Module Command_List
	Public Sub CommandList(WhatToAdd As String)
		'This is what every function call could use to show what the name of the fuction that has been called is
		'Command of current function
		'        CommandList(System.Reflection.MethodBase.GetCurrentMethod.Name)

		Command_List_Form.Command_List_Box.Items.Add(TimeOfDay & " : " & WhatToAdd)
		Command_List_Form.Command_List_Box.SelectedIndex = Command_List_Form.Command_List_Box.Items.Count - 1
	End Sub

	Public Sub ErrorList(WhatToAdd As String)
		Command_List_Form.Error_List_Box.Items.Add(TimeOfDay & " : " & WhatToAdd)
		Command_List_Form.Error_List_Box.SelectedIndex = Command_List_Form.Error_List_Box.Items.Count - 1
	End Sub


	Public Sub DataList(WhatToAdd As String)
		Command_List_Form.ListBox_Data.Items.Add(TimeOfDay & " : " & WhatToAdd)
		Command_List_Form.ListBox_Data.SelectedIndex = Command_List_Form.ListBox_Data.Items.Count - 1
	End Sub




End Module
