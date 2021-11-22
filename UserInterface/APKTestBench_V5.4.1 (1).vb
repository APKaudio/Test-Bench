
Imports System.Windows.Forms.DataVisualization.Charting



Public Class UserInterfaceShell


	Private Sub UserInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'ConfigureYo()

		Command_List_Form.Show()
		ESA_L1500A.Show()
		DCLoadForm.Show()
	End Sub





	'▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓░▓
	'Spectrum Analyzer

	Public Sub ShowSpectrumAnalyzer(sender As Object, e As EventArgs) Handles AudioAnalyzerToolStripMenuItem.Click

		If AgilentESALSpectrumAnalyzerToolStripMenuItem.Checked = False Then
			CommandList("ESA_L1500A.OPEN")

			ESA_L1500A.Show()
			ESA_L1500A.MdiParent = Me
		Else
			CommandList("ESA_L1500A.Close")

			ESA_L1500A.Close()

		End If

	End Sub


	Private Sub CommandBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommandBoxToolStripMenuItem.Click
		Command_List_Form.Show()
		Command_List_Form.TopMost = True

	End Sub


	'YO CONTROL


	Public Sub YOC_StartTimer()
		YoTimer.Enabled = True
	End Sub

	Public Sub YOC_StopTimer()
		YoTimer.Enabled = False
	End Sub

	Public Sub YoTimer_Tick(sender As Object, e As EventArgs) Handles YoTimer.Tick
		CommandList("Timer value:" & YoControl.YoControl.Timer)

		YoControl.YoControl.Timer = YoControl.YoControl.Timer + 1
		YoControl.YoControl.EnabledStatus = True
		If YoControl.YoControl.Timer >= 10 Then
			YoTimeOut.Value = 0
			YoControl.YoControl.Timer = 0
			YoControl.YoControl.EnabledStatus = False
			YOC_StopTimer()
		Else
			YoTimeOut.Value = 10 - YoControl.YoControl.Timer
		End If


	End Sub



	Private Sub RelaysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelaysToolStripMenuItem.Click
		Switch___OpenClose.Show()
		Switch___OpenClose.MdiParent = Me
	End Sub


	Private Sub AgilentESALSpectrumAnalyzerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgilentESALSpectrumAnalyzerToolStripMenuItem.Click
		ShowSpectrumAnalyzer(1, e)
	End Sub


	Private Sub ButtonFindDevices_Click(sender As Object, e As EventArgs)
		FindDevices.Main()

	End Sub


	Private Sub SigGen_FrequencyTrackBar_Scroll(sender As Object, e As EventArgs) Handles SigGen_FrequencyTrackBar.Scroll
		SoundSource1.SGChangeFreq(SigGen_FrequencyTrackBar.Value)
	End Sub

	Private Sub LOADALLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOADALLToolStripMenuItem.Click
		SequenceTimer.Show()
		SequenceTimer.TopMost = True
		'SequenceTimer.MdiParent = Me
	End Sub

	Private Sub FrequencyChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrequencyChartToolStripMenuItem.Click
		Freq_Chart_2.Show()
	End Sub

	Private Sub SignalGeneratorToolStripMenuInstrument_Click(sender As Object, e As EventArgs) Handles SignalGeneratorToolStripMenuInstrument.Click

	End Sub



	'' COAX Busses

	''COAX Devices

	Private Sub Button_SIGNAL_GEN_Click(sender As Object, e As EventArgs) Handles Button_SIGNAL_GEN.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 901)
	End Sub
	Private Sub Button_DIST_GEN_Click(sender As Object, e As EventArgs) Handles Button_DIST_GEN.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 902)
	End Sub
	Private Sub Button_Bridging_Input_Click(sender As Object, e As EventArgs) Handles Button_Bridging_Input.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 903)
	End Sub
	Private Sub Button_ISO_A_IN_Click(sender As Object, e As EventArgs) Handles Button_ISO_A_IN.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 904)
	End Sub
	Private Sub Button_ISO_B_IN_Click(sender As Object, e As EventArgs) Handles Button_ISO_B_IN.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 905)
	End Sub
	Private Sub Button_PATCH_PANEL_OUT_Click(sender As Object, e As EventArgs) Handles Button_PATCH_PANEL_OUT.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 906)
	End Sub
	Private Sub Button_DISTORTION_Click(sender As Object, e As EventArgs) Handles Button_DISTORTION.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 907)
	End Sub
	Private Sub Button_SPECTRUM_Click(sender As Object, e As EventArgs) Handles Button_SPECTRUM.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 908)
	End Sub

	Private Sub Button_FROM_COAX_Click(sender As Object, e As EventArgs) Handles Button_FROM_COAX.Click
		APK_Bench_Router.mux.Say("Open 900-999")
		Button_SPECTRUM.BackColor = Color.Transparent
		Button_DISTORTION.BackColor = Color.Transparent
		Button_PATCH_PANEL_OUT.BackColor = Color.Transparent
		Button_ISO_B_IN.BackColor = Color.Transparent
		Button_ISO_A_IN.BackColor = Color.Transparent
		Button_Bridging_Input.BackColor = Color.Transparent
		Button_DIST_GEN.BackColor = Color.Transparent
		Button_SIGNAL_GEN.BackColor = Color.Transparent
	End Sub

	Private Sub Button_BUSS_1_Click(sender As Object, e As EventArgs) Handles Button_BUSS_1.Click
		sender.BackColor = APK_Bench_Router.AllowBus(sender, 910)
	End Sub

	Private Sub Button_BUSS_2_Click(sender As Object, e As EventArgs) Handles Button_BUSS_2.Click
		sender.BackColor = APK_Bench_Router.AllowBus(sender, 920)
	End Sub

	Private Sub Button_BUSS_3_Click(sender As Object, e As EventArgs) Handles Button_BUSS_3.Click
		sender.BackColor = APK_Bench_Router.AllowBus(sender, 930)
	End Sub

	Private Sub Button_BUSS_4_Click(sender As Object, e As EventArgs) Handles Button_BUSS_4.Click
		sender.BackColor = APK_Bench_Router.AllowBus(sender, 940)
	End Sub

	Private Sub Button_Bridging_Input_Click_1(sender As Object, e As EventArgs) Handles Button_Bridging_Input.Click

	End Sub

	Private Sub SoundSource1_Load(sender As Object, e As EventArgs) Handles SoundSource1.Load

	End Sub

	Private Sub GPIB_IP_Click(sender As Object, e As EventArgs) Handles GPIB_IP.Click

	End Sub
End Class

