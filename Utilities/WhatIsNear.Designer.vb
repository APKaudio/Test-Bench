<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WhatIsNear
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
		Me.Button1 = New System.Windows.Forms.Button()
		Me.ListBox_Pings = New System.Windows.Forms.ListBox()
		Me.Label_MY_IP = New System.Windows.Forms.Label()
		Me.TextBox_GPIB_IP_ADDRESS = New System.Windows.Forms.TextBox()
		Me.TextBox_GPIB_BUSS = New System.Windows.Forms.TextBox()
		Me.TextBox_Rigol_IP = New System.Windows.Forms.TextBox()
		Me.TextBox_SIGNALGEN_IP = New System.Windows.Forms.TextBox()
		Me.Label_SIGNALGEN_IP = New System.Windows.Forms.Label()
		Me.label_Rigol_IP = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(186, 24)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(96, 31)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Ping"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'ListBox_Pings
		'
		Me.ListBox_Pings.FormattingEnabled = True
		Me.ListBox_Pings.Location = New System.Drawing.Point(2, 96)
		Me.ListBox_Pings.Name = "ListBox_Pings"
		Me.ListBox_Pings.Size = New System.Drawing.Size(389, 108)
		Me.ListBox_Pings.TabIndex = 1
		'
		'Label_MY_IP
		'
		Me.Label_MY_IP.AutoSize = True
		Me.Label_MY_IP.Location = New System.Drawing.Point(30, 33)
		Me.Label_MY_IP.Name = "Label_MY_IP"
		Me.Label_MY_IP.Size = New System.Drawing.Size(71, 13)
		Me.Label_MY_IP.TabIndex = 4
		Me.Label_MY_IP.Text = "Label_MY_IP"
		'
		'TextBox_GPIB_IP_ADDRESS
		'
		Me.TextBox_GPIB_IP_ADDRESS.Location = New System.Drawing.Point(145, 238)
		Me.TextBox_GPIB_IP_ADDRESS.Name = "TextBox_GPIB_IP_ADDRESS"
		Me.TextBox_GPIB_IP_ADDRESS.Size = New System.Drawing.Size(100, 20)
		Me.TextBox_GPIB_IP_ADDRESS.TabIndex = 6
		Me.TextBox_GPIB_IP_ADDRESS.Text = "192.168.11.56"
		'
		'TextBox_GPIB_BUSS
		'
		Me.TextBox_GPIB_BUSS.Location = New System.Drawing.Point(145, 264)
		Me.TextBox_GPIB_BUSS.Name = "TextBox_GPIB_BUSS"
		Me.TextBox_GPIB_BUSS.Size = New System.Drawing.Size(100, 20)
		Me.TextBox_GPIB_BUSS.TabIndex = 7
		Me.TextBox_GPIB_BUSS.Text = "gpib10"
		'
		'TextBox_Rigol_IP
		'
		Me.TextBox_Rigol_IP.Location = New System.Drawing.Point(145, 312)
		Me.TextBox_Rigol_IP.Name = "TextBox_Rigol_IP"
		Me.TextBox_Rigol_IP.Size = New System.Drawing.Size(100, 20)
		Me.TextBox_Rigol_IP.TabIndex = 8
		Me.TextBox_Rigol_IP.Text = "192.168.11.61"
		'
		'TextBox_SIGNALGEN_IP
		'
		Me.TextBox_SIGNALGEN_IP.Location = New System.Drawing.Point(145, 338)
		Me.TextBox_SIGNALGEN_IP.Name = "TextBox_SIGNALGEN_IP"
		Me.TextBox_SIGNALGEN_IP.Size = New System.Drawing.Size(100, 20)
		Me.TextBox_SIGNALGEN_IP.TabIndex = 9
		Me.TextBox_SIGNALGEN_IP.Text = "192.168.11.66"
		'
		'Label_SIGNALGEN_IP
		'
		Me.Label_SIGNALGEN_IP.AutoSize = True
		Me.Label_SIGNALGEN_IP.Location = New System.Drawing.Point(27, 345)
		Me.Label_SIGNALGEN_IP.Name = "Label_SIGNALGEN_IP"
		Me.Label_SIGNALGEN_IP.Size = New System.Drawing.Size(59, 13)
		Me.Label_SIGNALGEN_IP.TabIndex = 10
		Me.Label_SIGNALGEN_IP.Text = "Signal Gen"
		'
		'label_Rigol_IP
		'
		Me.label_Rigol_IP.AutoSize = True
		Me.label_Rigol_IP.Location = New System.Drawing.Point(27, 312)
		Me.label_Rigol_IP.Name = "label_Rigol_IP"
		Me.label_Rigol_IP.Size = New System.Drawing.Size(44, 13)
		Me.label_Rigol_IP.TabIndex = 11
		Me.label_Rigol_IP.Text = "Rigol IP"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(27, 264)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(53, 13)
		Me.Label1.TabIndex = 12
		Me.Label1.Text = "GPIB Bus"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(27, 241)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(45, 13)
		Me.Label2.TabIndex = 13
		Me.Label2.Text = "GPIB IP"
		'
		'WhatIsNear
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.label_Rigol_IP)
		Me.Controls.Add(Me.Label_SIGNALGEN_IP)
		Me.Controls.Add(Me.TextBox_SIGNALGEN_IP)
		Me.Controls.Add(Me.TextBox_Rigol_IP)
		Me.Controls.Add(Me.TextBox_GPIB_BUSS)
		Me.Controls.Add(Me.TextBox_GPIB_IP_ADDRESS)
		Me.Controls.Add(Me.Label_MY_IP)
		Me.Controls.Add(Me.ListBox_Pings)
		Me.Controls.Add(Me.Button1)
		Me.Name = "WhatIsNear"
		Me.Size = New System.Drawing.Size(391, 400)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Button1 As Button
    Friend WithEvents ListBox_Pings As ListBox
	Friend WithEvents Label_MY_IP As Label
	Friend WithEvents TextBox_GPIB_IP_ADDRESS As TextBox
	Friend WithEvents TextBox_GPIB_BUSS As TextBox
    Friend WithEvents TextBox_Rigol_IP As TextBox
    Friend WithEvents TextBox_SIGNALGEN_IP As TextBox
    Friend WithEvents Label_SIGNALGEN_IP As Label
    Friend WithEvents label_Rigol_IP As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
