Public Class PSU_FORM_12

    Public ChannelOnForm As Integer = 1



    Private Sub PSU_FORM_12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(400, 0)

        UserInterfaceShell.PSU12ToolStripMenuItem.Checked = True
        PSUAssignAddress(1)
        PSUAssignAddress(2)

    End Sub



    Private Sub PSU_FORM_12_Close(sender As Object, e As EventArgs) Handles MyBase.Closed

        UserInterfaceShell.PSU12ToolStripMenuItem.Checked = False

        'shut off PSU
        PSU_Status(1, 0)
        PSU_Status(2, 0)
    End Sub

    Private Sub PSU_ON_1_Click(sender As Object, e As EventArgs) Handles PSU_ON_1.Click
        If PSU_CH(1).Status = False Then
            PSU_Update_1(1)
            If PSULink.Checked = True Then
                PSU_V_2.Text = PSU_V_1.Text
                PSU_I_2.Text = PSU_I_1.Text
                PSU_Update_2(1)
            End If
        ElseIf PSU_CH(1).Status = True Then
            PSU_Update_1(0)
            If PSULink.Checked = True Then
                PSU_Update_2(0)
            End If
        End If

    End Sub



    Private Sub PSU_ON_2_Click(sender As Object, e As EventArgs) Handles PSU_ON_2.Click
        If PSU_CH(2).Status = False Then
            PSU_Update_2(1)
        ElseIf PSU_CH(2).Status = True Then
            PSU_Update_2(0)
        End If
    End Sub


    Sub PSU_Update_1(Status As Boolean)
        PSU_CH(1).SendVoltage = CDbl(PSU_V_1.Text)
        PSU_CH(1).SendCurrentLimit = CDbl(PSU_I_1.Text)

        PSU_Update(1)
        PSU_Status(1, Status)
        ReadPSUValue(1)
        PSUButtonUpdate1()


    End Sub

    Sub PSU_Update_2(Status As Boolean)
        PSU_CH(2).SendVoltage = CDbl(PSU_V_2.Text)
        PSU_CH(2).SendCurrentLimit = CDbl(PSU_I_2.Text)

        PSU_Update(2)
        PSU_Status(2, Status)
        ReadPSUValue(2)
        PSUButtonUpdate2()


    End Sub




    Sub PSUButtonUpdate1()
        If PSU_CH(1).Status = False Then
            PSU_ON_1.Text = "OFF"
            PSU_ON_1.BackColor = Color.Transparent

        ElseIf PSU_CH(1).Status = True Then
            PSU_ON_1.Text = "ON"
            PSU_ON_1.BackColor = Color.Orange

        End If
    End Sub


    Sub PSUButtonUpdate2()
        If PSU_CH(2).Status = False Then
            PSU_ON_2.Text = "OFF"
            PSU_ON_2.BackColor = Color.Transparent

        ElseIf PSU_CH(2).Status = True Then
            PSU_ON_2.Text = "ON"
            PSU_ON_2.BackColor = Color.Orange

        End If
    End Sub




    Private Sub PSULink_CheckedChanged(sender As Object, e As EventArgs) Handles PSULink.CheckedChanged


        If PSULink.Checked Then
            PSU_Update_1(0)
            PSU_Update_2(0)

            PSU_CH(1).Link = True
            PSU_CH(2).Link = True
            PSU_V_2.Text = PSU_V_1.Text
            PSU_I_2.Text = PSU_I_1.Text
            PSU_V_2.Enabled = False
            PSU_I_2.Enabled = False
            PSU_ON_2.Enabled = False


        ElseIf PSULink.Checked = False Then
            PSU_CH(1).Link = False
            PSU_CH(2).Link = False

            PSU_V_2.Enabled = True
            PSU_I_2.Enabled = True
            PSU_ON_2.Enabled = True
        End If
    End Sub

    Private Sub PSU_READ_V_1_TextChanged(sender As Object, e As EventArgs) Handles PSU_READ_V_1.MouseClick
        ReadPSUValue(1)
    End Sub

    Private Sub PSU_READ_V_2_TextChanged(sender As Object, e As EventArgs) Handles PSU_READ_V_2.MouseClick
        ReadPSUValue(2)
    End Sub

    Private Sub PSU_READ_I_1_TextChanged(sender As Object, e As EventArgs) Handles PSU_READ_I_1.MouseClick
        ReadPSUValue(1)
    End Sub

    Private Sub PSU_READ_I_2_TextChanged(sender As Object, e As EventArgs) Handles PSU_READ_I_2.MouseClick
        ReadPSUValue(2)
    End Sub

    Private Sub PSU_READ_I_1_TextChanged(sender As Object, e As MouseEventArgs) Handles PSU_READ_I_1.MouseClick

    End Sub
End Class