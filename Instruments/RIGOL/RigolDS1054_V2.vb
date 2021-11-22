Imports System.Windows.Forms.DataVisualization.Charting

Module Rigol_Scope


    Public RigolioMgr As Ivi.Visa.Interop.ResourceManager
    Public RIGOL_SCPI As Ivi.Visa.Interop.FormattedIO488

    Structure RigolScopeData
        Dim RawWaveData As String
        Dim SplitWaveData() As String
        Dim Vpp As Double
        Dim Vrms As Double
        Dim dBm As Double
        Dim Freq As Double
        Dim DataTable As DataTable
        Dim ScopeGraph_Series As Series
        Dim timebaseMainScale As Double
        Dim Scale As Double
        Dim AxisInterval As Double
        Dim IsConnected As Boolean
        Dim DelayOffset As Integer
    End Structure

    Public Rigol_CH(4) As RigolScopeData

    Public SecondsPerDivisionIncriments() As Double = {
        0.000000005,'5ns
        0.00000001, 0.00000002, 0.00000005,'10ns - 50ns
        0.0000001, 0.0000002, 0.0000005,'100ns -500ns
        0.000001, 0.000002, 0.000005,'1us - 5us
        0.00001, 0.00002, 0.00005,'10us - 50us
        0.0001, 0.0002, 0.0005,'100us - 500us
         0.001, 0.002, 0.005,'1ms - 5ms
         0.01, 0.02, 0.05,'10ms - 50ms
         0.1, 0.2, 0.5,'100ms - 500ms
         1, 2, 5,'1 - 5 seconds
         10, 20, 50} ' 10-50s





    Dim Rigol_Scope_TimeBase As Double






    '*****************************************************
    'RIGOL SCOPE CONNECTION CONFIGURATION
    Public Sub RIGOL_Connecttoscope(Channel As Integer)

        RIGOL_SCPI = New Ivi.Visa.Interop.FormattedIO488
        RigolioMgr = New Ivi.Visa.Interop.ResourceManager

        Try
            CommandList("RIGOL SCOPE CONNECTED")
			RIGOL_SCPI.IO = RigolioMgr.Open("TCPIP0::" & "44.10.54.1" & "::INSTR")    ' 10 is the instr. address 
			RIGOL_SCPI.WriteString(":RUN")
            Rigol_CH(Channel).IsConnected = True
        Catch ex As Exception
            CommandList("ERROR: RIGOL SCOPE NOT CONNECTED")

            Rigol_CH(Channel).IsConnected = False
        End Try


    End Sub

    'READ VITALS
    Public Sub Rigol_Read_Vitals(CHANNEL As Int16)
        If Rigol_CH(CHANNEL).IsConnected = True Then
			CommandList("Rigol_Read_Vitals" & CHANNEL)

			'   RIGOL_SCPI.WriteString("CHAN" & I & " : DISP ON")
			'Measure V Peak to peak
			RIGOL_SCPI.WriteString("MEASure:VPP? CHAN" & CHANNEL)
            Rigol_CH(CHANNEL).Vpp = RIGOL_SCPI.ReadString

            'Measure Vrms
            RIGOL_SCPI.WriteString("MEASure:VRMS? CHAN" & CHANNEL)
            Rigol_CH(CHANNEL).Vrms = RIGOL_SCPI.ReadString

            'Do match to make dBm relative to global refference
            Rigol_CH(CHANNEL).dBm = Math.Round(10 * Math.Log10((CDbl(Rigol_CH(CHANNEL).Vrms) ^ 2) / CDbl(UserInterfaceShell.Reff_Imp.Text) / (0.001)), 6)

            'Measure Frequency
            RIGOL_SCPI.WriteString("MEASure:FREQuency? CHAN" & CHANNEL)
            Rigol_CH(CHANNEL).Freq = RIGOL_SCPI.ReadString

            'Display Vpp
            Dim Rigol_Value_Vpp() As Control = UserInterfaceShell.Controls.Find("Rigol_Vpp_" & CHANNEL, 1)
            Rigol_Value_Vpp(0).Text = Rigol_CH(CHANNEL).Vpp

            'Display Vrms
            Dim Rigol_Value_Vrms() As Control = UserInterfaceShell.Controls.Find("Rigol_Vrms_" & CHANNEL, 1)
            Rigol_Value_Vrms(0).Text = Rigol_CH(CHANNEL).Vrms

            'Display dBm
            Dim Rigol_Value_dBm() As Control = UserInterfaceShell.Controls.Find("Rigol_dBm_" & CHANNEL, 1)
            Rigol_Value_dBm(0).Text = Rigol_CH(CHANNEL).dBm

            'Display Freq
            Dim Rigol_Value_freq() As Control = UserInterfaceShell.Controls.Find("Rigol_Freq_" & CHANNEL, 1)
            Rigol_Value_freq(0).Text = Rigol_CH(CHANNEL).Freq
        End If

    End Sub

    Public Sub Rigol_Horizontal_Offset(CHANNEL As Integer, Direction As Integer)
        'direction 1 is up  2 is down   0 is reset of offset

        If Direction = 1 Then
            Rigol_CH(CHANNEL).DelayOffset += 1

        ElseIf Direction = 2 Then
            Rigol_CH(CHANNEL).DelayOffset -= 1
        ElseIf Direction = 0 Then
            '

            Rigol_CH(CHANNEL).DelayOffset = 0

        End If



        Dim offset As Double = (Rigol_CH(CHANNEL).DelayOffset * Rigol_CH(CHANNEL).timebaseMainScale) / 100

        CommandList("DELAY OFFSET SEND" & Rigol_CH(CHANNEL).DelayOffset)
        CommandList("Offset send " & offset)
        RIGOL_SCPI.WriteString(":TIMebase:MAIN:OFFSet " & offset)

        '

        RIGOL_SCPI.WriteString(":TIMebase:MAIN:offset?")
        Dim shit As String = RIGOL_SCPI.ReadString()
        CommandList("DELAY OFFSET RECIEVE" & shit)

    End Sub

    Public Sub Rigol_Time_division(CHANNEL As Integer)
        If Rigol_CH(CHANNEL).IsConnected = True Then
            CommandList("Rigol_Time_division" & CHANNEL)
            'get time scale
            RIGOL_SCPI.WriteString(":TIMebase:MAIN:SCALe?")
            Rigol_CH(CHANNEL).timebaseMainScale = CDbl(RIGOL_SCPI.ReadString)


            CommandList("ENG NOTE" & ConvertToEngNotation(Rigol_CH(CHANNEL).timebaseMainScale))
            If Rigol_CH(CHANNEL).timebaseMainScale < 0.001 Then
                Rigol_CH(CHANNEL).Scale = 10 'mili
                CommandList("SCALE mili")
            ElseIf Rigol_CH(CHANNEL).timebaseMainScale < 0.000001 Then ' micro
                Rigol_CH(CHANNEL).Scale = 10000
                CommandList("SCALE micro")
            Else
                Rigol_CH(CHANNEL).Scale = 1
                CommandList("SCALE second")
            End If
        End If

    End Sub


    'COLLECT DATA AND PUT IT IN CHART
    Public Sub RigolData_Fetch(Channel As Integer)
        If Rigol_CH(Channel).IsConnected = True Then
            CommandList("RigolData_Fetch" & Channel)
            Dim tempDataTable As New DataTable("SCOPE CH" & Channel)


            tempDataTable.Columns.Clear()


            RIGOL_SCPI.WriteString(":WAVeform:SOURce CHANnel" & Channel)
            RIGOL_SCPI.WriteString(":WAV:POIN:MODE RAW")
            RIGOL_SCPI.WriteString(":WAVeform:FORmat ASCii")
            RIGOL_SCPI.WriteString(":WAV:DATA?")



            'Read the Data from the scope to local memory
            Rigol_CH(Channel).RawWaveData = RIGOL_SCPI.ReadString

            'Split up the Data
            Rigol_CH(Channel).SplitWaveData = Mid(Rigol_CH(Channel).RawWaveData, 12).Split(",")

            'add column of data

            tempDataTable.Columns.Add("SCOPE " & Channel)

            For I = 0 To ((Rigol_CH(Channel).SplitWaveData.Length) - 1)
                tempDataTable.Rows.Add(Rigol_CH(Channel).SplitWaveData(I))
            Next I

            'set datasource of dgv to be table

            Rigol_CH(Channel).DataTable = tempDataTable
        End If

    End Sub


    'PLOT THE DATA
    Public Sub Rigol_Plot_Chart(Channel As Integer)
        If Rigol_CH(Channel).IsConnected = True Then
            CommandList("Rigol_Plot_Chart" & Channel)
            Dim TEMPseries As New Series

            TEMPseries.Name = "Scope " & Channel

            'Change to a line graph.
            TEMPseries.ChartType = SeriesChartType.Spline
            TEMPseries.Color = Color.DarkOrange

            Rigol_Time_division(Channel)

            Dim TotalDataPoints As Double = Rigol_CH(Channel).SplitWaveData.Length
            CommandList("TotalDataPoints:" & TotalDataPoints)

            Dim SecondsPerDivision As Double = Rigol_CH(Channel).timebaseMainScale
            CommandList("SecondsPerDivision:" & SecondsPerDivision)

            Dim SecondsPerDatatPoint As Double = (SecondsPerDivision * 12) / TotalDataPoints
            CommandList("SecondsPerDivision:" & SecondsPerDatatPoint)

            Dim PointsPerDivision As Integer = 100

            For I = 0 To ((TotalDataPoints) - 1)
                TEMPseries.Points.AddXY(
               ((I + 1) * SecondsPerDatatPoint * Rigol_CH(Channel).Scale), Rigol_CH(Channel).SplitWaveData(I))
            Next

            'Move the temp series to the Channel 
            Rigol_CH(Channel).ScopeGraph_Series = TEMPseries

            'set the x axis divisions
            Rigol_CH(Channel).AxisInterval = (SecondsPerDatatPoint * PointsPerDivision * Rigol_CH(Channel).Scale)
            CommandList("axis interval:" & Rigol_CH(Channel).AxisInterval)
        End If
    End Sub


    'GET ALL SCOPE DATA

    Public Sub Rigol_ChangeDivision(ScopeDivisionVaule As Double)

        CommandList("ScopeDivisionVaule" & ScopeDivisionVaule)
        CommandList("SecondsPerDivision" & SecondsPerDivisionIncriments(ScopeDivisionVaule))

        Try
            RIGOL_SCPI.WriteString(":TIMebase:MAIN:SCALe " & SecondsPerDivisionIncriments(ScopeDivisionVaule))

        Catch ex As Exception

        End Try


    End Sub


    Public Sub BandwidthLimitChange(Channel As Integer, BandwidthLimit As Boolean)

        If Rigol_CH(Channel).IsConnected = True Then

            If BandwidthLimit Then
                RIGOL_SCPI.WriteString(":CHANnel" & Channel & ":BWLimit 20M")
            Else
                RIGOL_SCPI.WriteString(":CHANnel" & Channel & ":BWLimit OFF")
            End If
        End If
    End Sub


    Public Sub ChannelCoupling(Channel As Integer, CouplingMode As String)

        If Rigol_CH(Channel).IsConnected = True Then
            If CouplingMode = "AC" Then
                RIGOL_SCPI.WriteString(":CHANnel" & Channel & ":COUPling AC")
            ElseIf CouplingMode = "DC" Then
                RIGOL_SCPI.WriteString(":CHANnel" & Channel & ":COUPling DC")
            ElseIf CouplingMode = "GND" Then
                RIGOL_SCPI.WriteString(":CHANnel" & Channel & ":COUPling GND")
            End If
        End If

    End Sub


    Public Sub Rigol_ReadandDisplay_CH1()
        If Rigol_CH(1).IsConnected = True Then
            CommandList("Rigol_ReadandDisplay_CH1")

            'Clear the Chart and series of chart
            RIGOLSCOPE_FORM_1.Rigol_Chart.Series.Dispose()
            RIGOLSCOPE_FORM_1.Rigol_Chart.Series.Clear()

            'Function call 
            Rigol_Read_Vitals(1)
            RigolData_Fetch(1)
            Rigol_Plot_Chart(1)

            'Clear the chart
            RIGOLSCOPE_FORM_1.Rigol_Data_Grid.DataSource = Rigol_CH(1).DataTable
            RIGOLSCOPE_FORM_1.Rigol_Chart.Series.Add(Rigol_CH(1).ScopeGraph_Series)

            'Set the devision interval
            RIGOLSCOPE_FORM_1.Rigol_Chart.ChartAreas(0).AxisX.Interval = (Rigol_CH(1).AxisInterval)

            'Set the max an minumim of the 
            RIGOLSCOPE_FORM_1.Rigol_Chart.ChartAreas(0).AxisX.Minimum = 0
            RIGOLSCOPE_FORM_1.Rigol_Chart.ChartAreas(0).AxisX.Maximum = (Rigol_CH(1).AxisInterval) * 12
        End If
    End Sub

    Public Sub Rigol_ReadandDisplay_CH2()
        CommandList("Rigol_ReadandDisplay_CH2")
        Rigol_Read_Vitals(2)
        RigolData_Fetch(2)
        Rigol_Plot_Chart(2)

        RIGOLSCOPE_FORM_2.Rigol_Data_Grid.DataSource = Rigol_CH(2).DataTable
        RIGOLSCOPE_FORM_2.Rigol_Chart.Series.Clear()
        RIGOLSCOPE_FORM_2.Rigol_Chart.ChartAreas(0).AxisX.Interval = Rigol_CH(2).AxisInterval
        RIGOLSCOPE_FORM_2.Rigol_Chart.Series.Add(Rigol_CH(2).ScopeGraph_Series)
    End Sub

    Public Sub Rigol_ReadandDisplay_CH3()
        CommandList("Rigol_ReadandDisplay_CH3")
        Rigol_Read_Vitals(3)
        RigolData_Fetch(3)
        Rigol_Plot_Chart(3)

        RIGOLSCOPE_FORM_3.Rigol_Data_Grid.DataSource = Rigol_CH(3).DataTable
        RIGOLSCOPE_FORM_3.Rigol_Chart.Series.Clear()
        RIGOLSCOPE_FORM_3.Rigol_Chart.ChartAreas(0).AxisX.Interval = Rigol_CH(3).AxisInterval
        RIGOLSCOPE_FORM_3.Rigol_Chart.Series.Add(Rigol_CH(3).ScopeGraph_Series)
    End Sub

    Public Sub Rigol_ReadandDisplay_CH4()
        CommandList("Rigol_ReadandDisplay_CH4")
        Rigol_Read_Vitals(4)
        RigolData_Fetch(4)
        Rigol_Plot_Chart(4)

        RIGOLSCOPE_FORM_4.Rigol_Data_Grid.DataSource = Rigol_CH(4).DataTable
        RIGOLSCOPE_FORM_4.Rigol_Chart.Series.Clear()
        RIGOLSCOPE_FORM_4.Rigol_Chart.ChartAreas(0).AxisX.Interval = Rigol_CH(4).AxisInterval
        RIGOLSCOPE_FORM_4.Rigol_Chart.Series.Add(Rigol_CH(4).ScopeGraph_Series)
    End Sub

    Public Sub Rigol_autoscale()
        RIGOL_SCPI.WriteString(":AUToscale")
    End Sub



End Module

