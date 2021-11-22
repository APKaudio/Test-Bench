<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserInterfaceShell
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserInterfaceShell))
		Me.userIntMainMenuStrip = New System.Windows.Forms.MenuStrip()
		Me.DeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LoadConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InstrumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AgilentNetworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RelaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SwitcherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
		Me.RigolScopeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Rigol_Channel1ToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
		Me.Rigol_Channel2ToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
		Me.Rigol_Channel3ToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
		Me.Rigol_Channel4ToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
		Me.DecodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SerialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.I2CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
		Me.RigolFFTToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
		Me.SignalGeneratorToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
		Me.AgilentScopeToolStripMenuInstrument = New System.Windows.Forms.ToolStripMenuItem()
		Me.AgilentFFTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripMenuItem_AllDMM = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
		Me.AgilentESALSpectrumAnalyzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProgramableLoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AudioAnalyzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PSUFrameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
		Me.PSU12ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PSU34ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.IPAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GPIBToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.GPIB_IP = New System.Windows.Forms.ToolStripTextBox()
		Me.GPIB_BUSS = New System.Windows.Forms.ToolStripTextBox()
		Me.RIGOLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RIGOL_IP = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
		Me.SigGen_IP = New System.Windows.Forms.ToolStripTextBox()
		Me.ImpedanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InputImpedanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OutputImpedanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RefferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Reff_Imp = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
		Me.SpeachOnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.SignalGenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GPIBAddressToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.SignalGen_GPIB_address = New System.Windows.Forms.ToolStripTextBox()
		Me.GPIBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
		Me.AgilentScopeGPIBaddress12 = New System.Windows.Forms.ToolStripTextBox()
		Me.GPIBAddress_Sope12 = New System.Windows.Forms.ToolStripMenuItem()
		Me.AgilentScopeGPIBaddress34 = New System.Windows.Forms.ToolStripTextBox()
		Me.AgilentFFTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.DMM1ToolStripMenuItemConfig = New System.Windows.Forms.ToolStripMenuItem()
		Me.NameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DMM_NAME_1 = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DMM_gpibaddress_1 = New System.Windows.Forms.ToolStripTextBox()
		Me.DMM2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NameToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DMM_NAME_2 = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DMM_gpibaddress_2 = New System.Windows.Forms.ToolStripTextBox()
		Me.DMM3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NameToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DMM_NAME_3 = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DMM_gpibaddress_3 = New System.Windows.Forms.ToolStripTextBox()
		Me.DMM4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NameToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DMM_NAME_4 = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DMM_gpibaddress_4 = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.DMM5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NAMEToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DMM_NAME_5 = New System.Windows.Forms.ToolStripTextBox()
		Me.GPIBAddressToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DMM_gpibaddress_5 = New System.Windows.Forms.ToolStripTextBox()
		Me.DMM6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.NAMEToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DMM_NAME_6 = New System.Windows.Forms.ToolStripTextBox()
		Me.GPIBAddressToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DMM_gpibaddress_6 = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
		Me.SpectrumAnalyzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GPIBAddressToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
		Me.SpectrumAnalyzer_GPIB_address = New System.Windows.Forms.ToolStripTextBox()
		Me.SWITCHERToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.GPIBAddressToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
		Me.SWR_GPIB_ADDRESS = New System.Windows.Forms.ToolStripTextBox()
		Me.PSUFrameToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.GPIBADDRESSToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
		Me.PSUFrameGPIBAddress = New System.Windows.Forms.ToolStripTextBox()
		Me.DCLOADToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GPIBAddressToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DCloadGPIBaddress = New System.Windows.Forms.ToolStripComboBox()
		Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
		Me.PSUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GPIBADDRESSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PSU_GPIB_ADDRESS = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
		Me.CommandBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LOADALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FrequencyChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.WBSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PreMoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.POD2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.POD10DigitalSwitchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RIGOL_FFT_TOOLTIP = New System.Windows.Forms.ToolTip(Me.components)
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
		Me.ReadValues = New System.Windows.Forms.Timer(Me.components)
		Me.Button_BUSS_1 = New System.Windows.Forms.Button()
		Me.Button_BUSS_2 = New System.Windows.Forms.Button()
		Me.Button_BUSS_3 = New System.Windows.Forms.Button()
		Me.Button_BUSS_4 = New System.Windows.Forms.Button()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.YoControlStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.YoTimeOut = New System.Windows.Forms.ToolStripProgressBar()
		Me.YoTimer = New System.Windows.Forms.Timer(Me.components)
		Me.Button_Uncheck_DIST_MON = New System.Windows.Forms.Button()
		Me.RadioButton_DIST_MON_A = New System.Windows.Forms.RadioButton()
		Me.RadioButton_DIST_MON_B = New System.Windows.Forms.RadioButton()
		Me.RadioButton_DIST_MON_C = New System.Windows.Forms.RadioButton()
		Me.RadioButton_DIST_MON_D = New System.Windows.Forms.RadioButton()
		Me.GroupBox13 = New System.Windows.Forms.GroupBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.TabControl4 = New System.Windows.Forms.TabControl()
		Me.TabPage8 = New System.Windows.Forms.TabPage()
		Me.Dist_measure_Voltage = New System.Windows.Forms.TextBox()
		Me.Dist_measure_SINAD = New System.Windows.Forms.TextBox()
		Me.Dist_measure_DSTN = New System.Windows.Forms.TextBox()
		Me.TabPage9 = New System.Windows.Forms.TabPage()
		Me.DistortionChange = New System.Windows.Forms.Button()
		Me.Dist_Amp = New System.Windows.Forms.TextBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Dist_freq = New System.Windows.Forms.TextBox()
		Me.PictureBox_Distortion = New System.Windows.Forms.PictureBox()
		Me.EventLog1 = New System.Diagnostics.EventLog()
		Me.SigGen_FrequencyTrackBar = New System.Windows.Forms.TrackBar()
		Me.Button_DIST_GEN = New System.Windows.Forms.Button()
		Me.Button_ISO_B_IN = New System.Windows.Forms.Button()
		Me.Button_ISO_A_IN = New System.Windows.Forms.Button()
		Me.Button_Bridging_Input = New System.Windows.Forms.Button()
		Me.Button_SIGNAL_GEN = New System.Windows.Forms.Button()
		Me.Button_SPECTRUM = New System.Windows.Forms.Button()
		Me.Button_DISTORTION = New System.Windows.Forms.Button()
		Me.Button_PATCH_PANEL_OUT = New System.Windows.Forms.Button()
		Me.Button_FROM_COAX = New System.Windows.Forms.Button()
		Me.SoundSource1 = New APK_Bench_Software.SoundSource()
		Me.DmmControl8 = New APK_Bench_Software.DMMControl()
		Me.DmmControl7 = New APK_Bench_Software.DMMControl()
		Me.DmmControl6 = New APK_Bench_Software.DMMControl()
		Me.DmmControl5 = New APK_Bench_Software.DMMControl()
		Me.DmmControl4 = New APK_Bench_Software.DMMControl()
		Me.DmmControl3 = New APK_Bench_Software.DMMControl()
		Me.DmmControl2 = New APK_Bench_Software.DMMControl()
		Me.DmmControl1 = New APK_Bench_Software.DMMControl()
		Me.Scope_Channel_Display6 = New APK_Bench_Software.Scope_Channel_Display()
		Me.Scope_Channel_Display5 = New APK_Bench_Software.Scope_Channel_Display()
		Me.PsU_Module5 = New APK_Bench_Software.PSU_Module()
		Me.PsU_Module6 = New APK_Bench_Software.PSU_Module()
		Me.PsU_Module7 = New APK_Bench_Software.PSU_Module()
		Me.PsU_Module4 = New APK_Bench_Software.PSU_Module()
		Me.Scope_Channel_Display1 = New APK_Bench_Software.Scope_Channel_Display()
		Me.Scope_Channel_Display4 = New APK_Bench_Software.Scope_Channel_Display()
		Me.Scope_Channel_Display3 = New APK_Bench_Software.Scope_Channel_Display()
		Me.Scope_Channel_Display2 = New APK_Bench_Software.Scope_Channel_Display()
		Me.PsU_Module0 = New APK_Bench_Software.PSU_Module()
		Me.PsU_Module3 = New APK_Bench_Software.PSU_Module()
		Me.PsU_Module2 = New APK_Bench_Software.PSU_Module()
		Me.PsU_Module1 = New APK_Bench_Software.PSU_Module()
		Me.userIntMainMenuStrip.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.GroupBox13.SuspendLayout()
		Me.TabControl4.SuspendLayout()
		Me.TabPage8.SuspendLayout()
		Me.TabPage9.SuspendLayout()
		CType(Me.PictureBox_Distortion, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.SigGen_FrequencyTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'userIntMainMenuStrip
		'
		Me.userIntMainMenuStrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.userIntMainMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.userIntMainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeviceToolStripMenuItem, Me.DataToolStripMenuItem, Me.InstrumentToolStripMenuItem, Me.DevicesToolStripMenuItem, Me.CommandBoxToolStripMenuItem, Me.LOADALLToolStripMenuItem, Me.FrequencyChartToolStripMenuItem, Me.WBSToolStripMenuItem})
		Me.userIntMainMenuStrip.Location = New System.Drawing.Point(0, 0)
		Me.userIntMainMenuStrip.Name = "userIntMainMenuStrip"
		Me.userIntMainMenuStrip.Size = New System.Drawing.Size(1924, 25)
		Me.userIntMainMenuStrip.TabIndex = 25
		Me.userIntMainMenuStrip.Text = "MenuStrip1"
		'
		'DeviceToolStripMenuItem
		'
		Me.DeviceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveConfigToolStripMenuItem, Me.LoadConfigToolStripMenuItem, Me.ToolStripSeparator1})
		Me.DeviceToolStripMenuItem.Name = "DeviceToolStripMenuItem"
		Me.DeviceToolStripMenuItem.Size = New System.Drawing.Size(42, 21)
		Me.DeviceToolStripMenuItem.Text = "&File"
		'
		'SaveConfigToolStripMenuItem
		'
		Me.SaveConfigToolStripMenuItem.Name = "SaveConfigToolStripMenuItem"
		Me.SaveConfigToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
		Me.SaveConfigToolStripMenuItem.Text = "Save Config"
		'
		'LoadConfigToolStripMenuItem
		'
		Me.LoadConfigToolStripMenuItem.Name = "LoadConfigToolStripMenuItem"
		Me.LoadConfigToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
		Me.LoadConfigToolStripMenuItem.Text = "Load Config"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
		'
		'DataToolStripMenuItem
		'
		Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
		Me.DataToolStripMenuItem.Size = New System.Drawing.Size(49, 21)
		Me.DataToolStripMenuItem.Text = "&Data"
		'
		'InstrumentToolStripMenuItem
		'
		Me.InstrumentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgilentNetworkToolStripMenuItem, Me.RelaysToolStripMenuItem, Me.SwitcherToolStripMenuItem, Me.ToolStripSeparator13, Me.RigolScopeToolStripMenuItem, Me.Rigol_Channel1ToolStripMenuInstrument, Me.Rigol_Channel2ToolStripMenuInstrument, Me.Rigol_Channel3ToolStripMenuInstrument, Me.Rigol_Channel4ToolStripMenuInstrument, Me.DecodeToolStripMenuItem, Me.ToolStripSeparator8, Me.RigolFFTToolStripMenuInstrument, Me.ToolStripSeparator9, Me.SignalGeneratorToolStripMenuInstrument, Me.AgilentScopeToolStripMenuInstrument, Me.AgilentFFTToolStripMenuItem1, Me.ToolStripSeparator14, Me.ToolStripMenuItem_AllDMM, Me.ToolStripSeparator10, Me.AgilentESALSpectrumAnalyzerToolStripMenuItem, Me.ProgramableLoadToolStripMenuItem, Me.AudioAnalyzerToolStripMenuItem, Me.PSUFrameToolStripMenuItem, Me.ToolStripSeparator11, Me.ToolStripSeparator12, Me.PSU12ToolStripMenuItem, Me.PSU34ToolStripMenuItem})
		Me.InstrumentToolStripMenuItem.Name = "InstrumentToolStripMenuItem"
		Me.InstrumentToolStripMenuItem.Size = New System.Drawing.Size(88, 21)
		Me.InstrumentToolStripMenuItem.Text = "&Instrument"
		'
		'AgilentNetworkToolStripMenuItem
		'
		Me.AgilentNetworkToolStripMenuItem.Name = "AgilentNetworkToolStripMenuItem"
		Me.AgilentNetworkToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
		Me.AgilentNetworkToolStripMenuItem.Text = "Agilent Coaxial Network"
		'
		'RelaysToolStripMenuItem
		'
		Me.RelaysToolStripMenuItem.Name = "RelaysToolStripMenuItem"
		Me.RelaysToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
		Me.RelaysToolStripMenuItem.Text = "Auxiliary Relays"
		'
		'SwitcherToolStripMenuItem
		'
		Me.SwitcherToolStripMenuItem.Name = "SwitcherToolStripMenuItem"
		Me.SwitcherToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
		Me.SwitcherToolStripMenuItem.Text = "Multiplexer"
		'
		'ToolStripSeparator13
		'
		Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
		Me.ToolStripSeparator13.Size = New System.Drawing.Size(276, 6)
		'
		'RigolScopeToolStripMenuItem
		'
		Me.RigolScopeToolStripMenuItem.Name = "RigolScopeToolStripMenuItem"
		Me.RigolScopeToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
		Me.RigolScopeToolStripMenuItem.Text = "Rigol Scope"
		'
		'Rigol_Channel1ToolStripMenuInstrument
		'
		Me.Rigol_Channel1ToolStripMenuInstrument.Name = "Rigol_Channel1ToolStripMenuInstrument"
		Me.Rigol_Channel1ToolStripMenuInstrument.Size = New System.Drawing.Size(279, 22)
		Me.Rigol_Channel1ToolStripMenuInstrument.Text = "Channel 1"
		'
		'Rigol_Channel2ToolStripMenuInstrument
		'
		Me.Rigol_Channel2ToolStripMenuInstrument.Name = "Rigol_Channel2ToolStripMenuInstrument"
		Me.Rigol_Channel2ToolStripMenuInstrument.Size = New System.Drawing.Size(279, 22)
		Me.Rigol_Channel2ToolStripMenuInstrument.Text = "Channel 2"
		'
		'Rigol_Channel3ToolStripMenuInstrument
		'
		Me.Rigol_Channel3ToolStripMenuInstrument.Name = "Rigol_Channel3ToolStripMenuInstrument"
		Me.Rigol_Channel3ToolStripMenuInstrument.Size = New System.Drawing.Size(279, 22)
		Me.Rigol_Channel3ToolStripMenuInstrument.Text = "Channel 3"
		'
		'Rigol_Channel4ToolStripMenuInstrument
		'
		Me.Rigol_Channel4ToolStripMenuInstrument.Name = "Rigol_Channel4ToolStripMenuInstrument"
		Me.Rigol_Channel4ToolStripMenuInstrument.Size = New System.Drawing.Size(279, 22)
		Me.Rigol_Channel4ToolStripMenuInstrument.Text = "Channel 4"
		'
		'DecodeToolStripMenuItem
		'
		Me.DecodeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SerialToolStripMenuItem, Me.I2CToolStripMenuItem})
		Me.DecodeToolStripMenuItem.Name = "DecodeToolStripMenuItem"
		Me.DecodeToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
		Me.DecodeToolStripMenuItem.Text = "Decode"
		'
		'SerialToolStripMenuItem
		'
		Me.SerialToolStripMenuItem.Name = "SerialToolStripMenuItem"
		Me.SerialToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
		Me.SerialToolStripMenuItem.Text = "Serial"
		'
		'I2CToolStripMenuItem
		'
		Me.I2CToolStripMenuItem.Name = "I2CToolStripMenuItem"
		Me.I2CToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
		Me.I2CToolStripMenuItem.Text = "I2C"
		'
		'ToolStripSeparator8
		'
		Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
		Me.ToolStripSeparator8.Size = New System.Drawing.Size(276, 6)
		'
		'RigolFFTToolStripMenuInstrument
		'
		Me.RigolFFTToolStripMenuInstrument.Name = "RigolFFTToolStripMenuInstrument"
		Me.RigolFFTToolStripMenuInstrument.Size = New System.Drawing.Size(279, 22)
		Me.RigolFFTToolStripMenuInstrument.Text = "Rigol FFT"
		'
		'ToolStripSeparator9
		'
		Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
		Me.ToolStripSeparator9.Size = New System.Drawing.Size(276, 6)
		'
		'SignalGeneratorToolStripMenuInstrument
		'
		Me.SignalGeneratorToolStripMenuInstrument.Name = "SignalGeneratorToolStripMenuInstrument"
		Me.SignalGeneratorToolStripMenuInstrument.Size = New System.Drawing.Size(279, 22)
		Me.SignalGeneratorToolStripMenuInstrument.Text = "Signal Generator"
		'
		'AgilentScopeToolStripMenuInstrument
		'
		Me.AgilentScopeToolStripMenuInstrument.Name = "AgilentScopeToolStripMenuInstrument"
		Me.AgilentScopeToolStripMenuInstrument.Size = New System.Drawing.Size(279, 22)
		Me.AgilentScopeToolStripMenuInstrument.Text = "Agilent Scope"
		'
		'AgilentFFTToolStripMenuItem1
		'
		Me.AgilentFFTToolStripMenuItem1.Name = "AgilentFFTToolStripMenuItem1"
		Me.AgilentFFTToolStripMenuItem1.Size = New System.Drawing.Size(279, 22)
		Me.AgilentFFTToolStripMenuItem1.Text = "Agilent FFT"
		'
		'ToolStripSeparator14
		'
		Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
		Me.ToolStripSeparator14.Size = New System.Drawing.Size(276, 6)
		'
		'ToolStripMenuItem_AllDMM
		'
		Me.ToolStripMenuItem_AllDMM.Name = "ToolStripMenuItem_AllDMM"
		Me.ToolStripMenuItem_AllDMM.Size = New System.Drawing.Size(279, 22)
		Me.ToolStripMenuItem_AllDMM.Text = "All  DMM"
		'
		'ToolStripSeparator10
		'
		Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
		Me.ToolStripSeparator10.Size = New System.Drawing.Size(276, 6)
		'
		'AgilentESALSpectrumAnalyzerToolStripMenuItem
		'
		Me.AgilentESALSpectrumAnalyzerToolStripMenuItem.Name = "AgilentESALSpectrumAnalyzerToolStripMenuItem"
		Me.AgilentESALSpectrumAnalyzerToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
		Me.AgilentESALSpectrumAnalyzerToolStripMenuItem.Text = "Agilent ESA-L Spectrum Analyzer"
		'
		'ProgramableLoadToolStripMenuItem
		'
		Me.ProgramableLoadToolStripMenuItem.Name = "ProgramableLoadToolStripMenuItem"
		Me.ProgramableLoadToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
		Me.ProgramableLoadToolStripMenuItem.Text = "Programable Load"
		'
		'AudioAnalyzerToolStripMenuItem
		'
		Me.AudioAnalyzerToolStripMenuItem.Name = "AudioAnalyzerToolStripMenuItem"
		Me.AudioAnalyzerToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
		Me.AudioAnalyzerToolStripMenuItem.Text = "Audio Analyzer"
		'
		'PSUFrameToolStripMenuItem
		'
		Me.PSUFrameToolStripMenuItem.Name = "PSUFrameToolStripMenuItem"
		Me.PSUFrameToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
		Me.PSUFrameToolStripMenuItem.Text = " PSU Frame"
		'
		'ToolStripSeparator11
		'
		Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
		Me.ToolStripSeparator11.Size = New System.Drawing.Size(276, 6)
		'
		'ToolStripSeparator12
		'
		Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
		Me.ToolStripSeparator12.Size = New System.Drawing.Size(276, 6)
		'
		'PSU12ToolStripMenuItem
		'
		Me.PSU12ToolStripMenuItem.Name = "PSU12ToolStripMenuItem"
		Me.PSU12ToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
		Me.PSU12ToolStripMenuItem.Text = "HOME - PSU 1-2"
		'
		'PSU34ToolStripMenuItem
		'
		Me.PSU34ToolStripMenuItem.Name = "PSU34ToolStripMenuItem"
		Me.PSU34ToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
		Me.PSU34ToolStripMenuItem.Text = "HOME - PSU 3-4"
		'
		'DevicesToolStripMenuItem
		'
		Me.DevicesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IPAddressToolStripMenuItem, Me.ImpedanceToolStripMenuItem, Me.ToolStripSeparator7, Me.SpeachOnToolStripMenuItem, Me.ToolStripSeparator2, Me.SignalGenToolStripMenuItem, Me.GPIBToolStripMenuItem, Me.AgilentFFTToolStripMenuItem, Me.ToolStripSeparator4, Me.DMM1ToolStripMenuItemConfig, Me.DMM2ToolStripMenuItem, Me.DMM3ToolStripMenuItem, Me.DMM4ToolStripMenuItem, Me.ToolStripSeparator3, Me.DMM5ToolStripMenuItem, Me.DMM6ToolStripMenuItem, Me.ToolStripSeparator5, Me.ToolStripSeparator6, Me.SpectrumAnalyzerToolStripMenuItem, Me.SWITCHERToolStripMenuItem1, Me.PSUFrameToolStripMenuItem1, Me.DCLOADToolStripMenuItem, Me.ToolStripSeparator15, Me.PSUToolStripMenuItem, Me.ToolStripSeparator16})
		Me.DevicesToolStripMenuItem.Name = "DevicesToolStripMenuItem"
		Me.DevicesToolStripMenuItem.Size = New System.Drawing.Size(61, 21)
		Me.DevicesToolStripMenuItem.Text = "Config"
		'
		'IPAddressToolStripMenuItem
		'
		Me.IPAddressToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GPIBToolStripMenuItem1, Me.GPIB_IP, Me.GPIB_BUSS, Me.RIGOLToolStripMenuItem, Me.RIGOL_IP, Me.ToolStripMenuItem6, Me.SigGen_IP})
		Me.IPAddressToolStripMenuItem.Name = "IPAddressToolStripMenuItem"
		Me.IPAddressToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.IPAddressToolStripMenuItem.Text = "IP address"
		'
		'GPIBToolStripMenuItem1
		'
		Me.GPIBToolStripMenuItem1.Name = "GPIBToolStripMenuItem1"
		Me.GPIBToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
		Me.GPIBToolStripMenuItem1.Text = "GPIB:"
		'
		'GPIB_IP
		'
		Me.GPIB_IP.Name = "GPIB_IP"
		Me.GPIB_IP.Size = New System.Drawing.Size(100, 23)
		Me.GPIB_IP.Text = "44.44.44.244"
		'
		'GPIB_BUSS
		'
		Me.GPIB_BUSS.Name = "GPIB_BUSS"
		Me.GPIB_BUSS.Size = New System.Drawing.Size(100, 23)
		Me.GPIB_BUSS.Text = "gpib7"
		'
		'RIGOLToolStripMenuItem
		'
		Me.RIGOLToolStripMenuItem.Name = "RIGOLToolStripMenuItem"
		Me.RIGOLToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
		Me.RIGOLToolStripMenuItem.Text = "RIGOL:"
		'
		'RIGOL_IP
		'
		Me.RIGOL_IP.Name = "RIGOL_IP"
		Me.RIGOL_IP.Size = New System.Drawing.Size(100, 23)
		Me.RIGOL_IP.Text = "192.168.11.64"
		'
		'ToolStripMenuItem6
		'
		Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
		Me.ToolStripMenuItem6.Size = New System.Drawing.Size(160, 22)
		Me.ToolStripMenuItem6.Text = "Signal Gen:"
		'
		'SigGen_IP
		'
		Me.SigGen_IP.Name = "SigGen_IP"
		Me.SigGen_IP.Size = New System.Drawing.Size(100, 23)
		Me.SigGen_IP.Text = "44.44.44.101"
		'
		'ImpedanceToolStripMenuItem
		'
		Me.ImpedanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputImpedanceToolStripMenuItem, Me.OutputImpedanceToolStripMenuItem, Me.RefferenceToolStripMenuItem, Me.Reff_Imp})
		Me.ImpedanceToolStripMenuItem.Name = "ImpedanceToolStripMenuItem"
		Me.ImpedanceToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.ImpedanceToolStripMenuItem.Text = "Impedance"
		'
		'InputImpedanceToolStripMenuItem
		'
		Me.InputImpedanceToolStripMenuItem.Name = "InputImpedanceToolStripMenuItem"
		Me.InputImpedanceToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.InputImpedanceToolStripMenuItem.Text = "Input Impedance"
		'
		'OutputImpedanceToolStripMenuItem
		'
		Me.OutputImpedanceToolStripMenuItem.Name = "OutputImpedanceToolStripMenuItem"
		Me.OutputImpedanceToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.OutputImpedanceToolStripMenuItem.Text = "Output Impedance"
		'
		'RefferenceToolStripMenuItem
		'
		Me.RefferenceToolStripMenuItem.Name = "RefferenceToolStripMenuItem"
		Me.RefferenceToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.RefferenceToolStripMenuItem.Text = "Refference:"
		'
		'Reff_Imp
		'
		Me.Reff_Imp.Name = "Reff_Imp"
		Me.Reff_Imp.Size = New System.Drawing.Size(100, 23)
		Me.Reff_Imp.Text = "600"
		'
		'ToolStripSeparator7
		'
		Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
		Me.ToolStripSeparator7.Size = New System.Drawing.Size(188, 6)
		'
		'SpeachOnToolStripMenuItem
		'
		Me.SpeachOnToolStripMenuItem.Name = "SpeachOnToolStripMenuItem"
		Me.SpeachOnToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.SpeachOnToolStripMenuItem.Text = "Speach On"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(188, 6)
		'
		'SignalGenToolStripMenuItem
		'
		Me.SignalGenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GPIBAddressToolStripMenuItem2})
		Me.SignalGenToolStripMenuItem.Name = "SignalGenToolStripMenuItem"
		Me.SignalGenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.SignalGenToolStripMenuItem.Text = "Signal Gen"
		'
		'GPIBAddressToolStripMenuItem2
		'
		Me.GPIBAddressToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SignalGen_GPIB_address})
		Me.GPIBAddressToolStripMenuItem2.Name = "GPIBAddressToolStripMenuItem2"
		Me.GPIBAddressToolStripMenuItem2.Size = New System.Drawing.Size(156, 22)
		Me.GPIBAddressToolStripMenuItem2.Text = "GPIB address"
		'
		'SignalGen_GPIB_address
		'
		Me.SignalGen_GPIB_address.Name = "SignalGen_GPIB_address"
		Me.SignalGen_GPIB_address.Size = New System.Drawing.Size(100, 23)
		Me.SignalGen_GPIB_address.Text = "9"
		'
		'GPIBToolStripMenuItem
		'
		Me.GPIBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.GPIBAddress_Sope12})
		Me.GPIBToolStripMenuItem.Name = "GPIBToolStripMenuItem"
		Me.GPIBToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.GPIBToolStripMenuItem.Text = "Agilent Scope"
		'
		'ToolStripMenuItem5
		'
		Me.ToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgilentScopeGPIBaddress12})
		Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
		Me.ToolStripMenuItem5.Size = New System.Drawing.Size(181, 22)
		Me.ToolStripMenuItem5.Text = "GPIB Address 1-2"
		'
		'AgilentScopeGPIBaddress12
		'
		Me.AgilentScopeGPIBaddress12.Name = "AgilentScopeGPIBaddress12"
		Me.AgilentScopeGPIBaddress12.Size = New System.Drawing.Size(100, 23)
		Me.AgilentScopeGPIBaddress12.Text = "11"
		'
		'GPIBAddress_Sope12
		'
		Me.GPIBAddress_Sope12.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgilentScopeGPIBaddress34})
		Me.GPIBAddress_Sope12.Name = "GPIBAddress_Sope12"
		Me.GPIBAddress_Sope12.Size = New System.Drawing.Size(181, 22)
		Me.GPIBAddress_Sope12.Text = "GPIB Address 3-4"
		'
		'AgilentScopeGPIBaddress34
		'
		Me.AgilentScopeGPIBaddress34.Name = "AgilentScopeGPIBaddress34"
		Me.AgilentScopeGPIBaddress34.Size = New System.Drawing.Size(100, 23)
		Me.AgilentScopeGPIBaddress34.Text = "12"
		'
		'AgilentFFTToolStripMenuItem
		'
		Me.AgilentFFTToolStripMenuItem.Name = "AgilentFFTToolStripMenuItem"
		Me.AgilentFFTToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.AgilentFFTToolStripMenuItem.Text = "Agilent FFT"
		'
		'ToolStripSeparator4
		'
		Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
		Me.ToolStripSeparator4.Size = New System.Drawing.Size(188, 6)
		'
		'DMM1ToolStripMenuItemConfig
		'
		Me.DMM1ToolStripMenuItemConfig.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripMenuItem, Me.ToolStripMenuItem1})
		Me.DMM1ToolStripMenuItemConfig.Name = "DMM1ToolStripMenuItemConfig"
		Me.DMM1ToolStripMenuItemConfig.Size = New System.Drawing.Size(191, 22)
		Me.DMM1ToolStripMenuItemConfig.Text = "DMM 1"
		'
		'NameToolStripMenuItem
		'
		Me.NameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_NAME_1})
		Me.NameToolStripMenuItem.Name = "NameToolStripMenuItem"
		Me.NameToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
		Me.NameToolStripMenuItem.Text = "Name:"
		'
		'DMM_NAME_1
		'
		Me.DMM_NAME_1.Name = "DMM_NAME_1"
		Me.DMM_NAME_1.Size = New System.Drawing.Size(100, 23)
		Me.DMM_NAME_1.Text = "DMM1"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_gpibaddress_1})
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
		Me.ToolStripMenuItem1.Text = "GPIB Address:"
		'
		'DMM_gpibaddress_1
		'
		Me.DMM_gpibaddress_1.Name = "DMM_gpibaddress_1"
		Me.DMM_gpibaddress_1.Size = New System.Drawing.Size(100, 23)
		Me.DMM_gpibaddress_1.Text = "1"
		'
		'DMM2ToolStripMenuItem
		'
		Me.DMM2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripMenuItem1, Me.ToolStripMenuItem2})
		Me.DMM2ToolStripMenuItem.Name = "DMM2ToolStripMenuItem"
		Me.DMM2ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.DMM2ToolStripMenuItem.Text = "DMM2"
		'
		'NameToolStripMenuItem1
		'
		Me.NameToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_NAME_2})
		Me.NameToolStripMenuItem1.Name = "NameToolStripMenuItem1"
		Me.NameToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
		Me.NameToolStripMenuItem1.Text = "Name"
		'
		'DMM_NAME_2
		'
		Me.DMM_NAME_2.Name = "DMM_NAME_2"
		Me.DMM_NAME_2.Size = New System.Drawing.Size(100, 23)
		Me.DMM_NAME_2.Text = "DMM2"
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_gpibaddress_2})
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		Me.ToolStripMenuItem2.Size = New System.Drawing.Size(158, 22)
		Me.ToolStripMenuItem2.Text = "GPIB Address"
		'
		'DMM_gpibaddress_2
		'
		Me.DMM_gpibaddress_2.Name = "DMM_gpibaddress_2"
		Me.DMM_gpibaddress_2.Size = New System.Drawing.Size(100, 23)
		Me.DMM_gpibaddress_2.Text = "2"
		'
		'DMM3ToolStripMenuItem
		'
		Me.DMM3ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripMenuItem2, Me.ToolStripMenuItem3})
		Me.DMM3ToolStripMenuItem.Name = "DMM3ToolStripMenuItem"
		Me.DMM3ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.DMM3ToolStripMenuItem.Text = "DMM3"
		'
		'NameToolStripMenuItem2
		'
		Me.NameToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_NAME_3})
		Me.NameToolStripMenuItem2.Name = "NameToolStripMenuItem2"
		Me.NameToolStripMenuItem2.Size = New System.Drawing.Size(158, 22)
		Me.NameToolStripMenuItem2.Text = "Name:"
		'
		'DMM_NAME_3
		'
		Me.DMM_NAME_3.Name = "DMM_NAME_3"
		Me.DMM_NAME_3.Size = New System.Drawing.Size(100, 23)
		Me.DMM_NAME_3.Text = "DMM 3"
		'
		'ToolStripMenuItem3
		'
		Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_gpibaddress_3})
		Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
		Me.ToolStripMenuItem3.Size = New System.Drawing.Size(158, 22)
		Me.ToolStripMenuItem3.Text = "GPIB Address"
		'
		'DMM_gpibaddress_3
		'
		Me.DMM_gpibaddress_3.Name = "DMM_gpibaddress_3"
		Me.DMM_gpibaddress_3.Size = New System.Drawing.Size(100, 23)
		Me.DMM_gpibaddress_3.Text = "3"
		'
		'DMM4ToolStripMenuItem
		'
		Me.DMM4ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripMenuItem3, Me.ToolStripMenuItem4})
		Me.DMM4ToolStripMenuItem.Name = "DMM4ToolStripMenuItem"
		Me.DMM4ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.DMM4ToolStripMenuItem.Text = "DMM4"
		'
		'NameToolStripMenuItem3
		'
		Me.NameToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_NAME_4})
		Me.NameToolStripMenuItem3.Name = "NameToolStripMenuItem3"
		Me.NameToolStripMenuItem3.Size = New System.Drawing.Size(158, 22)
		Me.NameToolStripMenuItem3.Text = "Name:"
		'
		'DMM_NAME_4
		'
		Me.DMM_NAME_4.Name = "DMM_NAME_4"
		Me.DMM_NAME_4.Size = New System.Drawing.Size(100, 23)
		Me.DMM_NAME_4.Text = "DMM 4"
		'
		'ToolStripMenuItem4
		'
		Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_gpibaddress_4})
		Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
		Me.ToolStripMenuItem4.Size = New System.Drawing.Size(158, 22)
		Me.ToolStripMenuItem4.Text = "GPIB Address"
		'
		'DMM_gpibaddress_4
		'
		Me.DMM_gpibaddress_4.Name = "DMM_gpibaddress_4"
		Me.DMM_gpibaddress_4.Size = New System.Drawing.Size(100, 23)
		Me.DMM_gpibaddress_4.Text = "4"
		'
		'ToolStripSeparator3
		'
		Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
		Me.ToolStripSeparator3.Size = New System.Drawing.Size(188, 6)
		'
		'DMM5ToolStripMenuItem
		'
		Me.DMM5ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NAMEToolStripMenuItem4, Me.GPIBAddressToolStripMenuItem3})
		Me.DMM5ToolStripMenuItem.Name = "DMM5ToolStripMenuItem"
		Me.DMM5ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.DMM5ToolStripMenuItem.Text = "DMM5"
		'
		'NAMEToolStripMenuItem4
		'
		Me.NAMEToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_NAME_5})
		Me.NAMEToolStripMenuItem4.Name = "NAMEToolStripMenuItem4"
		Me.NAMEToolStripMenuItem4.Size = New System.Drawing.Size(162, 22)
		Me.NAMEToolStripMenuItem4.Text = "Name:"
		'
		'DMM_NAME_5
		'
		Me.DMM_NAME_5.Name = "DMM_NAME_5"
		Me.DMM_NAME_5.Size = New System.Drawing.Size(100, 23)
		Me.DMM_NAME_5.Text = "DMM5"
		'
		'GPIBAddressToolStripMenuItem3
		'
		Me.GPIBAddressToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_gpibaddress_5})
		Me.GPIBAddressToolStripMenuItem3.Name = "GPIBAddressToolStripMenuItem3"
		Me.GPIBAddressToolStripMenuItem3.Size = New System.Drawing.Size(162, 22)
		Me.GPIBAddressToolStripMenuItem3.Text = "GPIB Address:"
		'
		'DMM_gpibaddress_5
		'
		Me.DMM_gpibaddress_5.Name = "DMM_gpibaddress_5"
		Me.DMM_gpibaddress_5.Size = New System.Drawing.Size(100, 23)
		Me.DMM_gpibaddress_5.Text = "5"
		'
		'DMM6ToolStripMenuItem
		'
		Me.DMM6ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NAMEToolStripMenuItem5, Me.GPIBAddressToolStripMenuItem4})
		Me.DMM6ToolStripMenuItem.Name = "DMM6ToolStripMenuItem"
		Me.DMM6ToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.DMM6ToolStripMenuItem.Text = "DMM6"
		'
		'NAMEToolStripMenuItem5
		'
		Me.NAMEToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_NAME_6})
		Me.NAMEToolStripMenuItem5.Name = "NAMEToolStripMenuItem5"
		Me.NAMEToolStripMenuItem5.Size = New System.Drawing.Size(162, 22)
		Me.NAMEToolStripMenuItem5.Text = "Name:"
		'
		'DMM_NAME_6
		'
		Me.DMM_NAME_6.Name = "DMM_NAME_6"
		Me.DMM_NAME_6.Size = New System.Drawing.Size(100, 23)
		Me.DMM_NAME_6.Text = "DMM6"
		'
		'GPIBAddressToolStripMenuItem4
		'
		Me.GPIBAddressToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DMM_gpibaddress_6})
		Me.GPIBAddressToolStripMenuItem4.Name = "GPIBAddressToolStripMenuItem4"
		Me.GPIBAddressToolStripMenuItem4.Size = New System.Drawing.Size(162, 22)
		Me.GPIBAddressToolStripMenuItem4.Text = "GPIB Address:"
		'
		'DMM_gpibaddress_6
		'
		Me.DMM_gpibaddress_6.Name = "DMM_gpibaddress_6"
		Me.DMM_gpibaddress_6.Size = New System.Drawing.Size(100, 23)
		Me.DMM_gpibaddress_6.Text = "6"
		'
		'ToolStripSeparator5
		'
		Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
		Me.ToolStripSeparator5.Size = New System.Drawing.Size(188, 6)
		'
		'ToolStripSeparator6
		'
		Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
		Me.ToolStripSeparator6.Size = New System.Drawing.Size(188, 6)
		'
		'SpectrumAnalyzerToolStripMenuItem
		'
		Me.SpectrumAnalyzerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GPIBAddressToolStripMenuItem6})
		Me.SpectrumAnalyzerToolStripMenuItem.Name = "SpectrumAnalyzerToolStripMenuItem"
		Me.SpectrumAnalyzerToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.SpectrumAnalyzerToolStripMenuItem.Text = "Spectrum Analyzer"
		'
		'GPIBAddressToolStripMenuItem6
		'
		Me.GPIBAddressToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpectrumAnalyzer_GPIB_address})
		Me.GPIBAddressToolStripMenuItem6.Name = "GPIBAddressToolStripMenuItem6"
		Me.GPIBAddressToolStripMenuItem6.Size = New System.Drawing.Size(156, 22)
		Me.GPIBAddressToolStripMenuItem6.Text = "GPIB address"
		'
		'SpectrumAnalyzer_GPIB_address
		'
		Me.SpectrumAnalyzer_GPIB_address.Name = "SpectrumAnalyzer_GPIB_address"
		Me.SpectrumAnalyzer_GPIB_address.Size = New System.Drawing.Size(100, 23)
		Me.SpectrumAnalyzer_GPIB_address.Text = "26"
		'
		'SWITCHERToolStripMenuItem1
		'
		Me.SWITCHERToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GPIBAddressToolStripMenuItem5})
		Me.SWITCHERToolStripMenuItem1.Name = "SWITCHERToolStripMenuItem1"
		Me.SWITCHERToolStripMenuItem1.Size = New System.Drawing.Size(191, 22)
		Me.SWITCHERToolStripMenuItem1.Text = "SWITCHER"
		'
		'GPIBAddressToolStripMenuItem5
		'
		Me.GPIBAddressToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SWR_GPIB_ADDRESS})
		Me.GPIBAddressToolStripMenuItem5.Name = "GPIBAddressToolStripMenuItem5"
		Me.GPIBAddressToolStripMenuItem5.Size = New System.Drawing.Size(156, 22)
		Me.GPIBAddressToolStripMenuItem5.Text = "GPIB address"
		'
		'SWR_GPIB_ADDRESS
		'
		Me.SWR_GPIB_ADDRESS.Name = "SWR_GPIB_ADDRESS"
		Me.SWR_GPIB_ADDRESS.Size = New System.Drawing.Size(100, 23)
		Me.SWR_GPIB_ADDRESS.Text = "29"
		'
		'PSUFrameToolStripMenuItem1
		'
		Me.PSUFrameToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GPIBADDRESSToolStripMenuItem7, Me.PSUFrameGPIBAddress})
		Me.PSUFrameToolStripMenuItem1.Name = "PSUFrameToolStripMenuItem1"
		Me.PSUFrameToolStripMenuItem1.Size = New System.Drawing.Size(191, 22)
		Me.PSUFrameToolStripMenuItem1.Text = "PSU Frame"
		'
		'GPIBADDRESSToolStripMenuItem7
		'
		Me.GPIBADDRESSToolStripMenuItem7.Name = "GPIBADDRESSToolStripMenuItem7"
		Me.GPIBADDRESSToolStripMenuItem7.Size = New System.Drawing.Size(167, 22)
		Me.GPIBADDRESSToolStripMenuItem7.Text = "GPIB ADDRESS"
		'
		'PSUFrameGPIBAddress
		'
		Me.PSUFrameGPIBAddress.Name = "PSUFrameGPIBAddress"
		Me.PSUFrameGPIBAddress.Size = New System.Drawing.Size(100, 23)
		Me.PSUFrameGPIBAddress.Text = "24"
		'
		'DCLOADToolStripMenuItem
		'
		Me.DCLOADToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GPIBAddressToolStripMenuItem8})
		Me.DCLOADToolStripMenuItem.Name = "DCLOADToolStripMenuItem"
		Me.DCLOADToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.DCLOADToolStripMenuItem.Text = "DC LOAD"
		'
		'GPIBAddressToolStripMenuItem8
		'
		Me.GPIBAddressToolStripMenuItem8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DCloadGPIBaddress})
		Me.GPIBAddressToolStripMenuItem8.Name = "GPIBAddressToolStripMenuItem8"
		Me.GPIBAddressToolStripMenuItem8.Size = New System.Drawing.Size(158, 22)
		Me.GPIBAddressToolStripMenuItem8.Text = "GPIB Address"
		'
		'DCloadGPIBaddress
		'
		Me.DCloadGPIBaddress.Name = "DCloadGPIBaddress"
		Me.DCloadGPIBaddress.Size = New System.Drawing.Size(121, 23)
		Me.DCloadGPIBaddress.Text = "20"
		'
		'ToolStripSeparator15
		'
		Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
		Me.ToolStripSeparator15.Size = New System.Drawing.Size(188, 6)
		'
		'PSUToolStripMenuItem
		'
		Me.PSUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GPIBADDRESSToolStripMenuItem})
		Me.PSUToolStripMenuItem.Name = "PSUToolStripMenuItem"
		Me.PSUToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.PSUToolStripMenuItem.Text = "HOME PSU"
		'
		'GPIBADDRESSToolStripMenuItem
		'
		Me.GPIBADDRESSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PSU_GPIB_ADDRESS})
		Me.GPIBADDRESSToolStripMenuItem.Name = "GPIBADDRESSToolStripMenuItem"
		Me.GPIBADDRESSToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
		Me.GPIBADDRESSToolStripMenuItem.Text = "GPIB ADDRESS"
		'
		'PSU_GPIB_ADDRESS
		'
		Me.PSU_GPIB_ADDRESS.Name = "PSU_GPIB_ADDRESS"
		Me.PSU_GPIB_ADDRESS.Size = New System.Drawing.Size(100, 23)
		Me.PSU_GPIB_ADDRESS.Text = "15"
		'
		'ToolStripSeparator16
		'
		Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
		Me.ToolStripSeparator16.Size = New System.Drawing.Size(188, 6)
		'
		'CommandBoxToolStripMenuItem
		'
		Me.CommandBoxToolStripMenuItem.Name = "CommandBoxToolStripMenuItem"
		Me.CommandBoxToolStripMenuItem.Size = New System.Drawing.Size(110, 21)
		Me.CommandBoxToolStripMenuItem.Text = "Command Box"
		'
		'LOADALLToolStripMenuItem
		'
		Me.LOADALLToolStripMenuItem.Name = "LOADALLToolStripMenuItem"
		Me.LOADALLToolStripMenuItem.Size = New System.Drawing.Size(49, 21)
		Me.LOADALLToolStripMenuItem.Text = "Start"
		'
		'FrequencyChartToolStripMenuItem
		'
		Me.FrequencyChartToolStripMenuItem.Name = "FrequencyChartToolStripMenuItem"
		Me.FrequencyChartToolStripMenuItem.Size = New System.Drawing.Size(120, 21)
		Me.FrequencyChartToolStripMenuItem.Text = "Frequency Chart"
		'
		'WBSToolStripMenuItem
		'
		Me.WBSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreMoteToolStripMenuItem, Me.POD2ToolStripMenuItem, Me.POD10DigitalSwitchToolStripMenuItem})
		Me.WBSToolStripMenuItem.Name = "WBSToolStripMenuItem"
		Me.WBSToolStripMenuItem.Size = New System.Drawing.Size(48, 21)
		Me.WBSToolStripMenuItem.Text = "WBS"
		'
		'PreMoteToolStripMenuItem
		'
		Me.PreMoteToolStripMenuItem.Name = "PreMoteToolStripMenuItem"
		Me.PreMoteToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
		Me.PreMoteToolStripMenuItem.Text = "PreMote"
		'
		'POD2ToolStripMenuItem
		'
		Me.POD2ToolStripMenuItem.Name = "POD2ToolStripMenuItem"
		Me.POD2ToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
		Me.POD2ToolStripMenuItem.Text = "POD-2 - Analog Switch"
		'
		'POD10DigitalSwitchToolStripMenuItem
		'
		Me.POD10DigitalSwitchToolStripMenuItem.Name = "POD10DigitalSwitchToolStripMenuItem"
		Me.POD10DigitalSwitchToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
		Me.POD10DigitalSwitchToolStripMenuItem.Text = "POD-10 - Digital Switch"
		'
		'SerialPort1
		'
		Me.SerialPort1.PortName = "COM3"
		'
		'ReadValues
		'
		Me.ReadValues.Interval = 1000
		'
		'Button_BUSS_1
		'
		Me.Button_BUSS_1.BackColor = System.Drawing.Color.Maroon
		Me.Button_BUSS_1.Location = New System.Drawing.Point(-6, 168)
		Me.Button_BUSS_1.Name = "Button_BUSS_1"
		Me.Button_BUSS_1.Size = New System.Drawing.Size(4000, 110)
		Me.Button_BUSS_1.TabIndex = 84
		Me.Button_BUSS_1.Text = "Button1"
		Me.Button_BUSS_1.UseVisualStyleBackColor = False
		'
		'Button_BUSS_2
		'
		Me.Button_BUSS_2.BackColor = System.Drawing.Color.Red
		Me.Button_BUSS_2.Location = New System.Drawing.Point(-8, 277)
		Me.Button_BUSS_2.Name = "Button_BUSS_2"
		Me.Button_BUSS_2.Size = New System.Drawing.Size(4000, 110)
		Me.Button_BUSS_2.TabIndex = 85
		Me.Button_BUSS_2.Text = "Button1"
		Me.Button_BUSS_2.UseVisualStyleBackColor = False
		'
		'Button_BUSS_3
		'
		Me.Button_BUSS_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.Button_BUSS_3.Location = New System.Drawing.Point(-8, 386)
		Me.Button_BUSS_3.Name = "Button_BUSS_3"
		Me.Button_BUSS_3.Size = New System.Drawing.Size(4000, 110)
		Me.Button_BUSS_3.TabIndex = 86
		Me.Button_BUSS_3.Text = "Button2"
		Me.Button_BUSS_3.UseVisualStyleBackColor = False
		'
		'Button_BUSS_4
		'
		Me.Button_BUSS_4.BackColor = System.Drawing.Color.Yellow
		Me.Button_BUSS_4.Location = New System.Drawing.Point(-20, 496)
		Me.Button_BUSS_4.Name = "Button_BUSS_4"
		Me.Button_BUSS_4.Size = New System.Drawing.Size(4000, 110)
		Me.Button_BUSS_4.TabIndex = 87
		Me.Button_BUSS_4.Text = "Button3"
		Me.Button_BUSS_4.UseVisualStyleBackColor = False
		'
		'StatusStrip1
		'
		Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YoControlStatus, Me.YoTimeOut})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 1039)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(1924, 22)
		Me.StatusStrip1.TabIndex = 27
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'YoControlStatus
		'
		Me.YoControlStatus.Name = "YoControlStatus"
		Me.YoControlStatus.Size = New System.Drawing.Size(92, 17)
		Me.YoControlStatus.Text = "YoControlStatus"
		'
		'YoTimeOut
		'
		Me.YoTimeOut.Maximum = 10
		Me.YoTimeOut.Name = "YoTimeOut"
		Me.YoTimeOut.Size = New System.Drawing.Size(100, 16)
		Me.YoTimeOut.Step = 1
		'
		'YoTimer
		'
		Me.YoTimer.Interval = 1000
		'
		'Button_Uncheck_DIST_MON
		'
		Me.Button_Uncheck_DIST_MON.Location = New System.Drawing.Point(-3, -66)
		Me.Button_Uncheck_DIST_MON.Name = "Button_Uncheck_DIST_MON"
		Me.Button_Uncheck_DIST_MON.Size = New System.Drawing.Size(72, 39)
		Me.Button_Uncheck_DIST_MON.TabIndex = 36
		Me.Button_Uncheck_DIST_MON.Text = "OFF"
		Me.Button_Uncheck_DIST_MON.UseVisualStyleBackColor = True
		'
		'RadioButton_DIST_MON_A
		'
		Me.RadioButton_DIST_MON_A.AutoSize = True
		Me.RadioButton_DIST_MON_A.Checked = True
		Me.RadioButton_DIST_MON_A.Location = New System.Drawing.Point(10, 69)
		Me.RadioButton_DIST_MON_A.Name = "RadioButton_DIST_MON_A"
		Me.RadioButton_DIST_MON_A.Size = New System.Drawing.Size(32, 17)
		Me.RadioButton_DIST_MON_A.TabIndex = 0
		Me.RadioButton_DIST_MON_A.TabStop = True
		Me.RadioButton_DIST_MON_A.Text = "A"
		Me.RadioButton_DIST_MON_A.UseVisualStyleBackColor = True
		'
		'RadioButton_DIST_MON_B
		'
		Me.RadioButton_DIST_MON_B.AutoSize = True
		Me.RadioButton_DIST_MON_B.Location = New System.Drawing.Point(7, 174)
		Me.RadioButton_DIST_MON_B.Name = "RadioButton_DIST_MON_B"
		Me.RadioButton_DIST_MON_B.Size = New System.Drawing.Size(32, 17)
		Me.RadioButton_DIST_MON_B.TabIndex = 1
		Me.RadioButton_DIST_MON_B.TabStop = True
		Me.RadioButton_DIST_MON_B.Text = "B"
		Me.RadioButton_DIST_MON_B.UseVisualStyleBackColor = True
		'
		'RadioButton_DIST_MON_C
		'
		Me.RadioButton_DIST_MON_C.AutoSize = True
		Me.RadioButton_DIST_MON_C.Location = New System.Drawing.Point(7, 276)
		Me.RadioButton_DIST_MON_C.Name = "RadioButton_DIST_MON_C"
		Me.RadioButton_DIST_MON_C.Size = New System.Drawing.Size(32, 17)
		Me.RadioButton_DIST_MON_C.TabIndex = 2
		Me.RadioButton_DIST_MON_C.TabStop = True
		Me.RadioButton_DIST_MON_C.Text = "C"
		Me.RadioButton_DIST_MON_C.UseVisualStyleBackColor = True
		'
		'RadioButton_DIST_MON_D
		'
		Me.RadioButton_DIST_MON_D.AutoSize = True
		Me.RadioButton_DIST_MON_D.Location = New System.Drawing.Point(7, 381)
		Me.RadioButton_DIST_MON_D.Name = "RadioButton_DIST_MON_D"
		Me.RadioButton_DIST_MON_D.Size = New System.Drawing.Size(33, 17)
		Me.RadioButton_DIST_MON_D.TabIndex = 3
		Me.RadioButton_DIST_MON_D.TabStop = True
		Me.RadioButton_DIST_MON_D.Text = "D"
		Me.RadioButton_DIST_MON_D.UseVisualStyleBackColor = True
		'
		'GroupBox13
		'
		Me.GroupBox13.Controls.Add(Me.Button_Uncheck_DIST_MON)
		Me.GroupBox13.Controls.Add(Me.RadioButton_DIST_MON_D)
		Me.GroupBox13.Controls.Add(Me.RadioButton_DIST_MON_C)
		Me.GroupBox13.Controls.Add(Me.RadioButton_DIST_MON_B)
		Me.GroupBox13.Controls.Add(Me.RadioButton_DIST_MON_A)
		Me.GroupBox13.Location = New System.Drawing.Point(1834, 185)
		Me.GroupBox13.Name = "GroupBox13"
		Me.GroupBox13.Size = New System.Drawing.Size(54, 437)
		Me.GroupBox13.TabIndex = 82
		Me.GroupBox13.TabStop = False
		Me.GroupBox13.Text = "MON"
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.Blue
		Me.Button1.Location = New System.Drawing.Point(-20, 716)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(4000, 110)
		Me.Button1.TabIndex = 211
		Me.Button1.Text = "Button3"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.Color.Green
		Me.Button2.Location = New System.Drawing.Point(-22, 606)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(4000, 110)
		Me.Button2.TabIndex = 210
		Me.Button2.Text = "Button2"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.Color.Violet
		Me.Button4.Location = New System.Drawing.Point(-31, 826)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(4000, 110)
		Me.Button4.TabIndex = 212
		Me.Button4.Text = "Button4"
		Me.Button4.UseVisualStyleBackColor = False
		'
		'Button5
		'
		Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.Button5.Location = New System.Drawing.Point(-97, 936)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(4000, 110)
		Me.Button5.TabIndex = 217
		Me.Button5.Text = "Button5"
		Me.Button5.UseVisualStyleBackColor = False
		'
		'Button6
		'
		Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button6.Location = New System.Drawing.Point(12, 37)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(154, 125)
		Me.Button6.TabIndex = 252
		Me.Button6.Text = "ALL PSU OFF"
		Me.Button6.UseVisualStyleBackColor = True
		'
		'TabControl4
		'
		Me.TabControl4.Controls.Add(Me.TabPage8)
		Me.TabControl4.Controls.Add(Me.TabPage9)
		Me.TabControl4.Location = New System.Drawing.Point(920, 120)
		Me.TabControl4.Name = "TabControl4"
		Me.TabControl4.SelectedIndex = 0
		Me.TabControl4.Size = New System.Drawing.Size(384, 115)
		Me.TabControl4.TabIndex = 254
		Me.TabControl4.Visible = False
		'
		'TabPage8
		'
		Me.TabPage8.Controls.Add(Me.Dist_measure_Voltage)
		Me.TabPage8.Controls.Add(Me.Dist_measure_SINAD)
		Me.TabPage8.Controls.Add(Me.Dist_measure_DSTN)
		Me.TabPage8.Location = New System.Drawing.Point(4, 22)
		Me.TabPage8.Name = "TabPage8"
		Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage8.Size = New System.Drawing.Size(376, 89)
		Me.TabPage8.TabIndex = 0
		Me.TabPage8.Text = "TabPage8"
		Me.TabPage8.UseVisualStyleBackColor = True
		'
		'Dist_measure_Voltage
		'
		Me.Dist_measure_Voltage.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Dist_measure_Voltage.Location = New System.Drawing.Point(123, 20)
		Me.Dist_measure_Voltage.Name = "Dist_measure_Voltage"
		Me.Dist_measure_Voltage.Size = New System.Drawing.Size(85, 57)
		Me.Dist_measure_Voltage.TabIndex = 261
		Me.Dist_measure_Voltage.Text = "Volt"
		'
		'Dist_measure_SINAD
		'
		Me.Dist_measure_SINAD.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Dist_measure_SINAD.Location = New System.Drawing.Point(226, 23)
		Me.Dist_measure_SINAD.Name = "Dist_measure_SINAD"
		Me.Dist_measure_SINAD.Size = New System.Drawing.Size(104, 57)
		Me.Dist_measure_SINAD.TabIndex = 259
		Me.Dist_measure_SINAD.Text = "sinad"
		'
		'Dist_measure_DSTN
		'
		Me.Dist_measure_DSTN.Font = New System.Drawing.Font("Arial Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Dist_measure_DSTN.Location = New System.Drawing.Point(24, 23)
		Me.Dist_measure_DSTN.Name = "Dist_measure_DSTN"
		Me.Dist_measure_DSTN.Size = New System.Drawing.Size(90, 57)
		Me.Dist_measure_DSTN.TabIndex = 260
		Me.Dist_measure_DSTN.Text = "thd"
		'
		'TabPage9
		'
		Me.TabPage9.Controls.Add(Me.DistortionChange)
		Me.TabPage9.Controls.Add(Me.Dist_Amp)
		Me.TabPage9.Controls.Add(Me.Label17)
		Me.TabPage9.Controls.Add(Me.Dist_freq)
		Me.TabPage9.Controls.Add(Me.PictureBox_Distortion)
		Me.TabPage9.Location = New System.Drawing.Point(4, 22)
		Me.TabPage9.Name = "TabPage9"
		Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage9.Size = New System.Drawing.Size(376, 89)
		Me.TabPage9.TabIndex = 1
		Me.TabPage9.Text = "TabPage9"
		Me.TabPage9.UseVisualStyleBackColor = True
		'
		'DistortionChange
		'
		Me.DistortionChange.Location = New System.Drawing.Point(195, 33)
		Me.DistortionChange.Name = "DistortionChange"
		Me.DistortionChange.Size = New System.Drawing.Size(49, 23)
		Me.DistortionChange.TabIndex = 257
		Me.DistortionChange.Text = "Distortion Update "
		Me.DistortionChange.UseVisualStyleBackColor = True
		'
		'Dist_Amp
		'
		Me.Dist_Amp.Location = New System.Drawing.Point(135, 46)
		Me.Dist_Amp.Name = "Dist_Amp"
		Me.Dist_Amp.Size = New System.Drawing.Size(54, 20)
		Me.Dist_Amp.TabIndex = 258
		Me.Dist_Amp.Text = "1"
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Location = New System.Drawing.Point(78, 22)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(51, 13)
		Me.Label17.TabIndex = 255
		Me.Label17.Text = "Distortion"
		'
		'Dist_freq
		'
		Me.Dist_freq.Location = New System.Drawing.Point(134, 20)
		Me.Dist_freq.Name = "Dist_freq"
		Me.Dist_freq.Size = New System.Drawing.Size(55, 20)
		Me.Dist_freq.TabIndex = 256
		Me.Dist_freq.Text = "1000"
		'
		'PictureBox_Distortion
		'
		Me.PictureBox_Distortion.Image = CType(resources.GetObject("PictureBox_Distortion.Image"), System.Drawing.Image)
		Me.PictureBox_Distortion.Location = New System.Drawing.Point(6, 41)
		Me.PictureBox_Distortion.Name = "PictureBox_Distortion"
		Me.PictureBox_Distortion.Size = New System.Drawing.Size(126, 45)
		Me.PictureBox_Distortion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox_Distortion.TabIndex = 215
		Me.PictureBox_Distortion.TabStop = False
		'
		'EventLog1
		'
		Me.EventLog1.SynchronizingObject = Me
		'
		'SigGen_FrequencyTrackBar
		'
		Me.SigGen_FrequencyTrackBar.Location = New System.Drawing.Point(1203, -3)
		Me.SigGen_FrequencyTrackBar.Maximum = 50000
		Me.SigGen_FrequencyTrackBar.Name = "SigGen_FrequencyTrackBar"
		Me.SigGen_FrequencyTrackBar.Size = New System.Drawing.Size(685, 45)
		Me.SigGen_FrequencyTrackBar.TabIndex = 266
		'
		'Button_DIST_GEN
		'
		Me.Button_DIST_GEN.BackColor = System.Drawing.Color.Transparent
		Me.Button_DIST_GEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_DIST_GEN.Location = New System.Drawing.Point(278, 52)
		Me.Button_DIST_GEN.Name = "Button_DIST_GEN"
		Me.Button_DIST_GEN.Size = New System.Drawing.Size(100, 100)
		Me.Button_DIST_GEN.TabIndex = 280
		Me.Button_DIST_GEN.Text = "DIST GEN"
		Me.Button_DIST_GEN.UseVisualStyleBackColor = False
		'
		'Button_ISO_B_IN
		'
		Me.Button_ISO_B_IN.BackColor = System.Drawing.Color.Transparent
		Me.Button_ISO_B_IN.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_ISO_B_IN.Location = New System.Drawing.Point(1108, 52)
		Me.Button_ISO_B_IN.Name = "Button_ISO_B_IN"
		Me.Button_ISO_B_IN.Size = New System.Drawing.Size(100, 100)
		Me.Button_ISO_B_IN.TabIndex = 279
		Me.Button_ISO_B_IN.Text = "ISO B IN"
		Me.Button_ISO_B_IN.UseVisualStyleBackColor = False
		'
		'Button_ISO_A_IN
		'
		Me.Button_ISO_A_IN.BackColor = System.Drawing.Color.Transparent
		Me.Button_ISO_A_IN.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_ISO_A_IN.Location = New System.Drawing.Point(1002, 49)
		Me.Button_ISO_A_IN.Name = "Button_ISO_A_IN"
		Me.Button_ISO_A_IN.Size = New System.Drawing.Size(100, 100)
		Me.Button_ISO_A_IN.TabIndex = 278
		Me.Button_ISO_A_IN.Text = "ISO A IN"
		Me.Button_ISO_A_IN.UseVisualStyleBackColor = False
		'
		'Button_Bridging_Input
		'
		Me.Button_Bridging_Input.BackColor = System.Drawing.Color.Transparent
		Me.Button_Bridging_Input.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_Bridging_Input.Location = New System.Drawing.Point(172, 49)
		Me.Button_Bridging_Input.Name = "Button_Bridging_Input"
		Me.Button_Bridging_Input.Size = New System.Drawing.Size(100, 100)
		Me.Button_Bridging_Input.TabIndex = 277
		Me.Button_Bridging_Input.Text = "BRIDGE IN"
		Me.Button_Bridging_Input.UseVisualStyleBackColor = False
		'
		'Button_SIGNAL_GEN
		'
		Me.Button_SIGNAL_GEN.BackColor = System.Drawing.Color.Transparent
		Me.Button_SIGNAL_GEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_SIGNAL_GEN.Location = New System.Drawing.Point(384, 52)
		Me.Button_SIGNAL_GEN.Name = "Button_SIGNAL_GEN"
		Me.Button_SIGNAL_GEN.Size = New System.Drawing.Size(100, 100)
		Me.Button_SIGNAL_GEN.TabIndex = 276
		Me.Button_SIGNAL_GEN.Tag = ""
		Me.Button_SIGNAL_GEN.Text = "SIG GEN"
		Me.Button_SIGNAL_GEN.UseVisualStyleBackColor = False
		'
		'Button_SPECTRUM
		'
		Me.Button_SPECTRUM.BackColor = System.Drawing.Color.Transparent
		Me.Button_SPECTRUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_SPECTRUM.Location = New System.Drawing.Point(1690, 52)
		Me.Button_SPECTRUM.Name = "Button_SPECTRUM"
		Me.Button_SPECTRUM.Size = New System.Drawing.Size(100, 100)
		Me.Button_SPECTRUM.TabIndex = 284
		Me.Button_SPECTRUM.Text = "SPECTRUM"
		Me.Button_SPECTRUM.UseVisualStyleBackColor = False
		'
		'Button_DISTORTION
		'
		Me.Button_DISTORTION.BackColor = System.Drawing.Color.Transparent
		Me.Button_DISTORTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_DISTORTION.Location = New System.Drawing.Point(1351, 45)
		Me.Button_DISTORTION.Name = "Button_DISTORTION"
		Me.Button_DISTORTION.Size = New System.Drawing.Size(100, 100)
		Me.Button_DISTORTION.TabIndex = 283
		Me.Button_DISTORTION.Text = "DISTORTION"
		Me.Button_DISTORTION.UseVisualStyleBackColor = False
		'
		'Button_PATCH_PANEL_OUT
		'
		Me.Button_PATCH_PANEL_OUT.BackColor = System.Drawing.Color.Transparent
		Me.Button_PATCH_PANEL_OUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_PATCH_PANEL_OUT.Location = New System.Drawing.Point(871, 52)
		Me.Button_PATCH_PANEL_OUT.Name = "Button_PATCH_PANEL_OUT"
		Me.Button_PATCH_PANEL_OUT.Size = New System.Drawing.Size(100, 101)
		Me.Button_PATCH_PANEL_OUT.TabIndex = 282
		Me.Button_PATCH_PANEL_OUT.Text = "PTCH  PNL  OUT"
		Me.Button_PATCH_PANEL_OUT.UseVisualStyleBackColor = False
		'
		'Button_FROM_COAX
		'
		Me.Button_FROM_COAX.BackColor = System.Drawing.Color.Transparent
		Me.Button_FROM_COAX.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_FROM_COAX.Location = New System.Drawing.Point(1796, 52)
		Me.Button_FROM_COAX.Name = "Button_FROM_COAX"
		Me.Button_FROM_COAX.Size = New System.Drawing.Size(105, 100)
		Me.Button_FROM_COAX.TabIndex = 281
		Me.Button_FROM_COAX.Text = "RESET COAX"
		Me.Button_FROM_COAX.UseVisualStyleBackColor = False
		'
		'SoundSource1
		'
		Me.SoundSource1.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.SoundSource1.Location = New System.Drawing.Point(501, 16)
		Me.SoundSource1.Name = "SoundSource1"
		Me.SoundSource1.Size = New System.Drawing.Size(311, 161)
		Me.SoundSource1.TabIndex = 274
		'
		'DmmControl8
		'
		Me.DmmControl8.BackColor = System.Drawing.Color.Gray
		Me.DmmControl8.Location = New System.Drawing.Point(1510, 939)
		Me.DmmControl8.Meter_to_Address = 8.0R
		Me.DmmControl8.Name = "DmmControl8"
		Me.DmmControl8.Size = New System.Drawing.Size(413, 110)
		Me.DmmControl8.TabIndex = 263
		Me.DmmControl8.Value_To_Display = -0.003479R
		'
		'DmmControl7
		'
		Me.DmmControl7.BackColor = System.Drawing.Color.Violet
		Me.DmmControl7.Location = New System.Drawing.Point(1509, 829)
		Me.DmmControl7.Meter_to_Address = 7.0R
		Me.DmmControl7.Name = "DmmControl7"
		Me.DmmControl7.Size = New System.Drawing.Size(413, 110)
		Me.DmmControl7.TabIndex = 262
		Me.DmmControl7.Value_To_Display = 0.020283R
		'
		'DmmControl6
		'
		Me.DmmControl6.BackColor = System.Drawing.Color.Blue
		Me.DmmControl6.Location = New System.Drawing.Point(1509, 719)
		Me.DmmControl6.Meter_to_Address = 6.0R
		Me.DmmControl6.Name = "DmmControl6"
		Me.DmmControl6.Size = New System.Drawing.Size(413, 110)
		Me.DmmControl6.TabIndex = 261
		Me.DmmControl6.Value_To_Display = 0.075823R
		'
		'DmmControl5
		'
		Me.DmmControl5.BackColor = System.Drawing.Color.Green
		Me.DmmControl5.Location = New System.Drawing.Point(1511, 609)
		Me.DmmControl5.Meter_to_Address = 5.0R
		Me.DmmControl5.Name = "DmmControl5"
		Me.DmmControl5.Size = New System.Drawing.Size(413, 110)
		Me.DmmControl5.TabIndex = 260
		Me.DmmControl5.Value_To_Display = -0.001416R
		'
		'DmmControl4
		'
		Me.DmmControl4.BackColor = System.Drawing.Color.Yellow
		Me.DmmControl4.Location = New System.Drawing.Point(1511, 499)
		Me.DmmControl4.Meter_to_Address = 4.0R
		Me.DmmControl4.Name = "DmmControl4"
		Me.DmmControl4.Size = New System.Drawing.Size(413, 110)
		Me.DmmControl4.TabIndex = 259
		Me.DmmControl4.Value_To_Display = 0.023024R
		'
		'DmmControl3
		'
		Me.DmmControl3.BackColor = System.Drawing.Color.Orange
		Me.DmmControl3.Location = New System.Drawing.Point(1510, 389)
		Me.DmmControl3.Meter_to_Address = 3.0R
		Me.DmmControl3.Name = "DmmControl3"
		Me.DmmControl3.Size = New System.Drawing.Size(413, 110)
		Me.DmmControl3.TabIndex = 258
		Me.DmmControl3.Value_To_Display = 0.000696R
		'
		'DmmControl2
		'
		Me.DmmControl2.BackColor = System.Drawing.Color.Red
		Me.DmmControl2.Location = New System.Drawing.Point(1510, 280)
		Me.DmmControl2.Meter_to_Address = 2.0R
		Me.DmmControl2.Name = "DmmControl2"
		Me.DmmControl2.Size = New System.Drawing.Size(413, 110)
		Me.DmmControl2.TabIndex = 257
		Me.DmmControl2.Value_To_Display = -0.011937R
		'
		'DmmControl1
		'
		Me.DmmControl1.BackColor = System.Drawing.Color.Brown
		Me.DmmControl1.Location = New System.Drawing.Point(1511, 171)
		Me.DmmControl1.Meter_to_Address = 1.0R
		Me.DmmControl1.Name = "DmmControl1"
		Me.DmmControl1.Size = New System.Drawing.Size(413, 110)
		Me.DmmControl1.TabIndex = 256
		Me.DmmControl1.Value_To_Display = -0.00278R
		'
		'Scope_Channel_Display6
		'
		Me.Scope_Channel_Display6.Location = New System.Drawing.Point(423, 723)
		Me.Scope_Channel_Display6.Name = "Scope_Channel_Display6"
		Me.Scope_Channel_Display6.PropertyChangeGPIBaddress = 13
		Me.Scope_Channel_Display6.PropertyChannelToGraph = 6
		Me.Scope_Channel_Display6.Size = New System.Drawing.Size(986, 97)
		Me.Scope_Channel_Display6.TabIndex = 250
		'
		'Scope_Channel_Display5
		'
		Me.Scope_Channel_Display5.Location = New System.Drawing.Point(423, 609)
		Me.Scope_Channel_Display5.Name = "Scope_Channel_Display5"
		Me.Scope_Channel_Display5.PropertyChangeGPIBaddress = 13
		Me.Scope_Channel_Display5.PropertyChannelToGraph = 5
		Me.Scope_Channel_Display5.Size = New System.Drawing.Size(986, 110)
		Me.Scope_Channel_Display5.TabIndex = 249
		'
		'PsU_Module5
		'
		Me.PsU_Module5.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module5.DataReadCurrent = 0R
		Me.PsU_Module5.DataReadVoltage = 0R
		Me.PsU_Module5.Location = New System.Drawing.Point(1, 713)
		Me.PsU_Module5.ModuleMaxCurrent = "0.3"
		Me.PsU_Module5.ModuleMaxVoltage = "15"
		Me.PsU_Module5.ModulePositionNumber = "5"
		Me.PsU_Module5.Name = "PsU_Module5"
		Me.PsU_Module5.OutputEnabled = False
		Me.PsU_Module5.Size = New System.Drawing.Size(372, 110)
		Me.PsU_Module5.TabIndex = 247
		'
		'PsU_Module6
		'
		Me.PsU_Module6.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module6.DataReadCurrent = 0R
		Me.PsU_Module6.DataReadVoltage = 0R
		Me.PsU_Module6.Location = New System.Drawing.Point(1, 820)
		Me.PsU_Module6.ModuleMaxCurrent = "0.3"
		Me.PsU_Module6.ModuleMaxVoltage = "15"
		Me.PsU_Module6.ModulePositionNumber = "6"
		Me.PsU_Module6.Name = "PsU_Module6"
		Me.PsU_Module6.OutputEnabled = False
		Me.PsU_Module6.Size = New System.Drawing.Size(372, 110)
		Me.PsU_Module6.TabIndex = 246
		'
		'PsU_Module7
		'
		Me.PsU_Module7.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module7.DataReadCurrent = 0R
		Me.PsU_Module7.DataReadVoltage = 0R
		Me.PsU_Module7.Location = New System.Drawing.Point(1, 936)
		Me.PsU_Module7.ModuleMaxCurrent = "0.3"
		Me.PsU_Module7.ModuleMaxVoltage = "15"
		Me.PsU_Module7.ModulePositionNumber = "7"
		Me.PsU_Module7.Name = "PsU_Module7"
		Me.PsU_Module7.OutputEnabled = False
		Me.PsU_Module7.Size = New System.Drawing.Size(372, 110)
		Me.PsU_Module7.TabIndex = 245
		'
		'PsU_Module4
		'
		Me.PsU_Module4.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module4.DataReadCurrent = 0R
		Me.PsU_Module4.DataReadVoltage = 0R
		Me.PsU_Module4.Location = New System.Drawing.Point(-1, 609)
		Me.PsU_Module4.ModuleMaxCurrent = "0.3"
		Me.PsU_Module4.ModuleMaxVoltage = "48"
		Me.PsU_Module4.ModulePositionNumber = "4"
		Me.PsU_Module4.Name = "PsU_Module4"
		Me.PsU_Module4.OutputEnabled = False
		Me.PsU_Module4.Size = New System.Drawing.Size(372, 110)
		Me.PsU_Module4.TabIndex = 244
		'
		'Scope_Channel_Display1
		'
		Me.Scope_Channel_Display1.Location = New System.Drawing.Point(423, 171)
		Me.Scope_Channel_Display1.Name = "Scope_Channel_Display1"
		Me.Scope_Channel_Display1.PropertyChangeGPIBaddress = 11
		Me.Scope_Channel_Display1.PropertyChannelToGraph = 1
		Me.Scope_Channel_Display1.Size = New System.Drawing.Size(986, 106)
		Me.Scope_Channel_Display1.TabIndex = 197
		'
		'Scope_Channel_Display4
		'
		Me.Scope_Channel_Display4.Location = New System.Drawing.Point(423, 498)
		Me.Scope_Channel_Display4.Name = "Scope_Channel_Display4"
		Me.Scope_Channel_Display4.PropertyChangeGPIBaddress = 12
		Me.Scope_Channel_Display4.PropertyChannelToGraph = 4
		Me.Scope_Channel_Display4.Size = New System.Drawing.Size(986, 108)
		Me.Scope_Channel_Display4.TabIndex = 196
		'
		'Scope_Channel_Display3
		'
		Me.Scope_Channel_Display3.Location = New System.Drawing.Point(423, 390)
		Me.Scope_Channel_Display3.Name = "Scope_Channel_Display3"
		Me.Scope_Channel_Display3.PropertyChangeGPIBaddress = 12
		Me.Scope_Channel_Display3.PropertyChannelToGraph = 3
		Me.Scope_Channel_Display3.Size = New System.Drawing.Size(986, 104)
		Me.Scope_Channel_Display3.TabIndex = 195
		'
		'Scope_Channel_Display2
		'
		Me.Scope_Channel_Display2.Location = New System.Drawing.Point(423, 280)
		Me.Scope_Channel_Display2.Name = "Scope_Channel_Display2"
		Me.Scope_Channel_Display2.PropertyChangeGPIBaddress = 11
		Me.Scope_Channel_Display2.PropertyChannelToGraph = 2
		Me.Scope_Channel_Display2.Size = New System.Drawing.Size(986, 103)
		Me.Scope_Channel_Display2.TabIndex = 194
		'
		'PsU_Module0
		'
		Me.PsU_Module0.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module0.DataReadCurrent = 0R
		Me.PsU_Module0.DataReadVoltage = 0R
		Me.PsU_Module0.Location = New System.Drawing.Point(1, 169)
		Me.PsU_Module0.ModuleMaxCurrent = "0.3"
		Me.PsU_Module0.ModuleMaxVoltage = "5"
		Me.PsU_Module0.ModulePositionNumber = "0"
		Me.PsU_Module0.Name = "PsU_Module0"
		Me.PsU_Module0.OutputEnabled = False
		Me.PsU_Module0.Size = New System.Drawing.Size(372, 110)
		Me.PsU_Module0.TabIndex = 248
		'
		'PsU_Module3
		'
		Me.PsU_Module3.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module3.DataReadCurrent = 0R
		Me.PsU_Module3.DataReadVoltage = 0R
		Me.PsU_Module3.Location = New System.Drawing.Point(-1, 501)
		Me.PsU_Module3.ModuleMaxCurrent = "0.3"
		Me.PsU_Module3.ModuleMaxVoltage = "25"
		Me.PsU_Module3.ModulePositionNumber = "3"
		Me.PsU_Module3.Name = "PsU_Module3"
		Me.PsU_Module3.OutputEnabled = False
		Me.PsU_Module3.Size = New System.Drawing.Size(372, 110)
		Me.PsU_Module3.TabIndex = 243
		'
		'PsU_Module2
		'
		Me.PsU_Module2.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module2.DataReadCurrent = 0R
		Me.PsU_Module2.DataReadVoltage = 0R
		Me.PsU_Module2.Location = New System.Drawing.Point(-1, 386)
		Me.PsU_Module2.ModuleMaxCurrent = "0.3"
		Me.PsU_Module2.ModuleMaxVoltage = "25"
		Me.PsU_Module2.ModulePositionNumber = "2"
		Me.PsU_Module2.Name = "PsU_Module2"
		Me.PsU_Module2.OutputEnabled = False
		Me.PsU_Module2.Size = New System.Drawing.Size(372, 110)
		Me.PsU_Module2.TabIndex = 242
		'
		'PsU_Module1
		'
		Me.PsU_Module1.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module1.DataReadCurrent = 0R
		Me.PsU_Module1.DataReadVoltage = 0R
		Me.PsU_Module1.Location = New System.Drawing.Point(1, 276)
		Me.PsU_Module1.ModuleMaxCurrent = "0.3"
		Me.PsU_Module1.ModuleMaxVoltage = "25"
		Me.PsU_Module1.ModulePositionNumber = "1"
		Me.PsU_Module1.Name = "PsU_Module1"
		Me.PsU_Module1.OutputEnabled = False
		Me.PsU_Module1.Size = New System.Drawing.Size(372, 110)
		Me.PsU_Module1.TabIndex = 241
		'
		'UserInterfaceShell
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1924, 1061)
		Me.Controls.Add(Me.Scope_Channel_Display6)
		Me.Controls.Add(Me.Scope_Channel_Display5)
		Me.Controls.Add(Me.Scope_Channel_Display1)
		Me.Controls.Add(Me.Scope_Channel_Display4)
		Me.Controls.Add(Me.Scope_Channel_Display3)
		Me.Controls.Add(Me.Scope_Channel_Display2)
		Me.Controls.Add(Me.Button_SPECTRUM)
		Me.Controls.Add(Me.Button_DISTORTION)
		Me.Controls.Add(Me.Button_PATCH_PANEL_OUT)
		Me.Controls.Add(Me.Button_FROM_COAX)
		Me.Controls.Add(Me.Button_DIST_GEN)
		Me.Controls.Add(Me.Button_ISO_B_IN)
		Me.Controls.Add(Me.Button_ISO_A_IN)
		Me.Controls.Add(Me.Button_Bridging_Input)
		Me.Controls.Add(Me.Button_SIGNAL_GEN)
		Me.Controls.Add(Me.SigGen_FrequencyTrackBar)
		Me.Controls.Add(Me.DmmControl8)
		Me.Controls.Add(Me.DmmControl7)
		Me.Controls.Add(Me.DmmControl6)
		Me.Controls.Add(Me.DmmControl5)
		Me.Controls.Add(Me.DmmControl4)
		Me.Controls.Add(Me.DmmControl3)
		Me.Controls.Add(Me.DmmControl2)
		Me.Controls.Add(Me.DmmControl1)
		Me.Controls.Add(Me.TabControl4)
		Me.Controls.Add(Me.Button6)
		Me.Controls.Add(Me.PsU_Module5)
		Me.Controls.Add(Me.PsU_Module6)
		Me.Controls.Add(Me.PsU_Module7)
		Me.Controls.Add(Me.PsU_Module4)
		Me.Controls.Add(Me.Button5)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.GroupBox13)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.userIntMainMenuStrip)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.PsU_Module0)
		Me.Controls.Add(Me.PsU_Module3)
		Me.Controls.Add(Me.PsU_Module2)
		Me.Controls.Add(Me.PsU_Module1)
		Me.Controls.Add(Me.Button_BUSS_4)
		Me.Controls.Add(Me.Button_BUSS_3)
		Me.Controls.Add(Me.Button_BUSS_1)
		Me.Controls.Add(Me.Button_BUSS_2)
		Me.Controls.Add(Me.SoundSource1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.IsMdiContainer = True
		Me.Name = "UserInterfaceShell"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "APK Test Bench"
		Me.userIntMainMenuStrip.ResumeLayout(False)
		Me.userIntMainMenuStrip.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.GroupBox13.ResumeLayout(False)
		Me.GroupBox13.PerformLayout()
		Me.TabControl4.ResumeLayout(False)
		Me.TabPage8.ResumeLayout(False)
		Me.TabPage8.PerformLayout()
		Me.TabPage9.ResumeLayout(False)
		Me.TabPage9.PerformLayout()
		CType(Me.PictureBox_Distortion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.SigGen_FrequencyTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents userIntMainMenuStrip As MenuStrip
	Friend WithEvents DeviceToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DevicesToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InstrumentToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CommandBoxToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents WBSToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SaveConfigToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LoadConfigToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents AgilentNetworkToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RelaysToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SwitcherToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
	Friend WithEvents RigolScopeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Rigol_Channel1ToolStripMenuInstrument As ToolStripMenuItem
	Friend WithEvents Rigol_Channel2ToolStripMenuInstrument As ToolStripMenuItem
	Friend WithEvents Rigol_Channel3ToolStripMenuInstrument As ToolStripMenuItem
	Friend WithEvents Rigol_Channel4ToolStripMenuInstrument As ToolStripMenuItem
	Friend WithEvents DecodeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SerialToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents I2CToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
	Friend WithEvents RigolFFTToolStripMenuInstrument As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
	Friend WithEvents SignalGeneratorToolStripMenuInstrument As ToolStripMenuItem
	Friend WithEvents AgilentScopeToolStripMenuInstrument As ToolStripMenuItem
	Friend WithEvents AgilentFFTToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
	Friend WithEvents ToolStripMenuItem_AllDMM As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
	Friend WithEvents AgilentESALSpectrumAnalyzerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ProgramableLoadToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AudioAnalyzerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PSUFrameToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
	Friend WithEvents PSU12ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PSU34ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents IPAddressToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GPIBToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents GPIB_IP As ToolStripTextBox
	Friend WithEvents GPIB_BUSS As ToolStripTextBox
	Friend WithEvents RIGOLToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RIGOL_IP As ToolStripTextBox
	Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
	Friend WithEvents SigGen_IP As ToolStripTextBox
	Friend WithEvents ImpedanceToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InputImpedanceToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OutputImpedanceToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RefferenceToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Reff_Imp As ToolStripTextBox
	Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
	Friend WithEvents SpeachOnToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents SignalGenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GPIBAddressToolStripMenuItem2 As ToolStripMenuItem
	Friend WithEvents SignalGen_GPIB_address As ToolStripTextBox
	Friend WithEvents GPIBToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
	Friend WithEvents AgilentScopeGPIBaddress12 As ToolStripTextBox
	Friend WithEvents GPIBAddress_Sope12 As ToolStripMenuItem
	Friend WithEvents AgilentScopeGPIBaddress34 As ToolStripTextBox
	Friend WithEvents AgilentFFTToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
	Friend WithEvents DMM1ToolStripMenuItemConfig As ToolStripMenuItem
	Friend WithEvents NameToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DMM_NAME_1 As ToolStripTextBox
	Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents DMM_gpibaddress_1 As ToolStripTextBox
	Friend WithEvents DMM2ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NameToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents DMM_NAME_2 As ToolStripTextBox
	Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
	Friend WithEvents DMM_gpibaddress_2 As ToolStripTextBox
	Friend WithEvents DMM3ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NameToolStripMenuItem2 As ToolStripMenuItem
	Friend WithEvents DMM_NAME_3 As ToolStripTextBox
	Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
	Friend WithEvents DMM_gpibaddress_3 As ToolStripTextBox
	Friend WithEvents DMM4ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NameToolStripMenuItem3 As ToolStripMenuItem
	Friend WithEvents DMM_NAME_4 As ToolStripTextBox
	Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
	Friend WithEvents DMM_gpibaddress_4 As ToolStripTextBox
	Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
	Friend WithEvents DMM5ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NAMEToolStripMenuItem4 As ToolStripMenuItem
	Friend WithEvents DMM_NAME_5 As ToolStripTextBox
	Friend WithEvents GPIBAddressToolStripMenuItem3 As ToolStripMenuItem
	Friend WithEvents DMM_gpibaddress_5 As ToolStripTextBox
	Friend WithEvents DMM6ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents NAMEToolStripMenuItem5 As ToolStripMenuItem
	Friend WithEvents DMM_NAME_6 As ToolStripTextBox
	Friend WithEvents GPIBAddressToolStripMenuItem4 As ToolStripMenuItem
	Friend WithEvents DMM_gpibaddress_6 As ToolStripTextBox
	Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
	Friend WithEvents SpectrumAnalyzerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GPIBAddressToolStripMenuItem6 As ToolStripMenuItem
	Friend WithEvents SpectrumAnalyzer_GPIB_address As ToolStripTextBox
	Friend WithEvents SWITCHERToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents GPIBAddressToolStripMenuItem5 As ToolStripMenuItem
	Friend WithEvents SWR_GPIB_ADDRESS As ToolStripTextBox
	Friend WithEvents PSUFrameToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents GPIBADDRESSToolStripMenuItem7 As ToolStripMenuItem
	Friend WithEvents PSUFrameGPIBAddress As ToolStripTextBox
	Friend WithEvents DCLOADToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GPIBAddressToolStripMenuItem8 As ToolStripMenuItem
	Friend WithEvents DCloadGPIBaddress As ToolStripComboBox
	Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
	Friend WithEvents PSUToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GPIBADDRESSToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PSU_GPIB_ADDRESS As ToolStripTextBox
	Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
	Friend WithEvents PreMoteToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents POD2ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents POD10DigitalSwitchToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RIGOL_FFT_TOOLTIP As ToolTip
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents SerialPort1 As IO.Ports.SerialPort
	Friend WithEvents ReadValues As Timer
	Friend WithEvents Button_BUSS_1 As Button
	Friend WithEvents Button_BUSS_2 As Button
	Friend WithEvents Button_BUSS_3 As Button
	Friend WithEvents Button_BUSS_4 As Button
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents YoControlStatus As ToolStripStatusLabel
	Friend WithEvents YoTimeOut As ToolStripProgressBar
	Public WithEvents YoTimer As Timer
	Friend WithEvents Button_Uncheck_DIST_MON As Button
	Friend WithEvents RadioButton_DIST_MON_A As RadioButton
	Friend WithEvents RadioButton_DIST_MON_B As RadioButton
	Friend WithEvents RadioButton_DIST_MON_C As RadioButton
	Friend WithEvents RadioButton_DIST_MON_D As RadioButton
	Friend WithEvents GroupBox13 As GroupBox
	Friend WithEvents Scope_Channel_Display2 As Scope_Channel_Display
	Friend WithEvents Scope_Channel_Display3 As Scope_Channel_Display
	Friend WithEvents Scope_Channel_Display4 As Scope_Channel_Display
	Friend WithEvents Scope_Channel_Display1 As Scope_Channel_Display
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents PictureBox_Distortion As PictureBox
	Friend WithEvents Button5 As Button
	Friend WithEvents PsU_Module0 As PSU_Module
	Friend WithEvents PsU_Module5 As PSU_Module
	Friend WithEvents PsU_Module6 As PSU_Module
	Friend WithEvents PsU_Module7 As PSU_Module
	Friend WithEvents PsU_Module4 As PSU_Module
	Friend WithEvents PsU_Module3 As PSU_Module
	Friend WithEvents PsU_Module2 As PSU_Module
	Friend WithEvents PsU_Module1 As PSU_Module
	Friend WithEvents Scope_Channel_Display5 As Scope_Channel_Display
	Friend WithEvents Scope_Channel_Display6 As Scope_Channel_Display
	Friend WithEvents Button6 As Button
	Friend WithEvents TabControl4 As TabControl
	Friend WithEvents TabPage8 As TabPage
	Friend WithEvents Dist_measure_Voltage As TextBox
	Friend WithEvents Dist_measure_SINAD As TextBox
	Friend WithEvents Dist_measure_DSTN As TextBox
	Friend WithEvents TabPage9 As TabPage
	Friend WithEvents Dist_Amp As TextBox
	Friend WithEvents Label17 As Label
	Friend WithEvents Dist_freq As TextBox
	Friend WithEvents DistortionChange As Button
	Friend WithEvents LOADALLToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EventLog1 As EventLog
	Friend WithEvents DmmControl1 As DMMControl
	Friend WithEvents DmmControl8 As DMMControl
	Friend WithEvents DmmControl7 As DMMControl
	Friend WithEvents DmmControl6 As DMMControl
	Friend WithEvents DmmControl5 As DMMControl
	Friend WithEvents DmmControl4 As DMMControl
	Friend WithEvents DmmControl3 As DMMControl
	Friend WithEvents DmmControl2 As DMMControl

	Friend WithEvents SigGen_FrequencyTrackBar As TrackBar
	Friend WithEvents SoundSource1 As SoundSource
	Friend WithEvents FrequencyChartToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Button_DIST_GEN As Button
	Friend WithEvents Button_ISO_B_IN As Button
	Friend WithEvents Button_ISO_A_IN As Button
	Friend WithEvents Button_Bridging_Input As Button
	Friend WithEvents Button_SIGNAL_GEN As Button
	Friend WithEvents Button_SPECTRUM As Button
	Friend WithEvents Button_DISTORTION As Button
	Friend WithEvents Button_PATCH_PANEL_OUT As Button
	Friend WithEvents Button_FROM_COAX As Button
End Class
