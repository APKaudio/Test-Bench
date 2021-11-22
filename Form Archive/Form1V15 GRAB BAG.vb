
Imports System.Windows.Forms.DataVisualization.Charting


Public Class UserInterface

    Public ioMgr As Ivi.Visa.Interop.ResourceManager


    Public DMM1 As Ivi.Visa.Interop.FormattedIO488
    Public DMM2 As Ivi.Visa.Interop.FormattedIO488
    Public DMM3 As Ivi.Visa.Interop.FormattedIO488
    Public DMM4 As Ivi.Visa.Interop.FormattedIO488

    Public DMM1Mode As String
    Public DMM2Mode As String
    Public DMM3Mode As String
    Public DMM4Mode As String


    Public AudioAnalyzer As Ivi.Visa.Interop.FormattedIO488

    Public Ocilliscope As Ivi.Visa.Interop.FormattedIO488


    '    Public SignalGen As Ivi.Visa.Interop.FormattedIO488

    '  Public RIGOL As Ivi.Visa.Interop.FormattedIO488

    Public DataCollectionTable As New DataTable("CollectedData")






    Dim FFT_X_Value As Double
    Dim FFT_Y_Value As Double



    Public Sub Form1_closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        If PSU_Enable.Checked = True Then
            PSUOFF()
        End If

        If DMM_Enable_1.Checked = True Then
            DMM1.WriteString("DISP:TEXT ""HAVE"" ")
        End If

        If DMM_Enable_2.Checked = True Then
            DMM2.WriteString("DISP:TEXT ""A"" ")
        End If

        If DMM_Enable_3.Checked = True Then
            DMM3.WriteString("DISP:TEXT ""GOOD"" ")
        End If

        If DMM_Enable_4.Checked = True Then
            DMM4.WriteString("DISP:TEXT ""DAY Eh"" ")
        End If
    End Sub




    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RigolIPAddresFFT.TabIndex = 3

        'set combobox default value
        FFT_Window_Type.SelectedIndex = 0
        FFT_Channel_Select.SelectedIndex = 0
        FFT_Resolution.SelectedIndex = 0

        ioMgr = New Ivi.Visa.Interop.ResourceManager

        DMM1 = New Ivi.Visa.Interop.FormattedIO488
        DMM2 = New Ivi.Visa.Interop.FormattedIO488
        DMM3 = New Ivi.Visa.Interop.FormattedIO488
        DMM4 = New Ivi.Visa.Interop.FormattedIO488

        AudioAnalyzer = New Ivi.Visa.Interop.FormattedIO488

        Ocilliscope = New Ivi.Visa.Interop.FormattedIO488

        PSU = New Ivi.Visa.Interop.FormattedIO488

        SignalGen = New Ivi.Visa.Interop.FormattedIO488





    End Sub

    Private Sub AssignAddress()
        If DMM_Enable_1.Checked = True Then
            DMM1.IO = ioMgr.Open(("TCPIP0::" & IPaddress.Text & "::" & gpibAddress.Text & "," & CDec(DMM_gpib_1.Text) & "::INSTR"))    ' 10 is the instr. address 
        End If

        If DMM_Enable_2.Checked = True Then
            DMM2.IO = ioMgr.Open(("TCPIP0::" & IPaddress.Text & "::" & gpibAddress.Text & "," & CDec(DMM_gpib_2.Text) & "::INSTR"))    ' 10 is the instr. address 
        End If

        If DMM_Enable_3.Checked = True Then
            DMM3.IO = ioMgr.Open(("TCPIP0::" & IPaddress.Text & "::" & gpibAddress.Text & "," & CDec(DMM_gpib_3.Text) & "::INSTR"))    ' 10 is the instr. address 
        End If

        If DMM_Enable_4.Checked = True Then
            DMM4.IO = ioMgr.Open(("TCPIP0::" & IPaddress.Text & "::" & gpibAddress.Text & "," & CDec(DMM_gpib_4.Text) & "::INSTR"))    ' 10 is the instr. address 
        End If
        If Analyzer_Enable.Checked = True Then
            AudioAnalyzer.IO = ioMgr.Open(("TCPIP0::" & IPaddress.Text & "::" & gpibAddress.Text & "," & CDec(AudioAnalyzer_gpib.Text) & "::INSTR"))    ' 10 is the instr. address 
        End If

        If Scope_Enable.Checked = True Then
            Ocilliscope.IO = ioMgr.Open(("TCPIP0::" & IPaddress.Text & "::" & gpibAddress.Text & "," & CDec(Ocilliscope_gpib.Text) & "::INSTR"))    ' 10 is the instr. address 
        End If

        If PSU_Enable.Checked = True Then
            PSU.IO = ioMgr.Open(("TCPIP0::" & IPaddress.Text & "::" & gpibAddress.Text & "," & CDec(PSU_gpib.Text) & "::INSTR"))    ' 10 is the instr. address 

        End If

        If SigGen_Enable.Checked = True Then
            SignalGen.IO = ioMgr.Open(("TCPIP0::" & IPaddress.Text & "::" & gpibAddress.Text & "," & CDec(SignalGen_gpib.Text) & "::INSTR"))    ' 10 is the instr. address 
        End If



    End Sub
    Private Sub NameDevices_Click(sender As Object, e As EventArgs) Handles NameDevices.Click

        AssignAddress()


        If DMM_Enable_1.Checked = True Then

            DMM1.WriteString("DISP:TEXT """ & DMM_Name_1.Text & """")
            DMMLabel1.Text = DMM_Name_1.Text
        End If

        If DMM_Enable_2.Checked = True Then
            DMM2.WriteString("DISP:TEXT """ & DMM_Name_2.Text & """")
            DMMLabel2.Text = DMM_Name_2.Text
        End If

        If DMM_Enable_3.Checked = True Then
            DMM3.WriteString("DISP:TEXT """ & DMM_Name_3.Text & """")
            DMMLabel3.Text = DMM_Name_3.Text
        End If

        If DMM_Enable_4.Checked = True Then
            DMM4.WriteString("DISP:TEXT """ & DMM_Name_4.Text & """")
            DMMLabel4.Text = DMM_Name_4.Text
        End If

        If Analyzer_Enable.Checked = True Then
            AudioAnalyzer.WriteString("21.0 SP")
        End If

        ''Ocilliscope.WriteString("DISP:TEXT """ & Ocilliscope_name.Text & """")


        If PSU_Enable.Checked = True Then
            PSU.WriteString("DISP:TEXT """ & PSU_name.Text & """")
        End If

        If SigGen_Enable.Checked = True Then
            SignalGen.WriteString("DISP:TEXT """ & SignalGen_name.Text & """")
        End If

        'Set to default 
        DMM_function_1.SelectedIndex = 0
        DMM_function_2.SelectedIndex = 0
        DMM_function_3.SelectedIndex = 0
        DMM_function_4.SelectedIndex = 0

        SigGen_Signal_Type.SelectedIndex = 0
        SigGen_Amp_unit.SelectedIndex = 0






    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BUT_READ_DMM.Click
        DMM_Read_1()
        DMM_Read_2()
        DMM_Read_3()
        DMM_Read_4()
    End Sub

    Public Sub DMM_Config_1()


        DMM1.WriteString("*RST")
        If DMM_function_1.SelectedIndex = 0 Then
            DMM1Mode = "MEAS:VOLT:DC?"
            ' 1 I DC
        ElseIf DMM_function_1.SelectedIndex = 1 Then
            DMM1Mode = "MEAS:CURR:DC?"
            '2 V AC
        ElseIf DMM_function_1.SelectedIndex = 2 Then
            DMM1Mode = "MEAS:VOLT:AC?"
            '3 I AC
        ElseIf DMM_function_1.SelectedIndex = 3 Then
            DMM1Mode = "MEAS:CURR:AC?"
            '4 R 2W
        ElseIf DMM_function_1.SelectedIndex = 4 Then
            DMM1Mode = "MEAS:RES?"
            '5 R 4W
        ElseIf DMM_function_1.SelectedIndex = 5 Then
            DMM1Mode = "MEAS:FRES?"
            '6 Diode
        ElseIf DMM_function_1.SelectedIndex = 6 Then
            DMM1Mode = "MEAS:DIODe?"
            '7 Capacitance
        ElseIf DMM_function_1.SelectedIndex = 7 Then
            DMM1Mode = "MEAS:FREQuency?"
            '8 Freq
        ElseIf DMM_function_1.SelectedIndex = 8 Then
            DMM1Mode = "MEAS:FREQuency?"
            '9 Period
        ElseIf DMM_function_1.SelectedIndex = 9 Then
            DMM1Mode = "MEAS:PERiod?"
            '10 Continuity
        ElseIf DMM_function_1.SelectedIndex = 10 Then
            DMM1Mode = "MEAS:CONTinuity?"
        End If


    End Sub
    Public Sub DMM_Config_2()


        DMM2.WriteString("*RST")
        If DMM_function_2.SelectedIndex = 0 Then
            DMM2Mode = "MEAS:VOLT:DC?"
            ' 1 I DC
        ElseIf DMM_function_2.SelectedIndex = 1 Then
            DMM2Mode = "MEAS:CURR:DC?"
            '2 V AC
        ElseIf DMM_function_2.SelectedIndex = 2 Then
            DMM2Mode = "MEAS:VOLT:AC?"
            '3 I AC
        ElseIf DMM_function_2.SelectedIndex = 3 Then
            DMM2Mode = "MEAS:CURR:AC?"
            '4 R 2W
        ElseIf DMM_function_2.SelectedIndex = 4 Then
            DMM2Mode = "MEAS:RES?"
            '5 R 4W
        ElseIf DMM_function_2.SelectedIndex = 5 Then
            DMM2Mode = "MEAS:FRES?"
            '6 Diode
        ElseIf DMM_function_2.SelectedIndex = 6 Then
            DMM2Mode = "MEAS:DIODe?"
            '7 Capacitance
        ElseIf DMM_function_2.SelectedIndex = 7 Then
            DMM2Mode = "MEAS:FREQuency?"
            '8 Freq
        ElseIf DMM_function_2.SelectedIndex = 8 Then
            DMM2Mode = "MEAS:FREQuency?"
            '9 Period
        ElseIf DMM_function_2.SelectedIndex = 9 Then
            DMM2Mode = "MEAS:PERiod?"
            '10 Continuity
        ElseIf DMM_function_2.SelectedIndex = 10 Then
            DMM2Mode = "MEAS:CONTinuity?"
        End If


    End Sub
    Public Sub DMM_Config_3()


        DMM3.WriteString("*RST")
        If DMM_function_3.SelectedIndex = 0 Then
            DMM3Mode = "MEAS:VOLT:DC?"
            ' 1 I DC
        ElseIf DMM_function_3.SelectedIndex = 1 Then
            DMM3Mode = "MEAS:CURR:DC?"
            '2 V AC
        ElseIf DMM_function_3.SelectedIndex = 2 Then
            DMM3Mode = "MEAS:VOLT:AC?"
            '3 I AC
        ElseIf DMM_function_3.SelectedIndex = 3 Then
            DMM3Mode = "MEAS:CURR:AC?"
            '4 R 2W
        ElseIf DMM_function_3.SelectedIndex = 4 Then
            DMM3Mode = "MEAS:RES?"
            '5 R 4W
        ElseIf DMM_function_3.SelectedIndex = 5 Then
            DMM3Mode = "MEAS:FRES?"
            '6 Diode
        ElseIf DMM_function_3.SelectedIndex = 6 Then
            DMM3Mode = "MEAS:DIODe?"
            '7 Capacitance
        ElseIf DMM_function_3.SelectedIndex = 7 Then
            DMM3Mode = "MEAS:FREQuency?"
            '8 Freq
        ElseIf DMM_function_3.SelectedIndex = 8 Then
            DMM3Mode = "MEAS:FREQuency?"
            '9 Period
        ElseIf DMM_function_3.SelectedIndex = 9 Then
            DMM3Mode = "MEAS:PERiod?"
            '10 Continuity
        ElseIf DMM_function_3.SelectedIndex = 10 Then
            DMM3Mode = "MEAS:CONTinuity?"
        End If


    End Sub
    Public Sub DMM_Config_4()

        DMM4.WriteString("*RST")

        If DMM_function_4.SelectedIndex = 0 Then
            DMM4Mode = "MEAS:VOLT:DC?"
            ' 1 I DC
        ElseIf DMM_function_4.SelectedIndex = 1 Then
            DMM4Mode = "MEAS:CURR:DC?"
            '2 V AC
        ElseIf DMM_function_4.SelectedIndex = 2 Then
            DMM4Mode = "MEAS:VOLT:AC?"
            '3 I AC
        ElseIf DMM_function_4.SelectedIndex = 3 Then
            DMM4Mode = "MEAS:CURR:AC?"
            '4 R 2W
        ElseIf DMM_function_4.SelectedIndex = 4 Then
            DMM4Mode = "MEAS:RES?"
            '5 R 4W
        ElseIf DMM_function_4.SelectedIndex = 5 Then
            DMM4Mode = "MEAS:FRES?"
            '6 Diode
        ElseIf DMM_function_4.SelectedIndex = 6 Then
            DMM4Mode = "MEAS:DIODe?"
            '7 Capacitance
        ElseIf DMM_function_4.SelectedIndex = 7 Then
            DMM4Mode = "MEAS:FREQuency?"
            '8 Freq
        ElseIf DMM_function_4.SelectedIndex = 8 Then
            DMM4Mode = "MEAS:FREQuency?"
            '9 Period
        ElseIf DMM_function_4.SelectedIndex = 9 Then
            DMM4Mode = "MEAS:PERiod?"
            '10 Continuity
        ElseIf DMM_function_4.SelectedIndex = 10 Then
            DMM4Mode = "MEAS:CONTinuity?"
        End If


    End Sub

    Public Sub DMM_Read_1()

        If DMM_Enable_1.Checked = True Then
            'read the value

            DMM1.WriteString(DMM1Mode)
            Dim DMM1ReadNumber = DMM1.ReadNumber()


            DMM_Value_1.Text = CDbl(DMM1ReadNumber)

            'if it's Vac calculate dBm
            If DMM_function_1.SelectedIndex = 2 Then
                DMM_dbm_1.Text = 10 * Math.Log10((CDbl((DMM1ReadNumber) ^ 2) / CDbl(dBm_ref_imp.Text)) / (0.001))
            Else
                DMM_dbm_1.Text = ""
            End If
        End If

    End Sub
    Public Sub DMM_Read_2()
        If DMM_Enable_2.Checked = True Then


            DMM2.WriteString(DMM2Mode)
            Dim DMM2ReadNumber = DMM2.ReadNumber()

            DMM_Value_2.Text = CDbl(DMM2ReadNumber)

            'if it's Vac calculate dBm
            If DMM_function_2.SelectedIndex = 2 Then
                DMM_dbm_2.Text = 10 * Math.Log10((CDbl(DMM2ReadNumber) ^ 2) / CDbl(dBm_ref_imp.Text) / (0.001))
            Else
                DMM_dbm_2.Text = ""
            End If
        End If

    End Sub
    Public Sub DMM_Read_3()
        If DMM_Enable_3.Checked = True Then

            DMM3.WriteString(DMM3Mode)
            Dim DMM3ReadNumber = DMM3.ReadNumber()
            'read the value
            DMM_Value_3.Text = CDbl(DMM3ReadNumber)

            'if it's Vac calculate dBm
            If DMM_function_3.SelectedIndex = 2 Then
                DMM_dbm_3.Text = 10 * Math.Log10((CDbl(DMM3ReadNumber) ^ 2) / CDbl(dBm_ref_imp.Text) / (0.001))
            Else
                DMM_dbm_3.Text = ""
            End If
        End If

    End Sub
    Public Sub DMM_Read_4()
        If DMM_Enable_4.Checked = True Then

            DMM4.WriteString(DMM4Mode)

            Dim DMM4ReadNumber = DMM4.ReadNumber()

            'read the value
            DMM_Value_4.Text = CDbl(DMM4ReadNumber)

            'if it's Vac calculate dBm
            If DMM_function_4.SelectedIndex = 2 Then
                DMM_dbm_4.Text = CDbl(10 * Math.Log10((CDbl(DMM4ReadNumber) ^ 2) / CDbl(dBm_ref_imp.Text) / (0.001)))
            Else
                DMM_dbm_4.Text = ""
            End If
        End If


        End Sub7

    Private Sub DMM_function_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DMM_function_1.SelectedIndexChanged
        If DMM_Enable_1.Checked = True Then
            DMM_Config_1()
            DMM_Read_1()
        End If

    End Sub
    Private Sub DMM_function_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DMM_function_2.SelectedIndexChanged
        If DMM_Enable_2.Checked = True Then
            DMM_Config_2()
            DMM_Read_2()
        End If

    End Sub
    Private Sub DMM_function_3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DMM_function_3.SelectedIndexChanged
        If DMM_Enable_3.Checked = True Then
            DMM_Config_3()
            DMM_Read_3()
        End If

    End Sub
    Private Sub DMM_function_4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DMM_function_4.SelectedIndexChanged
        If DMM_Enable_4.Checked = True Then
            DMM_Config_4()
            DMM_Read_4()
        End If

    End Sub




    'AA
    Private Sub DistortionChange_Click(sender As Object, e As EventArgs) Handles DistortionChange.Click
        AudioAnalyzer.WriteString("CL")


        AudioAnalyzer.WriteString("FR " & Dist_freq.Text & " HZ")
        AudioAnalyzer.WriteString("AP " & Dist_Amp.Text & " VL")

        'Dist_Dist_measure_DSTN
        ''AudioAnalyzer.WriteString("S31")

        'hold


        AudioAnalyzer.WriteString("RR")
        '      Dist_measure_DSTN.Text = AudioAnalyzer.ReadString()
        'Dist_measure_SINAD
        ' AudioAnalyzer.WriteString("M2")
        ' Dist_measure_SINAD.Text = AudioAnalyzer.ReadNumber()


        'Dist_measure_Voltage
        '  AudioAnalyzer.WriteString("MV")
        '   Dist_measure_Voltage.Text = AudioAnalyzer.ReadNumber()




    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles ReadValues.Tick
        If PSU_Enable.Checked = True Then
            ReadPSUValue()
        End If

        If DMM_Enable_1.Checked = True Then
            DMM_Read_1()
        End If

        If DMM_Enable_2.Checked = True Then
            DMM_Read_2()
        End If

        If DMM_Enable_3.Checked = True Then
            DMM_Read_3()
        End If

        If DMM_Enable_4.Checked = True Then
            DMM_Read_4()
        End If

        If Scope_Enable.Checked = True Then
            GetScopeData()
        End If

        CollectData()
    End Sub

    Private Sub TMRENA_Click(sender As Object, e As EventArgs) Handles TMRENA.Click
        If TMRENA.Text = "START" Then
            TMRENA.Text = "RUNNING"
            ReadValues.Enabled = True
        ElseIf TMRENA.Text = "RUNNING" Then
            TMRENA.Text = "START"
            ReadValues.Enabled = False
        End If
    End Sub





    Private Sub Scope_Autoscale_Click(sender As Object, e As EventArgs) Handles Scope_Autoscale.Click
        AutoScaleScope()
        GetScopeData()
    End Sub


    Public Sub GetScopeData()
        Ocilliscope.WriteString(":MEAS:VPP? CHAN1")
        SCOPE_Vpp_1.Text = CDbl(Ocilliscope.ReadString)
        Ocilliscope.WriteString(":MEAS:VRMS? CHAN1")
        SCOPE_Vrms_1.Text = CDbl(Ocilliscope.ReadString)
        Ocilliscope.WriteString(":MEAS:FREQ? CHAN1")
        SCOPE_FREQ_1.Text = CDbl(Ocilliscope.ReadString)
        SCOPE_dBm_1.Text = CDbl(10 * Math.Log10((CDbl(SCOPE_Vrms_1.Text) ^ 2) / CDbl(dBm_ref_imp.Text) / (0.001)))



        Ocilliscope.WriteString(":MEAS:VPP? CHAN2")
        SCOPE_Vpp_2.Text = CDbl(Ocilliscope.ReadString)
        Ocilliscope.WriteString(":MEAS:VRMS? CHAN2")
        SCOPE_Vrms_2.Text = CDbl(Ocilliscope.ReadString)
        Ocilliscope.WriteString(":MEAS:FREQ? CHAN2")
        SCOPE_FREQ_2.Text = CDbl(Ocilliscope.ReadString)
        SCOPE_dBm_2.Text = CDbl(10 * Math.Log10((CDbl(SCOPE_Vrms_2.Text) ^ 2) / CDbl(dBm_ref_imp.Text) / (0.001)))


        SCOPE_dBm_diff.Text = CDbl(SCOPE_dBm_2.Text) - CDbl(SCOPE_dBm_1.Text)
        Ocilliscope.WriteString(":MEAS:PHAS? CHAN1, CHAN2")
        SCOPE_Phase.Text = CDbl(Ocilliscope.ReadString)



    End Sub


    Public Sub AutoScaleScope()
        Ocilliscope.WriteString("AUToscale")




    End Sub



    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Dim b As Byte() = {&HF0, &H7F}











    Public Sub CollectData()

        DataCollectionTable.Rows.Add(DateAndTime.DateString & " " & DateAndTime.TimeOfDay, Measurement.Text, SigGen_Sine_freq.Text, SigGen_amp.Text,
                                     DMM_Value_1.Text, DMM_dbm_1.Text,
                                     DMM_Value_2.Text, DMM_dbm_2.Text,
                                     DMM_Value_3.Text, DMM_dbm_3.Text,
                                     DMM_Value_4.Text, DMM_dbm_4.Text,
                                      PSU_READ_V_1.Text, PSU_READ_V_2.Text, PSU_READ_V_3.Text, PSU_READ_V_4.Text,
                                     PSU_READ_I_1.Text, PSU_READ_I_2.Text, PSU_READ_I_3.Text, PSU_READ_I_4.Text,
                                          SCOPE_Vpp_1.Text, SCOPE_Vrms_1.Text,
    SCOPE_dBm_1.Text, SCOPE_FREQ_1.Text,
          SCOPE_Vpp_2.Text, SCOPE_Vrms_2.Text,
    SCOPE_dBm_2.Text, SCOPE_FREQ_2.Text,
        SCOPE_dBm_diff.Text, SCOPE_Phase.Text)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CreatTable()
    End Sub


    Public Sub CreatTable()
        'Creat Table Colums

        DataCollectionTable.Reset()

        DataCollectionTable.Columns.Add("DATE and TIME")

        DataCollectionTable.Columns.Add(Measurement.Text)

        DataCollectionTable.Columns.Add(SigGen_Signal_Type.SelectedItem.ToString & "(HZ)", GetType(String))
        DataCollectionTable.Columns.Add("Ampl " & SigGen_Amp_unit.SelectedItem.ToString, GetType(String))

        DataCollectionTable.Columns.Add(DMMLabel1.Text & " " & DMM1Mode, GetType(String))
        DataCollectionTable.Columns.Add(DMMLabel1.Text & " " & " (dBm)", GetType(String))

        DataCollectionTable.Columns.Add(DMMLabel2.Text & " " & DMM2Mode, GetType(String))
        DataCollectionTable.Columns.Add(DMMLabel2.Text & " " & " (dBm)", GetType(String))

        DataCollectionTable.Columns.Add(DMMLabel3.Text & " " & DMM3Mode, GetType(String))
        DataCollectionTable.Columns.Add(DMMLabel3.Text & " " & " (dBm)", GetType(String))

        DataCollectionTable.Columns.Add(DMMLabel4.Text & " " & DMM4Mode, GetType(String))
        DataCollectionTable.Columns.Add(DMMLabel4.Text & " " & " (dBm)", GetType(String))

        DataCollectionTable.Columns.Add(PSULabel1.Text & " (V)", GetType(String))
        DataCollectionTable.Columns.Add(PSULabel2.Text & " (V)", GetType(String))
        DataCollectionTable.Columns.Add(PSULabel3.Text & " (V)", GetType(String))
        DataCollectionTable.Columns.Add(PSULabel4.Text & " (V)", GetType(String))

        DataCollectionTable.Columns.Add(PSULabel1.Text & " (A)", GetType(String))
        DataCollectionTable.Columns.Add(PSULabel2.Text & " (A)", GetType(String))
        DataCollectionTable.Columns.Add(PSULabel3.Text & " (A)", GetType(String))
        DataCollectionTable.Columns.Add(PSULabel4.Text & " (A)", GetType(String))

        DataCollectionTable.Columns.Add("Scope 1 (Vpp)", GetType(String))
        DataCollectionTable.Columns.Add("Scope 1 (Vrms)", GetType(String))
        DataCollectionTable.Columns.Add("Scope 1 (dBm)", GetType(String))
        DataCollectionTable.Columns.Add("Scope 1 (Hz)", GetType(String))

        DataCollectionTable.Columns.Add("Scope 2 (Vpp)", GetType(String))
        DataCollectionTable.Columns.Add("Scope 2 (Vrms)", GetType(String))
        DataCollectionTable.Columns.Add("Scope 2 (dBm)", GetType(String))
        DataCollectionTable.Columns.Add("Scope 2 (Hz)", GetType(String))

        DataCollectionTable.Columns.Add("SCOPE dBm diff 1-2", GetType(String))
        DataCollectionTable.Columns.Add("SCOPE Phase diff 1-2", GetType(String))

        DataGridView.DataSource = DataCollectionTable
    End Sub





    'Disable Buttons
    Private Sub DMM_Enable_1_CheckedChanged(sender As Object, e As EventArgs) Handles DMM_Enable_1.CheckedChanged
        If DMM_Enable_1.Checked = True Then
            DMM_gpib_1.Enabled = True
            DMM_Name_1.Enabled = True
            DMM_function_1.Enabled = True
            DMM_Value_1.Enabled = True
            DMM_dbm_1.Enabled = True
        Else
            DMM_gpib_1.Enabled = False
            DMM_Name_1.Enabled = False
            DMM_function_1.Enabled = False
            DMM_Value_1.Enabled = False
            DMM_dbm_1.Enabled = False
        End If
    End Sub

    Private Sub DMM_Enable_2_CheckedChanged(sender As Object, e As EventArgs) Handles DMM_Enable_2.CheckedChanged
        If DMM_Enable_2.Checked = True Then
            DMM_gpib_2.Enabled = True
            DMM_Name_2.Enabled = True
            DMM_function_2.Enabled = True
            DMM_Value_2.Enabled = True
            DMM_dbm_2.Enabled = True
        Else
            DMM_gpib_2.Enabled = False
            DMM_Name_2.Enabled = False
            DMM_function_2.Enabled = False
            DMM_Value_2.Enabled = False
            DMM_dbm_2.Enabled = False
        End If
    End Sub

    Private Sub DMM_Enable_3_CheckedChanged(sender As Object, e As EventArgs) Handles DMM_Enable_3.CheckedChanged
        If DMM_Enable_3.Checked = True Then
            DMM_gpib_3.Enabled = True
            DMM_Name_3.Enabled = True
            DMM_function_3.Enabled = True
            DMM_Value_3.Enabled = True
            DMM_dbm_3.Enabled = True
        Else
            DMM_gpib_3.Enabled = False
            DMM_Name_3.Enabled = False
            DMM_function_3.Enabled = False
            DMM_Value_3.Enabled = False
            DMM_dbm_3.Enabled = False
        End If
    End Sub

    Private Sub DMM_Enable_4_CheckedChanged(sender As Object, e As EventArgs) Handles DMM_Enable_4.CheckedChanged
        If DMM_Enable_4.Checked = True Then
            DMM_gpib_4.Enabled = True
            DMM_Name_4.Enabled = True
            DMM_function_4.Enabled = True
            DMM_Value_4.Enabled = True
            DMM_dbm_4.Enabled = True
        Else
            DMM_gpib_4.Enabled = False
            DMM_Name_4.Enabled = False
            DMM_function_4.Enabled = False
            DMM_Value_4.Enabled = False
            DMM_dbm_4.Enabled = False
        End If
    End Sub

    Private Sub Analyzer_Enable_CheckedChanged(sender As Object, e As EventArgs) Handles Analyzer_Enable.CheckedChanged
        If Analyzer_Enable.Checked = True Then
            AudioAnalyzer_gpib.Enabled = True
            AudioAnalyzer_name.Enabled = True
            Dist_freq.Enabled = True
            Dist_Amp.Enabled = True
            DistortionChange.Enabled = True
            Dist_measure_SINAD.Enabled = True
            Dist_measure_DSTN.Enabled = True
            Dist_measure_Voltage.Enabled = True
        Else
            AudioAnalyzer_gpib.Enabled = False
            AudioAnalyzer_name.Enabled = False
            Dist_freq.Enabled = False
            Dist_Amp.Enabled = False
            DistortionChange.Enabled = False
            Dist_measure_SINAD.Enabled = False
            Dist_measure_DSTN.Enabled = False
            Dist_measure_Voltage.Enabled = False

        End If
    End Sub

    Private Sub Scope_Enable_CheckedChanged(sender As Object, e As EventArgs) Handles Scope_Enable.CheckedChanged
        If Scope_Enable.Checked = True Then
            Ocilliscope_gpib.Enabled = True
            Ocilliscope_name.Enabled = True
            SCOPE_Vpp_1.Enabled = True
            SCOPE_Vrms_1.Enabled = True
            SCOPE_dBm_1.Enabled = True
            SCOPE_FREQ_1.Enabled = True

            SCOPE_Vpp_2.Enabled = True
            SCOPE_Vrms_2.Enabled = True
            SCOPE_dBm_2.Enabled = True
            SCOPE_FREQ_2.Enabled = True

            Scope_Autoscale.Enabled = True

            SCOPE_dBm_diff.Enabled = True
            SCOPE_Phase.Enabled = True
        Else
            Ocilliscope_gpib.Enabled = False
            Ocilliscope_name.Enabled = False
            SCOPE_Vpp_1.Enabled = False
            SCOPE_Vrms_1.Enabled = False
            SCOPE_dBm_1.Enabled = False
            SCOPE_FREQ_1.Enabled = False

            SCOPE_Vpp_2.Enabled = False
            SCOPE_Vrms_2.Enabled = False
            SCOPE_dBm_2.Enabled = False
            SCOPE_FREQ_2.Enabled = False

            Scope_Autoscale.Enabled = False

            SCOPE_dBm_diff.Enabled = False
            SCOPE_Phase.Enabled = False
        End If
    End Sub


    Private Sub PSU_Enable_CheckedChanged(sender As Object, e As EventArgs) Handles PSU_Enable.CheckedChanged
        If PSU_Enable.Checked = True Then
            PSU_gpib.Enabled = True
            PSU_name.Enabled = True

            PSU_V_1.Enabled = True
            PSU_I_1.Enabled = True
            PSU_READ_V_1.Enabled = True
            PSU_READ_I_1.Enabled = True
            PSU_ON_1.Enabled = True

            PSU_V_2.Enabled = True
            PSU_I_2.Enabled = True
            PSU_READ_V_2.Enabled = True
            PSU_READ_I_2.Enabled = True
            PSU_ON_2.Enabled = True

            PSU_V_3.Enabled = True
            PSU_I_3.Enabled = True
            PSU_READ_V_3.Enabled = True
            PSU_READ_I_3.Enabled = True
            PSU_ON_3.Enabled = True

            PSU_V_4.Enabled = True
            PSU_I_4.Enabled = True
            PSU_READ_V_4.Enabled = True
            PSU_READ_I_4.Enabled = True
            PSU_ON_4.Enabled = True

            PSULink12.Enabled = True
            PSUlink34.Enabled = True

        Else
            PSU_gpib.Enabled = False
            PSU_name.Enabled = False

            PSU_V_1.Enabled = False
            PSU_I_1.Enabled = False
            PSU_READ_V_1.Enabled = False
            PSU_READ_I_1.Enabled = False
            PSU_ON_1.Enabled = False

            PSU_V_2.Enabled = False
            PSU_I_2.Enabled = False
            PSU_READ_V_2.Enabled = False
            PSU_READ_I_2.Enabled = False
            PSU_ON_2.Enabled = False

            PSU_V_3.Enabled = False
            PSU_I_3.Enabled = False
            PSU_READ_V_3.Enabled = False
            PSU_READ_I_3.Enabled = False
            PSU_ON_3.Enabled = False

            PSU_V_4.Enabled = False
            PSU_I_4.Enabled = False
            PSU_READ_V_4.Enabled = False
            PSU_READ_I_4.Enabled = False
            PSU_ON_4.Enabled = False

            PSULink12.Enabled = False
            PSUlink34.Enabled = False

        End If
    End Sub

    Private Sub SigGen_Enable_CheckedChanged(sender As Object, e As EventArgs) Handles SigGen_Enable.CheckedChanged
        If SigGen_Enable.Checked = True Then

            SignalGen_gpib.Enabled = True
            SignalGen_name.Enabled = True

            SigGen_Sine_freq.Enabled = True
            SigGen_Signal_Type.Enabled = True
            SigGen_DutyCycle.Enabled = True
            SigGen_amp.Enabled = True
            SigGen_Amp_unit.Enabled = True
            SigGen_Update.Enabled = True
            SigGen_FrequencyTrackBar.Enabled = True
            QuickFreq.Visible = True

        Else
            SignalGen_gpib.Enabled = False
            SignalGen_name.Enabled = False

            SigGen_Sine_freq.Enabled = False
            SigGen_Signal_Type.Enabled = False
            SigGen_DutyCycle.Enabled = False
            SigGen_amp.Enabled = False
            SigGen_Amp_unit.Enabled = False
            SigGen_Update.Enabled = False
            SigGen_FrequencyTrackBar.Enabled = False
            QuickFreq.Visible = False
        End If
    End Sub

    Private Sub GPIB_Enable_CheckedChanged(sender As Object, e As EventArgs) Handles GPIB_Enable.CheckedChanged
        If GPIB_Enable.Checked = True Then
            DMM_Enable_1.Checked = True
            DMM_Enable_2.Checked = True
            DMM_Enable_3.Checked = True
            DMM_Enable_4.Checked = True
            Analyzer_Enable.Checked = True

            Scope_Enable.Checked = True
            PSU_Enable.Checked = True
            SigGen_Enable.Checked = True

        Else DMM_Enable_1.Checked = False
            DMM_Enable_2.Checked = False
            DMM_Enable_3.Checked = False
            DMM_Enable_4.Checked = False
            Analyzer_Enable.Checked = False

            Scope_Enable.Checked = False
            PSU_Enable.Checked = False
            SigGen_Enable.Checked = False

        End If
    End Sub






    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Rigol_FFT_Connect.Click
        CommandList("Connect FFT")

        Rigol_FFT_Config()

    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs)
        FFTGraph()
    End Sub

    Private Sub FFT_GET_DATA_Click(sender As Object, e As EventArgs) Handles FFT_GET_DATA.Click
        Get_FFT_data()
    End Sub


    Public Sub CommandList(WhatToAdd As String)
        Me.CommandListBox.Items.Add(WhatToAdd)
    End Sub

    Private Sub Rigol_FFT_Chart_mouseover(sender As Object, ByVal e As MouseEventArgs) Handles Rigol_FFT_Chart.MouseMove
        'get x and y values from chart
        Try
            Dim result As DataVisualization.Charting.HitTestResult = Rigol_FFT_Chart.HitTest(e.X, e.Y)

            Dim dp As DataVisualization.Charting.DataPoint = Rigol_FFT_Chart.Series(0).Points(result.PointIndex)
            ToolTip1.SetToolTip(Rigol_FFT_Chart, "X:" & (dp.XValue) & "kHz :" & dp.YValues(0) & "dBV")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Rigol_FFT_Chart_Click(sender As Object, ByVal e As MouseEventArgs) Handles Rigol_FFT_Chart.MouseClick

        'get x and y values from chart
        Try
            Dim result As DataVisualization.Charting.HitTestResult = Rigol_FFT_Chart.HitTest(e.X, e.Y)

            Dim dp As DataVisualization.Charting.DataPoint = Rigol_FFT_Chart.Series(0).Points(result.PointIndex)
            Dim Xtemp As Double = dp.XValue
            Dim Ytemp As Double = dp.YValues(0)
            FFT_MouseOver_XValue.Text = Xtemp
            FFT_MouseOver_YValue.Text = Ytemp
        Catch ex As Exception

        End Try

    End Sub


    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub IPaddress_TextChanged(sender As Object, e As EventArgs) Handles IPaddress.TextChanged

    End Sub

    Private Sub Connecttoscope_Click(sender As Object, e As EventArgs) Handles Connecttoscope.Click
        RIGOL_Connecttoscope_Click()
    End Sub

    Private Sub Rigol_Get_SCOPE_DATA_Click(sender As Object, e As EventArgs) Handles Rigol_GetSCOPEDATA.Click
        Rigol_Get_SCOPE_DATA()
    End Sub

    Private Sub Rigol_update_CH1_Click(sender As Object, e As EventArgs) Handles Rigol_update_CH1.Click
        Rigol_ReadandDisplay_CH1()
    End Sub

    Private Sub Rigol_update_CH2_Click(sender As Object, e As EventArgs) Handles Rigol_update_CH2.Click
        Rigol_ReadandDisplay_CH2()
    End Sub

    Private Sub Rigol_update_CH3_Click(sender As Object, e As EventArgs) Handles Rigol_update_CH3.Click
        Rigol_ReadandDisplay_CH3()
    End Sub

    Private Sub Rigol_update_CH4_Click(sender As Object, e As EventArgs) Handles Rigol_update_CH4.Click
        Rigol_ReadandDisplay_CH4()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Rigol_autoscale()
    End Sub
End Class

