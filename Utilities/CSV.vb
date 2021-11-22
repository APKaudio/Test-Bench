Module CSV
    Public Sub Append(filename As String, CSVstring As String)


        Dim CSVWriter As IO.StreamWriter = IO.File.AppendText(filename)

        If IO.File.Exists(filename) Then
            CSVWriter.Write(CSVstring)
            CSVWriter.Write(Environment.NewLine)
        End If
        CSVWriter.Close()
    End Sub

    Public Sub Delete(filename As String)


        IO.File.Delete(filename)

    End Sub

    Function ReadLineWithNumberFrom(filename As String, ByVal lineNumber As Integer) As String



        Using file As New IO.StreamReader(filename)
            ' Skip all preceding lines: '
            For i As Integer = 1 To lineNumber - 1
                If file.ReadLine() Is Nothing Then
                    Throw New ArgumentOutOfRangeException("lineNumber")
                End If
            Next
            ' Attempt to read the line you're interested in: '
            Dim line As String = file.ReadLine()
            If line Is Nothing Then
                Throw New ArgumentOutOfRangeException("lineNumber")
            End If
            ' Succeded!
            Return line
        End Using
    End Function


    Public Sub ReadCSV(filename As String)




        'Try

        '    Dim reader As Stream    Reader = New System.IO.StreamReader(File.OpenRead(filename))
        '    Dim listA As New List(Of String)()


        '    If File.Exists(filename) Then
        '        File.Delete(filename)
        '    End If

        '    Dim sw As New StreamWriter(filename)
        '    Dim s As String = String.Empty

        '    While reader.Peek() >= 0
        '        Dim line As String = reader.ReadLine()
        '        Dim values As String() = line.Split(";"c)
        '        listA.Add(values(0))
        '        s = s + line + Chr(10)
        '    End While
        '    reader.Close()
        '    sw.Write(s)
        '    sw.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

    End Sub
End Module
