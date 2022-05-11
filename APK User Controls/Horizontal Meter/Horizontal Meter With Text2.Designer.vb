<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Horizontal_Meter_With_Text
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
		Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 0R)
		Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Me.BarGraphValue_Hundred = New System.Windows.Forms.ProgressBar()
		Me.BarGraphValueMili = New System.Windows.Forms.ProgressBar()
		Me.Labelhundreds = New System.Windows.Forms.Label()
		Me.Labelmili = New System.Windows.Forms.Label()
		Me.BarGraphValueMicro = New System.Windows.Forms.ProgressBar()
		Me.Labelmicro = New System.Windows.Forms.Label()
		Me.Label_Title = New System.Windows.Forms.Label()
		Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.TimeGraphBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TimeGraphBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'BarGraphValue_Hundred
		'
		Me.BarGraphValue_Hundred.BackColor = System.Drawing.Color.Silver
		Me.BarGraphValue_Hundred.ForeColor = System.Drawing.Color.Red
		Me.BarGraphValue_Hundred.Location = New System.Drawing.Point(6, 91)
		Me.BarGraphValue_Hundred.Margin = New System.Windows.Forms.Padding(1)
		Me.BarGraphValue_Hundred.Maximum = 1000
		Me.BarGraphValue_Hundred.Name = "BarGraphValue_Hundred"
		Me.BarGraphValue_Hundred.RightToLeftLayout = True
		Me.BarGraphValue_Hundred.Size = New System.Drawing.Size(292, 53)
		Me.BarGraphValue_Hundred.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.BarGraphValue_Hundred.TabIndex = 17
		'
		'BarGraphValueMili
		'
		Me.BarGraphValueMili.BackColor = System.Drawing.Color.Silver
		Me.BarGraphValueMili.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.BarGraphValueMili.Location = New System.Drawing.Point(309, 10)
		Me.BarGraphValueMili.Margin = New System.Windows.Forms.Padding(0)
		Me.BarGraphValueMili.Maximum = 1000
		Me.BarGraphValueMili.Name = "BarGraphValueMili"
		Me.BarGraphValueMili.RightToLeftLayout = True
		Me.BarGraphValueMili.Size = New System.Drawing.Size(176, 53)
		Me.BarGraphValueMili.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.BarGraphValueMili.TabIndex = 18
		'
		'Labelhundreds
		'
		Me.Labelhundreds.AllowDrop = True
		Me.Labelhundreds.AutoSize = True
		Me.Labelhundreds.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Labelhundreds.Location = New System.Drawing.Point(3, 128)
		Me.Labelhundreds.Name = "Labelhundreds"
		Me.Labelhundreds.Size = New System.Drawing.Size(72, 16)
		Me.Labelhundreds.TabIndex = 20
		Me.Labelhundreds.Text = "hundreds"
		'
		'Labelmili
		'
		Me.Labelmili.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Labelmili.AutoSize = True
		Me.Labelmili.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Labelmili.Location = New System.Drawing.Point(320, 185)
		Me.Labelmili.Name = "Labelmili"
		Me.Labelmili.Size = New System.Drawing.Size(32, 16)
		Me.Labelmili.TabIndex = 21
		Me.Labelmili.Text = "Mili"
		'
		'BarGraphValueMicro
		'
		Me.BarGraphValueMicro.BackColor = System.Drawing.Color.Silver
		Me.BarGraphValueMicro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.BarGraphValueMicro.Location = New System.Drawing.Point(499, 22)
		Me.BarGraphValueMicro.Margin = New System.Windows.Forms.Padding(0)
		Me.BarGraphValueMicro.Maximum = 1000
		Me.BarGraphValueMicro.Name = "BarGraphValueMicro"
		Me.BarGraphValueMicro.RightToLeftLayout = True
		Me.BarGraphValueMicro.Size = New System.Drawing.Size(150, 53)
		Me.BarGraphValueMicro.Style = System.Windows.Forms.ProgressBarStyle.Continuous
		Me.BarGraphValueMicro.TabIndex = 22
		'
		'Labelmicro
		'
		Me.Labelmicro.AutoSize = True
		Me.Labelmicro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Labelmicro.Location = New System.Drawing.Point(473, 92)
		Me.Labelmicro.Name = "Labelmicro"
		Me.Labelmicro.Size = New System.Drawing.Size(46, 16)
		Me.Labelmicro.TabIndex = 23
		Me.Labelmicro.Text = "Micro"
		'
		'Label_Title
		'
		Me.Label_Title.AutoSize = True
		Me.Label_Title.Location = New System.Drawing.Point(3, 10)
		Me.Label_Title.Name = "Label_Title"
		Me.Label_Title.Size = New System.Drawing.Size(59, 13)
		Me.Label_Title.TabIndex = 16
		Me.Label_Title.Text = "Label_Title"
		Me.Label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Chart1
		'
		ChartArea1.AxisX.IsLabelAutoFit = False
		ChartArea1.AxisX.LabelAutoFitMinFontSize = 10
		ChartArea1.AxisX.MaximumAutoSize = 1.0!
		ChartArea1.AxisX2.IsLabelAutoFit = False
		ChartArea1.AxisX2.LabelAutoFitMinFontSize = 10
		ChartArea1.AxisX2.MaximumAutoSize = 1.0!
		ChartArea1.AxisY.IsLabelAutoFit = False
		ChartArea1.AxisY.LabelAutoFitMinFontSize = 10
		ChartArea1.AxisY.MaximumAutoSize = 1.0!
		ChartArea1.AxisY2.IsLabelAutoFit = False
		ChartArea1.AxisY2.LabelAutoFitMinFontSize = 10
		ChartArea1.AxisY2.MaximumAutoSize = 1.0!
		ChartArea1.Name = "ChartArea1"
		Me.Chart1.ChartAreas.Add(ChartArea1)
		Me.Chart1.DataSource = Me.TimeGraphBindingSource
		Me.Chart1.Location = New System.Drawing.Point(430, 128)
		Me.Chart1.Name = "Chart1"
		Series1.BorderWidth = 0
		Series1.ChartArea = "ChartArea1"
		Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series1.IsVisibleInLegend = False
		Series1.Name = "Series1"
		Series1.Points.Add(DataPoint1)
		Series1.SmartLabelStyle.Enabled = False
		Series2.BorderWidth = 0
		Series2.ChartArea = "ChartArea1"
		Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series2.IsVisibleInLegend = False
		Series2.Name = "Series2"
		Series2.SmartLabelStyle.Enabled = False
		Series3.BorderWidth = 0
		Series3.ChartArea = "ChartArea1"
		Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series3.IsVisibleInLegend = False
		Series3.Name = "Series3"
		Series3.SmartLabelStyle.Enabled = False
		Series4.BorderWidth = 0
		Series4.ChartArea = "ChartArea1"
		Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
		Series4.IsVisibleInLegend = False
		Series4.Name = "Series4"
		Series4.SmartLabelStyle.Enabled = False
		Me.Chart1.Series.Add(Series1)
		Me.Chart1.Series.Add(Series2)
		Me.Chart1.Series.Add(Series3)
		Me.Chart1.Series.Add(Series4)
		Me.Chart1.Size = New System.Drawing.Size(438, 65)
		Me.Chart1.TabIndex = 24
		Me.Chart1.Text = "Chart1"
		'
		'TimeGraphBindingSource
		'
		Me.TimeGraphBindingSource.DataSource = GetType(APK_Bench_Software.TimeGraph)
		'
		'Horizontal_Meter_With_Text
		'
		Me.AllowDrop = True
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.BackColor = System.Drawing.SystemColors.ControlDark
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.Chart1)
		Me.Controls.Add(Me.Labelmicro)
		Me.Controls.Add(Me.Labelmili)
		Me.Controls.Add(Me.Labelhundreds)
		Me.Controls.Add(Me.BarGraphValueMicro)
		Me.Controls.Add(Me.BarGraphValue_Hundred)
		Me.Controls.Add(Me.BarGraphValueMili)
		Me.Controls.Add(Me.Label_Title)
		Me.Name = "Horizontal_Meter_With_Text"
		Me.Size = New System.Drawing.Size(871, 201)
		CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TimeGraphBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Title As Label
    Friend WithEvents VALUE As Label
    Friend WithEvents BarGraphValue_Hundred As ProgressBar
    Friend WithEvents BarGraphValueMili As ProgressBar
    Friend WithEvents Labelhundreds As Label
    Friend WithEvents Labelmili As Label
    Friend WithEvents BarGraphValueMicro As ProgressBar
    Friend WithEvents Labelmicro As Label
    Friend WithEvents Label_Title As Label
	Friend WithEvents Chart1 As DataVisualization.Charting.Chart
	Friend WithEvents TimeGraphBindingSource As BindingSource
End Class
