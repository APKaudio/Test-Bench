Public Class Command_List_Form
	Private Sub Command_List_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Command_List_Form_Resize(sender, e)

    End Sub

	Private Sub RepositionAnnounce(sender As Object, e As EventArgs) Handles MyBase.Move
		Me.Text = Me.Name & " X:" & Me.Location.X & " Y:" & Me.Location.Y
	End Sub


	Private Sub Command_List_Form_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
		Dim offset As Integer = 30
		Dim Panles As Integer = 3

		Command_List_Box.Height = Me.Height - offset * 3
		Command_List_Box.Width = Me.Width / Panles - offset
		Command_List_Box.Location = New Point(0, offset)

		Error_List_Box.Height = Me.Height - offset * 3
		Error_List_Box.Width = Me.Width / Panles - offset
		Error_List_Box.Location = New Point((Me.Width / Panles) - offset, offset)

		ListBox_Data.Height = Me.Height - offset * 3
		ListBox_Data.Width = Me.Width / Panles - offset
		ListBox_Data.Location = New Point((Me.Width / Panles) * 2 - offset, offset)

		Label_Error.Location = New Point((Me.Width / Panles) - offset, 0)
		Label_Data.Location = New Point((Me.Width / Panles) * 2 - offset, 0)



	End Sub


End Class