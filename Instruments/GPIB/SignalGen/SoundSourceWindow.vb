Public Class SoundSourceWindow
	Private Sub Balanced_Router_reposition(sender As Object, e As EventArgs) Handles MyBase.Move
		Me.Text = "SOFTWARE " & " LOCATION X:" & Me.Location.X & " LOCATION Y:" & Me.Location.Y & " WIDTH:" & Me.Width & " HEIGHT:" & Me.Height
	End Sub

	Private Sub SoundSourceWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub SoundSource1_Load(sender As Object, e As EventArgs) Handles SoundSource1.Load

	End Sub
End Class