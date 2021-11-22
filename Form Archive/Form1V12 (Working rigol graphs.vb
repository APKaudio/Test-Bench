
Imports System.Windows.Forms.DataVisualization.Charting



Public Class Form1

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

    Public PSU As Ivi.Visa.Interop.FormattedIO488

    Public SignalGen As Ivi.Visa.Interop.FormattedIO488

    Public RIGOL As Ivi.Visa.Interop.FormattedIO488

    Public RigolSplitWaveData_CH1() As String
    Public RigolSplitWaveData_CH2() As String
    Public RigolSplitWaveData_CH3() As String
    Public RigolSplitWaveData_CH4() As String

    Public DataCollectionTable As New DataTable("CollectedData")


    Public SCOPE_CH_1 As New DataTable("SCOPECH1")
    Public SCOPE_CH_2 As New DataTable("SCOPECH2")
    Public SCOPE_CH_3 As New DataTable("SCOPECH3")
    Public SCOPE_CH_4 As New DataTable("SCOPECH4")


    Dim ScopeGraph_ch_1 As New Series
    Dim ScopeGraph_ch_2 As New Series
    Dim ScopeGraph_ch_3 As New Series
    Dim ScopeGraph_ch_4 As New Series


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
        TabControl1.TabIndex = 3


        ioMgr = New Ivi.Visa.Interop.ResourceManager

        DMM1 = New Ivi.Visa.Interop.FormattedIO488
        DMM2 = New Ivi.Visa.Interop.FormattedIO488
        DMM3 = New Ivi.Visa.Interop.FormattedIO488
        DMM4 = New Ivi.Visa.Interop.FormattedIO488

        AudioAnalyzer = New Ivi.Visa.Interop.FormattedIO488

        Ocilliscope = New Ivi.Visa.Interop.FormattedIO488

        PSU = New Ivi.Visa.Interop.FormattedIO488

        SignalGen = New Ivi.Visa.Interop.FormattedIO488

        RIGOL = New Ivi.Visa.Interop.FormattedIO488



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


    End Sub

    Private Sub DMM_function_1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DMM_function_1.SelectedIndexChanged
        If DMM_Enable_1.Checked = True Then
            DMM_Config_1()
            DMM1.WriteString("DISP:TEXT:CLEAR")
        End If

    End Sub
    Private Sub DMM_function_2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DMM_function_2.SelectedIndexChanged
        If DMM_Enable_2.Checked = True Then
            DMM_Config_2()
            DMM2.WriteString("DISP:TEXT:CLEAR")
        End If

    End Sub
    Private Sub DMM_function_3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DMM_function_3.SelectedIndexChanged
        If DMM_Enable_3.Checked = True Then
            DMM_Config_3()
            DMM3.WriteString("DISP:TEXT:CLEAR")
        End If

    End Sub
    Private Sub DMM_function_4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DMM_function_4.SelectedIndexChanged
        If DMM_Enable_4.Checked = True Then
            DMM_Config_4()
            DMM4.WriteString("DISP:TEXT:CLEAR")
        End If

    End Sub



    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles SigGen_Update.Click
        config_SigGen()
        SignalGen.WriteString("OUTPUT ON")
    End Sub

    Public Sub config_SigGen()
        SignalGen.WriteString("DISPLAY:TEXT:CLEAR")
        SignalGen.WriteString("OUTPUT:LOAD " & dBm_ref_imp.Text)
        SignalGen.WriteString("FUNC " & SigGen_Signal_Type.Text)
        SignalGen.WriteString("FREQ " & SigGen_Sine_freq.Text)
        SignalGen.WriteString("VOLT:UNIT " & SigGen_Amp_unit.Text)


        SignalGen.WriteString("VOLT " & SigGen_amp.Text)
        AutoScaleScope()
        GetScopeData()
    End Sub

    Public Sub FrequencyUpdate(freq As Integer)
        SignalGen.WriteString("FREQ " & freq)
        SigGen_FrequencyTrackBar.Value = freq
        SigGen_Sine_freq.Text = freq
    End Sub

    Private Sub Sine_amp_TextChanged(sender As Object, e As EventArgs) Handles SigGen_amp.TextChanged

    End Sub

    Private Sub DutyCycle_Scroll(sender As Object, e As EventArgs) Handles SigGen_DutyCycle.Scroll
        If SigGen_Signal_Type.Text = "SQU" Then
            SignalGen.WriteString("FUNC:SQU:DCYC " & SigGen_DutyCycle.Value)
        ElseIf SigGen_Signal_Type.Text = "RAMP" Then
            SignalGen.WriteString("FUNC:RAMP:SYMM " & SigGen_DutyCycle.Value)
        Else


        End If
    End Sub



    Private Sub Sine_freq_TextChanged(sender As Object, e As EventArgs) Handles SigGen_Sine_freq.TextChanged

        If SigGen_FrequencyTrackBar.Value > 0 Then
            SigGen_FrequencyTrackBar.Value = SigGen_Sine_freq.Text
        End If
    End Sub

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

    Private Sub FrequencyTrackBar_Scroll(sender As Object, e As EventArgs) Handles SigGen_FrequencyTrackBar.Scroll
        SigGen_Sine_freq.Text = SigGen_FrequencyTrackBar.Value
        SignalGen.WriteString("FREQ " & SigGen_Sine_freq.Text)

    End Sub

    Private Sub Button_PSU_STATE_1(sender As Object, e As EventArgs) Handles PSU_ON_1.Click

        If PSU_ON_1.Text = "ON" Then
            PSU.WriteString("VSET 1," & PSU_V_1.Text)
            PSU.WriteString("ISET 1," & PSU_I_1.Text)
            PSU.WriteString("OUT 1,1")
            PSU_ON_1.Text = "OFF"
            PSU_ON_1.BackColor = Color.Orange
        ElseIf PSU_ON_1.Text = "OFF" Then
            PSU.WriteString("OUT 1,0")
            PSU_ON_1.Text = "ON"
            PSU_ON_1.BackColor = Color.Transparent
        End If
        If PSULink12.Checked Then
            If PSU_ON_2.Text = "ON" Then
                PSU_V_2.Text = PSU_V_1.Text
                PSU_I_2.Text = PSU_I_1.Text
                PSU.WriteString("VSET 2," & PSU_V_1.Text)
                PSU.WriteString("ISET 2," & PSU_I_1.Text)
                PSU.WriteString("OUT 2,1")
                PSU_ON_2.Text = "OFF"
                PSU_ON_2.BackColor = Color.Orange
            ElseIf PSU_ON_2.Text = "OFF" Then
                PSU.WriteString("OUT 2,0")
                PSU_ON_2.Text = "ON"
                PSU_ON_2.BackColor = Color.Transparent
            End If

        End If

        ReadPSUValue()

    End Sub
    Private Sub BButton_PSU_STATE_3(sender As Object, e As EventArgs) Handles PSU_ON_2.Click
        If PSU_ON_2.Text = "ON" Then
            PSU.WriteString("VSET 2," & PSU_V_2.Text)
            PSU.WriteString("ISET 2," & PSU_I_2.Text)
            PSU.WriteString("OUT 2,1")
            PSU_ON_2.Text = "OFF"
            PSU_ON_2.BackColor = Color.Orange
        ElseIf PSU_ON_2.Text = "OFF" Then
            PSU.WriteString("OUT 2,0")
            PSU_ON_2.Text = "ON"
            PSU_ON_2.BackColor = Color.Transparent
        End If




        ReadPSUValue()
    End Sub
    Private Sub Button_PSU_STATE_3(sender As Object, e As EventArgs) Handles PSU_ON_3.Click

        If PSU_ON_3.Text = "ON" Then
            PSU.WriteString("VSET 3," & PSU_V_3.Text)
            PSU.WriteString("ISET 3," & PSU_I_3.Text)
            PSU.WriteString("OUT 3,1")
            PSU_ON_3.Text = "OFF"
            PSU_ON_3.BackColor = Color.Orange

        ElseIf PSU_ON_3.Text = "OFF" Then
            PSU.WriteString("OUT 3,0")
            PSU_ON_3.Text = "ON"
            PSU_ON_3.BackColor = Color.Transparent
        End If

        If PSUlink34.Checked Then
            PSU_V_4.Text = PSU_V_3.Text
            PSU_I_4.Text = PSU_I_3.Text
            If PSU_ON_4.Text = "ON" Then
                PSU.WriteString("VSET 4," & PSU_V_3.Text)
                PSU.WriteString("ISET 4," & PSU_I_3.Text)
                PSU.WriteString("OUT 4,1")
                PSU_ON_4.Text = "OFF"
                PSU_ON_4.BackColor = Color.Orange
            ElseIf PSU_ON_4.Text = "OFF" Then
                PSU.WriteString("OUT 4,0")
                PSU_ON_4.Text = "ON"
                PSU_ON_4.BackColor = Color.Transparent
            End If


        End If

        ReadPSUValue()
    End Sub
    Private Sub Button_PSU_STATE_4(sender As Object, e As EventArgs) Handles PSU_ON_4.Click
        If PSU_ON_4.Text = "ON" Then
            PSU.WriteString("VSET 4," & PSU_V_4.Text)
            PSU.WriteString("ISET 4," & PSU_I_4.Text)
            PSU.WriteString("OUT 4,1")
            PSU_ON_4.Text = "OFF"
            PSU_ON_4.BackColor = Color.Orange
        ElseIf PSU_ON_4.Text = "OFF" Then
            PSU.WriteString("OUT 4,0")
            PSU_ON_4.Text = "ON"
            PSU_ON_4.BackColor = Color.Transparent
        End If
        ReadPSUValue()
    End Sub

    Private Sub BUTTON_PSU_OFF(sender As Object, e As EventArgs) Handles Button2.Click

        PSUOFF()


    End Sub

    Public Sub PSUOFF()
        If PSU_Enable.Checked = True Then
            PSU.WriteString("OUT 1,0")

            PSU_ON_1.Text = "ON"
            PSU_ON_1.BackColor = Color.Transparent

            PSU.WriteString("OUT 2,0")
            PSU_ON_2.Text = "ON"
            PSU_ON_2.BackColor = Color.Transparent

            PSU.WriteString("OUT 3,0")
            PSU_ON_3.Text = "ON"
            PSU_ON_3.BackColor = Color.Transparent

            PSU.WriteString("OUT 4,0")
            PSU_ON_4.Text = "ON"
            PSU_ON_4.BackColor = Color.Transparent

            ReadPSUValue()
        End If
    End Sub

    Private Sub Button_Read_PSU(sender As Object, e As EventArgs) Handles Button3.Click

        ReadPSUValue()

    End Sub

    Public Sub ReadPSUValue()

        If PSU_Enable.Checked = True Then
            ReadPSUValue_1()
            ReadPSUValue_2()
            ReadPSUValue_3()
            ReadPSUValue_4()
        End If

    End Sub

    Public Sub ReadPSUValue_1()
        'REad voltage and current
        PSU.WriteString("VOUT? 1")
        PSU_READ_V_1.Text = PSU.ReadString
        PSU.WriteString("IOUT? 1")
        PSU_READ_I_1.Text = PSU.ReadString
    End Sub

    Public Sub ReadPSUValue_2()
        'REad voltage and current
        PSU.WriteString("VOUT? 2")
        PSU_READ_V_2.Text = PSU.ReadString
        PSU.WriteString("IOUT? 2")
        PSU_READ_I_2.Text = PSU.ReadString
    End Sub

    Public Sub ReadPSUValue_3()
        'REad voltage and current
        PSU.WriteString("VOUT? 3")
        PSU_READ_V_3.Text = PSU.ReadString
        PSU.WriteString("IOUT? 3")
        PSU_READ_I_3.Text = PSU.ReadString
    End Sub

    Public Sub ReadPSUValue_4()
        'REad voltage and current
        PSU.WriteString("VOUT? 4")
        PSU_READ_V_4.Text = PSU.ReadString
        PSU.WriteString("IOUT? 4")
        PSU_READ_I_4.Text = PSU.ReadString
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




    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles PSULink12.CheckedChanged
        PSU.WriteString("OUT 1,0")
        PSU_ON_1.Text = "ON"
        PSU_ON_1.BackColor = Color.Transparent

        PSU.WriteString("OUT 2,0")
        PSU_ON_2.Text = "ON"
        PSU_ON_2.BackColor = Color.Transparent

        PSU_V_2.Enabled = Not PSU_V_2.Enabled
        PSU_I_2.Enabled = Not PSU_I_2.Enabled
        PSU_ON_2.Enabled = Not PSU_ON_2.Enabled

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles PSUlink34.CheckedChanged
        PSU.WriteString("OUT 3,0")
        PSU_ON_3.Text = "ON"
        PSU_ON_3.BackColor = Color.Transparent
        PSU.WriteString("OUT 4,0")
        PSU_ON_4.Text = "ON"
        PSU_ON_4.BackColor = Color.Transparent

        PSU_V_4.Enabled = Not PSU_V_4.Enabled
        PSU_I_4.Enabled = Not PSU_I_4.Enabled
        PSU_ON_4.Enabled = Not PSU_ON_4.Enabled
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



    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        FrequencyUpdate(100)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        FrequencyUpdate(1000)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        FrequencyUpdate(10000)
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        FrequencyUpdate(100000)
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        FrequencyUpdate(10)
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        FrequencyUpdate(2000)
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        FrequencyUpdate(5000)
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        FrequencyUpdate(20000)
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        FrequencyUpdate(50000)
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Dim b As Byte() = {&HF0, &H7F}

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click



        SerialPort1.Write(b, 0, 2)

    End Sub

    Private Sub Button5_Click_2(sender As Object, e As EventArgs) Handles Button5.Click
        SerialPort1.Open()
    End Sub







    Private Sub PSU_READ_V_1_TextChanged_1(sender As Object, e As EventArgs) Handles PSU_READ_V_1.DoubleClick
        ReadPSUValue_1()
        My.Computer.Clipboard.SetText(PSU_READ_V_1.Text)
    End Sub

    Private Sub PSU_READ_V_2_TextChanged_1(sender As Object, e As EventArgs) Handles PSU_READ_V_2.DoubleClick
        ReadPSUValue_2()
        My.Computer.Clipboard.SetText(PSU_READ_V_2.Text)
    End Sub

    Private Sub PSU_READ_V_3_TextChanged_1(sender As Object, e As EventArgs) Handles PSU_READ_V_3.DoubleClick
        ReadPSUValue_3()
        My.Computer.Clipboard.SetText(PSU_READ_V_3.Text)
    End Sub
    Private Sub PSU_READ_V_4_TextChanged_1(sender As Object, e As EventArgs) Handles PSU_READ_V_4.DoubleClick
        ReadPSUValue_4()
        My.Computer.Clipboard.SetText(PSU_READ_V_4.Text)
    End Sub

    Private Sub PSU_READ_I_1_TextChanged(sender As Object, e As EventArgs) Handles PSU_READ_I_1.DoubleClick
        ReadPSUValue_1()
        My.Computer.Clipboard.SetText(PSU_READ_I_1.Text)
    End Sub


    Private Sub PSU_READ_I_2_TextChanged(sender As Object, e As EventArgs) Handles PSU_READ_I_2.DoubleClick
        ReadPSUValue_2()
        My.Computer.Clipboard.SetText(PSU_READ_I_2.Text)
    End Sub


    Private Sub PSU_READ_I_3_TextChanged(sender As Object, e As EventArgs) Handles PSU_READ_I_3.DoubleClick
        ReadPSUValue_3()
        My.Computer.Clipboard.SetText(PSU_READ_I_3.Text)
    End Sub


    Private Sub PSU_READ_I_4_TextChanged(sender As Object, e As EventArgs) Handles PSU_READ_I_4.DoubleClick
        ReadPSUValue_4()
        My.Computer.Clipboard.SetText(PSU_READ_I_4.Text)
    End Sub

    Private Sub DMM_Value_1_TextChanged_1(sender As Object, e As EventArgs) Handles DMM_Value_1.DoubleClick
        DMM_Read_1()
        My.Computer.Clipboard.SetText(DMM_Value_1.Text)
    End Sub

    Private Sub DMM_Value_2_TextChanged_1(sender As Object, e As EventArgs) Handles DMM_Value_2.DoubleClick
        DMM_Read_2()
        My.Computer.Clipboard.SetText(DMM_Value_2.Text)
    End Sub

    Private Sub DMM_Value_3_TextChanged_1(sender As Object, e As EventArgs) Handles DMM_Value_3.DoubleClick
        DMM_Read_3()
        My.Computer.Clipboard.SetText(DMM_Value_3.Text)
    End Sub

    Private Sub DMM_Value_4_TextChanged_1(sender As Object, e As EventArgs) Handles DMM_Value_4.DoubleClick
        DMM_Read_4()
        My.Computer.Clipboard.SetText(DMM_Value_4.Text)
    End Sub


    Private Sub PSU_READ_V_1_TextChanged(sender As Object, e As EventArgs) Handles PSU_READ_V_1.TextChanged

    End Sub

    Private Sub DMM_Value_1_TextChanged(sender As Object, e As EventArgs) Handles DMM_Value_1.TextChanged

    End Sub

    Private Sub DMM_Name_1_TextChanged(sender As Object, e As EventArgs) Handles DMM_Name_1.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click



        CollectData()




    End Sub


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

    Private Sub SCOPE_Vpp_1_TextChanged(sender As Object, e As EventArgs) Handles SCOPE_Vpp_1.TextChanged

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


    '*****************************************************
    'RIGOL SCOPE
    Private Sub Connecttoscope_Click(sender As Object, e As EventArgs) Handles Connecttoscope.Click
        RIGOL.IO = ioMgr.Open("TCPIP0::192.168.0.110::INSTR")    ' 10 is the instr. address 
        RIGOL.WriteString(":RUN")
        RigolRead1()
        RigolRead2()
        RigolRead3()
        RigolRead4()


        RigolWave3()
        RIGOL.WriteString(":STOP")
    End Sub

    Public Sub RigolRead1()
        RIGOL.WriteString("CHAN1 : DISP ON")
        RIGOL.WriteString("MEASure:VPP? CHAN1")
        Rigol_Vpp_1.Text = RIGOL.ReadString

        RIGOL.WriteString("MEASure:VRMS? CHAN1")
        Rigol_Vrms_1.Text = RIGOL.ReadString

        RIGOL.WriteString("MEASure:FREQuency? CHAN1")
        Rigol_Freq_1.Text = RIGOL.ReadString
    End Sub

    Public Sub RigolRead2()
        RIGOL.WriteString("CHAN2 : DISP ON")


        RIGOL.WriteString("MEASure:VPP? CHAN2")
        Rigol_Vpp_2.Text = RIGOL.ReadString

        RIGOL.WriteString("MEASure:VRMS? CHAN2")
        Rigol_Vrms_2.Text = RIGOL.ReadString

        RIGOL.WriteString("MEASure:FREQuency? CHAN2")
        Rigol_Freq_2.Text = RIGOL.ReadString
    End Sub

    Public Sub RigolRead3()

        RIGOL.WriteString("CHAN3 : DISP ON")
        RIGOL.WriteString("MEASure:VPP? CHAN3")
        Rigol_Vpp_3.Text = RIGOL.ReadString

        RIGOL.WriteString("MEASure:VRMS? CHAN3")
        Rigol_Vrms_3.Text = RIGOL.ReadString

        RIGOL.WriteString("MEASure:FREQuency? CHAN3")
        Rigol_Freq_3.Text = RIGOL.ReadString
    End Sub

    Public Sub RigolRead4()
        RIGOL.WriteString("CHAN4 : DISP ON")
        RIGOL.WriteString("MEASure:VPP? CHAN4")
        Rigol_Vpp_4.Text = RIGOL.ReadString

        RIGOL.WriteString("MEASure:VRMS? CHAN4")
        Rigol_Vrms_4.Text = RIGOL.ReadString

        RIGOL.WriteString("MEASure:FREQuency? CHAN4")
        Rigol_Freq_4.Text = RIGOL.ReadString
    End Sub

    Public Sub RigolWave3()



        '   Chart1.Series.Add()
    End Sub

    Private Sub Get_SCOPE_DATA_CH3_Click(sender As Object, e As EventArgs) Handles Get_SCOPE_DATA_CH3.Click
        RigolData1()
        RigolData2()
        RigolData3()
        RigolData4()

    End Sub




    Public Sub RigolData1()
        Dim RigolRAWWaveData_1 As String = "jjjj"

        SCOPE_CH_1.Columns.Clear()


        RIGOL.WriteString(":WAVeform:SOURce CHANnel1")
        RIGOL.WriteString(":WAV:POIN:MODE RAW")
        RIGOL.WriteString(":WAVeform:FORmat ASCii")
        RIGOL.WriteString(":WAV:DATA?")

        'Read the Data from the scope to local memory
        RigolRAWWaveData_1 = RIGOL.ReadString

        'Split up the Data
        RigolSplitWaveData_CH1 = Mid(RigolRAWWaveData_1, 12).Split(",")



        SCOPE_CH_1.Columns.Add("DATA")
        For I = 0 To ((RigolSplitWaveData_CH1.Length) - 1)
            SCOPE_CH_1.Rows.Add(RigolSplitWaveData_CH1(I))
        Next I
        DataGridView1.DataSource = SCOPE_CH_1
    End Sub
    Public Sub RigolData2()
        Dim RigolRAWWaveData_2 As String = "jjjj"

        SCOPE_CH_2.Columns.Clear()


        RIGOL.WriteString(":WAVeform:SOURce CHANnel2")
        RIGOL.WriteString(":WAV:POIN:MODE RAW")
        RIGOL.WriteString(":WAVeform:FORmat ASCii")
        RIGOL.WriteString(":WAV:DATA?")

        'Read the Data from the scope to local memory
        RigolRAWWaveData_2 = RIGOL.ReadString

        'Split up the Data
        RigolSplitWaveData_CH2 = Mid(RigolRAWWaveData_2, 12).Split(",")

        SCOPE_CH_2.Columns.Add("SCOPE 2")
        For I = 0 To ((RigolSplitWaveData_CH2.Length) - 1)
            SCOPE_CH_2.Rows.Add(RigolSplitWaveData_CH2(I))
        Next I
        DataGridView2.DataSource = SCOPE_CH_2
    End Sub
    Public Sub RigolData3()
        Dim RigolRAWWaveData_3 As String = "jjjj"

        SCOPE_CH_3.Columns.Clear()


        RIGOL.WriteString(":WAVeform:SOURce CHANnel3")
        RIGOL.WriteString(":WAV:POIN:MODE RAW")
        RIGOL.WriteString(":WAVeform:FORmat ASCii")
        RIGOL.WriteString(":WAV:DATA?")

        'Read the Data from the scope to local memory
        RigolRAWWaveData_3 = RIGOL.ReadString

        'Split up the Data
        RigolSplitWaveData_CH3 = Mid(RigolRAWWaveData_3, 12).Split(",")



        SCOPE_CH_3.Columns.Add("SCOPE 3")
        For I = 0 To ((RigolSplitWaveData_CH3.Length) - 1)
            SCOPE_CH_3.Rows.Add(RigolSplitWaveData_CH3(I))
        Next I
        DataGridView3.DataSource = SCOPE_CH_3
    End Sub
    Public Sub RigolData4()
        Dim RigolRAWWaveData_4 As String = "jjjj"

        SCOPE_CH_4.Columns.Clear()


        RIGOL.WriteString(":WAVeform:SOURce CHANnel4")
        RIGOL.WriteString(":WAV:POIN:MODE RAW")
        RIGOL.WriteString(":WAVeform:FORmat ASCii")
        RIGOL.WriteString(":WAV:DATA?")

        'Read the Data from the scope to local memory
        RigolRAWWaveData_4 = RIGOL.ReadString

        'Split up the Data
        RigolSplitWaveData_CH4 = Mid(RigolRAWWaveData_4, 12).Split(",")

        SCOPE_CH_4.Columns.Add("SCOPE 4")
        For I = 0 To ((RigolSplitWaveData_CH4.Length) - 1)
            SCOPE_CH_4.Rows.Add(RigolSplitWaveData_CH4(I))
        Next I
        DataGridView4.DataSource = SCOPE_CH_4
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        DoChart_ch_1()
        DoChart_ch_2()
        DoChart_ch_3()
        DoChart_ch_4()
    End Sub


    Sub DoChart_ch_1()

        Chart1.Series.Clear()
        ScopeGraph_ch_1.Points.Clear()




        ScopeGraph_ch_1.Name = "Scope 1"

        'Change to a line graph.
        ScopeGraph_ch_1.ChartType = SeriesChartType.Line
        ScopeGraph_ch_1.Color = Color.DarkOrange

        For I = 0 To ((RigolSplitWaveData_CH1.Length) - 1)
            ScopeGraph_ch_1.Points.AddXY(I, RigolSplitWaveData_CH1(I))

        Next
        Chart1.Series.Add(ScopeGraph_ch_1)
    End Sub
    Sub DoChart_ch_2()

        Chart2.Series.Clear()

        ScopeGraph_ch_2.Name = "SCOPE 3"

        'Change to a line graph.
        ScopeGraph_ch_2.ChartType = SeriesChartType.Line
        ScopeGraph_ch_2.Color = Color.LightBlue
        For I = 0 To ((RigolSplitWaveData_CH2.Length) - 1)
            ScopeGraph_ch_2.Points.AddXY(I, RigolSplitWaveData_CH2(I))

        Next
        Chart2.Series.Add(ScopeGraph_ch_2)
    End Sub
    Sub DoChart_ch_3()
        Chart3.Series.Clear()
        ScopeGraph_ch_4.Name = "SCOPE 2"

        'Change to a line graph.
        ScopeGraph_ch_3.ChartType = SeriesChartType.Line
        ScopeGraph_ch_3.Color = Color.Violet
        For I = 0 To ((RigolSplitWaveData_CH3.Length) - 1)
            ScopeGraph_ch_3.Points.AddXY(I, RigolSplitWaveData_CH3(I))

        Next
        Chart3.Series.Add(ScopeGraph_ch_3)
    End Sub
    Sub DoChart_ch_4()
        Chart4.Series.Clear()
        ScopeGraph_ch_4.Name = "Scope 3"

        'Change to a line graph.
        ScopeGraph_ch_4.ChartType = SeriesChartType.Line
        ScopeGraph_ch_4.Color = Color.DarkBlue
        For I = 0 To ((RigolSplitWaveData_CH4.Length) - 1)
            ScopeGraph_ch_4.Points.AddXY(I, RigolSplitWaveData_CH4(I))

        Next
        Chart4.Series.Add(ScopeGraph_ch_4)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        DoChart_ch_1()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DoChart_ch_2()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        DoChart_ch_3()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        DoChart_ch_4()
    End Sub
End Class

