<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SequenceTimer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.TestSequenceTimer = New System.Windows.Forms.Timer(Me.components)
		Me.Button_TimmerRun = New System.Windows.Forms.Button()
		Me.CheckBox_SignalGenSweep = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.SweepStart = New System.Windows.Forms.TextBox()
		Me.SweepEnable = New System.Windows.Forms.Button()
		Me.SweepStop = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.CheckBox_log = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
		Me.CheckBox_ScopeCH2 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_ScopeCH3 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_ScopeCH4 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_ScopeCH6 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_ScopeCH5 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_ScopeCH1 = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
		Me.CheckBox_DCLoad = New System.Windows.Forms.CheckBox()
		Me.CheckBox2 = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.CheckBox_DMM1 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_DMM2 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_DMM3 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_DMM4 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_DMM5 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_DMM8 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_DMM6 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_DMM7 = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_SA = New System.Windows.Forms.CheckBox()
		Me.CheckBox_THD = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.CheckBox_PSU_frame_2 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_PSU_frame_1 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_PSU_frame_3 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_PSU_frame_4 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_PSU_frame_5 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_PSU_frame_6 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_PSU_frame_7 = New System.Windows.Forms.CheckBox()
		Me.CheckBox_PSU_frame_8 = New System.Windows.Forms.CheckBox()
		Me.ChK_Graph_Measurements = New System.Windows.Forms.CheckBox()
		Me.ListBox_Saved_Preset = New System.Windows.Forms.ListBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.ListBox_Measured_Devices = New System.Windows.Forms.ListBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
		Me.TextDisplayCounter = New System.Windows.Forms.Label()
		Me.CounterReset = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextDisplayCounterLoops = New System.Windows.Forms.Label()
		Me.Textbox_NumberOfTestCycles = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Trackbar_Interval = New System.Windows.Forms.TrackBar()
		Me.TextBox_Interval = New System.Windows.Forms.TextBox()
		Me.Trackbar_NumberOfTestCycles = New System.Windows.Forms.TrackBar()
		Me.CheckBox_Loop = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel11 = New System.Windows.Forms.TableLayoutPanel()
		Me.BenchInstrumentItemBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.BenchInstrumentItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.CheckBox_Autoscale = New System.Windows.Forms.CheckBox()
		Me.TableLayoutPanel6.SuspendLayout()
		Me.TableLayoutPanel5.SuspendLayout()
		Me.TableLayoutPanel4.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TableLayoutPanel7.SuspendLayout()
		Me.TableLayoutPanel8.SuspendLayout()
		Me.TableLayoutPanel10.SuspendLayout()
		CType(Me.Trackbar_Interval, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Trackbar_NumberOfTestCycles, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel11.SuspendLayout()
		CType(Me.BenchInstrumentItemBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BenchInstrumentItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TestSequenceTimer
		'
		'
		'Button_TimmerRun
		'
		Me.Button_TimmerRun.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Button_TimmerRun.Location = New System.Drawing.Point(3, 3)
		Me.Button_TimmerRun.Name = "Button_TimmerRun"
		Me.Button_TimmerRun.Size = New System.Drawing.Size(700, 321)
		Me.Button_TimmerRun.TabIndex = 7
		Me.Button_TimmerRun.Text = "TIMER START"
		Me.Button_TimmerRun.UseVisualStyleBackColor = True
		'
		'CheckBox_SignalGenSweep
		'
		Me.CheckBox_SignalGenSweep.AutoSize = True
		Me.CheckBox_SignalGenSweep.Location = New System.Drawing.Point(3, 3)
		Me.CheckBox_SignalGenSweep.Name = "CheckBox_SignalGenSweep"
		Me.CheckBox_SignalGenSweep.Size = New System.Drawing.Size(105, 17)
		Me.CheckBox_SignalGenSweep.TabIndex = 11
		Me.CheckBox_SignalGenSweep.Text = "Signal Generator"
		Me.CheckBox_SignalGenSweep.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel6
		'
		Me.TableLayoutPanel6.ColumnCount = 3
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.42017!))
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.57983!))
		Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
		Me.TableLayoutPanel6.Controls.Add(Me.Label5, 0, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.SweepStart, 0, 1)
		Me.TableLayoutPanel6.Controls.Add(Me.SweepEnable, 2, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.SweepStop, 1, 1)
		Me.TableLayoutPanel6.Controls.Add(Me.Label4, 1, 0)
		Me.TableLayoutPanel6.Controls.Add(Me.CheckBox_log, 2, 1)
		Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel6.Location = New System.Drawing.Point(236, 142)
		Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
		Me.TableLayoutPanel6.RowCount = 2
		Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel6.Size = New System.Drawing.Size(227, 134)
		Me.TableLayoutPanel6.TabIndex = 294
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(3, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(32, 13)
		Me.Label5.TabIndex = 272
		Me.Label5.Text = "Start:"
		'
		'SweepStart
		'
		Me.SweepStart.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SweepStart.Location = New System.Drawing.Point(3, 70)
		Me.SweepStart.Name = "SweepStart"
		Me.SweepStart.Size = New System.Drawing.Size(35, 20)
		Me.SweepStart.TabIndex = 268
		Me.SweepStart.Text = "50"
		'
		'SweepEnable
		'
		Me.SweepEnable.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SweepEnable.Location = New System.Drawing.Point(85, 3)
		Me.SweepEnable.Name = "SweepEnable"
		Me.SweepEnable.Size = New System.Drawing.Size(139, 61)
		Me.SweepEnable.TabIndex = 271
		Me.SweepEnable.Text = "Sweep"
		Me.SweepEnable.UseVisualStyleBackColor = True
		'
		'SweepStop
		'
		Me.SweepStop.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SweepStop.Location = New System.Drawing.Point(44, 70)
		Me.SweepStop.Name = "SweepStop"
		Me.SweepStop.Size = New System.Drawing.Size(35, 20)
		Me.SweepStop.TabIndex = 269
		Me.SweepStop.Text = "25000"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(44, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(32, 13)
		Me.Label4.TabIndex = 273
		Me.Label4.Text = "Stop:"
		'
		'CheckBox_log
		'
		Me.CheckBox_log.AutoSize = True
		Me.CheckBox_log.Checked = True
		Me.CheckBox_log.CheckState = System.Windows.Forms.CheckState.Checked
		Me.CheckBox_log.Location = New System.Drawing.Point(85, 70)
		Me.CheckBox_log.Name = "CheckBox_log"
		Me.CheckBox_log.Size = New System.Drawing.Size(80, 17)
		Me.CheckBox_log.TabIndex = 274
		Me.CheckBox_log.Text = "Log Sweep"
		Me.CheckBox_log.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel5
		'
		Me.TableLayoutPanel5.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.TableLayoutPanel5.ColumnCount = 2
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel5.Controls.Add(Me.CheckBox_ScopeCH2, 1, 0)
		Me.TableLayoutPanel5.Controls.Add(Me.CheckBox_ScopeCH3, 0, 1)
		Me.TableLayoutPanel5.Controls.Add(Me.CheckBox_ScopeCH4, 1, 1)
		Me.TableLayoutPanel5.Controls.Add(Me.CheckBox_ScopeCH6, 1, 2)
		Me.TableLayoutPanel5.Controls.Add(Me.CheckBox_ScopeCH5, 0, 2)
		Me.TableLayoutPanel5.Controls.Add(Me.CheckBox_ScopeCH1, 0, 0)
		Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel5.Location = New System.Drawing.Point(469, 3)
		Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
		Me.TableLayoutPanel5.RowCount = 4
		Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel5.Size = New System.Drawing.Size(228, 133)
		Me.TableLayoutPanel5.TabIndex = 290
		'
		'CheckBox_ScopeCH2
		'
		Me.CheckBox_ScopeCH2.AutoSize = True
		Me.CheckBox_ScopeCH2.Location = New System.Drawing.Point(117, 3)
		Me.CheckBox_ScopeCH2.Name = "CheckBox_ScopeCH2"
		Me.CheckBox_ScopeCH2.Size = New System.Drawing.Size(66, 17)
		Me.CheckBox_ScopeCH2.TabIndex = 24
		Me.CheckBox_ScopeCH2.Text = "Scope 2"
		Me.CheckBox_ScopeCH2.UseVisualStyleBackColor = True
		'
		'CheckBox_ScopeCH3
		'
		Me.CheckBox_ScopeCH3.AutoSize = True
		Me.CheckBox_ScopeCH3.Location = New System.Drawing.Point(3, 36)
		Me.CheckBox_ScopeCH3.Name = "CheckBox_ScopeCH3"
		Me.CheckBox_ScopeCH3.Size = New System.Drawing.Size(66, 17)
		Me.CheckBox_ScopeCH3.TabIndex = 25
		Me.CheckBox_ScopeCH3.Text = "Scope 3"
		Me.CheckBox_ScopeCH3.UseVisualStyleBackColor = True
		'
		'CheckBox_ScopeCH4
		'
		Me.CheckBox_ScopeCH4.AutoSize = True
		Me.CheckBox_ScopeCH4.Location = New System.Drawing.Point(117, 36)
		Me.CheckBox_ScopeCH4.Name = "CheckBox_ScopeCH4"
		Me.CheckBox_ScopeCH4.Size = New System.Drawing.Size(66, 17)
		Me.CheckBox_ScopeCH4.TabIndex = 26
		Me.CheckBox_ScopeCH4.Text = "Scope 4"
		Me.CheckBox_ScopeCH4.UseVisualStyleBackColor = True
		'
		'CheckBox_ScopeCH6
		'
		Me.CheckBox_ScopeCH6.AutoSize = True
		Me.CheckBox_ScopeCH6.CheckAlign = System.Drawing.ContentAlignment.TopLeft
		Me.CheckBox_ScopeCH6.Location = New System.Drawing.Point(117, 69)
		Me.CheckBox_ScopeCH6.Name = "CheckBox_ScopeCH6"
		Me.CheckBox_ScopeCH6.Size = New System.Drawing.Size(66, 17)
		Me.CheckBox_ScopeCH6.TabIndex = 30
		Me.CheckBox_ScopeCH6.Text = "Scope 6"
		Me.CheckBox_ScopeCH6.UseVisualStyleBackColor = True
		'
		'CheckBox_ScopeCH5
		'
		Me.CheckBox_ScopeCH5.AutoSize = True
		Me.CheckBox_ScopeCH5.Location = New System.Drawing.Point(3, 69)
		Me.CheckBox_ScopeCH5.Name = "CheckBox_ScopeCH5"
		Me.CheckBox_ScopeCH5.Size = New System.Drawing.Size(66, 17)
		Me.CheckBox_ScopeCH5.TabIndex = 29
		Me.CheckBox_ScopeCH5.Text = "Scope 5"
		Me.CheckBox_ScopeCH5.UseVisualStyleBackColor = True
		'
		'CheckBox_ScopeCH1
		'
		Me.CheckBox_ScopeCH1.AutoSize = True
		Me.CheckBox_ScopeCH1.Location = New System.Drawing.Point(3, 3)
		Me.CheckBox_ScopeCH1.Name = "CheckBox_ScopeCH1"
		Me.CheckBox_ScopeCH1.Size = New System.Drawing.Size(66, 17)
		Me.CheckBox_ScopeCH1.TabIndex = 12
		Me.CheckBox_ScopeCH1.Text = "Scope 1"
		Me.CheckBox_ScopeCH1.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel4
		'
		Me.TableLayoutPanel4.ColumnCount = 2
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel4.Controls.Add(Me.CheckBox_Autoscale, 0, 1)
		Me.TableLayoutPanel4.Controls.Add(Me.CheckBox_DCLoad, 0, 0)
		Me.TableLayoutPanel4.Controls.Add(Me.CheckBox2, 1, 0)
		Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel4.Location = New System.Drawing.Point(469, 142)
		Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
		Me.TableLayoutPanel4.RowCount = 2
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel4.Size = New System.Drawing.Size(228, 134)
		Me.TableLayoutPanel4.TabIndex = 293
		'
		'CheckBox_DCLoad
		'
		Me.CheckBox_DCLoad.AutoSize = True
		Me.CheckBox_DCLoad.Location = New System.Drawing.Point(3, 3)
		Me.CheckBox_DCLoad.Name = "CheckBox_DCLoad"
		Me.CheckBox_DCLoad.Size = New System.Drawing.Size(82, 17)
		Me.CheckBox_DCLoad.TabIndex = 20
		Me.CheckBox_DCLoad.Text = "DC LOAD 1"
		Me.CheckBox_DCLoad.UseVisualStyleBackColor = True
		'
		'CheckBox2
		'
		Me.CheckBox2.AutoSize = True
		Me.CheckBox2.Location = New System.Drawing.Point(117, 3)
		Me.CheckBox2.Name = "CheckBox2"
		Me.CheckBox2.Size = New System.Drawing.Size(82, 17)
		Me.CheckBox2.TabIndex = 39
		Me.CheckBox2.Text = "DC LOAD 2"
		Me.CheckBox2.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.ColumnCount = 2
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel3.Controls.Add(Me.CheckBox_DMM1, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.CheckBox_DMM2, 1, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.CheckBox_DMM3, 0, 1)
		Me.TableLayoutPanel3.Controls.Add(Me.CheckBox_DMM4, 1, 1)
		Me.TableLayoutPanel3.Controls.Add(Me.CheckBox_DMM5, 0, 2)
		Me.TableLayoutPanel3.Controls.Add(Me.CheckBox_DMM8, 1, 3)
		Me.TableLayoutPanel3.Controls.Add(Me.CheckBox_DMM6, 1, 2)
		Me.TableLayoutPanel3.Controls.Add(Me.CheckBox_DMM7, 0, 3)
		Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(236, 3)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 4
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(227, 133)
		Me.TableLayoutPanel3.TabIndex = 292
		'
		'CheckBox_DMM1
		'
		Me.CheckBox_DMM1.AutoSize = True
		Me.CheckBox_DMM1.Location = New System.Drawing.Point(3, 3)
		Me.CheckBox_DMM1.Name = "CheckBox_DMM1"
		Me.CheckBox_DMM1.Size = New System.Drawing.Size(61, 17)
		Me.CheckBox_DMM1.TabIndex = 14
		Me.CheckBox_DMM1.Text = "DMM 1"
		Me.CheckBox_DMM1.UseVisualStyleBackColor = True
		'
		'CheckBox_DMM2
		'
		Me.CheckBox_DMM2.AutoSize = True
		Me.CheckBox_DMM2.Location = New System.Drawing.Point(116, 3)
		Me.CheckBox_DMM2.Name = "CheckBox_DMM2"
		Me.CheckBox_DMM2.Size = New System.Drawing.Size(61, 17)
		Me.CheckBox_DMM2.TabIndex = 15
		Me.CheckBox_DMM2.Text = "DMM 2"
		Me.CheckBox_DMM2.UseVisualStyleBackColor = True
		'
		'CheckBox_DMM3
		'
		Me.CheckBox_DMM3.AutoSize = True
		Me.CheckBox_DMM3.Location = New System.Drawing.Point(3, 36)
		Me.CheckBox_DMM3.Name = "CheckBox_DMM3"
		Me.CheckBox_DMM3.Size = New System.Drawing.Size(61, 17)
		Me.CheckBox_DMM3.TabIndex = 16
		Me.CheckBox_DMM3.Text = "DMM 3"
		Me.CheckBox_DMM3.UseVisualStyleBackColor = True
		'
		'CheckBox_DMM4
		'
		Me.CheckBox_DMM4.AutoSize = True
		Me.CheckBox_DMM4.Location = New System.Drawing.Point(116, 36)
		Me.CheckBox_DMM4.Name = "CheckBox_DMM4"
		Me.CheckBox_DMM4.Size = New System.Drawing.Size(61, 17)
		Me.CheckBox_DMM4.TabIndex = 17
		Me.CheckBox_DMM4.Text = "DMM 4"
		Me.CheckBox_DMM4.UseVisualStyleBackColor = True
		'
		'CheckBox_DMM5
		'
		Me.CheckBox_DMM5.AutoSize = True
		Me.CheckBox_DMM5.Location = New System.Drawing.Point(3, 69)
		Me.CheckBox_DMM5.Name = "CheckBox_DMM5"
		Me.CheckBox_DMM5.Size = New System.Drawing.Size(61, 17)
		Me.CheckBox_DMM5.TabIndex = 18
		Me.CheckBox_DMM5.Text = "DMM 5"
		Me.CheckBox_DMM5.UseVisualStyleBackColor = True
		'
		'CheckBox_DMM8
		'
		Me.CheckBox_DMM8.AutoSize = True
		Me.CheckBox_DMM8.Location = New System.Drawing.Point(116, 102)
		Me.CheckBox_DMM8.Name = "CheckBox_DMM8"
		Me.CheckBox_DMM8.Size = New System.Drawing.Size(61, 17)
		Me.CheckBox_DMM8.TabIndex = 28
		Me.CheckBox_DMM8.Text = "DMM 8"
		Me.CheckBox_DMM8.UseVisualStyleBackColor = True
		'
		'CheckBox_DMM6
		'
		Me.CheckBox_DMM6.AutoSize = True
		Me.CheckBox_DMM6.Location = New System.Drawing.Point(116, 69)
		Me.CheckBox_DMM6.Name = "CheckBox_DMM6"
		Me.CheckBox_DMM6.Size = New System.Drawing.Size(61, 17)
		Me.CheckBox_DMM6.TabIndex = 19
		Me.CheckBox_DMM6.Text = "DMM 6"
		Me.CheckBox_DMM6.UseVisualStyleBackColor = True
		'
		'CheckBox_DMM7
		'
		Me.CheckBox_DMM7.AutoSize = True
		Me.CheckBox_DMM7.Location = New System.Drawing.Point(3, 102)
		Me.CheckBox_DMM7.Name = "CheckBox_DMM7"
		Me.CheckBox_DMM7.Size = New System.Drawing.Size(61, 17)
		Me.CheckBox_DMM7.TabIndex = 27
		Me.CheckBox_DMM7.Text = "DMM 7"
		Me.CheckBox_DMM7.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.TableLayoutPanel2.ColumnCount = 1
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.Controls.Add(Me.CheckBox1, 0, 3)
		Me.TableLayoutPanel2.Controls.Add(Me.CheckBox_SA, 0, 2)
		Me.TableLayoutPanel2.Controls.Add(Me.CheckBox_THD, 0, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.CheckBox_SignalGenSweep, 0, 0)
		Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 142)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 4
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(227, 134)
		Me.TableLayoutPanel2.TabIndex = 291
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(3, 102)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
		Me.CheckBox1.TabIndex = 38
		Me.CheckBox1.Text = "CheckBox1"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'CheckBox_SA
		'
		Me.CheckBox_SA.AutoSize = True
		Me.CheckBox_SA.Location = New System.Drawing.Point(3, 69)
		Me.CheckBox_SA.Name = "CheckBox_SA"
		Me.CheckBox_SA.Size = New System.Drawing.Size(146, 17)
		Me.CheckBox_SA.TabIndex = 22
		Me.CheckBox_SA.Text = "SPECTRUM ANALYZER"
		Me.CheckBox_SA.UseVisualStyleBackColor = True
		'
		'CheckBox_THD
		'
		Me.CheckBox_THD.AutoSize = True
		Me.CheckBox_THD.Location = New System.Drawing.Point(3, 36)
		Me.CheckBox_THD.Name = "CheckBox_THD"
		Me.CheckBox_THD.Size = New System.Drawing.Size(49, 17)
		Me.CheckBox_THD.TabIndex = 21
		Me.CheckBox_THD.Text = "THD"
		Me.CheckBox_THD.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Salmon
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.CheckBox_PSU_frame_2, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.CheckBox_PSU_frame_1, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.CheckBox_PSU_frame_3, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.CheckBox_PSU_frame_4, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.CheckBox_PSU_frame_5, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.CheckBox_PSU_frame_6, 1, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.CheckBox_PSU_frame_7, 0, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.CheckBox_PSU_frame_8, 1, 3)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 4
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(227, 133)
		Me.TableLayoutPanel1.TabIndex = 290
		'
		'CheckBox_PSU_frame_2
		'
		Me.CheckBox_PSU_frame_2.AutoSize = True
		Me.CheckBox_PSU_frame_2.Location = New System.Drawing.Point(116, 3)
		Me.CheckBox_PSU_frame_2.Name = "CheckBox_PSU_frame_2"
		Me.CheckBox_PSU_frame_2.Size = New System.Drawing.Size(57, 17)
		Me.CheckBox_PSU_frame_2.TabIndex = 31
		Me.CheckBox_PSU_frame_2.Text = "PSU 2"
		Me.CheckBox_PSU_frame_2.UseVisualStyleBackColor = True
		'
		'CheckBox_PSU_frame_1
		'
		Me.CheckBox_PSU_frame_1.AutoSize = True
		Me.CheckBox_PSU_frame_1.Location = New System.Drawing.Point(3, 3)
		Me.CheckBox_PSU_frame_1.Name = "CheckBox_PSU_frame_1"
		Me.CheckBox_PSU_frame_1.Size = New System.Drawing.Size(57, 17)
		Me.CheckBox_PSU_frame_1.TabIndex = 23
		Me.CheckBox_PSU_frame_1.Text = "PSU 1"
		Me.CheckBox_PSU_frame_1.UseVisualStyleBackColor = True
		'
		'CheckBox_PSU_frame_3
		'
		Me.CheckBox_PSU_frame_3.AutoSize = True
		Me.CheckBox_PSU_frame_3.Location = New System.Drawing.Point(3, 36)
		Me.CheckBox_PSU_frame_3.Name = "CheckBox_PSU_frame_3"
		Me.CheckBox_PSU_frame_3.Size = New System.Drawing.Size(57, 17)
		Me.CheckBox_PSU_frame_3.TabIndex = 32
		Me.CheckBox_PSU_frame_3.Text = "PSU 3"
		Me.CheckBox_PSU_frame_3.UseVisualStyleBackColor = True
		'
		'CheckBox_PSU_frame_4
		'
		Me.CheckBox_PSU_frame_4.AutoSize = True
		Me.CheckBox_PSU_frame_4.Location = New System.Drawing.Point(116, 36)
		Me.CheckBox_PSU_frame_4.Name = "CheckBox_PSU_frame_4"
		Me.CheckBox_PSU_frame_4.Size = New System.Drawing.Size(57, 17)
		Me.CheckBox_PSU_frame_4.TabIndex = 33
		Me.CheckBox_PSU_frame_4.Text = "PSU 4"
		Me.CheckBox_PSU_frame_4.UseVisualStyleBackColor = True
		'
		'CheckBox_PSU_frame_5
		'
		Me.CheckBox_PSU_frame_5.AutoSize = True
		Me.CheckBox_PSU_frame_5.Location = New System.Drawing.Point(3, 69)
		Me.CheckBox_PSU_frame_5.Name = "CheckBox_PSU_frame_5"
		Me.CheckBox_PSU_frame_5.Size = New System.Drawing.Size(57, 17)
		Me.CheckBox_PSU_frame_5.TabIndex = 34
		Me.CheckBox_PSU_frame_5.Text = "PSU 5"
		Me.CheckBox_PSU_frame_5.UseVisualStyleBackColor = True
		'
		'CheckBox_PSU_frame_6
		'
		Me.CheckBox_PSU_frame_6.AutoSize = True
		Me.CheckBox_PSU_frame_6.Location = New System.Drawing.Point(116, 69)
		Me.CheckBox_PSU_frame_6.Name = "CheckBox_PSU_frame_6"
		Me.CheckBox_PSU_frame_6.Size = New System.Drawing.Size(57, 17)
		Me.CheckBox_PSU_frame_6.TabIndex = 35
		Me.CheckBox_PSU_frame_6.Text = "PSU 6"
		Me.CheckBox_PSU_frame_6.UseVisualStyleBackColor = True
		'
		'CheckBox_PSU_frame_7
		'
		Me.CheckBox_PSU_frame_7.AutoSize = True
		Me.CheckBox_PSU_frame_7.Location = New System.Drawing.Point(3, 102)
		Me.CheckBox_PSU_frame_7.Name = "CheckBox_PSU_frame_7"
		Me.CheckBox_PSU_frame_7.Size = New System.Drawing.Size(57, 17)
		Me.CheckBox_PSU_frame_7.TabIndex = 36
		Me.CheckBox_PSU_frame_7.Text = "PSU 7"
		Me.CheckBox_PSU_frame_7.UseVisualStyleBackColor = True
		'
		'CheckBox_PSU_frame_8
		'
		Me.CheckBox_PSU_frame_8.AutoSize = True
		Me.CheckBox_PSU_frame_8.Location = New System.Drawing.Point(116, 102)
		Me.CheckBox_PSU_frame_8.Name = "CheckBox_PSU_frame_8"
		Me.CheckBox_PSU_frame_8.Size = New System.Drawing.Size(57, 17)
		Me.CheckBox_PSU_frame_8.TabIndex = 37
		Me.CheckBox_PSU_frame_8.Text = "PSU 8"
		Me.CheckBox_PSU_frame_8.UseVisualStyleBackColor = True
		'
		'ChK_Graph_Measurements
		'
		Me.ChK_Graph_Measurements.AutoSize = True
		Me.ChK_Graph_Measurements.Location = New System.Drawing.Point(3, 33)
		Me.ChK_Graph_Measurements.Name = "ChK_Graph_Measurements"
		Me.ChK_Graph_Measurements.Size = New System.Drawing.Size(93, 17)
		Me.ChK_Graph_Measurements.TabIndex = 14
		Me.ChK_Graph_Measurements.Text = "Graph Results"
		Me.ChK_Graph_Measurements.UseVisualStyleBackColor = True
		'
		'ListBox_Saved_Preset
		'
		Me.ListBox_Saved_Preset.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ListBox_Saved_Preset.FormattingEnabled = True
		Me.ListBox_Saved_Preset.Location = New System.Drawing.Point(105, 222)
		Me.ListBox_Saved_Preset.Name = "ListBox_Saved_Preset"
		Me.ListBox_Saved_Preset.Size = New System.Drawing.Size(246, 54)
		Me.ListBox_Saved_Preset.TabIndex = 290
		'
		'TextBox1
		'
		Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TextBox1.Location = New System.Drawing.Point(105, 3)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(246, 20)
		Me.TextBox1.TabIndex = 293
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(3, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(74, 26)
		Me.Label3.TabIndex = 294
		Me.Label3.Text = "Measurement Name"
		'
		'Button1
		'
		Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Button1.Location = New System.Drawing.Point(105, 188)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(246, 28)
		Me.Button1.TabIndex = 295
		Me.Button1.Text = "Load"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'ListBox_Measured_Devices
		'
		Me.ListBox_Measured_Devices.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ListBox_Measured_Devices.FormattingEnabled = True
		Me.ListBox_Measured_Devices.Location = New System.Drawing.Point(105, 33)
		Me.ListBox_Measured_Devices.Name = "ListBox_Measured_Devices"
		Me.ListBox_Measured_Devices.Size = New System.Drawing.Size(246, 149)
		Me.ListBox_Measured_Devices.TabIndex = 296
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(3, 188)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(96, 28)
		Me.Button2.TabIndex = 297
		Me.Button2.Text = "SAVE"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1066, 24)
		Me.MenuStrip1.TabIndex = 298
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'TableLayoutPanel7
		'
		Me.TableLayoutPanel7.ColumnCount = 3
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel6, 1, 1)
		Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel4, 2, 1)
		Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel1, 0, 0)
		Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel5, 2, 0)
		Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel2, 0, 1)
		Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel3, 1, 0)
		Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 330)
		Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
		Me.TableLayoutPanel7.RowCount = 2
		Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel7.Size = New System.Drawing.Size(700, 279)
		Me.TableLayoutPanel7.TabIndex = 300
		'
		'TableLayoutPanel8
		'
		Me.TableLayoutPanel8.ColumnCount = 2
		Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.25561!))
		Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.7444!))
		Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel10, 1, 0)
		Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel11, 1, 1)
		Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel7, 0, 1)
		Me.TableLayoutPanel8.Controls.Add(Me.Button_TimmerRun, 0, 0)
		Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel8.Location = New System.Drawing.Point(0, 24)
		Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(0)
		Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
		Me.TableLayoutPanel8.RowCount = 2
		Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.5!))
		Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.5!))
		Me.TableLayoutPanel8.Size = New System.Drawing.Size(1066, 612)
		Me.TableLayoutPanel8.TabIndex = 301
		'
		'TableLayoutPanel10
		'
		Me.TableLayoutPanel10.ColumnCount = 2
		Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel10.Controls.Add(Me.TextDisplayCounter, 0, 4)
		Me.TableLayoutPanel10.Controls.Add(Me.CounterReset, 0, 3)
		Me.TableLayoutPanel10.Controls.Add(Me.Label1, 0, 0)
		Me.TableLayoutPanel10.Controls.Add(Me.TextDisplayCounterLoops, 0, 4)
		Me.TableLayoutPanel10.Controls.Add(Me.Textbox_NumberOfTestCycles, 0, 1)
		Me.TableLayoutPanel10.Controls.Add(Me.Label2, 1, 0)
		Me.TableLayoutPanel10.Controls.Add(Me.Trackbar_Interval, 1, 2)
		Me.TableLayoutPanel10.Controls.Add(Me.TextBox_Interval, 1, 1)
		Me.TableLayoutPanel10.Controls.Add(Me.Trackbar_NumberOfTestCycles, 0, 2)
		Me.TableLayoutPanel10.Controls.Add(Me.CheckBox_Loop, 1, 3)
		Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel10.Location = New System.Drawing.Point(709, 3)
		Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
		Me.TableLayoutPanel10.RowCount = 5
		Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
		Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel10.Size = New System.Drawing.Size(354, 321)
		Me.TableLayoutPanel10.TabIndex = 305
		'
		'TextDisplayCounter
		'
		Me.TextDisplayCounter.AutoSize = True
		Me.TextDisplayCounter.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TextDisplayCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextDisplayCounter.Location = New System.Drawing.Point(2, 195)
		Me.TextDisplayCounter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.TextDisplayCounter.Name = "TextDisplayCounter"
		Me.TextDisplayCounter.Size = New System.Drawing.Size(173, 126)
		Me.TextDisplayCounter.TabIndex = 15
		Me.TextDisplayCounter.Text = "0"
		'
		'CounterReset
		'
		Me.CounterReset.Dock = System.Windows.Forms.DockStyle.Fill
		Me.CounterReset.Location = New System.Drawing.Point(3, 73)
		Me.CounterReset.Name = "CounterReset"
		Me.CounterReset.Size = New System.Drawing.Size(171, 119)
		Me.CounterReset.TabIndex = 6
		Me.CounterReset.Text = "COUNTER RESET"
		Me.CounterReset.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label1.Location = New System.Drawing.Point(3, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(171, 20)
		Me.Label1.TabIndex = 9
		Me.Label1.Text = "# of Test Cycles"
		'
		'TextDisplayCounterLoops
		'
		Me.TextDisplayCounterLoops.AutoSize = True
		Me.TextDisplayCounterLoops.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TextDisplayCounterLoops.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextDisplayCounterLoops.Location = New System.Drawing.Point(179, 195)
		Me.TextDisplayCounterLoops.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.TextDisplayCounterLoops.Name = "TextDisplayCounterLoops"
		Me.TextDisplayCounterLoops.Size = New System.Drawing.Size(173, 126)
		Me.TextDisplayCounterLoops.TabIndex = 0
		Me.TextDisplayCounterLoops.Text = "0"
		'
		'Textbox_NumberOfTestCycles
		'
		Me.Textbox_NumberOfTestCycles.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Textbox_NumberOfTestCycles.Location = New System.Drawing.Point(2, 22)
		Me.Textbox_NumberOfTestCycles.Margin = New System.Windows.Forms.Padding(2)
		Me.Textbox_NumberOfTestCycles.Name = "Textbox_NumberOfTestCycles"
		Me.Textbox_NumberOfTestCycles.Size = New System.Drawing.Size(173, 20)
		Me.Textbox_NumberOfTestCycles.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label2.Location = New System.Drawing.Point(180, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(171, 20)
		Me.Label2.TabIndex = 10
		Me.Label2.Text = "Test Speed (ms)"
		'
		'Trackbar_Interval
		'
		Me.Trackbar_Interval.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Trackbar_Interval.Location = New System.Drawing.Point(179, 42)
		Me.Trackbar_Interval.Margin = New System.Windows.Forms.Padding(2)
		Me.Trackbar_Interval.Maximum = 2000
		Me.Trackbar_Interval.Minimum = 10
		Me.Trackbar_Interval.Name = "Trackbar_Interval"
		Me.Trackbar_Interval.Size = New System.Drawing.Size(173, 26)
		Me.Trackbar_Interval.TabIndex = 3
		Me.Trackbar_Interval.Value = 10
		'
		'TextBox_Interval
		'
		Me.TextBox_Interval.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TextBox_Interval.Location = New System.Drawing.Point(179, 22)
		Me.TextBox_Interval.Margin = New System.Windows.Forms.Padding(2)
		Me.TextBox_Interval.Name = "TextBox_Interval"
		Me.TextBox_Interval.Size = New System.Drawing.Size(173, 20)
		Me.TextBox_Interval.TabIndex = 4
		'
		'Trackbar_NumberOfTestCycles
		'
		Me.Trackbar_NumberOfTestCycles.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Trackbar_NumberOfTestCycles.LargeChange = 10
		Me.Trackbar_NumberOfTestCycles.Location = New System.Drawing.Point(2, 42)
		Me.Trackbar_NumberOfTestCycles.Margin = New System.Windows.Forms.Padding(2)
		Me.Trackbar_NumberOfTestCycles.Maximum = 1000
		Me.Trackbar_NumberOfTestCycles.Minimum = 10
		Me.Trackbar_NumberOfTestCycles.Name = "Trackbar_NumberOfTestCycles"
		Me.Trackbar_NumberOfTestCycles.Size = New System.Drawing.Size(173, 26)
		Me.Trackbar_NumberOfTestCycles.TabIndex = 1
		Me.Trackbar_NumberOfTestCycles.Value = 10
		'
		'CheckBox_Loop
		'
		Me.CheckBox_Loop.AutoSize = True
		Me.CheckBox_Loop.Location = New System.Drawing.Point(180, 73)
		Me.CheckBox_Loop.Name = "CheckBox_Loop"
		Me.CheckBox_Loop.Size = New System.Drawing.Size(50, 17)
		Me.CheckBox_Loop.TabIndex = 14
		Me.CheckBox_Loop.Text = "Loop"
		Me.CheckBox_Loop.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel11
		'
		Me.TableLayoutPanel11.ColumnCount = 2
		Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.00608!))
		Me.TableLayoutPanel11.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.99391!))
		Me.TableLayoutPanel11.Controls.Add(Me.ListBox_Measured_Devices, 1, 1)
		Me.TableLayoutPanel11.Controls.Add(Me.TextBox1, 1, 0)
		Me.TableLayoutPanel11.Controls.Add(Me.ChK_Graph_Measurements, 0, 1)
		Me.TableLayoutPanel11.Controls.Add(Me.Label3, 0, 0)
		Me.TableLayoutPanel11.Controls.Add(Me.Button2, 0, 2)
		Me.TableLayoutPanel11.Controls.Add(Me.ListBox_Saved_Preset, 1, 3)
		Me.TableLayoutPanel11.Controls.Add(Me.Button1, 1, 2)
		Me.TableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel11.Location = New System.Drawing.Point(709, 330)
		Me.TableLayoutPanel11.Name = "TableLayoutPanel11"
		Me.TableLayoutPanel11.RowCount = 4
		Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.43192!))
		Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.56808!))
		Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
		Me.TableLayoutPanel11.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
		Me.TableLayoutPanel11.Size = New System.Drawing.Size(354, 279)
		Me.TableLayoutPanel11.TabIndex = 302
		'
		'BenchInstrumentItemBindingSource1
		'
		Me.BenchInstrumentItemBindingSource1.DataSource = GetType(APK_Bench_Software.BenchInstrumentItem)
		'
		'BenchInstrumentItemBindingSource
		'
		Me.BenchInstrumentItemBindingSource.DataSource = GetType(APK_Bench_Software.BenchInstrumentItem)
		'
		'CheckBox_Autoscale
		'
		Me.CheckBox_Autoscale.AutoSize = True
		Me.CheckBox_Autoscale.Location = New System.Drawing.Point(3, 70)
		Me.CheckBox_Autoscale.Name = "CheckBox_Autoscale"
		Me.CheckBox_Autoscale.Size = New System.Drawing.Size(73, 17)
		Me.CheckBox_Autoscale.TabIndex = 40
		Me.CheckBox_Autoscale.Text = "Autoscale"
		Me.CheckBox_Autoscale.UseVisualStyleBackColor = True
		'
		'SequenceTimer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1066, 636)
		Me.Controls.Add(Me.TableLayoutPanel8)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "SequenceTimer"
		Me.Text = "SequenceTimer"
		Me.TableLayoutPanel6.ResumeLayout(False)
		Me.TableLayoutPanel6.PerformLayout()
		Me.TableLayoutPanel5.ResumeLayout(False)
		Me.TableLayoutPanel5.PerformLayout()
		Me.TableLayoutPanel4.ResumeLayout(False)
		Me.TableLayoutPanel4.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TableLayoutPanel7.ResumeLayout(False)
		Me.TableLayoutPanel8.ResumeLayout(False)
		Me.TableLayoutPanel10.ResumeLayout(False)
		Me.TableLayoutPanel10.PerformLayout()
		CType(Me.Trackbar_Interval, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Trackbar_NumberOfTestCycles, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel11.ResumeLayout(False)
		Me.TableLayoutPanel11.PerformLayout()
		CType(Me.BenchInstrumentItemBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BenchInstrumentItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TestSequenceTimer As Timer
	Friend WithEvents Button_TimmerRun As Button
	Friend WithEvents CheckBox_SignalGenSweep As CheckBox
	Friend WithEvents CheckBox_PSU_frame_1 As CheckBox
	Friend WithEvents CheckBox_SA As CheckBox
	Friend WithEvents CheckBox_THD As CheckBox
	Friend WithEvents CheckBox_DCLoad As CheckBox
	Friend WithEvents CheckBox_DMM6 As CheckBox
	Friend WithEvents CheckBox_DMM5 As CheckBox
	Friend WithEvents CheckBox_DMM4 As CheckBox
	Friend WithEvents CheckBox_DMM3 As CheckBox
	Friend WithEvents CheckBox_DMM2 As CheckBox
	Friend WithEvents CheckBox_DMM1 As CheckBox
	Friend WithEvents CheckBox_ScopeCH1 As CheckBox
	Friend WithEvents CheckBox_ScopeCH4 As CheckBox
	Friend WithEvents CheckBox_ScopeCH3 As CheckBox
	Friend WithEvents CheckBox_ScopeCH2 As CheckBox
	Friend WithEvents ChK_Graph_Measurements As CheckBox
	Friend WithEvents CheckBox_DMM8 As CheckBox
	Friend WithEvents CheckBox_DMM7 As CheckBox
	Friend WithEvents CheckBox_ScopeCH6 As CheckBox
	Friend WithEvents CheckBox_ScopeCH5 As CheckBox
	Friend WithEvents CheckBox_PSU_frame_6 As CheckBox
	Friend WithEvents CheckBox_PSU_frame_5 As CheckBox
	Friend WithEvents CheckBox_PSU_frame_4 As CheckBox
	Friend WithEvents CheckBox_PSU_frame_3 As CheckBox
	Friend WithEvents CheckBox_PSU_frame_2 As CheckBox
	Friend WithEvents CheckBox_PSU_frame_8 As CheckBox
	Friend WithEvents CheckBox_PSU_frame_7 As CheckBox
	Friend WithEvents Label4 As Label
	Friend WithEvents SweepStart As TextBox
	Friend WithEvents SweepStop As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents SweepEnable As Button
	Friend WithEvents ListBox_Saved_Preset As ListBox
	Friend WithEvents BenchInstrumentItemBindingSource1 As BindingSource
	Friend WithEvents BenchInstrumentItemBindingSource As BindingSource
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents ListBox_Measured_Devices As ListBox
	Friend WithEvents Button2 As Button
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
	Friend WithEvents CounterReset As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents TextDisplayCounterLoops As Label
	Friend WithEvents Textbox_NumberOfTestCycles As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Trackbar_Interval As TrackBar
	Friend WithEvents TextBox_Interval As TextBox
	Friend WithEvents Trackbar_NumberOfTestCycles As TrackBar
	Friend WithEvents CheckBox_Loop As CheckBox
	Friend WithEvents TableLayoutPanel11 As TableLayoutPanel
	Friend WithEvents TextDisplayCounter As Label
	Friend WithEvents CheckBox_log As CheckBox
	Friend WithEvents CheckBox_Autoscale As CheckBox
End Class
