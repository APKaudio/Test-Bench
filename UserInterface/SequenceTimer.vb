Imports System.Threading


Public Class SequenceTimer

	Structure EventCounterType
		Dim CountValue As Integer
		Dim CountLoops As Integer
		Dim EndValue As Integer
		Dim Interval As Integer
	End Structure

	Dim DefaulTestCycles As Integer = 40
	Dim DefaulTestInterval As Integer = 10

	Public SequenceCount As EventCounterType

	Private Sub RepositionAnnounce(sender As Object, e As EventArgs) Handles MyBase.Move
		Me.Text = "Sequence Timer" & " X:" & Me.Location.X & " Y:" & Me.Location.Y
	End Sub


	Private Sub SequenceTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		ConfigNumberOfCycles(DefaulTestCycles)
		ConfigInterval(DefaulTestInterval)
		ResetCounter()


	End Sub


	'____________________________________________________
	'NUMBER OF CYCLES

	Public Sub ConfigNumberOfCycles(NumberOfCycles As Integer)
		SequenceCount.EndValue = NumberOfCycles
		Trackbar_NumberOfTestCycles.Value = SequenceCount.EndValue
		Textbox_NumberOfTestCycles.Text = SequenceCount.EndValue
		SoundSourceWindow.SoundSource1.SGSweepCalculate()
	End Sub

	Public Sub DisplayNumberofCycles()
		TextDisplayCounter.Text = SequenceCount.CountValue
		TextDisplayCounterLoops.Text = SequenceCount.CountLoops
	End Sub

	Private Sub Trackbar_NumberOfTestCycles_Scroll_1(sender As Object, e As EventArgs) Handles Trackbar_NumberOfTestCycles.Scroll
		ConfigNumberOfCycles(Trackbar_NumberOfTestCycles.Value)
	End Sub



	Private Sub EndValueDisplay_TextChanged(sender As Object, e As EventArgs)
		ConfigNumberOfCycles(CDbl(Textbox_NumberOfTestCycles.Text))
	End Sub

	Public Sub ResetCounter()
		SequenceCount.CountValue = 0
		SequenceCount.CountLoops = 0
		SoundSourceWindow.SoundSource1.DEVICE.Sweep.Index = 0
		SoundSourceWindow.SoundSource1.SGSweepCalculate()
		DisplayNumberofCycles()

		Freq_Chart.ClearAll()
	End Sub




	'____________________________________________________
	'INTERVAL

	Public Sub ConfigInterval(IntervalTime As Integer)
		SequenceCount.Interval = IntervalTime
		Trackbar_Interval.Value = IntervalTime
		TextBox_Interval.Text = IntervalTime
		TestSequenceTimer.Interval = SequenceCount.Interval
	End Sub


	''this

	Private Sub Trackbar_Interval_Scroll_1(sender As Object, e As EventArgs) Handles Trackbar_Interval.Scroll
		ConfigInterval(Trackbar_Interval.Value)
	End Sub



	Private Sub TextBox_Interval_TextChanged(sender As Object, e As EventArgs)
		ConfigInterval(CDbl(TextBox_Interval.Text))
	End Sub






	'____________________________________________________
	'TIME START STOP

	Public Sub TIMER_START()
		TestSequenceTimer.Enabled = True

	End Sub

	Public Sub TIMER_STOP()
		TestSequenceTimer.Enabled = False
		Button_TimmerRun.Visible = True
	End Sub


	Private Sub Button_TimmerRun_Click(sender As Object, e As EventArgs) Handles Button_TimmerRun.Click


		If Button_TimmerRun.BackColor = Color.Transparent Then
			TIMER_START()

			Button_TimmerRun.Text = "STOP TEST"
			Button_TimmerRun.BackColor = Color.Orange

		Else
			TIMER_STOP()

			Button_TimmerRun.Text = "RUN TEST"
			Button_TimmerRun.BackColor = Color.Transparent

		End If


	End Sub

	Private Sub TestSequenceTimer_Tick(sender As Object, e As EventArgs) Handles TestSequenceTimer.Tick
		MeasureSelected()


		'Increment count

		If SequenceCount.CountValue >= SequenceCount.EndValue Then
			If CheckBox_Loop.Checked Then
				SequenceCount.CountLoops = SequenceCount.CountLoops + 1
				TextDisplayCounterLoops.Text = SequenceCount.CountLoops
				SequenceCount.CountValue = 0


			Else
				TIMER_STOP()
				ResetCounter()
				Button_TimmerRun.Text = "RUN TEST AGAIN"
				Button_TimmerRun.BackColor = Color.Transparent

			End If
			SoundSourceWindow.SoundSource1.SGSweepCalculate()

		End If
		SequenceCount.CountValue = SequenceCount.CountValue + 1
		DisplayNumberofCycles()


	End Sub



	'___________________________________________________
	'Measure things
	Public Sub MeasureSelected()




		If CheckBox_SignalGenSweep.Checked Then
			SoundSourceWindow.SoundSource1.sgsweep()


		End If

		Dim AnalysisTimeScale As Double = (1 / Math.Round(SoundSourceWindow.SoundSource1.DEVICE.Configuration.Freq, 5) / 4)

		If CheckBox_ScopeCH1.Checked Then
			If CheckBox_SignalGenSweep.Checked Then
				If UserInterfaceShell.Scope_Channel_Display_1.Button_FFT.BackColor = Color.Orange Then
					'do nothing
				Else
					If CheckBox_Autoscale.Checked Then

						UserInterfaceShell.Scope_Channel_Display_1.ScopeAutoscale(1)

					End If
					UserInterfaceShell.Scope_Channel_Display_1.Set_ScopeTimescale(1, AnalysisTimeScale)
				End If


			End If
				UserInterfaceShell.Scope_Channel_Display_1.Get_ScopeMeasureAll(1)
		End If

		If CheckBox_ScopeCH2.Checked Then
			If CheckBox_SignalGenSweep.Checked Then


				If UserInterfaceShell.Scope_Channel_Display_2.Button_FFT.BackColor = Color.Orange Then
					'do nothing
				Else
					If CheckBox_Autoscale.Checked Then

						UserInterfaceShell.Scope_Channel_Display_2.ScopeAutoscale(2)

					End If

					UserInterfaceShell.Scope_Channel_Display_2.Set_ScopeTimescale(1, AnalysisTimeScale)
				End If

			End If
			UserInterfaceShell.Scope_Channel_Display_2.Get_ScopeMeasureAll(1)
		End If

		If CheckBox_ScopeCH3.Checked Then
			If CheckBox_SignalGenSweep.Checked Then
				'

				'Dim t4 As Thread = Thread.CurrentThread



				If UserInterfaceShell.Scope_Channel_Display_3.Button_FFT.BackColor = Color.Orange Then
					'do nothing
				Else

					If CheckBox_Autoscale.Checked Then


						UserInterfaceShell.Scope_Channel_Display_3.ScopeAutoscale(3)

					End If

					UserInterfaceShell.Scope_Channel_Display_3.Set_ScopeTimescale(2, AnalysisTimeScale)
				End If


			End If
			UserInterfaceShell.Scope_Channel_Display_3.Get_ScopeMeasureAll(2)
		End If

		If CheckBox_ScopeCH4.Checked Then
			If CheckBox_SignalGenSweep.Checked Then
				Dim t5 As Thread = Thread.CurrentThread

				If UserInterfaceShell.Scope_Channel_Display_4.Button_FFT.BackColor = Color.Orange Then
					'do nothing
				Else
					If CheckBox_Autoscale.Checked Then

						UserInterfaceShell.Scope_Channel_Display_4.ScopeAutoscale(4)

					End If

					UserInterfaceShell.Scope_Channel_Display_4.Set_ScopeTimescale(2, AnalysisTimeScale)
				End If

			End If
			UserInterfaceShell.Scope_Channel_Display_4.Get_ScopeMeasureAll(2)
		End If


		If CheckBox_ScopeCH5.Checked Then
			'	UserInterfaceShell.Scope_Channel_Display_5.SetScopeTimescale(5, (1 / SoundSourceWindow.SoundSource1.SignalGen.Configuration.Freq) * 2)
			'	UserInterfaceShell.Scope_Channel_Display_5.ScopeMeasureAll(5)
		End If

		If CheckBox_ScopeCH6.Checked Then
			'	UserInterfaceShell.Scope_Channel_Display_6.SetScopeTimescale(6, (1 / SoundSourceWindow.SoundSource1.SignalGen.Configuration.Freq) * 2)
			'	UserInterfaceShell.Scope_Channel_Display_6.ScopeMeasureAll(6)
		End If


		'DMM
		If CheckBox_DMM1.Checked Then
			Dim t6 As Thread = Thread.CurrentThread
			UserInterfaceShell.DmmControl1.ReadDMM()
		End If

		If CheckBox_DMM5.Checked Then
			Dim t7 As Thread = Thread.CurrentThread
			UserInterfaceShell.DmmControl5.ReadDMM()
		End If

		If CheckBox_DMM2.Checked Then
			Dim thread_dmm2 As Thread = Thread.CurrentThread
			UserInterfaceShell.DmmControl2.ReadDMM()
		End If

		If CheckBox_DMM6.Checked Then
			Dim thread_dmm6 As Thread = Thread.CurrentThread
			UserInterfaceShell.DmmControl6.ReadDMM()
		End If

		If CheckBox_DMM3.Checked Then
			Dim thread_dmm2 As Thread = Thread.CurrentThread
			UserInterfaceShell.DmmControl3.ReadDMM()
		End If

		If CheckBox_DMM7.Checked Then
			Dim thread_dmm7 As Thread = Thread.CurrentThread
			UserInterfaceShell.DmmControl7.ReadDMM()
		End If

		If CheckBox_DMM4.Checked Then
			Dim thread_dmm4 As Thread = Thread.CurrentThread
			UserInterfaceShell.DmmControl4.ReadDMM()
		End If

		If CheckBox_DMM8.Checked Then
			Dim thread_dmm8 As Thread = Thread.CurrentThread
			UserInterfaceShell.DmmControl8.ReadDMM()
		End If

		If CheckBox_THD.Checked Then
		End If

		If CheckBox_PSU_frame_1.Checked Then
			Dim thread_PSU_1 As Thread = Thread.CurrentThread
			UserInterfaceShell.PsU_Module0.ReadPower()
		End If

		If CheckBox_PSU_frame_2.Checked Then
			Dim thread_PSU_2 As Thread = Thread.CurrentThread
			UserInterfaceShell.PsU_Module1.ReadPower()
		End If

		If CheckBox_PSU_frame_3.Checked Then
			Dim thread_PSU_3 As Thread = Thread.CurrentThread
			UserInterfaceShell.PsU_Module2.ReadPower()
		End If

		If CheckBox_PSU_frame_4.Checked Then
			Dim thread_PSU_4 As Thread = Thread.CurrentThread

			UserInterfaceShell.PsU_Module3.ReadPower()
		End If

		If CheckBox_PSU_frame_5.Checked Then

			Dim thread_PSU_5 As Thread = Thread.CurrentThread
			UserInterfaceShell.PsU_Module4.ReadPower()
		End If

		If CheckBox_PSU_frame_6.Checked Then
			Dim thread_PSU_6 As Thread = Thread.CurrentThread
			UserInterfaceShell.PsU_Module5.ReadPower()
		End If

		If CheckBox_PSU_frame_7.Checked Then
			Dim thread_PSU_7 As Thread = Thread.CurrentThread
			UserInterfaceShell.PsU_Module6.ReadPower()
		End If

		If CheckBox_PSU_frame_8.Checked Then
			Dim thread_PSU_8 As Thread = Thread.CurrentThread
			UserInterfaceShell.PsU_Module7.ReadPower()
		End If

		If CheckBox_SA.Checked Then
			Dim thread_PSU_9 As Thread = Thread.CurrentThread
			Tune_To_Preset(SequenceCount.CountValue + 1)
		End If



		If ChK_Graph_Measurements.Checked Then

			Freq_Chart.CHART_DMM_Values()
			Freq_Chart.CHART_PSU_Values()
			Freq_Chart.CHART_Scope_DBM_Values()


		End If

	End Sub

	Private Sub CheckBox_ScopeCH1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ScopeCH1.CheckedChanged
		UserInterfaceShell.Scope_Channel_Display_1.Visible = True
	End Sub

	Private Sub CheckBox_ScopeCH2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ScopeCH2.CheckedChanged
		UserInterfaceShell.Scope_Channel_Display_2.Visible = True
	End Sub

	Private Sub CheckBox_ScopeCH3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ScopeCH3.CheckedChanged
		UserInterfaceShell.Scope_Channel_Display_3.Visible = True
	End Sub

	Private Sub CheckBox_ScopeCH4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ScopeCH4.CheckedChanged
		UserInterfaceShell.Scope_Channel_Display_4.Visible = True
	End Sub

	Private Sub CheckBox_ScopeCH5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ScopeCH5.CheckedChanged
		'UserInterfaceShell.Scope_Channel_Display_5.Visible = True
	End Sub

	Private Sub CheckBox_ScopeCH6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ScopeCH6.CheckedChanged
		'	UserInterfaceShell.Scope_Channel_Display_6.Visible = True
	End Sub

	Private Sub CheckBox_DMM1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_DMM1.CheckedChanged
		UserInterfaceShell.DmmControl1.Visible = True
	End Sub

	Private Sub CheckBox_DMM2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_DMM2.CheckedChanged
		UserInterfaceShell.DmmControl2.Visible = True
	End Sub

	Private Sub CheckBox_DMM3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_DMM3.CheckedChanged
		UserInterfaceShell.DmmControl3.Visible = True
	End Sub

	Private Sub CheckBox_DMM4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_DMM4.CheckedChanged
		UserInterfaceShell.DmmControl4.Visible = True
	End Sub

	Private Sub CheckBox_DMM5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_DMM5.CheckedChanged
		UserInterfaceShell.DmmControl5.Visible = True
	End Sub

	Private Sub CheckBox_DMM6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_DMM6.CheckedChanged
		UserInterfaceShell.DmmControl6.Visible = True
	End Sub

	Private Sub CheckBox_DMM7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_DMM7.CheckedChanged
		UserInterfaceShell.DmmControl7.Visible = True
	End Sub

	Private Sub CheckBox_DMM8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_DMM8.CheckedChanged
		UserInterfaceShell.DmmControl8.Visible = True
	End Sub

	Private Sub CheckBox_PSU_frame_1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_PSU_frame_1.CheckedChanged
		UserInterfaceShell.PsU_Module0.Visible = True
	End Sub

	Private Sub CheckBox_PSU_frame_2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_PSU_frame_2.CheckedChanged
		UserInterfaceShell.PsU_Module1.Visible = True
	End Sub

	Private Sub CheckBox_PSU_frame_3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_PSU_frame_3.CheckedChanged
		UserInterfaceShell.PsU_Module2.Visible = True
	End Sub

	Private Sub CheckBox_PSU_frame_4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_PSU_frame_4.CheckedChanged
		UserInterfaceShell.PsU_Module3.Visible = True
	End Sub

	Private Sub CheckBox_PSU_frame_5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_PSU_frame_5.CheckedChanged
		UserInterfaceShell.PsU_Module4.Visible = True
	End Sub

	Private Sub CheckBox_PSU_frame_6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_PSU_frame_6.CheckedChanged
		UserInterfaceShell.PsU_Module5.Visible = True
	End Sub

	Private Sub CheckBox_PSU_frame_7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_PSU_frame_7.CheckedChanged
		UserInterfaceShell.PsU_Module6.Visible = True
	End Sub

	Private Sub CheckBox_PSU_frame_8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_PSU_frame_8.CheckedChanged
		UserInterfaceShell.PsU_Module7.Visible = True
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs)
		TIMER_STOP()
	End Sub

	Private Sub SweepEnable_Click(sender As Object, e As EventArgs) Handles SweepEnable.Click
		SoundSourceWindow.SoundSource1.SweepEnable_Click()
	End Sub

	Private Sub CheckBox_SignalGenSweep_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_SignalGenSweep.CheckedChanged
		SoundSourceWindow.BringToFront()


	End Sub




	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
		Switch___OpenClose.Show()
	End Sub

	Private Sub CheckBox_SA_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_SA.CheckedChanged
		spectrum_BusinessLogic.Show()
	End Sub

	Private Sub CheckBox_DCLoad_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_DCLoad.CheckedChanged
		DCLoadForm.Show()
	End Sub


	Private Sub CounterReset_Click_2(sender As Object, e As EventArgs) Handles CounterReset.Click
		ResetCounter()
	End Sub

	Private Sub TextDisplayCounterLoops_Click(sender As Object, e As EventArgs) Handles TextDisplayCounterLoops.Click

	End Sub
End Class