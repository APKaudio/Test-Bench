<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Command_List_Form
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
		Me.Command_List_Box = New System.Windows.Forms.ListBox()
		Me.Error_List_Box = New System.Windows.Forms.ListBox()
		Me.Label_Error = New System.Windows.Forms.Label()
		Me.Label_Commands = New System.Windows.Forms.Label()
		Me.Label_Data = New System.Windows.Forms.Label()
		Me.ListBox_Data = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'Command_List_Box
		'
		Me.Command_List_Box.FormattingEnabled = True
		Me.Command_List_Box.Location = New System.Drawing.Point(0, 44)
		Me.Command_List_Box.Name = "Command_List_Box"
		Me.Command_List_Box.Size = New System.Drawing.Size(441, 472)
		Me.Command_List_Box.TabIndex = 0
		'
		'Error_List_Box
		'
		Me.Error_List_Box.FormattingEnabled = True
		Me.Error_List_Box.Location = New System.Drawing.Point(447, 44)
		Me.Error_List_Box.Name = "Error_List_Box"
		Me.Error_List_Box.Size = New System.Drawing.Size(344, 472)
		Me.Error_List_Box.TabIndex = 3
		'
		'Label_Error
		'
		Me.Label_Error.AutoSize = True
		Me.Label_Error.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label_Error.Location = New System.Drawing.Point(444, 9)
		Me.Label_Error.Name = "Label_Error"
		Me.Label_Error.Size = New System.Drawing.Size(44, 16)
		Me.Label_Error.TabIndex = 4
		Me.Label_Error.Text = "Errors"
		'
		'Label_Commands
		'
		Me.Label_Commands.AutoSize = True
		Me.Label_Commands.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label_Commands.Location = New System.Drawing.Point(0, 0)
		Me.Label_Commands.Name = "Label_Commands"
		Me.Label_Commands.Size = New System.Drawing.Size(86, 16)
		Me.Label_Commands.TabIndex = 5
		Me.Label_Commands.Text = "Configuration"
		'
		'Label_Data
		'
		Me.Label_Data.AutoSize = True
		Me.Label_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label_Data.Location = New System.Drawing.Point(805, 9)
		Me.Label_Data.Name = "Label_Data"
		Me.Label_Data.Size = New System.Drawing.Size(37, 16)
		Me.Label_Data.TabIndex = 7
		Me.Label_Data.Text = "Data"
		'
		'ListBox_Data
		'
		Me.ListBox_Data.FormattingEnabled = True
		Me.ListBox_Data.Location = New System.Drawing.Point(808, 44)
		Me.ListBox_Data.Name = "ListBox_Data"
		Me.ListBox_Data.Size = New System.Drawing.Size(344, 472)
		Me.ListBox_Data.TabIndex = 6
		'
		'Command_List_Form
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1303, 528)
		Me.Controls.Add(Me.Label_Data)
		Me.Controls.Add(Me.ListBox_Data)
		Me.Controls.Add(Me.Label_Commands)
		Me.Controls.Add(Me.Label_Error)
		Me.Controls.Add(Me.Error_List_Box)
		Me.Controls.Add(Me.Command_List_Box)
		Me.Name = "Command_List_Form"
		Me.Text = "Command_List_Form"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Command_List_Box As ListBox
	Friend WithEvents DadaDumpDataSetBindingSource As BindingSource
	Friend WithEvents Error_List_Box As ListBox
	Friend WithEvents Label_Error As Label
	Friend WithEvents Label_Commands As Label
	Friend WithEvents Label_Data As Label
	Friend WithEvents ListBox_Data As ListBox
End Class
