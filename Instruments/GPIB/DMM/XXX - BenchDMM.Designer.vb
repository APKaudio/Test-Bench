<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BenchDMM
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
		Me.EventLog1 = New System.Diagnostics.EventLog()
		Me.Button3 = New System.Windows.Forms.Button()
		CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'EventLog1
		'
		Me.EventLog1.SynchronizingObject = Me
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(130, 645)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 23)
		Me.Button3.TabIndex = 148
		Me.Button3.Text = "Button3"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'BenchDMM
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.ClientSize = New System.Drawing.Size(556, 868)
		Me.Controls.Add(Me.Button3)
		Me.Name = "BenchDMM"
		Me.Text = "BenchDMM"
		CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents EventLog1 As EventLog
	Friend WithEvents Button3 As Button
End Class
