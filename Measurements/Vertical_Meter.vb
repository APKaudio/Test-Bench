Imports System.Windows.Forms.DataVisualization.Charting



Public Class Vertical_Meter



    Dim V1 As Double
    Dim V2 As Double
    Dim V3 As Double
	Dim V4 As Double

	Private ModuleNumbertoColour As Integer
	Private ValueReceived As Integer



	Public Property ModuleNumber() As Double
		Get
			Return ValueReceived

		End Get
		Set(ValueReceived As Double)
			ModuleNumbertoColour = ValueReceived
			Chart1.Series("V1").Color = ChangeNumbertoColor(ModuleNumbertoColour)


		End Set
	End Property


	Public Property Plot_V1() As Double
        Get
            Return V1
        End Get
        Set(ByVal value As Double)
            V1 = value
            Chart1.Series("V1").Points.Clear()
            If Not value = 0 Then
                Chart1.Series("V1").Points.AddXY(-2, V1)
            Else
                Chart1.Series("V1").Points.AddXY(-2, 0)
            End If

        End Set
    End Property

    Public Property Plot_V2() As Double
        Get
            Return V2
        End Get
        Set(ByVal value As Double)
            V2 = value
            Chart1.Series("V2").Points.Clear()

            If Not value = 0 Then
                Chart1.Series("V2").Points.AddXY(-0.5, V2)
            End If


        End Set
    End Property

    Public Property Plot_V3() As Double
        Get
            Return V3
        End Get
        Set(ByVal value As Double)
            V3 = value
            Chart1.Series("V3").Points.Clear()
            If Not value = 0 Then
                Chart1.Series("V3").Points.AddXY(0.5, V3)
            End If



        End Set
    End Property

    Public Property Plot_V4() As Double
        Get
            Return V4
        End Get
        Set(ByVal value As Double)
            V4 = value
            Chart1.Series("V4").Points.Clear()
            If Not value = 0 Then
                Chart1.Series("V4").Points.AddXY(2, V4)
            End If

        End Set
    End Property



	Private Sub Vertical_Meter_resize(sender As Object, e As EventArgs) Handles MyBase.Resize
		Chart1.Width = Me.Width
		Chart1.Height = Me.Height

	End Sub

	Private Sub Vertical_Meter_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
		Chart1.Width = Me.Width
		Chart1.Height = Me.Height

	End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class
