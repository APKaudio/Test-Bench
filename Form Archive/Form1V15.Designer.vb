<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserInterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea13 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series13 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea14 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series14 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea15 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series15 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.RigolIPAddresFFT = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GPIB_Enable = New System.Windows.Forms.CheckBox()
        Me.SigGen_Enable = New System.Windows.Forms.CheckBox()
        Me.PSU_Enable = New System.Windows.Forms.CheckBox()
        Me.Scope_Enable = New System.Windows.Forms.CheckBox()
        Me.Analyzer_Enable = New System.Windows.Forms.CheckBox()
        Me.NameDevices = New System.Windows.Forms.Button()
        Me.dBm_ref_imp = New System.Windows.Forms.TextBox()
        Me.DMM_Enable_4 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DMM_Enable_3 = New System.Windows.Forms.CheckBox()
        Me.DMM_Enable_2 = New System.Windows.Forms.CheckBox()
        Me.DMM_Enable_1 = New System.Windows.Forms.CheckBox()
        Me.SignalGen_gpib = New System.Windows.Forms.TextBox()
        Me.SignalGen_name = New System.Windows.Forms.TextBox()
        Me.PSU_gpib = New System.Windows.Forms.TextBox()
        Me.PSU_name = New System.Windows.Forms.TextBox()
        Me.Ocilliscope_gpib = New System.Windows.Forms.TextBox()
        Me.Ocilliscope_name = New System.Windows.Forms.TextBox()
        Me.AudioAnalyzer_gpib = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AudioAnalyzer_name = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gpibAddress = New System.Windows.Forms.TextBox()
        Me.DMM_gpib_4 = New System.Windows.Forms.TextBox()
        Me.DMM_gpib_3 = New System.Windows.Forms.TextBox()
        Me.DMM_gpib_2 = New System.Windows.Forms.TextBox()
        Me.DMM_gpib_1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IPaddress = New System.Windows.Forms.TextBox()
        Me.DMM_Name_4 = New System.Windows.Forms.TextBox()
        Me.DMM_Name_3 = New System.Windows.Forms.TextBox()
        Me.DMM_Name_2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DMM_Name_1 = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DMMLabel4 = New System.Windows.Forms.Label()
        Me.DMMLabel3 = New System.Windows.Forms.Label()
        Me.DMMLabel2 = New System.Windows.Forms.Label()
        Me.DMMLabel1 = New System.Windows.Forms.Label()
        Me.PSU_READ_I_4 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PSU_READ_I_3 = New System.Windows.Forms.TextBox()
        Me.PSU_READ_I_2 = New System.Windows.Forms.TextBox()
        Me.PSU_READ_I_1 = New System.Windows.Forms.TextBox()
        Me.PSU_READ_V_4 = New System.Windows.Forms.TextBox()
        Me.PSU_READ_V_3 = New System.Windows.Forms.TextBox()
        Me.PSU_READ_V_2 = New System.Windows.Forms.TextBox()
        Me.BUT_READ_DMM = New System.Windows.Forms.Button()
        Me.PSU_READ_V_1 = New System.Windows.Forms.TextBox()
        Me.SCOPE_dBm_diff = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.SCOPE_Phase = New System.Windows.Forms.TextBox()
        Me.SCOPE_FREQ_2 = New System.Windows.Forms.TextBox()
        Me.SCOPE_dBm_2 = New System.Windows.Forms.TextBox()
        Me.SCOPE_Vrms_2 = New System.Windows.Forms.TextBox()
        Me.SCOPE_Vpp_2 = New System.Windows.Forms.TextBox()
        Me.SCOPE_FREQ_1 = New System.Windows.Forms.TextBox()
        Me.SCOPE_dBm_1 = New System.Windows.Forms.TextBox()
        Me.SCOPE_Vrms_1 = New System.Windows.Forms.TextBox()
        Me.SCOPE_Vpp_1 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.QuickFreq = New System.Windows.Forms.GroupBox()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Scope_Autoscale = New System.Windows.Forms.Button()
        Me.PSU_ON_4 = New System.Windows.Forms.Button()
        Me.PSU_ON_3 = New System.Windows.Forms.Button()
        Me.PSU_ON_2 = New System.Windows.Forms.Button()
        Me.PSU_ON_1 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PSU_I_4 = New System.Windows.Forms.TextBox()
        Me.PSU_V_4 = New System.Windows.Forms.TextBox()
        Me.PSULabel4 = New System.Windows.Forms.Label()
        Me.PSU_I_3 = New System.Windows.Forms.TextBox()
        Me.PSU_V_3 = New System.Windows.Forms.TextBox()
        Me.PSULabel3 = New System.Windows.Forms.Label()
        Me.PSU_I_2 = New System.Windows.Forms.TextBox()
        Me.PSU_V_2 = New System.Windows.Forms.TextBox()
        Me.PSULabel2 = New System.Windows.Forms.Label()
        Me.PSU_I_1 = New System.Windows.Forms.TextBox()
        Me.PSU_V_1 = New System.Windows.Forms.TextBox()
        Me.PSULink12 = New System.Windows.Forms.CheckBox()
        Me.PSUlink34 = New System.Windows.Forms.CheckBox()
        Me.PSULabel1 = New System.Windows.Forms.Label()
        Me.SigGen_FrequencyTrackBar = New System.Windows.Forms.TrackBar()
        Me.Dist_measure_Voltage = New System.Windows.Forms.TextBox()
        Me.Dist_measure_DSTN = New System.Windows.Forms.TextBox()
        Me.Dist_measure_SINAD = New System.Windows.Forms.TextBox()
        Me.Dist_Amp = New System.Windows.Forms.TextBox()
        Me.DistortionChange = New System.Windows.Forms.Button()
        Me.Dist_freq = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SigGen_DutyCycle = New System.Windows.Forms.TrackBar()
        Me.SigGen_Signal_Type = New System.Windows.Forms.ComboBox()
        Me.SigGen_Update = New System.Windows.Forms.Button()
        Me.SigGen_Amp_unit = New System.Windows.Forms.ComboBox()
        Me.SigGen_amp = New System.Windows.Forms.TextBox()
        Me.SigGen_Sine_freq = New System.Windows.Forms.TextBox()
        Me.SignalGenLabel = New System.Windows.Forms.Label()
        Me.DMM_dbm_4 = New System.Windows.Forms.TextBox()
        Me.DMM_Value_4 = New System.Windows.Forms.TextBox()
        Me.DMM_function_4 = New System.Windows.Forms.ComboBox()
        Me.DMM_dbm_3 = New System.Windows.Forms.TextBox()
        Me.DMM_Value_3 = New System.Windows.Forms.TextBox()
        Me.DMM_function_3 = New System.Windows.Forms.ComboBox()
        Me.DMM_dbm_2 = New System.Windows.Forms.TextBox()
        Me.DMM_Value_2 = New System.Windows.Forms.TextBox()
        Me.DMM_function_2 = New System.Windows.Forms.ComboBox()
        Me.DMM_dbm_1 = New System.Windows.Forms.TextBox()
        Me.DMM_Value_1 = New System.Windows.Forms.TextBox()
        Me.DMM_function_1 = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Rigol_Time_Scale = New System.Windows.Forms.Label()
        Me.Rigol_Time_Base = New System.Windows.Forms.TextBox()
        Me.RigolIPAddres = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Rigol_update_CH1 = New System.Windows.Forms.Button()
        Me.Rigol_update_CH4 = New System.Windows.Forms.Button()
        Me.Rigol_update_CH3 = New System.Windows.Forms.Button()
        Me.Rigol_update_CH2 = New System.Windows.Forms.Button()
        Me.Rigol_Data_Grid_4 = New System.Windows.Forms.DataGridView()
        Me.Rigol_Data_Grid_3 = New System.Windows.Forms.DataGridView()
        Me.Rigol_Data_Grid_2 = New System.Windows.Forms.DataGridView()
        Me.Rigol_Data_Grid_1 = New System.Windows.Forms.DataGridView()
        Me.Rigol_GetSCOPEDATA = New System.Windows.Forms.Button()
        Me.Rigol_Freq_4 = New System.Windows.Forms.TextBox()
        Me.Rigol_dBm_4 = New System.Windows.Forms.TextBox()
        Me.Rigol_Vrms_4 = New System.Windows.Forms.TextBox()
        Me.Rigol_Vpp_4 = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Rigol_Freq_3 = New System.Windows.Forms.TextBox()
        Me.Rigol_dBm_3 = New System.Windows.Forms.TextBox()
        Me.Rigol_Vrms_3 = New System.Windows.Forms.TextBox()
        Me.Rigol_Vpp_3 = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Rigol_Freq_2 = New System.Windows.Forms.TextBox()
        Me.Rigol_dBm_2 = New System.Windows.Forms.TextBox()
        Me.Rigol_Vrms_2 = New System.Windows.Forms.TextBox()
        Me.Rigol_Vpp_2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Rigol_Freq_1 = New System.Windows.Forms.TextBox()
        Me.Rigol_dBm_1 = New System.Windows.Forms.TextBox()
        Me.Rigol_Vrms_1 = New System.Windows.Forms.TextBox()
        Me.Rigol_Vpp_1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Connecttoscope = New System.Windows.Forms.Button()
        Me.Rigol_Chart_1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Rigol_Chart_2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Rigol_Chart_3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Rigol_Chart_4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.FFT_MouseOver_YValue = New System.Windows.Forms.Label()
        Me.FFT_MouseOver_XValue = New System.Windows.Forms.Label()
        Me.FFT_H_Display_scale_f = New System.Windows.Forms.Label()
        Me.FFT_H_Display_Center_f_value = New System.Windows.Forms.Label()
        Me.RigolIPAddresFTP = New System.Windows.Forms.TextBox()
        Me.FFT_WINDOWTYPE = New System.Windows.Forms.Label()
        Me.FFT_CH_SOURCE = New System.Windows.Forms.Label()
        Me.FFT_Resolution = New System.Windows.Forms.ComboBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.FFT_H_Display_Center_f = New System.Windows.Forms.TextBox()
        Me.FFT_Channel_Select = New System.Windows.Forms.ComboBox()
        Me.FFT_Window_Type = New System.Windows.Forms.ComboBox()
        Me.FFT_GET_DATA = New System.Windows.Forms.Button()
        Me.Rigol_FFT_Data = New System.Windows.Forms.DataGridView()
        Me.Rigol_FFT_Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Rigol_FFT_Connect = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.ReadValues = New System.Windows.Forms.Timer(Me.components)
        Me.TMRENA = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Measurement = New System.Windows.Forms.TextBox()
        Me.CommandListBox = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RIGOL_FFT_TOOLTIP = New System.Windows.Forms.ToolTip(Me.components)
        Me.RigolIPAddresFFT.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.QuickFreq.SuspendLayout()
        CType(Me.SigGen_FrequencyTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SigGen_DutyCycle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Rigol_Data_Grid_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rigol_Data_Grid_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rigol_Data_Grid_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rigol_Data_Grid_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rigol_Chart_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rigol_Chart_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rigol_Chart_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rigol_Chart_4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rigol_FFT_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rigol_FFT_Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'RigolIPAddresFFT
        '
        Me.RigolIPAddresFFT.Controls.Add(Me.TabPage4)
        Me.RigolIPAddresFFT.Controls.Add(Me.TabPage1)
        Me.RigolIPAddresFFT.Controls.Add(Me.TabPage2)
        Me.RigolIPAddresFFT.Controls.Add(Me.TabPage6)
        Me.RigolIPAddresFFT.Controls.Add(Me.TabPage3)
        Me.RigolIPAddresFFT.Controls.Add(Me.TabPage5)
        Me.RigolIPAddresFFT.Location = New System.Drawing.Point(12, 12)
        Me.RigolIPAddresFFT.Name = "RigolIPAddresFFT"
        Me.RigolIPAddresFFT.SelectedIndex = 0
        Me.RigolIPAddresFFT.Size = New System.Drawing.Size(1020, 540)
        Me.RigolIPAddresFFT.TabIndex = 3
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button7)
        Me.TabPage4.Controls.Add(Me.GPIB_Enable)
        Me.TabPage4.Controls.Add(Me.SigGen_Enable)
        Me.TabPage4.Controls.Add(Me.PSU_Enable)
        Me.TabPage4.Controls.Add(Me.Scope_Enable)
        Me.TabPage4.Controls.Add(Me.Analyzer_Enable)
        Me.TabPage4.Controls.Add(Me.NameDevices)
        Me.TabPage4.Controls.Add(Me.dBm_ref_imp)
        Me.TabPage4.Controls.Add(Me.DMM_Enable_4)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.DMM_Enable_3)
        Me.TabPage4.Controls.Add(Me.DMM_Enable_2)
        Me.TabPage4.Controls.Add(Me.DMM_Enable_1)
        Me.TabPage4.Controls.Add(Me.SignalGen_gpib)
        Me.TabPage4.Controls.Add(Me.SignalGen_name)
        Me.TabPage4.Controls.Add(Me.PSU_gpib)
        Me.TabPage4.Controls.Add(Me.PSU_name)
        Me.TabPage4.Controls.Add(Me.Ocilliscope_gpib)
        Me.TabPage4.Controls.Add(Me.Ocilliscope_name)
        Me.TabPage4.Controls.Add(Me.AudioAnalyzer_gpib)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.AudioAnalyzer_name)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.gpibAddress)
        Me.TabPage4.Controls.Add(Me.DMM_gpib_4)
        Me.TabPage4.Controls.Add(Me.DMM_gpib_3)
        Me.TabPage4.Controls.Add(Me.DMM_gpib_2)
        Me.TabPage4.Controls.Add(Me.DMM_gpib_1)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.IPaddress)
        Me.TabPage4.Controls.Add(Me.DMM_Name_4)
        Me.TabPage4.Controls.Add(Me.DMM_Name_3)
        Me.TabPage4.Controls.Add(Me.DMM_Name_2)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.DMM_Name_1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1012, 514)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Config"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(820, 90)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(105, 23)
        Me.Button7.TabIndex = 122
        Me.Button7.Text = "Create Table"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GPIB_Enable
        '
        Me.GPIB_Enable.AutoSize = True
        Me.GPIB_Enable.Location = New System.Drawing.Point(60, 28)
        Me.GPIB_Enable.Name = "GPIB_Enable"
        Me.GPIB_Enable.Size = New System.Drawing.Size(122, 17)
        Me.GPIB_Enable.TabIndex = 44
        Me.GPIB_Enable.Text = "Gateway IP Address"
        Me.GPIB_Enable.UseVisualStyleBackColor = True
        '
        'SigGen_Enable
        '
        Me.SigGen_Enable.AutoSize = True
        Me.SigGen_Enable.Location = New System.Drawing.Point(86, 334)
        Me.SigGen_Enable.Name = "SigGen_Enable"
        Me.SigGen_Enable.Size = New System.Drawing.Size(64, 17)
        Me.SigGen_Enable.TabIndex = 43
        Me.SigGen_Enable.Text = "Sig Gen"
        Me.SigGen_Enable.UseVisualStyleBackColor = True
        '
        'PSU_Enable
        '
        Me.PSU_Enable.AutoSize = True
        Me.PSU_Enable.Location = New System.Drawing.Point(86, 293)
        Me.PSU_Enable.Name = "PSU_Enable"
        Me.PSU_Enable.Size = New System.Drawing.Size(48, 17)
        Me.PSU_Enable.TabIndex = 42
        Me.PSU_Enable.Text = "PSU"
        Me.PSU_Enable.UseVisualStyleBackColor = True
        '
        'Scope_Enable
        '
        Me.Scope_Enable.AutoSize = True
        Me.Scope_Enable.Location = New System.Drawing.Point(86, 254)
        Me.Scope_Enable.Name = "Scope_Enable"
        Me.Scope_Enable.Size = New System.Drawing.Size(57, 17)
        Me.Scope_Enable.TabIndex = 41
        Me.Scope_Enable.Text = "Scope"
        Me.Scope_Enable.UseVisualStyleBackColor = True
        '
        'Analyzer_Enable
        '
        Me.Analyzer_Enable.AutoSize = True
        Me.Analyzer_Enable.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.Analyzer_Enable.Location = New System.Drawing.Point(85, 213)
        Me.Analyzer_Enable.Name = "Analyzer_Enable"
        Me.Analyzer_Enable.Size = New System.Drawing.Size(66, 17)
        Me.Analyzer_Enable.TabIndex = 40
        Me.Analyzer_Enable.Text = "Analyzer"
        Me.Analyzer_Enable.UseVisualStyleBackColor = True
        '
        'NameDevices
        '
        Me.NameDevices.Location = New System.Drawing.Point(660, 133)
        Me.NameDevices.Name = "NameDevices"
        Me.NameDevices.Size = New System.Drawing.Size(105, 23)
        Me.NameDevices.TabIndex = 0
        Me.NameDevices.Text = "NameDevices"
        Me.NameDevices.UseVisualStyleBackColor = True
        '
        'dBm_ref_imp
        '
        Me.dBm_ref_imp.Location = New System.Drawing.Point(696, 37)
        Me.dBm_ref_imp.Name = "dBm_ref_imp"
        Me.dBm_ref_imp.Size = New System.Drawing.Size(32, 20)
        Me.dBm_ref_imp.TabIndex = 7
        Me.dBm_ref_imp.Text = "600"
        '
        'DMM_Enable_4
        '
        Me.DMM_Enable_4.AutoSize = True
        Me.DMM_Enable_4.Location = New System.Drawing.Point(85, 167)
        Me.DMM_Enable_4.Name = "DMM_Enable_4"
        Me.DMM_Enable_4.Size = New System.Drawing.Size(61, 17)
        Me.DMM_Enable_4.TabIndex = 39
        Me.DMM_Enable_4.Text = "DMM 4"
        Me.DMM_Enable_4.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(693, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "dBm ref imp"
        '
        'DMM_Enable_3
        '
        Me.DMM_Enable_3.AutoSize = True
        Me.DMM_Enable_3.Location = New System.Drawing.Point(85, 139)
        Me.DMM_Enable_3.Name = "DMM_Enable_3"
        Me.DMM_Enable_3.Size = New System.Drawing.Size(61, 17)
        Me.DMM_Enable_3.TabIndex = 38
        Me.DMM_Enable_3.Text = "DMM 3"
        Me.DMM_Enable_3.UseVisualStyleBackColor = True
        '
        'DMM_Enable_2
        '
        Me.DMM_Enable_2.AutoSize = True
        Me.DMM_Enable_2.Location = New System.Drawing.Point(85, 114)
        Me.DMM_Enable_2.Name = "DMM_Enable_2"
        Me.DMM_Enable_2.Size = New System.Drawing.Size(61, 17)
        Me.DMM_Enable_2.TabIndex = 37
        Me.DMM_Enable_2.Text = "DMM 2"
        Me.DMM_Enable_2.UseVisualStyleBackColor = True
        '
        'DMM_Enable_1
        '
        Me.DMM_Enable_1.AutoSize = True
        Me.DMM_Enable_1.Location = New System.Drawing.Point(85, 89)
        Me.DMM_Enable_1.Name = "DMM_Enable_1"
        Me.DMM_Enable_1.Size = New System.Drawing.Size(61, 17)
        Me.DMM_Enable_1.TabIndex = 36
        Me.DMM_Enable_1.Text = "DMM 1"
        Me.DMM_Enable_1.UseVisualStyleBackColor = True
        '
        'SignalGen_gpib
        '
        Me.SignalGen_gpib.Location = New System.Drawing.Point(153, 331)
        Me.SignalGen_gpib.Name = "SignalGen_gpib"
        Me.SignalGen_gpib.Size = New System.Drawing.Size(42, 20)
        Me.SignalGen_gpib.TabIndex = 35
        Me.SignalGen_gpib.Text = "8"
        '
        'SignalGen_name
        '
        Me.SignalGen_name.Location = New System.Drawing.Point(201, 331)
        Me.SignalGen_name.Name = "SignalGen_name"
        Me.SignalGen_name.Size = New System.Drawing.Size(100, 20)
        Me.SignalGen_name.TabIndex = 33
        Me.SignalGen_name.Text = "SignalGen"
        '
        'PSU_gpib
        '
        Me.PSU_gpib.Location = New System.Drawing.Point(153, 291)
        Me.PSU_gpib.Name = "PSU_gpib"
        Me.PSU_gpib.Size = New System.Drawing.Size(42, 20)
        Me.PSU_gpib.TabIndex = 31
        Me.PSU_gpib.Text = "6"
        '
        'PSU_name
        '
        Me.PSU_name.Location = New System.Drawing.Point(201, 291)
        Me.PSU_name.Name = "PSU_name"
        Me.PSU_name.Size = New System.Drawing.Size(100, 20)
        Me.PSU_name.TabIndex = 29
        Me.PSU_name.Text = "PSU"
        '
        'Ocilliscope_gpib
        '
        Me.Ocilliscope_gpib.Location = New System.Drawing.Point(153, 252)
        Me.Ocilliscope_gpib.Name = "Ocilliscope_gpib"
        Me.Ocilliscope_gpib.Size = New System.Drawing.Size(42, 20)
        Me.Ocilliscope_gpib.TabIndex = 27
        Me.Ocilliscope_gpib.Text = "7"
        '
        'Ocilliscope_name
        '
        Me.Ocilliscope_name.Location = New System.Drawing.Point(201, 252)
        Me.Ocilliscope_name.Name = "Ocilliscope_name"
        Me.Ocilliscope_name.Size = New System.Drawing.Size(100, 20)
        Me.Ocilliscope_name.TabIndex = 25
        Me.Ocilliscope_name.Text = "Scope"
        '
        'AudioAnalyzer_gpib
        '
        Me.AudioAnalyzer_gpib.Location = New System.Drawing.Point(153, 211)
        Me.AudioAnalyzer_gpib.Name = "AudioAnalyzer_gpib"
        Me.AudioAnalyzer_gpib.Size = New System.Drawing.Size(42, 20)
        Me.AudioAnalyzer_gpib.TabIndex = 23
        Me.AudioAnalyzer_gpib.Text = "28"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(105, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 22
        '
        'AudioAnalyzer_name
        '
        Me.AudioAnalyzer_name.Location = New System.Drawing.Point(201, 211)
        Me.AudioAnalyzer_name.Name = "AudioAnalyzer_name"
        Me.AudioAnalyzer_name.Size = New System.Drawing.Size(100, 20)
        Me.AudioAnalyzer_name.TabIndex = 21
        Me.AudioAnalyzer_name.Text = "AA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(115, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "gpib address"
        '
        'gpibAddress
        '
        Me.gpibAddress.Location = New System.Drawing.Point(188, 54)
        Me.gpibAddress.Name = "gpibAddress"
        Me.gpibAddress.Size = New System.Drawing.Size(100, 20)
        Me.gpibAddress.TabIndex = 18
        Me.gpibAddress.Text = "gpib10"
        '
        'DMM_gpib_4
        '
        Me.DMM_gpib_4.Location = New System.Drawing.Point(153, 165)
        Me.DMM_gpib_4.Name = "DMM_gpib_4"
        Me.DMM_gpib_4.Size = New System.Drawing.Size(42, 20)
        Me.DMM_gpib_4.TabIndex = 17
        Me.DMM_gpib_4.Text = "4"
        '
        'DMM_gpib_3
        '
        Me.DMM_gpib_3.Location = New System.Drawing.Point(153, 138)
        Me.DMM_gpib_3.Name = "DMM_gpib_3"
        Me.DMM_gpib_3.Size = New System.Drawing.Size(42, 20)
        Me.DMM_gpib_3.TabIndex = 16
        Me.DMM_gpib_3.Text = "3"
        '
        'DMM_gpib_2
        '
        Me.DMM_gpib_2.Location = New System.Drawing.Point(153, 112)
        Me.DMM_gpib_2.Name = "DMM_gpib_2"
        Me.DMM_gpib_2.Size = New System.Drawing.Size(42, 20)
        Me.DMM_gpib_2.TabIndex = 15
        Me.DMM_gpib_2.Text = "2"
        '
        'DMM_gpib_1
        '
        Me.DMM_gpib_1.Location = New System.Drawing.Point(152, 87)
        Me.DMM_gpib_1.Name = "DMM_gpib_1"
        Me.DMM_gpib_1.Size = New System.Drawing.Size(42, 20)
        Me.DMM_gpib_1.TabIndex = 14
        Me.DMM_gpib_1.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(82, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 13
        '
        'IPaddress
        '
        Me.IPaddress.Location = New System.Drawing.Point(188, 28)
        Me.IPaddress.Name = "IPaddress"
        Me.IPaddress.Size = New System.Drawing.Size(100, 20)
        Me.IPaddress.TabIndex = 12
        Me.IPaddress.Text = "169.254.58.10"
        '
        'DMM_Name_4
        '
        Me.DMM_Name_4.Location = New System.Drawing.Point(201, 165)
        Me.DMM_Name_4.Name = "DMM_Name_4"
        Me.DMM_Name_4.Size = New System.Drawing.Size(100, 20)
        Me.DMM_Name_4.TabIndex = 10
        Me.DMM_Name_4.Text = "DMM4"
        '
        'DMM_Name_3
        '
        Me.DMM_Name_3.Location = New System.Drawing.Point(201, 139)
        Me.DMM_Name_3.Name = "DMM_Name_3"
        Me.DMM_Name_3.Size = New System.Drawing.Size(100, 20)
        Me.DMM_Name_3.TabIndex = 7
        Me.DMM_Name_3.Text = "DMM3"
        '
        'DMM_Name_2
        '
        Me.DMM_Name_2.Location = New System.Drawing.Point(201, 113)
        Me.DMM_Name_2.Name = "DMM_Name_2"
        Me.DMM_Name_2.Size = New System.Drawing.Size(100, 20)
        Me.DMM_Name_2.TabIndex = 4
        Me.DMM_Name_2.Text = "DMM2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'DMM_Name_1
        '
        Me.DMM_Name_1.Location = New System.Drawing.Point(201, 87)
        Me.DMM_Name_1.Name = "DMM_Name_1"
        Me.DMM_Name_1.Size = New System.Drawing.Size(100, 20)
        Me.DMM_Name_1.TabIndex = 1
        Me.DMM_Name_1.Text = "DMM1"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.DMMLabel4)
        Me.TabPage1.Controls.Add(Me.DMMLabel3)
        Me.TabPage1.Controls.Add(Me.DMMLabel2)
        Me.TabPage1.Controls.Add(Me.DMMLabel1)
        Me.TabPage1.Controls.Add(Me.PSU_READ_I_4)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.PSU_READ_I_3)
        Me.TabPage1.Controls.Add(Me.PSU_READ_I_2)
        Me.TabPage1.Controls.Add(Me.PSU_READ_I_1)
        Me.TabPage1.Controls.Add(Me.PSU_READ_V_4)
        Me.TabPage1.Controls.Add(Me.PSU_READ_V_3)
        Me.TabPage1.Controls.Add(Me.PSU_READ_V_2)
        Me.TabPage1.Controls.Add(Me.BUT_READ_DMM)
        Me.TabPage1.Controls.Add(Me.PSU_READ_V_1)
        Me.TabPage1.Controls.Add(Me.SCOPE_dBm_diff)
        Me.TabPage1.Controls.Add(Me.Label36)
        Me.TabPage1.Controls.Add(Me.SCOPE_Phase)
        Me.TabPage1.Controls.Add(Me.SCOPE_FREQ_2)
        Me.TabPage1.Controls.Add(Me.SCOPE_dBm_2)
        Me.TabPage1.Controls.Add(Me.SCOPE_Vrms_2)
        Me.TabPage1.Controls.Add(Me.SCOPE_Vpp_2)
        Me.TabPage1.Controls.Add(Me.SCOPE_FREQ_1)
        Me.TabPage1.Controls.Add(Me.SCOPE_dBm_1)
        Me.TabPage1.Controls.Add(Me.SCOPE_Vrms_1)
        Me.TabPage1.Controls.Add(Me.SCOPE_Vpp_1)
        Me.TabPage1.Controls.Add(Me.Label32)
        Me.TabPage1.Controls.Add(Me.Label33)
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Controls.Add(Me.Label35)
        Me.TabPage1.Controls.Add(Me.Label31)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.QuickFreq)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.Scope_Autoscale)
        Me.TabPage1.Controls.Add(Me.PSU_ON_4)
        Me.TabPage1.Controls.Add(Me.PSU_ON_3)
        Me.TabPage1.Controls.Add(Me.PSU_ON_2)
        Me.TabPage1.Controls.Add(Me.PSU_ON_1)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.PSU_I_4)
        Me.TabPage1.Controls.Add(Me.PSU_V_4)
        Me.TabPage1.Controls.Add(Me.PSULabel4)
        Me.TabPage1.Controls.Add(Me.PSU_I_3)
        Me.TabPage1.Controls.Add(Me.PSU_V_3)
        Me.TabPage1.Controls.Add(Me.PSULabel3)
        Me.TabPage1.Controls.Add(Me.PSU_I_2)
        Me.TabPage1.Controls.Add(Me.PSU_V_2)
        Me.TabPage1.Controls.Add(Me.PSULabel2)
        Me.TabPage1.Controls.Add(Me.PSU_I_1)
        Me.TabPage1.Controls.Add(Me.PSU_V_1)
        Me.TabPage1.Controls.Add(Me.PSULink12)
        Me.TabPage1.Controls.Add(Me.PSUlink34)
        Me.TabPage1.Controls.Add(Me.PSULabel1)
        Me.TabPage1.Controls.Add(Me.SigGen_FrequencyTrackBar)
        Me.TabPage1.Controls.Add(Me.Dist_measure_Voltage)
        Me.TabPage1.Controls.Add(Me.Dist_measure_DSTN)
        Me.TabPage1.Controls.Add(Me.Dist_measure_SINAD)
        Me.TabPage1.Controls.Add(Me.Dist_Amp)
        Me.TabPage1.Controls.Add(Me.DistortionChange)
        Me.TabPage1.Controls.Add(Me.Dist_freq)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.SigGen_DutyCycle)
        Me.TabPage1.Controls.Add(Me.SigGen_Signal_Type)
        Me.TabPage1.Controls.Add(Me.SigGen_Update)
        Me.TabPage1.Controls.Add(Me.SigGen_Amp_unit)
        Me.TabPage1.Controls.Add(Me.SigGen_amp)
        Me.TabPage1.Controls.Add(Me.SigGen_Sine_freq)
        Me.TabPage1.Controls.Add(Me.SignalGenLabel)
        Me.TabPage1.Controls.Add(Me.DMM_dbm_4)
        Me.TabPage1.Controls.Add(Me.DMM_Value_4)
        Me.TabPage1.Controls.Add(Me.DMM_function_4)
        Me.TabPage1.Controls.Add(Me.DMM_dbm_3)
        Me.TabPage1.Controls.Add(Me.DMM_Value_3)
        Me.TabPage1.Controls.Add(Me.DMM_function_3)
        Me.TabPage1.Controls.Add(Me.DMM_dbm_2)
        Me.TabPage1.Controls.Add(Me.DMM_Value_2)
        Me.TabPage1.Controls.Add(Me.DMM_function_2)
        Me.TabPage1.Controls.Add(Me.DMM_dbm_1)
        Me.TabPage1.Controls.Add(Me.DMM_Value_1)
        Me.TabPage1.Controls.Add(Me.DMM_function_1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1012, 514)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "INPUT"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(843, 374)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 121
        Me.Label16.Text = "Units"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(781, 374)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 120
        Me.Label15.Text = "Ampl"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(714, 374)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 13)
        Me.Label14.TabIndex = 119
        Me.Label14.Text = "DC"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(639, 374)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 118
        Me.Label13.Text = "Type"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(578, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 92)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "PSU OFF"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(568, 375)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "Frequency"
        '
        'DMMLabel4
        '
        Me.DMMLabel4.AutoSize = True
        Me.DMMLabel4.Location = New System.Drawing.Point(16, 224)
        Me.DMMLabel4.Name = "DMMLabel4"
        Me.DMMLabel4.Size = New System.Drawing.Size(42, 13)
        Me.DMMLabel4.TabIndex = 116
        Me.DMMLabel4.Text = "DMM 4"
        '
        'DMMLabel3
        '
        Me.DMMLabel3.AutoSize = True
        Me.DMMLabel3.Location = New System.Drawing.Point(16, 149)
        Me.DMMLabel3.Name = "DMMLabel3"
        Me.DMMLabel3.Size = New System.Drawing.Size(42, 13)
        Me.DMMLabel3.TabIndex = 115
        Me.DMMLabel3.Text = "DMM 3"
        '
        'DMMLabel2
        '
        Me.DMMLabel2.AutoSize = True
        Me.DMMLabel2.Location = New System.Drawing.Point(16, 82)
        Me.DMMLabel2.Name = "DMMLabel2"
        Me.DMMLabel2.Size = New System.Drawing.Size(42, 13)
        Me.DMMLabel2.TabIndex = 114
        Me.DMMLabel2.Text = "DMM 2"
        '
        'DMMLabel1
        '
        Me.DMMLabel1.AutoSize = True
        Me.DMMLabel1.Location = New System.Drawing.Point(16, 6)
        Me.DMMLabel1.Name = "DMMLabel1"
        Me.DMMLabel1.Size = New System.Drawing.Size(42, 13)
        Me.DMMLabel1.TabIndex = 113
        Me.DMMLabel1.Text = "DMM 1"
        '
        'PSU_READ_I_4
        '
        Me.PSU_READ_I_4.Location = New System.Drawing.Point(886, 328)
        Me.PSU_READ_I_4.Name = "PSU_READ_I_4"
        Me.PSU_READ_I_4.Size = New System.Drawing.Size(100, 20)
        Me.PSU_READ_I_4.TabIndex = 112
        Me.PSU_READ_I_4.Text = "PSU_READ_I_4"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(578, 127)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 93)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "PSU READ"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PSU_READ_I_3
        '
        Me.PSU_READ_I_3.Location = New System.Drawing.Point(760, 323)
        Me.PSU_READ_I_3.Name = "PSU_READ_I_3"
        Me.PSU_READ_I_3.Size = New System.Drawing.Size(100, 20)
        Me.PSU_READ_I_3.TabIndex = 111
        Me.PSU_READ_I_3.Text = "PSU_READ_I_3"
        '
        'PSU_READ_I_2
        '
        Me.PSU_READ_I_2.Location = New System.Drawing.Point(886, 144)
        Me.PSU_READ_I_2.Name = "PSU_READ_I_2"
        Me.PSU_READ_I_2.Size = New System.Drawing.Size(100, 20)
        Me.PSU_READ_I_2.TabIndex = 110
        Me.PSU_READ_I_2.Text = "PSU_READ_I_2"
        '
        'PSU_READ_I_1
        '
        Me.PSU_READ_I_1.Location = New System.Drawing.Point(762, 145)
        Me.PSU_READ_I_1.Name = "PSU_READ_I_1"
        Me.PSU_READ_I_1.Size = New System.Drawing.Size(100, 20)
        Me.PSU_READ_I_1.TabIndex = 109
        Me.PSU_READ_I_1.Text = "PSU_READ_I_1"
        '
        'PSU_READ_V_4
        '
        Me.PSU_READ_V_4.Location = New System.Drawing.Point(886, 298)
        Me.PSU_READ_V_4.Name = "PSU_READ_V_4"
        Me.PSU_READ_V_4.Size = New System.Drawing.Size(100, 20)
        Me.PSU_READ_V_4.TabIndex = 108
        Me.PSU_READ_V_4.Text = "PSU_READ_V_4"
        '
        'PSU_READ_V_3
        '
        Me.PSU_READ_V_3.Location = New System.Drawing.Point(760, 298)
        Me.PSU_READ_V_3.Name = "PSU_READ_V_3"
        Me.PSU_READ_V_3.Size = New System.Drawing.Size(100, 20)
        Me.PSU_READ_V_3.TabIndex = 107
        Me.PSU_READ_V_3.Text = "PSU_READ_V_3"
        '
        'PSU_READ_V_2
        '
        Me.PSU_READ_V_2.Location = New System.Drawing.Point(886, 118)
        Me.PSU_READ_V_2.Name = "PSU_READ_V_2"
        Me.PSU_READ_V_2.Size = New System.Drawing.Size(100, 20)
        Me.PSU_READ_V_2.TabIndex = 106
        Me.PSU_READ_V_2.Text = "PSU_READ_V_2"
        '
        'BUT_READ_DMM
        '
        Me.BUT_READ_DMM.Location = New System.Drawing.Point(578, 6)
        Me.BUT_READ_DMM.Name = "BUT_READ_DMM"
        Me.BUT_READ_DMM.Size = New System.Drawing.Size(118, 95)
        Me.BUT_READ_DMM.TabIndex = 3
        Me.BUT_READ_DMM.Text = "READ DMM"
        Me.BUT_READ_DMM.UseVisualStyleBackColor = True
        '
        'PSU_READ_V_1
        '
        Me.PSU_READ_V_1.Location = New System.Drawing.Point(762, 117)
        Me.PSU_READ_V_1.Name = "PSU_READ_V_1"
        Me.PSU_READ_V_1.Size = New System.Drawing.Size(100, 20)
        Me.PSU_READ_V_1.TabIndex = 105
        Me.PSU_READ_V_1.Text = "PSU_READ_V_1"
        '
        'SCOPE_dBm_diff
        '
        Me.SCOPE_dBm_diff.Location = New System.Drawing.Point(231, 378)
        Me.SCOPE_dBm_diff.Name = "SCOPE_dBm_diff"
        Me.SCOPE_dBm_diff.Size = New System.Drawing.Size(64, 20)
        Me.SCOPE_dBm_diff.TabIndex = 100
        Me.SCOPE_dBm_diff.Text = "SCOPE_dBm_diff"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(174, 427)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 13)
        Me.Label36.TabIndex = 99
        Me.Label36.Text = "Phase Diff"
        '
        'SCOPE_Phase
        '
        Me.SCOPE_Phase.Location = New System.Drawing.Point(232, 424)
        Me.SCOPE_Phase.Name = "SCOPE_Phase"
        Me.SCOPE_Phase.Size = New System.Drawing.Size(64, 20)
        Me.SCOPE_Phase.TabIndex = 98
        Me.SCOPE_Phase.Text = "SCOPE_Phase"
        '
        'SCOPE_FREQ_2
        '
        Me.SCOPE_FREQ_2.Location = New System.Drawing.Point(338, 401)
        Me.SCOPE_FREQ_2.Name = "SCOPE_FREQ_2"
        Me.SCOPE_FREQ_2.Size = New System.Drawing.Size(100, 20)
        Me.SCOPE_FREQ_2.TabIndex = 97
        Me.SCOPE_FREQ_2.Text = "SCOPE_FREQ_2"
        '
        'SCOPE_dBm_2
        '
        Me.SCOPE_dBm_2.Location = New System.Drawing.Point(338, 378)
        Me.SCOPE_dBm_2.Name = "SCOPE_dBm_2"
        Me.SCOPE_dBm_2.Size = New System.Drawing.Size(100, 20)
        Me.SCOPE_dBm_2.TabIndex = 96
        Me.SCOPE_dBm_2.Text = "SCOPE_dBm_2"
        '
        'SCOPE_Vrms_2
        '
        Me.SCOPE_Vrms_2.Location = New System.Drawing.Point(338, 355)
        Me.SCOPE_Vrms_2.Name = "SCOPE_Vrms_2"
        Me.SCOPE_Vrms_2.Size = New System.Drawing.Size(100, 20)
        Me.SCOPE_Vrms_2.TabIndex = 95
        Me.SCOPE_Vrms_2.Text = "SCOPE_Vrms_2"
        '
        'SCOPE_Vpp_2
        '
        Me.SCOPE_Vpp_2.Location = New System.Drawing.Point(338, 332)
        Me.SCOPE_Vpp_2.Name = "SCOPE_Vpp_2"
        Me.SCOPE_Vpp_2.Size = New System.Drawing.Size(100, 20)
        Me.SCOPE_Vpp_2.TabIndex = 94
        Me.SCOPE_Vpp_2.Text = "SCOPE_Vpp_2"
        '
        'SCOPE_FREQ_1
        '
        Me.SCOPE_FREQ_1.Location = New System.Drawing.Point(86, 401)
        Me.SCOPE_FREQ_1.Name = "SCOPE_FREQ_1"
        Me.SCOPE_FREQ_1.Size = New System.Drawing.Size(100, 20)
        Me.SCOPE_FREQ_1.TabIndex = 93
        Me.SCOPE_FREQ_1.Text = "SCOPE_FREQ_1"
        '
        'SCOPE_dBm_1
        '
        Me.SCOPE_dBm_1.Location = New System.Drawing.Point(85, 378)
        Me.SCOPE_dBm_1.Name = "SCOPE_dBm_1"
        Me.SCOPE_dBm_1.Size = New System.Drawing.Size(100, 20)
        Me.SCOPE_dBm_1.TabIndex = 92
        Me.SCOPE_dBm_1.Text = "SCOPE_dBm_1"
        '
        'SCOPE_Vrms_1
        '
        Me.SCOPE_Vrms_1.Location = New System.Drawing.Point(85, 355)
        Me.SCOPE_Vrms_1.Name = "SCOPE_Vrms_1"
        Me.SCOPE_Vrms_1.Size = New System.Drawing.Size(100, 20)
        Me.SCOPE_Vrms_1.TabIndex = 91
        Me.SCOPE_Vrms_1.Text = "SCOPE_Vrms_1"
        '
        'SCOPE_Vpp_1
        '
        Me.SCOPE_Vpp_1.Location = New System.Drawing.Point(85, 331)
        Me.SCOPE_Vpp_1.Name = "SCOPE_Vpp_1"
        Me.SCOPE_Vpp_1.Size = New System.Drawing.Size(100, 20)
        Me.SCOPE_Vpp_1.TabIndex = 90
        Me.SCOPE_Vpp_1.Text = "SCOPE_Vpp_1"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(305, 395)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(25, 13)
        Me.Label32.TabIndex = 88
        Me.Label32.Text = "freq"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(301, 376)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(28, 13)
        Me.Label33.TabIndex = 87
        Me.Label33.Text = "dBm"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(301, 357)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(30, 13)
        Me.Label34.TabIndex = 86
        Me.Label34.Text = "Vrms"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(301, 338)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(26, 13)
        Me.Label35.TabIndex = 85
        Me.Label35.Text = "Vpp"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(53, 405)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(25, 13)
        Me.Label31.TabIndex = 84
        Me.Label31.Text = "freq"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(49, 380)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(28, 13)
        Me.Label30.TabIndex = 83
        Me.Label30.Text = "dBm"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(49, 358)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(30, 13)
        Me.Label29.TabIndex = 82
        Me.Label29.Text = "Vrms"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(49, 334)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(26, 13)
        Me.Label28.TabIndex = 81
        Me.Label28.Text = "Vpp"
        '
        'QuickFreq
        '
        Me.QuickFreq.Controls.Add(Me.RadioButton9)
        Me.QuickFreq.Controls.Add(Me.RadioButton8)
        Me.QuickFreq.Controls.Add(Me.RadioButton7)
        Me.QuickFreq.Controls.Add(Me.RadioButton6)
        Me.QuickFreq.Controls.Add(Me.RadioButton5)
        Me.QuickFreq.Controls.Add(Me.RadioButton4)
        Me.QuickFreq.Controls.Add(Me.RadioButton3)
        Me.QuickFreq.Controls.Add(Me.RadioButton2)
        Me.QuickFreq.Controls.Add(Me.RadioButton1)
        Me.QuickFreq.Location = New System.Drawing.Point(487, 443)
        Me.QuickFreq.Name = "QuickFreq"
        Me.QuickFreq.Size = New System.Drawing.Size(507, 36)
        Me.QuickFreq.TabIndex = 79
        Me.QuickFreq.TabStop = False
        Me.QuickFreq.Text = "Quick Freq"
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(210, 13)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton9.TabIndex = 8
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "5kHz"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(159, 13)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton8.TabIndex = 7
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "2kHz"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(379, 13)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "50kHz"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(319, 13)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "20kHz"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(5, 13)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "10Hz"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(437, 13)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "100kHz"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(260, 13)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "10kHz"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(110, 13)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "1kHz"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(55, 13)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "100Hz"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(265, 339)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 13)
        Me.Label27.TabIndex = 71
        Me.Label27.Text = "CH 2"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(12, 339)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(31, 13)
        Me.Label26.TabIndex = 70
        Me.Label26.Text = "CH 1"
        '
        'Scope_Autoscale
        '
        Me.Scope_Autoscale.Location = New System.Drawing.Point(271, 450)
        Me.Scope_Autoscale.Name = "Scope_Autoscale"
        Me.Scope_Autoscale.Size = New System.Drawing.Size(105, 23)
        Me.Scope_Autoscale.TabIndex = 69
        Me.Scope_Autoscale.Text = "SCOPE AUTOSCALE"
        Me.Scope_Autoscale.UseVisualStyleBackColor = True
        '
        'PSU_ON_4
        '
        Me.PSU_ON_4.Location = New System.Drawing.Point(902, 269)
        Me.PSU_ON_4.Name = "PSU_ON_4"
        Me.PSU_ON_4.Size = New System.Drawing.Size(65, 23)
        Me.PSU_ON_4.TabIndex = 60
        Me.PSU_ON_4.Text = "ON"
        Me.PSU_ON_4.UseVisualStyleBackColor = True
        '
        'PSU_ON_3
        '
        Me.PSU_ON_3.Location = New System.Drawing.Point(775, 268)
        Me.PSU_ON_3.Name = "PSU_ON_3"
        Me.PSU_ON_3.Size = New System.Drawing.Size(65, 23)
        Me.PSU_ON_3.TabIndex = 59
        Me.PSU_ON_3.Text = "ON"
        Me.PSU_ON_3.UseVisualStyleBackColor = True
        '
        'PSU_ON_2
        '
        Me.PSU_ON_2.Location = New System.Drawing.Point(904, 87)
        Me.PSU_ON_2.Name = "PSU_ON_2"
        Me.PSU_ON_2.Size = New System.Drawing.Size(65, 23)
        Me.PSU_ON_2.TabIndex = 58
        Me.PSU_ON_2.Text = "ON"
        Me.PSU_ON_2.UseVisualStyleBackColor = True
        '
        'PSU_ON_1
        '
        Me.PSU_ON_1.Location = New System.Drawing.Point(777, 86)
        Me.PSU_ON_1.Name = "PSU_ON_1"
        Me.PSU_ON_1.Size = New System.Drawing.Size(65, 23)
        Me.PSU_ON_1.TabIndex = 57
        Me.PSU_ON_1.Text = "ON"
        Me.PSU_ON_1.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(759, 240)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(10, 13)
        Me.Label24.TabIndex = 56
        Me.Label24.Text = "I"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(759, 207)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(14, 13)
        Me.Label25.TabIndex = 55
        Me.Label25.Text = "V"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(757, 47)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(10, 13)
        Me.Label23.TabIndex = 54
        Me.Label23.Text = "I"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(757, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 13)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "V"
        '
        'PSU_I_4
        '
        Me.PSU_I_4.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSU_I_4.Location = New System.Drawing.Point(902, 239)
        Me.PSU_I_4.Name = "PSU_I_4"
        Me.PSU_I_4.Size = New System.Drawing.Size(65, 34)
        Me.PSU_I_4.TabIndex = 52
        Me.PSU_I_4.Text = ".3"
        '
        'PSU_V_4
        '
        Me.PSU_V_4.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSU_V_4.Location = New System.Drawing.Point(902, 206)
        Me.PSU_V_4.Name = "PSU_V_4"
        Me.PSU_V_4.Size = New System.Drawing.Size(65, 34)
        Me.PSU_V_4.TabIndex = 51
        Me.PSU_V_4.Text = "25"
        '
        'PSULabel4
        '
        Me.PSULabel4.AutoSize = True
        Me.PSULabel4.Location = New System.Drawing.Point(899, 190)
        Me.PSULabel4.Name = "PSULabel4"
        Me.PSULabel4.Size = New System.Drawing.Size(57, 13)
        Me.PSULabel4.TabIndex = 50
        Me.PSULabel4.Text = "POWER 4"
        '
        'PSU_I_3
        '
        Me.PSU_I_3.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSU_I_3.Location = New System.Drawing.Point(775, 238)
        Me.PSU_I_3.Name = "PSU_I_3"
        Me.PSU_I_3.Size = New System.Drawing.Size(65, 34)
        Me.PSU_I_3.TabIndex = 49
        Me.PSU_I_3.Text = ".3"
        '
        'PSU_V_3
        '
        Me.PSU_V_3.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSU_V_3.Location = New System.Drawing.Point(775, 205)
        Me.PSU_V_3.Name = "PSU_V_3"
        Me.PSU_V_3.Size = New System.Drawing.Size(65, 34)
        Me.PSU_V_3.TabIndex = 48
        Me.PSU_V_3.Text = "25"
        '
        'PSULabel3
        '
        Me.PSULabel3.AutoSize = True
        Me.PSULabel3.Location = New System.Drawing.Point(772, 189)
        Me.PSULabel3.Name = "PSULabel3"
        Me.PSULabel3.Size = New System.Drawing.Size(57, 13)
        Me.PSULabel3.TabIndex = 47
        Me.PSULabel3.Text = "POWER 3"
        '
        'PSU_I_2
        '
        Me.PSU_I_2.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSU_I_2.Location = New System.Drawing.Point(904, 57)
        Me.PSU_I_2.Name = "PSU_I_2"
        Me.PSU_I_2.Size = New System.Drawing.Size(65, 34)
        Me.PSU_I_2.TabIndex = 46
        Me.PSU_I_2.Text = ".3"
        '
        'PSU_V_2
        '
        Me.PSU_V_2.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSU_V_2.Location = New System.Drawing.Point(904, 24)
        Me.PSU_V_2.Name = "PSU_V_2"
        Me.PSU_V_2.Size = New System.Drawing.Size(65, 34)
        Me.PSU_V_2.TabIndex = 45
        Me.PSU_V_2.Text = "15"
        '
        'PSULabel2
        '
        Me.PSULabel2.AutoSize = True
        Me.PSULabel2.Location = New System.Drawing.Point(901, 8)
        Me.PSULabel2.Name = "PSULabel2"
        Me.PSULabel2.Size = New System.Drawing.Size(57, 13)
        Me.PSULabel2.TabIndex = 44
        Me.PSULabel2.Text = "POWER 2"
        '
        'PSU_I_1
        '
        Me.PSU_I_1.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSU_I_1.Location = New System.Drawing.Point(777, 56)
        Me.PSU_I_1.Name = "PSU_I_1"
        Me.PSU_I_1.Size = New System.Drawing.Size(65, 34)
        Me.PSU_I_1.TabIndex = 43
        Me.PSU_I_1.Text = ".3"
        '
        'PSU_V_1
        '
        Me.PSU_V_1.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSU_V_1.Location = New System.Drawing.Point(777, 23)
        Me.PSU_V_1.Name = "PSU_V_1"
        Me.PSU_V_1.Size = New System.Drawing.Size(65, 34)
        Me.PSU_V_1.TabIndex = 42
        Me.PSU_V_1.Text = "15"
        '
        'PSULink12
        '
        Me.PSULink12.AutoSize = True
        Me.PSULink12.Location = New System.Drawing.Point(848, 25)
        Me.PSULink12.Name = "PSULink12"
        Me.PSULink12.Size = New System.Drawing.Size(50, 17)
        Me.PSULink12.TabIndex = 41
        Me.PSULink12.Text = "LINK"
        Me.PSULink12.UseVisualStyleBackColor = True
        '
        'PSUlink34
        '
        Me.PSUlink34.AutoSize = True
        Me.PSUlink34.Location = New System.Drawing.Point(846, 209)
        Me.PSUlink34.Name = "PSUlink34"
        Me.PSUlink34.Size = New System.Drawing.Size(50, 17)
        Me.PSUlink34.TabIndex = 40
        Me.PSUlink34.Text = "LINK"
        Me.PSUlink34.UseVisualStyleBackColor = True
        '
        'PSULabel1
        '
        Me.PSULabel1.AutoSize = True
        Me.PSULabel1.Location = New System.Drawing.Point(774, 7)
        Me.PSULabel1.Name = "PSULabel1"
        Me.PSULabel1.Size = New System.Drawing.Size(57, 13)
        Me.PSULabel1.TabIndex = 39
        Me.PSULabel1.Text = "POWER 1"
        '
        'SigGen_FrequencyTrackBar
        '
        Me.SigGen_FrequencyTrackBar.BackColor = System.Drawing.SystemColors.Window
        Me.SigGen_FrequencyTrackBar.Location = New System.Drawing.Point(510, 420)
        Me.SigGen_FrequencyTrackBar.Maximum = 100000
        Me.SigGen_FrequencyTrackBar.Name = "SigGen_FrequencyTrackBar"
        Me.SigGen_FrequencyTrackBar.Size = New System.Drawing.Size(473, 42)
        Me.SigGen_FrequencyTrackBar.SmallChange = 100
        Me.SigGen_FrequencyTrackBar.TabIndex = 38
        Me.SigGen_FrequencyTrackBar.TickFrequency = 1000
        Me.SigGen_FrequencyTrackBar.Value = 50
        '
        'Dist_measure_Voltage
        '
        Me.Dist_measure_Voltage.Location = New System.Drawing.Point(423, 293)
        Me.Dist_measure_Voltage.Name = "Dist_measure_Voltage"
        Me.Dist_measure_Voltage.Size = New System.Drawing.Size(60, 20)
        Me.Dist_measure_Voltage.TabIndex = 37
        '
        'Dist_measure_DSTN
        '
        Me.Dist_measure_DSTN.Location = New System.Drawing.Point(357, 293)
        Me.Dist_measure_DSTN.Name = "Dist_measure_DSTN"
        Me.Dist_measure_DSTN.Size = New System.Drawing.Size(60, 20)
        Me.Dist_measure_DSTN.TabIndex = 36
        '
        'Dist_measure_SINAD
        '
        Me.Dist_measure_SINAD.Location = New System.Drawing.Point(290, 293)
        Me.Dist_measure_SINAD.Name = "Dist_measure_SINAD"
        Me.Dist_measure_SINAD.Size = New System.Drawing.Size(60, 20)
        Me.Dist_measure_SINAD.TabIndex = 35
        '
        'Dist_Amp
        '
        Me.Dist_Amp.Location = New System.Drawing.Point(142, 293)
        Me.Dist_Amp.Name = "Dist_Amp"
        Me.Dist_Amp.Size = New System.Drawing.Size(54, 20)
        Me.Dist_Amp.TabIndex = 34
        Me.Dist_Amp.Text = "1"
        '
        'DistortionChange
        '
        Me.DistortionChange.Location = New System.Drawing.Point(202, 293)
        Me.DistortionChange.Name = "DistortionChange"
        Me.DistortionChange.Size = New System.Drawing.Size(75, 23)
        Me.DistortionChange.TabIndex = 33
        Me.DistortionChange.Text = "Distortion Update "
        Me.DistortionChange.UseVisualStyleBackColor = True
        '
        'Dist_freq
        '
        Me.Dist_freq.Location = New System.Drawing.Point(81, 293)
        Me.Dist_freq.Name = "Dist_freq"
        Me.Dist_freq.Size = New System.Drawing.Size(55, 20)
        Me.Dist_freq.TabIndex = 32
        Me.Dist_freq.Text = "1000"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 293)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Distortion"
        '
        'SigGen_DutyCycle
        '
        Me.SigGen_DutyCycle.BackColor = System.Drawing.SystemColors.Window
        Me.SigGen_DutyCycle.Location = New System.Drawing.Point(712, 390)
        Me.SigGen_DutyCycle.Maximum = 100
        Me.SigGen_DutyCycle.Name = "SigGen_DutyCycle"
        Me.SigGen_DutyCycle.Size = New System.Drawing.Size(63, 42)
        Me.SigGen_DutyCycle.TabIndex = 30
        Me.SigGen_DutyCycle.Value = 50
        '
        'SigGen_Signal_Type
        '
        Me.SigGen_Signal_Type.FormattingEnabled = True
        Me.SigGen_Signal_Type.Items.AddRange(New Object() {"SIN", "SQU", "RAMP", "PULS", "NOISE"})
        Me.SigGen_Signal_Type.Location = New System.Drawing.Point(636, 390)
        Me.SigGen_Signal_Type.Name = "SigGen_Signal_Type"
        Me.SigGen_Signal_Type.Size = New System.Drawing.Size(70, 21)
        Me.SigGen_Signal_Type.TabIndex = 29
        '
        'SigGen_Update
        '
        Me.SigGen_Update.Location = New System.Drawing.Point(894, 391)
        Me.SigGen_Update.Name = "SigGen_Update"
        Me.SigGen_Update.Size = New System.Drawing.Size(75, 23)
        Me.SigGen_Update.TabIndex = 28
        Me.SigGen_Update.Text = "UPDATE"
        Me.SigGen_Update.UseVisualStyleBackColor = True
        '
        'SigGen_Amp_unit
        '
        Me.SigGen_Amp_unit.FormattingEnabled = True
        Me.SigGen_Amp_unit.Items.AddRange(New Object() {"Vpp", "Vrms", "dBm"})
        Me.SigGen_Amp_unit.Location = New System.Drawing.Point(841, 393)
        Me.SigGen_Amp_unit.Name = "SigGen_Amp_unit"
        Me.SigGen_Amp_unit.Size = New System.Drawing.Size(47, 21)
        Me.SigGen_Amp_unit.TabIndex = 27
        '
        'SigGen_amp
        '
        Me.SigGen_amp.Location = New System.Drawing.Point(781, 393)
        Me.SigGen_amp.Name = "SigGen_amp"
        Me.SigGen_amp.Size = New System.Drawing.Size(54, 20)
        Me.SigGen_amp.TabIndex = 26
        Me.SigGen_amp.Text = "1"
        '
        'SigGen_Sine_freq
        '
        Me.SigGen_Sine_freq.Location = New System.Drawing.Point(572, 391)
        Me.SigGen_Sine_freq.Name = "SigGen_Sine_freq"
        Me.SigGen_Sine_freq.Size = New System.Drawing.Size(55, 20)
        Me.SigGen_Sine_freq.TabIndex = 25
        Me.SigGen_Sine_freq.Text = "1000"
        '
        'SignalGenLabel
        '
        Me.SignalGenLabel.AutoSize = True
        Me.SignalGenLabel.Location = New System.Drawing.Point(507, 393)
        Me.SignalGenLabel.Name = "SignalGenLabel"
        Me.SignalGenLabel.Size = New System.Drawing.Size(59, 13)
        Me.SignalGenLabel.TabIndex = 22
        Me.SignalGenLabel.Text = "Signal Gen"
        '
        'DMM_dbm_4
        '
        Me.DMM_dbm_4.Location = New System.Drawing.Point(290, 226)
        Me.DMM_dbm_4.Name = "DMM_dbm_4"
        Me.DMM_dbm_4.Size = New System.Drawing.Size(161, 20)
        Me.DMM_dbm_4.TabIndex = 20
        Me.DMM_dbm_4.Text = "DMM_dbm_4"
        '
        'DMM_Value_4
        '
        Me.DMM_Value_4.Font = New System.Drawing.Font("Arial Black", 15.0!)
        Me.DMM_Value_4.Location = New System.Drawing.Point(87, 226)
        Me.DMM_Value_4.Name = "DMM_Value_4"
        Me.DMM_Value_4.Size = New System.Drawing.Size(289, 36)
        Me.DMM_Value_4.TabIndex = 19
        Me.DMM_Value_4.Text = "DMM_Value_4"
        '
        'DMM_function_4
        '
        Me.DMM_function_4.FormattingEnabled = True
        Me.DMM_function_4.Items.AddRange(New Object() {"V DC", "I DC", "V AC", "I AC", "R 2W", "R 4W", "Diode", "Capacitance", "Freq", "Period", "Continuity"})
        Me.DMM_function_4.Location = New System.Drawing.Point(16, 240)
        Me.DMM_function_4.Name = "DMM_function_4"
        Me.DMM_function_4.Size = New System.Drawing.Size(65, 21)
        Me.DMM_function_4.TabIndex = 17
        Me.DMM_function_4.Text = "Function"
        '
        'DMM_dbm_3
        '
        Me.DMM_dbm_3.Location = New System.Drawing.Point(291, 149)
        Me.DMM_dbm_3.Name = "DMM_dbm_3"
        Me.DMM_dbm_3.Size = New System.Drawing.Size(161, 20)
        Me.DMM_dbm_3.TabIndex = 16
        Me.DMM_dbm_3.Text = "DMM_dbm_3"
        '
        'DMM_Value_3
        '
        Me.DMM_Value_3.Font = New System.Drawing.Font("Arial Black", 15.0!)
        Me.DMM_Value_3.Location = New System.Drawing.Point(87, 149)
        Me.DMM_Value_3.Name = "DMM_Value_3"
        Me.DMM_Value_3.Size = New System.Drawing.Size(289, 36)
        Me.DMM_Value_3.TabIndex = 15
        Me.DMM_Value_3.Text = "DMM_Value_3"
        '
        'DMM_function_3
        '
        Me.DMM_function_3.FormattingEnabled = True
        Me.DMM_function_3.Items.AddRange(New Object() {"V DC", "I DC", "V AC", "I AC", "R 2W", "R 4W", "Diode", "Capacitance", "Freq", "Period", "Continuity"})
        Me.DMM_function_3.Location = New System.Drawing.Point(16, 162)
        Me.DMM_function_3.Name = "DMM_function_3"
        Me.DMM_function_3.Size = New System.Drawing.Size(65, 21)
        Me.DMM_function_3.TabIndex = 13
        Me.DMM_function_3.Text = "Function"
        '
        'DMM_dbm_2
        '
        Me.DMM_dbm_2.Location = New System.Drawing.Point(290, 82)
        Me.DMM_dbm_2.Name = "DMM_dbm_2"
        Me.DMM_dbm_2.Size = New System.Drawing.Size(161, 20)
        Me.DMM_dbm_2.TabIndex = 12
        Me.DMM_dbm_2.Text = "DMM_dbm_2"
        '
        'DMM_Value_2
        '
        Me.DMM_Value_2.Font = New System.Drawing.Font("Arial Black", 15.0!)
        Me.DMM_Value_2.Location = New System.Drawing.Point(87, 82)
        Me.DMM_Value_2.Name = "DMM_Value_2"
        Me.DMM_Value_2.Size = New System.Drawing.Size(289, 36)
        Me.DMM_Value_2.TabIndex = 11
        Me.DMM_Value_2.Text = "DMM_Value_2"
        '
        'DMM_function_2
        '
        Me.DMM_function_2.FormattingEnabled = True
        Me.DMM_function_2.Items.AddRange(New Object() {"V DC", "I DC", "V AC", "I AC", "R 2W", "R 4W", "Diode", "Capacitance", "Freq", "Period", "Continuity"})
        Me.DMM_function_2.Location = New System.Drawing.Point(16, 95)
        Me.DMM_function_2.Name = "DMM_function_2"
        Me.DMM_function_2.Size = New System.Drawing.Size(65, 21)
        Me.DMM_function_2.TabIndex = 9
        Me.DMM_function_2.Text = "Function"
        '
        'DMM_dbm_1
        '
        Me.DMM_dbm_1.Location = New System.Drawing.Point(290, 7)
        Me.DMM_dbm_1.Name = "DMM_dbm_1"
        Me.DMM_dbm_1.Size = New System.Drawing.Size(161, 20)
        Me.DMM_dbm_1.TabIndex = 6
        Me.DMM_dbm_1.Text = "DMM_dbm_1"
        '
        'DMM_Value_1
        '
        Me.DMM_Value_1.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DMM_Value_1.Location = New System.Drawing.Point(87, 7)
        Me.DMM_Value_1.Name = "DMM_Value_1"
        Me.DMM_Value_1.Size = New System.Drawing.Size(289, 36)
        Me.DMM_Value_1.TabIndex = 4
        Me.DMM_Value_1.Text = "DMM_Value_1"
        '
        'DMM_function_1
        '
        Me.DMM_function_1.FormattingEnabled = True
        Me.DMM_function_1.Items.AddRange(New Object() {"V DC", "I DC", "V AC", "I AC", "R 2W", "R 4W", "Diode", "Capacitance", "Freq", "Period", "Continuity"})
        Me.DMM_function_1.Location = New System.Drawing.Point(16, 23)
        Me.DMM_function_1.Name = "DMM_function_1"
        Me.DMM_function_1.Size = New System.Drawing.Size(65, 21)
        Me.DMM_function_1.TabIndex = 1
        Me.DMM_function_1.Text = "Function"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Rigol_Time_Scale)
        Me.TabPage2.Controls.Add(Me.Rigol_Time_Base)
        Me.TabPage2.Controls.Add(Me.RigolIPAddres)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Rigol_update_CH1)
        Me.TabPage2.Controls.Add(Me.Rigol_update_CH4)
        Me.TabPage2.Controls.Add(Me.Rigol_update_CH3)
        Me.TabPage2.Controls.Add(Me.Rigol_update_CH2)
        Me.TabPage2.Controls.Add(Me.Rigol_Data_Grid_4)
        Me.TabPage2.Controls.Add(Me.Rigol_Data_Grid_3)
        Me.TabPage2.Controls.Add(Me.Rigol_Data_Grid_2)
        Me.TabPage2.Controls.Add(Me.Rigol_Data_Grid_1)
        Me.TabPage2.Controls.Add(Me.Rigol_GetSCOPEDATA)
        Me.TabPage2.Controls.Add(Me.Rigol_Freq_4)
        Me.TabPage2.Controls.Add(Me.Rigol_dBm_4)
        Me.TabPage2.Controls.Add(Me.Rigol_Vrms_4)
        Me.TabPage2.Controls.Add(Me.Rigol_Vpp_4)
        Me.TabPage2.Controls.Add(Me.Label39)
        Me.TabPage2.Controls.Add(Me.Label40)
        Me.TabPage2.Controls.Add(Me.Label41)
        Me.TabPage2.Controls.Add(Me.Label42)
        Me.TabPage2.Controls.Add(Me.Rigol_Freq_3)
        Me.TabPage2.Controls.Add(Me.Rigol_dBm_3)
        Me.TabPage2.Controls.Add(Me.Rigol_Vrms_3)
        Me.TabPage2.Controls.Add(Me.Rigol_Vpp_3)
        Me.TabPage2.Controls.Add(Me.Label43)
        Me.TabPage2.Controls.Add(Me.Label44)
        Me.TabPage2.Controls.Add(Me.Label45)
        Me.TabPage2.Controls.Add(Me.Label46)
        Me.TabPage2.Controls.Add(Me.Rigol_Freq_2)
        Me.TabPage2.Controls.Add(Me.Rigol_dBm_2)
        Me.TabPage2.Controls.Add(Me.Rigol_Vrms_2)
        Me.TabPage2.Controls.Add(Me.Rigol_Vpp_2)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Rigol_Freq_1)
        Me.TabPage2.Controls.Add(Me.Rigol_dBm_1)
        Me.TabPage2.Controls.Add(Me.Rigol_Vrms_1)
        Me.TabPage2.Controls.Add(Me.Rigol_Vpp_1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Connecttoscope)
        Me.TabPage2.Controls.Add(Me.Rigol_Chart_1)
        Me.TabPage2.Controls.Add(Me.Rigol_Chart_2)
        Me.TabPage2.Controls.Add(Me.Rigol_Chart_3)
        Me.TabPage2.Controls.Add(Me.Rigol_Chart_4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1012, 514)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rigol"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Rigol_Time_Scale
        '
        Me.Rigol_Time_Scale.AutoSize = True
        Me.Rigol_Time_Scale.Location = New System.Drawing.Point(463, 13)
        Me.Rigol_Time_Scale.Name = "Rigol_Time_Scale"
        Me.Rigol_Time_Scale.Size = New System.Drawing.Size(45, 13)
        Me.Rigol_Time_Scale.TabIndex = 152
        Me.Rigol_Time_Scale.Text = "Label20"
        '
        'Rigol_Time_Base
        '
        Me.Rigol_Time_Base.Location = New System.Drawing.Point(354, 10)
        Me.Rigol_Time_Base.Name = "Rigol_Time_Base"
        Me.Rigol_Time_Base.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Time_Base.TabIndex = 151
        '
        'RigolIPAddres
        '
        Me.RigolIPAddres.Location = New System.Drawing.Point(102, 13)
        Me.RigolIPAddres.Name = "RigolIPAddres"
        Me.RigolIPAddres.Size = New System.Drawing.Size(100, 20)
        Me.RigolIPAddres.TabIndex = 150
        Me.RigolIPAddres.Text = "169.254.1.5"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(524, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 149
        Me.Button1.Text = "AutoScale"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Rigol_update_CH1
        '
        Me.Rigol_update_CH1.Location = New System.Drawing.Point(370, 150)
        Me.Rigol_update_CH1.Name = "Rigol_update_CH1"
        Me.Rigol_update_CH1.Size = New System.Drawing.Size(75, 23)
        Me.Rigol_update_CH1.TabIndex = 145
        Me.Rigol_update_CH1.Text = "CH 1"
        Me.Rigol_update_CH1.UseVisualStyleBackColor = True
        '
        'Rigol_update_CH4
        '
        Me.Rigol_update_CH4.Location = New System.Drawing.Point(863, 406)
        Me.Rigol_update_CH4.Name = "Rigol_update_CH4"
        Me.Rigol_update_CH4.Size = New System.Drawing.Size(75, 23)
        Me.Rigol_update_CH4.TabIndex = 144
        Me.Rigol_update_CH4.Text = "CH 4"
        Me.Rigol_update_CH4.UseVisualStyleBackColor = True
        '
        'Rigol_update_CH3
        '
        Me.Rigol_update_CH3.Location = New System.Drawing.Point(370, 365)
        Me.Rigol_update_CH3.Name = "Rigol_update_CH3"
        Me.Rigol_update_CH3.Size = New System.Drawing.Size(75, 23)
        Me.Rigol_update_CH3.TabIndex = 143
        Me.Rigol_update_CH3.Text = "CH 3"
        Me.Rigol_update_CH3.UseVisualStyleBackColor = True
        '
        'Rigol_update_CH2
        '
        Me.Rigol_update_CH2.Location = New System.Drawing.Point(884, 150)
        Me.Rigol_update_CH2.Name = "Rigol_update_CH2"
        Me.Rigol_update_CH2.Size = New System.Drawing.Size(75, 23)
        Me.Rigol_update_CH2.TabIndex = 142
        Me.Rigol_update_CH2.Text = "CH 2"
        Me.Rigol_update_CH2.UseVisualStyleBackColor = True
        '
        'Rigol_Data_Grid_4
        '
        Me.Rigol_Data_Grid_4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rigol_Data_Grid_4.Location = New System.Drawing.Point(983, 268)
        Me.Rigol_Data_Grid_4.Name = "Rigol_Data_Grid_4"
        Me.Rigol_Data_Grid_4.RowHeadersVisible = False
        Me.Rigol_Data_Grid_4.Size = New System.Drawing.Size(76, 150)
        Me.Rigol_Data_Grid_4.TabIndex = 139
        '
        'Rigol_Data_Grid_3
        '
        Me.Rigol_Data_Grid_3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rigol_Data_Grid_3.Location = New System.Drawing.Point(466, 268)
        Me.Rigol_Data_Grid_3.Name = "Rigol_Data_Grid_3"
        Me.Rigol_Data_Grid_3.RowHeadersVisible = False
        Me.Rigol_Data_Grid_3.Size = New System.Drawing.Size(76, 150)
        Me.Rigol_Data_Grid_3.TabIndex = 138
        '
        'Rigol_Data_Grid_2
        '
        Me.Rigol_Data_Grid_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rigol_Data_Grid_2.Location = New System.Drawing.Point(983, 54)
        Me.Rigol_Data_Grid_2.Name = "Rigol_Data_Grid_2"
        Me.Rigol_Data_Grid_2.RowHeadersVisible = False
        Me.Rigol_Data_Grid_2.Size = New System.Drawing.Size(76, 150)
        Me.Rigol_Data_Grid_2.TabIndex = 137
        '
        'Rigol_Data_Grid_1
        '
        Me.Rigol_Data_Grid_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rigol_Data_Grid_1.Location = New System.Drawing.Point(466, 54)
        Me.Rigol_Data_Grid_1.Name = "Rigol_Data_Grid_1"
        Me.Rigol_Data_Grid_1.RowHeadersVisible = False
        Me.Rigol_Data_Grid_1.Size = New System.Drawing.Size(76, 150)
        Me.Rigol_Data_Grid_1.TabIndex = 136
        '
        'Rigol_GetSCOPEDATA
        '
        Me.Rigol_GetSCOPEDATA.Location = New System.Drawing.Point(208, 10)
        Me.Rigol_GetSCOPEDATA.Name = "Rigol_GetSCOPEDATA"
        Me.Rigol_GetSCOPEDATA.Size = New System.Drawing.Size(140, 23)
        Me.Rigol_GetSCOPEDATA.TabIndex = 135
        Me.Rigol_GetSCOPEDATA.Text = "Get Scope Data"
        Me.Rigol_GetSCOPEDATA.UseVisualStyleBackColor = True
        '
        'Rigol_Freq_4
        '
        Me.Rigol_Freq_4.Location = New System.Drawing.Point(889, 338)
        Me.Rigol_Freq_4.Name = "Rigol_Freq_4"
        Me.Rigol_Freq_4.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Freq_4.TabIndex = 133
        Me.Rigol_Freq_4.Text = "Rigol_Freq_4"
        '
        'Rigol_dBm_4
        '
        Me.Rigol_dBm_4.Location = New System.Drawing.Point(888, 315)
        Me.Rigol_dBm_4.Name = "Rigol_dBm_4"
        Me.Rigol_dBm_4.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_dBm_4.TabIndex = 132
        Me.Rigol_dBm_4.Text = "Rigol_dBm_4"
        '
        'Rigol_Vrms_4
        '
        Me.Rigol_Vrms_4.Location = New System.Drawing.Point(888, 292)
        Me.Rigol_Vrms_4.Name = "Rigol_Vrms_4"
        Me.Rigol_Vrms_4.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Vrms_4.TabIndex = 131
        Me.Rigol_Vrms_4.Text = "Rigol_Vrms_4"
        '
        'Rigol_Vpp_4
        '
        Me.Rigol_Vpp_4.Location = New System.Drawing.Point(888, 268)
        Me.Rigol_Vpp_4.Name = "Rigol_Vpp_4"
        Me.Rigol_Vpp_4.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Vpp_4.TabIndex = 130
        Me.Rigol_Vpp_4.Text = "Rigol_Vpp_4"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(856, 342)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(25, 13)
        Me.Label39.TabIndex = 129
        Me.Label39.Text = "freq"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(852, 317)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(28, 13)
        Me.Label40.TabIndex = 128
        Me.Label40.Text = "dBm"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(852, 295)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(30, 13)
        Me.Label41.TabIndex = 127
        Me.Label41.Text = "Vrms"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(852, 271)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(26, 13)
        Me.Label42.TabIndex = 126
        Me.Label42.Text = "Vpp"
        '
        'Rigol_Freq_3
        '
        Me.Rigol_Freq_3.Location = New System.Drawing.Point(370, 338)
        Me.Rigol_Freq_3.Name = "Rigol_Freq_3"
        Me.Rigol_Freq_3.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Freq_3.TabIndex = 125
        Me.Rigol_Freq_3.Text = "Rigol_Freq_3"
        '
        'Rigol_dBm_3
        '
        Me.Rigol_dBm_3.Location = New System.Drawing.Point(369, 315)
        Me.Rigol_dBm_3.Name = "Rigol_dBm_3"
        Me.Rigol_dBm_3.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_dBm_3.TabIndex = 124
        Me.Rigol_dBm_3.Text = "Rigol_dBm_3"
        '
        'Rigol_Vrms_3
        '
        Me.Rigol_Vrms_3.Location = New System.Drawing.Point(369, 292)
        Me.Rigol_Vrms_3.Name = "Rigol_Vrms_3"
        Me.Rigol_Vrms_3.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Vrms_3.TabIndex = 123
        Me.Rigol_Vrms_3.Text = "Rigol_Vrms_3"
        '
        'Rigol_Vpp_3
        '
        Me.Rigol_Vpp_3.Location = New System.Drawing.Point(369, 268)
        Me.Rigol_Vpp_3.Name = "Rigol_Vpp_3"
        Me.Rigol_Vpp_3.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Vpp_3.TabIndex = 122
        Me.Rigol_Vpp_3.Text = "Rigol_Vpp_3"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(337, 342)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(25, 13)
        Me.Label43.TabIndex = 121
        Me.Label43.Text = "freq"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(333, 317)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(28, 13)
        Me.Label44.TabIndex = 120
        Me.Label44.Text = "dBm"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(333, 295)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(30, 13)
        Me.Label45.TabIndex = 119
        Me.Label45.Text = "Vrms"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(333, 271)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(26, 13)
        Me.Label46.TabIndex = 118
        Me.Label46.Text = "Vpp"
        '
        'Rigol_Freq_2
        '
        Me.Rigol_Freq_2.Location = New System.Drawing.Point(890, 124)
        Me.Rigol_Freq_2.Name = "Rigol_Freq_2"
        Me.Rigol_Freq_2.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Freq_2.TabIndex = 109
        Me.Rigol_Freq_2.Text = "Rigol_Freq_2"
        '
        'Rigol_dBm_2
        '
        Me.Rigol_dBm_2.Location = New System.Drawing.Point(889, 101)
        Me.Rigol_dBm_2.Name = "Rigol_dBm_2"
        Me.Rigol_dBm_2.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_dBm_2.TabIndex = 108
        Me.Rigol_dBm_2.Text = "Rigol_dBm_2"
        '
        'Rigol_Vrms_2
        '
        Me.Rigol_Vrms_2.Location = New System.Drawing.Point(889, 78)
        Me.Rigol_Vrms_2.Name = "Rigol_Vrms_2"
        Me.Rigol_Vrms_2.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Vrms_2.TabIndex = 107
        Me.Rigol_Vrms_2.Text = "Rigol_Vrms_2"
        '
        'Rigol_Vpp_2
        '
        Me.Rigol_Vpp_2.Location = New System.Drawing.Point(889, 54)
        Me.Rigol_Vpp_2.Name = "Rigol_Vpp_2"
        Me.Rigol_Vpp_2.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Vpp_2.TabIndex = 106
        Me.Rigol_Vpp_2.Text = "Rigol_Vpp_2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(857, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "freq"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(853, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "dBm"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(853, 81)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 13)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "Vrms"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(853, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(26, 13)
        Me.Label19.TabIndex = 102
        Me.Label19.Text = "Vpp"
        '
        'Rigol_Freq_1
        '
        Me.Rigol_Freq_1.Location = New System.Drawing.Point(370, 124)
        Me.Rigol_Freq_1.Name = "Rigol_Freq_1"
        Me.Rigol_Freq_1.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Freq_1.TabIndex = 101
        Me.Rigol_Freq_1.Text = "Rigol_Freq_1"
        '
        'Rigol_dBm_1
        '
        Me.Rigol_dBm_1.Location = New System.Drawing.Point(369, 101)
        Me.Rigol_dBm_1.Name = "Rigol_dBm_1"
        Me.Rigol_dBm_1.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_dBm_1.TabIndex = 100
        Me.Rigol_dBm_1.Text = "Rigol_dBm_1"
        '
        'Rigol_Vrms_1
        '
        Me.Rigol_Vrms_1.Location = New System.Drawing.Point(369, 78)
        Me.Rigol_Vrms_1.Name = "Rigol_Vrms_1"
        Me.Rigol_Vrms_1.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Vrms_1.TabIndex = 99
        Me.Rigol_Vrms_1.Text = "Rigol_Vrms_1"
        '
        'Rigol_Vpp_1
        '
        Me.Rigol_Vpp_1.Location = New System.Drawing.Point(369, 54)
        Me.Rigol_Vpp_1.Name = "Rigol_Vpp_1"
        Me.Rigol_Vpp_1.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Vpp_1.TabIndex = 98
        Me.Rigol_Vpp_1.Text = "Rigol_Vpp_1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(337, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "freq"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(333, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "dBm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(333, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Vrms"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(333, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Vpp"
        '
        'Connecttoscope
        '
        Me.Connecttoscope.Location = New System.Drawing.Point(21, 11)
        Me.Connecttoscope.Name = "Connecttoscope"
        Me.Connecttoscope.Size = New System.Drawing.Size(75, 23)
        Me.Connecttoscope.TabIndex = 4
        Me.Connecttoscope.Text = "Connect"
        Me.Connecttoscope.UseVisualStyleBackColor = True
        '
        'Rigol_Chart_1
        '
        Me.Rigol_Chart_1.AllowDrop = True
        Me.Rigol_Chart_1.BorderlineWidth = 0
        ChartArea11.Name = "ChartArea1"
        Me.Rigol_Chart_1.ChartAreas.Add(ChartArea11)
        Me.Rigol_Chart_1.Location = New System.Drawing.Point(3, 40)
        Me.Rigol_Chart_1.Margin = New System.Windows.Forms.Padding(0)
        Me.Rigol_Chart_1.Name = "Rigol_Chart_1"
        Me.Rigol_Chart_1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series11.ChartArea = "ChartArea1"
        Series11.Name = "Series1"
        Me.Rigol_Chart_1.Series.Add(Series11)
        Me.Rigol_Chart_1.Size = New System.Drawing.Size(338, 224)
        Me.Rigol_Chart_1.TabIndex = 140
        Me.Rigol_Chart_1.Text = "Chart1"
        '
        'Rigol_Chart_2
        '
        Me.Rigol_Chart_2.BorderlineWidth = 0
        ChartArea12.Name = "ChartArea1"
        Me.Rigol_Chart_2.ChartAreas.Add(ChartArea12)
        Me.Rigol_Chart_2.Location = New System.Drawing.Point(530, 37)
        Me.Rigol_Chart_2.Name = "Rigol_Chart_2"
        Me.Rigol_Chart_2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series12.ChartArea = "ChartArea1"
        Series12.Name = "Series1"
        Me.Rigol_Chart_2.Series.Add(Series12)
        Me.Rigol_Chart_2.Size = New System.Drawing.Size(338, 224)
        Me.Rigol_Chart_2.TabIndex = 146
        Me.Rigol_Chart_2.Text = "Chart2"
        '
        'Rigol_Chart_3
        '
        Me.Rigol_Chart_3.BorderlineWidth = 0
        ChartArea13.Name = "ChartArea1"
        Me.Rigol_Chart_3.ChartAreas.Add(ChartArea13)
        Me.Rigol_Chart_3.Location = New System.Drawing.Point(7, 252)
        Me.Rigol_Chart_3.Name = "Rigol_Chart_3"
        Me.Rigol_Chart_3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series13.ChartArea = "ChartArea1"
        Series13.Name = "Series1"
        Me.Rigol_Chart_3.Series.Add(Series13)
        Me.Rigol_Chart_3.Size = New System.Drawing.Size(338, 224)
        Me.Rigol_Chart_3.TabIndex = 147
        Me.Rigol_Chart_3.Text = "Chart3"
        '
        'Rigol_Chart_4
        '
        Me.Rigol_Chart_4.BorderlineWidth = 0
        ChartArea14.Name = "ChartArea1"
        Me.Rigol_Chart_4.ChartAreas.Add(ChartArea14)
        Me.Rigol_Chart_4.Location = New System.Drawing.Point(529, 252)
        Me.Rigol_Chart_4.Name = "Rigol_Chart_4"
        Me.Rigol_Chart_4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series14.ChartArea = "ChartArea1"
        Series14.Name = "Series1"
        Me.Rigol_Chart_4.Series.Add(Series14)
        Me.Rigol_Chart_4.Size = New System.Drawing.Size(338, 224)
        Me.Rigol_Chart_4.TabIndex = 148
        Me.Rigol_Chart_4.Text = "Chart4"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.FFT_MouseOver_YValue)
        Me.TabPage6.Controls.Add(Me.FFT_MouseOver_XValue)
        Me.TabPage6.Controls.Add(Me.FFT_H_Display_scale_f)
        Me.TabPage6.Controls.Add(Me.FFT_H_Display_Center_f_value)
        Me.TabPage6.Controls.Add(Me.RigolIPAddresFTP)
        Me.TabPage6.Controls.Add(Me.FFT_WINDOWTYPE)
        Me.TabPage6.Controls.Add(Me.FFT_CH_SOURCE)
        Me.TabPage6.Controls.Add(Me.FFT_Resolution)
        Me.TabPage6.Controls.Add(Me.TrackBar1)
        Me.TabPage6.Controls.Add(Me.FFT_H_Display_Center_f)
        Me.TabPage6.Controls.Add(Me.FFT_Channel_Select)
        Me.TabPage6.Controls.Add(Me.FFT_Window_Type)
        Me.TabPage6.Controls.Add(Me.FFT_GET_DATA)
        Me.TabPage6.Controls.Add(Me.Rigol_FFT_Data)
        Me.TabPage6.Controls.Add(Me.Rigol_FFT_Chart)
        Me.TabPage6.Controls.Add(Me.Rigol_FFT_Connect)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1012, 514)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "RigolFFT"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'FFT_MouseOver_YValue
        '
        Me.FFT_MouseOver_YValue.AutoSize = True
        Me.FFT_MouseOver_YValue.Location = New System.Drawing.Point(661, 216)
        Me.FFT_MouseOver_YValue.Name = "FFT_MouseOver_YValue"
        Me.FFT_MouseOver_YValue.Size = New System.Drawing.Size(45, 13)
        Me.FFT_MouseOver_YValue.TabIndex = 24
        Me.FFT_MouseOver_YValue.Text = "Label20"
        '
        'FFT_MouseOver_XValue
        '
        Me.FFT_MouseOver_XValue.AutoSize = True
        Me.FFT_MouseOver_XValue.Location = New System.Drawing.Point(337, 450)
        Me.FFT_MouseOver_XValue.Name = "FFT_MouseOver_XValue"
        Me.FFT_MouseOver_XValue.Size = New System.Drawing.Size(45, 13)
        Me.FFT_MouseOver_XValue.TabIndex = 23
        Me.FFT_MouseOver_XValue.Text = "Label20"
        '
        'FFT_H_Display_scale_f
        '
        Me.FFT_H_Display_scale_f.AutoSize = True
        Me.FFT_H_Display_scale_f.Location = New System.Drawing.Point(850, 157)
        Me.FFT_H_Display_scale_f.Name = "FFT_H_Display_scale_f"
        Me.FFT_H_Display_scale_f.Size = New System.Drawing.Size(120, 13)
        Me.FFT_H_Display_scale_f.TabIndex = 22
        Me.FFT_H_Display_scale_f.Text = "FFT_H_Display_scale_f"
        '
        'FFT_H_Display_Center_f_value
        '
        Me.FFT_H_Display_Center_f_value.AutoSize = True
        Me.FFT_H_Display_Center_f_value.Location = New System.Drawing.Point(847, 131)
        Me.FFT_H_Display_Center_f_value.Name = "FFT_H_Display_Center_f_value"
        Me.FFT_H_Display_Center_f_value.Size = New System.Drawing.Size(126, 13)
        Me.FFT_H_Display_Center_f_value.TabIndex = 21
        Me.FFT_H_Display_Center_f_value.Text = "FFT_H_Display_Center_f"
        '
        'RigolIPAddresFTP
        '
        Me.RigolIPAddresFTP.Location = New System.Drawing.Point(739, 40)
        Me.RigolIPAddresFTP.Name = "RigolIPAddresFTP"
        Me.RigolIPAddresFTP.Size = New System.Drawing.Size(102, 20)
        Me.RigolIPAddresFTP.TabIndex = 20
        Me.RigolIPAddresFTP.Text = "192.168.0.110"
        '
        'FFT_WINDOWTYPE
        '
        Me.FFT_WINDOWTYPE.AutoSize = True
        Me.FFT_WINDOWTYPE.Location = New System.Drawing.Point(847, 109)
        Me.FFT_WINDOWTYPE.Name = "FFT_WINDOWTYPE"
        Me.FFT_WINDOWTYPE.Size = New System.Drawing.Size(109, 13)
        Me.FFT_WINDOWTYPE.TabIndex = 19
        Me.FFT_WINDOWTYPE.Text = "FFT_WINDOWTYPE"
        '
        'FFT_CH_SOURCE
        '
        Me.FFT_CH_SOURCE.AutoSize = True
        Me.FFT_CH_SOURCE.Location = New System.Drawing.Point(847, 81)
        Me.FFT_CH_SOURCE.Name = "FFT_CH_SOURCE"
        Me.FFT_CH_SOURCE.Size = New System.Drawing.Size(98, 13)
        Me.FFT_CH_SOURCE.TabIndex = 18
        Me.FFT_CH_SOURCE.Text = "FFT_CH_SOURCE"
        '
        'FFT_Resolution
        '
        Me.FFT_Resolution.FormattingEnabled = True
        Me.FFT_Resolution.Items.AddRange(New Object() {"2500", "5000", "12500", "25000"})
        Me.FFT_Resolution.Location = New System.Drawing.Point(739, 153)
        Me.FFT_Resolution.Name = "FFT_Resolution"
        Me.FFT_Resolution.Size = New System.Drawing.Size(102, 21)
        Me.FFT_Resolution.TabIndex = 17
        Me.FFT_Resolution.Text = "FFT_Resolution"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(451, 456)
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(200, 42)
        Me.TrackBar1.TabIndex = 16
        Me.TrackBar1.Value = 1
        '
        'FFT_H_Display_Center_f
        '
        Me.FFT_H_Display_Center_f.Location = New System.Drawing.Point(739, 127)
        Me.FFT_H_Display_Center_f.Name = "FFT_H_Display_Center_f"
        Me.FFT_H_Display_Center_f.Size = New System.Drawing.Size(102, 20)
        Me.FFT_H_Display_Center_f.TabIndex = 15
        Me.FFT_H_Display_Center_f.Text = "20000"
        '
        'FFT_Channel_Select
        '
        Me.FFT_Channel_Select.FormattingEnabled = True
        Me.FFT_Channel_Select.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.FFT_Channel_Select.Location = New System.Drawing.Point(739, 73)
        Me.FFT_Channel_Select.Name = "FFT_Channel_Select"
        Me.FFT_Channel_Select.Size = New System.Drawing.Size(102, 21)
        Me.FFT_Channel_Select.TabIndex = 14
        Me.FFT_Channel_Select.Text = "FFT Channel"
        '
        'FFT_Window_Type
        '
        Me.FFT_Window_Type.FormattingEnabled = True
        Me.FFT_Window_Type.Items.AddRange(New Object() {"RECTangle", "BLACkman", "HANNing", "HAMMing", "FLATtop", "TRIangle"})
        Me.FFT_Window_Type.Location = New System.Drawing.Point(739, 100)
        Me.FFT_Window_Type.Name = "FFT_Window_Type"
        Me.FFT_Window_Type.Size = New System.Drawing.Size(102, 21)
        Me.FFT_Window_Type.TabIndex = 13
        Me.FFT_Window_Type.Text = "Window Type"
        '
        'FFT_GET_DATA
        '
        Me.FFT_GET_DATA.Location = New System.Drawing.Point(739, 206)
        Me.FFT_GET_DATA.Name = "FFT_GET_DATA"
        Me.FFT_GET_DATA.Size = New System.Drawing.Size(200, 23)
        Me.FFT_GET_DATA.TabIndex = 12
        Me.FFT_GET_DATA.Text = "Get FFT Data"
        Me.FFT_GET_DATA.UseVisualStyleBackColor = True
        '
        'Rigol_FFT_Data
        '
        Me.Rigol_FFT_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rigol_FFT_Data.Location = New System.Drawing.Point(739, 245)
        Me.Rigol_FFT_Data.Name = "Rigol_FFT_Data"
        Me.Rigol_FFT_Data.Size = New System.Drawing.Size(240, 150)
        Me.Rigol_FFT_Data.TabIndex = 2
        '
        'Rigol_FFT_Chart
        '
        ChartArea15.Name = "ChartArea1"
        Me.Rigol_FFT_Chart.ChartAreas.Add(ChartArea15)
        Me.Rigol_FFT_Chart.Location = New System.Drawing.Point(3, 3)
        Me.Rigol_FFT_Chart.Name = "Rigol_FFT_Chart"
        Series15.ChartArea = "ChartArea1"
        Series15.Name = "Series1"
        Me.Rigol_FFT_Chart.Series.Add(Series15)
        Me.Rigol_FFT_Chart.Size = New System.Drawing.Size(678, 460)
        Me.Rigol_FFT_Chart.TabIndex = 1
        Me.Rigol_FFT_Chart.Text = "Chart1"
        '
        'Rigol_FFT_Connect
        '
        Me.Rigol_FFT_Connect.Location = New System.Drawing.Point(727, 10)
        Me.Rigol_FFT_Connect.Name = "Rigol_FFT_Connect"
        Me.Rigol_FFT_Connect.Size = New System.Drawing.Size(191, 23)
        Me.Rigol_FFT_Connect.TabIndex = 0
        Me.Rigol_FFT_Connect.Text = "FFT Connect"
        Me.Rigol_FFT_Connect.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1012, 514)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "DATA COLLECTION"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(0, 21)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(972, 446)
        Me.DataGridView.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Button5)
        Me.TabPage5.Controls.Add(Me.Button4)
        Me.TabPage5.Controls.Add(Me.CheckedListBox1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1012, 514)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "POD 2 Switcher"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(884, 269)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(884, 298)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"IN 1", "IN 2", "IN 3", "IN 4", "IN 5", "IN 6"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(758, 264)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 94)
        Me.CheckedListBox1.TabIndex = 1
        '
        'ReadValues
        '
        Me.ReadValues.Interval = 1000
        '
        'TMRENA
        '
        Me.TMRENA.Location = New System.Drawing.Point(927, 558)
        Me.TMRENA.Name = "TMRENA"
        Me.TMRENA.Size = New System.Drawing.Size(105, 23)
        Me.TMRENA.TabIndex = 3
        Me.TMRENA.Text = "START"
        Me.TMRENA.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(680, 558)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Collect Data"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Measurement
        '
        Me.Measurement.Location = New System.Drawing.Point(277, 558)
        Me.Measurement.Name = "Measurement"
        Me.Measurement.Size = New System.Drawing.Size(381, 20)
        Me.Measurement.TabIndex = 10
        Me.Measurement.Text = "Measurement Name"
        '
        'CommandListBox
        '
        Me.CommandListBox.FormattingEnabled = True
        Me.CommandListBox.Location = New System.Drawing.Point(792, 591)
        Me.CommandListBox.Name = "CommandListBox"
        Me.CommandListBox.Size = New System.Drawing.Size(223, 212)
        Me.CommandListBox.TabIndex = 23
        '
        'ToolTip1
        '
        '
        'UserInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 815)
        Me.Controls.Add(Me.CommandListBox)
        Me.Controls.Add(Me.Measurement)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TMRENA)
        Me.Controls.Add(Me.RigolIPAddresFFT)
        Me.Name = "UserInterface"
        Me.Text = "APKaudio Measurement System"
        Me.RigolIPAddresFFT.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.QuickFreq.ResumeLayout(False)
        Me.QuickFreq.PerformLayout()
        CType(Me.SigGen_FrequencyTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SigGen_DutyCycle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Rigol_Data_Grid_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rigol_Data_Grid_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rigol_Data_Grid_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rigol_Data_Grid_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rigol_Chart_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rigol_Chart_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rigol_Chart_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rigol_Chart_4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rigol_FFT_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rigol_FFT_Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RigolIPAddresFFT As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents NameDevices As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DMM_Name_1 As TextBox
    Friend WithEvents DMM_Name_4 As TextBox
    Friend WithEvents DMM_Name_3 As TextBox
    Friend WithEvents DMM_Name_2 As TextBox
    Friend WithEvents DMM_gpib_4 As TextBox
    Friend WithEvents DMM_gpib_3 As TextBox
    Friend WithEvents DMM_gpib_2 As TextBox
    Friend WithEvents DMM_gpib_1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents IPaddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents gpibAddress As TextBox
    Friend WithEvents AudioAnalyzer_gpib As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AudioAnalyzer_name As TextBox
    Friend WithEvents SignalGen_gpib As TextBox
    Friend WithEvents SignalGen_name As TextBox
    Friend WithEvents PSU_gpib As TextBox
    Friend WithEvents PSU_name As TextBox
    Friend WithEvents Ocilliscope_gpib As TextBox
    Friend WithEvents Ocilliscope_name As TextBox
    Friend WithEvents SignalGenLabel As Label
    Friend WithEvents SigGen_Signal_Type As ComboBox
    Friend WithEvents SigGen_Update As Button
    Friend WithEvents SigGen_Amp_unit As ComboBox
    Friend WithEvents SigGen_amp As TextBox
    Friend WithEvents SigGen_Sine_freq As TextBox
    Friend WithEvents SigGen_DutyCycle As TrackBar
    Friend WithEvents SigGen_FrequencyTrackBar As TrackBar
    Friend WithEvents PSU_ON_4 As Button
    Friend WithEvents PSU_ON_3 As Button
    Friend WithEvents PSU_ON_2 As Button
    Friend WithEvents PSU_ON_1 As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents PSU_I_4 As TextBox
    Friend WithEvents PSU_V_4 As TextBox
    Friend WithEvents PSULabel4 As Label
    Friend WithEvents PSU_I_3 As TextBox
    Friend WithEvents PSU_V_3 As TextBox
    Friend WithEvents PSULabel3 As Label
    Friend WithEvents PSU_I_2 As TextBox
    Friend WithEvents PSU_V_2 As TextBox
    Friend WithEvents PSULabel2 As Label
    Friend WithEvents PSU_I_1 As TextBox
    Friend WithEvents PSU_V_1 As TextBox
    Friend WithEvents PSULink12 As CheckBox
    Friend WithEvents PSUlink34 As CheckBox
    Friend WithEvents PSULabel1 As Label
    Friend WithEvents Dist_measure_Voltage As TextBox
    Friend WithEvents Dist_measure_DSTN As TextBox
    Friend WithEvents Dist_measure_SINAD As TextBox
    Friend WithEvents Dist_Amp As TextBox
    Friend WithEvents DistortionChange As Button
    Friend WithEvents Dist_freq As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents DMM_dbm_4 As TextBox
    Friend WithEvents DMM_Value_4 As TextBox
    Friend WithEvents DMM_function_4 As ComboBox
    Friend WithEvents DMM_dbm_3 As TextBox
    Friend WithEvents DMM_Value_3 As TextBox
    Friend WithEvents DMM_function_3 As ComboBox
    Friend WithEvents DMM_dbm_2 As TextBox
    Friend WithEvents DMM_Value_2 As TextBox
    Friend WithEvents DMM_function_2 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dBm_ref_imp As TextBox
    Friend WithEvents DMM_dbm_1 As TextBox
    Friend WithEvents DMM_Value_1 As TextBox
    Friend WithEvents BUT_READ_DMM As Button
    Friend WithEvents DMM_function_1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ReadValues As Timer
    Friend WithEvents TMRENA As Button
    Friend WithEvents Scope_Autoscale As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents QuickFreq As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents SCOPE_FREQ_1 As TextBox
    Friend WithEvents SCOPE_dBm_1 As TextBox
    Friend WithEvents SCOPE_Vrms_1 As TextBox
    Friend WithEvents SCOPE_Vpp_1 As TextBox
    Friend WithEvents SCOPE_Phase As TextBox
    Friend WithEvents SCOPE_FREQ_2 As TextBox
    Friend WithEvents SCOPE_dBm_2 As TextBox
    Friend WithEvents SCOPE_Vrms_2 As TextBox
    Friend WithEvents SCOPE_Vpp_2 As TextBox
    Friend WithEvents SCOPE_dBm_diff As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents PSU_READ_I_4 As TextBox
    Friend WithEvents PSU_READ_I_3 As TextBox
    Friend WithEvents PSU_READ_I_2 As TextBox
    Friend WithEvents PSU_READ_I_1 As TextBox
    Friend WithEvents PSU_READ_V_4 As TextBox
    Friend WithEvents PSU_READ_V_3 As TextBox
    Friend WithEvents PSU_READ_V_2 As TextBox
    Friend WithEvents PSU_READ_V_1 As TextBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents DMMLabel4 As Label
    Friend WithEvents DMMLabel3 As Label
    Friend WithEvents DMMLabel2 As Label
    Friend WithEvents DMMLabel1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Measurement As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Connecttoscope As Button
    Friend WithEvents SigGen_Enable As CheckBox
    Friend WithEvents PSU_Enable As CheckBox
    Friend WithEvents Scope_Enable As CheckBox
    Friend WithEvents Analyzer_Enable As CheckBox
    Friend WithEvents DMM_Enable_4 As CheckBox
    Friend WithEvents DMM_Enable_3 As CheckBox
    Friend WithEvents DMM_Enable_2 As CheckBox
    Friend WithEvents DMM_Enable_1 As CheckBox
    Friend WithEvents GPIB_Enable As CheckBox
    Friend WithEvents Rigol_Freq_4 As TextBox
    Friend WithEvents Rigol_dBm_4 As TextBox
    Friend WithEvents Rigol_Vrms_4 As TextBox
    Friend WithEvents Rigol_Vpp_4 As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Rigol_Freq_3 As TextBox
    Friend WithEvents Rigol_dBm_3 As TextBox
    Friend WithEvents Rigol_Vrms_3 As TextBox
    Friend WithEvents Rigol_Vpp_3 As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Rigol_Freq_2 As TextBox
    Friend WithEvents Rigol_dBm_2 As TextBox
    Friend WithEvents Rigol_Vrms_2 As TextBox
    Friend WithEvents Rigol_Vpp_2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Rigol_Freq_1 As TextBox
    Friend WithEvents Rigol_dBm_1 As TextBox
    Friend WithEvents Rigol_Vrms_1 As TextBox
    Friend WithEvents Rigol_Vpp_1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Rigol_GetSCOPEDATA As Button
    Friend WithEvents Rigol_Data_Grid_1 As DataGridView
    Friend WithEvents Rigol_Data_Grid_4 As DataGridView
    Friend WithEvents Rigol_Data_Grid_3 As DataGridView
    Friend WithEvents Rigol_Data_Grid_2 As DataGridView
    Friend WithEvents Rigol_Chart_1 As DataVisualization.Charting.Chart
    Friend WithEvents Rigol_update_CH1 As Button
    Friend WithEvents Rigol_update_CH4 As Button
    Friend WithEvents Rigol_update_CH3 As Button
    Friend WithEvents Rigol_update_CH2 As Button
    Friend WithEvents Rigol_Chart_4 As DataVisualization.Charting.Chart
    Friend WithEvents Rigol_Chart_3 As DataVisualization.Charting.Chart
    Friend WithEvents Rigol_Chart_2 As DataVisualization.Charting.Chart
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents RigolIPAddres As TextBox
    Friend WithEvents Rigol_Time_Base As TextBox
    Friend WithEvents Rigol_Time_Scale As Label
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Rigol_FFT_Data As DataGridView
    Friend WithEvents Rigol_FFT_Chart As DataVisualization.Charting.Chart
    Friend WithEvents Rigol_FFT_Connect As Button
    Friend WithEvents FFT_GET_DATA As Button
    Friend WithEvents FFT_Window_Type As ComboBox
    Friend WithEvents FFT_Channel_Select As ComboBox
    Friend WithEvents FFT_H_Display_Center_f As TextBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents FFT_Resolution As ComboBox
    Friend WithEvents FFT_CH_SOURCE As Label
    Friend WithEvents FFT_WINDOWTYPE As Label
    Friend WithEvents RigolIPAddresFTP As TextBox
    Friend WithEvents FFT_H_Display_Center_f_value As Label
    Friend WithEvents FFT_H_Display_scale_f As Label
    Friend WithEvents CommandListBox As ListBox
    Friend WithEvents FFT_MouseOver_YValue As Label
    Friend WithEvents FFT_MouseOver_XValue As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RIGOL_FFT_TOOLTIP As ToolTip
End Class
