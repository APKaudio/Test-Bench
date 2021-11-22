Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class TCPControl
    Public Event MessageReceived(sender As TCPControl, Data As String)

    ' SERVER CONFIG
    Public ServerIP As IPAddress = IPAddress.Parse(WBS_PreMOte.MyIP.Text)
    Public ServerPort As Integer = WBS_PreMOte.MyPort.Text
    Public Server As TcpListener

    Private CommThread As Thread
    Public IsListening As Boolean = True

    ' CLIENTS
    Private Client As TcpClient
    Private ClientData As StreamReader

    Public Sub New()
        Server = New TcpListener(ServerIP, ServerPort)
        Try
            Server.Start()
            CommThread = New Thread(New ThreadStart(AddressOf Listening))
            CommThread.Start()
        Catch

        End Try



    End Sub

    Private Sub Listening()
        ' CREATE LISTENER LOOP
        Do Until IsListening = False
            ' ACCEPT INCOMING CONNECTIONS
            If Server.Pending = True Then
                Client = Server.AcceptTcpClient
                ClientData = New StreamReader(Client.GetStream)

            End If

            ' RAISE EVENT FOR INCOMING MESSAGES
            Try
                RaiseEvent MessageReceived(Me, ClientData.ReadLine)
            Catch ex As Exception

            End Try

            ' REDUCE CPU USAGE
            'Thread.Sleep(100)
        Loop
    End Sub
End Class


Public Class TCPCtrl
    Public ClientChat As TcpClient
    Public DataStream As StreamWriter

    Public Sub New(Host As String, Port As Integer)
        ' CLIENT
        ClientChat = New TcpClient(Host, Port)
        DataStream = New StreamWriter(ClientChat.GetStream)
    End Sub

    Public Sub Send(Data As String)
        DataStream.Write(Data & vbCrLf)
        DataStream.Flush()
    End Sub
End Class

