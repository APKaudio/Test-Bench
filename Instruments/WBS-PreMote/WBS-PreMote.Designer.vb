<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WBS_PreMOte
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CH_ON_1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Phantom_CH_1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Gain_CH_1 = New System.Windows.Forms.VScrollBar()
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.TheirIP = New System.Windows.Forms.TextBox()
        Me.TheirPort = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MyIP = New System.Windows.Forms.TextBox()
        Me.MyPort = New System.Windows.Forms.TextBox()
        Me.cmdSend = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CH_ON_1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Phantom_CH_1)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Gain_CH_1)
        Me.GroupBox1.Controls.Add(Me.cmdConnect)
        Me.GroupBox1.Controls.Add(Me.TheirIP)
        Me.GroupBox1.Controls.Add(Me.TheirPort)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 555)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Channel 1"
        '
        'CH_ON_1
        '
        Me.CH_ON_1.Location = New System.Drawing.Point(14, 464)
        Me.CH_ON_1.Name = "CH_ON_1"
        Me.CH_ON_1.Size = New System.Drawing.Size(121, 55)
        Me.CH_ON_1.TabIndex = 5
        Me.CH_ON_1.Text = "CH ON"
        Me.CH_ON_1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "PORT:"
        '
        'Phantom_CH_1
        '
        Me.Phantom_CH_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Phantom_CH_1.Location = New System.Drawing.Point(14, 174)
        Me.Phantom_CH_1.Name = "Phantom_CH_1"
        Me.Phantom_CH_1.Size = New System.Drawing.Size(121, 23)
        Me.Phantom_CH_1.TabIndex = 4
        Me.Phantom_CH_1.Text = "48V"
        Me.Phantom_CH_1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(14, 525)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(121, 24)
        Me.ProgressBar1.TabIndex = 2
        '
        'Gain_CH_1
        '
        Me.Gain_CH_1.Location = New System.Drawing.Point(14, 200)
        Me.Gain_CH_1.Maximum = 64
        Me.Gain_CH_1.Name = "Gain_CH_1"
        Me.Gain_CH_1.Size = New System.Drawing.Size(121, 261)
        Me.Gain_CH_1.TabIndex = 1
        Me.Gain_CH_1.Value = 64
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(18, 71)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(117, 20)
        Me.cmdConnect.TabIndex = 21
        Me.cmdConnect.Text = "Connect"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        'TheirIP
        '
        Me.TheirIP.Location = New System.Drawing.Point(35, 19)
        Me.TheirIP.Name = "TheirIP"
        Me.TheirIP.Size = New System.Drawing.Size(100, 20)
        Me.TheirIP.TabIndex = 25
        Me.TheirIP.Text = "10.32.94.228"
        '
        'TheirPort
        '
        Me.TheirPort.Location = New System.Drawing.Point(67, 45)
        Me.TheirPort.Name = "TheirPort"
        Me.TheirPort.Size = New System.Drawing.Size(68, 20)
        Me.TheirPort.TabIndex = 24
        Me.TheirPort.Text = "64556"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 703)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1428, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(170, 632)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 39)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Pre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(235, 632)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 39)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Mote"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Honeydew
        Me.Label3.Location = New System.Drawing.Point(323, 632)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 39)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Control"
        '
        'PictureBox1
        '

        Me.PictureBox1.Location = New System.Drawing.Point(36, 614)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'UserName
        '
        Me.UserName.Location = New System.Drawing.Point(828, 216)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(78, 20)
        Me.UserName.TabIndex = 30
        Me.UserName.Text = "Anthony"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(299, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "PORT:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(266, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "MY IP"
        '
        'MyIP
        '
        Me.MyIP.Location = New System.Drawing.Point(308, 31)
        Me.MyIP.Name = "MyIP"
        Me.MyIP.Size = New System.Drawing.Size(100, 20)
        Me.MyIP.TabIndex = 23
        Me.MyIP.Text = "169.254.249.26"
        '
        'MyPort
        '
        Me.MyPort.Location = New System.Drawing.Point(340, 57)
        Me.MyPort.Name = "MyPort"
        Me.MyPort.Size = New System.Drawing.Size(68, 20)
        Me.MyPort.TabIndex = 22
        Me.MyPort.Text = "64555"
        '
        'cmdSend
        '
        Me.cmdSend.Location = New System.Drawing.Point(548, 422)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(71, 21)
        Me.cmdSend.TabIndex = 20
        Me.cmdSend.Text = "Send"
        Me.cmdSend.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(269, 424)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(269, 20)
        Me.txtMessage.TabIndex = 19
        '
        'txtChat
        '
        Me.txtChat.Location = New System.Drawing.Point(269, 152)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.Size = New System.Drawing.Size(350, 264)
        Me.txtChat.TabIndex = 18
        '
        'WBS_PreMOte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(1428, 725)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MyIP)
        Me.Controls.Add(Me.MyPort)
        Me.Controls.Add(Me.cmdSend)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtChat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "WBS_PreMOte"
        Me.Text = "WBS_PreMOte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CH_ON_1 As Button
    Friend WithEvents Phantom_CH_1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Gain_CH_1 As VScrollBar
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UserName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TheirIP As TextBox
    Friend WithEvents TheirPort As TextBox
    Friend WithEvents MyIP As TextBox
    Friend WithEvents MyPort As TextBox
    Friend WithEvents cmdConnect As Button
    Friend WithEvents cmdSend As Button
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents txtChat As TextBox
End Class
