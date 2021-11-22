<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RIGOLSCOPE_FORM_2
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
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Rigol_Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Rigol_update_CH2 = New System.Windows.Forms.Button()
        Me.Rigol_Data_Grid = New System.Windows.Forms.DataGridView()
        Me.Rigol_Freq_2 = New System.Windows.Forms.TextBox()
        Me.Rigol_dBm_2 = New System.Windows.Forms.TextBox()
        Me.Rigol_Vrms_2 = New System.Windows.Forms.TextBox()
        Me.Rigol_Vpp_2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ScopeDivision = New System.Windows.Forms.TrackBar()
        CType(Me.Rigol_Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rigol_Data_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScopeDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rigol_Chart
        '
        Me.Rigol_Chart.AllowDrop = True
        Me.Rigol_Chart.BackColor = System.Drawing.Color.Transparent
        Me.Rigol_Chart.BorderlineWidth = 0
        ChartArea1.Name = "ChartArea1"
        Me.Rigol_Chart.ChartAreas.Add(ChartArea1)
        Me.Rigol_Chart.Location = New System.Drawing.Point(-14, -2)
        Me.Rigol_Chart.Margin = New System.Windows.Forms.Padding(0)
        Me.Rigol_Chart.Name = "Rigol_Chart"
        Me.Rigol_Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.ChartArea = "ChartArea1"
        Series1.Name = "Series1"
        Me.Rigol_Chart.Series.Add(Series1)
        Me.Rigol_Chart.Size = New System.Drawing.Size(373, 239)
        Me.Rigol_Chart.TabIndex = 207
        Me.Rigol_Chart.Text = "Chart1"
        '
        'Rigol_update_CH2
        '
        Me.Rigol_update_CH2.Location = New System.Drawing.Point(161, 340)
        Me.Rigol_update_CH2.Name = "Rigol_update_CH2"
        Me.Rigol_update_CH2.Size = New System.Drawing.Size(75, 23)
        Me.Rigol_update_CH2.TabIndex = 208
        Me.Rigol_update_CH2.Text = "CH 2"
        Me.Rigol_update_CH2.UseVisualStyleBackColor = True
        '
        'Rigol_Data_Grid
        '
        Me.Rigol_Data_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rigol_Data_Grid.Location = New System.Drawing.Point(238, 264)
        Me.Rigol_Data_Grid.Name = "Rigol_Data_Grid"
        Me.Rigol_Data_Grid.RowHeadersVisible = False
        Me.Rigol_Data_Grid.Size = New System.Drawing.Size(95, 116)
        Me.Rigol_Data_Grid.TabIndex = 206
        '
        'Rigol_Freq_2
        '
        Me.Rigol_Freq_2.Location = New System.Drawing.Point(56, 346)
        Me.Rigol_Freq_2.Name = "Rigol_Freq_2"
        Me.Rigol_Freq_2.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Freq_2.TabIndex = 205
        Me.Rigol_Freq_2.Text = "Rigol_Freq_2"
        '
        'Rigol_dBm_2
        '
        Me.Rigol_dBm_2.Location = New System.Drawing.Point(55, 323)
        Me.Rigol_dBm_2.Name = "Rigol_dBm_2"
        Me.Rigol_dBm_2.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_dBm_2.TabIndex = 204
        Me.Rigol_dBm_2.Text = "Rigol_dBm_2"
        '
        'Rigol_Vrms_2
        '
        Me.Rigol_Vrms_2.Location = New System.Drawing.Point(55, 300)
        Me.Rigol_Vrms_2.Name = "Rigol_Vrms_2"
        Me.Rigol_Vrms_2.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Vrms_2.TabIndex = 203
        Me.Rigol_Vrms_2.Text = "Rigol_Vrms_2"
        '
        'Rigol_Vpp_2
        '
        Me.Rigol_Vpp_2.AcceptsTab = True
        Me.Rigol_Vpp_2.Location = New System.Drawing.Point(55, 276)
        Me.Rigol_Vpp_2.Name = "Rigol_Vpp_2"
        Me.Rigol_Vpp_2.Size = New System.Drawing.Size(100, 20)
        Me.Rigol_Vpp_2.TabIndex = 202
        Me.Rigol_Vpp_2.Text = "Rigol_Vpp_2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "freq"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 200
        Me.Label3.Text = "dBm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "Vrms"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 198
        Me.Label8.Text = "Vpp"
        '
        'ScopeDivision
        '
        Me.ScopeDivision.Location = New System.Drawing.Point(18, 234)
        Me.ScopeDivision.Name = "ScopeDivision"
        Me.ScopeDivision.Size = New System.Drawing.Size(295, 45)
        Me.ScopeDivision.TabIndex = 209
        '
        'RIGOLSCOPE_FORM_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 378)
        Me.Controls.Add(Me.Rigol_Chart)
        Me.Controls.Add(Me.Rigol_update_CH2)
        Me.Controls.Add(Me.Rigol_Data_Grid)
        Me.Controls.Add(Me.Rigol_Freq_2)
        Me.Controls.Add(Me.Rigol_dBm_2)
        Me.Controls.Add(Me.Rigol_Vrms_2)
        Me.Controls.Add(Me.Rigol_Vpp_2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ScopeDivision)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RIGOLSCOPE_FORM_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "RIGOLSCOPE_FORM"
        CType(Me.Rigol_Chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rigol_Data_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScopeDivision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rigol_Chart As DataVisualization.Charting.Chart
    Friend WithEvents Rigol_update_CH2 As Button
    Friend WithEvents Rigol_Data_Grid As DataGridView
    Friend WithEvents Rigol_Freq_2 As TextBox
    Friend WithEvents Rigol_dBm_2 As TextBox
    Friend WithEvents Rigol_Vrms_2 As TextBox
    Friend WithEvents Rigol_Vpp_2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ScopeDivision As TrackBar
End Class
