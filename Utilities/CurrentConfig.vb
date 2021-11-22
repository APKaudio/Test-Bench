Public Class CurrentConfig
	Private Sub CurrentConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Public Sub ConfigPresetList(WhatToAdd As String)
		Command_List_Form.ListBox_Data.Items.Add(TimeOfDay & " : " & WhatToAdd)
		Command_List_Form.ListBox_Data.SelectedIndex = Command_List_Form.ListBox_Data.Items.Count - 1
	End Sub


End Class
