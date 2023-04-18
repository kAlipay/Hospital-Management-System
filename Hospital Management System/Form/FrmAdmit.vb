Imports System.Data.OleDb
Public Class FrmAdmit
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer
    Dim remarks As String = "Checkin"
    Dim con As OleDb.OleDbConnection = Myconnection()


    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Testing.accdb")
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheckin.Click
        Dim sql = "INSERT INTO  TblAdmit(PatientName,IDrooms,RoomNo,RoomType,RoomRate,CHECKIN_DATE,DoctorName,DoctorCategory,ServiceCharge,DoctorName1,DoctorCategory1,ServiceCharge1) VALUES ('" & txtpatientname.Text & "', '" & txtroomID.Text & "', '" & txtroomnumber.Text & "','" & txtroomtype.Text & "', '" & txtroomrate.Text & "', '" & txtdate.Value & "', '" & txtdoctorname.Text & "', '" & txtdoctorcategory.Text & "', '" & txtservicecharge.Text & "', '" & txtdoctorname1.Text & "', '" & txtdoctorcategory1.Text & "', '" & txtservicecharge1.Text & "')"
        cashiersave(sql)

        Try
            sql = "UPDATE TblRoom SET Status='Unavailable' WHERE IDrooms=" & RoomID

            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
            End With

            result = cmd.ExecuteNonQuery


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()



        End Try
        '  Try
        'sql = "DELETE * FROM tblreserve  WHERE ID=" & GuestId
        '  con.Open()
        '  With cmd
        '.CommandText = sql
        ' .Connection = con
        ' End With

        ' result = cmd.ExecuteNonQuery


        ' Catch ex As Exception
        'MsgBox(ex.Message)
        '  Finally
        ' con.Close()


        ' End Try


        txtdoctorcategory1.Text = Nothing
        '   txtpatientname.Text = Nothing
        txtdoctorname1.Text = Nothing
        '  txtroomtype.Text = Nothing
        ' txtroomnumber.Text = Nothing
        txtservicecharge1.Text = Nothing
        '   txtroomrate.Text = Nothing
        ' txtdoctorname.Text = Nothing

    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FrmRoom.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FrmPatientList.ShowDialog()
    End Sub


    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '        Dim dt1 As Date = Convert.ToDateTime(DateTimePicker1.Text)
        '       Dim dt2 As Date = Convert.ToDateTime(DateTimePicker2.Text)
        '      Dim ts As TimeSpan = dt2.Subtract(dt1)
        '     txtdoctorname.Text = Convert.ToInt32(ts.Days)
        '    Convert.ToInt32(ts.Days)
    End Sub

    Public Sub cleartextfields()
        txtdoctorcategory.Text = ""
        txtdoctorname.Text = ""
        txtdoctorname.Text = ""
        For Each crt As Control In Me.Controls
            If crt.GetType Is GetType(TextBox) Then
                crt.Text = Nothing
            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cleartextfields()
        'txtadults.Text = Nothing
        'txtgname.Text = Nothing
        'txtdays.Text = Nothing
        'txttype.Text = Nothing
        'txtRoom.Text = Nothing
        'txtChildren.Text = Nothing
        'rate.Text = Nothing
        'txtadvance.Text = Nothing
        '  Me.Close()
    End Sub

    Private Sub FormCheckin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' DateTimePicker1.MinDate = Date.Now
        ' DateTimePicker1.MaxDate = Date.Now

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub cashiersave(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
            End With

            result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("NEW PATIENT HAS BEEN ADDED!")
                con.Close()


            Else
                MsgBox("NO DATA HASS BEEN SAVED!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmDoctorList.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        FrmDoctorList1.ShowDialog()
    End Sub
End Class
