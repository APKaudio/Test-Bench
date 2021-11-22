Public Class RIGOLSCOPE_FORM_3
    Private Sub RIGOLSCOPE_FORM_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(((3 - 1) * Me.Width), 600)
        UserInterfaceShell.Rigol_Channel3ToolStripMenuInstrument.Checked = True

    End Sub

    Private Sub RIGOLSCOPE_FORM_3_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        UserInterfaceShell.Rigol_Channel3ToolStripMenuInstrument.Checked = False
    End Sub

    Private Sub Rigol_update_CH3_Click(sender As Object, e As EventArgs) Handles Rigol_update_CH3.Click
        CommandList("=======")
        RIGOL_Connecttoscope(3)
        Rigol_ReadandDisplay_CH3()

    End Sub
End Class