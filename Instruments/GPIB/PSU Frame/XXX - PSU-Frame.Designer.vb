﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PSU_Frame
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
		Me.Button1 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(820, 103)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(91, 69)
		Me.Button1.TabIndex = 238
		Me.Button1.Text = "READ"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'PSU_Frame
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(923, 455)
		Me.Controls.Add(Me.Button1)
		Me.Name = "PSU_Frame"
		Me.Text = "PSU_Frame"
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents Button1 As Button
End Class
