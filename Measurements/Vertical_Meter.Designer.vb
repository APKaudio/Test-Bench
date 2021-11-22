<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vertical_Meter
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Chart1
		'
		ChartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
		ChartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
		ChartArea1.Name = "ChartArea1"
		Me.Chart1.ChartAreas.Add(ChartArea1)
		Me.Chart1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Chart1.ImeMode = System.Windows.Forms.ImeMode.Katakana
		Me.Chart1.Location = New System.Drawing.Point(0, 0)
		Me.Chart1.Name = "Chart1"
		Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
		Series1.BorderWidth = 40
		Series1.ChartArea = "ChartArea1"
		Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick
		Series1.Color = System.Drawing.Color.Yellow
		Series1.Name = "V1"
		Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Single]
		Series1.YValuesPerPoint = 4
		Series2.BorderWidth = 30
		Series2.ChartArea = "ChartArea1"
		Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick
		Series2.Color = System.Drawing.Color.Red
		Series2.Name = "V2"
		Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Single]
		Series2.YValuesPerPoint = 4
		Series3.BorderWidth = 30
		Series3.ChartArea = "ChartArea1"
		Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick
		Series3.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
		Series3.Name = "V3"
		Series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Single]
		Series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
		Series3.YValuesPerPoint = 4
		Series4.BorderWidth = 40
		Series4.ChartArea = "ChartArea1"
		Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick
		Series4.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
		Series4.Name = "V4"
		Series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Single]
		Series4.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
		Series4.YValuesPerPoint = 4
		Me.Chart1.Series.Add(Series1)
		Me.Chart1.Series.Add(Series2)
		Me.Chart1.Series.Add(Series3)
		Me.Chart1.Series.Add(Series4)
		Me.Chart1.Size = New System.Drawing.Size(318, 478)
		Me.Chart1.TabIndex = 0
		Me.Chart1.Text = "Chart1"
		'
		'Vertical_Meter
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Chart1)
		Me.Name = "Vertical_Meter"
		Me.Size = New System.Drawing.Size(389, 526)
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
