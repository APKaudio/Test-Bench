
Imports System.Speech

Module YoTalkback

    Public synth As New Synthesis.SpeechSynthesizer

    Public Sub YoTalkback(Phrase As String)
        synth.SpeakAsync(Phrase)
    End Sub


End Module
