

'User “tandapho_Bench” was added to the database “tandapho_Bench_Data”.



Imports System.Data.SqlClient




Public Class databaseExplore

	'Server=myServerAddress;Database=myDataBase;User Id=myUsername; Password=myPassword


	Dim Connection As New SqlConnection("Data Source=69.27.124.150,1433;Database=tandapho_Bench_Data;User Id=tandapho_Bench; Password=Bench19*3")
	Dim cmd As SqlCommand
	Dim row As Integer


	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Connection.Open()


		cmd = New SqlCommand("insert into([stuname]) student values ('" & TextBox1.Text & "')", Connection)
		row = cmd.ExecuteNonQuery()
		If row > 0 Then
			MessageBox.Show("the row inserted" & row)
		End If
		Connection.Close()



	End Sub








	'    Private cn As OleDbConnection = New OleDbConnection
	'    Private DataSet1 As DataSet = New DataSet()
	'    Private ExcelAdapterImport As OleDbDataAdapter = New OleDbDataAdapter
	'    Private ExcelAdapterExport As OleDbDataAdapter = New OleDbDataAdapter
	'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

	'    cn.SetExcelConnectionString(
	'        IO.Path.Combine(Application.StartupPath, "file.xlsx"),
	'        UseHeader.Yes,
	'        ExcelImex.TryScan
	'    )

	'    Dim cmd As OleDbCommand = New OleDbCommand(
	'                              <SQL>
	'                                  SELECT DEVICE.CATEGORY.ACTION.,	Device,	Category,	Action,		COMMON	DATA TYPE,

	'                                  FROM [Sheet1$]
	'                              </SQL>.Value, cn)

	'        ExcelAdapterImport.SelectCommand = cmd

	'        cn.Open()

	'        ExcelAdapterImport.Fill(DataSet1, "Sheet1")
	'        cn.Close()

	'    cn.SetExcelConnectionString(
	'        IO.Path.Combine(Application.StartupPath, "file.xlsx"),
	'        UseHeader.Yes,
	'        ExcelImex.TryScan
	'    )

	'    cn.Open()

	'        Dim dt As DataTable = DataSet1.Tables("Sheet1")

	'        ExcelAdapterExport.InsertCommand = New OleDbCommand With
	'        {
	'            .CommandText = "INSERT INTO [Sheet1$] VALUES(@P1,@P2)", .Connection = cn
	'        }
	'        ExcelAdapterExport.InsertCommand.Parameters.Add(
	'        New OleDbParameter With {.ParameterName = "@P1", .OleDbType = OleDbType.WChar})
	'        ExcelAdapterExport.InsertCommand.Parameters.Add(
	'        New OleDbParameter With {.ParameterName = "@P2", .OleDbType = OleDbType.WChar})

	'        For Each row As DataRow In dt.Rows
	'            ExcelAdapterExport.InsertCommand.Parameters(0).Value =
	'            row.Field(Of String)("FirstName")
	'            ExcelAdapterExport.InsertCommand.Parameters(1).Value =
	'            row.Field(Of String)("LastName")
	'            ExcelAdapterExport.InsertCommand.ExecuteNonQuery()
	'        Next
	'        MessageBox.Show("Done")
	'    End Sub

	'Private Sub databaseExplore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	'End Sub
End Class
