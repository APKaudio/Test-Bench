Imports System.Data.OleDb
Module ExcelExtensions
    Public Enum UseHeader
        ''' <summary>
        ''' Indicates that the first row contains columnnames, no data
        ''' </summary>
        ''' <remarks></remarks>
        Yes
        ''' <summary>
        ''' Indicates that the first row does not contain columnnames
        ''' </summary>
        ''' <remarks></remarks>
        No
    End Enum
    Public Enum ExcelImex
        TryScan = 0
        Resolve = 1
    End Enum

    <System.Diagnostics.DebuggerStepThrough()>
    <System.Runtime.CompilerServices.Extension()>
    Public Sub SetExcelConnectionString(
        ByRef sender As OleDbConnection,
        ByVal FileName As String,
        ByVal Header As UseHeader,
        ByVal IMEX As ExcelImex)

        Dim Mode As String = CInt(IMEX).ToString
        Dim Builder As New OleDbConnectionStringBuilder With {.DataSource = FileName}
        If IO.Path.GetExtension(FileName).ToUpper = ".XLSX" Then
            Builder.Provider = "Microsoft.ACE.OLEDB.12.0"
            Builder.Add("Extended Properties", "Excel 12.0;IMEX=" & Mode & ";HDR=" & Header.ToString & ";")
        Else
            Builder.Provider = "Microsoft.Jet.OLEDB.4.0"
            Builder.Add("Extended Properties", "Excel 8.0;IMEX=" & Mode & ";HDR=" & Header.ToString & ";")
        End If

        sender.ConnectionString = Builder.ConnectionString
    End Sub
End Module
