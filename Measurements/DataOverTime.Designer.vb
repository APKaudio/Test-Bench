<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataOverTime
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
		Me.components = New System.ComponentModel.Container()
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.Vertical_Meter1 = New APK_Bench_Software.Vertical_Meter()
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Chart1
		'
		Me.Chart1.BackColor = System.Drawing.Color.Black
		Me.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center
		Me.Chart1.BorderlineColor = System.Drawing.Color.Transparent
		ChartArea1.Name = "ChartArea1"
		Me.Chart1.ChartAreas.Add(ChartArea1)
		Legend1.Name = "Legend1"
		Me.Chart1.Legends.Add(Legend1)
		Me.Chart1.Location = New System.Drawing.Point(-14, -3)
		Me.Chart1.Name = "Chart1"
		Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale
		Series1.ChartArea = "ChartArea1"
		Series1.Legend = "Legend1"
		Series1.Name = "Series1"
		Me.Chart1.Series.Add(Series1)
		Me.Chart1.Size = New System.Drawing.Size(681, 316)
		Me.Chart1.TabIndex = 1
		Me.Chart1.Text = "Chart1"
		'
		'Vertical_Meter1
		'
		Me.Vertical_Meter1.Location = New System.Drawing.Point(808, 52)
		Me.Vertical_Meter1.ModuleNumber = 0R
		Me.Vertical_Meter1.Name = "Vertical_Meter1"
		Me.Vertical_Meter1.Plot_V1 = 0R
		Me.Vertical_Meter1.Plot_V2 = 0R
		Me.Vertical_Meter1.Plot_V3 = 0R
		Me.Vertical_Meter1.Plot_V4 = 0R
		Me.Vertical_Meter1.Size = New System.Drawing.Size(122, 317)
		Me.Vertical_Meter1.TabIndex = 2
		'
		'DataOverTime
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Vertical_Meter1)
		Me.Controls.Add(Me.Chart1)
		Me.Name = "DataOverTime"
		Me.Size = New System.Drawing.Size(944, 389)
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Chart1 As DataVisualization.Charting.Chart
	Friend WithEvents BindingSource1 As BindingSource
	Friend WithEvents Vertical_Meter1 As Vertical_Meter
End Class
