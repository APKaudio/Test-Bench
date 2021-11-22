Public Class WhatIsNear


	Dim OCT_First As String = ""
	Dim OCT_Second As String = ""
	Dim OCT_Third As String = ""
	Dim OCT_Fourth As String = ""

	Dim MyIPaddress As Address


    Public _GPIB_IP_ADDRESS As String = "192.168.11.56"
    Public _GPIB_BUSS As String = "gpib10"
    Public _Rigol_IP As String = "192.168.11.66"
    Public _SIGNALGEN_IP As String = "192.168.11.61"



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		GeHostnamer()
		'Label_MY_IP.Text = GetHostNameFromIP("44.44.44.112")

	End Sub





	Private Sub GeHostnamer()





		Dim hostName = System.Net.Dns.GetHostName()
		For Each hostAdr In System.Net.Dns.GetHostEntry(hostName).AddressList()

			' If you just want to write every IP
			'	Console.WriteLine("Name: " & hostName & " IP Address: " & hostAdr.ToString() 
			ListBox_Pings.Items.Add(("Name: " & hostName & " Address: " & hostAdr.ToString()))



			If hostAdr.ToString().Contains(".") Then
				Label_MY_IP.Text = hostAdr.ToString()
				SplitIP(Label_MY_IP.Text)
			End If



			' If you want to look if the device is member of a specific network
			'If hostAdr.ToString().StartsWith("192.168.1.") Then DoSomething() : Exit For

			' I think you get the idea ^^
			' ...
		Next


	End Sub

	Public Function GetHostNameFromIP(ByRef IP As String) As String

		Dim host As System.Net.IPHostEntry
		host = System.Net.Dns.GetHostEntry(IP)

		Return host.HostName

	End Function




	Private Sub PingRangeOfIP(start As String, Ending As String)




	End Sub


	Public Sub PingList()

	End Sub

	Public Sub SetIPSearchPrange()

	End Sub

	Private Sub Label_MY_IP_Click(sender As Object, e As EventArgs) Handles Label_MY_IP.TextChanged

	End Sub


	Private Sub SplitIP(AddressToSplit)



		Dim Working As Integer = 0


		For position As Integer = 1 To Len(AddressToSplit) + 1
			If Mid(AddressToSplit, position, 1) = "." Then
				Working = Working + 1

			Else
				Select Case Working
					Case 0
						OCT_First = OCT_First & Mid(AddressToSplit, position, 1)
					Case 1
						OCT_Second = OCT_Second & Mid(AddressToSplit, position, 1)
					Case 2
						OCT_Third = OCT_Third & Mid(AddressToSplit, position, 1)
					Case 3
						OCT_Fourth = OCT_Fourth & Mid(AddressToSplit, position, 1)

				End Select


			End If


		Next

		ListBox_Pings.Items.Add(OCT_First & ",," & OCT_Second & ",," & OCT_Third & ",," & OCT_Fourth)



	End Sub

    Private Sub TextBox_GPIB_IP_ADDRESS_TextChanged(sender As Object, e As EventArgs) Handles TextBox_GPIB_IP_ADDRESS.TextChanged
        Update_IPaddresses()
    End Sub

    Public Sub Update_IPaddresses()


        _GPIB_IP_ADDRESS = TextBox_GPIB_IP_ADDRESS.Text

        _GPIB_BUSS = TextBox_GPIB_BUSS.Text
        _Rigol_IP = TextBox_Rigol_IP.Text
        _SIGNALGEN_IP = TextBox_SIGNALGEN_IP.Text


    End Sub

    Private Sub TextBox_GPIB_BUSS_TextChanged(sender As Object, e As EventArgs) Handles TextBox_GPIB_BUSS.TextChanged
        Update_IPaddresses()
    End Sub

    Private Sub TextBox_Rigol_IP_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Rigol_IP.TextChanged
        Update_IPaddresses()
    End Sub

    Private Sub TextBox_SIGNALGEN_IP_TextChanged(sender As Object, e As EventArgs) Handles TextBox_SIGNALGEN_IP.TextChanged
        Update_IPaddresses()
    End Sub

    Private Sub WhatIsNear_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs)

	End Sub
End Class
