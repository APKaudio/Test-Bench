Imports System.Windows.Forms.DataVisualization.Charting


Public Class BenchInstrumentItem


	Public ProtocolInformation As String = "5.7"

	'Electrical Connection
	Public Address As Address

	'General Information
	Public Name As String
	Public Purpose As String ' meter, analyzer, source, Switch

	'Physical Information
	Public Manufacturer As String
	Public Model As String
	Public Location As String ' physical Location

	Public Errors As String
	Public reconnect As MsgBoxResult = Nothing
	Public reconnectagain As Boolean = True


	Public Matrix As BenchValues

	'DeviceStatus
	Public Connected As Boolean ' IS THE DEVICE ACTUALLY CONNECTED
	Public Output As Boolean ' is the output on of orr


	'talk to instruments
	Public ThingInstrumentSaid As String
	Public ThingToSayToInstrument As String

	Public ModeSCPI As String 'String formatted to send out the scip
	Public Mode As String 'Configuration Mode

	Public Linked As Integer ' the other channel its linked to
	Public Sweep As Sweep

	'Configuration Data
	Public Configuration As BenchValues 'This is the value the device should be set to
	Public Max As BenchValues
	Public Min As BenchValues

	'Data
	Public Read As BenchValues
	Public ReadSequence As Integer
	Public Display As XYValues ' Information about the Display
	Public Color As Color

	'Public AreasOfInterest As BenchValues ' what is is that you want to see

	Dim _DATA_Path As String = Application.StartupPath & "\"
	Dim _DATA_Name As String ' = Name & "-" & DateAndTime.DateString
	Dim _DATA_CSV As String '= _DATA_Path & _DATA_Name & ".CSV"
	Dim _DATA_SDP As String '= _DATA_Path & _DATA_Name & ".SDP"
	Friend ReadOnly SCIP As Object



	'XXXXXXXXXXXXXXXXXXDisplay 
	'  Public Window As InstrumentWindows

	Public Sub ReadSDP()


		'Address.IP = UserInterfaceShell.GPIB_IP.Text
		'Address.GPIB_Bus = UserInterfaceShell.GPIB_BUSS.Text

	End Sub




	Public Sub ConnectToGPIB()

		'THIS IS WHERE IT WOULD LOAD A PREVIOUS SESSION


		''IF NOT IN FILE SYSTEM = 
		_DATA_Name = Name & "-" & DateAndTime.DateString
		_DATA_CSV = _DATA_Path & _DATA_Name & ".CSV"
		_DATA_SDP = _DATA_Path & _DATA_Name & ".SDP"


		'Global IP address fo GPIB and GLOBAL BUS
		'//////////////////////////////////////////////////////////////
		'GPIB address SHOULD be defined as a setup parameter
		'Address.GPIB_Address = 

		Address.TCPIPVisaConfiguration = "TCPIP0::" & Address.IP & "::" & Address.GPIB_Bus & "," & Address.GPIB_Address & "::INSTR"

		'' I think this is how you could 



		'Dim TCPIPVisaConfiguration As String = "GPIB7::" & Address.GPIB & "::INSTR"

		If Ping(Address.IP) Then
			Try
				Address.Visa_Manager = New Ivi.Visa.Interop.ResourceManager
				Address.SCIP = New Ivi.Visa.Interop.FormattedIO488
				Address.SCIP.IO = Address.Visa_Manager.Open(Address.TCPIPVisaConfiguration)

				Address.Visa_Manager = New Ivi.Visa.Interop.ResourceManager
				Address.SCIP = New Ivi.Visa.Interop.FormattedIO488
				'' use instrument specific address for Open() parameter – i.e. GPIB0::22
				Address.SCIP.IO = Address.Visa_Manager.Open(Address.TCPIPVisaConfiguration)
				CommandList("CONNECT - " & Address.TCPIPVisaConfiguration)

				'DeviceReset()

				GetDeviceIDN()
				CommandList(Name & " " & Address.IDN & " CONNECTED")
				Connected = True


				reconnectagain = True
				SDP_Create()
			Catch ex As Exception
				Connected = False
				ErrorList(Name & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
			End Try
		ElseIf Connected = False Then

			reconnect = MsgBox(Name & " Failed to open - Would you like to retry connection", vbYesNo, Name & " -ERROR IN RESET")
			If reconnect = MsgBoxResult.Yes Then
				ConnectToGPIB()
			ElseIf reconnect = MsgBoxResult.No Then
				ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name & Name & "DONT RECONNECT ")
				'NOTHING HAPPENS
				reconnectagain = False
			End If

		Else
			Connected = False
			ErrorList(Name & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)


		End If


	End Sub


	Public Sub ConnectToIP()

		'THIS IS WHERE IT WOULD LOAD A PREVIOUS SESSION

		''IF NOT IN FILE SYSTEM = 
		_DATA_Name = Name & "-" & DateAndTime.DateString

		_DATA_CSV = _DATA_Path & _DATA_Name & ".CSV"
		_DATA_SDP = _DATA_Path & _DATA_Name & ".SDP"


		'Global IP address fo GPIB and GLOBAL BUS
		'//////////////////////////////////////////////////////////////
		'GPIB address SHOULD be defined as a setup parameter
		'Address.GPIB_Address = 

		Address.TCPIPVisaConfiguration = "TCPIP0::" & Address.IP & "::inst0::INSTR"
		'example '"TCPIP0::10.151.191.6::inst0::INSTR"

		If Ping(Address.IP) Then


			Try
				Address.Visa_Manager = New Ivi.Visa.Interop.ResourceManager
				Address.SCIP = New Ivi.Visa.Interop.FormattedIO488
				Address.SCIP.IO = Address.Visa_Manager.Open(Address.TCPIPVisaConfiguration)

				'' use instrument specific address for Open() parameter – i.e. GPIB0::22
				CommandList("CONNECT - " & Address.TCPIPVisaConfiguration)

				Connected = True
				reconnectagain = True
				SDP_Create()
			Catch ex As Exception
				Connected = False
				ErrorList(Name & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
				reconnectagain = True
			End Try
		ElseIf Connected = False Then
			reconnect = MsgBox(Name & " Failed to open - Would you like to retry connection", vbYesNo, Name & " -ERROR IN RESET")
			If reconnect = MsgBoxResult.Yes Then
				ConnectToGPIB()
			ElseIf reconnect = MsgBoxResult.No Then
				ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name & Name & "DONT RECONNECT ")
				'NOTHING HAPPENS
				reconnectagain = False
			End If

		Else
			Connected = False
			ErrorList(Name & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
		End If


	End Sub

	'GET DEVICE IDN
	Public Function GetDeviceIDN() 'Get the IDN of the device Can also be used to confirm that a unit is plugged in
		If Connected Then
			Try
				Say("*IDN?")
				Address.IDN = Listen()

			Catch ex As Exception
				ErrorList(Name & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)
				ErrorList(Name & " " & "IDN " & Address.IDN & " NOT Connected")
				Connected = False

			End Try
		Else
			ErrorList(Name & " " & System.Reflection.MethodBase.GetCurrentMethod.Name)

		End If
		Return Address.IDN
	End Function

	'GET DEVICE IDN
	Public Sub DeviceReset() 'Get the IDN of the device Can also be used to confirm that a unit is plugged in

		Try
			Address.SCIP.WriteString("*RST")
		Catch ex As Exception

		End Try

	End Sub


	'DISCONNECT DEVICE
	Public Sub DisConnectToGPIB()
		Connected = False
	End Sub

	Public Sub ChangeName(NewName)
		Name = NewName
		'If Connected Then
		'	Say("DISP:TEXT """ & Name & """")
		'End If
	End Sub

	Public Sub Clear()
		Say("*CLS")
	End Sub


	'TALK TO DEVICe
	Public Sub Say(ThingToSay As String)

		ThingToSayToInstrument = ThingToSay
		If Connected Then
			Try


				Address.SCIP.WriteString(ThingToSay)

				Data_CSV_ADD()
				CommandList(Name & " " & "GBIP SAY: " & Address.GPIB_Address & " : " & ThingToSay)

				If ThingToSay.IndexOf("?") = -1 Then

					SDPAdd(ThingToSay)

				End If

				ThingToSay = ""
			Catch ex As Exception
				ErrorList(Name & " " & System.Reflection.MethodBase.GetCurrentMethod.Name & "=" & ThingToSay)
			End Try
		Else
			DeviceReset()
			ErrorList(Name & " " & System.Reflection.MethodBase.GetCurrentMethod.Name & "=" & ThingToSay)
		End If


	End Sub



	'LISTEN TO DEVICE
	Public Function Listen() As String
		ThingInstrumentSaid = ""
		If Connected Then
			Try
				ThingInstrumentSaid = Address.SCIP.ReadString()
				DataList(Name & " " & "GBIP LISTEN: " & Address.GPIB_Address & " : " & ThingInstrumentSaid)
				Data_CSV_ADD()

			Catch ex As Exception
				ErrorList(Name & " " & System.Reflection.MethodBase.GetCurrentMethod.Name & "=" & ThingInstrumentSaid)
				ThingInstrumentSaid = 0
			End Try
		Else
			DeviceReset()

			ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
			ThingInstrumentSaid = 0
		End If
		Return ThingInstrumentSaid

	End Function



	Public Function Data_CSV_ADD()

		Try
			Dim CSVobjWriter As IO.StreamWriter = IO.File.AppendText(_DATA_CSV)
			Dim CharSep As String = ","

			If IO.File.Exists(_DATA_CSV) Then
				Dim stLine As String = ""
				CSVobjWriter.Write(DateAndTime.TimeOfDay & CharSep)
				CSVobjWriter.Write(Name & CharSep)
				CSVobjWriter.Write(ThingToSayToInstrument & CharSep)
				CSVobjWriter.Write(ThingInstrumentSaid)
				CSVobjWriter.Write(Environment.NewLine)
			Else
				Dim SDPWriter As IO.StreamWriter = IO.File.CreateText(_DATA_CSV)
			End If
			CSVobjWriter.Close()
		Catch ex As Exception
		End Try
	End Function


	Public Function SDP_Create()


		Try
			Dim SDPWriter As IO.StreamWriter = IO.File.CreateText(_DATA_SDP)

			If IO.File.Exists(_DATA_SDP) Then
				Dim stLine As String = ""
				SDPWriter.Write("V=")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("o=0 0 IN  IP4 " & System.Net.Dns.GetHostName())
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("S=" & Name)
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("T=" & DateAndTime.TimeString & DateAndTime.DateString)
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("A=clock-domain:NA" & Sweep.Freq)
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("m=" & Purpose & " " & Manufacturer)

				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("c=IN GPIB " & Address.TCPIPVisaConfiguration)  ';Stream Destination IP
				SDPWriter.Write(Environment.NewLine)
				'Address.TCPIPVisaConfiguration = "TCPIP0::" & Address.IP & "::" & Address.GPIB_Bus & "," & Address.GPIB & "::INSTR"
				SDPWriter.Write("a=rtpmap") ';Payload type:## Codec: L24, Sample rate 48000 / 8 Channels
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("a=sync-time:0") '
				SDPWriter.Write(Environment.NewLine)

				SDPWriter.Write("a=framecount")
				SDPWriter.Write(Environment.NewLine)


				SDPWriter.Write("i=AES70=" & "Name,")



				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.COMPUTE.ENGINEERINGNOTATION.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.AMPLITUDE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.FUNCTION.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.MODE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.OUTPUTACTIVE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.SCALE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.SOURCE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.SOURCE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.TIMEBASEMAINSCALE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.UNIT.DBM,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.UNIT.FREQ,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.UNIT.IMPEDANCE,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.UNIT.VPP,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.UNIT.VRMS,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.UNIT.WATTS,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.DISPLAY.FONT.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.DISPLAY.FONTSIZE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.DISPLAY.ON.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.DISPLAY.USERDISPLAY.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.GPIB.CONECTION ESTABLISHED.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.GPIB.HP-IB_ADDRESS.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.GPIB.IPADDRESS.IPADDRESS,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.GPIB.MODE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.GPIB.SCIP.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.GPIB.SCIPFORMAT.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.AXIS INTERVAL.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.GRAPH.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.NAMEOFSOURCE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.READVALUE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.UNIT.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.UNIT.DBM,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.UNIT.FREQ,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.UNIT.OHM,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.UNIT.VRMS,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.UNIT.VDC,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.UNIT.VPP,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.UNIT.VRMS,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.UNIT.WATTS,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.WAVEDATARAW.READDATA,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.WAVEDATASPLIT.SPLITUPDATA,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.WINDOW.CLOSE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.WINDOW.MDIPARENT.START,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.WINDOW.OPEN.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.WINDOW.XPOSITION.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.WINDOW.YPOSITION.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70...UNIT.THD,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.BANDWIDTH.START,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.MARKER.CENTER.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.MARKER.NAME.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.MARKER.SPAN.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.SOURCE.BACK,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.SOURCE.FRONT,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.LINK.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.SETCURRENTLIMIT.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.GPIB.CURRENTSTATUS.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.OFFSET.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.COUPLING.COUPLING.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.RANGE.RANGE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.READ.LOGICVALUE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.TIMEBASE.TIMEBASE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.DUTYCYCLE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.CONFIG.TYPE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.SWEEP.CURRENTVALUE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.SWEEP.ENABLE.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.SWEEP.START.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.SWEEP.STOP.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.RELAY.BANK.BANK,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.RELAY.CONNECT.,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.RELAY.LOCKOUT.LOCKOUT,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.RELAY.MODULE.MODULE,")
				SDPWriter.Write(Environment.NewLine)
				SDPWriter.Write("i=AES70.RELAY.RELAYSTATUS.RELAYSTATUS,")
				SDPWriter.Write(Environment.NewLine)


				SDPWriter.Write("a=framerate:") '//Divisions per second
				SDPWriter.Write(Environment.NewLine)

				SDPWriter.Write("a=framecount")
				SDPWriter.Write(Environment.NewLine)

				SDPWriter.Write("a=framecount")
				SDPWriter.Write(Environment.NewLine)

				SDPWriter.Write("a=framecount")
				SDPWriter.Write(Environment.NewLine)

				SDPWriter.Write("a=framecount")
				SDPWriter.Write(Environment.NewLine)

				SDPWriter.Write("a=framecount")
				SDPWriter.Write(Environment.NewLine)

				SDPWriter.Write("a=framecount")
				SDPWriter.Write(Environment.NewLine)

				SDPWriter.Write("a=framecount")
				SDPWriter.Write(Environment.NewLine)



				SDPWriter.Write("a=framecount")
				SDPWriter.Write(Environment.NewLine)

				SDPWriter.Write("a=framecount")
				SDPWriter.Write(Environment.NewLine)

				SDPWriter.Write("a=framecount")
				SDPWriter.Write(Environment.NewLine)

				SDPWriter.Write("a=framecount")
				SDPWriter.Write(Environment.NewLine)



			End If
			SDPWriter.Close()
		Catch ex As Exception
		End Try
	End Function


	Public Function SDPAdd(InformationToAddend As String) ', Value As String)


		''THIS IS ALL WRONG you must add it to an array first the or declare each value or controller 


		Try
			Dim objWriter As IO.StreamWriter = IO.File.AppendText(_DATA_SDP)

			If IO.File.Exists(_DATA_SDP) Then

				'find the information 
				objWriter.Write("i=" & InformationToAddend) ' & "|||" & Value)
				objWriter.Write(Environment.NewLine)
			End If
			objWriter.Close()
		Catch ex As Exception
		End Try
	End Function


End Class




'////////////////////////////   
'DATA STRUCTURE
'////////////////////////////


Public Structure Address
	'address
	Public GPIB_Bus As String
	Public GPIB_Address As String 'the actual address on the device
	Public GPIB_Module As String
    Public IP As String
    Public USB As String
    Public Serial As String

	Public Channel As Integer 'used to deliniate a channel within a sequence



	Public Visa_Address As String
	Public SCIP As Ivi.Visa.Interop.FormattedIO488
	Public Visa_Manager As Ivi.Visa.Interop.ResourceManager

	Dim TCPIPVisaConfiguration As String
	'IDN:::::::::::::::::::::::::::::::::::::::::::
	Public IDN As String 'IDN of the Device 
    'NOTE some devices do not have IDN

    
End Structure

Public Structure XYValues
    'Span of time
    'Public XDivision As Double
    'Public Xmin As Double
    'Public XMax As Double
    'Public XSpan As Double

    '   Public YScale As Double
    '   Public YRange As Double
    '   Public YOffset As Double
    '   Public YMin As Double
    '   Public YMax As Double
    '  Public TimebaseMainScale As Double
    Public ChartScale As Double

    Public X As DimentionalInformation
    Public Y As DimentionalInformation


End Structure

Public Structure DimentionalInformation

    Public Label As String
    Public Minimum As Double
    Public Maximum As Double
    Public Span As Double 'How wide is the display of the instrument

    Public Range As Double ' what is the Vertical range of the measurements
    Public Interval As Double
    Public Scale As Double ' 
    Public Division As Double
    Public Offset As Double
    Public NumberOfDivisions As Integer
    Public Center As Double

End Structure

Public Structure Sweep

	Dim Freq As Double
	Dim Index As Integer

	Dim StartPoint As Integer
	Dim StoppingPoint As Integer
	Dim Steps As Integer
	Dim StepValue As Short

	Dim Enable As Boolean

End Structure











Public Structure BenchValues

	Public Port As Integer

	Public Raw As String



	Public RawWaveData As String
	Public SplitWaveData() As String
    Public DataTable As DataTable
    Public ScopeGraphSeries As Series

	Public WaveForm As Double
	Public TimeBase As Double
	Public Vertical As Double

	'Frequency
	Public Freq As Double
    Public Period As Double
    Public FreqStart As Double
    Public FreqStop As Double
    Public FreqSpan As Double

    Public Polarity As BooleanSwitch

	Public Amplitude As Double
	Public Units As String

	'voltage
	Public VAC As Double
    Public VDC As Double
    Public Vpp As Double
    Public Vrms As Double
	Public VrmsSeries As Series

	'Signal Strength
	Public dBm As Double
    Public dBu As Double
    Public dBr As Double

    'current
    Public IAC As Double
    Public IDC As Double

    'power
    Public Power As Double

    'load
    Public Resistance As Double
    Public Capacitance As Double
	Public Impedance As Integer

	'Diode
	Public Diode As Double

    'Distortion
    Public THD As Double
    Public Continuity As Boolean
    Public SignaltoNoise As Double



	Public LogicLevel As Boolean


	Public WaveformShape As String
	Public DutyCycle As String

	'Span
	Public Span As String
	Public CenterFreq As String
	Public StartFreq As String
	Public StopFreq As String



	Public Name As String

	Public Trace As String
	Public SplitTrace() As String





End Structure

Public Structure InstrumentWindows
    Public MdiParent
    Public Xposition
    Public Yposition
End Structure
