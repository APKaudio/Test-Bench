
Imports System.Windows.Forms.DataVisualization.Charting


Module SpectrumAnalyzerFunctions

	Public DEVICE As BenchInstrumentItem




	Public SA_Data(20) As BenchValues
	Public SA_Counter As Integer
	Public AverageWait As Integer = 300

	Public Sub SpectrumAnalyzer_Address()

		DEVICE = New BenchInstrumentItem
		DEVICE.Name = "SPECTRUM"

		DEVICE.Address.IP = "44.44.44.222" ''spectrum_BusinessLogic.TextBox_Device_IP.Text
		DEVICE.Address.GPIB_Bus = 7
		DEVICE.Address.GPIB_Address = 18

		DEVICE.ConnectToGPIB()

		If DEVICE.Connected Then
			DEVICE.ChangeName("Spectrum Analyzer")
			DEVICE.GetDeviceIDN()
			DEVICE.DeviceReset()

			Set_Freq_Center(0, 100)
			Set_Freq_Span(0, 100)
		End If


		SA_Data(0).Units = spectrum_BusinessLogic.SA_Unit.Text
		VideoAveraging(False)


	End Sub







	Public Sub SpectrumAnalyzer_RebootDevice()
		''DEVICE.Say(":SYSTem:POWer:RESet")
		DEVICE.Say("RST")

	End Sub

	Public Sub SpectrumAnalyzer_ResetDevice()
		DEVICE.Say("*RST")

	End Sub



	Public Sub Set_Freq_Center(Index As Integer, Set_Frequency As Double)
		CommandList(System.Reflection.MethodBase.GetCurrentMethod.Name & "(" & Index & ")")
		If SA_Data(0).CenterFreq = Set_Frequency Then
			'do nothing
		Else
			Try

				'SpectrumAnalyzer.SCIP.WriteString("CF " & SA_Data(Index).CenterFreq & SA_Data(Index).Units)
				''DEVICE.Say("FREQuency:CENTer " & Set_Frequency & SA_Data(Index).Units)
				DEVICE.Say("CF " & Set_Frequency & SA_Data(Index).Units)

				SA_Data(Index).CenterFreq = Set_Frequency

				spectrum_BusinessLogic.Textbox_SA_Center.Text = Set_Frequency
				spectrum_BusinessLogic.TrackBar_Freq_Center_Major.Value = Math.Round(Set_Frequency)
				spectrum_BusinessLogic.Horizontal_Meter_Freq_Center.Value_To_Display = Set_Frequency
				'update the star and stop text boxes and store the data
				SA_Data(Index).StartFreq = SA_Data(Index).CenterFreq - ((SA_Data(Index).Span) / 2)
				spectrum_BusinessLogic.Textbox_StartFreq.Text = SA_Data(Index).StartFreq

				SA_Data(Index).StopFreq = SA_Data(Index).CenterFreq + ((SA_Data(Index).Span) / 2)
				spectrum_BusinessLogic.SA_StopFreq.Text = SA_Data(Index).StopFreq
			Catch ex As Exception
				ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
			End Try
		End If
	End Sub

	Public Sub Set_Freq_Span(Index As Integer, Set_Frequency As Double)


		If SA_Data(0).Span = Set_Frequency Then

			'do nothing

		Else
			Try
				'SpectrumAnalyzer.SCIP.WriteString("SP " & SA_Data(Index).Span & SA_Data(Index).Units)
				''DEVICE.Say("FREQuency:SPAN " & Set_Frequency & SA_Data(Index).Units)
				DEVICE.Say("SP " & Set_Frequency & SA_Data(Index).Units)
				SA_Data(Index).Span = Set_Frequency

				spectrum_BusinessLogic.Textbox_SA_Span.Text = Set_Frequency
				spectrum_BusinessLogic.TrackBar_Freq_Span.Value = Set_Frequency


				'update the star and stop text boxes and store the data
				SA_Data(Index).StartFreq = SA_Data(Index).CenterFreq - ((SA_Data(Index).Span) / 2)
				spectrum_BusinessLogic.Textbox_StartFreq.Text = SA_Data(Index).StartFreq

				SA_Data(Index).StopFreq = SA_Data(Index).CenterFreq + ((SA_Data(Index).Span) / 2)
				spectrum_BusinessLogic.SA_StopFreq.Text = SA_Data(Index).StopFreq

				CommandList(System.Reflection.MethodBase.GetCurrentMethod.Name & "(" & Index & ")")

			Catch ex As Exception
				ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
			End Try
		End If
	End Sub

	Public Sub Set_Freq_Start(Index As Integer)
		'LIST COMMAND 
		Try
			'SpectrumAnalyzer.SCIP.WriteString("FA " & SA_Data(Index).StartFreq & SA_Data(Index).Units)
			'DEVICE.Say("FREQuency:STARt " & SA_Data(Index).StartFreq & SA_Data(Index).Units)
			DEVICE.Say("FA " & SA_Data(Index).StartFreq & SA_Data(Index).Units)

			spectrum_BusinessLogic.Textbox_StartFreq.Text = SA_Data(Index).StartFreq
			CommandList(System.Reflection.MethodBase.GetCurrentMethod.Name & "(" & Index & ")")
		Catch ex As Exception
			ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
		End Try


	End Sub


	Public Function Get_Freq_Start()
		'LIST COMMAND 
		Try
			'SpectrumAnalyzer.SCIP.WriteString("FA " & SA_Data(Index).StartFreq & SA_Data(Index).Units)
			''DEVICE.Say("FREQuency:STARt?")
			DEVICE.Say("FA?")
			Return DEVICE.Listen()
			CommandList(System.Reflection.MethodBase.GetCurrentMethod.Name)
		Catch ex As Exception
			ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
		End Try


	End Function

	Public Function Get_Freq_Span()
		'LIST COMMAND 
		Try

			''DEVICE.Say("FREQuency:SPAN?")
			DEVICE.Say("SP?")
			Return DEVICE.Listen()
			CommandList(System.Reflection.MethodBase.GetCurrentMethod.Name)
		Catch ex As Exception
			ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
		End Try


	End Function

	Public Sub Set_Freq_Stop(Index As Integer)
		'LIST COMMAND 

		Try
			'SpectrumAnalyzer.SCIP.WriteString("FB " & SA_Data(Index).StopFreq & SA_Data(Index).Units)
			''DEVICE.Say("FREQuency:STOP " & SA_Data(Index).StopFreq & SA_Data(Index).Units)
			DEVICE.Say("FB " & SA_Data(Index).StopFreq & SA_Data(Index).Units)
			spectrum_BusinessLogic.SA_StopFreq.Text = SA_Data(Index).StopFreq
			CommandList(System.Reflection.MethodBase.GetCurrentMethod.Name)
		Catch ex As Exception
			ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
		End Try
	End Sub



	Public Sub Markers_State_On(marker As Integer)
		Try
			' SpectrumAnalyzer.SCIP.WriteString("MKPK HI")
			''DEVICE.Say("CALCulate:MARKer" & marker & ":STATe ON")
		Catch ex As Exception
			ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
		End Try
	End Sub

	Public Function Markers_Measure_Y_Value(marker As Integer)
		Try
			' SpectrumAnalyzer.SCIP.WriteString("MKPK HI")
			''DEVICE.Say("CALCulate:MARKer" & marker & ":Y?")

			Dim valuereceived As String = DEVICE.Listen()
			Return valuereceived

		Catch ex As Exception
			ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
		End Try
	End Function

	Public Function Markers_Measure_X_Value(marker As Integer)
		Try

			''DEVICE.Say("CALCulate:MARKer" & marker & ":X?")

			Dim valuereceived As String = DEVICE.Listen()
			Return valuereceived

		Catch ex As Exception
			ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
		End Try
	End Function


	Public Function preampOn(onoff As Boolean)
		Try
			If onoff Then
				''	DEVICE.Say(":POWer:GAIN ON")

			Else
				''DEVICE.Say(":POWer:GAIN OFF")

			End If
		Catch ex As Exception

		End Try
	End Function



	Public Function HighSensitivity(onoff As Boolean)
		Try
			If onoff Then
				''DEVICE.Say(":POWer:ATTenuation 0")
				''DEVICE.Say(":POWer:GAIN 1")
			Else
				''DEVICE.Say(":POWer:GAIN OFF")
			End If
		Catch ex As Exception

		End Try
	End Function


	Public Sub SA_Save_Screen_File()
		Try
			' SpectrumAnalyzer.SCIP.WriteString("MKPK HI")
			DEVICE.Say(":SYSTem:FILE:SAVE SCReen")
		Catch ex As Exception
			ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
		End Try
	End Sub

	Public Sub VideoAveraging(Enabeled As Boolean)

		Try
			If Enabeled Then
				' SpectrumAnalyzer.SCIP.WriteString("VAVG 100")
				DEVICE.Say("AVERage:TRACe1 ON")
				AverageWait = 1000

				'        SA_Data(Index).AveragingEnabled = True
			Else
				'SpectrumAnalyzer.Say("VAVG OFF")


				DEVICE.Say("AVERage:TRACe1 OFF")
				AverageWait = 300
				'       SA_Data(Index).AveragingEnabled = False
			End If
			'page 163 in programming
		Catch ex As Exception
			ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
		End Try

	End Sub




	Public Sub Get_Trace_Data(Index As Integer, chart As Integer)
		'LIST COMMAND 



		''		DEVICE.Say("TRACe:FORmat AScii")


		Dim current_span As Double
		Dim Current_Start As Double
		Dim Chart_division_size As Double

		Dim xpoint As String
		Dim ypoint As String

		Dim CharSeperator As String = ","


		If chart = 1 Then

			spectrum_BusinessLogic.Spectrum_Chart.Series(0).Points.Clear()

			''DEVICE.Say("FREQuency:SPAN " & SA_Data(Index).Span & SA_Data(Index).Units)
			DEVICE.Say("SP " & SA_Data(Index).Span & SA_Data(Index).Units)
			Threading.Thread.Sleep(AverageWait)
			'DEVICE.Say("*CLS")

			current_span = SA_Data(Index).Span
			Current_Start = SA_Data(Index).CenterFreq

			''DEVICE.Say("TRACe1:DATA?")
			DEVICE.Say("TRA?")
			SA_Data(Index).Trace = DEVICE.Listen()

			SA_Data(Index).SplitTrace = SA_Data(Index).Trace.Split(CharSeperator)
			'Mid(SA_Data(Index).Trace, 12).Split(CharSeperator)

			Chart_division_size = (current_span / SA_Data(Index).SplitTrace.Length()) / 1000000
			ChartSetup(0)

			For i = 0 To SA_Data(Index).SplitTrace.Length() - 1
				xpoint = (Current_Start / 1000000) + (Chart_division_size * i)
				ypoint = SA_Data(Index).SplitTrace(i)
				spectrum_BusinessLogic.Spectrum_Chart.Series(0).Points.AddXY(xpoint, ypoint)
			Next

			spectrum_BusinessLogic.Spectrum_Chart.ChartAreas(0).AxisX.MajorGrid.Interval = CInt((Chart_division_size * (SA_Data(Index).Trace.Length() / 6)))


		ElseIf chart = 2 Then



			''X2
			DEVICE.Say("FREQuency:SPAN " & SA_Data(Index).Span * 2 & SA_Data(Index).Units)
			Threading.Thread.Sleep(AverageWait)
			DEVICE.Say("*CLS")

			current_span = SA_Data(Index).Span * 2
			Current_Start = SA_Data(Index).CenterFreq

			DEVICE.Say("TRACe1:FORmat AScii")
			DEVICE.Say("TRACe1:DATA?")
			SA_Data(Index).Trace = DEVICE.Listen()

			SA_Data(Index).SplitTrace = SA_Data(Index).Trace.Split(CharSeperator)

			Chart_division_size = (current_span / SA_Data(Index).SplitTrace.Length()) / 1000000
			ChartSetup(1)

			For i = 0 To SA_Data(Index).SplitTrace.Length() - 1
				xpoint = (Current_Start / 1000000) + (Chart_division_size * i)
				ypoint = SA_Data(Index).SplitTrace(i)
				spectrum_BusinessLogic.Spectrum_Chart_X2.Series(0).Points.AddXY(xpoint, ypoint)
			Next

			spectrum_BusinessLogic.Spectrum_Chart_X2.ChartAreas(0).AxisX.MajorGrid.Interval = Math.Round(Chart_division_size * (SA_Data(Index).SplitTrace.Length() / 6))


		ElseIf chart = 3 Then
			''X10

			DEVICE.Say("FREQuency:SPAN " & SA_Data(Index).Span / 10 & SA_Data(Index).Units)

			Threading.Thread.Sleep(AverageWait)
			DEVICE.Say("*CLS")

			current_span = SA_Data(Index).Span / 10
			Current_Start = SA_Data(Index).CenterFreq

			''DEVICE.Say("TRACe1:DATA?")
			DEVICE.Say("TRA?")

			SA_Data(Index).Trace = DEVICE.Listen()

			SA_Data(Index).SplitTrace = SA_Data(Index).Trace.Split(CharSeperator)

			Chart_division_size = (current_span / SA_Data(Index).Trace.Length()) / 1000000
			ChartSetup(2)

			For i = 0 To SA_Data(Index).Trace.Length() - 2
				xpoint = (Current_Start / 1000000) + (Chart_division_size * i)
				ypoint = SA_Data(Index).SplitTrace(i)
				spectrum_BusinessLogic.Spectrum_Chart_X10.Series(0).Points.AddXY(xpoint, ypoint)
			Next

			spectrum_BusinessLogic.Spectrum_Chart_X10.ChartAreas(0).AxisX.Interval = Math.Round(Chart_division_size * (SA_Data(Index).Trace.Length() / 6))

		ElseIf chart = 4 Then
			''X100

			DEVICE.Say("FREQuency:SPAN " & SA_Data(Index).Span / 100 & SA_Data(Index).Units)
			Threading.Thread.Sleep(AverageWait)
			DEVICE.Say("*CLS")

			current_span = SA_Data(Index).Span / 100
			Current_Start = SA_Data(Index).CenterFreq

			DEVICE.Say("TRACe1:DATA?")
			SA_Data(Index).Trace = DEVICE.Listen()

			SA_Data(Index).SplitTrace = SA_Data(Index).Trace.Split(CharSeperator)

			Chart_division_size = (SA_Data(Index).Span / SA_Data(Index).Trace.Length()) / 1000000
			ChartSetup(3)

			For i = 0 To SA_Data(Index).Trace.Length() - 2

				xpoint = (Current_Start / 1000000) + (Chart_division_size * i)
				ypoint = SA_Data(Index).SplitTrace(i)
				spectrum_BusinessLogic.Spectrum_Chart_X100.Series(0).Points.AddXY(xpoint, ypoint)
			Next

			spectrum_BusinessLogic.Spectrum_Chart_X100.ChartAreas(0).AxisX.Interval = Math.Round(Chart_division_size * (SA_Data(Index).Trace.Length() / 6))
		End If

	End Sub


	Private Sub ChartSetup(index)

		Dim graphthreshold As Int16 = -0

		If index = 0 Then
			spectrum_BusinessLogic.Spectrum_Chart.ChartAreas(0).AxisX.MajorGrid.Enabled = True
			spectrum_BusinessLogic.Spectrum_Chart.ChartAreas(0).AxisX.LabelStyle.Angle = 90
			spectrum_BusinessLogic.Spectrum_Chart.ChartAreas(0).AxisY.MajorGrid.Enabled = True
			spectrum_BusinessLogic.Spectrum_Chart.ChartAreas(0).AxisY.MajorGrid.Interval = 10
			spectrum_BusinessLogic.Spectrum_Chart.ChartAreas(0).AxisY.Maximum = graphthreshold
			spectrum_BusinessLogic.Spectrum_Chart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
			spectrum_BusinessLogic.Spectrum_Chart.Series(0).IsVisibleInLegend = False
			spectrum_BusinessLogic.Spectrum_Chart.Series(0).Points.Clear()

		ElseIf index = 1 Then
			spectrum_BusinessLogic.Spectrum_Chart_X2.ChartAreas(0).AxisX.MajorGrid.Enabled = True
			spectrum_BusinessLogic.Spectrum_Chart_X2.ChartAreas(0).AxisX.LabelStyle.Enabled = False

			spectrum_BusinessLogic.Spectrum_Chart_X2.ChartAreas(0).AxisY.Maximum = graphthreshold

			spectrum_BusinessLogic.Spectrum_Chart_X2.ChartAreas(0).AxisY.LabelStyle.Enabled = False
			spectrum_BusinessLogic.Spectrum_Chart_X2.ChartAreas(0).AxisY.MajorGrid.Enabled = False
			spectrum_BusinessLogic.Spectrum_Chart_X2.ChartAreas(0).AxisY.Interval = 10

			spectrum_BusinessLogic.Spectrum_Chart_X2.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
			spectrum_BusinessLogic.Spectrum_Chart_X2.Series(0).IsVisibleInLegend = False
			spectrum_BusinessLogic.Spectrum_Chart_X2.Series(0).Points.Clear()

		ElseIf index = 2 Then
			spectrum_BusinessLogic.Spectrum_Chart_X10.ChartAreas(0).AxisX.MajorGrid.Enabled = True
			spectrum_BusinessLogic.Spectrum_Chart_X10.ChartAreas(0).AxisX.LabelStyle.Enabled = False
			spectrum_BusinessLogic.Spectrum_Chart_X10.ChartAreas(0).AxisY.Maximum = graphthreshold

			spectrum_BusinessLogic.Spectrum_Chart_X10.ChartAreas(0).AxisY.LabelStyle.Enabled = False
			spectrum_BusinessLogic.Spectrum_Chart_X10.ChartAreas(0).AxisY.MajorGrid.Enabled = False
			spectrum_BusinessLogic.Spectrum_Chart_X10.ChartAreas(0).AxisY.Interval = 10
			spectrum_BusinessLogic.Spectrum_Chart_X10.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
			spectrum_BusinessLogic.Spectrum_Chart_X10.Series(0).IsVisibleInLegend = False
			spectrum_BusinessLogic.Spectrum_Chart_X10.Series(0).Points.Clear()

		ElseIf index = 3 Then
			spectrum_BusinessLogic.Spectrum_Chart_X100.ChartAreas(0).AxisX.MajorGrid.Enabled = True
			spectrum_BusinessLogic.Spectrum_Chart_X100.ChartAreas(0).AxisX.LabelStyle.Enabled = False
			spectrum_BusinessLogic.Spectrum_Chart_X100.ChartAreas(0).AxisY.Maximum = graphthreshold
			spectrum_BusinessLogic.Spectrum_Chart_X100.ChartAreas(0).AxisY.LabelStyle.Enabled = False
			spectrum_BusinessLogic.Spectrum_Chart_X100.ChartAreas(0).AxisY.MajorGrid.Enabled = False
			spectrum_BusinessLogic.Spectrum_Chart_X100.ChartAreas(0).AxisY.Interval = 10
			spectrum_BusinessLogic.Spectrum_Chart_X100.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
			spectrum_BusinessLogic.Spectrum_Chart_X100.Series(0).IsVisibleInLegend = False
			spectrum_BusinessLogic.Spectrum_Chart_X100.Series(0).Points.Clear()

		End If

	End Sub

	Public Sub LabelScreen(Index As Integer)

		Try
			Dim displaywithoutspaces As String = SA_Data(Index).Name.Replace(" ", "_")

			DEVICE.Say("TITLE " & displaywithoutspaces)

		Catch ex As Exception
			ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
		End Try
	End Sub

	Public Sub Tune_To_Preset(PresetToTune As Integer)

		Set_Freq_Span(PresetToTune, SA_Data(PresetToTune).Span)
		Set_Freq_Center(PresetToTune, SA_Data(PresetToTune).CenterFreq)
		LabelScreen(PresetToTune)
		'    FindPeak()

	End Sub

	Public Sub Markers_Show_all()
		Try
			' SpectrumAnalyzer.SCIP.WriteString("MKPK HI")
			DEVICE.Say("CALCulate:MARKer:ALL")

			Markers_State_On(1)

			spectrum_BusinessLogic.Horizontal_Meter_Marker_Level_1.Value_To_Display = Markers_Measure_Y_Value(1)
			spectrum_BusinessLogic.Horizontal_Meter_Xvalue_1.Value_To_Display = Markers_Measure_X_Value(1) / 1000000

			Markers_State_On(2)
			spectrum_BusinessLogic.Horizontal_Meter_Marker_Level_2.Value_To_Display = Markers_Measure_Y_Value(2)
			spectrum_BusinessLogic.Horizontal_Meter_Xvalue_2.Value_To_Display = Markers_Measure_X_Value(2) / 1000000

			Markers_State_On(3)
			spectrum_BusinessLogic.Horizontal_Meter_Marker_Level_3.Value_To_Display = Markers_Measure_Y_Value(3)
			spectrum_BusinessLogic.Horizontal_Meter_Xvalue_3.Value_To_Display = Markers_Measure_X_Value(3) / 1000000

			Markers_State_On(4)
			spectrum_BusinessLogic.Horizontal_Meter_Marker_Level_4.Value_To_Display = Markers_Measure_Y_Value(4)
			spectrum_BusinessLogic.Horizontal_Meter_Xvalue_4.Value_To_Display = Markers_Measure_X_Value(4) / 1000000

			Markers_State_On(5)
			spectrum_BusinessLogic.Horizontal_Meter_Marker_Level_5.Value_To_Display = Markers_Measure_Y_Value(5)
			spectrum_BusinessLogic.Horizontal_Meter_Xvalue_5.Value_To_Display = Markers_Measure_X_Value(5) / 1000000

			Markers_State_On(6)
			spectrum_BusinessLogic.Horizontal_Meter_Marker_Level_6.Value_To_Display = Markers_Measure_Y_Value(6)
			spectrum_BusinessLogic.Horizontal_Meter_Xvalue_6.Value_To_Display = Markers_Measure_X_Value(6) / 1000000
			DEVICE.Say("CALCulate:MARKer:OFF")

		Catch ex As Exception
            ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub


End Module
