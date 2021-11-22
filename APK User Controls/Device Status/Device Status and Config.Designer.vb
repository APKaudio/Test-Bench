<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Device_Status_and_Config
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
		Me.ComboBox_Channel = New System.Windows.Forms.ComboBox()
		Me.TextBox_IP_Address = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.List_Functions = New System.Windows.Forms.ListView()
		Me.TextBox_Name = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'ComboBox_Channel
		'
		Me.ComboBox_Channel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ComboBox_Channel.FormattingEnabled = True
		Me.ComboBox_Channel.Items.AddRange(New Object() {"NO", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40"})
		Me.ComboBox_Channel.Location = New System.Drawing.Point(366, 3)
		Me.ComboBox_Channel.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.ComboBox_Channel.Name = "ComboBox_Channel"
		Me.ComboBox_Channel.Size = New System.Drawing.Size(56, 24)
		Me.ComboBox_Channel.TabIndex = 1
		'
		'TextBox_IP_Address
		'
		Me.TextBox_IP_Address.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox_IP_Address.Location = New System.Drawing.Point(226, 4)
		Me.TextBox_IP_Address.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.TextBox_IP_Address.Name = "TextBox_IP_Address"
		Me.TextBox_IP_Address.Size = New System.Drawing.Size(95, 22)
		Me.TextBox_IP_Address.TabIndex = 2
		Me.TextBox_IP_Address.Text = "IP Address"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(327, 7)
		Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(29, 16)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Ch:"
		'
		'Button1
		'
		Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(107, 2)
		Me.Button1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(114, 29)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "CONNECT"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'List_Functions
		'
		Me.List_Functions.Location = New System.Drawing.Point(453, 1)
		Me.List_Functions.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.List_Functions.Name = "List_Functions"
		Me.List_Functions.Size = New System.Drawing.Size(95, 28)
		Me.List_Functions.TabIndex = 5
		Me.List_Functions.UseCompatibleStateImageBehavior = False
		'
		'TextBox_Name
		'
		Me.TextBox_Name.Location = New System.Drawing.Point(0, 2)
		Me.TextBox_Name.Name = "TextBox_Name"
		Me.TextBox_Name.Size = New System.Drawing.Size(100, 32)
		Me.TextBox_Name.TabIndex = 6
		'
		'Device_Status_and_Config
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.TextBox_Name)
		Me.Controls.Add(Me.List_Functions)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox_IP_Address)
		Me.Controls.Add(Me.ComboBox_Channel)
		Me.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
		Me.Name = "Device_Status_and_Config"
		Me.Size = New System.Drawing.Size(572, 32)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox_Channel As ComboBox
    Friend WithEvents TextBox_IP_Address As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents List_Functions As ListView
    Friend WithEvents TextBox_Name As TextBox
End Class
