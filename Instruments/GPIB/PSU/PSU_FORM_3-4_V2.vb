Public Class PSU_FORM_34



    Private Sub PSU_FORM_34_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Point((400 + Me.Width), 0)


        UserInterfaceShell.PSU34ToolStripMenuItem.Checked = True
        PSUAssignAddress(3)
        PSUAssignAddress(4)

    End Sub



    Private Sub PSU_FORM_34_Close(sender As Object, e As EventArgs) Handles MyBase.Closed

        UserInterfaceShell.PSU34ToolStripMenuItem.Checked = False

        'shut off PSU
        PSU_Status(3, 0)
        PSU_Status(4, 0)
    End Sub

    Private Sub PSU_ON_3_Click(sender As Object, e As EventArgs) Handles PSU_ON_3.Click
        If PSU_CH(3).Status = False Then
            PSU_Update_3(1)
            If PSULink.Checked = True Then
                PSU_V_4.Text = PSU_V_3.Text
                PSU_I_4.Text = PSU_I_3.Text
                PSU_Update_4(1)

            End If
        ElseIf PSU_CH(3).Status = True Then
            PSU_Update_3(0)
            If PSULink.Checked = True Then
                PSU_Update_4(0)
            End If
        End If

    End Sub



    Private Sub PSU_ON_4_Click(sender As Object, e As EventArgs) Handles PSU_ON_4.Click
        If PSU_CH(4).Status = False Then
            PSU_Update_4(1)
        ElseIf PSU_CH(4).Status = True Then
            PSU_Update_4(0)
        End If
    End Sub


    Sub PSU_Update_3(Status As Boolean)
        PSU_CH(3).SendVoltage = CDbl(PSU_V_3.Text)
        PSU_CH(3).SendCurrentLimit = CDbl(PSU_I_3.Text)

        PSU_Update(3)
        PSU_Status(3, Status)
        ReadPSUValue(3)
        PSUButtonUpdate3()


    End Sub

    Sub PSU_Update_4(Status As Boolean)
        PSU_CH(4).SendVoltage = CDbl(PSU_V_4.Text)
        PSU_CH(4).SendCurrentLimit = CDbl(PSU_I_4.Text)

        PSU_Update(4)
        PSU_Status(4, Status)
        ReadPSUValue(4)
        PSUButtonUpdate4()


    End Sub




    Sub PSUButtonUpdate3()
        If PSU_CH(3).Status = False Then
            PSU_ON_3.Text = "OFF"
            PSU_ON_3.BackColor = Color.Transparent

        ElseIf PSU_CH(3).Status = True Then
            PSU_ON_3.Text = "ON"
            PSU_ON_3.BackColor = Color.Orange

        End If
    End Sub


    Sub PSUButtonUpdate4()
        If PSU_CH(4).Status = False Then
            PSU_ON_4.Text = "OFF"
            PSU_ON_4.BackColor = Color.Transparent

        ElseIf PSU_CH(4).Status = True Then
            PSU_ON_4.Text = "ON"
            PSU_ON_4.BackColor = Color.Orange

        End If
    End Sub




    Private Sub PSULink_CheckedChanged(sender As Object, e As EventArgs) Handles PSULink.CheckedChanged


        If PSULink.Checked Then
            PSU_Update_3(0)
            PSU_Update_4(0)

            PSU_CH(3).Link = True
            PSU_CH(4).Link = True
            PSU_V_4.Text = PSU_V_3.Text
            PSU_I_4.Text = PSU_I_3.Text
            PSU_V_4.Enabled = False
            PSU_I_4.Enabled = False
            PSU_ON_4.Enabled = False


        ElseIf PSULink.Checked = False Then
            PSU_CH(3).Link = False
            PSU_CH(4).Link = False

            PSU_V_4.Enabled = True
            PSU_I_4.Enabled = True
            PSU_ON_4.Enabled = True
        End If
    End Sub


    Private Sub PSU_READ_V_3_TextChanged(sender As Object, e As EventArgs) Handles PSU_READ_V_3.MouseClick
        ReadPSUValue(3)
    End Sub

    Private Sub PSU_READ_V_2_TextChanged(sender As Object, e As EventArgs) Handles PSU_READ_V_3.MouseClick
        ReadPSUValue(3)
    End Sub

    Private Sub PSU_READ_I_1_TextChanged(sender As Object, e As EventArgs) Handles PSU_READ_I_4.MouseClick
        ReadPSUValue(4)
    End Sub

    Private Sub PSU_READ_I_2_TextChanged(sender As Object, e As EventArgs) Handles PSU_READ_I_4.MouseClick
        ReadPSUValue(4)
    End Sub




End Class