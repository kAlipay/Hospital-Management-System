Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web
'Imports System.Data.OleDb
'Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Net.Mail

Public Class FrmRegistration
    Dim st1 As String
    Public con As OleDbConnection = Nothing
    Public rdr As OleDbDataReader = Nothing
    Public ReadOnly cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Testing.accdb"
    Sub Reset()
        masktextboxcontactno.Text = ""
        txtemailid.Text = ""
        txtname.Text = ""
        txtpassword.Text = ""
        txtusername.Text = ""
        cmbusertype.SelectedIndex = -1
        chkboxactive.Checked = True
        txtusername.Focus()
        toolbtnsave.Enabled = True
        '  btnUpdate.Enabled = False
        toolbtndelete.Enabled = False
    End Sub
    Public Function Encrypt(ByVal password As String) As String
        Dim strmsg As String = String.Empty
        Dim encode As Byte() = New Byte(password.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(password)
        strmsg = Convert.ToBase64String(encode)
        Return strmsg
    End Function

    Sub LogFunc(ByVal st1 As String, ByVal st2 As String)
        con = New OleDbConnection(cs)
        con.Open()
        Dim cb As String = "insert into Logs(UserID,[Date],Operation) VALUES (@d1,#" & System.DateTime.Now & "#,@d2)"
        cmd = New OleDbCommand(cb)
        cmd.Connection = con
        cmd.Parameters.AddWithValue("@d1", st1)
        cmd.Parameters.AddWithValue("@d2", st2)
        cmd.ExecuteReader()
        con.Close()
    End Sub


    Private Sub DeleteRecord()

        Try
            If cmbusertype.Text = "Admin" Or cmbusertype.Text = "Admin" Then
                MessageBox.Show("Admin account can not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim RowsAffected As Integer = 0
                ' con = New OleDbConnection(cs)
                'con.Open()
                '     Dim cl As String = "select UserID from Registration,RestaurantBillingInfo where RestaurantBillingInfo.OperatorID=Registration.UserID and UserID=@d1"
                'Dim cl As String = "select UserID from Registration where UserID=@d1"
                'cmd = New OleDbCommand(cl)
                'cmd.Connection = con
                'cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
                'rdr = cmd.ExecuteReader()
                'If rdr.Read Then
                'MessageBox.Show("Unable to delete..Already in use in Billing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'If Not rdr Is Nothing Then
                ' rdr.Close()
                'End If
                'Exit Sub
                'End If
                'con.Close()
                'con = New OleDbConnection(cs)
                'con.Open()
                'Dim cl1 As String = "select UserID from Registration where UserID=@d1"
                'cmd = New OleDbCommand(cl1)
                'cmd.Connection = con
                'cmd.Parameters.AddWithValue("@d1", txtUserID.Text)
                'rdr = cmd.ExecuteReader()
                'If rdr.Read Then
                'MessageBox.Show("Unable to delete..Already in use in Billing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'If Not rdr Is Nothing Then
                'rdr.Close()
                'End If
                'Exit Sub
                'End If
                con.Close()
                con = New OleDbConnection(cs)
                con.Open()
                Dim cq As String = "delete from TblRegistration where userid=@d1"
                cmd = New OleDbCommand(cq)
                cmd.Parameters.AddWithValue("@d1", txtusername.Text)
                cmd.Connection = con
                RowsAffected = cmd.ExecuteNonQuery()
                If RowsAffected > 0 Then
                    Dim st As String = "deleted the user '" & txtusername.Text & "'"
                    LogFunc(lbluser.Text, st)
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Getdata()
                    Reset()
                Else
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Reset()
                End If
                If con.State = ConnectionState.Open Then
                    con.Close()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
        'End If

                Exit Sub


    End Sub

    Public Sub Getdata()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT RTRIM(userid), RTRIM(UserType), RTRIM([Password]), RTRIM(RegisteredName), RTRIM(EmailID), RTRIM(ContactNo),RTRIM(Active),JoiningDate from TblRegistration order by JoiningDate", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            DataGridView1.Rows.Clear()
            While (rdr.Read() = True)
                DataGridView1.Rows.Add(rdr(0), rdr(1), (rdr(2)), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub dgw_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs)
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))

    End Sub

    Private Sub frmRegistration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub

    Private Sub frmRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Getdata()
    End Sub

    Private Sub dgw_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If DataGridView1.Rows.Count > 0 Then
                Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
                txtusername.Text = dr.Cells(0).Value.ToString()
                TextBox1.Text = dr.Cells(0).Value.ToString()
                cmbusertype.Text = dr.Cells(1).Value.ToString()
                txtpassword.Text = dr.Cells(2).Value.ToString()
                txtname.Text = dr.Cells(3).Value.ToString()
                masktextboxcontactno.Text = dr.Cells(5).Value.ToString()
                txtemailid.Text = dr.Cells(4).Value.ToString()
                txtEmail.Text = dr.Cells(4).Value.ToString()
                If dr.Cells(6).Value.ToString() = "Yes" Then
                    chkboxactive.Checked = True
                Else
                    chkboxactive.Checked = False
                End If
                '  btnUpdate.Enabled = True
                toolbtndelete.Enabled = True
                toolbtnsave.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCheckAvailability_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAvailability.Click
        If txtusername.Text = "" Then
            MessageBox.Show("Please enter user id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtusername.Focus()
            Return
        End If
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select userid from TblRegistration where userid=@d1"
            cmd = New OleDbCommand(ct)
            cmd.Parameters.AddWithValue("@d1", txtusername.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                MessageBox.Show("User ID not available", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            Else
                MessageBox.Show("User ID available", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim obj As frmMainMenu = DirectCast(Application.OpenForms("frmMainMenu"), frmMainMenu)
        'obj.lblUser.Text = lblUser.Text
        'Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Reset()
    End Sub

    Private Sub dgw_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If (e.ColumnIndex = 2) AndAlso e.Value IsNot Nothing Then
            DataGridView1.Rows(e.RowIndex).Tag = e.Value
            e.Value = New [String]("●"c, e.Value.ToString().Length)
        End If
    End Sub

    Private Sub dgw_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs)
        If DataGridView1.CurrentCell.ColumnIndex = 2 Then
            'select target column
            Dim textBox As TextBox = TryCast(e.Control, TextBox)
            If textBox IsNot Nothing Then
                textBox.UseSystemPasswordChar = True
            End If
        Else
            Dim textBox As TextBox = TryCast(e.Control, TextBox)
            If textBox IsNot Nothing Then
                textBox.UseSystemPasswordChar = False
            End If
        End If
    End Sub

    Private Sub txtEmailID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemailid.KeyPress
        Dim ac As String = "@"
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                If Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 95 Then
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                        If ac.IndexOf(e.KeyChar) = -1 Then
                            e.Handled = True

                        Else

                            If txtemailid.Text.Contains("@") And e.KeyChar = "@" Then
                                e.Handled = True
                            End If

                        End If


                    End If
                End If
            End If

        End If
    End Sub

    Private Sub txtEmailID_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtemailid.Validating
        Dim pattern As String = "^[a-z][a-z|0-9|]*([_][a-z|0-9]+)*([.][a-z|0-9]+([_][a-z|0-9]+)*)?@[a-z][a-z|0-9|]*\.([a-z][a-z|0-9]*(\.[a-z][a-z|0-9]*)?)$"
        Dim match As System.Text.RegularExpressions.Match = Regex.Match(txtemailid.Text.Trim(), pattern, RegexOptions.IgnoreCase)
        If (match.Success) Then
        Else
            MessageBox.Show("Please enter a valid email id", "Checking")
            txtemailid.Clear()
        End If
    End Sub



    Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If (e.ColumnIndex = 2) AndAlso e.Value IsNot Nothing Then
            DataGridView1.Rows(e.RowIndex).Tag = e.Value
            e.Value = New [String]("●"c, e.Value.ToString().Length)
        End If
    End Sub

    Private Sub DataGridView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        Try
            If DataGridView1.Rows.Count > 0 Then
                Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
                txtusername.Text = dr.Cells(0).Value.ToString()
                TextBox1.Text = dr.Cells(0).Value.ToString()
                cmbusertype.Text = dr.Cells(1).Value.ToString()
                txtpassword.Text = dr.Cells(2).Value.ToString()
                txtname.Text = dr.Cells(3).Value.ToString()
                masktextboxcontactno.Text = dr.Cells(5).Value.ToString()
                txtemailid.Text = dr.Cells(4).Value.ToString()
                txtEmail.Text = dr.Cells(4).Value.ToString()
                If dr.Cells(6).Value.ToString() = "Yes" Then
                    chkboxactive.Checked = True
                Else
                    chkboxactive.Checked = False
                End If
                ' btnUpdate.Enabled = True
                toolbtndelete.Enabled = True
                toolbtnsave.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub toolbtnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnnew.Click
        Reset()
    End Sub

    Private Sub toolbtnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnsave.Click
        If txtusername.Text = "" Then
            MessageBox.Show("Please enter user id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtusername.Focus()
            Return
        End If
        If cmbusertype.Text = "" Then
            MessageBox.Show("Please select user type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbusertype.Focus()
            Return
        End If
        If txtpassword.Text = "" Then
            MessageBox.Show("Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpassword.Focus()
            Return
        End If
        If txtname.Text = "" Then
            MessageBox.Show("Please enter name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtname.Focus()
            Return
        End If
        If txtemailid.Text = "" Then
            MessageBox.Show("Please enter email id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtemailid.Focus()
            Return
        End If
        If masktextboxcontactno.Text = "" Then
            MessageBox.Show("Please enter contact no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            masktextboxcontactno.Focus()
            Return
        End If

        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select userid from TblRegistration where userid=@d1"
            cmd = New OleDbCommand(ct)
            cmd.Parameters.AddWithValue("@d1", txtusername.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                MessageBox.Show("user id Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtusername.Text = ""
                txtusername.Focus()
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If
            con.Close()
            con = New OleDbConnection(cs)
            con.Open()
            Dim ct2 As String = "select EmailID from TblRegistration where EmailID=@d1"
            cmd = New OleDbCommand(ct2)
            cmd.Parameters.AddWithValue("@d1", txtemailid.Text)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                MessageBox.Show("Email id Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If
            con.Close()
            If chkboxactive.Checked = True Then
                st1 = "Yes"
            Else
                st1 = "No"
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "insert into TblRegistration(userid, UserType, [Password],RegisteredName, ContactNo, EmailID,JoiningDate,Active) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,#" & System.DateTime.Now & "#,@d8)"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtusername.Text)
            cmd.Parameters.AddWithValue("@d2", cmbusertype.Text)
            cmd.Parameters.AddWithValue("@d3", Encrypt(txtpassword.Text.Trim()))
            cmd.Parameters.AddWithValue("@d4", txtname.Text)
            cmd.Parameters.AddWithValue("@d5", masktextboxcontactno.Text)
            cmd.Parameters.AddWithValue("@d6", txtemailid.Text)
            cmd.Parameters.AddWithValue("@d8", st1)
            cmd.ExecuteReader()
            con.Close()
            Dim st As String = "added the new user '" & txtusername.Text & "'"
            LogFunc(lbluser.Text, st)
            MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            toolbtnsave.Enabled = False
            Getdata()
            Reset()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub toolbtndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtndelete.Click
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub masktextboxcontactno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles masktextboxcontactno.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        '  Dim Position = DataGridView1.CurrentRow.Cells("Status").Value.ToString

        'checkin

        '   If Position = "Unavailable" Then
        'MessageBox.Show("Not Available")
        '  Else
        '   FrmAdmit.txtroomrate.Text = ""
        '   FrmAdmit.txtroomno.Text = ""
        '  FrmAdmit.txtroomtype.Text = ""
        ' FrmAdmit.txtroomid.Text = DataGridView1.CurrentRow.Cells("IDrooms").Value.ToString
        '   RoomID = DataGridView1.CurrentRow.Cells("IDrooms").Value.ToString
        ' FrmAdmit.txtroomID.Text = DataGridView1.CurrentRow.Cells("IDrooms").Value.ToString
        '  FrmAdmit.txtroomnumber.Text = DataGridView1.CurrentRow.Cells("Room").Value.ToString
        '  FrmAdmit.txtroomtype.Text = DataGridView1.CurrentRow.Cells("RoomType").Value.ToString
        '  FrmAdmit.txtroomrate.Text = DataGridView1.CurrentRow.Cells("RoomRate").Value.ToString
        '  Me.Close()
        ' End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class
