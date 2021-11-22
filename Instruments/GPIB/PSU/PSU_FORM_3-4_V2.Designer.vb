<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PSU_FORM_34
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
        Me.PSULink = New System.Windows.Forms.CheckBox()
        Me.PSU_READ_I_4 = New System.Windows.Forms.TextBox()
        Me.PSU_READ_I_3 = New System.Windows.Forms.TextBox()
        Me.PSU_READ_V_4 = New System.Windows.Forms.TextBox()
        Me.PSU_READ_V_3 = New System.Windows.Forms.TextBox()
        Me.PSU_ON_4 = New System.Windows.Forms.Button()
        Me.PSU_ON_3 = New System.Windows.Forms.Button()
        Me.PSU_I_4 = New System.Windows.Forms.TextBox()
        Me.PSU_V_4 = New System.Windows.Forms.TextBox()
        Me.PSULabel2 = New System.Windows.Forms.Label()
        Me.PSU_I_3 = New System.Windows.Forms.TextBox()
        Me.PSU_V_3 = New System.Windows.Forms.TextBox()
        Me.PSULabel1 = New System.Windows.Forms.Label()
        Me.PSU_POWER_CALC_4 = New System.Windows.Forms.TextBox()
        Me.PSU_POWER_CALC_3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PSULink
        '
        Me.PSULink.AutoSize = True
        Me.PSULink.Location = New System.Drawing.Point(87, 57)
        Me.PSULink.Name = "PSULink"
        Me.PSULink.Size = New System.Drawing.Size(50, 17)
        Me.PSULink.TabIndex = 142
        Me.PSULink.Text = "LINK"
        Me.PSULink.UseVisualStyleBackColor = True
        '
        'PSU_READ_I_4
        '
        Me.PSU_READ_I_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PSU_READ_I_4.Location = New System.Drawing.Point(95, 191)
        Me.PSU_READ_I_4.Name = "PSU_READ_I_4"
        Me.PSU_READ_I_4.Size = New System.Drawing.Size(84, 26)
        Me.PSU_READ_I_4.TabIndex = 155
        Me.PSU_READ_I_4.Text = "PSU_READ_I_2"
        '
        'PSU_READ_I_3
        '
        Me.PSU_READ_I_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PSU_READ_I_3.Location = New System.Drawing.Point(7, 191)
        Me.PSU_READ_I_3.Name = "PSU_READ_I_3"
        Me.PSU_READ_I_3.Size = New System.Drawing.Size(83, 26)
        Me.PSU_READ_I_3.TabIndex = 154
        Me.PSU_READ_I_3.Text = "PSU_READ_I_1"
        '
        'PSU_READ_V_4
        '
        Me.PSU_READ_V_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PSU_READ_V_4.Location = New System.Drawing.Point(95, 161)
        Me.PSU_READ_V_4.Name = "PSU_READ_V_4"
        Me.PSU_READ_V_4.Size = New System.Drawing.Size(84, 26)
        Me.PSU_READ_V_4.TabIndex = 153
        Me.PSU_READ_V_4.Text = "PSU_READ_V_4"
        '
        'PSU_READ_V_3
        '
        Me.PSU_READ_V_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PSU_READ_V_3.Location = New System.Drawing.Point(7, 161)
        Me.PSU_READ_V_3.Name = "PSU_READ_V_3"
        Me.PSU_READ_V_3.Size = New System.Drawing.Size(83, 26)
        Me.PSU_READ_V_3.TabIndex = 152
        Me.PSU_READ_V_3.Text = "PSU_READ_V_3"
        '
        'PSU_ON_4
        '
        Me.PSU_ON_4.Location = New System.Drawing.Point(95, 111)
        Me.PSU_ON_4.Name = "PSU_ON_4"
        Me.PSU_ON_4.Size = New System.Drawing.Size(84, 44)
        Me.PSU_ON_4.TabIndex = 151
        Me.PSU_ON_4.Text = "ON"
        Me.PSU_ON_4.UseVisualStyleBackColor = True
        '
        'PSU_ON_3
        '
        Me.PSU_ON_3.Location = New System.Drawing.Point(7, 111)
        Me.PSU_ON_3.Name = "PSU_ON_3"
        Me.PSU_ON_3.Size = New System.Drawing.Size(83, 44)
        Me.PSU_ON_3.TabIndex = 150
        Me.PSU_ON_3.Text = "ON"
        Me.PSU_ON_3.UseVisualStyleBackColor = True
        '
        'PSU_I_4
        '
        Me.PSU_I_4.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSU_I_4.Location = New System.Drawing.Point(95, 74)
        Me.PSU_I_4.Name = "PSU_I_4"
        Me.PSU_I_4.Size = New System.Drawing.Size(84, 34)
        Me.PSU_I_4.TabIndex = 147
        Me.PSU_I_4.Text = ".3"
        '
        'PSU_V_4
        '
        Me.PSU_V_4.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSU_V_4.Location = New System.Drawing.Point(96, 22)
        Me.PSU_V_4.Name = "PSU_V_4"
        Me.PSU_V_4.Size = New System.Drawing.Size(83, 34)
        Me.PSU_V_4.TabIndex = 146
        Me.PSU_V_4.Text = "25"
        '
        'PSULabel2
        '
        Me.PSULabel2.AutoSize = True
        Me.PSULabel2.Location = New System.Drawing.Point(93, 6)
        Me.PSULabel2.Name = "PSULabel2"
        Me.PSULabel2.Size = New System.Drawing.Size(38, 13)
        Me.PSULabel2.TabIndex = 145
        Me.PSULabel2.Text = "PSU 4"
        '
        'PSU_I_3
        '
        Me.PSU_I_3.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSU_I_3.Location = New System.Drawing.Point(7, 74)
        Me.PSU_I_3.Name = "PSU_I_3"
        Me.PSU_I_3.Size = New System.Drawing.Size(83, 34)
        Me.PSU_I_3.TabIndex = 144
        Me.PSU_I_3.Text = ".3"
        '
        'PSU_V_3
        '
        Me.PSU_V_3.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PSU_V_3.Location = New System.Drawing.Point(7, 22)
        Me.PSU_V_3.Name = "PSU_V_3"
        Me.PSU_V_3.Size = New System.Drawing.Size(83, 34)
        Me.PSU_V_3.TabIndex = 143
        Me.PSU_V_3.Text = "25"
        '
        'PSULabel1
        '
        Me.PSULabel1.AutoSize = True
        Me.PSULabel1.Location = New System.Drawing.Point(4, 6)
        Me.PSULabel1.Name = "PSULabel1"
        Me.PSULabel1.Size = New System.Drawing.Size(38, 13)
        Me.PSULabel1.TabIndex = 141
        Me.PSULabel1.Text = "PSU 3"
        '
        'PSU_POWER_CALC_4
        '
        Me.PSU_POWER_CALC_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PSU_POWER_CALC_4.Location = New System.Drawing.Point(95, 221)
        Me.PSU_POWER_CALC_4.Name = "PSU_POWER_CALC_4"
        Me.PSU_POWER_CALC_4.Size = New System.Drawing.Size(84, 26)
        Me.PSU_POWER_CALC_4.TabIndex = 157
        Me.PSU_POWER_CALC_4.Text = "PSU_POWER_CALC_4"
        '
        'PSU_POWER_CALC_3
        '
        Me.PSU_POWER_CALC_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PSU_POWER_CALC_3.Location = New System.Drawing.Point(7, 221)
        Me.PSU_POWER_CALC_3.Name = "PSU_POWER_CALC_3"
        Me.PSU_POWER_CALC_3.Size = New System.Drawing.Size(83, 26)
        Me.PSU_POWER_CALC_3.TabIndex = 156
        Me.PSU_POWER_CALC_3.Text = "PSU_POWER_CALC_3"
        '
        'PSU_FORM_34
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(184, 261)
        Me.Controls.Add(Me.PSU_POWER_CALC_4)
        Me.Controls.Add(Me.PSU_POWER_CALC_3)
        Me.Controls.Add(Me.PSULink)
        Me.Controls.Add(Me.PSU_READ_I_4)
        Me.Controls.Add(Me.PSU_READ_I_3)
        Me.Controls.Add(Me.PSU_READ_V_4)
        Me.Controls.Add(Me.PSU_READ_V_3)
        Me.Controls.Add(Me.PSU_ON_4)
        Me.Controls.Add(Me.PSU_ON_3)
        Me.Controls.Add(Me.PSU_I_4)
        Me.Controls.Add(Me.PSU_V_4)
        Me.Controls.Add(Me.PSULabel2)
        Me.Controls.Add(Me.PSU_I_3)
        Me.Controls.Add(Me.PSU_V_3)
        Me.Controls.Add(Me.PSULabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PSU_FORM_34"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PSU 3 AND 4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PSULink As CheckBox
    Friend WithEvents PSU_READ_I_4 As TextBox
    Friend WithEvents PSU_READ_I_3 As TextBox
    Friend WithEvents PSU_READ_V_4 As TextBox
    Friend WithEvents PSU_READ_V_3 As TextBox
    Friend WithEvents PSU_ON_4 As Button
    Friend WithEvents PSU_ON_3 As Button
    Friend WithEvents PSU_I_4 As TextBox
    Friend WithEvents PSU_V_4 As TextBox
    Friend WithEvents PSULabel2 As Label
    Friend WithEvents PSU_I_3 As TextBox
    Friend WithEvents PSU_V_3 As TextBox
    Friend WithEvents PSULabel1 As Label
    Friend WithEvents PSU_POWER_CALC_4 As TextBox
    Friend WithEvents PSU_POWER_CALC_3 As TextBox
End Class
