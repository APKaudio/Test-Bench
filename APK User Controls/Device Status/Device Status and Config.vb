Public Class Device_Status_and_Config

    Private _Device_Name As String
    Private _Device_IP_Address As String
    Private _Device_Channel As String



    Public Property DeviceName() As String
        Get
            Return _Device_Name
        End Get
        Set(value As String)
            _Device_Name = value
            TextBox_Name.Text = _Device_Name
        End Set
    End Property


    Public Property DeviceIPAddress() As String
        Get
            Return _Device_IP_Address

        End Get
        Set(value As String)

            _Device_IP_Address = value
            TextBox_IP_Address.Text = _Device_IP_Address
        End Set
    End Property

    Public Property DeviceChannel() As String
        Get
            Return _Device_Channel

        End Get
        Set(value As String)
            _Device_Channel = value
            TextBox_IP_Address.Text = _Device_Channel
            ComboBox_Channel.SelectedIndex = _Device_Channel

        End Set
    End Property

    Private Sub Device_Status_and_Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' UserInterfaceShell.WhatIsNear.Update_IPaddresses()



		If _Device_Channel = 0 Then
            'device is not GPIB


        End If




    End Sub


End Class
