Imports System.Data.OleDb
Public Class FrmCashier
    Dim cmd As New OleDb.OleDbCommand
    Dim sql As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim dt As New DataTable
    Dim result As Integer
    Dim remarks As String = "Checkin"
    Dim con As OleDb.OleDbConnection = Myconnection()
    Public GuestId As Integer

    Public Function Myconnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Testing.accdb")
    End Function

    Public Sub cleartextfields()
        txtdoctorcategory.Text = ""
        txtdoctorname.Text = ""
        txtdoctorname.Text = ""
        lblchange.Text = "0.00"
        For Each crt As Control In Me.Controls
            If crt.GetType Is GetType(TextBox) Then
                crt.Text = Nothing
            End If
        Next
        txtdoctorcategory1.Text = Nothing
        '   txtpatientname.Text = Nothing
        txtdoctorname1.Text = Nothing
        '  txtroomtype.Text = Nothing
        ' txtroomnumber.Text = Nothing
        txtservicecharge1.Text = Nothing
        '   txtroomrate.Text = Nothing
        ' txtdoctorname.Text = Nothing
    End Sub

 

    Private Sub FormCheckin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '   txtdate.MinDate = Date.Now
        '  txtdate.MaxDate = Date.Now


        dt = New DataTable
        Try
            sql = "SELECT * FROM TblAdmit"
            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
            End With

            da.SelectCommand = cmd
            da.Fill(dt)
            RadGridView1.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()


        End Try
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
                MsgBox("NEW GUEST HAS BEEN ADDED!")
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




    Private Sub txtdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdate.ValueChanged
        Dim dt1 As Date = Convert.ToDateTime(txtdatenow.Text)
        Dim dt2 As Date = Convert.ToDateTime(txtdate.Text)
        Dim ts As TimeSpan = dt1.Subtract(dt2)
        txtnoofdays.Text = Convert.ToInt32(ts.Days)
        Convert.ToInt32(ts.Days)
    End Sub
    Public Sub Discharge(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .CommandText = sql
                .Connection = con
            End With

            result = cmd.ExecuteNonQuery
            If result > 0 Then
                MsgBox("THE PATIENT HAS BEEN DISCHARGE!")
                con.Close()


            Else
                MsgBox("NO PATIENT HAS BEEN DISCHARGE!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        dt = New DataTable
        sql = "Select * from TblAdmit where PatientName LIKE '%" & txtsearch.Text & "%'"

        Try

            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(dt)
            RadGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

        con.Close()
    End Sub


    Private Sub btndischarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndischarge.Click
        'Dim sql = "INSERT INTO  TblDischarge(PatientName,RoomNo,RoomType,RoomRate,CHECKIN_DATE,DoctorName,DoctorCategory,ServiceCharge,DoctorName1,DoctorCategory1,ServiceCharge1) VALUES ('" & txtpatientname.Text & "', '" & txtroomnumber.Text & "','" & txtroomtype.Text & "', '" & txtroomrate.Text & "', '" & txtdate.Value & "', '" & txtdoctorname.Text & "', '" & txtdoctorcategory.Text & "', '" & txtservicecharge.Text & "', '" & txtdoctorname1.Text & "', '" & txtdoctorcategory1.Text & "', '" & txtservicecharge1.Text & "')"
        'cashiersave(sql)
        If Val(txttotal.Text) > Val(txtcash.Text) Then
            MsgBox("kulang ang imong bayronon.")
        Else
            Discharge("INSERT INTO  TblDischarge(PatientName,RoomNo,RoomType,RoomRate,CHECKIN_DATE,DoctorName,DoctorCategory,DoctorName1,DoctorCategory1,ServiceCharge,RoomBills,Total) VALUES ('" & txtpatientname.Text & "', '" & txtroomnumber.Text & "','" & txtroomtype.Text & "', '" & txtroomrate.Text & "', '" & txtdate.Value & "', '" & txtdoctorname.Text & "', '" & txtdoctorcategory.Text & "', '" & txtdoctorname1.Text & "', '" & txtdoctorcategory1.Text & "', '" & txtdoctorbillsall.Text & "', '" & txtdayscalculate.Text & "', '" & txttotal.Text & "')")

            Try
                sql = "UPDATE TblRoom SET Status='Available' WHERE IDrooms=" & RoomID

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
            Try
                sql = "DELETE * FROM TblAdmit WHERE ID=" & GuestId
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

            dt = New DataTable
            Try
                sql = "SELECT * FROM TblAdmit"
                con.Open()
                With cmd
                    .CommandText = sql
                    .Connection = con
                End With

                da.SelectCommand = cmd
                da.Fill(dt)
                RadGridView1.DataSource = dt


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()


            End Try
            txtdoctorcategory1.Text = Nothing
            '   txtpatientname.Text = Nothing
            txtdoctorname1.Text = Nothing
            '  txtroomtype.Text = Nothing
            ' txtroomnumber.Text = Nothing
            txtservicecharge1.Text = Nothing
            '   txtroomrate.Text = Nothing
            ' txtdoctorname.Text = Nothing
            '  FrmPrintDischarge.ShowDialog()
        End If

    End Sub


    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim totalAmount As Double
        totalAmount = 0
        RoomID = RadGridView1.CurrentRow.Cells("IDrooms").Value.ToString
        GuestId = RadGridView1.CurrentRow.Cells("ID").Value.ToString

        txtpatientname.Text = RadGridView1.CurrentRow.Cells("PatientName").Value.ToString
        'txt.Text = DataGridView1.CurrentRow.Cells("PatientName").Value.ToString
        txtroomnumber.Text = RadGridView1.CurrentRow.Cells("RoomNo").Value.ToString
        txtroomtype.Text = RadGridView1.CurrentRow.Cells("RoomType").Value.ToString
        txtroomrate.Text = RadGridView1.CurrentRow.Cells("RoomRate").Value.ToString
        txtdate.Value = RadGridView1.CurrentRow.Cells("CHECKIN_DATE").Value.ToString
        txtdoctorname.Text = RadGridView1.CurrentRow.Cells("DoctorName").Value.ToString
        txtdoctorcategory.Text = RadGridView1.CurrentRow.Cells("DoctorCategory").Value.ToString
        txtservicecharge.Text = RadGridView1.CurrentRow.Cells("ServiceCharge").Value.ToString
        txtdoctorname1.Text = RadGridView1.CurrentRow.Cells("DoctorName1").Value.ToString
        txtdoctorcategory1.Text = RadGridView1.CurrentRow.Cells("DoctorCategory1").Value.ToString
        txtservicecharge1.Text = RadGridView1.CurrentRow.Cells("ServiceCharge1").Value.ToString

        txtdayscalculate.Text = Val(txtroomrate.Text) * Val(txtnoofdays.Text)
        txtdoctorbills.Text = Val(txtnoofdays.Text) * Val(txtservicecharge.Text)
        txtdoctorbills1.Text = Val(txtnoofdays.Text) * Val(txtservicecharge1.Text)
        txtdoctorbillsall.Text = Val(txtdoctorbills.Text) + Val(txtdoctorbills1.Text)
        txttotal.Text = Val(txtdoctorbillsall.Text) + Val(txtdayscalculate.Text)
        dt = New DataTable
        'Dim Number1 As Double = txttotal.Text
        txtservicecharge.Text = Format(totalAmount, "#,##0.00")
    End Sub





    Private Sub txtcash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcash.TextChanged
        lblchange.Text = Val(txtcash.Text) - Val(txttotal.Text)
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        cleartextfields()
    End Sub


    Private Sub txttotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotal.Click
        ' Dim Number1 As Double = txttotal.Text
    End Sub

    Private Sub txtcash_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcash.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.txttotal.Text.Contains(".") Then
                    If Me.txttotal.Text.Split(".")(1).Length < 2 Then
                        If Char.IsDigit(e.KeyChar) = False Then
                            e.Handled = True
                        End If
                    Else
                        e.Handled = True

                    End If
            End If
        Else
            e.Handled = True
        End If
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub FrmCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
