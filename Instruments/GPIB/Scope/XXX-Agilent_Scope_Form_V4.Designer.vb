<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agilent_Scope_Form_V4
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
		Me.Scope_Data = New System.Windows.Forms.Button()
		Me.scope_Autoscale = New System.Windows.Forms.Button()
		Me.Button_FFT = New System.Windows.Forms.Button()
		Me.TextBox_FFT_END = New System.Windows.Forms.TextBox()
		Me.TextBox_FFT_Center = New System.Windows.Forms.TextBox()
		Me.TextBox_FFT_SPAN = New System.Windows.Forms.TextBox()
		Me.CheckBox_Averaging = New System.Windows.Forms.CheckBox()
		Me.TextBox_AverageCount = New System.Windows.Forms.TextBox()
		Me.TextBox_FFT_Start = New System.Windows.Forms.TextBox()
		Me.Scope_Channel_Display1 = New APK_Bench_Software.Scope_Channel_Display()
		Me.SuspendLayout()
		'
		'Scope_Data
		'
		Me.Scope_Data.Location = New System.Drawing.Point(1233, 114)
		Me.Scope_Data.Name = "Scope_Data"
		Me.Scope_Data.Size = New System.Drawing.Size(143, 102)
		Me.Scope_Data.TabIndex = 101
		Me.Scope_Data.Text = "SCOPE DATA"
		Me.Scope_Data.UseVisualStyleBackColor = True
		'
		'scope_Autoscale
		'
		Me.scope_Autoscale.Location = New System.Drawing.Point(1233, 235)
		Me.scope_Autoscale.Name = "scope_Autoscale"
		Me.scope_Autoscale.Size = New System.Drawing.Size(143, 86)
		Me.scope_Autoscale.TabIndex = 123
		Me.scope_Autoscale.Text = "Autoscale"
		Me.scope_Autoscale.UseVisualStyleBackColor = True
		'
		'Button_FFT
		'
		Me.Button_FFT.Location = New System.Drawing.Point(992, 887)
		Me.Button_FFT.Name = "Button_FFT"
		Me.Button_FFT.Size = New System.Drawing.Size(75, 23)
		Me.Button_FFT.TabIndex = 125
		Me.Button_FFT.Text = "Button1"
		Me.Button_FFT.UseVisualStyleBackColor = True
		'
		'TextBox_FFT_END
		'
		Me.TextBox_FFT_END.Location = New System.Drawing.Point(967, 812)
		Me.TextBox_FFT_END.Name = "TextBox_FFT_END"
		Me.TextBox_FFT_END.Size = New System.Drawing.Size(100, 20)
		Me.TextBox_FFT_END.TabIndex = 127
		'
		'TextBox_FFT_Center
		'
		Me.TextBox_FFT_Center.Location = New System.Drawing.Point(967, 838)
		Me.TextBox_FFT_Center.Name = "TextBox_FFT_Center"
		Me.TextBox_FFT_Center.Size = New System.Drawing.Size(100, 20)
		Me.TextBox_FFT_Center.TabIndex = 128
		Me.TextBox_FFT_Center.Text = "15"
		'
		'TextBox_FFT_SPAN
		'
		Me.TextBox_FFT_SPAN.Location = New System.Drawing.Point(967, 864)
		Me.TextBox_FFT_SPAN.Name = "TextBox_FFT_SPAN"
		Me.TextBox_FFT_SPAN.Size = New System.Drawing.Size(100, 20)
		Me.TextBox_FFT_SPAN.TabIndex = 129
		Me.TextBox_FFT_SPAN.Text = "30"
		'
		'CheckBox_Averaging
		'
		Me.CheckBox_Averaging.AutoSize = True
		Me.CheckBox_Averaging.Location = New System.Drawing.Point(1248, 91)
		Me.CheckBox_Averaging.Name = "CheckBox_Averaging"
		Me.CheckBox_Averaging.Size = New System.Drawing.Size(66, 17)
		Me.CheckBox_Averaging.TabIndex = 130
		Me.CheckBox_Averaging.Text = "Average"
		Me.CheckBox_Averaging.UseVisualStyleBackColor = True
		'
		'TextBox_AverageCount
		'
		Me.TextBox_AverageCount.Location = New System.Drawing.Point(1248, 66)
		Me.TextBox_AverageCount.Name = "TextBox_AverageCount"
		Me.TextBox_AverageCount.Size = New System.Drawing.Size(100, 20)
		Me.TextBox_AverageCount.TabIndex = 131
		Me.TextBox_AverageCount.Text = "16"
		'
		'TextBox_FFT_Start
		'
		Me.TextBox_FFT_Start.Location = New System.Drawing.Point(967, 786)
		Me.TextBox_FFT_Start.Name = "TextBox_FFT_Start"
		Me.TextBox_FFT_Start.Size = New System.Drawing.Size(100, 20)
		Me.TextBox_FFT_Start.TabIndex = 126
		'

		'
		'Agilent_Scope_Form_V4
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1450, 1006)
		Me.Controls.Add(Me.Scope_Channel_Display1)
		Me.Controls.Add(Me.TextBox_AverageCount)
		Me.Controls.Add(Me.CheckBox_Averaging)
		Me.Controls.Add(Me.TextBox_FFT_SPAN)
		Me.Controls.Add(Me.TextBox_FFT_Center)
		Me.Controls.Add(Me.TextBox_FFT_END)
		Me.Controls.Add(Me.TextBox_FFT_Start)
		Me.Controls.Add(Me.Button_FFT)
		Me.Controls.Add(Me.scope_Autoscale)
		Me.Controls.Add(Me.Scope_Data)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Agilent_Scope_Form_V4"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Agilent_Scope_Form"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Scope_Data As Button
    Friend WithEvents scope_Autoscale As Button
    Friend WithEvents Button_FFT As Button
    Friend WithEvents TextBox_FFT_END As TextBox
    Friend WithEvents TextBox_FFT_Center As TextBox
    Friend WithEvents TextBox_FFT_SPAN As TextBox
    Friend WithEvents CheckBox_Averaging As CheckBox
    Friend WithEvents TextBox_AverageCount As TextBox
	Friend WithEvents TextBox_FFT_Start As TextBox
	Friend WithEvents Scope_Channel_Display1 As Scope_Channel_Display
End Class
