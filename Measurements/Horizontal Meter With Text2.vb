Public Class Horizontal_Meter_With_Text

	Private ValueReceived As Double
	Private TitleToDisplay As String
	Private Counter As Integer


	Private ModuleNumbertoColour As Integer

	Private MinValue As Integer
	Private MaxValue As Integer

	Dim Unit As String = ""
	Public signedvalue As String = ""

	Public Property Value_To_Display() As Double
		Get
			Return ValueReceived

		End Get
		Set(value As Double)
			ValueReceived = value
			UpdateGraph(ValueReceived)
			DisplayDigits()
			Storepoint()
		End Set
	End Property


	Public Property Title_To_Display() As String
		Get
			Return TitleToDisplay
		End Get
		Set(value As String)
			TitleToDisplay = value
			Label_Title.Text = TitleToDisplay
			UpdateGraph(ValueReceived)
		End Set
	End Property




	Public Property ModuleNumber() As Double
		Get
			Return ValueReceived

		End Get
		Set(ValueReceived As Double)

            If ValueReceived > 0 Then
                ModuleNumbertoColour = ValueReceived
                Me.BackColor = ChangeNumbertoColor(ModuleNumbertoColour)
            End If
        End Set
    End Property


	Private Sub Horizontal_Meter_With_Text_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Horizontal_Meter_With_Text_resize(sender, e)

		ChartSetup()


	End Sub

	Private Sub Horizontal_Meter_With_Text_resize(sender As Object, e As EventArgs) Handles MyBase.Resize
		Dim NumberOfLineItems As Integer = 4
		Dim HeightOfItems As Integer = Me.Height / NumberOfLineItems

		'SIZE METERS
		BarGraphValue_Hundred.Size = New Point(Me.Width * (0.5), HeightOfItems * 3)
		BarGraphValueMili.Size = New Point(Me.Width * (0.35), HeightOfItems * 3)
		BarGraphValueMicro.Size = New Point(Me.Width * (0.15), HeightOfItems * 3)

		'Move the mili micro and nano
		BarGraphValue_Hundred.Location = New Point(0, (HeightOfItems * 2))
		BarGraphValueMili.Location = New Point(Me.Width * (0.5), (HeightOfItems * 2))
		BarGraphValueMicro.Location = New Point(Me.Width * (0.5) + Me.Width * (0.35), (HeightOfItems * 2))

		'LABELS - Move 
		Labelhundreds.Location = New Point(0, (HeightOfItems * 3))
		Labelmili.Location = New Point(Me.Width * (0.5), (HeightOfItems * 3))
		Labelmicro.Location = New Point(Me.Width * (0.5) + Me.Width * (0.35), (HeightOfItems * 3))

		'LABELS - Font Size
		Labelhundreds.Font = New Font("Arial", Me.Height / 10 + 2)
		Labelmili.Font = New Font("Arial", Me.Height / 10 + 2)
		Labelmicro.Font = New Font("Arial", Me.Height / 10 + 2)

		If Me.Width < 80 Then
			Label_Title.Visible = False
		End If

		Chart1.Width = Me.Width
		Chart1.Height = HeightOfItems * 2
		Chart1.Location = New Point(0, 0)
		Chart1.Visible = False

		Label_Title.Location = New Point(0, 0)
		Label_Title.Font = New Font("Arial", Me.Height / 5 + 2)
	End Sub

	Private Sub UpdateGraph(ValueReceived As Double)
		Dim Unit_Scaler As Double


		signedvalue = ""



		If ValueReceived > 9.1E+30 Then
			ValueReceived = 0
			Unit = "INFINITY"
		Else

			If ValueReceived < 0 Then
				BarGraphValue_Hundred.RightToLeft = RightToLeft.Yes
				BarGraphValueMili.RightToLeft = RightToLeft.Yes
				BarGraphValueMicro.RightToLeft = RightToLeft.Yes
				ValueReceived = ValueReceived * -1
				signedvalue = "-"
			Else
				BarGraphValue_Hundred.RightToLeft = RightToLeft.No
				BarGraphValueMili.RightToLeft = RightToLeft.No
				BarGraphValueMicro.RightToLeft = RightToLeft.No
				signedvalue = ""
			End If

			If ValueReceived > 1000000000.0 Then
				Unit = "G"
				Unit_Scaler = 1000000000
			ElseIf ValueReceived > 1000000 Then
				Unit = "M"
				Unit_Scaler = 1000000
			ElseIf ValueReceived > 1000 Then
				Unit = "k"
				Unit_Scaler = 1000
			ElseIf ValueReceived > 0.001 Then
				Unit = ""
				Unit_Scaler = 1
			ElseIf ValueReceived < 1 And ValueReceived > 0.001 Then
				Unit = "m"
				Unit_Scaler = 1 / 1000

			ElseIf ValueReceived < 0.001 And ValueReceived > (1 / 1000000.0) Then
				Unit = "u"
				Unit_Scaler = 1 / 1000000.0

			ElseIf ValueReceived < (1 / 1000000.0) And ValueReceived > (1 / 1000000000000.0) Then
				Unit = "p"
				Unit_Scaler = (1 / 1000000000000.0)
			End If



			updateColor()

			If ValueReceived <> 0 Then
				Try
					Dim scaledvalue As Integer = ValueReceived / Unit_Scaler

					If ValueReceived < 10 Then
						BarGraphValue_Hundred.Value = Math.Truncate(ValueReceived) * 100

					ElseIf ValueReceived < 100 Then
						BarGraphValue_Hundred.Value = Math.Truncate(ValueReceived) * 10

					ElseIf ValueReceived < 1000 Then
						BarGraphValue_Hundred.Value = Math.Truncate(ValueReceived) * 1


					ElseIf ValueReceived > 1000 And ValueReceived < 1000000 Then
						BarGraphValue_Hundred.Value = Math.Truncate(ValueReceived) / 1000
					ElseIf ValueReceived > 1000000 And ValueReceived < 1000000000 Then
						BarGraphValue_Hundred.Value = Math.Truncate(ValueReceived) / 1000000
					ElseIf ValueReceived > 1000000000 Then
						BarGraphValue_Hundred.Value = Math.Truncate(ValueReceived) / 1000000000


					ElseIf ValueReceived >= (1 / 0) Then
						BarGraphValue_Hundred.Value = 0
						ValueReceived = 0
					Else
						BarGraphValue_Hundred.Value = Math.Truncate(ValueReceived)
					End If
				Catch ex As Exception

				End Try





			End If

		End If





		Dim newvaluemili As Double = (ValueReceived - Math.Truncate(ValueReceived))
		BarGraphValueMili.Value = newvaluemili * 1000

		Dim newvaluemicro As Double = (ValueReceived * 1000 - Math.Truncate(ValueReceived * 1000))
		BarGraphValueMicro.Value = newvaluemicro * 1000

		Dim newvalueNano As Double = (ValueReceived * 1000000 - Math.Truncate(ValueReceived * 1000000))
	End Sub

	Public Sub updateColor()

		Dim UnitChangeValue As Double = ValueReceived

		Select Case Unit
			Case "G"
				UnitChangeValue = UnitChangeValue / 1000000000
				BarGraphValue_Hundred.ForeColor = ChangeNumbertoColor(9)
				BarGraphValueMili.ForeColor = ChangeNumbertoColor(6)
				BarGraphValueMicro.ForeColor = ChangeNumbertoColor(3)
			Case "M"
				UnitChangeValue = UnitChangeValue / 1000000
				BarGraphValue_Hundred.ForeColor = ChangeNumbertoColor(6)
				BarGraphValueMili.ForeColor = ChangeNumbertoColor(3)
				BarGraphValueMicro.ForeColor = ChangeNumbertoColor(8)

			Case "k"
				UnitChangeValue = UnitChangeValue / 1000
				BarGraphValue_Hundred.ForeColor = ChangeNumbertoColor(3)
				BarGraphValueMili.ForeColor = ChangeNumbertoColor(9)
				BarGraphValueMicro.ForeColor = ChangeNumbertoColor(9)

			Case "m"
				UnitChangeValue = UnitChangeValue * 1000
				BarGraphValue_Hundred.ForeColor = ChangeNumbertoColor(-3)
				BarGraphValueMili.ForeColor = ChangeNumbertoColor(9)
				BarGraphValueMicro.ForeColor = ChangeNumbertoColor(9)

			Case Else
				BarGraphValue_Hundred.ForeColor = ChangeNumbertoColor(-6)
				BarGraphValueMili.ForeColor = ChangeNumbertoColor(-3)
				BarGraphValueMicro.ForeColor = ChangeNumbertoColor(9)
		End Select

	End Sub

	Public Sub DisplayDigits()
		Labelhundreds.Text = signedvalue & Math.Truncate(ValueReceived) & Unit


		If BarGraphValueMicro.Value < 100 Then
			Labelmicro.Text = "0" & BarGraphValueMicro.Value
		Else
			Labelmicro.Text = BarGraphValueMicro.Value
		End If

		' INSERT ZERO
		If BarGraphValueMili.Value < 100 Then
			Labelmili.Text = "0" & BarGraphValueMili.Value
		Else
			Labelmili.Text = BarGraphValueMili.Value
		End If

		Label_Title.Text = TitleToDisplay & "|" & Labelhundreds.Text & "," & Labelmili.Text


	End Sub



	Public Sub Storepoint()

		If ValueReceived > 1 Then
			Chart1.Series(1).Color = Color.Blue
			Chart1.Series(1).Points.AddXY(Counter, ValueReceived)
		ElseIf ValueReceived < -1 Then
			Chart1.Series(2).Color = Color.Red
			Chart1.Series(2).Points.AddXY(Counter, ValueReceived)

		ElseIf ValueReceived > 9.9E+20 Then
		ElseIf ValueReceived < -9.9E+20 Then


		Else
			Chart1.Series(3).Color = Color.Black
			Chart1.Series(3).Points.AddXY(Counter, ValueReceived)
		End If

		If Counter > 20 Then
			Chart1.Visible = True
		Else
			Chart1.Visible = False
		End If



		'Chart1.ChartAreas(0).AxisX.CustomLabels.Add(Counter - 1, Counter + 1, Now.ToString("HH:mm:ss fff"))
		Counter += 1
	End Sub

	Private Sub ChartSetup()
		Try
			Chart1.ChartAreas(0).AxisX.Interval = 1
			Chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = False
			Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = 90
			Chart1.ChartAreas(0).AxisY.MajorGrid.Enabled = False
			Chart1.ChartAreas(0).AxisY.Interval = 1


			Chart1.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Point
			Chart1.Series(1).IsVisibleInLegend = False


			Chart1.Series(2).ChartType = DataVisualization.Charting.SeriesChartType.Point
			Chart1.Series(2).IsVisibleInLegend = False

			Chart1.Series(3).ChartType = DataVisualization.Charting.SeriesChartType.Point
			Chart1.Series(3).IsVisibleInLegend = False

		Catch ex As Exception

		End Try

	End Sub

	Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click
		Counter = 0
		Chart1.Series(1).Points.Clear()
		Chart1.Series(2).Points.Clear()
		Chart1.Series(3).Points.Clear()


	End Sub
End Class



