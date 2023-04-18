Public Class FrmPatientList

    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer

    Dim con As OleDb.OleDbConnection = Myconnection()

    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Testing.accdb")
    End Function



    Private Sub cboroomtype_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FrmRoomList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '       Me.listcboroomtype.Items.Add("Private")
        '      Me.listcboroomtype.Items.Add("Family")
        '     Me.listcboroomtype.Items.Add("Bed")
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        ' FrmAdmit.txtpatientname.Text = DataGridView1.SelectedCells(1).Value.ToString()
        'FrmAdmit.txtpatientname.Text &= ", " & DataGridView1.SelectedCells(2).Value.ToString()
        'FrmAdmit.txtpatientname.Text &= " " & DataGridView1.SelectedCells(3).Value.ToString()
        'FrmAdmit.txtpatientname.Text &= "." '& DataGridView.SelectedCells(3).Value.ToString()
        '     Dim RoomStatus = DataGridView1.CurrentRow.Cells("Status").Value.ToString

        'checkin

        'If RoomStatus = "Unavailable" Then
        'MessageBox.Show("Not Available")
        'Else
        FrmAdmit.txtpatientname.Text = ""
        FrmAdmit.txtpatientname.Text &= " " & DataGridView1.CurrentRow.Cells("PatientSureName").Value.ToString
        FrmAdmit.txtpatientname.Text &= ", " & DataGridView1.CurrentRow.Cells("PatientFirstName").Value.ToString
        FrmAdmit.txtpatientname.Text &= " " & DataGridView1.CurrentRow.Cells("PatientMiddleName").Value.ToString
        FrmAdmit.txtpatientname.Text &= "."
        Me.Close()
        'End If
    End Sub


    Private Sub btnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub toolbtnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnload.Click
        dt = New DataTable
        sql = "Select * from TblPatient where PatientSureName LIKE '%" & listcboroomtype.Text & "%'"

        Try

            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

        con.Close()
    End Sub



    Private Sub listcboroomtype_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles listcboroomtype.KeyDown
        If e.KeyCode = Keys.Enter Then
            toolbtnload.PerformClick()
        End If
    End Sub

    Private Sub listcboroomtype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listcboroomtype.Click

    End Sub
End Class