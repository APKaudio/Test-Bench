Public Class RIGOL_FFT_FORM
    Private Sub RIGOL_FFT_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Point(1200, 300)
        UserInterfaceShell.RigolFFTToolStripMenuInstrument.Checked = True

    End Sub

    Private Sub RIGOL_FFT_FORM_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        UserInterfaceShell.RigolFFTToolStripMenuInstrument.Checked = False


    End Sub

    Private Sub FFT_GET_DATA_Click(sender As Object, e As EventArgs) Handles FFT_GET_DATA.Click

    End Sub

    Private Sub Rigol_FFT_Data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Rigol_FFT_Data.CellContentClick

    End Sub

	Private Sub FFT_Resolution_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FFT_Resolution.SelectedIndexChanged

	End Sub
End Class