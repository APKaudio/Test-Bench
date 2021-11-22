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
		Me.RelaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
		Me.AgilentFFTToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.SpectrumAnalyzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AgilentESALSpectrumAnalyzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GPIBAddressToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
		Me.SpectrumAnalyzer_GPIB_address = New System.Windows.Forms.ToolStripTextBox()
		Me.AudioAnalyzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DCLOADToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProgramableLoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GPIBAddressToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
		Me.DCloadGPIBaddress = New System.Windows.Forms.ToolStripComboBox()
		Me.DevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ImpedanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.InputImpedanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OutputImpedanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RefferenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.Reff_Imp = New System.Windows.Forms.ToolStripTextBox()
		Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
		Me.SpeachOnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
		Me.CommandBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.LOADALLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FrequencyChartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.GlobalFreq = New System.Windows.Forms.ToolStripTextBox()
		Me.RIGOL_FFT_TOOLTIP = New System.Windows.Forms.ToolTip(Me.components)
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.ReadValues = New System.Windows.Forms.Timer(Me.components)
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.YoControlStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.YoTimeOut = New System.Windows.Forms.ToolStripProgressBar()
		Me.YoTimer = New System.Windows.Forms.Timer(Me.components)
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
		Me.TableLayoutPanel_PSU = New System.Windows.Forms.TableLayoutPanel()
		Me.PsU_Module2 = New APK_Bench_Software.PSU_Module()
		Me.PsU_Module0 = New APK_Bench_Software.PSU_Module()
		Me.PsU_Module1 = New APK_Bench_Software.PSU_Module()
		Me.PsU_Module3 = New APK_Bench_Software.PSU_Module()
		Me.PsU_Module7 = New APK_Bench_Software.PSU_Module()
		Me.PsU_Module4 = New APK_Bench_Software.PSU_Module()
		Me.PsU_Module5 = New APK_Bench_Software.PSU_Module()
		Me.PsU_Module6 = New APK_Bench_Software.PSU_Module()
		Me.TableLayoutPanel_DMM = New System.Windows.Forms.TableLayoutPanel()
		Me.DmmControl1 = New APK_Bench_Software.DMMControl()
		Me.DmmControl8 = New APK_Bench_Software.DMMControl()
		Me.DmmControl4 = New APK_Bench_Software.DMMControl()
		Me.DmmControl7 = New APK_Bench_Software.DMMControl()
		Me.DmmControl5 = New APK_Bench_Software.DMMControl()
		Me.DmmControl6 = New APK_Bench_Software.DMMControl()
		Me.DmmControl3 = New APK_Bench_Software.DMMControl()
		Me.DmmControl2 = New APK_Bench_Software.DMMControl()
		Me.TableLayoutPanel_Scopes = New System.Windows.Forms.TableLayoutPanel()
		Me.Scope_Channel_Display_3 = New APK_Bench_Software.Scope_Channel_Display()
		Me.Scope_Channel_Display_4 = New APK_Bench_Software.Scope_Channel_Display()
		Me.Scope_Channel_Display_2 = New APK_Bench_Software.Scope_Channel_Display()
		Me.Scope_Channel_Display_1 = New APK_Bench_Software.Scope_Channel_Display()
		Me.TableLayoutPanelAllTables = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
		Me.Button_ISO_A_IN = New System.Windows.Forms.Button()
		Me.Button_ISO_B_IN = New System.Windows.Forms.Button()
		Me.Button_DISTORTION = New System.Windows.Forms.Button()
		Me.Button_SPECTRUM = New System.Windows.Forms.Button()
		Me.TableLayoutPanel_SigGen = New System.Windows.Forms.TableLayoutPanel()
		Me.Button_SIGNAL_GEN = New System.Windows.Forms.Button()
		Me.Button_Bridging_Input = New System.Windows.Forms.Button()
		Me.Button_GEN_2 = New System.Windows.Forms.Button()
		Me.Button_PATCH_PANEL_OUT = New System.Windows.Forms.Button()
		Me.TableLayoutPanel_MatrixCoax_000 = New System.Windows.Forms.TableLayoutPanel()
		Me.Scope_Channel_Display1 = New APK_Bench_Software.Scope_Channel_Display()
		Me.userIntMainMenuStrip.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.TabControl4.SuspendLayout()
		Me.TabPage8.SuspendLayout()
		Me.TabPage9.SuspendLayout()
		CType(Me.PictureBox_Distortion, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel_PSU.SuspendLayout()
		Me.TableLayoutPanel_DMM.SuspendLayout()
		Me.TableLayoutPanel_Scopes.SuspendLayout()
		Me.TableLayoutPanelAllTables.SuspendLayout()
		Me.TableLayoutPanel5.SuspendLayout()
		Me.TableLayoutPanel_SigGen.SuspendLayout()
		Me.TableLayoutPanel_MatrixCoax_000.SuspendLayout()
		Me.SuspendLayout()
		'
		'userIntMainMenuStrip
		'
		Me.userIntMainMenuStrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.userIntMainMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.userIntMainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeviceToolStripMenuItem, Me.DataToolStripMenuItem, Me.InstrumentToolStripMenuItem, Me.DevicesToolStripMenuItem, Me.CommandBoxToolStripMenuItem, Me.LOADALLToolStripMenuItem, Me.FrequencyChartToolStripMenuItem, Me.GlobalFreq})
		Me.userIntMainMenuStrip.Location = New System.Drawing.Point(0, 0)
		Me.userIntMainMenuStrip.Name = "userIntMainMenuStrip"
		Me.userIntMainMenuStrip.Size = New System.Drawing.Size(5124, 27)
		Me.userIntMainMenuStrip.TabIndex = 25
		Me.userIntMainMenuStrip.Text = "MenuStrip1"
		Me.userIntMainMenuStrip.Visible = False
		'
		'DeviceToolStripMenuItem
		'
		Me.DeviceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveConfigToolStripMenuItem, Me.LoadConfigToolStripMenuItem, Me.ToolStripSeparator1})
		Me.DeviceToolStripMenuItem.Name = "DeviceToolStripMenuItem"
		Me.DeviceToolStripMenuItem.Size = New System.Drawing.Size(42, 23)
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
		Me.DataToolStripMenuItem.Size = New System.Drawing.Size(49, 23)
		Me.DataToolStripMenuItem.Text = "&Data"
		'
		'InstrumentToolStripMenuItem
		'
		Me.InstrumentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelaysToolStripMenuItem, Me.ToolStripSeparator13, Me.RigolScopeToolStripMenuItem, Me.Rigol_Channel1ToolStripMenuInstrument, Me.Rigol_Channel2ToolStripMenuInstrument, Me.Rigol_Channel3ToolStripMenuInstrument, Me.Rigol_Channel4ToolStripMenuInstrument, Me.DecodeToolStripMenuItem, Me.ToolStripSeparator8, Me.RigolFFTToolStripMenuInstrument, Me.ToolStripSeparator9, Me.AgilentFFTToolStripMenuItem1, Me.SpectrumAnalyzerToolStripMenuItem, Me.AudioAnalyzerToolStripMenuItem, Me.DCLOADToolStripMenuItem})
		Me.InstrumentToolStripMenuItem.Name = "InstrumentToolStripMenuItem"
		Me.InstrumentToolStripMenuItem.Size = New System.Drawing.Size(88, 23)
		Me.InstrumentToolStripMenuItem.Text = "&Instrument"
		'
		'RelaysToolStripMenuItem
		'
		Me.RelaysToolStripMenuItem.Name = "RelaysToolStripMenuItem"
		Me.RelaysToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.RelaysToolStripMenuItem.Text = "Auxiliary Relays"
		'
		'ToolStripSeparator13
		'
		Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
		Me.ToolStripSeparator13.Size = New System.Drawing.Size(188, 6)
		'
		'RigolScopeToolStripMenuItem
		'
		Me.RigolScopeToolStripMenuItem.Name = "RigolScopeToolStripMenuItem"
		Me.RigolScopeToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.RigolScopeToolStripMenuItem.Text = "Rigol Scope"
		'
		'Rigol_Channel1ToolStripMenuInstrument
		'
		Me.Rigol_Channel1ToolStripMenuInstrument.Name = "Rigol_Channel1ToolStripMenuInstrument"
		Me.Rigol_Channel1ToolStripMenuInstrument.Size = New System.Drawing.Size(191, 22)
		Me.Rigol_Channel1ToolStripMenuInstrument.Text = "Channel 1"
		'
		'Rigol_Channel2ToolStripMenuInstrument
		'
		Me.Rigol_Channel2ToolStripMenuInstrument.Name = "Rigol_Channel2ToolStripMenuInstrument"
		Me.Rigol_Channel2ToolStripMenuInstrument.Size = New System.Drawing.Size(191, 22)
		Me.Rigol_Channel2ToolStripMenuInstrument.Text = "Channel 2"
		'
		'Rigol_Channel3ToolStripMenuInstrument
		'
		Me.Rigol_Channel3ToolStripMenuInstrument.Name = "Rigol_Channel3ToolStripMenuInstrument"
		Me.Rigol_Channel3ToolStripMenuInstrument.Size = New System.Drawing.Size(191, 22)
		Me.Rigol_Channel3ToolStripMenuInstrument.Text = "Channel 3"
		'
		'Rigol_Channel4ToolStripMenuInstrument
		'
		Me.Rigol_Channel4ToolStripMenuInstrument.Name = "Rigol_Channel4ToolStripMenuInstrument"
		Me.Rigol_Channel4ToolStripMenuInstrument.Size = New System.Drawing.Size(191, 22)
		Me.Rigol_Channel4ToolStripMenuInstrument.Text = "Channel 4"
		'
		'DecodeToolStripMenuItem
		'
		Me.DecodeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SerialToolStripMenuItem, Me.I2CToolStripMenuItem})
		Me.DecodeToolStripMenuItem.Name = "DecodeToolStripMenuItem"
		Me.DecodeToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
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
		Me.ToolStripSeparator8.Size = New System.Drawing.Size(188, 6)
		'
		'RigolFFTToolStripMenuInstrument
		'
		Me.RigolFFTToolStripMenuInstrument.Name = "RigolFFTToolStripMenuInstrument"
		Me.RigolFFTToolStripMenuInstrument.Size = New System.Drawing.Size(191, 22)
		Me.RigolFFTToolStripMenuInstrument.Text = "Rigol FFT"
		'
		'ToolStripSeparator9
		'
		Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
		Me.ToolStripSeparator9.Size = New System.Drawing.Size(188, 6)
		'
		'AgilentFFTToolStripMenuItem1
		'
		Me.AgilentFFTToolStripMenuItem1.Name = "AgilentFFTToolStripMenuItem1"
		Me.AgilentFFTToolStripMenuItem1.Size = New System.Drawing.Size(191, 22)
		Me.AgilentFFTToolStripMenuItem1.Text = "Agilent FFT"
		'
		'SpectrumAnalyzerToolStripMenuItem
		'
		Me.SpectrumAnalyzerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgilentESALSpectrumAnalyzerToolStripMenuItem, Me.GPIBAddressToolStripMenuItem6})
		Me.SpectrumAnalyzerToolStripMenuItem.Name = "SpectrumAnalyzerToolStripMenuItem"
		Me.SpectrumAnalyzerToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.SpectrumAnalyzerToolStripMenuItem.Text = "Spectrum Analyzer"
		'
		'AgilentESALSpectrumAnalyzerToolStripMenuItem
		'
		Me.AgilentESALSpectrumAnalyzerToolStripMenuItem.Name = "AgilentESALSpectrumAnalyzerToolStripMenuItem"
		Me.AgilentESALSpectrumAnalyzerToolStripMenuItem.Size = New System.Drawing.Size(279, 22)
		Me.AgilentESALSpectrumAnalyzerToolStripMenuItem.Text = "Agilent ESA-L Spectrum Analyzer"
		'
		'GPIBAddressToolStripMenuItem6
		'
		Me.GPIBAddressToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpectrumAnalyzer_GPIB_address})
		Me.GPIBAddressToolStripMenuItem6.Name = "GPIBAddressToolStripMenuItem6"
		Me.GPIBAddressToolStripMenuItem6.Size = New System.Drawing.Size(279, 22)
		Me.GPIBAddressToolStripMenuItem6.Text = "GPIB address"
		'
		'SpectrumAnalyzer_GPIB_address
		'
		Me.SpectrumAnalyzer_GPIB_address.Name = "SpectrumAnalyzer_GPIB_address"
		Me.SpectrumAnalyzer_GPIB_address.Size = New System.Drawing.Size(100, 23)
		Me.SpectrumAnalyzer_GPIB_address.Text = "26"
		'
		'AudioAnalyzerToolStripMenuItem
		'
		Me.AudioAnalyzerToolStripMenuItem.Name = "AudioAnalyzerToolStripMenuItem"
		Me.AudioAnalyzerToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.AudioAnalyzerToolStripMenuItem.Text = "Audio Analyzer"
		'
		'DCLOADToolStripMenuItem
		'
		Me.DCLOADToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramableLoadToolStripMenuItem, Me.GPIBAddressToolStripMenuItem8})
		Me.DCLOADToolStripMenuItem.Name = "DCLOADToolStripMenuItem"
		Me.DCLOADToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
		Me.DCLOADToolStripMenuItem.Text = "DC LOAD"
		'
		'ProgramableLoadToolStripMenuItem
		'
		Me.ProgramableLoadToolStripMenuItem.Name = "ProgramableLoadToolStripMenuItem"
		Me.ProgramableLoadToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
		Me.ProgramableLoadToolStripMenuItem.Text = "Programable Load"
		'
		'GPIBAddressToolStripMenuItem8
		'
		Me.GPIBAddressToolStripMenuItem8.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DCloadGPIBaddress})
		Me.GPIBAddressToolStripMenuItem8.Name = "GPIBAddressToolStripMenuItem8"
		Me.GPIBAddressToolStripMenuItem8.Size = New System.Drawing.Size(189, 22)
		Me.GPIBAddressToolStripMenuItem8.Text = "GPIB Address"
		'
		'DCloadGPIBaddress
		'
		Me.DCloadGPIBaddress.Name = "DCloadGPIBaddress"
		Me.DCloadGPIBaddress.Size = New System.Drawing.Size(121, 23)
		Me.DCloadGPIBaddress.Text = "20"
		'
		'DevicesToolStripMenuItem
		'
		Me.DevicesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImpedanceToolStripMenuItem, Me.ToolStripSeparator7, Me.SpeachOnToolStripMenuItem, Me.ToolStripSeparator2, Me.ToolStripSeparator4, Me.ToolStripSeparator3, Me.ToolStripSeparator5, Me.ToolStripSeparator6, Me.ToolStripSeparator15, Me.ToolStripSeparator16})
		Me.DevicesToolStripMenuItem.Name = "DevicesToolStripMenuItem"
		Me.DevicesToolStripMenuItem.Size = New System.Drawing.Size(61, 23)
		Me.DevicesToolStripMenuItem.Text = "Config"
		'
		'ImpedanceToolStripMenuItem
		'
		Me.ImpedanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputImpedanceToolStripMenuItem, Me.OutputImpedanceToolStripMenuItem, Me.RefferenceToolStripMenuItem, Me.Reff_Imp})
		Me.ImpedanceToolStripMenuItem.Name = "ImpedanceToolStripMenuItem"
		Me.ImpedanceToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
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
		Me.ToolStripSeparator7.Size = New System.Drawing.Size(140, 6)
		'
		'SpeachOnToolStripMenuItem
		'
		Me.SpeachOnToolStripMenuItem.Name = "SpeachOnToolStripMenuItem"
		Me.SpeachOnToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
		Me.SpeachOnToolStripMenuItem.Text = "Speach On"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(140, 6)
		'
		'ToolStripSeparator4
		'
		Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
		Me.ToolStripSeparator4.Size = New System.Drawing.Size(140, 6)
		'
		'ToolStripSeparator3
		'
		Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
		Me.ToolStripSeparator3.Size = New System.Drawing.Size(140, 6)
		'
		'ToolStripSeparator5
		'
		Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
		Me.ToolStripSeparator5.Size = New System.Drawing.Size(140, 6)
		'
		'ToolStripSeparator6
		'
		Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
		Me.ToolStripSeparator6.Size = New System.Drawing.Size(140, 6)
		'
		'ToolStripSeparator15
		'
		Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
		Me.ToolStripSeparator15.Size = New System.Drawing.Size(140, 6)
		'
		'ToolStripSeparator16
		'
		Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
		Me.ToolStripSeparator16.Size = New System.Drawing.Size(140, 6)
		'
		'CommandBoxToolStripMenuItem
		'
		Me.CommandBoxToolStripMenuItem.Name = "CommandBoxToolStripMenuItem"
		Me.CommandBoxToolStripMenuItem.Size = New System.Drawing.Size(110, 23)
		Me.CommandBoxToolStripMenuItem.Text = "Command Box"
		'
		'LOADALLToolStripMenuItem
		'
		Me.LOADALLToolStripMenuItem.Name = "LOADALLToolStripMenuItem"
		Me.LOADALLToolStripMenuItem.Size = New System.Drawing.Size(49, 23)
		Me.LOADALLToolStripMenuItem.Text = "Start"
		'
		'FrequencyChartToolStripMenuItem
		'
		Me.FrequencyChartToolStripMenuItem.Name = "FrequencyChartToolStripMenuItem"
		Me.FrequencyChartToolStripMenuItem.Size = New System.Drawing.Size(120, 23)
		Me.FrequencyChartToolStripMenuItem.Text = "Frequency Chart"
		'
		'GlobalFreq
		'
		Me.GlobalFreq.Name = "GlobalFreq"
		Me.GlobalFreq.Size = New System.Drawing.Size(200, 23)
		'
		'ReadValues
		'
		Me.ReadValues.Interval = 1000
		'
		'StatusStrip1
		'
		Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YoControlStatus, Me.YoTimeOut})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 1446)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(5124, 22)
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
		'Button6
		'
		Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button6.Location = New System.Drawing.Point(761, 682)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(262, 140)
		Me.Button6.TabIndex = 252
		Me.Button6.Text = "ALL PSU OFF"
		Me.Button6.UseVisualStyleBackColor = True
		'
		'TabControl4
		'
		Me.TabControl4.Controls.Add(Me.TabPage8)
		Me.TabControl4.Controls.Add(Me.TabPage9)
		Me.TabControl4.Location = New System.Drawing.Point(2808, 736)
		Me.TabControl4.Name = "TabControl4"
		Me.TabControl4.SelectedIndex = 0
		Me.TabControl4.Size = New System.Drawing.Size(384, 115)
		Me.TabControl4.TabIndex = 254
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
		'TableLayoutPanel_PSU
		'
		Me.TableLayoutPanel_PSU.ColumnCount = 2
		Me.TableLayoutPanel_PSU.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel_PSU.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel_PSU.Controls.Add(Me.PsU_Module2, 0, 1)
		Me.TableLayoutPanel_PSU.Controls.Add(Me.PsU_Module0, 0, 0)
		Me.TableLayoutPanel_PSU.Controls.Add(Me.PsU_Module1, 1, 0)
		Me.TableLayoutPanel_PSU.Controls.Add(Me.PsU_Module3, 1, 1)
		Me.TableLayoutPanel_PSU.Controls.Add(Me.PsU_Module7, 1, 3)
		Me.TableLayoutPanel_PSU.Controls.Add(Me.PsU_Module4, 0, 2)
		Me.TableLayoutPanel_PSU.Controls.Add(Me.PsU_Module5, 1, 2)
		Me.TableLayoutPanel_PSU.Controls.Add(Me.PsU_Module6, 0, 3)
		Me.TableLayoutPanel_PSU.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel_PSU.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel_PSU.Name = "TableLayoutPanel_PSU"
		Me.TableLayoutPanel_PSU.RowCount = 4
		Me.TableLayoutPanel_PSU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
		Me.TableLayoutPanel_PSU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
		Me.TableLayoutPanel_PSU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
		Me.TableLayoutPanel_PSU.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
		Me.TableLayoutPanel_PSU.Size = New System.Drawing.Size(752, 659)
		Me.TableLayoutPanel_PSU.TabIndex = 292
		'
		'PsU_Module2
		'
		Me.PsU_Module2.AES70_Manager_GPIB_address = 30
		Me.PsU_Module2.AES70_Manager_GPIB_bus = 7
		Me.PsU_Module2.AES70_Manager_IP_address = "44.44.44.222"
		Me.PsU_Module2.AES70_ModuleMaxCurrent = "0.3"
		Me.PsU_Module2.AES70_OutputEnabled = False
		Me.PsU_Module2.AES70_Property_ChangeRouterConnection = 0
		Me.PsU_Module2.AES70_Property_Channel = 2
		Me.PsU_Module2.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module2.DataReadCurrent = 0R
		Me.PsU_Module2.DataReadVoltage = 0R
		Me.PsU_Module2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PsU_Module2.Location = New System.Drawing.Point(6, 170)
		Me.PsU_Module2.Margin = New System.Windows.Forms.Padding(6)
		Me.PsU_Module2.ModuleMaxVoltage = "25"
		Me.PsU_Module2.Name = "PsU_Module2"
		Me.PsU_Module2.Size = New System.Drawing.Size(364, 152)
		Me.PsU_Module2.TabIndex = 242
		Me.PsU_Module2.Visible = False
		'
		'PsU_Module0
		'
		Me.PsU_Module0.AES70_Manager_GPIB_address = 30
		Me.PsU_Module0.AES70_Manager_GPIB_bus = 7
		Me.PsU_Module0.AES70_Manager_IP_address = "44.44.44.222"
		Me.PsU_Module0.AES70_ModuleMaxCurrent = "0.3"
		Me.PsU_Module0.AES70_OutputEnabled = False
		Me.PsU_Module0.AES70_Property_ChangeRouterConnection = 0
		Me.PsU_Module0.AES70_Property_Channel = 0
		Me.PsU_Module0.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module0.DataReadCurrent = 0R
		Me.PsU_Module0.DataReadVoltage = 0R
		Me.PsU_Module0.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PsU_Module0.Location = New System.Drawing.Point(6, 6)
		Me.PsU_Module0.Margin = New System.Windows.Forms.Padding(6)
		Me.PsU_Module0.ModuleMaxVoltage = "5"
		Me.PsU_Module0.Name = "PsU_Module0"
		Me.PsU_Module0.Size = New System.Drawing.Size(364, 152)
		Me.PsU_Module0.TabIndex = 248
		Me.PsU_Module0.Visible = False
		'
		'PsU_Module1
		'
		Me.PsU_Module1.AES70_Manager_GPIB_address = 30
		Me.PsU_Module1.AES70_Manager_GPIB_bus = 7
		Me.PsU_Module1.AES70_Manager_IP_address = "44.44.44.222"
		Me.PsU_Module1.AES70_ModuleMaxCurrent = "0.3"
		Me.PsU_Module1.AES70_OutputEnabled = False
		Me.PsU_Module1.AES70_Property_ChangeRouterConnection = 0
		Me.PsU_Module1.AES70_Property_Channel = 1
		Me.PsU_Module1.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module1.DataReadCurrent = 0R
		Me.PsU_Module1.DataReadVoltage = 0R
		Me.PsU_Module1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PsU_Module1.Location = New System.Drawing.Point(382, 6)
		Me.PsU_Module1.Margin = New System.Windows.Forms.Padding(6)
		Me.PsU_Module1.ModuleMaxVoltage = "25"
		Me.PsU_Module1.Name = "PsU_Module1"
		Me.PsU_Module1.Size = New System.Drawing.Size(364, 152)
		Me.PsU_Module1.TabIndex = 241
		Me.PsU_Module1.Visible = False
		'
		'PsU_Module3
		'
		Me.PsU_Module3.AES70_Manager_GPIB_address = 30
		Me.PsU_Module3.AES70_Manager_GPIB_bus = 7
		Me.PsU_Module3.AES70_Manager_IP_address = "44.44.44.222"
		Me.PsU_Module3.AES70_ModuleMaxCurrent = "0.3"
		Me.PsU_Module3.AES70_OutputEnabled = False
		Me.PsU_Module3.AES70_Property_ChangeRouterConnection = 0
		Me.PsU_Module3.AES70_Property_Channel = 3
		Me.PsU_Module3.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module3.DataReadCurrent = 0R
		Me.PsU_Module3.DataReadVoltage = 0R
		Me.PsU_Module3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PsU_Module3.Location = New System.Drawing.Point(382, 170)
		Me.PsU_Module3.Margin = New System.Windows.Forms.Padding(6)
		Me.PsU_Module3.ModuleMaxVoltage = "25"
		Me.PsU_Module3.Name = "PsU_Module3"
		Me.PsU_Module3.Size = New System.Drawing.Size(364, 152)
		Me.PsU_Module3.TabIndex = 243
		Me.PsU_Module3.Visible = False
		'
		'PsU_Module7
		'
		Me.PsU_Module7.AES70_Manager_GPIB_address = 30
		Me.PsU_Module7.AES70_Manager_GPIB_bus = 7
		Me.PsU_Module7.AES70_Manager_IP_address = "44.44.44.222"
		Me.PsU_Module7.AES70_ModuleMaxCurrent = "0.3"
		Me.PsU_Module7.AES70_OutputEnabled = False
		Me.PsU_Module7.AES70_Property_ChangeRouterConnection = 0
		Me.PsU_Module7.AES70_Property_Channel = 7
		Me.PsU_Module7.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module7.DataReadCurrent = 0R
		Me.PsU_Module7.DataReadVoltage = 0R
		Me.PsU_Module7.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PsU_Module7.Location = New System.Drawing.Point(382, 498)
		Me.PsU_Module7.Margin = New System.Windows.Forms.Padding(6)
		Me.PsU_Module7.ModuleMaxVoltage = "48"
		Me.PsU_Module7.Name = "PsU_Module7"
		Me.PsU_Module7.Size = New System.Drawing.Size(364, 155)
		Me.PsU_Module7.TabIndex = 286
		Me.PsU_Module7.Visible = False
		'
		'PsU_Module4
		'
		Me.PsU_Module4.AES70_Manager_GPIB_address = 30
		Me.PsU_Module4.AES70_Manager_GPIB_bus = 7
		Me.PsU_Module4.AES70_Manager_IP_address = "44.44.44.222"
		Me.PsU_Module4.AES70_ModuleMaxCurrent = "1.5"
		Me.PsU_Module4.AES70_OutputEnabled = False
		Me.PsU_Module4.AES70_Property_ChangeRouterConnection = 0
		Me.PsU_Module4.AES70_Property_Channel = 4
		Me.PsU_Module4.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module4.DataReadCurrent = 0R
		Me.PsU_Module4.DataReadVoltage = 0R
		Me.PsU_Module4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PsU_Module4.Location = New System.Drawing.Point(6, 334)
		Me.PsU_Module4.Margin = New System.Windows.Forms.Padding(6)
		Me.PsU_Module4.ModuleMaxVoltage = "12"
		Me.PsU_Module4.Name = "PsU_Module4"
		Me.PsU_Module4.Size = New System.Drawing.Size(364, 152)
		Me.PsU_Module4.TabIndex = 244
		Me.PsU_Module4.Visible = False
		'
		'PsU_Module5
		'
		Me.PsU_Module5.AES70_Manager_GPIB_address = 30
		Me.PsU_Module5.AES70_Manager_GPIB_bus = 7
		Me.PsU_Module5.AES70_Manager_IP_address = "44.44.44.222"
		Me.PsU_Module5.AES70_ModuleMaxCurrent = "0.3"
		Me.PsU_Module5.AES70_OutputEnabled = False
		Me.PsU_Module5.AES70_Property_ChangeRouterConnection = 0
		Me.PsU_Module5.AES70_Property_Channel = 5
		Me.PsU_Module5.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module5.DataReadCurrent = 0R
		Me.PsU_Module5.DataReadVoltage = 0R
		Me.PsU_Module5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PsU_Module5.Location = New System.Drawing.Point(382, 334)
		Me.PsU_Module5.Margin = New System.Windows.Forms.Padding(6)
		Me.PsU_Module5.ModuleMaxVoltage = "25"
		Me.PsU_Module5.Name = "PsU_Module5"
		Me.PsU_Module5.Size = New System.Drawing.Size(364, 152)
		Me.PsU_Module5.TabIndex = 247
		Me.PsU_Module5.Visible = False
		'
		'PsU_Module6
		'
		Me.PsU_Module6.AES70_Manager_GPIB_address = 30
		Me.PsU_Module6.AES70_Manager_GPIB_bus = 7
		Me.PsU_Module6.AES70_Manager_IP_address = "44.44.44.222"
		Me.PsU_Module6.AES70_ModuleMaxCurrent = "0.3"
		Me.PsU_Module6.AES70_OutputEnabled = False
		Me.PsU_Module6.AES70_Property_ChangeRouterConnection = 0
		Me.PsU_Module6.AES70_Property_Channel = 6
		Me.PsU_Module6.BackColor = System.Drawing.SystemColors.Control
		Me.PsU_Module6.DataReadCurrent = 0R
		Me.PsU_Module6.DataReadVoltage = 0R
		Me.PsU_Module6.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PsU_Module6.Location = New System.Drawing.Point(6, 498)
		Me.PsU_Module6.Margin = New System.Windows.Forms.Padding(6)
		Me.PsU_Module6.ModuleMaxVoltage = "25"
		Me.PsU_Module6.Name = "PsU_Module6"
		Me.PsU_Module6.Size = New System.Drawing.Size(364, 155)
		Me.PsU_Module6.TabIndex = 246
		Me.PsU_Module6.Visible = False
		'
		'TableLayoutPanel_DMM
		'
		Me.TableLayoutPanel_DMM.ColumnCount = 2
		Me.TableLayoutPanel_DMM.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel_DMM.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel_DMM.Controls.Add(Me.DmmControl1, 0, 0)
		Me.TableLayoutPanel_DMM.Controls.Add(Me.DmmControl8, 1, 3)
		Me.TableLayoutPanel_DMM.Controls.Add(Me.DmmControl4, 1, 1)
		Me.TableLayoutPanel_DMM.Controls.Add(Me.DmmControl7, 0, 3)
		Me.TableLayoutPanel_DMM.Controls.Add(Me.DmmControl5, 0, 2)
		Me.TableLayoutPanel_DMM.Controls.Add(Me.DmmControl6, 1, 2)
		Me.TableLayoutPanel_DMM.Controls.Add(Me.DmmControl3, 0, 1)
		Me.TableLayoutPanel_DMM.Controls.Add(Me.DmmControl2, 1, 0)
		Me.TableLayoutPanel_DMM.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel_DMM.Location = New System.Drawing.Point(761, 3)
		Me.TableLayoutPanel_DMM.Name = "TableLayoutPanel_DMM"
		Me.TableLayoutPanel_DMM.RowCount = 4
		Me.TableLayoutPanel_DMM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel_DMM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel_DMM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel_DMM.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel_DMM.Size = New System.Drawing.Size(752, 659)
		Me.TableLayoutPanel_DMM.TabIndex = 293
		'
		'DmmControl1
		'
		Me.DmmControl1.AES70_Manager_GPIB_address = 3
		Me.DmmControl1.AES70_Manager_GPIB_bus = 7
		Me.DmmControl1.AES70_Manager_IP_address = "44.44.44.111"
		Me.DmmControl1.AES70_Property_ChangeRouterConnection = 0
		Me.DmmControl1.AES70_Property_Channel = 1
		Me.DmmControl1.AllowDrop = True
		Me.DmmControl1.BackColor = System.Drawing.Color.Brown
		Me.DmmControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DmmControl1.Location = New System.Drawing.Point(6, 6)
		Me.DmmControl1.Margin = New System.Windows.Forms.Padding(6)
		Me.DmmControl1.Meter_to_Address = 1.0R
		Me.DmmControl1.Name = "DmmControl1"
		Me.DmmControl1.Size = New System.Drawing.Size(364, 152)
		Me.DmmControl1.TabIndex = 256
		Me.DmmControl1.Visible = False
		'
		'DmmControl8
		'
		Me.DmmControl8.AES70_Manager_GPIB_address = 5
		Me.DmmControl8.AES70_Manager_GPIB_bus = 7
		Me.DmmControl8.AES70_Manager_IP_address = "44.44.44.111"
		Me.DmmControl8.AES70_Property_ChangeRouterConnection = 0
		Me.DmmControl8.AES70_Property_Channel = 4
		Me.DmmControl8.BackColor = System.Drawing.Color.Gray
		Me.DmmControl8.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DmmControl8.Location = New System.Drawing.Point(382, 498)
		Me.DmmControl8.Margin = New System.Windows.Forms.Padding(6)
		Me.DmmControl8.Meter_to_Address = 8.0R
		Me.DmmControl8.Name = "DmmControl8"
		Me.DmmControl8.Size = New System.Drawing.Size(364, 155)
		Me.DmmControl8.TabIndex = 288
		Me.DmmControl8.Visible = False
		'
		'DmmControl4
		'
		Me.DmmControl4.AES70_Manager_GPIB_address = 12
		Me.DmmControl4.AES70_Manager_GPIB_bus = 7
		Me.DmmControl4.AES70_Manager_IP_address = "44.44.44.222"
		Me.DmmControl4.AES70_Property_ChangeRouterConnection = 0
		Me.DmmControl4.AES70_Property_Channel = 2
		Me.DmmControl4.BackColor = System.Drawing.Color.Red
		Me.DmmControl4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DmmControl4.Location = New System.Drawing.Point(382, 170)
		Me.DmmControl4.Margin = New System.Windows.Forms.Padding(6)
		Me.DmmControl4.Meter_to_Address = 2.0R
		Me.DmmControl4.Name = "DmmControl4"
		Me.DmmControl4.Size = New System.Drawing.Size(364, 152)
		Me.DmmControl4.TabIndex = 259
		Me.DmmControl4.Visible = False
		'
		'DmmControl7
		'
		Me.DmmControl7.AES70_Manager_GPIB_address = 155
		Me.DmmControl7.AES70_Manager_GPIB_bus = 7
		Me.DmmControl7.AES70_Manager_IP_address = "44.44.44.111"
		Me.DmmControl7.AES70_Property_ChangeRouterConnection = 0
		Me.DmmControl7.AES70_Property_Channel = 4
		Me.DmmControl7.BackColor = System.Drawing.Color.Violet
		Me.DmmControl7.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DmmControl7.Location = New System.Drawing.Point(6, 498)
		Me.DmmControl7.Margin = New System.Windows.Forms.Padding(6)
		Me.DmmControl7.Meter_to_Address = 7.0R
		Me.DmmControl7.Name = "DmmControl7"
		Me.DmmControl7.Size = New System.Drawing.Size(364, 155)
		Me.DmmControl7.TabIndex = 287
		Me.DmmControl7.Visible = False
		'
		'DmmControl5
		'
		Me.DmmControl5.AES70_Manager_GPIB_address = 1
		Me.DmmControl5.AES70_Manager_GPIB_bus = 7
		Me.DmmControl5.AES70_Manager_IP_address = "44.44.44.111"
		Me.DmmControl5.AES70_Property_ChangeRouterConnection = 0
		Me.DmmControl5.AES70_Property_Channel = 3
		Me.DmmControl5.BackColor = System.Drawing.Color.Orange
		Me.DmmControl5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DmmControl5.Location = New System.Drawing.Point(6, 334)
		Me.DmmControl5.Margin = New System.Windows.Forms.Padding(6)
		Me.DmmControl5.Meter_to_Address = 3.0R
		Me.DmmControl5.Name = "DmmControl5"
		Me.DmmControl5.Size = New System.Drawing.Size(364, 152)
		Me.DmmControl5.TabIndex = 260
		Me.DmmControl5.Visible = False
		'
		'DmmControl6
		'
		Me.DmmControl6.AES70_Manager_GPIB_address = 11
		Me.DmmControl6.AES70_Manager_GPIB_bus = 7
		Me.DmmControl6.AES70_Manager_IP_address = "44.44.44.222"
		Me.DmmControl6.AES70_Property_ChangeRouterConnection = 0
		Me.DmmControl6.AES70_Property_Channel = 3
		Me.DmmControl6.BackColor = System.Drawing.Color.Orange
		Me.DmmControl6.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DmmControl6.Location = New System.Drawing.Point(382, 334)
		Me.DmmControl6.Margin = New System.Windows.Forms.Padding(6)
		Me.DmmControl6.Meter_to_Address = 3.0R
		Me.DmmControl6.Name = "DmmControl6"
		Me.DmmControl6.Size = New System.Drawing.Size(364, 152)
		Me.DmmControl6.TabIndex = 261
		Me.DmmControl6.Visible = False
		'
		'DmmControl3
		'
		Me.DmmControl3.AES70_Manager_GPIB_address = 2
		Me.DmmControl3.AES70_Manager_GPIB_bus = 7
		Me.DmmControl3.AES70_Manager_IP_address = "44.44.44.111"
		Me.DmmControl3.AES70_Property_ChangeRouterConnection = 0
		Me.DmmControl3.AES70_Property_Channel = 2
		Me.DmmControl3.BackColor = System.Drawing.Color.Red
		Me.DmmControl3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DmmControl3.Location = New System.Drawing.Point(6, 170)
		Me.DmmControl3.Margin = New System.Windows.Forms.Padding(6)
		Me.DmmControl3.Meter_to_Address = 2.0R
		Me.DmmControl3.Name = "DmmControl3"
		Me.DmmControl3.Size = New System.Drawing.Size(364, 152)
		Me.DmmControl3.TabIndex = 258
		Me.DmmControl3.Visible = False
		'
		'DmmControl2
		'
		Me.DmmControl2.AES70_Manager_GPIB_address = 13
		Me.DmmControl2.AES70_Manager_GPIB_bus = 7
		Me.DmmControl2.AES70_Manager_IP_address = "44.44.44.222"
		Me.DmmControl2.AES70_Property_ChangeRouterConnection = 0
		Me.DmmControl2.AES70_Property_Channel = 1
		Me.DmmControl2.BackColor = System.Drawing.Color.Brown
		Me.DmmControl2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DmmControl2.Location = New System.Drawing.Point(382, 6)
		Me.DmmControl2.Margin = New System.Windows.Forms.Padding(6)
		Me.DmmControl2.Meter_to_Address = 1.0R
		Me.DmmControl2.Name = "DmmControl2"
		Me.DmmControl2.Size = New System.Drawing.Size(364, 152)
		Me.DmmControl2.TabIndex = 257
		Me.DmmControl2.Visible = False
		'
		'TableLayoutPanel_Scopes
		'
		Me.TableLayoutPanel_Scopes.ColumnCount = 2
		Me.TableLayoutPanel_Scopes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel_Scopes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel_Scopes.Controls.Add(Me.Scope_Channel_Display_3, 0, 1)
		Me.TableLayoutPanel_Scopes.Controls.Add(Me.Scope_Channel_Display_4, 1, 1)
		Me.TableLayoutPanel_Scopes.Controls.Add(Me.Scope_Channel_Display_2, 1, 0)
		Me.TableLayoutPanel_Scopes.Controls.Add(Me.Scope_Channel_Display_1, 0, 0)
		Me.TableLayoutPanel_Scopes.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel_Scopes.Location = New System.Drawing.Point(1516, 0)
		Me.TableLayoutPanel_Scopes.Margin = New System.Windows.Forms.Padding(0)
		Me.TableLayoutPanel_Scopes.Name = "TableLayoutPanel_Scopes"
		Me.TableLayoutPanel_Scopes.RowCount = 3
		Me.TableLayoutPanel_Scopes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel_Scopes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel_Scopes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel_Scopes.Size = New System.Drawing.Size(1517, 665)
		Me.TableLayoutPanel_Scopes.TabIndex = 299
		'
		'Scope_Channel_Display_3
		'
		Me.Scope_Channel_Display_3.AES70_Manager_GPIB_address = 6
		Me.Scope_Channel_Display_3.AES70_Manager_GPIB_bus = 7
		Me.Scope_Channel_Display_3.AES70_Manager_IP_address = "44.44.44.111"
		Me.Scope_Channel_Display_3.AES70_Property_ChangeRouterConnection = 20
		Me.Scope_Channel_Display_3.AES70_Property_Channel = 3
		Me.Scope_Channel_Display_3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Scope_Channel_Display_3.Location = New System.Drawing.Point(6, 328)
		Me.Scope_Channel_Display_3.Margin = New System.Windows.Forms.Padding(6)
		Me.Scope_Channel_Display_3.Name = "Scope_Channel_Display_3"
		Me.Scope_Channel_Display_3.Size = New System.Drawing.Size(746, 310)
		Me.Scope_Channel_Display_3.TabIndex = 2
		Me.Scope_Channel_Display_3.Visible = False
		'
		'Scope_Channel_Display_4
		'
		Me.Scope_Channel_Display_4.AES70_Manager_GPIB_address = 16
		Me.Scope_Channel_Display_4.AES70_Manager_GPIB_bus = 7
		Me.Scope_Channel_Display_4.AES70_Manager_IP_address = "44.44.44.222"
		Me.Scope_Channel_Display_4.AES70_Property_ChangeRouterConnection = 120
		Me.Scope_Channel_Display_4.AES70_Property_Channel = 4
		Me.Scope_Channel_Display_4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Scope_Channel_Display_4.Location = New System.Drawing.Point(764, 328)
		Me.Scope_Channel_Display_4.Margin = New System.Windows.Forms.Padding(6)
		Me.Scope_Channel_Display_4.Name = "Scope_Channel_Display_4"
		Me.Scope_Channel_Display_4.Size = New System.Drawing.Size(747, 310)
		Me.Scope_Channel_Display_4.TabIndex = 3
		Me.Scope_Channel_Display_4.Visible = False
		'
		'Scope_Channel_Display_2
		'
		Me.Scope_Channel_Display_2.AES70_Manager_GPIB_address = 16
		Me.Scope_Channel_Display_2.AES70_Manager_GPIB_bus = 7
		Me.Scope_Channel_Display_2.AES70_Manager_IP_address = "44.44.44.222"
		Me.Scope_Channel_Display_2.AES70_Property_ChangeRouterConnection = 110
		Me.Scope_Channel_Display_2.AES70_Property_Channel = 1
		Me.Scope_Channel_Display_2.AutoSize = True
		Me.Scope_Channel_Display_2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Scope_Channel_Display_2.Location = New System.Drawing.Point(764, 6)
		Me.Scope_Channel_Display_2.Margin = New System.Windows.Forms.Padding(6)
		Me.Scope_Channel_Display_2.Name = "Scope_Channel_Display_2"
		Me.Scope_Channel_Display_2.Size = New System.Drawing.Size(747, 310)
		Me.Scope_Channel_Display_2.TabIndex = 1
		Me.Scope_Channel_Display_2.Visible = False
		'
		'Scope_Channel_Display_1
		'
		Me.Scope_Channel_Display_1.AES70_Manager_GPIB_address = 6
		Me.Scope_Channel_Display_1.AES70_Manager_GPIB_bus = 7
		Me.Scope_Channel_Display_1.AES70_Manager_IP_address = "44.44.44.111"
		Me.Scope_Channel_Display_1.AES70_Property_ChangeRouterConnection = 10
		Me.Scope_Channel_Display_1.AES70_Property_Channel = 1
		Me.Scope_Channel_Display_1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Scope_Channel_Display_1.Location = New System.Drawing.Point(6, 6)
		Me.Scope_Channel_Display_1.Margin = New System.Windows.Forms.Padding(6)
		Me.Scope_Channel_Display_1.Name = "Scope_Channel_Display_1"
		Me.Scope_Channel_Display_1.Size = New System.Drawing.Size(746, 310)
		Me.Scope_Channel_Display_1.TabIndex = 0
		Me.Scope_Channel_Display_1.Visible = False
		'
		'TableLayoutPanelAllTables
		'
		Me.TableLayoutPanelAllTables.ColumnCount = 3
		Me.TableLayoutPanelAllTables.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanelAllTables.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanelAllTables.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanelAllTables.Controls.Add(Me.TableLayoutPanel_DMM, 1, 0)
		Me.TableLayoutPanelAllTables.Controls.Add(Me.TableLayoutPanel_PSU, 0, 0)
		Me.TableLayoutPanelAllTables.Controls.Add(Me.TableLayoutPanel_Scopes, 2, 0)
		Me.TableLayoutPanelAllTables.Location = New System.Drawing.Point(9, 9)
		Me.TableLayoutPanelAllTables.Margin = New System.Windows.Forms.Padding(0)
		Me.TableLayoutPanelAllTables.Name = "TableLayoutPanelAllTables"
		Me.TableLayoutPanelAllTables.RowCount = 1
		Me.TableLayoutPanelAllTables.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanelAllTables.Size = New System.Drawing.Size(3033, 665)
		Me.TableLayoutPanelAllTables.TabIndex = 303
		'
		'TableLayoutPanel5
		'
		Me.TableLayoutPanel5.ColumnCount = 2
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel5.Controls.Add(Me.Button_ISO_A_IN, 0, 0)
		Me.TableLayoutPanel5.Controls.Add(Me.Button_ISO_B_IN, 1, 0)
		Me.TableLayoutPanel5.Controls.Add(Me.Button_DISTORTION, 0, 1)
		Me.TableLayoutPanel5.Controls.Add(Me.Button_SPECTRUM, 1, 1)
		Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel5.Location = New System.Drawing.Point(144, 3)
		Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
		Me.TableLayoutPanel5.RowCount = 2
		Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel5.Size = New System.Drawing.Size(136, 101)
		Me.TableLayoutPanel5.TabIndex = 296
		'
		'Button_ISO_A_IN
		'
		Me.Button_ISO_A_IN.BackColor = System.Drawing.Color.Transparent
		Me.Button_ISO_A_IN.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Button_ISO_A_IN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_ISO_A_IN.Location = New System.Drawing.Point(3, 3)
		Me.Button_ISO_A_IN.Name = "Button_ISO_A_IN"
		Me.Button_ISO_A_IN.Size = New System.Drawing.Size(62, 44)
		Me.Button_ISO_A_IN.TabIndex = 278
		Me.Button_ISO_A_IN.Text = "11005A IN"
		Me.Button_ISO_A_IN.UseVisualStyleBackColor = False
		'
		'Button_ISO_B_IN
		'
		Me.Button_ISO_B_IN.BackColor = System.Drawing.Color.Transparent
		Me.Button_ISO_B_IN.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Button_ISO_B_IN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_ISO_B_IN.Location = New System.Drawing.Point(71, 3)
		Me.Button_ISO_B_IN.Name = "Button_ISO_B_IN"
		Me.Button_ISO_B_IN.Size = New System.Drawing.Size(62, 44)
		Me.Button_ISO_B_IN.TabIndex = 279
		Me.Button_ISO_B_IN.Text = "400FL IN"
		Me.Button_ISO_B_IN.UseVisualStyleBackColor = False
		'
		'Button_DISTORTION
		'
		Me.Button_DISTORTION.BackColor = System.Drawing.Color.Transparent
		Me.Button_DISTORTION.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Button_DISTORTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_DISTORTION.Location = New System.Drawing.Point(3, 53)
		Me.Button_DISTORTION.Name = "Button_DISTORTION"
		Me.Button_DISTORTION.Size = New System.Drawing.Size(62, 45)
		Me.Button_DISTORTION.TabIndex = 283
		Me.Button_DISTORTION.Text = "NC"
		Me.Button_DISTORTION.UseVisualStyleBackColor = False
		'
		'Button_SPECTRUM
		'
		Me.Button_SPECTRUM.BackColor = System.Drawing.Color.Transparent
		Me.Button_SPECTRUM.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Button_SPECTRUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_SPECTRUM.Location = New System.Drawing.Point(71, 53)
		Me.Button_SPECTRUM.Name = "Button_SPECTRUM"
		Me.Button_SPECTRUM.Size = New System.Drawing.Size(62, 45)
		Me.Button_SPECTRUM.TabIndex = 284
		Me.Button_SPECTRUM.UseVisualStyleBackColor = False
		'
		'TableLayoutPanel_SigGen
		'
		Me.TableLayoutPanel_SigGen.ColumnCount = 2
		Me.TableLayoutPanel_SigGen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel_SigGen.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel_SigGen.Controls.Add(Me.Button_SIGNAL_GEN, 0, 0)
		Me.TableLayoutPanel_SigGen.Controls.Add(Me.Button_Bridging_Input, 1, 0)
		Me.TableLayoutPanel_SigGen.Controls.Add(Me.Button_GEN_2, 0, 1)
		Me.TableLayoutPanel_SigGen.Controls.Add(Me.Button_PATCH_PANEL_OUT, 1, 1)
		Me.TableLayoutPanel_SigGen.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel_SigGen.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel_SigGen.Name = "TableLayoutPanel_SigGen"
		Me.TableLayoutPanel_SigGen.RowCount = 2
		Me.TableLayoutPanel_SigGen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel_SigGen.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel_SigGen.Size = New System.Drawing.Size(135, 101)
		Me.TableLayoutPanel_SigGen.TabIndex = 295
		'
		'Button_SIGNAL_GEN
		'
		Me.Button_SIGNAL_GEN.BackColor = System.Drawing.Color.Transparent
		Me.Button_SIGNAL_GEN.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Button_SIGNAL_GEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_SIGNAL_GEN.Location = New System.Drawing.Point(3, 3)
		Me.Button_SIGNAL_GEN.Name = "Button_SIGNAL_GEN"
		Me.Button_SIGNAL_GEN.Size = New System.Drawing.Size(61, 44)
		Me.Button_SIGNAL_GEN.TabIndex = 276
		Me.Button_SIGNAL_GEN.Tag = ""
		Me.Button_SIGNAL_GEN.Text = "SIG GEN"
		Me.Button_SIGNAL_GEN.UseVisualStyleBackColor = False
		'
		'Button_Bridging_Input
		'
		Me.Button_Bridging_Input.BackColor = System.Drawing.Color.Transparent
		Me.Button_Bridging_Input.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Button_Bridging_Input.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_Bridging_Input.Location = New System.Drawing.Point(70, 3)
		Me.Button_Bridging_Input.Name = "Button_Bridging_Input"
		Me.Button_Bridging_Input.Size = New System.Drawing.Size(62, 44)
		Me.Button_Bridging_Input.TabIndex = 277
		Me.Button_Bridging_Input.Text = "353A IN"
		Me.Button_Bridging_Input.UseVisualStyleBackColor = False
		'
		'Button_GEN_2
		'
		Me.Button_GEN_2.BackColor = System.Drawing.Color.Transparent
		Me.Button_GEN_2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Button_GEN_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_GEN_2.Location = New System.Drawing.Point(3, 53)
		Me.Button_GEN_2.Name = "Button_GEN_2"
		Me.Button_GEN_2.Size = New System.Drawing.Size(61, 45)
		Me.Button_GEN_2.TabIndex = 280
		Me.Button_GEN_2.Text = "33220A GEN"
		Me.Button_GEN_2.UseVisualStyleBackColor = False
		'
		'Button_PATCH_PANEL_OUT
		'
		Me.Button_PATCH_PANEL_OUT.BackColor = System.Drawing.Color.Transparent
		Me.Button_PATCH_PANEL_OUT.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Button_PATCH_PANEL_OUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button_PATCH_PANEL_OUT.Location = New System.Drawing.Point(70, 53)
		Me.Button_PATCH_PANEL_OUT.Name = "Button_PATCH_PANEL_OUT"
		Me.Button_PATCH_PANEL_OUT.Size = New System.Drawing.Size(62, 45)
		Me.Button_PATCH_PANEL_OUT.TabIndex = 282
		Me.Button_PATCH_PANEL_OUT.Text = "353A OUT"
		Me.Button_PATCH_PANEL_OUT.UseVisualStyleBackColor = False
		'
		'TableLayoutPanel_MatrixCoax_000
		'
		Me.TableLayoutPanel_MatrixCoax_000.ColumnCount = 2
		Me.TableLayoutPanel_MatrixCoax_000.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel_MatrixCoax_000.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel_MatrixCoax_000.Controls.Add(Me.TableLayoutPanel_SigGen, 0, 0)
		Me.TableLayoutPanel_MatrixCoax_000.Controls.Add(Me.TableLayoutPanel5, 1, 0)
		Me.TableLayoutPanel_MatrixCoax_000.Location = New System.Drawing.Point(3106, 12)
		Me.TableLayoutPanel_MatrixCoax_000.Name = "TableLayoutPanel_MatrixCoax_000"
		Me.TableLayoutPanel_MatrixCoax_000.RowCount = 1
		Me.TableLayoutPanel_MatrixCoax_000.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel_MatrixCoax_000.Size = New System.Drawing.Size(283, 107)
		Me.TableLayoutPanel_MatrixCoax_000.TabIndex = 301
		'
		'Scope_Channel_Display1
		'
		Me.Scope_Channel_Display1.AES70_Manager_GPIB_address = 11
		Me.Scope_Channel_Display1.AES70_Manager_GPIB_bus = 0
		Me.Scope_Channel_Display1.AES70_Manager_IP_address = Nothing
		Me.Scope_Channel_Display1.AES70_Property_ChangeRouterConnection = 10
		Me.Scope_Channel_Display1.AES70_Property_Channel = 0
		Me.Scope_Channel_Display1.Location = New System.Drawing.Point(1733, -1104)
		Me.Scope_Channel_Display1.Margin = New System.Windows.Forms.Padding(6)
		Me.Scope_Channel_Display1.Name = "Scope_Channel_Display1"
		Me.Scope_Channel_Display1.Size = New System.Drawing.Size(936, 445)
		Me.Scope_Channel_Display1.TabIndex = 290
		'
		'UserInterfaceShell
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.DarkGray
		Me.ClientSize = New System.Drawing.Size(5124, 1468)
		Me.Controls.Add(Me.TableLayoutPanel_MatrixCoax_000)
		Me.Controls.Add(Me.TableLayoutPanelAllTables)
		Me.Controls.Add(Me.Button6)
		Me.Controls.Add(Me.Scope_Channel_Display1)
		Me.Controls.Add(Me.TabControl4)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.userIntMainMenuStrip)
		Me.IsMdiContainer = True
		Me.Name = "UserInterfaceShell"
		Me.Opacity = 0.8R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "APK Test Bench"
		Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.userIntMainMenuStrip.ResumeLayout(False)
		Me.userIntMainMenuStrip.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.TabControl4.ResumeLayout(False)
		Me.TabPage8.ResumeLayout(False)
		Me.TabPage8.PerformLayout()
		Me.TabPage9.ResumeLayout(False)
		Me.TabPage9.PerformLayout()
		CType(Me.PictureBox_Distortion, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel_PSU.ResumeLayout(False)
		Me.TableLayoutPanel_DMM.ResumeLayout(False)
		Me.TableLayoutPanel_Scopes.ResumeLayout(False)
		Me.TableLayoutPanel_Scopes.PerformLayout()
		Me.TableLayoutPanelAllTables.ResumeLayout(False)
		Me.TableLayoutPanel5.ResumeLayout(False)
		Me.TableLayoutPanel_SigGen.ResumeLayout(False)
		Me.TableLayoutPanel_MatrixCoax_000.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents userIntMainMenuStrip As MenuStrip
	Friend WithEvents DeviceToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DevicesToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InstrumentToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CommandBoxToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SaveConfigToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents LoadConfigToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents RelaysToolStripMenuItem As ToolStripMenuItem
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
	Friend WithEvents AgilentFFTToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents AudioAnalyzerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ImpedanceToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents InputImpedanceToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OutputImpedanceToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RefferenceToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Reff_Imp As ToolStripTextBox
	Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
	Friend WithEvents SpeachOnToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
	Friend WithEvents RIGOL_FFT_TOOLTIP As ToolTip
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents ReadValues As Timer
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents YoControlStatus As ToolStripStatusLabel
	Friend WithEvents YoTimeOut As ToolStripProgressBar
	Public WithEvents YoTimer As Timer

	Friend WithEvents PictureBox_Distortion As PictureBox
	Friend WithEvents PsU_Module0 As PSU_Module
	Friend WithEvents PsU_Module5 As PSU_Module
	Friend WithEvents PsU_Module6 As PSU_Module
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
	Friend WithEvents DmmControl6 As DMMControl
	Friend WithEvents DmmControl5 As DMMControl
	Friend WithEvents DmmControl4 As DMMControl
	Friend WithEvents DmmControl3 As DMMControl
	Friend WithEvents DmmControl2 As DMMControl
	Friend WithEvents FrequencyChartToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PsU_Module7 As PSU_Module
	Friend WithEvents DmmControl8 As DMMControl
	Friend WithEvents DmmControl7 As DMMControl
	Friend WithEvents GlobalFreq As ToolStripTextBox
	Friend WithEvents Scope_Channel_Display1 As Scope_Channel_Display
	Friend WithEvents Scope_Channel_Display_1 As Scope_Channel_Display
	Friend WithEvents Scope_Channel_Display_4 As Scope_Channel_Display
	Friend WithEvents TableLayoutPanel_PSU As TableLayoutPanel
	Friend WithEvents TableLayoutPanel_DMM As TableLayoutPanel
	Public WithEvents DmmControl1 As DMMControl
	Friend WithEvents SpectrumAnalyzerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AgilentESALSpectrumAnalyzerToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GPIBAddressToolStripMenuItem6 As ToolStripMenuItem
	Friend WithEvents SpectrumAnalyzer_GPIB_address As ToolStripTextBox
	Friend WithEvents DCLOADToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ProgramableLoadToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents GPIBAddressToolStripMenuItem8 As ToolStripMenuItem
	Friend WithEvents DCloadGPIBaddress As ToolStripComboBox
	Friend WithEvents TableLayoutPanel_Scopes As TableLayoutPanel
	Friend WithEvents TableLayoutPanelAllTables As TableLayoutPanel
	Friend WithEvents TableLayoutPanel_MatrixCoax_000 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel_SigGen As TableLayoutPanel
	Friend WithEvents Button_SIGNAL_GEN As Button
	Friend WithEvents Button_Bridging_Input As Button
	Friend WithEvents Button_GEN_2 As Button
	Friend WithEvents Button_PATCH_PANEL_OUT As Button
	Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
	Friend WithEvents Button_ISO_A_IN As Button
	Friend WithEvents Button_ISO_B_IN As Button
	Friend WithEvents Button_DISTORTION As Button
	Friend WithEvents Button_SPECTRUM As Button
	Friend WithEvents Scope_Channel_Display_3 As Scope_Channel_Display
	Friend WithEvents Scope_Channel_Display_2 As Scope_Channel_Display
End Class
