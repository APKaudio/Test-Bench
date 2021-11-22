Public Class Panner
	Private Sub Button_MouseDown(sender As Object, e As EventArgs) Handles Button1.MouseDown
		Button1.Text = MousePosition.X & " , " & MousePosition.Y & ""
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.MouseUp
		Button1.Text = MousePosition.X & " , " & MousePosition.Y & ""

		Button1.Location = MousePosition

	End Sub

	Private Sub Panner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'Me.Parent.Location(0, 0)
	End Sub
End Class
