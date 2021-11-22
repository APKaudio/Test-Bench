Module Utilities



	Public Function ConvertToEngNotation(doubleValue As Double) As String
		Dim x As Double    ' --- Original Double (Floating-point)
		Dim y As Double    ' --- Mantissa
		Dim n As Long      ' --- Exponent
		Dim str As String
		Dim sign As String
		'On Error GoTo error_hander   ' --- uncomment for debug; disable when bug-free!
		x = doubleValue
		If x <> 0 Then
			If x < 0 Then
				' --- x *must* be positive for log function to work
				x = x * -1
				sign = "-"    ' --- we need to preserve the sign for output string
			End If
			n = 3 * CLng((Math.Log(x) / Math.Log(1000)))   ' --- calculate Exponent...
			'     (Converts: log-base-e to log-base-10)
			y = x / (10 ^ n)                     ' --- calculate Mantissa.
			If y < 1 Then                        ' --- if Mantissa <1 then...
				n = n - 3                        ' --- ...adjust Exponent and...
				y = x / (10 ^ n)                 ' --- ...recalculate Mantissa.
			End If
			' --- Create output string (special treatment when Exponent of zero; don't append "e")
			str = sign & y & IIf(n <> 0, "e" & IIf(n > 0, "+", "") & n, "")
		Else
			' --- if the value is zero, well, return zero...
			str = "0"
		End If
		ConvertToEngNotation = str
		Exit Function
error_hander:
        ' --- this is really just for debugging suspected problems
        Resume Next
    End Function

    Public Function ChangeNumbertoColor(NumberToConvert As Integer)
		Dim ColorToReturn As Color

		If CInt(Right(NumberToConvert, 1)) = 0 Then
			NumberToConvert = CInt(Right(NumberToConvert, 2)) / 10
		Else
			NumberToConvert = CInt(Right(NumberToConvert, 1))
		End If



		Select Case NumberToConvert
			Case 1
				ColorToReturn = Color.Brown
			Case 2
				ColorToReturn = Color.Red
			Case 3
				ColorToReturn = Color.Orange
			Case 4
				ColorToReturn = Color.Yellow
			Case 5
				ColorToReturn = Color.Green
			Case 6
				ColorToReturn = Color.Blue
			Case 7
				ColorToReturn = Color.Violet
			Case 8
				ColorToReturn = Color.Gray
			Case 9
				ColorToReturn = Color.White
			Case 0
				ColorToReturn = Color.Black

			Case -1
				ColorToReturn = Color.Brown
			Case -2
				ColorToReturn = Color.Red
			Case -3
				ColorToReturn = Color.Orange
			Case -4
				ColorToReturn = Color.Yellow
			Case -5
				ColorToReturn = Color.Green
			Case -6
				ColorToReturn = Color.Blue
			Case -7
				ColorToReturn = Color.Violet
			Case -8
				ColorToReturn = Color.Gray
			Case -9
				ColorToReturn = Color.White
			Case Else



				ColorToReturn = Color.Pink
		End Select

		Return ColorToReturn

    End Function

	Public Function ChangeColorIntoNumber(Colortoconvert As Color)
		Select Case Colortoconvert
			Case Color.Brown
				Return 1
			Case Color.Red
				Return 2
			Case Color.Orange
				Return 3
			Case Color.Yellow
				Return 4
			Case Color.Green
				Return 5
			Case Color.Blue
				Return 6
			Case Color.Violet
				Return 7
			Case Color.Gray
				Return 8
			Case Color.White
				Return 9
			Case Color.Black
				Return 10
			Case Else
				Return 666
		End Select

	End Function



	Public Function oddoreven(Number As Integer) As Int16
        If Number Mod 2 = 0 Then
            Number = 2
        Else
            Number = 1
        End If
        Return Number
    End Function

    Public Function Ping(hostNameOrAddress As String) As Boolean
		Try
			If My.Computer.Network.Ping(hostNameOrAddress) Then
				CommandList("Ping " & hostNameOrAddress)
				Return True
			Else
				ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
				Return False
			End If
		Catch ex As Exception
			ErrorList(System.Reflection.MethodBase.GetCurrentMethod.Name)
			Return False
		End Try

	End Function

	Public Function Convert_Vrms_to_dBM(VRMS As Double, Impedance As Integer)
		CommandList(System.Reflection.MethodBase.GetCurrentMethod.Name)
		Return (10 * Math.Log10((VRMS) ^ 2) / Impedance / (0.001))

	End Function


End Module
