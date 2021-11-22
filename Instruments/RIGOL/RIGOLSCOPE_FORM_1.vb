


Public Class RIGOLSCOPE_FORM_1

    Dim Channel As Integer = 1



    Private Sub RIGOLSCOPE_FORM_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Point(((Channel - 1) * Me.Width), 600)

        UserInterfaceShell.Rigol_Channel1ToolStripMenuInstrument.Checked = True
        RIGOL_Connecttoscope(Channel)
    End Sub

    Private Sub RIGOLSCOPE_FORM_1_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        UserInterfaceShell.Rigol_Channel1ToolStripMenuInstrument.Checked = False
    End Sub



    Private Sub ScopeDivision_Scroll(sender As Object, e As EventArgs) Handles ScopeDivision.Scroll
        Rigol_ChangeDivision(ScopeDivision.Value)
        Division_Value.Text = SecondsPerDivisionIncriments(ScopeDivision.Value)
    End Sub

    Private Sub BandwidthLimit_CheckedChanged(sender As Object, e As EventArgs) Handles BandwidthLimit.CheckedChanged
        BandwidthLimitChange(1, BandwidthLimit.Checked)
    End Sub

    Private Sub COUPlingAC_CheckedChanged(sender As Object, e As EventArgs) Handles COUPlingAC.CheckedChanged
        ChannelCoupling(Channel, "AC")
    End Sub

    Private Sub COUPlingDC_CheckedChanged(sender As Object, e As EventArgs) Handles COUPlingDC.CheckedChanged
        ChannelCoupling(Channel, "DC")
    End Sub

    Private Sub COUPlingGND_CheckedChanged(sender As Object, e As EventArgs) Handles COUPlingGND.CheckedChanged
        ChannelCoupling(Channel, "GND")
    End Sub



    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        CommandList("=======UPDATE CLICK")
        Rigol_ChangeDivision(ScopeDivision.Value)

        Rigol_ReadandDisplay_CH1()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles TimeBaseOffsetUP.Click
        Rigol_Horizontal_Offset(Channel, 1)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles TimeBaseOffsetDOWN.Click
        Rigol_Horizontal_Offset(Channel, 2)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Rigol_Horizontal_Offset(Channel, 0)
    End Sub
End Class