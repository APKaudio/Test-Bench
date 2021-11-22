Imports System.Windows.Forms.DataVisualization.Charting



Module Rigol_FFT

    Public fftioManager As Ivi.Visa.Interop.ResourceManager

    Public RIGOL_MATH_FFT As Ivi.Visa.Interop.FormattedIO488

    Public Rigol_FFT_RAW_Data As String
    Public Rigol_FFT_SPLIT_Data() As String

    Public Rigol_FFT_DATA_TABLE As New DataTable("SCOPECH1")
    Public Rigol_FFT_DATA_SERIES As New Series

    Public Rigol_FFT_FrequencyScale(1200) As Double



    Public Sub Rigol_FFT_Config()
        RIGOL_MATH_FFT = New Ivi.Visa.Interop.FormattedIO488
        fftioManager = New Ivi.Visa.Interop.ResourceManager


        'Connecto to the scope
        Try
			RIGOL_MATH_FFT.IO = fftioManager.Open("TCPIP0::" & "44.10.54.1" & "::INSTR")    ' 10 is the instr. address 
			RIGOL_MATH_FFT.WriteString(":RUN")
            '       RIGOL_FFT_FORM.Rigol_FFT_Connect.BackColor = Color.Red
            Rigol_FFT_DATA_TABLE.Columns.Add("FREQUENCY")
            Rigol_FFT_DATA_TABLE.Columns.Add("FFT DATA")
        Catch ex As Exception
			MsgBox("Could no Connect to " & "44.44.44.44" & " Try again")
			'          RIGOL_FFT_FORM.Rigol_FFT_Connect.BackColor = Color.Transparent
		End Try


    End Sub

    Public Sub Get_FFT_data()
        CommandList("*******************")
        FFTConfigure()
        FFTStatus()
        FFTGetDataFrom()
        FFTGraph()

    End Sub


    Public Sub FFTConfigure()
        RIGOL_MATH_FFT.WriteString(":MATH:DISPlay on")
        RIGOL_MATH_FFT.WriteString(":Math:Reset")

        RIGOL_MATH_FFT.WriteString(":MATH:OPERator FFT")

        Dim FFT_Channel_Selected As String = RIGOL_FFT_FORM.FFT_Channel_Select.SelectedItem.ToString()
        RIGOL_MATH_FFT.WriteString(":MATH:FFT:SOURce CHAN" & FFT_Channel_Selected)

        Dim FFT_Window_type As String = RIGOL_FFT_FORM.FFT_Window_Type.SelectedItem.ToString()
        RIGOL_MATH_FFT.WriteString((":MATH:FFT:WINDow " & FFT_Window_type))
        RIGOL_MATH_FFT.WriteString(":MATH:FFT:UNIT DB")

        'FFT_Resolution
        RIGOL_MATH_FFT.WriteString(":MATH:FFT:HSCale " & RIGOL_FFT_FORM.FFT_Resolution.SelectedItem.ToString())
        RIGOL_MATH_FFT.WriteString(":MATH:FFT:HCENter " & RIGOL_FFT_FORM.FFT_H_Display_Center_f.Text)
    End Sub

    Public Sub FFTStatus()
        '*****************Check values after they have been changed to confirm 

        'check source and display it
        RIGOL_MATH_FFT.WriteString(":MATH:FFT:SOURce?")
        RIGOL_FFT_FORM.FFT_CH_SOURCE.Text = RIGOL_MATH_FFT.ReadString()


        'check FFT_H_Display_Center_f
        RIGOL_MATH_FFT.WriteString(":MATH:FFT:HCENter?")
        RIGOL_FFT_FORM.FFT_H_Display_Center_f_value.Text = RIGOL_MATH_FFT.ReadString()

        'check :MATH:FFT:HSCale?

        RIGOL_MATH_FFT.WriteString(":Math:FFT:HSCale?")
        RIGOL_FFT_FORM.FFT_H_Display_scale_f.Text = RIGOL_MATH_FFT.ReadString()

        'check FFT_WINDOWTYPE
        RIGOL_MATH_FFT.WriteString(":MATH:FFT:WINDow?")
        RIGOL_FFT_FORM.FFT_WINDOWTYPE.Text = RIGOL_MATH_FFT.ReadString()
    End Sub

    Public Sub FFTGetDataFrom()
        CommandList("FFT Get Data from WAVE")

        'Get data from FFT
        RIGOL_MATH_FFT.WriteString(":WAVeform:SOURce math ")
        RIGOL_MATH_FFT.WriteString(":WAVeform:FORmat ASCii")
        RIGOL_MATH_FFT.WriteString(":WAVeform:Data?")

        'Read the Data from the scope to local memory
        Rigol_FFT_RAW_Data = RIGOL_MATH_FFT.ReadString

        'Split up the Data
        Rigol_FFT_SPLIT_Data = Mid(Rigol_FFT_RAW_Data, 12).Split(",")

        Rigol_FFT_DATA_TABLE.Clear()

        CommandList("Data Length " & Rigol_FFT_SPLIT_Data.Length)

        'Move datasouce to the table
        RIGOL_FFT_FORM.Rigol_FFT_Data.DataSource = Rigol_FFT_DATA_TABLE

    End Sub

    Public Sub FFTGraph()

        'GRAPH THE FFT OUT

        'Clear the chart
        RIGOL_FFT_FORM.Rigol_FFT_Chart.Series.Clear()

        'Cleat the series and name it
        Rigol_FFT_DATA_SERIES.Points.Clear()
        Rigol_FFT_DATA_SERIES.Name = "Scope FFT"

        'Change to a line graph.
        Rigol_FFT_DATA_SERIES.ChartType = SeriesChartType.Line
        Rigol_FFT_DATA_SERIES.Color = Color.DarkOrange

        'set the x axis to be a divison of 12 as on the screen
        'Kinda works        RIGOL_FFT_FORM.Rigol_FFT_Chart.ChartAreas(0).AxisX.Interval = (Rigol_FFT_SPLIT_Data.Length / 12) * (CInt(RIGOL_FFT_FORM.FFT_Resolution.SelectedItem.ToString()))

        Dim FFT_HZperDiv As Double = (CInt(RIGOL_FFT_FORM.FFT_Resolution.SelectedItem.ToString()))
        CommandList("FFT_HZperDiv") '& FFT_HZperDiv)

        Dim FFT_center_f As Double = (CInt(RIGOL_FFT_FORM.FFT_H_Display_Center_f.Text))
        CommandList("FFT_center_f" & FFT_center_f)



        Dim FFT_starting_f As Double = FFT_center_f - (6 * FFT_HZperDiv)
        CommandList("FFT_starting_f" & FFT_starting_f)

        Dim FFT_ending_f As Double = FFT_center_f + (6 * FFT_HZperDiv)
        CommandList("FFT_ending_f" & FFT_ending_f)

        Dim FFT_Cycles_per_Division As Integer = (CInt(RIGOL_FFT_FORM.FFT_Resolution.SelectedItem.ToString()))
        CommandList("FFT_Cycles_per_Division" & FFT_Cycles_per_Division)


        Dim FFT_Number_of_Blank_Data_Points As Integer = (1200 - Rigol_FFT_SPLIT_Data.Length)
        CommandList("FFT_Number_of_Blank_Data_Points" & FFT_Number_of_Blank_Data_Points)
        'returns how many blank spaces before the data

        Dim fft_Cycles_Per_data_Point As Integer = FFT_Cycles_per_Division / 100
        CommandList("fft_Cycles_Per_data_Point" & fft_Cycles_Per_data_Point)

        Dim fft_offset_to_be_adde As Integer = fft_Cycles_Per_data_Point * FFT_Number_of_Blank_Data_Points
        CommandList("fft_offset_to_be_adde" & fft_offset_to_be_adde)

        FFT_starting_f = FFT_starting_f + fft_offset_to_be_adde
        CommandList("FFT_starting_f" & FFT_starting_f)

        'Dim FFT_incriment As Double = scale / 100
        'CommandList("FFT_incriment" & FFT_incriment)

        'Dim freqsubtracted As Double = fftoffset * FFT_incriment

        '        Dim offsetscaler As Double = (Rigol_FFT_SPLIT_Data.Length - fftoffset) / Rigol_FFT_SPLIT_Data.Length
        'RETURNS PERCENTAGE OF 



        RIGOL_FFT_FORM.Rigol_FFT_Chart.ChartAreas(0).AxisX.Interval = FFT_Cycles_per_Division / 1000

        '      RIGOL_FFT_FORM.Rigol_FFT_Chart.ChartAreas(0).AxisX.Int 'erval = Math.Round(((scale * offsetscaler) / 1000), 3)

        'adjust starting freq to actual number



        Rigol_FFT_FrequencyScale(0) = FFT_starting_f - fft_Cycles_Per_data_Point

        'Data at freq
        For I = 1 To ((Rigol_FFT_SPLIT_Data.Length - 1))

            Rigol_FFT_FrequencyScale(I) = Rigol_FFT_FrequencyScale(I - 1) + fft_Cycles_Per_data_Point
            Rigol_FFT_DATA_TABLE.Rows.Add(Rigol_FFT_FrequencyScale(I - 1), Rigol_FFT_SPLIT_Data(I - 1))

        Next I

        For I = 2 To (Rigol_FFT_SPLIT_Data.Length - 1)
            Rigol_FFT_DATA_SERIES.Points.AddXY(Rigol_FFT_FrequencyScale(I) / 1000, Rigol_FFT_SPLIT_Data(I))
        Next I





        'Convert Series to a chart
        RIGOL_FFT_FORM.Rigol_FFT_Chart.Series.Add(Rigol_FFT_DATA_SERIES)


    End Sub




End Module
