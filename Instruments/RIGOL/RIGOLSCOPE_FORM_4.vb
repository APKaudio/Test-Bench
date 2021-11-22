Public Class RIGOLSCOPE_FORM_4
    Private Sub RIGOLSCOPE_FORM_4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(((4 - 1) * Me.Width), 600)
        UserInterfaceShell.Rigol_Channel4ToolStripMenuInstrument.Checked = True

    End Sub

    Private Sub RIGOLSCOPE_FORM_4_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        UserInterfaceShell.Rigol_Channel4ToolStripMenuInstrument.Checked = False
    End Sub

    Private Sub Rigol_update_CH4_Click(sender As Object, e As EventArgs) Handles Rigol_update_CH4.Click
        CommandList("=======")
        RIGOL_Connecttoscope(4)
        Rigol_ReadandDisplay_CH4()
    End Sub


End Class