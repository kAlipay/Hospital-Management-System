Public Class FrmDoctorList1
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer

    Dim con As OleDb.OleDbConnection = Myconnection()

    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Testing.accdb")
    End Function

    Private Sub DataGridView2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView2.DoubleClick
        FrmAdmit.txtdoctorname1.Text = ""
        FrmAdmit.txtdoctorcategory1.Text = ""
        FrmAdmit.txtservicecharge1.Text = ""
        FrmAdmit.txtdoctorname1.Text &= " " & DataGridView2.CurrentRow.Cells("DoctorSureName").Value.ToString
        FrmAdmit.txtdoctorname1.Text &= ", " & DataGridView2.CurrentRow.Cells("DoctorFirstName").Value.ToString
        FrmAdmit.txtdoctorname1.Text &= " " & DataGridView2.CurrentRow.Cells("DoctorMiddleName").Value.ToString
        FrmAdmit.txtdoctorname1.Text &= "."
        FrmAdmit.txtdoctorcategory1.Text = DataGridView2.CurrentRow.Cells("DoctorCategory").Value.ToString
        FrmAdmit.txtservicecharge1.Text = DataGridView2.CurrentRow.Cells("ServiceCharge").Value.ToString

        Me.Close()
    End Sub

    Private Sub toolbtnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnload.Click
        dt = New DataTable
        sql = "Select * from TblDoctor where DoctorSureName LIKE '%" & tooltxtsearch.Text & "%'"

        Try

            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(dt)
            'DataGridView1.DataSource = dt
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

        con.Close()
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tooltxtsearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tooltxtsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            toolbtnload.PerformClick()
        End If
    End Sub

    Private Sub FrmDoctorList1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class