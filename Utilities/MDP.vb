Public Class MDP
	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


		'Dim myChars As Char() = System.Text.Encoding.Unicode.GetChars(myBytes)


		Dim splitup As String = "🆔PRODUCTION ID⌚ PTP TIME STAMP😃NAME📛FUNCTIONℹINFORMATION⚠WARNING🎤MIC MODEL👻PHANTOM POWER🔌CONNECTION N🔌CONNECTION N+1🎚SENSITIVITY"
		Dim myBytes As Byte() = System.Text.Encoding.Unicode.GetBytes(splitup)
		Dim myChars As Char() = System.Text.Encoding.ASCII.GetChars(myBytes)
		Dim myString As String = New String(myChars)

		TextBox1.Text = myString


		'RichTextBox1.Text = myBytes
	End Sub

	Private Sub MDP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

	End Sub
End Class