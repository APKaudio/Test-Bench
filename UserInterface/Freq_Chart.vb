Imports System.Windows.Forms.DataVisualization.Charting

Public Class Freq_Chart

	Private Sub Freq_Chart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub RepositionAnnounce(sender As Object, e As EventArgs) Handles MyBase.Move
		Me.Text = "Sequence Timer" & " X:" & Me.Location.X & " Y:" & Me.Location.Y

	End Sub



	Public Sub CHART_DMM_Values()
		Try

			Dim CurrentFreq As Integer = SoundSourceWindow.SoundSource1.DEVICE.Read.Freq


			Chart1.Series("DMM1").Points.AddXY(CurrentFreq, CDbl(UserInterfaceShell.DmmControl1.Horizontal_Meter.Value_To_Display))
			Chart1.Series("DMM2").Points.AddXY(CurrentFreq, CDbl(UserInterfaceShell.DmmControl2.Horizontal_Meter.Value_To_Display))
			Chart1.Series("DMM3").Points.AddXY(CurrentFreq, CDbl(UserInterfaceShell.DmmControl3.Horizontal_Meter.Value_To_Display))
			Chart1.Series("DMM4").Points.AddXY(CurrentFreq, CDbl(UserInterfaceShell.DmmControl4.Horizontal_Meter.Value_To_Display))
			Chart1.Series("DMM5").Points.AddXY(CurrentFreq, CDbl(UserInterfaceShell.DmmControl5.Horizontal_Meter.Value_To_Display))
			Chart1.Series("DMM6").Points.AddXY(CurrentFreq, CDbl(UserInterfaceShell.DmmControl6.Horizontal_Meter.Value_To_Display))
			Chart1.Series("DMM7").Points.AddXY(CurrentFreq, CDbl(UserInterfaceShell.DmmControl7.Horizontal_Meter.Value_To_Display))
			Chart1.Series("DMM8").Points.AddXY(CurrentFreq, CDbl(UserInterfaceShell.DmmControl8.Horizontal_Meter.Value_To_Display))

			'	Chart1.ChartAreas(0).AxisX.IsLogarithmic = True

		Catch ex As Exception

		End Try

	End Sub


	Public Sub CHART_PSU_Values()
		Try

			Dim CurrentFreq As Integer = SoundSourceWindow.SoundSource1.DEVICE.Read.Freq



			Chart_PSU.Series("PSU1").Points.AddXY(CurrentFreq, UserInterfaceShell.PsU_Module0.Display_Power.Value_To_Display)
			Chart_PSU.Series("PSU2").Points.AddXY(CurrentFreq, UserInterfaceShell.PsU_Module1.Display_Power.Value_To_Display)
			Chart_PSU.Series("PSU3").Points.AddXY(CurrentFreq, UserInterfaceShell.PsU_Module2.Display_Power.Value_To_Display)
			Chart_PSU.Series("PSU4").Points.AddXY(CurrentFreq, UserInterfaceShell.PsU_Module3.Display_Power.Value_To_Display)
			Chart_PSU.Series("PSU5").Points.AddXY(CurrentFreq, UserInterfaceShell.PsU_Module4.Display_Power.Value_To_Display)
			Chart_PSU.Series("PSU6").Points.AddXY(CurrentFreq, UserInterfaceShell.PsU_Module5.Display_Power.Value_To_Display)
			Chart_PSU.Series("PSU7").Points.AddXY(CurrentFreq, UserInterfaceShell.PsU_Module6.Display_Power.Value_To_Display)
			Chart_PSU.Series("PSU8").Points.AddXY(CurrentFreq, UserInterfaceShell.PsU_Module7.Display_Power.Value_To_Display)

			Chart_PSU.ChartAreas(0).AxisX.IsLogarithmic = True
		Catch ex As Exception

		End Try

	End Sub


	Public Sub CHART_Scope_VRMS_Values()


		Dim CurrentFreq As Integer = SoundSourceWindow.SoundSource1.DEVICE.Read.Freq

		If SequenceTimer.CheckBox_ScopeCH1.Checked Then
			Chart_Scope.Series("Scope-Vrms_1").Points.AddXY(CurrentFreq, UserInterfaceShell.Scope_Channel_Display_1.display_Vrms.Value_To_Display)
		End If

		If SequenceTimer.CheckBox_ScopeCH2.Checked Then
			Chart_Scope.Series("Scope-Vrms_2").Points.AddXY(CurrentFreq, UserInterfaceShell.Scope_Channel_Display_2.display_Vrms.Value_To_Display)
		End If

		If SequenceTimer.CheckBox_ScopeCH3.Checked Then
			Chart_Scope.Series("Scope-Vrms_3").Points.AddXY(CurrentFreq, UserInterfaceShell.Scope_Channel_Display_3.display_Vrms.Value_To_Display)
		End If

		If SequenceTimer.CheckBox_ScopeCH4.Checked Then
			Chart_Scope.Series("Scope-Vrms_4").Points.AddXY(CurrentFreq, UserInterfaceShell.Scope_Channel_Display_4.display_Vrms.Value_To_Display)
		End If
		Chart_Scope.ChartAreas(0).AxisX.IsLogarithmic = True

		Chart_Scope.ChartAreas(0).AxisX.Minimum = SequenceTimer.SweepStart.Text
		Chart_Scope.ChartAreas(0).AxisX.Maximum = SequenceTimer.SweepStop.Text
		Chart_Scope.ChartAreas(0).AxisX.IsMarginVisible = False

		'Chart_Scope.Series("Scope-Vrms_5").Points.AddXY(CurrentFreq, UserInterfaceShell.Scope_Channel_Display_5.display_Vrms.Value_To_Display)
		'Chart_Scope.Series("Scope-Vrms_6").Points.AddXY(CurrentFreq, UserInterfaceShell.Scope_Channel_Display_6.display_Vrms.Value_To_Display)


	End Sub

	Public Sub CHART_Scope_DBM_Values()


		Dim CurrentFreq As Integer = SoundSourceWindow.SoundSource1.DEVICE.Read.Freq

		If SequenceTimer.CheckBox_ScopeCH1.Checked Then
			Chart_Scope.Series("Scope-Vrms_1").Points.AddXY(CurrentFreq, UserInterfaceShell.Scope_Channel_Display_1.display_dBm.Value_To_Display)
		End If

		If SequenceTimer.CheckBox_ScopeCH2.Checked Then
			Chart_Scope.Series("Scope-Vrms_2").Points.AddXY(CurrentFreq, UserInterfaceShell.Scope_Channel_Display_2.display_dBm.Value_To_Display)
		End If

		If SequenceTimer.CheckBox_ScopeCH3.Checked Then
			Chart_Scope.Series("Scope-Vrms_3").Points.AddXY(CurrentFreq, UserInterfaceShell.Scope_Channel_Display_3.display_dBm.Value_To_Display)
		End If

		If SequenceTimer.CheckBox_ScopeCH4.Checked Then
			Chart_Scope.Series("Scope-Vrms_4").Points.AddXY(CurrentFreq, UserInterfaceShell.Scope_Channel_Display_4.display_dBm.Value_To_Display)
		End If



		Chart_Scope.ChartAreas(0).AxisX.IsLogarithmic = True
		Chart_Update_Horizontal(SequenceTimer.SweepStart.Text, SequenceTimer.SweepStop.Text)
		Chart_Scope.ChartAreas(0).AxisX.IsMarginVisible = False




		''This should be global but it;'s here for test
		'Try

		'	TextBox1.Text = Chart_Scope.ChartAreas(0).AxisY.Minimum
		'	TextBox2.Text = Chart_Scope.ChartAreas(0).AxisY.Maximum


		'	If Chart_Scope.ChartAreas(0).AxisY.Minimum > 0 Then
		'		TrackBar1.Maximum = Chart_Scope.ChartAreas(0).AxisY.Minimum
		'		TrackBar1.Minimum = Chart_Scope.ChartAreas(0).AxisY.Minimum + 100

		'	End If

		'	If Chart_Scope.ChartAreas(0).AxisY.Maximum > 0 Then
		'		TrackBar2.Minimum = Chart_Scope.ChartAreas(0).AxisY.Maximum
		'		TrackBar2.Maximum = Chart_Scope.ChartAreas(0).AxisY.Maximum + 100

		'	End If

		'Catch ex As Exception

		'End Try

	End Sub


	Public Sub Chart_Update_VerticalScale(Min As Double, Max As Double)
		Chart_Scope.ChartAreas(0).AxisY.Minimum = CDbl(Min)
		Chart_Scope.ChartAreas(0).AxisY.Maximum = CDbl(Max)

	End Sub


	Public Sub Chart_Update_Horizontal(Min As Double, Max As Double)
		Chart_Scope.ChartAreas(0).AxisX.Minimum = CDbl(Min)
		Chart_Scope.ChartAreas(0).AxisX.Maximum = CDbl(Max)

	End Sub


	Public Sub ClearAll()

		Chart_Scope.Series.Clear()
		Chart_Scope.ChartAreas(0).AxisX.IsLogarithmic = False

		Chart_Scope.Series.Add("Scope-Vrms_1")
		Chart_Scope.Series("Scope-Vrms_1").ChartType = SeriesChartType.Point
		Chart_Scope.Series("Scope-Vrms_1").Color = ChangeNumbertoColor(1)

		Chart_Scope.Series.Add("Scope-Vrms_2")
		Chart_Scope.Series("Scope-Vrms_2").ChartType = SeriesChartType.Point
		Chart_Scope.Series("Scope-Vrms_2").Color = ChangeNumbertoColor(2)


		Chart_Scope.Series.Add("Scope-Vrms_3")
		Chart_Scope.Series("Scope-Vrms_3").ChartType = SeriesChartType.Point
		Chart_Scope.Series("Scope-Vrms_3").Color = ChangeNumbertoColor(3)

		Chart_Scope.Series.Add("Scope-Vrms_4")
		Chart_Scope.Series("Scope-Vrms_4").ChartType = SeriesChartType.Point
		Chart_Scope.Series("Scope-Vrms_4").Color = ChangeNumbertoColor(4)


	End Sub



	Private Sub Chart_Scope_Click(sender As Object, e As EventArgs) Handles Chart_Scope.Click

	End Sub

	Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

		Chart_Update_VerticalScale(TrackBar1.Value, TrackBar2.Value)

	End Sub

	Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
		Chart_Update_VerticalScale(TrackBar1.Value, TrackBar2.Value)
	End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

	End Sub

	Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

	End Sub
End Class