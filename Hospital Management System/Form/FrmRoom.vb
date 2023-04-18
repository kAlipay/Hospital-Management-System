Public Class FrmRoom

    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer
    Dim Fname As String
    Dim Lname As String
    '   Public RoomID As Integer = 0
    Dim con As OleDb.OleDbConnection = Myconnection()


    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Testing.accdb")
    End Function
    Private Sub formroomslist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.listcboroomtype.Items.Add("Private")
        Me.listcboroomtype.Items.Add("Family")
        Me.listcboroomtype.Items.Add("Bed")
        Me.listcboroomtype.Items.Add("Clear")
        dt = New DataTable
        Try
            sql = "SELECT * FROM TblRoom"
            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
            End With

            da.SelectCommand = cmd
            da.Fill(dt)
            DataGridView1.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()


        End Try
    End Sub




    Private Sub listcboroomtype_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles listcboroomtype.KeyDown
        If e.KeyCode = Keys.Enter Then
            toolbtnload.PerformClick()
        End If
    End Sub

    Private Sub toolbtnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnload.Click
        dt = New DataTable
        sql = "Select * from TblRoom where RoomType LIKE '%" & listcboroomtype.Text & "%'"

        Try

            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

        con.Close()

        If listcboroomtype.Text = "Clear" Then
            dt = New DataTable
            Try
                sql = "SELECT * FROM TblRoom"
                con.Open()
                With cmd
                    .CommandText = sql
                    .Connection = con
                End With

                da.SelectCommand = cmd
                da.Fill(dt)
                DataGridView1.DataSource = dt


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()


            End Try
        End If
    End Sub


    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Dim RoomStatus = DataGridView1.CurrentRow.Cells("Status").Value.ToString

        'checkin

        If RoomStatus = "Unavailable" Then
            MessageBox.Show("Not Available")
        Else
            '   FrmAdmit.txtroomrate.Text = ""
            '   FrmAdmit.txtroomno.Text = ""
            '  FrmAdmit.txtroomtype.Text = ""
            ' FrmAdmit.txtroomid.Text = DataGridView1.CurrentRow.Cells("IDrooms").Value.ToString
            RoomID = DataGridView1.CurrentRow.Cells("IDrooms").Value.ToString
            FrmAdmit.txtroomID.Text = DataGridView1.CurrentRow.Cells("IDrooms").Value.ToString
            FrmAdmit.txtroomnumber.Text = DataGridView1.CurrentRow.Cells("Room").Value.ToString
            FrmAdmit.txtroomtype.Text = DataGridView1.CurrentRow.Cells("RoomType").Value.ToString
            FrmAdmit.txtroomrate.Text = DataGridView1.CurrentRow.Cells("RoomRate").Value.ToString
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class