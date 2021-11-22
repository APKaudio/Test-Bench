<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Signal_Gen_form
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
		Me.SuspendLayout()
		'
		'Signal_Gen_form
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.DarkGray
		Me.ClientSize = New System.Drawing.Size(451, 284)
		Me.Name = "Signal_Gen_form"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Signal_Gen_form"
		Me.ResumeLayout(False)

	End Sub
End Class
