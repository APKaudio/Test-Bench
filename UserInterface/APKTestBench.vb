
Imports System.Windows.Forms.DataVisualization.Charting



Public Class UserInterfaceShell


	Private Sub UserInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'ConfigureYo()

		Me.Location = New Point(0, 0)
		Me.Height = 1000
		Me.Width = 3175



		APK_Bench_Router.Show()
		APK_Bench_Router.BringToFront()
		APK_Bench_Router.Location = New Point(3512, 4)

		SequenceTimer.Show()
		SequenceTimer.BringToFront()
		SequenceTimer.Location = New Point(1959, -726)


		Command_List_Form.Show()
		Command_List_Form.BringToFront()


		SoundSourceWindow.Show()
		SoundSourceWindow.BringToFront()
		SoundSourceWindow.Location = New Point(3500, 610)

		Freq_Chart.Show()
		Freq_Chart.BringToFront()
		Freq_Chart.Location = New Point(3570, 70)
	End Sub

	Private Sub RepositionAnnounce(sender As Object, e As EventArgs) Handles MyBase.Move
		Me.Text = "SOFTWARE " & " LOCATION X:" & Me.Location.X & " LOCATION Y:" & Me.Location.Y & " WIDTH:" & Me.Width & " HEIGHT:" & Me.Height
	End Sub

	Private Sub UserInterface_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
		TableLayoutPanelAllTables.Location = New Point(0, 0)
		TableLayoutPanelAllTables.Width = Me.Width
		TableLayoutPanelAllTables.Height = Me.Height - 30

		Me.Text = "SOFTWARE " & " LOCATION X:" & Me.Location.X & " LOCATION Y:" & Me.Location.Y & " WIDTH:" & Me.Width & " HEIGHT:" & Me.Height
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


	Private Sub AgilentESALSpectrumAnalyzerToolStripMenuItem_Click(sender As Object, e As EventArgs)

	End Sub


	Private Sub ButtonFindDevices_Click(sender As Object, e As EventArgs)
		FindDevices.Main()
	End Sub




	Private Sub LOADALLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOADALLToolStripMenuItem.Click
		'SequenceTimer.MdiParent = Me
	End Sub

	Private Sub FrequencyChartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrequencyChartToolStripMenuItem.Click
		Freq_Chart.Show()
	End Sub

	Private Sub SignalGeneratorToolStripMenuInstrument_Click(sender As Object, e As EventArgs)

	End Sub



	'' COAX Busses

	''COAX Devices



	Private Sub Button_SIGNAL_GEN_Click(sender As Object, e As EventArgs) Handles Button_SIGNAL_GEN.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 1)
	End Sub
	Private Sub Button_DIST_GEN_Click(sender As Object, e As EventArgs) Handles Button_GEN_2.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 2)
	End Sub

	Private Sub Button_ISO_IN_Click(sender As Object, e As EventArgs) Handles Button_ISO_A_IN.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 3)
	End Sub
	Private Sub Button_Bridging_Input_Click(sender As Object, e As EventArgs) Handles Button_Bridging_Input.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 4)
	End Sub


	Private Sub Button_PATCH_PANEL_OUT_Click(sender As Object, e As EventArgs) Handles Button_PATCH_PANEL_OUT.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 5)
	End Sub


	Private Sub Button_ISO_B_IN_Click(sender As Object, e As EventArgs) Handles Button_ISO_B_IN.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 7)
	End Sub

	Private Sub Button_DISTORTION_Click(sender As Object, e As EventArgs) Handles Button_DISTORTION.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 7)
	End Sub
	Private Sub Button_SPECTRUM_Click(sender As Object, e As EventArgs) Handles Button_SPECTRUM.Click
		sender.BackColor = APK_Bench_Router.ConnectWithAllowedBus(sender, 8)
	End Sub

	Private Sub Button_FROM_COAX_Click(sender As Object, e As EventArgs)
		APK_Bench_Router.DEVICE.Say("Open 0-100")
		Button_SPECTRUM.BackColor = Color.Transparent
		Button_DISTORTION.BackColor = Color.Transparent
		Button_PATCH_PANEL_OUT.BackColor = Color.Transparent
		Button_ISO_B_IN.BackColor = Color.Transparent
		Button_ISO_A_IN.BackColor = Color.Transparent
		Button_Bridging_Input.BackColor = Color.Transparent
		Button_GEN_2.BackColor = Color.Transparent
		Button_SIGNAL_GEN.BackColor = Color.Transparent
	End Sub

	Private Sub Button_BUSS_1_Click(sender As Object, e As EventArgs)
		sender.BackColor = APK_Bench_Router.AllowBus(sender, 10)
	End Sub

	Private Sub Button_BUSS_2_Click(sender As Object, e As EventArgs)
		sender.BackColor = APK_Bench_Router.AllowBus(sender, 20)
	End Sub

	Private Sub Button_BUSS_3_Click(sender As Object, e As EventArgs)
		sender.BackColor = APK_Bench_Router.AllowBus(sender, 30)
	End Sub

	Private Sub Button_BUSS_4_Click(sender As Object, e As EventArgs)
		sender.BackColor = APK_Bench_Router.AllowBus(sender, 40)
	End Sub

	Private Sub Scope_Channel_Display_2_Load(sender As Object, e As EventArgs) Handles Scope_Channel_Display_2.Load

	End Sub

	Private Sub Scope_Channel_Display_1_Load(sender As Object, e As EventArgs) Handles Scope_Channel_Display_1.Load

	End Sub

	Private Sub Scope_Channel_Display_3_Load(sender As Object, e As EventArgs) Handles Scope_Channel_Display_3.Load

	End Sub
End Class

