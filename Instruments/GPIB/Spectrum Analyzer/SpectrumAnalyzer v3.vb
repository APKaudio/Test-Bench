Public Class spectrum_BusinessLogic


	Public PointofInterestOneScreen As Integer



	Private Sub spectrum_BusinessLogic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		SpectrumAnalyzer_Address()
		Timer_events.Enabled = True
		Timer_events.Start()
	End Sub

	'Private Sub ESA_L1500A_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	'End Sub

	Private Sub FormClose() Handles Me.Closing
		UserInterfaceShell.AgilentESALSpectrumAnalyzerToolStripMenuItem.Checked = False
	End Sub

	Private Sub SA_Button_1_Click(sender As Object, e As EventArgs) Handles SA_Button_1.Click
		Tune_To_Preset(1)
	End Sub

	Private Sub SA_Button_2_Click(sender As Object, e As EventArgs) Handles SA_Button_2.Click
		Tune_To_Preset(2)
	End Sub

	Private Sub SA_Button_3_Click(sender As Object, e As EventArgs) Handles SA_Button_3.Click
		Tune_To_Preset(3)
	End Sub

	Private Sub SA_Button_4_Click(sender As Object, e As EventArgs) Handles SA_Button_4.Click
		Tune_To_Preset(4)
	End Sub

	Private Sub SA_Button_5_Click(sender As Object, e As EventArgs) Handles SA_Button_5.Click
		Tune_To_Preset(5)
	End Sub

	Private Sub SA_Button_6_Click(sender As Object, e As EventArgs) Handles SA_Button_6.Click
		Tune_To_Preset(6)
	End Sub

	Private Sub SA_Button_7_Click(sender As Object, e As EventArgs) Handles SA_Button_7.Click
		Tune_To_Preset(7)
	End Sub

	Private Sub SA_Button_8_Click(sender As Object, e As EventArgs) Handles SA_Button_8.Click
		Tune_To_Preset(8)
	End Sub

	Private Sub SA_Button_9_Click(sender As Object, e As EventArgs) Handles SA_Button_9.Click
		Tune_To_Preset(9)
	End Sub

	Private Sub SA_Button_10_Click(sender As Object, e As EventArgs) Handles SA_Button_10.Click
		Tune_To_Preset(10)
	End Sub

	Private Sub SA_Button_11_Click(sender As Object, e As EventArgs) Handles SA_Button_11.Click
		Tune_To_Preset(11)
	End Sub

	Private Sub SA_Button_12_Click(sender As Object, e As EventArgs) Handles SA_Button_12.Click
		Tune_To_Preset(12)
	End Sub


	Private Sub SA_Button_13_Click(sender As Object, e As EventArgs) Handles SA_Button_13.Click
		Tune_To_Preset(13)
	End Sub

	Private Sub SA_Button_14_Click(sender As Object, e As EventArgs) Handles SA_Button_14.Click
		Tune_To_Preset(14)
	End Sub

	Private Sub SA_Button_15_Click(sender As Object, e As EventArgs) Handles SA_Button_15.Click
		Tune_To_Preset(15)
	End Sub

	Private Sub SA_Button_16_Click(sender As Object, e As EventArgs) Handles SA_Button_16.Click
		Tune_To_Preset(16)
	End Sub

	Private Sub SA_Button_17_Click(sender As Object, e As EventArgs) Handles SA_Button_17.Click
		Tune_To_Preset(17)
	End Sub

	Private Sub SA_Button_18_Click(sender As Object, e As EventArgs) Handles SA_Button_18.Click
		Tune_To_Preset(18)
	End Sub

	Private Sub Button_Averaging_Click(sender As Object, e As EventArgs) Handles Button_Averaging.Click


		If Button_Averaging.BackColor = Color.Orange Then
			VideoAveraging(False)
			Button_Averaging.BackColor = Color.Gray

		Else
			VideoAveraging(True)
			Button_Averaging.BackColor = Color.Orange
		End If
	End Sub



	Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar_Freq_Span.Scroll
		Set_Freq_Span(0, TrackBar_Freq_Span.Value)
	End Sub

	'Private Sub Button1_Click_2(sender As Object, e As EventArgs)
	'    SA_Counter = 0

	'    SA_Data(SA_Counter).CenterFreq = Textbox_SA_Center.Text
	'    SA_Data(SA_Counter).Span = Textbox_SA_Span.Text
	'    SA_Data(SA_Counter).Units = SA_Unit.Text


	'    Set_Freq_Center(SA_Counter, Textbox_SA_Center.Text)
	'    Set_Freq_Span(SA_Counter, Textbox_SA_Center.Text)
	'End Sub

	Private Sub TrackBarCenterFreq_Scroll_1(sender As Object, e As EventArgs) Handles TrackBar_Freq_Center_Major.Scroll, TrackBar_Freq_Center_Minor.Scroll
		Set_Freq_Center(0, TrackBar_Freq_Center_Major.Value + TrackBar_Freq_Center_Minor.Value / 1000)
	End Sub

	Private Sub SA_Center_TextChanged(sender As Object, e As EventArgs) Handles Textbox_SA_Center.Leave


		Set_Freq_Center(0, CInt(Textbox_SA_Center.Text))
	End Sub

	Private Sub SA_Span_TextChanged(sender As Object, e As EventArgs) Handles Textbox_SA_Span.Leave
		Set_Freq_Span(0, CInt(Textbox_SA_Span.Text))
	End Sub

	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		Command_List_Form.Show()

	End Sub

	Private Sub Button_Save_CSV_Click(sender As Object, e As EventArgs) Handles Button_Save_CSV.Click
		Dim result As DialogResult = OpenFileDialog1.ShowDialog()

		' Test result.
		If result = Windows.Forms.DialogResult.OK Then

			' Get the file name.
			Dim path As String = OpenFileDialog1.FileName




			CSV.Delete(path)

			For Dataindex = 1 To 18

				CSV.Append(path, SA_Data(Dataindex).CenterFreq & "," & SA_Data(Dataindex).Span & "," & SA_Data(Dataindex).Name & "," & SA_Data(Dataindex).Units)
			Next
		End If

	End Sub






	Private Sub Button_CSV_Load_Click(sender As Object, e As EventArgs) Handles Button_CSV_Load.Click

		Dim result As DialogResult = OpenFileDialog1.ShowDialog()

		' Test result.
		If result = Windows.Forms.DialogResult.OK Then

			' Get the file name.
			Dim path As String = OpenFileDialog1.FileName
			Try
				For DataIndex = 1 To 18

					Dim text() As String = CSV.ReadLineWithNumberFrom(path, DataIndex).Split(",")

					Dim SA_Data_item_freq() As Control = Controls.Find("SA_Freq_" & DataIndex, 1)
					SA_Data_item_freq(0).Text = text(0)
					SA_Data(DataIndex).CenterFreq = text(0)

					Dim SA_Data_item_span() As Control = Controls.Find("SA_Span_" & DataIndex, 1)
					SA_Data_item_span(0).Text = text(1)
					SA_Data(DataIndex).Span = text(1)

					Dim SA_Data_item_name() As Control = Controls.Find("SA_Name_" & DataIndex, 1)
					SA_Data(DataIndex).Name = text(2)
					SA_Data_item_name(0).Text = text(2)

					Dim SA_Data_item_Button() As Control = Controls.Find("SA_Button_" & DataIndex, 1)
					SA_Data_item_Button(0).Text = SA_Data(DataIndex).Name & "   @ " & SA_Data(DataIndex).CenterFreq

					SA_Data(DataIndex).Units = "MHZ"
				Next

			Catch ex As Exception

			End Try
		End If

	End Sub

	Private Sub Button_peak_Search_Click(sender As Object, e As EventArgs) Handles Button_peak_Search.Click
		If Button_peak_Search.BackColor = Color.Orange Then
			Button_peak_Search.BackColor = Color.Gray
		Else
			Button_peak_Search.BackColor = Color.Orange
		End If
	End Sub


	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		SA_Save_Screen_File()
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer_events.Tick

		If Button_Get_Trace.BackColor = Color.Orange Then
			Get_Trace_Data(0, 1)
		End If

		If Button_peak_Search.BackColor = Color.Orange Then
			Markers_Show_all()
		End If

		If Button_Get_X2.BackColor = Color.Orange Then
			Get_Trace_Data(0, 2)
		End If

		If Button_Get_Trace.BackColor = Color.Orange Then
			Get_Trace_Data(0, 1)
		End If

		If Button_peak_Search.BackColor = Color.Orange Then
			Markers_Show_all()
		End If

		If Button_Get_DIV_10.BackColor = Color.Orange Then
			Get_Trace_Data(0, 3)
		End If

		If Button_Get_Trace.BackColor = Color.Orange Then
			Get_Trace_Data(0, 1)
		End If

		If Button_Get_DIV_100.BackColor = Color.Orange Then
			Get_Trace_Data(0, 4)
		End If

	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		Markers_Show_all()
	End Sub


	Public Sub Get_Marker_Topsix()
		Horizontal_Meter_Marker_Level_1.Value_To_Display = Markers_Measure_Y_Value(1)
		Horizontal_Meter_Xvalue_1.Value_To_Display = Markers_Measure_X_Value(1) / 1000000

		Markers_State_On(2)
		Horizontal_Meter_Marker_Level_2.Value_To_Display = Markers_Measure_Y_Value(2)
		Horizontal_Meter_Xvalue_2.Value_To_Display = Markers_Measure_X_Value(2) / 1000000

		Markers_State_On(3)
		Horizontal_Meter_Marker_Level_3.Value_To_Display = Markers_Measure_Y_Value(3)
		Horizontal_Meter_Xvalue_3.Value_To_Display = Markers_Measure_X_Value(3) / 1000000

		Markers_State_On(4)
		Horizontal_Meter_Marker_Level_4.Value_To_Display = Markers_Measure_Y_Value(4)
		Horizontal_Meter_Xvalue_4.Value_To_Display = Markers_Measure_X_Value(4) / 1000000

		Markers_State_On(5)
		Horizontal_Meter_Marker_Level_5.Value_To_Display = Markers_Measure_Y_Value(5)
		Horizontal_Meter_Xvalue_5.Value_To_Display = Markers_Measure_X_Value(5) / 1000000

		Markers_State_On(6)
		Horizontal_Meter_Marker_Level_6.Value_To_Display = Markers_Measure_Y_Value(6)
		Horizontal_Meter_Xvalue_6.Value_To_Display = Markers_Measure_X_Value(6) / 1000000
	End Sub

	Private Sub Button_Get_Trace_Click(sender As Object, e As EventArgs) Handles Button_Get_Trace.Click

		If Button_Get_Trace.BackColor = Color.Orange Then
			Button_Get_Trace.BackColor = Color.Gray
		Else

			Button_Get_Trace.BackColor = Color.Orange
		End If


	End Sub

	Private Sub Button_PreAmp_Click(sender As Object, e As EventArgs) Handles Button_PreAmp.Click
		If Button_PreAmp.BackColor = Color.Orange Then
			Button_PreAmp.BackColor = Color.Gray
			preampOn(False)
		Else

			Button_PreAmp.BackColor = Color.Orange
			preampOn(True)
		End If

	End Sub

	Private Sub Button_Reset_Device_Click(sender As Object, e As EventArgs) Handles Button_Reset_Device.Click

		If Button_Reset_Device.BackColor = Color.Orange Then
			Button_Reset_Device.BackColor = Color.Gray

			Button_Reset_Device.Text = "Reboot"
			SpectrumAnalyzer_Address()
		Else

			Button_Reset_Device.BackColor = Color.Orange
			Button_Reset_Device.Text = "reconenct"
			SpectrumAnalyzer_RebootDevice()
		End If
	End Sub

	Private Sub Spectrum_Chart_Click(sender As Object, e As EventArgs) Handles Spectrum_Chart.MouseHover

		Spectrum_Chart.Series(0).LabelToolTip = "#VALX [#VALY]"
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_Get_DIV_10.Click
		If Button_Get_DIV_10.BackColor = Color.Orange Then
			Button_Get_DIV_10.BackColor = Color.Gray
		Else

			Button_Get_DIV_10.BackColor = Color.Orange
		End If
	End Sub

	Private Sub Button_Get_DIV_100_Click(sender As Object, e As EventArgs) Handles Button_Get_DIV_100.Click
		If Button_Get_DIV_100.BackColor = Color.Orange Then
			Button_Get_DIV_100.BackColor = Color.Gray
		Else

			Button_Get_DIV_100.BackColor = Color.Orange
		End If
	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button_Get_X2.Click
		If Button_Get_X2.BackColor = Color.Orange Then
			Button_Get_X2.BackColor = Color.Gray
		Else

			Button_Get_X2.BackColor = Color.Orange
		End If
	End Sub

	Private Sub Textbox_SA_Center_TextChanged(sender As Object, e As EventArgs) Handles Textbox_SA_Center.TextChanged

	End Sub

	Private Sub Button_High_Sensitivity_Click(sender As Object, e As EventArgs) Handles Button_High_Sensitivity.Click
		If Button_High_Sensitivity.BackColor = Color.Orange Then
			Button_High_Sensitivity.BackColor = Color.Gray
			HighSensitivity(False)
		Else
			HighSensitivity(True)
			Button_High_Sensitivity.BackColor = Color.Orange

		End If

	End Sub

	Private Sub Button2_Click_1(sender As Object, e As EventArgs)

	End Sub
End Class