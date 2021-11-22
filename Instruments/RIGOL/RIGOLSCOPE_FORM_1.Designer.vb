<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RIGOLSCOPE_FORM_1
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Rigol_Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Rigol_update_CH1 = New System.Windows.Forms.Button()
        Me.Rigol_Data_Grid = New System.Windows.Forms.DataGridView()
        Me.Rigol_Freq_1 = New System.Windows.Forms.TextBox()
        Me.Rigol_dBm_1 = New System.Windows.Forms.TextBox()
        Me.Rigol_Vrms_1 = New System.Windows.Forms.TextBox()
        Me.Rigol_Vpp_1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ScopeDivision = New System.Windows.Forms.TrackBar()
        Me.Division_Value = New System.Windows.Forms.Label()
        Me.BandwidthLimit = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.COUPlingGND = New System.Windows.Forms.RadioButton()
        Me.COUPlingDC = New System.Windows.Forms.RadioButton()
        Me.COUPlingAC = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TimeBaseOffsetUP = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TimeBaseOffsetDOWN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        CType(Me.Rigol_Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rigol_Data_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScopeDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Rigol_Chart
        '
        Me.Rigol_Chart.AllowDrop = True
        Me.Rigol_Chart.BackColor = System.Drawing.Color.Transparent
        Me.Rigol_Chart.BorderlineWidth = 0
        ChartArea1.Name = "ChartArea1"
        Me.Rigol_Chart.ChartAreas.Add(ChartArea1)
        Me.Rigol_Chart.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Rigol_Chart.Location = New System.Drawing.Point(-14, -2)
        Me.Rigol_Chart.Margin = New System.Windows.Forms.Padding(0)
        Me.Rigol_Chart.MaximumSize = New System.Drawing.Size(373, 239)
        Me.Rigol_Chart.MinimumSize = New System.Drawing.Size(373, 239)
        Me.Rigol_Chart.Name = "Rigol_Chart"
        Me.Rigol_Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Name = "Series1"
        Me.Rigol_Chart.Series.Add(Series1)
        Me.Rigol_Chart.Size = New System.Drawing.Size(373, 239)
        Me.Rigol_Chart.TabIndex = 207
        Me.Rigol_Chart.Text = "Chart1"
        Me.Rigol_Chart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault
        '
        'Rigol_update_CH1
        '
        Me.Rigol_update_CH1.Location = New System.Drawing.Point(113, 214)
        Me.Rigol_update_CH1.Name = "Rigol_update_CH1"
        Me.Rigol_update_CH1.Size = New System.Drawing.Size(75, 23)
        Me.Rigol_update_CH1.TabIndex = 208
        Me.Rigol_update_CH1.Text = "CH 1"
        Me.Rigol_update_CH1.UseVisualStyleBackColor = True
        '
        'Rigol_Data_Grid
        '
        Me.Rigol_Data_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Rigol_Data_Grid.Location = New System.Drawing.Point(103, 2)
        Me.Rigol_Data_Grid.Name = "Rigol_Data_Grid"
        Me.Rigol_Data_Grid.RowHeadersVisible = False
        Me.Rigol_Data_Grid.Size = New System.Drawing.Size(95, 98)
        Me.Rigol_Data_Grid.TabIndex = 206
        '
        'Rigol_Freq_1
        '
        Me.Rigol_Freq_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rigol_Freq_1.Location = New System.Drawing.Point(192, 57)
        Me.Rigol_Freq_1.Name = "Rigol_Freq_1"
        Me.Rigol_Freq_1.Size = New System.Drawing.Size(110, 31)
        Me.Rigol_Freq_1.TabIndex = 205
        Me.Rigol_Freq_1.Text = "Rigol_Freq_1"
        '
        'Rigol_dBm_1
        '
        Me.Rigol_dBm_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rigol_dBm_1.Location = New System.Drawing.Point(48, 57)
        Me.Rigol_dBm_1.Name = "Rigol_dBm_1"
        Me.Rigol_dBm_1.Size = New System.Drawing.Size(97, 31)
        Me.Rigol_dBm_1.TabIndex = 204
        Me.Rigol_dBm_1.Text = "Rigol_dBm_1"
        '
        'Rigol_Vrms_1
        '
        Me.Rigol_Vrms_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rigol_Vrms_1.Location = New System.Drawing.Point(192, 20)
        Me.Rigol_Vrms_1.Name = "Rigol_Vrms_1"
        Me.Rigol_Vrms_1.Size = New System.Drawing.Size(110, 31)
        Me.Rigol_Vrms_1.TabIndex = 203
        Me.Rigol_Vrms_1.Text = "Rigol_Vrms_1"
        '
        'Rigol_Vpp_1
        '
        Me.Rigol_Vpp_1.AcceptsTab = True
        Me.Rigol_Vpp_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rigol_Vpp_1.Location = New System.Drawing.Point(48, 20)
        Me.Rigol_Vpp_1.Name = "Rigol_Vpp_1"
        Me.Rigol_Vpp_1.Size = New System.Drawing.Size(97, 31)
        Me.Rigol_Vpp_1.TabIndex = 202
        Me.Rigol_Vpp_1.Text = "Rigol_Vpp_1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "freq"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 200
        Me.Label3.Text = "dBm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "Vrms"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 198
        Me.Label8.Text = "Vpp"
        '
        'ScopeDivision
        '
        Me.ScopeDivision.LargeChange = 1
        Me.ScopeDivision.Location = New System.Drawing.Point(68, 3)
        Me.ScopeDivision.Maximum = 30
        Me.ScopeDivision.Name = "ScopeDivision"
        Me.ScopeDivision.Size = New System.Drawing.Size(199, 45)
        Me.ScopeDivision.TabIndex = 209
        Me.ScopeDivision.Value = 15
        '
        'Division_Value
        '
        Me.Division_Value.AutoSize = True
        Me.Division_Value.Location = New System.Drawing.Point(267, 15)
        Me.Division_Value.Name = "Division_Value"
        Me.Division_Value.Size = New System.Drawing.Size(39, 13)
        Me.Division_Value.TabIndex = 210
        Me.Division_Value.Text = "Label1"
        '
        'BandwidthLimit
        '
        Me.BandwidthLimit.AutoSize = True
        Me.BandwidthLimit.Location = New System.Drawing.Point(9, 69)
        Me.BandwidthLimit.Name = "BandwidthLimit"
        Me.BandwidthLimit.Size = New System.Drawing.Size(137, 17)
        Me.BandwidthLimit.TabIndex = 211
        Me.BandwidthLimit.Text = "Bandwidth Limit 20MHz"
        Me.BandwidthLimit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.COUPlingGND)
        Me.GroupBox1.Controls.Add(Me.COUPlingDC)
        Me.GroupBox1.Controls.Add(Me.COUPlingAC)
        Me.GroupBox1.Location = New System.Drawing.Point(162, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 43)
        Me.GroupBox1.TabIndex = 212
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coupling"
        '
        'COUPlingGND
        '
        Me.COUPlingGND.AutoSize = True
        Me.COUPlingGND.Location = New System.Drawing.Point(88, 16)
        Me.COUPlingGND.Name = "COUPlingGND"
        Me.COUPlingGND.Size = New System.Drawing.Size(40, 17)
        Me.COUPlingGND.TabIndex = 2
        Me.COUPlingGND.Text = "DC"
        Me.COUPlingGND.UseVisualStyleBackColor = True
        '
        'COUPlingDC
        '
        Me.COUPlingDC.AutoSize = True
        Me.COUPlingDC.Location = New System.Drawing.Point(42, 16)
        Me.COUPlingDC.Name = "COUPlingDC"
        Me.COUPlingDC.Size = New System.Drawing.Size(40, 17)
        Me.COUPlingDC.TabIndex = 1
        Me.COUPlingDC.Text = "DC"
        Me.COUPlingDC.UseVisualStyleBackColor = True
        '
        'COUPlingAC
        '
        Me.COUPlingAC.AutoSize = True
        Me.COUPlingAC.Checked = True
        Me.COUPlingAC.Location = New System.Drawing.Point(3, 16)
        Me.COUPlingAC.Name = "COUPlingAC"
        Me.COUPlingAC.Size = New System.Drawing.Size(39, 17)
        Me.COUPlingAC.TabIndex = 0
        Me.COUPlingAC.TabStop = True
        Me.COUPlingAC.Text = "AC"
        Me.COUPlingAC.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(6, 233)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(326, 132)
        Me.TabControl1.TabIndex = 213
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Rigol_Vpp_1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Rigol_Vrms_1)
        Me.TabPage1.Controls.Add(Me.Rigol_dBm_1)
        Me.TabPage1.Controls.Add(Me.Rigol_Freq_1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(318, 106)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Vitals"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TimeBaseOffsetUP)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.TimeBaseOffsetDOWN)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.BandwidthLimit)
        Me.TabPage2.Controls.Add(Me.ScopeDivision)
        Me.TabPage2.Controls.Add(Me.Division_Value)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(318, 106)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Config"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TimeBaseOffsetUP
        '
        Me.TimeBaseOffsetUP.Location = New System.Drawing.Point(86, 41)
        Me.TimeBaseOffsetUP.Name = "TimeBaseOffsetUP"
        Me.TimeBaseOffsetUP.Size = New System.Drawing.Size(29, 23)
        Me.TimeBaseOffsetUP.TabIndex = 214
        Me.TimeBaseOffsetUP.Text = ">"
        Me.TimeBaseOffsetUP.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(58, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 23)
        Me.Button2.TabIndex = 216
        Me.Button2.Text = "0"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TimeBaseOffsetDOWN
        '
        Me.TimeBaseOffsetDOWN.Location = New System.Drawing.Point(30, 41)
        Me.TimeBaseOffsetDOWN.Name = "TimeBaseOffsetDOWN"
        Me.TimeBaseOffsetDOWN.Size = New System.Drawing.Size(29, 23)
        Me.TimeBaseOffsetDOWN.TabIndex = 215
        Me.TimeBaseOffsetDOWN.Text = "<"
        Me.TimeBaseOffsetDOWN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 213
        Me.Label1.Text = "Time Scale"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.Rigol_Data_Grid)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(318, 106)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "DATA"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(213, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 207
        Me.Button1.Text = "Export to Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.update.Location = New System.Drawing.Point(257, 229)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(75, 23)
        Me.update.TabIndex = 214
        Me.update.Text = "UPDATE"
        Me.update.UseVisualStyleBackColor = False
        '
        'RIGOLSCOPE_FORM_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 605)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Rigol_Chart)
        Me.Controls.Add(Me.Rigol_update_CH1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimumSize = New System.Drawing.Size(312, 226)
        Me.Name = "RIGOLSCOPE_FORM_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "RIGOLSCOPE_FORM"
        CType(Me.Rigol_Chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rigol_Data_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScopeDivision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Rigol_Chart As DataVisualization.Charting.Chart
    Friend WithEvents Rigol_update_CH1 As Button
    Friend WithEvents Rigol_Data_Grid As DataGridView
    Friend WithEvents Rigol_Freq_1 As TextBox
    Friend WithEvents Rigol_dBm_1 As TextBox
    Friend WithEvents Rigol_Vrms_1 As TextBox
    Friend WithEvents Rigol_Vpp_1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ScopeDivision As TrackBar
    Friend WithEvents Division_Value As Label
    Friend WithEvents BandwidthLimit As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents COUPlingGND As RadioButton
    Friend WithEvents COUPlingDC As RadioButton
    Friend WithEvents COUPlingAC As RadioButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents update As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TimeBaseOffsetUP As Button
    Friend WithEvents TimeBaseOffsetDOWN As Button
    Friend WithEvents Button2 As Button
End Class
