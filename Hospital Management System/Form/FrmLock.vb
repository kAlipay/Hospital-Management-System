Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web
Imports System.Net.Mail
Public Class FrmLock
    Public con As OleDbConnection = Nothing

    Public rdr As OleDbDataReader = Nothing
    Public ReadOnly cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Testing.accdb"
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Function Encrypt(ByVal password As String) As String
        Dim strmsg As String = String.Empty
        Dim encode As Byte() = New Byte(password.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(password)
        strmsg = Convert.ToBase64String(encode)
        Return strmsg
    End Function

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
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
                Me.Hide()
                '      frmBillling.lblUser.Text = UserID.Text
                '     frmBillling.Show()
            Else
                MsgBox("Invalid Password...Try again !", MsgBoxStyle.Critical, "Login Denied")
                txtpassword.Text = ""
                txtpassword.Focus()
            End If
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
