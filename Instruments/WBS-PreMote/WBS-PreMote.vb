Public Class WBS_PreMOte


    Private Server As TCPControl
    Private ClientChat As TCPCtrl

    Public Myipaddress As String = 0


    Public Structure WBS_PreMo
        Dim DeviceName As String ' This is the name of the device 


        Dim IP As String  'IP address 
        Dim Port As Integer ' port used to connect to UART

        Dim Gain As Integer
        Dim Phantom As Boolean
        Dim Mute As Boolean



    End Structure

    Public PreMo(8) As WBS_PreMo







    '//////////////////////////////////////////////////////////////////////////////////////////////////




    'THIS IS THE TCP SERVER
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Server = New TCPControl
        txtChat.Text = ":: SERVER STARTED ::" & vbCrLf
        AddHandler Server.MessageReceived, AddressOf OnLineReceived

    End Sub

    ' ALLOW THREAD TO COMMUNICATE WITH FORM CONTROL
    Private Delegate Sub UpdateTextDelegate(TB As TextBox, txt As String)

    ' UPDATE TEXTBOX
    Private Sub UpdateText(TB As TextBox, txt As String)
        If TB.InvokeRequired Then
            TB.Invoke(New UpdateTextDelegate(AddressOf UpdateText), New Object() {TB, txt})
        Else
            If txt IsNot Nothing Then TB.AppendText(txt & vbCrLf)
        End If
    End Sub

    ' UPDATE TEXT WHEN DATA IS RECEIVED
    Private Sub OnLineReceived(sender As TCPControl, Data As String)
        UpdateText(txtChat, Data)

    End Sub

    Private Sub cmdSend_Click(sender As System.Object, e As System.EventArgs)
        SendMessage(txtMessage.Text)
        txtChat.Text &= "Me>> " & txtMessage.Text & vbCrLf
        txtMessage.Clear()
        txtMessage.Focus()
    End Sub

    Private Sub cmdConnect_Click(sender As System.Object, e As System.EventArgs)
        ClientChat = New TCPCtrl(TheirIP.Text, CInt(TheirPort.Text))
        If ClientChat.ClientChat.Connected Then cmdConnect.Text = "Connected"
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ClientChat.ClientChat.Connected = True Then
            ClientChat.DataStream.Close()
            ClientChat.ClientChat.Close()
        End If
    End Sub

    Private Sub txtMessage_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendMessage(txtMessage.Text)
        End If
    End Sub

    Private Sub SendMessage(SendMsg As String)
        If ClientChat.ClientChat.Connected = True Then
            ClientChat.Send(SendMsg)
        End If
    End Sub







    'Adjust gain of the pre-mo
    Private Sub Gain_CH_1_Scroll(sender As Object, e As ScrollEventArgs) Handles Gain_CH_1.Scroll
        PreMo(1).Gain = Gain_CH_1.Value
        SendMessage("PreMo1:G" & Gain_CH_1.Value)
    End Sub


    'Channel on Switch

    Private Sub CH_ON_1_Click(sender As Object, e As EventArgs) Handles CH_ON_1.Click
        If CH_ON_1.BackColor = Color.Red Then
            CH_ON_1.BackColor = Color.DarkGray

            PreMo(1).Mute = False
            SendMessage("PreMo1:M0")
        Else
            CH_ON_1.BackColor = Color.Red
            PreMo(1).Mute = True
            SendMessage("PreMo1:M1")
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Phantom_CH_1.Click
        If Phantom_CH_1.BackColor = Color.Red Then
            Phantom_CH_1.BackColor = Color.DarkGray
            PreMo(1).Phantom = False
            SendMessage("PreMo1:P0")
        Else
            Phantom_CH_1.BackColor = Color.Red
            PreMo(1).Phantom = True
            SendMessage("PreMo1:P1")
        End If
    End Sub

    Private Sub cmdConnect_Click_1(sender As Object, e As EventArgs) Handles cmdConnect.Click
        ClientChat = New TCPCtrl(TheirIP.Text, CInt(TheirPort.Text))
        If ClientChat.ClientChat.Connected Then cmdConnect.Text = "Connected"
    End Sub

    Private Sub cmdSend_Click_1(sender As Object, e As EventArgs) Handles cmdSend.Click
        SendMessage("AES67-PREMO-TEST- APK SEND TO ADAM")
    End Sub
End Class