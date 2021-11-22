Public Class APK_Bench_Router

	Public mux As BenchInstrumentItem
	Dim AllowedBus As Integer
	Dim AllowedCrossPoint As Integer

	Dim relay(1000) As Boolean

	Private Sub APK_Bench_Router_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.Size = New Size(1900, 600)
		UserInterfaceShell.Show()
		SetupRouter()
		mux.Say("open 000-999")

	End Sub

	Public Sub SetupRouter()
		mux = New BenchInstrumentItem
		mux.Address.GPIB = UserInterfaceShell.SWR_GPIB_ADDRESS.Text
		mux.ConnectToGPIB()
	End Sub

	Public Function AllowBus(sender As Object, NewlyAllowedBus As Integer)

		If relay(NewlyAllowedBus) = False Then
			AllowedBus = NewlyAllowedBus

			relay(NewlyAllowedBus) = True
			Return ChangeNumbertoColor(AllowedBus)

		ElseIf relay(NewlyAllowedBus) Then
			relay(NewlyAllowedBus) = False
			Return Color.Transparent
		End If




	End Function

	Public Function AllowCrossOver(NewlyAllowedBus As Integer)

		If AllowedBus = -1 Then
		Else
			If AllowedBus <> NewlyAllowedBus Then
				AllowedBus = NewlyAllowedBus
				Return ChangeNumbertoColor(AllowedBus)
			Else
				AllowedBus = 0
				Return Color.Transparent
			End If
		End If

	End Function


	Public Function ConnectWithAllowedBus(sender As Object, portNumber As Integer)

		If AllowedBus = -1 Then
			
		Else
			If sender.backcolor = Color.Transparent Then
				mux.Say("Connect " & portNumber & "," & AllowedBus)
				Return ChangeNumbertoColor(AllowedBus)
			Else
				mux.Say("Disconn " & portNumber & "," & AllowedBus)
				Return Color.Transparent
			End If
		End If

	End Function


	Public Function ConnectCrossPointLatch(sender As Object, portNumber As Integer)
		If sender.backcolor = Color.Transparent Then
			mux.Say("Close " & portNumber)
			Return ChangeNumbertoColor(portNumber)
		Else
			mux.Say("Open " & portNumber)
			Return Color.Transparent
		End If
	End Function



	Public Sub Route(Route_From As Integer, Route_To As Integer)
		mux.Say("connect " & Route_From & ", " & Route_To)
	End Sub




	''Balanced Sound Sources
	Private Sub Button_XFMR_OUT_L_Click(sender As Object, e As EventArgs) Handles Button_XFMR_OUT_L_701.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 701)
	End Sub

	Private Sub Button_XFMR_OUT_R_Click(sender As Object, e As EventArgs) Handles Button_OUT_R_721.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 721)
	End Sub

	Private Sub Button_NEUTRIK_OUT_L_Click(sender As Object, e As EventArgs) Handles Button_NEUTRIK_OUT_L_703.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 703)
	End Sub

	Private Sub Button_NEUTRIK_OUT_R_Click(sender As Object, e As EventArgs) Handles Button_OUT_R_723.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 723)
	End Sub

	Private Sub Button_Music_L_Click(sender As Object, e As EventArgs) Handles Button_Music_L_704.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 704)
	End Sub

	Private Sub Button_Music_R_Click(sender As Object, e As EventArgs) Handles Button_OUT_R_724.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 724)
	End Sub




	''BALANCE ANALYZERS
	Private Sub Button_XFMR_IN_L_Click(sender As Object, e As EventArgs) Handles Button_IN_L_711.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 711)
	End Sub

	Private Sub Button_XFMR_IN_R_Click(sender As Object, e As EventArgs) Handles Button_IN_R_731.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 731)
	End Sub

	Private Sub Button_NEUTRIK_IN_L_Click(sender As Object, e As EventArgs) Handles Button_IN_L_712.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 712)
	End Sub

	Private Sub Button_NEUTRIK_IN_R_Click(sender As Object, e As EventArgs) Handles Button_IN_R_732.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 732)
	End Sub

	Private Sub Button_SLM_L_Click(sender As Object, e As EventArgs) Handles Button_IN_L_713.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 713)
	End Sub

	Private Sub Button_SLM_R_Click(sender As Object, e As EventArgs) Handles Button_IN_R_733.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 733)
	End Sub

	Private Sub Button_Monitor_1_L_Click(sender As Object, e As EventArgs)
		sender.BackColor = ConnectCrossPointLatch(sender, 714)
	End Sub

	Private Sub Button_Monitor_1_R_Click(sender As Object, e As EventArgs)
		sender.BackColor = ConnectCrossPointLatch(sender, 734)
	End Sub

	Private Sub Button_Monitor_2_L_Click(sender As Object, e As EventArgs) Handles Button_IN_L_714.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 714)
	End Sub

	Private Sub Button_Monitor_2_R_Click(sender As Object, e As EventArgs) Handles Button_IN_R_734.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 734)
	End Sub

	Private Sub Button_AUX_OUT_L_702_Click(sender As Object, e As EventArgs) Handles Button_AUX_OUT_L_702.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 702)

	End Sub

	Private Sub Button_AUX_OUT_R_712_Click(sender As Object, e As EventArgs) Handles Button_OUT_R_722.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 712)

	End Sub





	'' EDAC OUTPUTS 1-36
	Private Sub Button_EDAC_OUT_A_1_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_A_1_401.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 401)
	End Sub

	Private Sub Button_EDAC_OUT_A_2_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_A_2_421.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 421)
	End Sub

	Private Sub Button_EDAC_OUT_A_3_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_A_3_402.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 402)
	End Sub

	Private Sub Button_EDAC_OUT_A_4_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_A_4_422.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 422)
	End Sub

	Private Sub Button_EDAC_OUT_A_5_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_A_5_403.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 403)
	End Sub

	Private Sub Button_EDAC_OUT_A_6_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_A_6_423.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 423)
	End Sub

	Private Sub Button_EDAC_OUT_A_7_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_A_7_404.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 404)
	End Sub

	Private Sub Button_EDAC_OUT_A_8_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_A_8_424.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 424)
	End Sub

	Private Sub Button_EDAC_OUT_A_9_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_A_9_405.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 405)
	End Sub

	Private Sub Button_EDAC_OUT_A_10_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_A_10_425.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 425)
	End Sub

	Private Sub Button_EDAC_OUT_A_11_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_A_11_406.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 406)
	End Sub

	Private Sub Button_EDAC_OUT_A_12_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_A_12_426.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 426)
	End Sub

	Private Sub Button_EDAC_OUT_B_13_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_B_13_501.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 501)
	End Sub

	Private Sub Button_EDAC_OUT_B_14_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_B_14_521.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 521)
	End Sub

	Private Sub Button_EDAC_OUT_B_15_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_B_15_502.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 502)
	End Sub

	Private Sub Button_EDAC_OUT_B_16_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_B_16_522.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 522)
	End Sub

	Private Sub Button_EDAC_OUT_B_17_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_B_17_503.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 503)
	End Sub

	Private Sub Button_EDAC_OUT_B_18_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_B_18_523.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 523)
	End Sub

	Private Sub Button_EDAC_OUT_B_19_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_B_19_504.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 504)
	End Sub

	Private Sub Button_EDAC_OUT_B_20_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_B_20_524.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 524)
	End Sub

	Private Sub Button_EDAC_OUT_B_21_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_B_21_505.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 505)
	End Sub

	Private Sub Button_EDAC_OUT_B_22_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_B_22_525.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 525)
	End Sub

	Private Sub Button_EDAC_OUT_B_23_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_B_23_506.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 506)
	End Sub

	Private Sub Button_EDAC_OUT_B_24_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_B_24_526.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 526)
	End Sub

	Private Sub Button_EDAC_OUT_C_25_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_C_25_601.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 601)
	End Sub

	Private Sub Button_EDAC_OUT_C_26_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_C_26_621.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 621)
	End Sub

	Private Sub Button_EDAC_OUT_C_27_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_C_27_602.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 602)
	End Sub

	Private Sub Button_EDAC_OUT_C_28_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_C_28_622.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 622)
	End Sub

	Private Sub Button_EDAC_OUT_C_29_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_C_29_603.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 603)
	End Sub

	Private Sub Button_EDAC_OUT_C_30_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_C_30_623.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 623)
	End Sub

	Private Sub Button_EDAC_OUT_C_31_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_C_31_604.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 604)
	End Sub

	Private Sub Button_EDAC_OUT_C_32_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_C_32_624.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 624)
	End Sub

	Private Sub Button_EDAC_OUT_C_33_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_C_33_605.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 605)
	End Sub

	Private Sub Button_EDAC_OUT_C_34_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_C_34_625.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 625)
	End Sub

	Private Sub Button_EDAC_OUT_C_35_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_C_35_606.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 606)
	End Sub

	Private Sub Button_EDAC_OUT_C_36_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_C_36_626.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 626)
	End Sub



	'' EDAC INPUTS
	Private Sub Button_EDAC_IN_A_1_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_A_1_411.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 411)
	End Sub

	Private Sub Button_EDAC_IN_A_2_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_A_2_431.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 431)
	End Sub

	Private Sub Button_EDAC_IN_A_3_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_A_3_412.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 412)
	End Sub

	Private Sub Button_EDAC_IN_A_4_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_A_4_432.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 432)
	End Sub

	Private Sub Button_EDAC_IN_A_5_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_A_5_413.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 413)
	End Sub

	Private Sub Button_EDAC_IN_A_6_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_A_6_433.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 433)
	End Sub

	Private Sub Button_EDAC_IN_A_7_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_A_7_414.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 414)
	End Sub

	Private Sub Button_EDAC_IN_A_8_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_A_8_434.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 434)
	End Sub

	Private Sub Button_EDAC_IN_A_9_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_A_9_415.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 415)
	End Sub

	Private Sub Button_EDAC_IN_A_10_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_A_10_435.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 435)
	End Sub

	Private Sub Button_EDAC_IN_A_11_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_A_11_416.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 416)
	End Sub

	Private Sub Button_EDAC_IN_A_12_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_A_12_436.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 436)
	End Sub

	Private Sub Button_EDAC_IN_B_13_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_B_13_511.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 511)
	End Sub

	Private Sub Button_EDAC_IN_B_14_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_B_14_531.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 531)
	End Sub

	Private Sub Button_EDAC_IN_B_15_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_B_15_512.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 512)
	End Sub

	Private Sub Button_EDAC_IN_B_16_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_B_16_532.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 532)
	End Sub

	Private Sub Button_EDAC_IN_B_17_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_B_17_513.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 513)
	End Sub

	Private Sub Button_EDAC_IN_B_18_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_B_18_533.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 533)
	End Sub

	Private Sub Button_EDAC_IN_B_19_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_B_19_514.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 514)
	End Sub

	Private Sub Button_EDAC_IN_B_20_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_B_20_534.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 534)
	End Sub

	Private Sub Button_EDAC_IN_B_21_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_B_21_515.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 515)
	End Sub

	Private Sub Button_EDAC_IN_B_22_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_B_22_535.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 535)
	End Sub

	Private Sub Button_EDAC_IN_B_23_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_B_23_516.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 516)
	End Sub

	Private Sub Button_EDAC_IN_B_24_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_B_24_536.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 536)
	End Sub

	Private Sub Button_EDAC_IN_C_25_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_C_25_611.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 611)
	End Sub

	Private Sub Button_EDAC_IN_C_26_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_C_26_631.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 631)
	End Sub

	Private Sub Button_EDAC_IN_C_27_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_C_27_612.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 612)
	End Sub

	Private Sub Button_EDAC_IN_C_28_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_C_28_632.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 632)
	End Sub

	Private Sub Button_EDAC_IN_C_29_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_C_29_613.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 613)
	End Sub

	Private Sub Button_EDAC_IN_C_30_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_C_30_633.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 633)
	End Sub

	Private Sub Button_EDAC_IN_C_31_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_C_31_614.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 614)
	End Sub

	Private Sub Button_EDAC_IN_C_32_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_C_32_634.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 634)
	End Sub

	Private Sub Button_EDAC_IN_C_33_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_C_33_615.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 615)
	End Sub

	Private Sub Button_EDAC_IN_C_34_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_C_34_635.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 635)
	End Sub

	Private Sub Button_EDAC_IN_C_35_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_C_35_616.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 616)
	End Sub

	Private Sub Button_EDAC_IN_C_36_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_C_36_636.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 636)
	End Sub






	''''EDAC OUTPUT XLR MALE - BUS CONNECTION 
	Private Sub Button_EDAC_OUT_A_L_490_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_A_L_490.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 490)
	End Sub

	Private Sub Button_EDAC_OUT_A_R_492_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_A_R_492.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 492)
	End Sub

	Private Sub Button_EDAC_OUT_B_L_590_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_B_L_590.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 590)
	End Sub

	Private Sub Button_EDAC_OUT_B_R_592_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_B_R_592.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 592)
	End Sub

	Private Sub Button_EDAC_OUT_C_L_690_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_C_L_690.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 690)
	End Sub

	Private Sub Button_EDAC_OUT_C_R_592_Click(sender As Object, e As EventArgs) Handles Button_EDAC_OUT_C_R_592.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 592)
	End Sub



	''EDAC INPUT XLR FEMALE - BUS CONNECTION 
	Private Sub Button_EDAC_IN_A_Click(sender As Object, e As EventArgs) Handles Bus.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 491)
	End Sub

	Private Sub Button_EDAC_IN_A_R_493_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_A_R_493.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 493)
	End Sub

	Private Sub Button_EDAC_IN_B_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_B_L_591.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 591)
	End Sub

	Private Sub Button_EDAC_IN_B_R_593_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_B_R_593.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 593)
	End Sub

	Private Sub Button_EDAC_IN_C_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_C_L_691.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 691)
	End Sub

	Private Sub Button_EDAC_IN_C_R_693_Click(sender As Object, e As EventArgs) Handles Button_EDAC_IN_C_R_693.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 693)
	End Sub





	''BalaNCED SOURCE BUS CONNECTION
	Private Sub Button_BAL_AB0_790_Click(sender As Object, e As EventArgs) Handles Button_BAL_AB0_790.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 790)
	End Sub

	Private Sub Button_BAL_AB2_Click(sender As Object, e As EventArgs) Handles Button_BAL_AB2_792.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 792)
	End Sub

	Private Sub Button_BAL_AB1_791_Click(sender As Object, e As EventArgs) Handles Button_BAL_AB1_791.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 791)
	End Sub

	Private Sub Button_BAL_AB3_793_Click(sender As Object, e As EventArgs) Handles Button_BAL_AB3_793.Click
		sender.BackColor = ConnectCrossPointLatch(sender, 793)
	End Sub


End Class