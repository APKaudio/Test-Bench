Public Class Agilent_Distortion_Form
    Private Sub Agilent_Distortion_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(1200, 0)


        CommandList("Agilent_Distortion_Form_Load")
        UserInterfaceShell.AudioAnalyzerToolStripMenuItem.Checked = True
    End Sub

    Private Sub Agilent_Distortion_Form_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        CommandList("Agilent_Distortion_Form_close")
        UserInterfaceShell.AudioAnalyzerToolStripMenuItem.Checked = False
    End Sub

    Private Sub DistortionChange_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Dist_freq_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Dist_measure_SINAD_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Dist_measure_DSTN_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Dist_measure_Voltage_TextChanged(sender As Object, e As EventArgs) 

    End Sub
End Class