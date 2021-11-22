<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Freq_Chart
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
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(10.0R, 0R)
		Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series13 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series14 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series15 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series16 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series17 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series18 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Chart_Scope = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.TrackBar2 = New System.Windows.Forms.TrackBar()
		Me.TrackBar1 = New System.Windows.Forms.TrackBar()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.Chart_PSU = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TableLayoutPanel1.SuspendLayout()
		CType(Me.Chart_Scope, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel2.SuspendLayout()
		CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabPage2.SuspendLayout()
		CType(Me.Chart_PSU, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabPage3.SuspendLayout()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Controls.Add(Me.TabPage3)
		Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl1.Location = New System.Drawing.Point(0, 0)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(1473, 968)
		Me.TabControl1.TabIndex = 9
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(1465, 942)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "TabPage1"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.ColumnCount = 3
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.815846!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.18415!))
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.Chart_Scope, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 2
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(1459, 936)
		Me.TableLayoutPanel1.TabIndex = 9
		'
		'Chart_Scope
		'
		Me.Chart_Scope.BackColor = System.Drawing.Color.DimGray
		ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
		ChartArea1.AxisX.IsLogarithmic = True
		ChartArea1.AxisX.IsStartedFromZero = False
		ChartArea1.AxisX.LabelAutoFitStyle = CType((((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) _
			Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) _
			Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) _
			Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) _
			Or System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap), System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)
		ChartArea1.AxisX.LabelStyle.Interval = 1.0R
		ChartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
		ChartArea1.AxisX.MajorGrid.Interval = 0R
		ChartArea1.AxisX.MajorGrid.LineWidth = 2
		ChartArea1.AxisX.Maximum = 50000.0R
		ChartArea1.AxisX.Minimum = 10.0R
		ChartArea1.AxisX.MinorGrid.Enabled = True
		ChartArea1.AxisX.MinorGrid.Interval = 1.0R
		ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.DimGray
		ChartArea1.AxisX.MinorTickMark.Enabled = True
		ChartArea1.AxisX.MinorTickMark.Interval = 1.0R
		ChartArea1.AxisX.MinorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
		ChartArea1.AxisY.LineWidth = 2
		ChartArea1.BackColor = System.Drawing.Color.Gray
		ChartArea1.Name = "ChartArea1"
		Me.Chart_Scope.ChartAreas.Add(ChartArea1)
		Me.Chart_Scope.Dock = System.Windows.Forms.DockStyle.Fill
		Legend1.Alignment = System.Drawing.StringAlignment.Center
		Legend1.DockedToChartArea = "ChartArea1"
		Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
		Legend1.InterlacedRows = True
		Legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
		Legend1.Name = "Legend1"
		Me.Chart_Scope.Legends.Add(Legend1)
		Me.Chart_Scope.Location = New System.Drawing.Point(115, 3)
		Me.Chart_Scope.Name = "Chart_Scope"
		Me.Chart_Scope.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
		Series1.BorderWidth = 2
		Series1.ChartArea = "ChartArea1"
		Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series1.Legend = "Legend1"
		Series1.Name = "Scope-Vrms_1"
		Series1.Points.Add(DataPoint1)
		Series1.ToolTip = "#VAL"
		Series2.BorderWidth = 2
		Series2.ChartArea = "ChartArea1"
		Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
		Series2.Legend = "Legend1"
		Series2.Name = "Scope-Vrms_2"
		Series3.BorderWidth = 2
		Series3.ChartArea = "ChartArea1"
		Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
		Series3.Legend = "Legend1"
		Series3.Name = "Scope-Vrms_3"
		Series4.BorderWidth = 2
		Series4.ChartArea = "ChartArea1"
		Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
		Series4.Legend = "Legend1"
		Series4.Name = "Scope-Vrms_4"
		Me.Chart_Scope.Series.Add(Series1)
		Me.Chart_Scope.Series.Add(Series2)
		Me.Chart_Scope.Series.Add(Series3)
		Me.Chart_Scope.Series.Add(Series4)
		Me.Chart_Scope.Size = New System.Drawing.Size(1319, 836)
		Me.Chart_Scope.TabIndex = 8
		Me.Chart_Scope.Text = "Chart2"
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.ColumnCount = 2
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel2.Controls.Add(Me.TrackBar2, 1, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.TrackBar1, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.TextBox1, 0, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.TextBox2, 1, 1)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(115, 845)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 2
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(738, 88)
		Me.TableLayoutPanel2.TabIndex = 9
		'
		'TrackBar2
		'
		Me.TrackBar2.Location = New System.Drawing.Point(372, 3)
		Me.TrackBar2.Maximum = 100
		Me.TrackBar2.Minimum = -100
		Me.TrackBar2.Name = "TrackBar2"
		Me.TrackBar2.Size = New System.Drawing.Size(221, 38)
		Me.TrackBar2.TabIndex = 1
		Me.TrackBar2.Value = 20
		'
		'TrackBar1
		'
		Me.TrackBar1.Location = New System.Drawing.Point(3, 3)
		Me.TrackBar1.Maximum = 100
		Me.TrackBar1.Minimum = -100
		Me.TrackBar1.Name = "TrackBar1"
		Me.TrackBar1.Size = New System.Drawing.Size(221, 38)
		Me.TrackBar1.TabIndex = 0
		Me.TrackBar1.Value = -100
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(3, 47)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(100, 20)
		Me.TextBox1.TabIndex = 2
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(372, 47)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(100, 20)
		Me.TextBox2.TabIndex = 3
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.Chart_PSU)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(1465, 942)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "TabPage2"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'Chart_PSU
		'
		ChartArea2.AxisX.IsStartedFromZero = False
		ChartArea2.AxisX.LineWidth = 4
		ChartArea2.AxisX.Maximum = 30000.0R
		ChartArea2.AxisX.Minimum = 50.0R
		ChartArea2.AxisX.MinorGrid.Enabled = True
		ChartArea2.Name = "ChartArea1"
		Me.Chart_PSU.ChartAreas.Add(ChartArea2)
		Me.Chart_PSU.Dock = System.Windows.Forms.DockStyle.Fill
		Legend2.Alignment = System.Drawing.StringAlignment.Far
		Legend2.DockedToChartArea = "ChartArea1"
		Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
		Legend2.InterlacedRows = True
		Legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
		Legend2.Name = "Legend1"
		Me.Chart_PSU.Legends.Add(Legend2)
		Me.Chart_PSU.Location = New System.Drawing.Point(3, 3)
		Me.Chart_PSU.Name = "Chart_PSU"
		Me.Chart_PSU.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
		Series5.ChartArea = "ChartArea1"
		Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series5.Legend = "Legend1"
		Series5.Name = "PSU1"
		Series6.ChartArea = "ChartArea1"
		Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series6.Legend = "Legend1"
		Series6.Name = "PSU2"
		Series7.ChartArea = "ChartArea1"
		Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series7.Legend = "Legend1"
		Series7.Name = "PSU3"
		Series8.ChartArea = "ChartArea1"
		Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series8.Legend = "Legend1"
		Series8.Name = "PSU4"
		Series9.ChartArea = "ChartArea1"
		Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series9.Legend = "Legend1"
		Series9.Name = "PSU5"
		Series10.ChartArea = "ChartArea1"
		Series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series10.Legend = "Legend1"
		Series10.Name = "PSU6"
		Series11.ChartArea = "ChartArea1"
		Series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series11.Legend = "Legend1"
		Series11.Name = "PSU7"
		Series12.ChartArea = "ChartArea1"
		Series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series12.Legend = "Legend1"
		Series12.Name = "PSU8"
		Me.Chart_PSU.Series.Add(Series5)
		Me.Chart_PSU.Series.Add(Series6)
		Me.Chart_PSU.Series.Add(Series7)
		Me.Chart_PSU.Series.Add(Series8)
		Me.Chart_PSU.Series.Add(Series9)
		Me.Chart_PSU.Series.Add(Series10)
		Me.Chart_PSU.Series.Add(Series11)
		Me.Chart_PSU.Series.Add(Series12)
		Me.Chart_PSU.Size = New System.Drawing.Size(1459, 936)
		Me.Chart_PSU.TabIndex = 7
		Me.Chart_PSU.Text = "Chart2"
		'
		'TabPage3
		'
		Me.TabPage3.Controls.Add(Me.Chart1)
		Me.TabPage3.Location = New System.Drawing.Point(4, 22)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage3.Size = New System.Drawing.Size(1465, 942)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "TabPage3"
		Me.TabPage3.UseVisualStyleBackColor = True
		'
		'Chart1
		'
		ChartArea3.AxisX.IsStartedFromZero = False
		ChartArea3.AxisX.Maximum = 30000.0R
		ChartArea3.AxisX.Minimum = 50.0R
		ChartArea3.AxisX.MinorGrid.Enabled = True
		ChartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.DimGray
		ChartArea3.AxisY.LineWidth = 4
		ChartArea3.Name = "ChartArea1"
		Me.Chart1.ChartAreas.Add(ChartArea3)
		Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
		Legend3.Alignment = System.Drawing.StringAlignment.Far
		Legend3.DockedToChartArea = "ChartArea1"
		Legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
		Legend3.InterlacedRows = True
		Legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column
		Legend3.Name = "Legend1"
		Me.Chart1.Legends.Add(Legend3)
		Me.Chart1.Location = New System.Drawing.Point(3, 3)
		Me.Chart1.Name = "Chart1"
		Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
		Series13.ChartArea = "ChartArea1"
		Series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series13.Legend = "Legend1"
		Series13.Name = "DMM1"
		Series14.ChartArea = "ChartArea1"
		Series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series14.Legend = "Legend1"
		Series14.Name = "DMM2"
		Series15.ChartArea = "ChartArea1"
		Series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series15.Legend = "Legend1"
		Series15.Name = "DMM3"
		Series16.ChartArea = "ChartArea1"
		Series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series16.Legend = "Legend1"
		Series16.Name = "DMM4"
		Series17.ChartArea = "ChartArea1"
		Series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series17.Legend = "Legend1"
		Series17.Name = "DMM5"
		Series18.ChartArea = "ChartArea1"
		Series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series18.Legend = "Legend1"
		Series18.Name = "DMM6"
		Me.Chart1.Series.Add(Series13)
		Me.Chart1.Series.Add(Series14)
		Me.Chart1.Series.Add(Series15)
		Me.Chart1.Series.Add(Series16)
		Me.Chart1.Series.Add(Series17)
		Me.Chart1.Series.Add(Series18)
		Me.Chart1.Size = New System.Drawing.Size(1459, 936)
		Me.Chart1.TabIndex = 1
		Me.Chart1.Text = "Chart1"
		'
		'Freq_Chart
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1473, 968)
		Me.Controls.Add(Me.TabControl1)
		Me.Name = "Freq_Chart"
		Me.Text = "Frew_Chart"
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TableLayoutPanel1.ResumeLayout(False)
		CType(Me.Chart_Scope, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabPage2.ResumeLayout(False)
		CType(Me.Chart_PSU, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabPage3.ResumeLayout(False)
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabPage1 As TabPage
	Friend WithEvents Chart_Scope As DataVisualization.Charting.Chart
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents Chart_PSU As DataVisualization.Charting.Chart
	Friend WithEvents TabPage3 As TabPage
	Friend WithEvents Chart1 As DataVisualization.Charting.Chart
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents TrackBar1 As TrackBar
	Friend WithEvents TrackBar2 As TrackBar
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
End Class
