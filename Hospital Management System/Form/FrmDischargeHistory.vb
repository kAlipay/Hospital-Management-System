Public Class FrmDischargeHistory
    '
    '  Private Sub FrmDischargeHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer

    Dim conn As OleDb.OleDbConnection = Myconnection()
    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Testing.accdb")
    End Function
    Private Sub FrmAdmitHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub toolbtnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnload.Click
        dt = New DataTable
        Try
            sql = "SELECT * FROM TblDischarge"
            conn.Open()
            With cmd
                .CommandText = sql
                .Connection = conn
            End With

            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub listcboroomtype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listcboroomtype.Click

    End Sub

    Private Sub listcboroomtype_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listcboroomtype.TextChanged
        dt = New DataTable
        sql = "Select * from TblDischarge where PatientName LIKE '%" & listcboroomtype.Text & "%'"

        Try

            conn.Open()
            da = New OleDb.OleDbDataAdapter(sql, conn)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

        conn.Close()
    End Sub
End Class
' End Sub
'