Imports System.Security.Cryptography
Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web
Imports System.Data.OleDb
'Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Net.Mail
'Imports System.Data.OleDb
Public Class FrmChangePassword
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Public con As OleDbConnection = Nothing
    Public ReadOnly cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Testing.accdb"
    Public Function Encrypt(ByVal password As String) As String
        Dim strmsg As String = String.Empty
        Dim encode As Byte() = New Byte(password.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(password)
        strmsg = Convert.ToBase64String(encode)
        Return strmsg
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub OSKeyboard()
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
    Private Sub frmChangePassword1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        FrmLogin.Show()
        FrmLogin.txtusername.Text = ""
        FrmLogin.txtpassword.Text = ""
        FrmLogin.txtusername.Focus()
    End Sub

    Private Sub frmChangePassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, False) 'for Select Next Control
        End If
    End Sub

    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Location = New Point(Me.ClientSize.Width / 2 - Panel1.Size.Width / 2, Me.ClientSize.Height / 2 - Panel1.Size.Height / 2)
        Panel1.Anchor = AnchorStyles.None
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        FrmLogin.Show()
        FrmLogin.txtusername.Text = ""
        FrmLogin.txtpassword.Text = ""
        FrmLogin.txtusername.Focus()
    End Sub

    Private Sub btnKeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OSKeyboard()
    End Sub

    Private Sub ConfirmPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtconfirmpassword.TextChanged

    End Sub

    Private Sub btncheckin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchangepassword.Click
        Try
            Dim RowsAffected As Integer = 0
            If Len(Trim(txtusername.Text)) = 0 Then
                MessageBox.Show("Please enter user id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtusername.Focus()
                Exit Sub
            End If
            If Len(Trim(txtoldpassword.Text)) = 0 Then
                MessageBox.Show("Please enter old password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtoldpassword.Focus()
                Exit Sub
            End If
            If Len(Trim(txtnewpassword.Text)) = 0 Then
                MessageBox.Show("Please enter new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnewpassword.Focus()
                Exit Sub
            End If
            If Len(Trim(txtconfirmpassword.Text)) = 0 Then
                MessageBox.Show("Please confirm new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtconfirmpassword.Focus()
                Exit Sub
            End If
            If txtnewpassword.TextLength < 5 Then
                MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnewpassword.Text = ""
                txtconfirmpassword.Text = ""
                txtnewpassword.Focus()
                Exit Sub
            ElseIf txtnewpassword.Text <> txtconfirmpassword.Text Then
                MessageBox.Show("Password do not match", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnewpassword.Text = ""
                txtoldpassword.Text = ""
                txtconfirmpassword.Text = ""
                txtoldpassword.Focus()
                Exit Sub
            ElseIf txtoldpassword.Text = txtnewpassword.Text Then
                MessageBox.Show("Password is same..Re-enter new password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnewpassword.Text = ""
                txtconfirmpassword.Text = ""
                txtnewpassword.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim co As String = "update TblRegistration set [password] =@d1 where userid=@d2 and [password] =@d3"
            cmd = New OleDbCommand(co)
            cmd.Parameters.AddWithValue("@d1", Encrypt(txtnewpassword.Text))
            cmd.Parameters.AddWithValue("@d2", txtusername.Text)
            cmd.Parameters.AddWithValue("@d3", Encrypt(txtoldpassword.Text))
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                Dim st As String = "Successfully changed the password"
                '   LogFunc(UserID.Text, st)
                ' frmCustomDialog.ShowDialog()
                Me.Hide()
                FrmLogin.Show()
                FrmLogin.txtusername.Text = ""
                FrmLogin.txtpassword.Text = ""
                FrmLogin.txtusername.Focus()
            Else

                MessageBox.Show("invalid user name or password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtusername.Text = ""
                txtnewpassword.Text = ""
                txtoldpassword.Text = ""
                txtconfirmpassword.Text = ""
                txtusername.Focus()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class