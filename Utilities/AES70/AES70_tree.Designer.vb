<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AES70_tree
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
		Me.inTreeNode = New System.Windows.Forms.TreeView()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'inTreeNode
		'
		Me.inTreeNode.Location = New System.Drawing.Point(3, 3)
		Me.inTreeNode.Name = "inTreeNode"
		Me.inTreeNode.Size = New System.Drawing.Size(408, 649)
		Me.inTreeNode.TabIndex = 0
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(86, 3)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'i=AES70_tree
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.inTreeNode)
		Me.Name = "i=AES70_tree"
		Me.Size = New System.Drawing.Size(448, 655)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents inTreeNode As TreeView
	Friend WithEvents Button1 As Button
End Class
