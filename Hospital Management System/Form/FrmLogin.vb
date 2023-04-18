Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web
'Imports System.Data.OleDb
'Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Net.Mail
Public Class FrmLogin
    Dim frm As New FrmMain
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Public con As OleDbConnection = Nothing
    Public rdr As OleDbDataReader = Nothing
    Public ReadOnly cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Testing.accdb"

    Public Function Encrypt(ByVal password As String) As String
        Dim strmsg As String = String.Empty
        Dim encode As Byte() = New Byte(password.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(password)
        strmsg = Convert.ToBase64String(encode)
        Return strmsg
    End Function
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Location = New Point(Me.ClientSize.Width / 2 - Panel1.Size.Width / 2, Me.ClientSize.Height / 2 - Panel1.Size.Height / 2)
        Panel1.Anchor = AnchorStyles.None
    End Sub

    Private Sub frmLogin_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub btnChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        FrmChangePassword.Show()
        FrmChangePassword.txtusername.Text = ""
        FrmChangePassword.txtoldpassword.Text = ""
        FrmChangePassword.txtnewpassword.Text = ""
        FrmChangePassword.txtconfirmpassword.Text = ""
        FrmChangePassword.txtusername.Focus()
    End Sub

    Private Sub btnKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim old As Long
        If Environment.Is64BitOperatingSystem Then
            If Wow64DisableWow64FsRedirection(old) Then
                Process.Start("osk.exe")
                Wow64EnableWow64FsRedirection(old)
            End If
        Else
            Process.Start("osk.exe")
        End If
    End Sub

    Private Sub btncheckin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If Len(Trim(txtusername.Text)) = 0 Then
            MessageBox.Show("Please enter user id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtusername.Focus()
            Exit Sub
        End If
        If Len(Trim(txtpassword.Text)) = 0 Then
            MessageBox.Show("Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtpassword.Focus()
            Exit Sub
        End If
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT RTRIM(UserID),RTRIM([Password]) FROM TblRegistration where UserID = @d1 and [Password]=@d2 and Active='Yes'"
            cmd.Parameters.AddWithValue("@d1", txtusername.Text)
            cmd.Parameters.AddWithValue("@d2", Encrypt(txtpassword.Text))
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                If Encrypt(txtpassword.Text).Trim = rdr.GetValue(1).trim Then
                    con = New OleDbConnection(cs)
                    con.Open()
                    cmd = con.CreateCommand()
                    cmd.CommandText = "SELECT usertype FROM TblRegistration where UserID=@d3 and [Password]=@d4"
                    cmd.Parameters.AddWithValue("@d3", txtusername.Text)
                    cmd.Parameters.AddWithValue("@d4", Encrypt(txtpassword.Text))
                    rdr = cmd.ExecuteReader()
                    If rdr.Read() Then
                        UserType.Text = rdr.GetValue(0).ToString.Trim
                    End If
                    If (rdr IsNot Nothing) Then
                        rdr.Close()
                    End If
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If
                    If UserType.Text = "Cashier" Then
                        Dim st As String = "Successfully logged in"
                        '  LogFunc(UserID.Text, st)
                        Me.Hide()
                        '    frmMainMenu.MasterEntryToolStripMenuItem.Enabled = True
                        '   frmMainMenu.AdministrationToolStripMenuItem.Enabled = True
                        FrmMain.Show()
                        FrmMain.toolstripusertype.Text = UserType.Text()
                        FrmMain.toolstripusername.Text = txtusername.Text()
                        FrmMain.RegistrationToolStripMenuItem.Visible = False
                        FrmMain.ToolStripStatusLabel7.Visible = True
                        FrmMain.ToolStripStatusLabel8.Visible = False


                    End If

                    If (UserType.Text = "Admin") Then
                        Dim st As String = "Successfully logged in"
                        LogFunc(txtusername.Text, st)
                        Me.Hide()
                        FrmMain.Show()
                        FrmMain.toolstripusertype.Text = UserType.Text()
                        FrmMain.toolstripusername.Text = txtusername.Text()
                        FrmMain.RegistrationToolStripMenuItem.Visible = True
                        FrmMain.ToolStripStatusLabel8.Visible = True
                        FrmMain.ToolStripStatusLabel7.Visible = False
                        '  frmMainMenu.lblUserType.Text = UserType.Text
                        ' frmMainMenu.Show()
                    End If

                End If
            Else
                MsgBox("Login is Failed...Try again !", MsgBoxStyle.Critical, "Login Denied")
                txtusername.Text = ""
                txtpassword.Text = ""
                txtusername.Focus()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
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
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        End
    End Sub
End Class
