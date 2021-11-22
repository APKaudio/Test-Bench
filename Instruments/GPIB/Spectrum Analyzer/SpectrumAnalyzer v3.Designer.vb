<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class spectrum_BusinessLogic
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
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
		Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.Spectrum_Chart_X2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.Preset = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
		Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
		Me.Button_Averaging = New System.Windows.Forms.Button()
		Me.TrackBar_Freq_Span = New System.Windows.Forms.TrackBar()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.SA_Span_18 = New System.Windows.Forms.TextBox()
		Me.SA_Span_17 = New System.Windows.Forms.TextBox()
		Me.SA_Name_18 = New System.Windows.Forms.TextBox()
		Me.SA_Name_17 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_18 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_17 = New System.Windows.Forms.TextBox()
		Me.SA_Span_16 = New System.Windows.Forms.TextBox()
		Me.SA_Span_15 = New System.Windows.Forms.TextBox()
		Me.SA_Span_14 = New System.Windows.Forms.TextBox()
		Me.SA_Span_13 = New System.Windows.Forms.TextBox()
		Me.SA_Name_16 = New System.Windows.Forms.TextBox()
		Me.SA_Name_15 = New System.Windows.Forms.TextBox()
		Me.SA_Name_14 = New System.Windows.Forms.TextBox()
		Me.SA_Name_13 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_16 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_15 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_14 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_13 = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.SA_Span_12 = New System.Windows.Forms.TextBox()
		Me.SA_Span_11 = New System.Windows.Forms.TextBox()
		Me.SA_Span_10 = New System.Windows.Forms.TextBox()
		Me.SA_Span_9 = New System.Windows.Forms.TextBox()
		Me.SA_Span_8 = New System.Windows.Forms.TextBox()
		Me.SA_Span_7 = New System.Windows.Forms.TextBox()
		Me.SA_Span_6 = New System.Windows.Forms.TextBox()
		Me.SA_Span_5 = New System.Windows.Forms.TextBox()
		Me.SA_Span_4 = New System.Windows.Forms.TextBox()
		Me.SA_Span_3 = New System.Windows.Forms.TextBox()
		Me.SA_Span_2 = New System.Windows.Forms.TextBox()
		Me.SA_Span_1 = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Freq = New System.Windows.Forms.Label()
		Me.SA_Name_12 = New System.Windows.Forms.TextBox()
		Me.SA_Name_11 = New System.Windows.Forms.TextBox()
		Me.SA_Name_10 = New System.Windows.Forms.TextBox()
		Me.SA_Name_9 = New System.Windows.Forms.TextBox()
		Me.SA_Name_8 = New System.Windows.Forms.TextBox()
		Me.SA_Name_7 = New System.Windows.Forms.TextBox()
		Me.SA_Name_6 = New System.Windows.Forms.TextBox()
		Me.SA_Name_5 = New System.Windows.Forms.TextBox()
		Me.SA_Name_4 = New System.Windows.Forms.TextBox()
		Me.SA_Name_3 = New System.Windows.Forms.TextBox()
		Me.SA_Name_2 = New System.Windows.Forms.TextBox()
		Me.SA_Name_1 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_12 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_11 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_10 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_9 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_8 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_7 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_6 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_5 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_4 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_3 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_2 = New System.Windows.Forms.TextBox()
		Me.SA_Freq_1 = New System.Windows.Forms.TextBox()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.SA_Button_18 = New System.Windows.Forms.Button()
		Me.SA_Button_17 = New System.Windows.Forms.Button()
		Me.SA_Button_16 = New System.Windows.Forms.Button()
		Me.SA_Button_15 = New System.Windows.Forms.Button()
		Me.SA_Button_14 = New System.Windows.Forms.Button()
		Me.SA_Button_13 = New System.Windows.Forms.Button()
		Me.SA_Button_12 = New System.Windows.Forms.Button()
		Me.SA_Button_11 = New System.Windows.Forms.Button()
		Me.SA_Button_10 = New System.Windows.Forms.Button()
		Me.SA_Button_9 = New System.Windows.Forms.Button()
		Me.SA_Button_8 = New System.Windows.Forms.Button()
		Me.SA_Button_7 = New System.Windows.Forms.Button()
		Me.SA_Button_6 = New System.Windows.Forms.Button()
		Me.SA_Button_5 = New System.Windows.Forms.Button()
		Me.SA_Button_4 = New System.Windows.Forms.Button()
		Me.SA_Button_3 = New System.Windows.Forms.Button()
		Me.SA_Button_2 = New System.Windows.Forms.Button()
		Me.SA_Button_1 = New System.Windows.Forms.Button()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button_Reset_Device = New System.Windows.Forms.Button()
		Me.SA_Unit = New System.Windows.Forms.TextBox()
		Me.Button_Save_CSV = New System.Windows.Forms.Button()
		Me.Textbox_StartFreq = New System.Windows.Forms.TextBox()
		Me.SA_StopFreq = New System.Windows.Forms.TextBox()
		Me.Button_CSV_Load = New System.Windows.Forms.Button()
		Me.Button_peak_Search = New System.Windows.Forms.Button()
		Me.TrackBar_Freq_Center_Major = New System.Windows.Forms.TrackBar()
		Me.Textbox_SA_Span = New System.Windows.Forms.TextBox()
		Me.Textbox_SA_Center = New System.Windows.Forms.TextBox()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.Timer_events = New System.Windows.Forms.Timer(Me.components)
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Horizontal_Meter_Xvalue_6 = New APK_Bench_Software.Horizontal_Meter_With_Text()
		Me.Horizontal_Meter_Xvalue_5 = New APK_Bench_Software.Horizontal_Meter_With_Text()
		Me.Horizontal_Meter_Xvalue_4 = New APK_Bench_Software.Horizontal_Meter_With_Text()
		Me.Horizontal_Meter_Xvalue_3 = New APK_Bench_Software.Horizontal_Meter_With_Text()
		Me.Horizontal_Meter_Xvalue_2 = New APK_Bench_Software.Horizontal_Meter_With_Text()
		Me.Horizontal_Meter_Xvalue_1 = New APK_Bench_Software.Horizontal_Meter_With_Text()
		Me.Horizontal_Meter_Marker_Level_1 = New APK_Bench_Software.Horizontal_Meter_With_Text()
		Me.Horizontal_Meter_Marker_Level_2 = New APK_Bench_Software.Horizontal_Meter_With_Text()
		Me.Horizontal_Meter_Marker_Level_3 = New APK_Bench_Software.Horizontal_Meter_With_Text()
		Me.Horizontal_Meter_Marker_Level_4 = New APK_Bench_Software.Horizontal_Meter_With_Text()
		Me.Horizontal_Meter_Marker_Level_5 = New APK_Bench_Software.Horizontal_Meter_With_Text()
		Me.Horizontal_Meter_Marker_Level_6 = New APK_Bench_Software.Horizontal_Meter_With_Text()
		Me.Button_Get_Trace = New System.Windows.Forms.Button()
		Me.Button_PreAmp = New System.Windows.Forms.Button()
		Me.Spectrum_Chart_X10 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.Spectrum_Chart_X100 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.Spectrum_Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.Button_Get_DIV_100 = New System.Windows.Forms.Button()
		Me.Button_Get_DIV_10 = New System.Windows.Forms.Button()
		Me.Button_Get_X2 = New System.Windows.Forms.Button()
		Me.TrackBar_Freq_Center_Minor = New System.Windows.Forms.TrackBar()
		Me.TextBox_Device_IP = New System.Windows.Forms.TextBox()
		Me.Button_High_Sensitivity = New System.Windows.Forms.Button()
		Me.Horizontal_Meter_Freq_Center = New APK_Bench_Software.Horizontal_Meter_With_Text()
		Me.Horizontal_Meter_With_Text1 = New APK_Bench_Software.Horizontal_Meter_With_Text()
		Me.TrackBar1 = New System.Windows.Forms.TrackBar()
		CType(Me.Spectrum_Chart_X2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TrackBar_Freq_Span, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabControl1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage3.SuspendLayout()
		CType(Me.TrackBar_Freq_Center_Major, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.Spectrum_Chart_X10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Spectrum_Chart_X100, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Spectrum_Chart, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel2.SuspendLayout()
		CType(Me.TrackBar_Freq_Center_Minor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Spectrum_Chart_X2
		'
		Me.Spectrum_Chart_X2.BackColor = System.Drawing.Color.DimGray
		Me.Spectrum_Chart_X2.BackImageTransparentColor = System.Drawing.Color.Silver
		ChartArea1.Name = "ChartArea1"
		Me.Spectrum_Chart_X2.ChartAreas.Add(ChartArea1)
		Me.Spectrum_Chart_X2.Cursor = System.Windows.Forms.Cursors.Cross
		Me.Spectrum_Chart_X2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Spectrum_Chart_X2.Location = New System.Drawing.Point(74, 3)
		Me.Spectrum_Chart_X2.Name = "Spectrum_Chart_X2"
		Series1.ChartArea = "ChartArea1"
		Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
		Series1.Color = System.Drawing.Color.LightGray
		Series1.Name = "Series1"
		Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale
		Me.Spectrum_Chart_X2.Series.Add(Series1)
		Me.Spectrum_Chart_X2.Size = New System.Drawing.Size(263, 208)
		Me.Spectrum_Chart_X2.TabIndex = 27
		Me.Spectrum_Chart_X2.Text = "Chart1"
		Title1.Name = "Title1"
		Me.Spectrum_Chart_X2.Titles.Add(Title1)
		'
		'Preset
		'
		Me.Preset.Location = New System.Drawing.Point(227, 556)
		Me.Preset.Name = "Preset"
		Me.Preset.Size = New System.Drawing.Size(140, 90)
		Me.Preset.TabIndex = 28
		Me.Preset.Text = "Preset"
		Me.Preset.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(37, 158)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(136, 98)
		Me.Button3.TabIndex = 15
		Me.Button3.Text = "Demod Selected"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button_Averaging
		'
		Me.Button_Averaging.BackColor = System.Drawing.Color.Gray
		Me.Button_Averaging.Location = New System.Drawing.Point(1245, 659)
		Me.Button_Averaging.Name = "Button_Averaging"
		Me.Button_Averaging.Size = New System.Drawing.Size(85, 271)
		Me.Button_Averaging.TabIndex = 33
		Me.Button_Averaging.Text = "Averaging"
		Me.Button_Averaging.UseVisualStyleBackColor = False
		'
		'TrackBar_Freq_Span
		'
		Me.TrackBar_Freq_Span.BackColor = System.Drawing.SystemColors.InfoText
		Me.TrackBar_Freq_Span.LargeChange = 50
		Me.TrackBar_Freq_Span.Location = New System.Drawing.Point(30, 910)
		Me.TrackBar_Freq_Span.Maximum = 1000
		Me.TrackBar_Freq_Span.Minimum = 1
		Me.TrackBar_Freq_Span.Name = "TrackBar_Freq_Span"
		Me.TrackBar_Freq_Span.Size = New System.Drawing.Size(229, 45)
		Me.TrackBar_Freq_Span.TabIndex = 34
		Me.TrackBar_Freq_Span.Value = 100
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Location = New System.Drawing.Point(4, 5)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(440, 565)
		Me.TabControl1.TabIndex = 36
		'
		'TabPage2
		'
		Me.TabPage2.BackColor = System.Drawing.Color.DimGray
		Me.TabPage2.Controls.Add(Me.SA_Span_18)
		Me.TabPage2.Controls.Add(Me.SA_Span_17)
		Me.TabPage2.Controls.Add(Me.SA_Name_18)
		Me.TabPage2.Controls.Add(Me.SA_Name_17)
		Me.TabPage2.Controls.Add(Me.SA_Freq_18)
		Me.TabPage2.Controls.Add(Me.SA_Freq_17)
		Me.TabPage2.Controls.Add(Me.SA_Span_16)
		Me.TabPage2.Controls.Add(Me.SA_Span_15)
		Me.TabPage2.Controls.Add(Me.SA_Span_14)
		Me.TabPage2.Controls.Add(Me.SA_Span_13)
		Me.TabPage2.Controls.Add(Me.SA_Name_16)
		Me.TabPage2.Controls.Add(Me.SA_Name_15)
		Me.TabPage2.Controls.Add(Me.SA_Name_14)
		Me.TabPage2.Controls.Add(Me.SA_Name_13)
		Me.TabPage2.Controls.Add(Me.SA_Freq_16)
		Me.TabPage2.Controls.Add(Me.SA_Freq_15)
		Me.TabPage2.Controls.Add(Me.SA_Freq_14)
		Me.TabPage2.Controls.Add(Me.SA_Freq_13)
		Me.TabPage2.Controls.Add(Me.Preset)
		Me.TabPage2.Controls.Add(Me.Label6)
		Me.TabPage2.Controls.Add(Me.SA_Span_12)
		Me.TabPage2.Controls.Add(Me.SA_Span_11)
		Me.TabPage2.Controls.Add(Me.SA_Span_10)
		Me.TabPage2.Controls.Add(Me.SA_Span_9)
		Me.TabPage2.Controls.Add(Me.SA_Span_8)
		Me.TabPage2.Controls.Add(Me.SA_Span_7)
		Me.TabPage2.Controls.Add(Me.SA_Span_6)
		Me.TabPage2.Controls.Add(Me.SA_Span_5)
		Me.TabPage2.Controls.Add(Me.SA_Span_4)
		Me.TabPage2.Controls.Add(Me.SA_Span_3)
		Me.TabPage2.Controls.Add(Me.SA_Span_2)
		Me.TabPage2.Controls.Add(Me.SA_Span_1)
		Me.TabPage2.Controls.Add(Me.Label7)
		Me.TabPage2.Controls.Add(Me.Freq)
		Me.TabPage2.Controls.Add(Me.SA_Name_12)
		Me.TabPage2.Controls.Add(Me.SA_Name_11)
		Me.TabPage2.Controls.Add(Me.SA_Name_10)
		Me.TabPage2.Controls.Add(Me.SA_Name_9)
		Me.TabPage2.Controls.Add(Me.SA_Name_8)
		Me.TabPage2.Controls.Add(Me.SA_Name_7)
		Me.TabPage2.Controls.Add(Me.SA_Name_6)
		Me.TabPage2.Controls.Add(Me.SA_Name_5)
		Me.TabPage2.Controls.Add(Me.SA_Name_4)
		Me.TabPage2.Controls.Add(Me.SA_Name_3)
		Me.TabPage2.Controls.Add(Me.SA_Name_2)
		Me.TabPage2.Controls.Add(Me.SA_Name_1)
		Me.TabPage2.Controls.Add(Me.SA_Freq_12)
		Me.TabPage2.Controls.Add(Me.SA_Freq_11)
		Me.TabPage2.Controls.Add(Me.SA_Freq_10)
		Me.TabPage2.Controls.Add(Me.SA_Freq_9)
		Me.TabPage2.Controls.Add(Me.SA_Freq_8)
		Me.TabPage2.Controls.Add(Me.SA_Freq_7)
		Me.TabPage2.Controls.Add(Me.SA_Freq_6)
		Me.TabPage2.Controls.Add(Me.SA_Freq_5)
		Me.TabPage2.Controls.Add(Me.SA_Freq_4)
		Me.TabPage2.Controls.Add(Me.SA_Freq_3)
		Me.TabPage2.Controls.Add(Me.SA_Freq_2)
		Me.TabPage2.Controls.Add(Me.SA_Freq_1)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(432, 539)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "frequencies"
		'
		'SA_Span_18
		'
		Me.SA_Span_18.Location = New System.Drawing.Point(60, 482)
		Me.SA_Span_18.Name = "SA_Span_18"
		Me.SA_Span_18.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_18.TabIndex = 124
		Me.SA_Span_18.Text = "200"
		'
		'SA_Span_17
		'
		Me.SA_Span_17.Location = New System.Drawing.Point(60, 456)
		Me.SA_Span_17.Name = "SA_Span_17"
		Me.SA_Span_17.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_17.TabIndex = 123
		Me.SA_Span_17.Text = "200"
		'
		'SA_Name_18
		'
		Me.SA_Name_18.Location = New System.Drawing.Point(115, 482)
		Me.SA_Name_18.Name = "SA_Name_18"
		Me.SA_Name_18.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_18.TabIndex = 122
		Me.SA_Name_18.Text = "TextBox5"
		'
		'SA_Name_17
		'
		Me.SA_Name_17.Location = New System.Drawing.Point(115, 456)
		Me.SA_Name_17.Name = "SA_Name_17"
		Me.SA_Name_17.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_17.TabIndex = 121
		Me.SA_Name_17.Text = "IFB 5 - Tessa"
		'
		'SA_Freq_18
		'
		Me.SA_Freq_18.Location = New System.Drawing.Point(5, 482)
		Me.SA_Freq_18.Name = "SA_Freq_18"
		Me.SA_Freq_18.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_18.TabIndex = 120
		Me.SA_Freq_18.Text = "500.12"
		'
		'SA_Freq_17
		'
		Me.SA_Freq_17.Location = New System.Drawing.Point(5, 456)
		Me.SA_Freq_17.Name = "SA_Freq_17"
		Me.SA_Freq_17.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_17.TabIndex = 119
		Me.SA_Freq_17.Text = "656.650"
		'
		'SA_Span_16
		'
		Me.SA_Span_16.Location = New System.Drawing.Point(62, 430)
		Me.SA_Span_16.Name = "SA_Span_16"
		Me.SA_Span_16.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_16.TabIndex = 118
		Me.SA_Span_16.Text = "200"
		'
		'SA_Span_15
		'
		Me.SA_Span_15.Location = New System.Drawing.Point(62, 404)
		Me.SA_Span_15.Name = "SA_Span_15"
		Me.SA_Span_15.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_15.TabIndex = 117
		Me.SA_Span_15.Text = "200"
		'
		'SA_Span_14
		'
		Me.SA_Span_14.Location = New System.Drawing.Point(61, 378)
		Me.SA_Span_14.Name = "SA_Span_14"
		Me.SA_Span_14.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_14.TabIndex = 116
		Me.SA_Span_14.Text = "200"
		'
		'SA_Span_13
		'
		Me.SA_Span_13.Location = New System.Drawing.Point(60, 352)
		Me.SA_Span_13.Name = "SA_Span_13"
		Me.SA_Span_13.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_13.TabIndex = 115
		Me.SA_Span_13.Text = "200"
		'
		'SA_Name_16
		'
		Me.SA_Name_16.Location = New System.Drawing.Point(117, 430)
		Me.SA_Name_16.Name = "SA_Name_16"
		Me.SA_Name_16.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_16.TabIndex = 114
		Me.SA_Name_16.Text = "IFB 4 - LIZ"
		'
		'SA_Name_15
		'
		Me.SA_Name_15.Location = New System.Drawing.Point(117, 404)
		Me.SA_Name_15.Name = "SA_Name_15"
		Me.SA_Name_15.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_15.TabIndex = 113
		Me.SA_Name_15.Text = "IFB 3 - Tryone"
		'
		'SA_Name_14
		'
		Me.SA_Name_14.Location = New System.Drawing.Point(116, 378)
		Me.SA_Name_14.Name = "SA_Name_14"
		Me.SA_Name_14.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_14.TabIndex = 112
		Me.SA_Name_14.Text = "IFB 2 - Allysia"
		'
		'SA_Name_13
		'
		Me.SA_Name_13.Location = New System.Drawing.Point(115, 352)
		Me.SA_Name_13.Name = "SA_Name_13"
		Me.SA_Name_13.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_13.TabIndex = 111
		Me.SA_Name_13.Text = "IFB1 - JOE"
		'
		'SA_Freq_16
		'
		Me.SA_Freq_16.Location = New System.Drawing.Point(7, 430)
		Me.SA_Freq_16.Name = "SA_Freq_16"
		Me.SA_Freq_16.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_16.TabIndex = 110
		Me.SA_Freq_16.Text = "656.175"
		'
		'SA_Freq_15
		'
		Me.SA_Freq_15.Location = New System.Drawing.Point(7, 404)
		Me.SA_Freq_15.Name = "SA_Freq_15"
		Me.SA_Freq_15.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_15.TabIndex = 109
		Me.SA_Freq_15.Text = "647.150"
		'
		'SA_Freq_14
		'
		Me.SA_Freq_14.Location = New System.Drawing.Point(6, 378)
		Me.SA_Freq_14.Name = "SA_Freq_14"
		Me.SA_Freq_14.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_14.TabIndex = 108
		Me.SA_Freq_14.Text = "645.80"
		'
		'SA_Freq_13
		'
		Me.SA_Freq_13.Location = New System.Drawing.Point(5, 352)
		Me.SA_Freq_13.Name = "SA_Freq_13"
		Me.SA_Freq_13.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_13.TabIndex = 107
		Me.SA_Freq_13.Text = "641.800"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(58, 18)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(32, 13)
		Me.Label6.TabIndex = 106
		Me.Label6.Text = "Span"
		'
		'SA_Span_12
		'
		Me.SA_Span_12.Location = New System.Drawing.Point(62, 326)
		Me.SA_Span_12.Name = "SA_Span_12"
		Me.SA_Span_12.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_12.TabIndex = 105
		Me.SA_Span_12.Text = "200"
		'
		'SA_Span_11
		'
		Me.SA_Span_11.Location = New System.Drawing.Point(62, 300)
		Me.SA_Span_11.Name = "SA_Span_11"
		Me.SA_Span_11.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_11.TabIndex = 104
		Me.SA_Span_11.Text = "200"
		'
		'SA_Span_10
		'
		Me.SA_Span_10.Location = New System.Drawing.Point(61, 274)
		Me.SA_Span_10.Name = "SA_Span_10"
		Me.SA_Span_10.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_10.TabIndex = 103
		Me.SA_Span_10.Text = "200"
		'
		'SA_Span_9
		'
		Me.SA_Span_9.Location = New System.Drawing.Point(60, 248)
		Me.SA_Span_9.Name = "SA_Span_9"
		Me.SA_Span_9.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_9.TabIndex = 102
		Me.SA_Span_9.Text = "200"
		'
		'SA_Span_8
		'
		Me.SA_Span_8.Location = New System.Drawing.Point(60, 222)
		Me.SA_Span_8.Name = "SA_Span_8"
		Me.SA_Span_8.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_8.TabIndex = 101
		Me.SA_Span_8.Text = "200"
		'
		'SA_Span_7
		'
		Me.SA_Span_7.Location = New System.Drawing.Point(60, 196)
		Me.SA_Span_7.Name = "SA_Span_7"
		Me.SA_Span_7.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_7.TabIndex = 100
		Me.SA_Span_7.Text = "200"
		'
		'SA_Span_6
		'
		Me.SA_Span_6.Location = New System.Drawing.Point(60, 170)
		Me.SA_Span_6.Name = "SA_Span_6"
		Me.SA_Span_6.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_6.TabIndex = 99
		Me.SA_Span_6.Text = "200"
		'
		'SA_Span_5
		'
		Me.SA_Span_5.Location = New System.Drawing.Point(60, 144)
		Me.SA_Span_5.Name = "SA_Span_5"
		Me.SA_Span_5.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_5.TabIndex = 98
		Me.SA_Span_5.Text = "200"
		'
		'SA_Span_4
		'
		Me.SA_Span_4.Location = New System.Drawing.Point(60, 115)
		Me.SA_Span_4.Name = "SA_Span_4"
		Me.SA_Span_4.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_4.TabIndex = 97
		Me.SA_Span_4.Text = "200"
		'
		'SA_Span_3
		'
		Me.SA_Span_3.Location = New System.Drawing.Point(61, 89)
		Me.SA_Span_3.Name = "SA_Span_3"
		Me.SA_Span_3.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_3.TabIndex = 96
		Me.SA_Span_3.Text = "200"
		'
		'SA_Span_2
		'
		Me.SA_Span_2.Location = New System.Drawing.Point(60, 63)
		Me.SA_Span_2.Name = "SA_Span_2"
		Me.SA_Span_2.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_2.TabIndex = 95
		Me.SA_Span_2.Text = "200"
		'
		'SA_Span_1
		'
		Me.SA_Span_1.Location = New System.Drawing.Point(60, 37)
		Me.SA_Span_1.Name = "SA_Span_1"
		Me.SA_Span_1.Size = New System.Drawing.Size(49, 20)
		Me.SA_Span_1.TabIndex = 94
		Me.SA_Span_1.Text = "200"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(113, 18)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(35, 13)
		Me.Label7.TabIndex = 93
		Me.Label7.Text = "Name"
		'
		'Freq
		'
		Me.Freq.AutoSize = True
		Me.Freq.Location = New System.Drawing.Point(6, 18)
		Me.Freq.Name = "Freq"
		Me.Freq.Size = New System.Drawing.Size(28, 13)
		Me.Freq.TabIndex = 92
		Me.Freq.Text = "Freq"
		'
		'SA_Name_12
		'
		Me.SA_Name_12.Location = New System.Drawing.Point(117, 326)
		Me.SA_Name_12.Name = "SA_Name_12"
		Me.SA_Name_12.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_12.TabIndex = 91
		Me.SA_Name_12.Text = "12 - Spare 2"
		'
		'SA_Name_11
		'
		Me.SA_Name_11.Location = New System.Drawing.Point(117, 300)
		Me.SA_Name_11.Name = "SA_Name_11"
		Me.SA_Name_11.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_11.TabIndex = 90
		Me.SA_Name_11.Text = "11 - Spare 1"
		'
		'SA_Name_10
		'
		Me.SA_Name_10.Location = New System.Drawing.Point(116, 274)
		Me.SA_Name_10.Name = "SA_Name_10"
		Me.SA_Name_10.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_10.TabIndex = 89
		Me.SA_Name_10.Text = "10 - Pink - Tessa Guest"
		'
		'SA_Name_9
		'
		Me.SA_Name_9.Location = New System.Drawing.Point(115, 248)
		Me.SA_Name_9.Name = "SA_Name_9"
		Me.SA_Name_9.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_9.TabIndex = 88
		Me.SA_Name_9.Text = "9 - Brown - Tessa"
		'
		'SA_Name_8
		'
		Me.SA_Name_8.Location = New System.Drawing.Point(115, 222)
		Me.SA_Name_8.Name = "SA_Name_8"
		Me.SA_Name_8.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_8.TabIndex = 87
		Me.SA_Name_8.Text = "8 - White - Guest 4"
		'
		'SA_Name_7
		'
		Me.SA_Name_7.Location = New System.Drawing.Point(115, 196)
		Me.SA_Name_7.Name = "SA_Name_7"
		Me.SA_Name_7.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_7.TabIndex = 86
		Me.SA_Name_7.Text = "7 - Violet - Guest 3"
		'
		'SA_Name_6
		'
		Me.SA_Name_6.Location = New System.Drawing.Point(115, 170)
		Me.SA_Name_6.Name = "SA_Name_6"
		Me.SA_Name_6.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_6.TabIndex = 85
		Me.SA_Name_6.Text = "6 - Black - Guest 2"
		'
		'SA_Name_5
		'
		Me.SA_Name_5.Location = New System.Drawing.Point(115, 144)
		Me.SA_Name_5.Name = "SA_Name_5"
		Me.SA_Name_5.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_5.TabIndex = 84
		Me.SA_Name_5.Text = "5 - Orange - Guest"
		'
		'SA_Name_4
		'
		Me.SA_Name_4.Location = New System.Drawing.Point(115, 115)
		Me.SA_Name_4.Name = "SA_Name_4"
		Me.SA_Name_4.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_4.TabIndex = 83
		Me.SA_Name_4.Text = "4 - Red - Liz"
		'
		'SA_Name_3
		'
		Me.SA_Name_3.Location = New System.Drawing.Point(116, 89)
		Me.SA_Name_3.Name = "SA_Name_3"
		Me.SA_Name_3.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_3.TabIndex = 82
		Me.SA_Name_3.Text = "3 - Blue Tyron"
		'
		'SA_Name_2
		'
		Me.SA_Name_2.Location = New System.Drawing.Point(115, 63)
		Me.SA_Name_2.Name = "SA_Name_2"
		Me.SA_Name_2.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_2.TabIndex = 81
		Me.SA_Name_2.Text = "2 - Green - Allesia"
		'
		'SA_Name_1
		'
		Me.SA_Name_1.Location = New System.Drawing.Point(115, 37)
		Me.SA_Name_1.Name = "SA_Name_1"
		Me.SA_Name_1.Size = New System.Drawing.Size(296, 20)
		Me.SA_Name_1.TabIndex = 80
		Me.SA_Name_1.Text = "1 - Yellow - JOE"
		'
		'SA_Freq_12
		'
		Me.SA_Freq_12.Location = New System.Drawing.Point(7, 326)
		Me.SA_Freq_12.Name = "SA_Freq_12"
		Me.SA_Freq_12.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_12.TabIndex = 79
		Me.SA_Freq_12.Text = "695.690"
		'
		'SA_Freq_11
		'
		Me.SA_Freq_11.Location = New System.Drawing.Point(7, 300)
		Me.SA_Freq_11.Name = "SA_Freq_11"
		Me.SA_Freq_11.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_11.TabIndex = 78
		Me.SA_Freq_11.Text = "681.125"
		'
		'SA_Freq_10
		'
		Me.SA_Freq_10.Location = New System.Drawing.Point(6, 274)
		Me.SA_Freq_10.Name = "SA_Freq_10"
		Me.SA_Freq_10.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_10.TabIndex = 77
		Me.SA_Freq_10.Text = "684.100"
		'
		'SA_Freq_9
		'
		Me.SA_Freq_9.Location = New System.Drawing.Point(5, 248)
		Me.SA_Freq_9.Name = "SA_Freq_9"
		Me.SA_Freq_9.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_9.TabIndex = 76
		Me.SA_Freq_9.Text = "696.885"
		'
		'SA_Freq_8
		'
		Me.SA_Freq_8.Location = New System.Drawing.Point(5, 222)
		Me.SA_Freq_8.Name = "SA_Freq_8"
		Me.SA_Freq_8.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_8.TabIndex = 75
		Me.SA_Freq_8.Text = "681.425"
		'
		'SA_Freq_7
		'
		Me.SA_Freq_7.Location = New System.Drawing.Point(5, 196)
		Me.SA_Freq_7.Name = "SA_Freq_7"
		Me.SA_Freq_7.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_7.TabIndex = 74
		Me.SA_Freq_7.Text = "677.625"
		'
		'SA_Freq_6
		'
		Me.SA_Freq_6.Location = New System.Drawing.Point(5, 170)
		Me.SA_Freq_6.Name = "SA_Freq_6"
		Me.SA_Freq_6.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_6.TabIndex = 73
		Me.SA_Freq_6.Text = "680.025"
		'
		'SA_Freq_5
		'
		Me.SA_Freq_5.Location = New System.Drawing.Point(5, 144)
		Me.SA_Freq_5.Name = "SA_Freq_5"
		Me.SA_Freq_5.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_5.TabIndex = 72
		Me.SA_Freq_5.Text = "679.600"
		'
		'SA_Freq_4
		'
		Me.SA_Freq_4.Location = New System.Drawing.Point(5, 115)
		Me.SA_Freq_4.Name = "SA_Freq_4"
		Me.SA_Freq_4.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_4.TabIndex = 71
		Me.SA_Freq_4.Text = "679.275"
		'
		'SA_Freq_3
		'
		Me.SA_Freq_3.Location = New System.Drawing.Point(6, 89)
		Me.SA_Freq_3.Name = "SA_Freq_3"
		Me.SA_Freq_3.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_3.TabIndex = 70
		Me.SA_Freq_3.Text = "663.465"
		'
		'SA_Freq_2
		'
		Me.SA_Freq_2.Location = New System.Drawing.Point(5, 63)
		Me.SA_Freq_2.Name = "SA_Freq_2"
		Me.SA_Freq_2.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_2.TabIndex = 69
		Me.SA_Freq_2.Text = "697.670"
		'
		'SA_Freq_1
		'
		Me.SA_Freq_1.Location = New System.Drawing.Point(5, 37)
		Me.SA_Freq_1.Name = "SA_Freq_1"
		Me.SA_Freq_1.Size = New System.Drawing.Size(49, 20)
		Me.SA_Freq_1.TabIndex = 68
		Me.SA_Freq_1.Text = "694.715"
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.SA_Button_18)
		Me.TabPage1.Controls.Add(Me.SA_Button_17)
		Me.TabPage1.Controls.Add(Me.SA_Button_16)
		Me.TabPage1.Controls.Add(Me.SA_Button_15)
		Me.TabPage1.Controls.Add(Me.SA_Button_14)
		Me.TabPage1.Controls.Add(Me.SA_Button_13)
		Me.TabPage1.Controls.Add(Me.SA_Button_12)
		Me.TabPage1.Controls.Add(Me.SA_Button_11)
		Me.TabPage1.Controls.Add(Me.SA_Button_10)
		Me.TabPage1.Controls.Add(Me.SA_Button_9)
		Me.TabPage1.Controls.Add(Me.SA_Button_8)
		Me.TabPage1.Controls.Add(Me.SA_Button_7)
		Me.TabPage1.Controls.Add(Me.SA_Button_6)
		Me.TabPage1.Controls.Add(Me.SA_Button_5)
		Me.TabPage1.Controls.Add(Me.SA_Button_4)
		Me.TabPage1.Controls.Add(Me.SA_Button_3)
		Me.TabPage1.Controls.Add(Me.SA_Button_2)
		Me.TabPage1.Controls.Add(Me.SA_Button_1)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(432, 539)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "buttons"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'SA_Button_18
		'
		Me.SA_Button_18.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_18.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_18.Location = New System.Drawing.Point(279, 450)
		Me.SA_Button_18.Name = "SA_Button_18"
		Me.SA_Button_18.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_18.TabIndex = 17
		Me.SA_Button_18.Text = "Button4"
		Me.SA_Button_18.UseVisualStyleBackColor = False
		'
		'SA_Button_17
		'
		Me.SA_Button_17.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_17.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_17.Location = New System.Drawing.Point(148, 450)
		Me.SA_Button_17.Name = "SA_Button_17"
		Me.SA_Button_17.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_17.TabIndex = 16
		Me.SA_Button_17.Text = "Button5"
		Me.SA_Button_17.UseVisualStyleBackColor = False
		'
		'SA_Button_16
		'
		Me.SA_Button_16.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_16.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_16.Location = New System.Drawing.Point(17, 450)
		Me.SA_Button_16.Name = "SA_Button_16"
		Me.SA_Button_16.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_16.TabIndex = 15
		Me.SA_Button_16.Text = "Button6"
		Me.SA_Button_16.UseVisualStyleBackColor = False
		'
		'SA_Button_15
		'
		Me.SA_Button_15.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_15.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_15.Location = New System.Drawing.Point(279, 366)
		Me.SA_Button_15.Name = "SA_Button_15"
		Me.SA_Button_15.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_15.TabIndex = 14
		Me.SA_Button_15.Text = "Button4"
		Me.SA_Button_15.UseVisualStyleBackColor = False
		'
		'SA_Button_14
		'
		Me.SA_Button_14.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_14.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_14.Location = New System.Drawing.Point(148, 366)
		Me.SA_Button_14.Name = "SA_Button_14"
		Me.SA_Button_14.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_14.TabIndex = 13
		Me.SA_Button_14.Text = "Button5"
		Me.SA_Button_14.UseVisualStyleBackColor = False
		'
		'SA_Button_13
		'
		Me.SA_Button_13.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_13.Location = New System.Drawing.Point(17, 366)
		Me.SA_Button_13.Name = "SA_Button_13"
		Me.SA_Button_13.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_13.TabIndex = 12
		Me.SA_Button_13.Text = "Button6"
		Me.SA_Button_13.UseVisualStyleBackColor = False
		'
		'SA_Button_12
		'
		Me.SA_Button_12.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_12.Location = New System.Drawing.Point(279, 282)
		Me.SA_Button_12.Name = "SA_Button_12"
		Me.SA_Button_12.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_12.TabIndex = 11
		Me.SA_Button_12.Text = "SA_Button_12"
		Me.SA_Button_12.UseVisualStyleBackColor = False
		'
		'SA_Button_11
		'
		Me.SA_Button_11.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_11.Location = New System.Drawing.Point(148, 282)
		Me.SA_Button_11.Name = "SA_Button_11"
		Me.SA_Button_11.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_11.TabIndex = 10
		Me.SA_Button_11.Text = "SA_Button_11"
		Me.SA_Button_11.UseVisualStyleBackColor = False
		'
		'SA_Button_10
		'
		Me.SA_Button_10.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_10.Location = New System.Drawing.Point(17, 282)
		Me.SA_Button_10.Name = "SA_Button_10"
		Me.SA_Button_10.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_10.TabIndex = 9
		Me.SA_Button_10.Text = "SA_Button_10"
		Me.SA_Button_10.UseVisualStyleBackColor = False
		'
		'SA_Button_9
		'
		Me.SA_Button_9.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_9.Location = New System.Drawing.Point(279, 196)
		Me.SA_Button_9.Name = "SA_Button_9"
		Me.SA_Button_9.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_9.TabIndex = 8
		Me.SA_Button_9.Text = "SA_Button_9"
		Me.SA_Button_9.UseVisualStyleBackColor = False
		'
		'SA_Button_8
		'
		Me.SA_Button_8.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_8.Location = New System.Drawing.Point(148, 196)
		Me.SA_Button_8.Name = "SA_Button_8"
		Me.SA_Button_8.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_8.TabIndex = 7
		Me.SA_Button_8.Text = "SA_Button_8"
		Me.SA_Button_8.UseVisualStyleBackColor = False
		'
		'SA_Button_7
		'
		Me.SA_Button_7.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_7.Location = New System.Drawing.Point(17, 196)
		Me.SA_Button_7.Name = "SA_Button_7"
		Me.SA_Button_7.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_7.TabIndex = 6
		Me.SA_Button_7.Text = "SA_Button_7"
		Me.SA_Button_7.UseVisualStyleBackColor = False
		'
		'SA_Button_6
		'
		Me.SA_Button_6.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_6.Location = New System.Drawing.Point(279, 112)
		Me.SA_Button_6.Name = "SA_Button_6"
		Me.SA_Button_6.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_6.TabIndex = 5
		Me.SA_Button_6.Text = "SA_Button_6"
		Me.SA_Button_6.UseVisualStyleBackColor = False
		'
		'SA_Button_5
		'
		Me.SA_Button_5.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_5.Location = New System.Drawing.Point(148, 112)
		Me.SA_Button_5.Name = "SA_Button_5"
		Me.SA_Button_5.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_5.TabIndex = 4
		Me.SA_Button_5.Text = "SA_Button_5"
		Me.SA_Button_5.UseVisualStyleBackColor = False
		'
		'SA_Button_4
		'
		Me.SA_Button_4.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_4.Location = New System.Drawing.Point(17, 112)
		Me.SA_Button_4.Name = "SA_Button_4"
		Me.SA_Button_4.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_4.TabIndex = 3
		Me.SA_Button_4.Text = "SA_Button_4"
		Me.SA_Button_4.UseVisualStyleBackColor = False
		'
		'SA_Button_3
		'
		Me.SA_Button_3.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_3.Location = New System.Drawing.Point(279, 28)
		Me.SA_Button_3.Name = "SA_Button_3"
		Me.SA_Button_3.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_3.TabIndex = 2
		Me.SA_Button_3.Text = "SA_Button_3"
		Me.SA_Button_3.UseVisualStyleBackColor = False
		'
		'SA_Button_2
		'
		Me.SA_Button_2.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_2.Location = New System.Drawing.Point(148, 28)
		Me.SA_Button_2.Name = "SA_Button_2"
		Me.SA_Button_2.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_2.TabIndex = 1
		Me.SA_Button_2.Text = "SA_Button_2"
		Me.SA_Button_2.UseVisualStyleBackColor = False
		'
		'SA_Button_1
		'
		Me.SA_Button_1.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.SA_Button_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SA_Button_1.Location = New System.Drawing.Point(17, 28)
		Me.SA_Button_1.Name = "SA_Button_1"
		Me.SA_Button_1.Size = New System.Drawing.Size(125, 78)
		Me.SA_Button_1.TabIndex = 0
		Me.SA_Button_1.Text = "SA_Button_1"
		Me.SA_Button_1.UseVisualStyleBackColor = False
		'
		'TabPage3
		'
		Me.TabPage3.Controls.Add(Me.Button5)
		Me.TabPage3.Controls.Add(Me.Button3)
		Me.TabPage3.Controls.Add(Me.Button4)
		Me.TabPage3.Controls.Add(Me.Button1)
		Me.TabPage3.Controls.Add(Me.Button_Reset_Device)
		Me.TabPage3.Location = New System.Drawing.Point(4, 22)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage3.Size = New System.Drawing.Size(432, 539)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "TabPage3"
		Me.TabPage3.UseVisualStyleBackColor = True
		'
		'Button5
		'
		Me.Button5.Location = New System.Drawing.Point(283, 216)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(75, 153)
		Me.Button5.TabIndex = 127
		Me.Button5.Text = "Show All Markers"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(37, 54)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(161, 98)
		Me.Button4.TabIndex = 40
		Me.Button4.Text = "Save Screen"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(204, 54)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(154, 98)
		Me.Button1.TabIndex = 37
		Me.Button1.Text = "Command List"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button_Reset_Device
		'
		Me.Button_Reset_Device.Location = New System.Drawing.Point(22, 361)
		Me.Button_Reset_Device.Margin = New System.Windows.Forms.Padding(2)
		Me.Button_Reset_Device.Name = "Button_Reset_Device"
		Me.Button_Reset_Device.Size = New System.Drawing.Size(196, 142)
		Me.Button_Reset_Device.TabIndex = 135
		Me.Button_Reset_Device.Text = "Button_Reset_device"
		Me.Button_Reset_Device.UseVisualStyleBackColor = True
		'
		'SA_Unit
		'
		Me.SA_Unit.Location = New System.Drawing.Point(436, 772)
		Me.SA_Unit.Name = "SA_Unit"
		Me.SA_Unit.Size = New System.Drawing.Size(76, 20)
		Me.SA_Unit.TabIndex = 4
		Me.SA_Unit.Text = "MHZ"
		'
		'Button_Save_CSV
		'
		Me.Button_Save_CSV.Location = New System.Drawing.Point(276, 579)
		Me.Button_Save_CSV.Name = "Button_Save_CSV"
		Me.Button_Save_CSV.Size = New System.Drawing.Size(168, 50)
		Me.Button_Save_CSV.TabIndex = 125
		Me.Button_Save_CSV.Text = "Save CSV"
		Me.Button_Save_CSV.UseVisualStyleBackColor = True
		'
		'Textbox_StartFreq
		'
		Me.Textbox_StartFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Textbox_StartFreq.Location = New System.Drawing.Point(37, 635)
		Me.Textbox_StartFreq.Name = "Textbox_StartFreq"
		Me.Textbox_StartFreq.Size = New System.Drawing.Size(82, 38)
		Me.Textbox_StartFreq.TabIndex = 10
		Me.Textbox_StartFreq.Text = "50"
		'
		'SA_StopFreq
		'
		Me.SA_StopFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SA_StopFreq.Location = New System.Drawing.Point(389, 635)
		Me.SA_StopFreq.Name = "SA_StopFreq"
		Me.SA_StopFreq.Size = New System.Drawing.Size(90, 38)
		Me.SA_StopFreq.TabIndex = 11
		Me.SA_StopFreq.Text = "150"
		'
		'Button_CSV_Load
		'
		Me.Button_CSV_Load.BackColor = System.Drawing.Color.Gray
		Me.Button_CSV_Load.Location = New System.Drawing.Point(4, 577)
		Me.Button_CSV_Load.Name = "Button_CSV_Load"
		Me.Button_CSV_Load.Size = New System.Drawing.Size(255, 52)
		Me.Button_CSV_Load.TabIndex = 125
		Me.Button_CSV_Load.Text = "Load CSV"
		Me.Button_CSV_Load.UseVisualStyleBackColor = False
		'
		'Button_peak_Search
		'
		Me.Button_peak_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.Button_peak_Search.Location = New System.Drawing.Point(1042, 572)
		Me.Button_peak_Search.Name = "Button_peak_Search"
		Me.Button_peak_Search.Size = New System.Drawing.Size(101, 358)
		Me.Button_peak_Search.TabIndex = 14
		Me.Button_peak_Search.Text = "Peak Search"
		Me.Button_peak_Search.UseVisualStyleBackColor = False
		'
		'TrackBar_Freq_Center_Major
		'
		Me.TrackBar_Freq_Center_Major.BackColor = System.Drawing.SystemColors.InfoText
		Me.TrackBar_Freq_Center_Major.Location = New System.Drawing.Point(36, 747)
		Me.TrackBar_Freq_Center_Major.Maximum = 999
		Me.TrackBar_Freq_Center_Major.Name = "TrackBar_Freq_Center_Major"
		Me.TrackBar_Freq_Center_Major.Size = New System.Drawing.Size(223, 45)
		Me.TrackBar_Freq_Center_Major.TabIndex = 9
		Me.TrackBar_Freq_Center_Major.Value = 1
		'
		'Textbox_SA_Span
		'
		Me.Textbox_SA_Span.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Textbox_SA_Span.Location = New System.Drawing.Point(426, 911)
		Me.Textbox_SA_Span.Name = "Textbox_SA_Span"
		Me.Textbox_SA_Span.Size = New System.Drawing.Size(100, 38)
		Me.Textbox_SA_Span.TabIndex = 6
		Me.Textbox_SA_Span.Text = "100"
		'
		'Textbox_SA_Center
		'
		Me.Textbox_SA_Center.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Textbox_SA_Center.Location = New System.Drawing.Point(205, 635)
		Me.Textbox_SA_Center.Name = "Textbox_SA_Center"
		Me.Textbox_SA_Center.Size = New System.Drawing.Size(100, 38)
		Me.Textbox_SA_Center.TabIndex = 1
		Me.Textbox_SA_Center.Text = "100"
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'Timer_events
		'
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.Horizontal_Meter_Xvalue_6, 0, 5)
		Me.TableLayoutPanel1.Controls.Add(Me.Horizontal_Meter_Xvalue_5, 0, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.Horizontal_Meter_Xvalue_4, 0, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.Horizontal_Meter_Xvalue_3, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.Horizontal_Meter_Xvalue_2, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Horizontal_Meter_Xvalue_1, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Horizontal_Meter_Marker_Level_1, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Horizontal_Meter_Marker_Level_2, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.Horizontal_Meter_Marker_Level_3, 1, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.Horizontal_Meter_Marker_Level_4, 1, 3)
		Me.TableLayoutPanel1.Controls.Add(Me.Horizontal_Meter_Marker_Level_5, 1, 4)
		Me.TableLayoutPanel1.Controls.Add(Me.Horizontal_Meter_Marker_Level_6, 1, 5)
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(532, 563)
		Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 6
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(523, 373)
		Me.TableLayoutPanel1.TabIndex = 129
		'
		'Horizontal_Meter_Xvalue_6
		'
		Me.Horizontal_Meter_Xvalue_6.AllowDrop = True
		Me.Horizontal_Meter_Xvalue_6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Horizontal_Meter_Xvalue_6.BackColor = System.Drawing.Color.White
		Me.Horizontal_Meter_Xvalue_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Horizontal_Meter_Xvalue_6.Location = New System.Drawing.Point(6, 316)
		Me.Horizontal_Meter_Xvalue_6.Margin = New System.Windows.Forms.Padding(6)
		Me.Horizontal_Meter_Xvalue_6.ModuleNumber = 0R
		Me.Horizontal_Meter_Xvalue_6.Name = "Horizontal_Meter_Xvalue_6"
		Me.Horizontal_Meter_Xvalue_6.Size = New System.Drawing.Size(249, 51)
		Me.Horizontal_Meter_Xvalue_6.TabIndex = 130
		Me.Horizontal_Meter_Xvalue_6.Title_To_Display = "PK 6"
		Me.Horizontal_Meter_Xvalue_6.Value_To_Display = 0R
		'
		'Horizontal_Meter_Xvalue_5
		'
		Me.Horizontal_Meter_Xvalue_5.AllowDrop = True
		Me.Horizontal_Meter_Xvalue_5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Horizontal_Meter_Xvalue_5.BackColor = System.Drawing.Color.White
		Me.Horizontal_Meter_Xvalue_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Horizontal_Meter_Xvalue_5.Location = New System.Drawing.Point(6, 254)
		Me.Horizontal_Meter_Xvalue_5.Margin = New System.Windows.Forms.Padding(6)
		Me.Horizontal_Meter_Xvalue_5.ModuleNumber = 0R
		Me.Horizontal_Meter_Xvalue_5.Name = "Horizontal_Meter_Xvalue_5"
		Me.Horizontal_Meter_Xvalue_5.Size = New System.Drawing.Size(249, 50)
		Me.Horizontal_Meter_Xvalue_5.TabIndex = 130
		Me.Horizontal_Meter_Xvalue_5.Title_To_Display = "PK 5"
		Me.Horizontal_Meter_Xvalue_5.Value_To_Display = 0R
		'
		'Horizontal_Meter_Xvalue_4
		'
		Me.Horizontal_Meter_Xvalue_4.AllowDrop = True
		Me.Horizontal_Meter_Xvalue_4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Horizontal_Meter_Xvalue_4.BackColor = System.Drawing.Color.White
		Me.Horizontal_Meter_Xvalue_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Horizontal_Meter_Xvalue_4.Location = New System.Drawing.Point(6, 192)
		Me.Horizontal_Meter_Xvalue_4.Margin = New System.Windows.Forms.Padding(6)
		Me.Horizontal_Meter_Xvalue_4.ModuleNumber = 0R
		Me.Horizontal_Meter_Xvalue_4.Name = "Horizontal_Meter_Xvalue_4"
		Me.Horizontal_Meter_Xvalue_4.Size = New System.Drawing.Size(249, 50)
		Me.Horizontal_Meter_Xvalue_4.TabIndex = 130
		Me.Horizontal_Meter_Xvalue_4.Title_To_Display = "PK 4"
		Me.Horizontal_Meter_Xvalue_4.Value_To_Display = 0R
		'
		'Horizontal_Meter_Xvalue_3
		'
		Me.Horizontal_Meter_Xvalue_3.AllowDrop = True
		Me.Horizontal_Meter_Xvalue_3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Horizontal_Meter_Xvalue_3.BackColor = System.Drawing.Color.White
		Me.Horizontal_Meter_Xvalue_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Horizontal_Meter_Xvalue_3.Location = New System.Drawing.Point(6, 130)
		Me.Horizontal_Meter_Xvalue_3.Margin = New System.Windows.Forms.Padding(6)
		Me.Horizontal_Meter_Xvalue_3.ModuleNumber = 0R
		Me.Horizontal_Meter_Xvalue_3.Name = "Horizontal_Meter_Xvalue_3"
		Me.Horizontal_Meter_Xvalue_3.Size = New System.Drawing.Size(249, 50)
		Me.Horizontal_Meter_Xvalue_3.TabIndex = 130
		Me.Horizontal_Meter_Xvalue_3.Title_To_Display = "PK 3"
		Me.Horizontal_Meter_Xvalue_3.Value_To_Display = 0R
		'
		'Horizontal_Meter_Xvalue_2
		'
		Me.Horizontal_Meter_Xvalue_2.AllowDrop = True
		Me.Horizontal_Meter_Xvalue_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Horizontal_Meter_Xvalue_2.BackColor = System.Drawing.Color.White
		Me.Horizontal_Meter_Xvalue_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Horizontal_Meter_Xvalue_2.Location = New System.Drawing.Point(6, 68)
		Me.Horizontal_Meter_Xvalue_2.Margin = New System.Windows.Forms.Padding(6)
		Me.Horizontal_Meter_Xvalue_2.ModuleNumber = 0R
		Me.Horizontal_Meter_Xvalue_2.Name = "Horizontal_Meter_Xvalue_2"
		Me.Horizontal_Meter_Xvalue_2.Size = New System.Drawing.Size(249, 50)
		Me.Horizontal_Meter_Xvalue_2.TabIndex = 130
		Me.Horizontal_Meter_Xvalue_2.Title_To_Display = "PK 2"
		Me.Horizontal_Meter_Xvalue_2.Value_To_Display = 0R
		'
		'Horizontal_Meter_Xvalue_1
		'
		Me.Horizontal_Meter_Xvalue_1.AllowDrop = True
		Me.Horizontal_Meter_Xvalue_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Horizontal_Meter_Xvalue_1.BackColor = System.Drawing.Color.White
		Me.Horizontal_Meter_Xvalue_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Horizontal_Meter_Xvalue_1.Location = New System.Drawing.Point(6, 6)
		Me.Horizontal_Meter_Xvalue_1.Margin = New System.Windows.Forms.Padding(6)
		Me.Horizontal_Meter_Xvalue_1.ModuleNumber = 0R
		Me.Horizontal_Meter_Xvalue_1.Name = "Horizontal_Meter_Xvalue_1"
		Me.Horizontal_Meter_Xvalue_1.Size = New System.Drawing.Size(249, 50)
		Me.Horizontal_Meter_Xvalue_1.TabIndex = 128
		Me.Horizontal_Meter_Xvalue_1.Title_To_Display = "PK 1"
		Me.Horizontal_Meter_Xvalue_1.Value_To_Display = 0R
		'
		'Horizontal_Meter_Marker_Level_1
		'
		Me.Horizontal_Meter_Marker_Level_1.AllowDrop = True
		Me.Horizontal_Meter_Marker_Level_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Horizontal_Meter_Marker_Level_1.BackColor = System.Drawing.Color.White
		Me.Horizontal_Meter_Marker_Level_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Horizontal_Meter_Marker_Level_1.Location = New System.Drawing.Point(267, 6)
		Me.Horizontal_Meter_Marker_Level_1.Margin = New System.Windows.Forms.Padding(6)
		Me.Horizontal_Meter_Marker_Level_1.ModuleNumber = 0R
		Me.Horizontal_Meter_Marker_Level_1.Name = "Horizontal_Meter_Marker_Level_1"
		Me.Horizontal_Meter_Marker_Level_1.Size = New System.Drawing.Size(250, 50)
		Me.Horizontal_Meter_Marker_Level_1.TabIndex = 126
		Me.Horizontal_Meter_Marker_Level_1.Title_To_Display = Nothing
		Me.Horizontal_Meter_Marker_Level_1.Value_To_Display = 0R
		'
		'Horizontal_Meter_Marker_Level_2
		'
		Me.Horizontal_Meter_Marker_Level_2.AllowDrop = True
		Me.Horizontal_Meter_Marker_Level_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Horizontal_Meter_Marker_Level_2.BackColor = System.Drawing.Color.White
		Me.Horizontal_Meter_Marker_Level_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Horizontal_Meter_Marker_Level_2.Location = New System.Drawing.Point(267, 68)
		Me.Horizontal_Meter_Marker_Level_2.Margin = New System.Windows.Forms.Padding(6)
		Me.Horizontal_Meter_Marker_Level_2.ModuleNumber = 0R
		Me.Horizontal_Meter_Marker_Level_2.Name = "Horizontal_Meter_Marker_Level_2"
		Me.Horizontal_Meter_Marker_Level_2.Size = New System.Drawing.Size(250, 50)
		Me.Horizontal_Meter_Marker_Level_2.TabIndex = 130
		Me.Horizontal_Meter_Marker_Level_2.Title_To_Display = Nothing
		Me.Horizontal_Meter_Marker_Level_2.Value_To_Display = 0R
		'
		'Horizontal_Meter_Marker_Level_3
		'
		Me.Horizontal_Meter_Marker_Level_3.AllowDrop = True
		Me.Horizontal_Meter_Marker_Level_3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Horizontal_Meter_Marker_Level_3.BackColor = System.Drawing.Color.White
		Me.Horizontal_Meter_Marker_Level_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Horizontal_Meter_Marker_Level_3.Location = New System.Drawing.Point(267, 130)
		Me.Horizontal_Meter_Marker_Level_3.Margin = New System.Windows.Forms.Padding(6)
		Me.Horizontal_Meter_Marker_Level_3.ModuleNumber = 0R
		Me.Horizontal_Meter_Marker_Level_3.Name = "Horizontal_Meter_Marker_Level_3"
		Me.Horizontal_Meter_Marker_Level_3.Size = New System.Drawing.Size(250, 50)
		Me.Horizontal_Meter_Marker_Level_3.TabIndex = 130
		Me.Horizontal_Meter_Marker_Level_3.Title_To_Display = Nothing
		Me.Horizontal_Meter_Marker_Level_3.Value_To_Display = 0R
		'
		'Horizontal_Meter_Marker_Level_4
		'
		Me.Horizontal_Meter_Marker_Level_4.AllowDrop = True
		Me.Horizontal_Meter_Marker_Level_4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Horizontal_Meter_Marker_Level_4.BackColor = System.Drawing.Color.White
		Me.Horizontal_Meter_Marker_Level_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Horizontal_Meter_Marker_Level_4.Location = New System.Drawing.Point(267, 192)
		Me.Horizontal_Meter_Marker_Level_4.Margin = New System.Windows.Forms.Padding(6)
		Me.Horizontal_Meter_Marker_Level_4.ModuleNumber = 0R
		Me.Horizontal_Meter_Marker_Level_4.Name = "Horizontal_Meter_Marker_Level_4"
		Me.Horizontal_Meter_Marker_Level_4.Size = New System.Drawing.Size(250, 50)
		Me.Horizontal_Meter_Marker_Level_4.TabIndex = 130
		Me.Horizontal_Meter_Marker_Level_4.Title_To_Display = Nothing
		Me.Horizontal_Meter_Marker_Level_4.Value_To_Display = 0R
		'
		'Horizontal_Meter_Marker_Level_5
		'
		Me.Horizontal_Meter_Marker_Level_5.AllowDrop = True
		Me.Horizontal_Meter_Marker_Level_5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Horizontal_Meter_Marker_Level_5.BackColor = System.Drawing.Color.White
		Me.Horizontal_Meter_Marker_Level_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Horizontal_Meter_Marker_Level_5.Location = New System.Drawing.Point(267, 254)
		Me.Horizontal_Meter_Marker_Level_5.Margin = New System.Windows.Forms.Padding(6)
		Me.Horizontal_Meter_Marker_Level_5.ModuleNumber = 0R
		Me.Horizontal_Meter_Marker_Level_5.Name = "Horizontal_Meter_Marker_Level_5"
		Me.Horizontal_Meter_Marker_Level_5.Size = New System.Drawing.Size(250, 50)
		Me.Horizontal_Meter_Marker_Level_5.TabIndex = 130
		Me.Horizontal_Meter_Marker_Level_5.Title_To_Display = Nothing
		Me.Horizontal_Meter_Marker_Level_5.Value_To_Display = 0R
		'
		'Horizontal_Meter_Marker_Level_6
		'
		Me.Horizontal_Meter_Marker_Level_6.AllowDrop = True
		Me.Horizontal_Meter_Marker_Level_6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Horizontal_Meter_Marker_Level_6.BackColor = System.Drawing.Color.White
		Me.Horizontal_Meter_Marker_Level_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Horizontal_Meter_Marker_Level_6.Location = New System.Drawing.Point(267, 316)
		Me.Horizontal_Meter_Marker_Level_6.Margin = New System.Windows.Forms.Padding(6)
		Me.Horizontal_Meter_Marker_Level_6.ModuleNumber = 0R
		Me.Horizontal_Meter_Marker_Level_6.Name = "Horizontal_Meter_Marker_Level_6"
		Me.Horizontal_Meter_Marker_Level_6.Size = New System.Drawing.Size(250, 51)
		Me.Horizontal_Meter_Marker_Level_6.TabIndex = 130
		Me.Horizontal_Meter_Marker_Level_6.Title_To_Display = Nothing
		Me.Horizontal_Meter_Marker_Level_6.Value_To_Display = 0R
		'
		'Button_Get_Trace
		'
		Me.Button_Get_Trace.BackColor = System.Drawing.SystemColors.GrayText
		Me.Button_Get_Trace.Location = New System.Drawing.Point(1160, 659)
		Me.Button_Get_Trace.Name = "Button_Get_Trace"
		Me.Button_Get_Trace.Size = New System.Drawing.Size(85, 271)
		Me.Button_Get_Trace.TabIndex = 130
		Me.Button_Get_Trace.Text = "GET TRACE"
		Me.Button_Get_Trace.UseVisualStyleBackColor = False
		'
		'Button_PreAmp
		'
		Me.Button_PreAmp.BackColor = System.Drawing.Color.Gray
		Me.Button_PreAmp.Location = New System.Drawing.Point(1330, 659)
		Me.Button_PreAmp.Name = "Button_PreAmp"
		Me.Button_PreAmp.Size = New System.Drawing.Size(85, 271)
		Me.Button_PreAmp.TabIndex = 131
		Me.Button_PreAmp.Text = "Preamp"
		Me.Button_PreAmp.UseVisualStyleBackColor = False
		'
		'Spectrum_Chart_X10
		'
		Me.Spectrum_Chart_X10.BackColor = System.Drawing.Color.DimGray
		Me.Spectrum_Chart_X10.BackImageTransparentColor = System.Drawing.Color.Silver
		ChartArea2.Name = "ChartArea1"
		Me.Spectrum_Chart_X10.ChartAreas.Add(ChartArea2)
		Me.Spectrum_Chart_X10.Cursor = System.Windows.Forms.Cursors.Cross
		Me.Spectrum_Chart_X10.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Spectrum_Chart_X10.Location = New System.Drawing.Point(74, 217)
		Me.Spectrum_Chart_X10.Name = "Spectrum_Chart_X10"
		Series2.ChartArea = "ChartArea1"
		Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
		Series2.Color = System.Drawing.Color.LightGray
		Series2.Name = "Series1"
		Series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale
		Me.Spectrum_Chart_X10.Series.Add(Series2)
		Me.Spectrum_Chart_X10.Size = New System.Drawing.Size(263, 208)
		Me.Spectrum_Chart_X10.TabIndex = 132
		Me.Spectrum_Chart_X10.Text = "Chart1"
		'
		'Spectrum_Chart_X100
		'
		Me.Spectrum_Chart_X100.BackColor = System.Drawing.Color.DimGray
		Me.Spectrum_Chart_X100.BackImageTransparentColor = System.Drawing.Color.Silver
		ChartArea3.Name = "ChartArea1"
		Me.Spectrum_Chart_X100.ChartAreas.Add(ChartArea3)
		Me.Spectrum_Chart_X100.Cursor = System.Windows.Forms.Cursors.Cross
		Me.Spectrum_Chart_X100.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Spectrum_Chart_X100.Location = New System.Drawing.Point(74, 431)
		Me.Spectrum_Chart_X100.Name = "Spectrum_Chart_X100"
		Series3.ChartArea = "ChartArea1"
		Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
		Series3.Color = System.Drawing.Color.LightGray
		Series3.Name = "Series1"
		Series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale
		Me.Spectrum_Chart_X100.Series.Add(Series3)
		Me.Spectrum_Chart_X100.Size = New System.Drawing.Size(263, 208)
		Me.Spectrum_Chart_X100.TabIndex = 133
		Me.Spectrum_Chart_X100.Text = "Chart1"
		'
		'Spectrum_Chart
		'
		Me.Spectrum_Chart.BackColor = System.Drawing.Color.DimGray
		Me.Spectrum_Chart.BackImageTransparentColor = System.Drawing.Color.Silver
		ChartArea4.Name = "ChartArea1"
		Me.Spectrum_Chart.ChartAreas.Add(ChartArea4)
		Me.Spectrum_Chart.Cursor = System.Windows.Forms.Cursors.Cross
		Me.Spectrum_Chart.Location = New System.Drawing.Point(450, 15)
		Me.Spectrum_Chart.Name = "Spectrum_Chart"
		Me.Spectrum_Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale
		Series4.ChartArea = "ChartArea1"
		Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area
		Series4.Color = System.Drawing.Color.LightGray
		Series4.Name = "Series1"
		Series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale
		Me.Spectrum_Chart.Series.Add(Series4)
		Me.Spectrum_Chart.Size = New System.Drawing.Size(711, 551)
		Me.Spectrum_Chart.TabIndex = 134
		Me.Spectrum_Chart.Text = "Chart1"
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.ColumnCount = 2
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.14286!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.85714!))
		Me.TableLayoutPanel2.Controls.Add(Me.Button_Get_DIV_100, 0, 2)
		Me.TableLayoutPanel2.Controls.Add(Me.Spectrum_Chart_X10, 1, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.Spectrum_Chart_X100, 1, 2)
		Me.TableLayoutPanel2.Controls.Add(Me.Spectrum_Chart_X2, 1, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Button_Get_DIV_10, 0, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.Button_Get_X2, 0, 0)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(1330, 27)
		Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 3
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(340, 642)
		Me.TableLayoutPanel2.TabIndex = 136
		'
		'Button_Get_DIV_100
		'
		Me.Button_Get_DIV_100.BackColor = System.Drawing.SystemColors.GrayText
		Me.Button_Get_DIV_100.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Button_Get_DIV_100.Location = New System.Drawing.Point(3, 431)
		Me.Button_Get_DIV_100.Name = "Button_Get_DIV_100"
		Me.Button_Get_DIV_100.Size = New System.Drawing.Size(65, 208)
		Me.Button_Get_DIV_100.TabIndex = 138
		Me.Button_Get_DIV_100.Text = "Very Zoomed in "
		Me.Button_Get_DIV_100.UseVisualStyleBackColor = False
		'
		'Button_Get_DIV_10
		'
		Me.Button_Get_DIV_10.BackColor = System.Drawing.SystemColors.GrayText
		Me.Button_Get_DIV_10.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Button_Get_DIV_10.Location = New System.Drawing.Point(3, 217)
		Me.Button_Get_DIV_10.Name = "Button_Get_DIV_10"
		Me.Button_Get_DIV_10.Size = New System.Drawing.Size(65, 208)
		Me.Button_Get_DIV_10.TabIndex = 138
		Me.Button_Get_DIV_10.Text = "Zoomed in "
		Me.Button_Get_DIV_10.UseVisualStyleBackColor = False
		'
		'Button_Get_X2
		'
		Me.Button_Get_X2.BackColor = System.Drawing.SystemColors.GrayText
		Me.Button_Get_X2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Button_Get_X2.Location = New System.Drawing.Point(3, 3)
		Me.Button_Get_X2.Name = "Button_Get_X2"
		Me.Button_Get_X2.Size = New System.Drawing.Size(65, 208)
		Me.Button_Get_X2.TabIndex = 138
		Me.Button_Get_X2.Text = "ZOOMED OUT "
		Me.Button_Get_X2.UseVisualStyleBackColor = False
		'
		'TrackBar_Freq_Center_Minor
		'
		Me.TrackBar_Freq_Center_Minor.BackColor = System.Drawing.SystemColors.InfoText
		Me.TrackBar_Freq_Center_Minor.Location = New System.Drawing.Point(256, 747)
		Me.TrackBar_Freq_Center_Minor.Maximum = 999
		Me.TrackBar_Freq_Center_Minor.Name = "TrackBar_Freq_Center_Minor"
		Me.TrackBar_Freq_Center_Minor.Size = New System.Drawing.Size(161, 45)
		Me.TrackBar_Freq_Center_Minor.SmallChange = 50
		Me.TrackBar_Freq_Center_Minor.TabIndex = 137
		Me.TrackBar_Freq_Center_Minor.Value = 1
		'
		'TextBox_Device_IP
		'
		Me.TextBox_Device_IP.Location = New System.Drawing.Point(412, 30)
		Me.TextBox_Device_IP.Name = "TextBox_Device_IP"
		Me.TextBox_Device_IP.Size = New System.Drawing.Size(100, 20)
		Me.TextBox_Device_IP.TabIndex = 125
		Me.TextBox_Device_IP.Text = "44.44.44.111"
		'
		'Button_High_Sensitivity
		'
		Me.Button_High_Sensitivity.Location = New System.Drawing.Point(1418, 659)
		Me.Button_High_Sensitivity.Name = "Button_High_Sensitivity"
		Me.Button_High_Sensitivity.Size = New System.Drawing.Size(75, 271)
		Me.Button_High_Sensitivity.TabIndex = 139
		Me.Button_High_Sensitivity.Text = "Button_High_Sensitivity"
		Me.Button_High_Sensitivity.UseVisualStyleBackColor = True
		'
		'Horizontal_Meter_Freq_Center
		'
		Me.Horizontal_Meter_Freq_Center.AllowDrop = True
		Me.Horizontal_Meter_Freq_Center.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Horizontal_Meter_Freq_Center.BackColor = System.Drawing.Color.White
		Me.Horizontal_Meter_Freq_Center.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Horizontal_Meter_Freq_Center.Location = New System.Drawing.Point(36, 674)
		Me.Horizontal_Meter_Freq_Center.Margin = New System.Windows.Forms.Padding(6)
		Me.Horizontal_Meter_Freq_Center.ModuleNumber = 0R
		Me.Horizontal_Meter_Freq_Center.Name = "Horizontal_Meter_Freq_Center"
		Me.Horizontal_Meter_Freq_Center.Size = New System.Drawing.Size(443, 64)
		Me.Horizontal_Meter_Freq_Center.TabIndex = 38
		Me.Horizontal_Meter_Freq_Center.Title_To_Display = "Center"
		Me.Horizontal_Meter_Freq_Center.Value_To_Display = 0R
		'
		'Horizontal_Meter_With_Text1
		'
		Me.Horizontal_Meter_With_Text1.AllowDrop = True
		Me.Horizontal_Meter_With_Text1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Horizontal_Meter_With_Text1.BackColor = System.Drawing.Color.Black
		Me.Horizontal_Meter_With_Text1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Horizontal_Meter_With_Text1.Location = New System.Drawing.Point(36, 835)
		Me.Horizontal_Meter_With_Text1.Margin = New System.Windows.Forms.Padding(6)
		Me.Horizontal_Meter_With_Text1.ModuleNumber = 100.0R
		Me.Horizontal_Meter_With_Text1.Name = "Horizontal_Meter_With_Text1"
		Me.Horizontal_Meter_With_Text1.Size = New System.Drawing.Size(443, 60)
		Me.Horizontal_Meter_With_Text1.TabIndex = 39
		Me.Horizontal_Meter_With_Text1.Tag = "span"
		Me.Horizontal_Meter_With_Text1.Title_To_Display = "Span"
		Me.Horizontal_Meter_With_Text1.Value_To_Display = 100.0R
		'
		'TrackBar1
		'
		Me.TrackBar1.BackColor = System.Drawing.SystemColors.InfoText
		Me.TrackBar1.LargeChange = 50
		Me.TrackBar1.Location = New System.Drawing.Point(260, 911)
		Me.TrackBar1.Maximum = 1000
		Me.TrackBar1.Minimum = 1
		Me.TrackBar1.Name = "TrackBar1"
		Me.TrackBar1.Size = New System.Drawing.Size(146, 45)
		Me.TrackBar1.TabIndex = 140
		Me.TrackBar1.Value = 100
		'
		'spectrum_BusinessLogic
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.InfoText
		Me.BackgroundImage = Global.APK_Bench_Software.My.Resources.Resources.moon
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.ClientSize = New System.Drawing.Size(1818, 1019)
		Me.Controls.Add(Me.TrackBar1)
		Me.Controls.Add(Me.Button_High_Sensitivity)
		Me.Controls.Add(Me.TextBox_Device_IP)
		Me.Controls.Add(Me.Button_Save_CSV)
		Me.Controls.Add(Me.TrackBar_Freq_Center_Minor)
		Me.Controls.Add(Me.TableLayoutPanel2)
		Me.Controls.Add(Me.Button_PreAmp)
		Me.Controls.Add(Me.SA_Unit)
		Me.Controls.Add(Me.Button_Averaging)
		Me.Controls.Add(Me.Button_Get_Trace)
		Me.Controls.Add(Me.TableLayoutPanel1)
		Me.Controls.Add(Me.Textbox_StartFreq)
		Me.Controls.Add(Me.SA_StopFreq)
		Me.Controls.Add(Me.Button_CSV_Load)
		Me.Controls.Add(Me.Button_peak_Search)
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.TrackBar_Freq_Span)
		Me.Controls.Add(Me.TrackBar_Freq_Center_Major)
		Me.Controls.Add(Me.Textbox_SA_Span)
		Me.Controls.Add(Me.Textbox_SA_Center)
		Me.Controls.Add(Me.Horizontal_Meter_Freq_Center)
		Me.Controls.Add(Me.Horizontal_Meter_With_Text1)
		Me.Controls.Add(Me.Spectrum_Chart)
		Me.Name = "spectrum_BusinessLogic"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = " "
		CType(Me.Spectrum_Chart_X2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TrackBar_Freq_Span, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage2.ResumeLayout(False)
		Me.TabPage2.PerformLayout()
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage3.ResumeLayout(False)
		CType(Me.TrackBar_Freq_Center_Major, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel1.ResumeLayout(False)
		CType(Me.Spectrum_Chart_X10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Spectrum_Chart_X100, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Spectrum_Chart, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel2.ResumeLayout(False)
		CType(Me.TrackBar_Freq_Center_Minor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Spectrum_Chart_X2 As DataVisualization.Charting.Chart
    Friend WithEvents Preset As Button
    Friend WithEvents Button3 As Button

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button_Averaging As Button
    Friend WithEvents TrackBar_Freq_Span As TrackBar
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents SA_Button_18 As Button
    Friend WithEvents SA_Button_17 As Button
    Friend WithEvents SA_Button_16 As Button
    Friend WithEvents SA_Button_15 As Button
    Friend WithEvents SA_Button_14 As Button
    Friend WithEvents SA_Button_13 As Button
    Friend WithEvents SA_Button_12 As Button
    Friend WithEvents SA_Button_11 As Button
    Friend WithEvents SA_Button_10 As Button
    Friend WithEvents SA_Button_9 As Button
    Friend WithEvents SA_Button_8 As Button
    Friend WithEvents SA_Button_7 As Button
    Friend WithEvents SA_Button_6 As Button
    Friend WithEvents SA_Button_5 As Button
    Friend WithEvents SA_Button_4 As Button
    Friend WithEvents SA_Button_3 As Button
    Friend WithEvents SA_Button_2 As Button
    Friend WithEvents SA_Button_1 As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents SA_Span_18 As TextBox
    Friend WithEvents SA_Span_17 As TextBox
    Friend WithEvents SA_Name_18 As TextBox
    Friend WithEvents SA_Name_17 As TextBox
    Friend WithEvents SA_Freq_18 As TextBox
    Friend WithEvents SA_Freq_17 As TextBox
    Friend WithEvents SA_Span_16 As TextBox
    Friend WithEvents SA_Span_15 As TextBox
    Friend WithEvents SA_Span_14 As TextBox
    Friend WithEvents SA_Span_13 As TextBox
    Friend WithEvents SA_Name_16 As TextBox
    Friend WithEvents SA_Name_15 As TextBox
    Friend WithEvents SA_Name_14 As TextBox
    Friend WithEvents SA_Name_13 As TextBox
    Friend WithEvents SA_Freq_16 As TextBox
    Friend WithEvents SA_Freq_15 As TextBox
    Friend WithEvents SA_Freq_14 As TextBox
    Friend WithEvents SA_Freq_13 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SA_Span_12 As TextBox
    Friend WithEvents SA_Span_11 As TextBox
    Friend WithEvents SA_Span_10 As TextBox
    Friend WithEvents SA_Span_9 As TextBox
    Friend WithEvents SA_Span_8 As TextBox
    Friend WithEvents SA_Span_7 As TextBox
    Friend WithEvents SA_Span_6 As TextBox
    Friend WithEvents SA_Span_5 As TextBox
    Friend WithEvents SA_Span_4 As TextBox
    Friend WithEvents SA_Span_3 As TextBox
    Friend WithEvents SA_Span_2 As TextBox
    Friend WithEvents SA_Span_1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Freq As Label
    Friend WithEvents SA_Name_12 As TextBox
    Friend WithEvents SA_Name_11 As TextBox
    Friend WithEvents SA_Name_10 As TextBox
    Friend WithEvents SA_Name_9 As TextBox
    Friend WithEvents SA_Name_8 As TextBox
    Friend WithEvents SA_Name_7 As TextBox
    Friend WithEvents SA_Name_6 As TextBox
    Friend WithEvents SA_Name_5 As TextBox
    Friend WithEvents SA_Name_4 As TextBox
    Friend WithEvents SA_Name_3 As TextBox
    Friend WithEvents SA_Name_2 As TextBox
    Friend WithEvents SA_Name_1 As TextBox
    Friend WithEvents SA_Freq_12 As TextBox
    Friend WithEvents SA_Freq_11 As TextBox
    Friend WithEvents SA_Freq_10 As TextBox
    Friend WithEvents SA_Freq_9 As TextBox
    Friend WithEvents SA_Freq_8 As TextBox
    Friend WithEvents SA_Freq_7 As TextBox
    Friend WithEvents SA_Freq_6 As TextBox
    Friend WithEvents SA_Freq_5 As TextBox
    Friend WithEvents SA_Freq_4 As TextBox
    Friend WithEvents SA_Freq_3 As TextBox
    Friend WithEvents SA_Freq_2 As TextBox
    Friend WithEvents SA_Freq_1 As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button_peak_Search As Button
    Friend WithEvents SA_StopFreq As TextBox
    Friend WithEvents Textbox_StartFreq As TextBox
    Friend WithEvents TrackBar_Freq_Center_Major As TrackBar
    Friend WithEvents Textbox_SA_Span As TextBox
    Friend WithEvents SA_Unit As TextBox
    Friend WithEvents Textbox_SA_Center As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Horizontal_Meter_Freq_Center As Horizontal_Meter_With_Text
    Friend WithEvents Button_Save_CSV As Button
    Friend WithEvents Button_CSV_Load As Button
    Friend WithEvents Horizontal_Meter_With_Text1 As Horizontal_Meter_With_Text
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer_events As Timer
    Friend WithEvents Horizontal_Meter_Marker_Level_1 As Horizontal_Meter_With_Text
    Friend WithEvents Button5 As Button
    Friend WithEvents Horizontal_Meter_Xvalue_1 As Horizontal_Meter_With_Text
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Horizontal_Meter_Marker_Level_6 As Horizontal_Meter_With_Text
    Friend WithEvents Horizontal_Meter_Marker_Level_5 As Horizontal_Meter_With_Text
    Friend WithEvents Horizontal_Meter_Marker_Level_4 As Horizontal_Meter_With_Text
    Friend WithEvents Horizontal_Meter_Marker_Level_3 As Horizontal_Meter_With_Text
    Friend WithEvents Horizontal_Meter_Marker_Level_2 As Horizontal_Meter_With_Text
    Friend WithEvents Horizontal_Meter_Xvalue_6 As Horizontal_Meter_With_Text
    Friend WithEvents Horizontal_Meter_Xvalue_5 As Horizontal_Meter_With_Text
    Friend WithEvents Horizontal_Meter_Xvalue_4 As Horizontal_Meter_With_Text
    Friend WithEvents Horizontal_Meter_Xvalue_3 As Horizontal_Meter_With_Text
    Friend WithEvents Horizontal_Meter_Xvalue_2 As Horizontal_Meter_With_Text
    Friend WithEvents Button_Get_Trace As Button
    Friend WithEvents Button_PreAmp As Button
    Friend WithEvents Spectrum_Chart_X10 As DataVisualization.Charting.Chart
    Friend WithEvents Spectrum_Chart_X100 As DataVisualization.Charting.Chart
    Friend WithEvents Spectrum_Chart As DataVisualization.Charting.Chart
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents Button_Get_DIV_100 As Button
	Friend WithEvents Button_Get_DIV_10 As Button
	Friend WithEvents Button_Get_X2 As Button
	Friend WithEvents TrackBar_Freq_Center_Minor As TrackBar
	Friend WithEvents Button_Reset_Device As Button
	Friend WithEvents TextBox_Device_IP As TextBox
	Friend WithEvents Button_High_Sensitivity As Button
	Friend WithEvents TrackBar1 As TrackBar
End Class
