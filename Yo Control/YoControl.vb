
Imports System.Speech

Public Structure YoControler
    Dim Timer As Integer
    Dim EnabledStatus As Boolean
    Dim CommandStructure As String


    Dim WindowActions As String
    Dim Instruments As String
    Dim Units As String
    Dim Engineering As String
    Dim Numbers As String


End Structure




Module YoControl

    Public YoControl As YoControler

    Public WithEvents reco As New Recognition.SpeechRecognitionEngine

    Public Sub ConfigureYo()
        ''    reco.SetInputToDefaultAudioDevice()

        'Dim YoGrammer As New Recognition.SrgsGrammar.SrgsDocument
        'Dim YoBasicRule As New Recognition.SrgsGrammar.SrgsRule("YoBasicRule")
        'Dim YoBasic As New Recognition.SrgsGrammar.SrgsOneOf("Yo", "Computer", "Shit head", "TK")


        'Dim WindowGrammer As New Recognition.SrgsGrammar.SrgsDocument
        'Dim WindowActionsRule As New Recognition.SrgsGrammar.SrgsRule("WindowActionsRule")
        'Dim WindowActions As New Recognition.SrgsGrammar.SrgsOneOf("Open", "Hide", "Read", "Configure", "Capture", "patch", "start", "Stop")

        'Dim InstrumentGrammer As New Recognition.SrgsGrammar.SrgsDocument
        'Dim InstrumentsRule As New Recognition.SrgsGrammar.SrgsRule("InstrumentsRule")
        'Dim Instruments As New Recognition.SrgsGrammar.SrgsOneOf("Meter", "Scope", "Signal", "Power", "Analyzer", "Switch")

        'Dim UnitGrammer As New Recognition.SrgsGrammar.SrgsDocument
        'Dim UnitsRule As New Recognition.SrgsGrammar.SrgsRule("UnitsRule")
        'Dim Units As New Recognition.SrgsGrammar.SrgsOneOf("Volts", "Amps", "Ohms", "dBm", "Hertz", "Channel")

        'Dim EngineerGrammer As New Recognition.SrgsGrammar.SrgsDocument
        'Dim EngineeringRule As New Recognition.SrgsGrammar.SrgsRule("EngineeringRule")
        'Dim Engineering As New Recognition.SrgsGrammar.SrgsOneOf("Mili", "Kilo", "Mega")

        'Dim NumbersGrammer As New Recognition.SrgsGrammar.SrgsDocument
        'Dim NumbersRule As New Recognition.SrgsGrammar.SrgsRule("NumbersRule")
        'Dim Numbers As New Recognition.SrgsGrammar.SrgsOneOf("1", "2", "3", "4", "5", "6", "7", "8", "9",
        '                                                     "10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
        '                                                     "20", "21", "22", "23", "24", "25", "26", "27", "28", "29",
        '                                                     "30", "31", "32", "33", "34", "35", "36", "37", "38", "39",
        '                                                     "40", "41", "42", "43", "44", "45", "46", "47", "48", "49",
        '                                                     "50", "51", "52", "53", "54", "55", "56", "57", "58", "59",
        '                                                     "60", "61", "62", "63", "64", "65", "66", "67", "68", "69",
        '                                                     "70", "71", "72", "73", "74", "75", "76", "77", "78", "79",
        '                                                     "80", "81", "82", "83", "84", "85", "86", "87", "88", "89",
        '                                                     "90", "91", "92", "93", "94", "95", "96", "97", "98", "99",
        '                                                     "Point")





        'YoBasicRule.Add(YoBasic)
        'WindowActionsRule.Add(WindowActions)
        'InstrumentsRule.Add(Instruments)
        'UnitsRule.Add(Units)
        'EngineeringRule.Add(Engineering)
        'NumbersRule.Add(Numbers)



        'YoGrammer.Rules.Add(YoBasicRule)

        'WindowGrammer.Rules.Add(WindowActionsRule)
        'InstrumentGrammer.Rules.Add(InstrumentsRule)
        'UnitGrammer.Rules.Add(UnitsRule)
        'EngineerGrammer.Rules.Add(EngineeringRule)
        'NumbersGrammer.Rules.Add(NumbersRule)




        'YoGrammer.Root = YoBasicRule
        'WindowGrammer.Root = WindowActionsRule
        'InstrumentGrammer.Root = InstrumentsRule
        'UnitGrammer.Root = UnitsRule
        'EngineerGrammer.Root = EngineeringRule
        'NumbersGrammer.Root = NumbersRule

        'reco.LoadGrammar(New Recognition.Grammar(YoGrammer))
        'reco.LoadGrammar(New Recognition.Grammar(WindowGrammer))
        'reco.LoadGrammar(New Recognition.Grammar(InstrumentGrammer))
        'reco.LoadGrammar(New Recognition.Grammar(UnitGrammer))
        'reco.LoadGrammar(New Recognition.Grammar(EngineerGrammer))
        'reco.LoadGrammar(New Recognition.Grammar(NumbersGrammer))


        'reco.RecognizeAsync()
    End Sub

    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted

        reco.RecognizeAsync()

    End Sub


    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

        If e.Result.Grammar.RuleName = "YoBasicRule" Then
            UserInterfaceShell.YOC_StartTimer()
            YoClearValues()
        End If

        If YoControl.EnabledStatus = True Then

            If e.Result.Grammar.RuleName = "WindowActionsRule" Then

                YoControl.WindowActions = e.Result.Text

            ElseIf e.Result.Grammar.RuleName = "InstrumentsRule" Then
                YoControl.Instruments = e.Result.Text

            ElseIf e.Result.Grammar.RuleName = "UnitsRule" Then
                YoControl.Units = e.Result.Text

            ElseIf e.Result.Grammar.RuleName = "EngineeringRule" Then
                YoControl.Engineering = e.Result.Text

            ElseIf e.Result.Grammar.RuleName = "NumbersRule" Then
                YoControl.Numbers = e.Result.Text
            End If
        End If


        UserInterfaceShell.YoControlStatus.Text = YoControl.WindowActions & ";" & YoControl.Instruments & ";" & YoControl.Units & ";" & YoControl.Engineering & ";" & YoControl.Numbers
        'YoBasicRule.Add(YoBasic)


        '        Dim synth As New Synthesis.SpeechSynthesizer




        '        Select Case e.Result.Text

        '        Case


        'Case "Open Meter 1"
        '    UserInterface.DMM1_Show(1, e)
        '    UserInterface.StatusStrip1.Text = ""

        'Case "Open Meter 2"
        '    CommandList("SPOKEN:Open Meter 2")
        '    UserInterface.DMM2_Show(1, e)

        'Case "Open Meter 3"
        '    CommandList("SPOKEN:Open Meter 3")
        '    UserInterface.DMM3_Show(1, e)

        'Case "Open Meter 4"
        '    CommandList("SPOKEN:Open Meter 4")
        '    UserInterface.DMM4_Show(1, e)

        'Case "Open Meter 5"
        '    CommandList("SPOKEN:Open Meter 5")
        '    UserInterface.DMM5_Show(1, e)

        'Case "Open Meter 6"
        '    CommandList("SPOKEN:Open Meter 6")
        '    UserInterface.DMM6_Show(1, e)




        'Case "Open Scope 1"
        '    CommandList("SPOKEN:Open Scope 1")
        '    UserInterface.RigolChannelShow1(1, e)

        'Case "Open Scope 2"
        '    CommandList("SPOKEN:Open Scope 2")
        '    UserInterface.RigolChannelShow2(1, e)

        'Case "Open Scope 3"
        '    CommandList("SPOKEN:Open Scope 3")
        '    UserInterface.RigolChannelShow3(1, e)

        'Case "Open Scope 4"
        '    CommandList("SPOKEN:Open Scope 4")
        '    UserInterface.RigolChannelShow4(1, e)

        'Case "Open Scope 5"
        '    CommandList("SPOKEN:Open Scope 5")

        '    UserInterface.AgilentScopeShow(1, e)
        'Case "Open Scope 6"
        '    CommandList("SPOKEN:Open Scope 6")





        'Case "Open Signal"
        '    CommandList("SPOKEN:Open Signal")
        '    UserInterface.SignalGeneratorSHOW(1, e)
        'Case "Open Power 1"
        '    CommandList("SPOKEN:Open Power 1")
        '    UserInterface.PSU12Show(1, e)

        'Case "Open Power 2"
        '    CommandList("SPOKEN:Open Power 2")

        'Case "Open Power 3"
        '    CommandList("SPOKEN:Open Power 3")
        '    UserInterface.PSU34show(1, e)

        'Case "Open Power 4"
        '    CommandList("SPOKEN:Open Power ")
        '    UserInterface.PSU34show(1, e)

        'Case "yo read all meters"
        '    synth.SpeakAsync("Reading all them meters")

        'Case "yo power off"
        '    synth.SpeakAsync("The power is now off")

        'Case "yo status"
        '    synth.SpeakAsync("There is something funky going on. Chill the F out, Give me some time to figure it out. I got this")

        'Case "Yo Load All"
        '    synth.SpeakAsync("You asked for it")
        '    UserInterface.OpenEverything(e)

        'End Select



    End Sub


    Public Sub YoClearValues()

        YoControl.WindowActions = ""
        YoControl.Instruments = ""
        YoControl.Units = ""
        YoControl.Engineering = ""
        YoControl.Numbers = ""
        UserInterfaceShell.YoControlStatus.Text = "YoClearValues"
    End Sub
End Module
