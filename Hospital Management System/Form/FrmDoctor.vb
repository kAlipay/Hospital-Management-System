Imports System.Data.OleDb


Public Class FrmDoctor

    Dim con As New System.Data.OleDb.OleDbConnection
    Dim cmd As System.Data.OleDb.OleDbCommand

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        e.SuppressKeyPress = e.Control
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CBSearchCategory.SelectedItem = "Doctor code"
        tooltxtsearch.Clear()
        toolbtnrefresh.Enabled = False

        Call _Refreshes()
        Call clear()
        Try
            If (DataGridView.Rows.Count > 0) Then
                DataGridView.Rows(0).Selected = True
            End If


            Try
                With OleCn
                    If .State <> ConnectionState.Open Then
                        .ConnectionString = StrConnection()
                        .Open()
                        With myDA

                            .SelectCommand = New OleDbCommand()
                            .SelectCommand.CommandText = "SELECT * FROM TblDoctor order by 1"
                            .SelectCommand.Connection = OleCn

                            Dim Ole As New OleDbCommandBuilder(myDA) 'For Delete... 

                            Dst.Clear()
                            .Fill(Dst, "Testing")
                            Call GridView1(Me.DataGridView)



                        End With
                    End If
                End With

            Catch ex As Exception
                ' MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
            Finally
                OleCn.Close()
            End Try

            Call Navigation()

        Catch ex As Exception
        End Try

    End Sub

    Private Sub Navigation()

        'if navigated to first record....

        If Me.BindingContext(Dst, "Testing").Position = 0 Then
            Me.cmdFirst.Enabled = False
            Me.cmdPrevious.Enabled = False
        Else
            Me.cmdFirst.Enabled = True
            Me.cmdPrevious.Enabled = True
        End If

        'if navigated to last record....

        If Me.BindingContext(Dst, "Testing").Position = Me.BindingContext(Dst, "Testing").Count - 1 Then
            Me.cmdLast.Enabled = False
            Me.cmdNext.Enabled = False
        Else
            Me.cmdLast.Enabled = True
            Me.cmdNext.Enabled = True
        End If
        Me.LblRecord.Text = Me.BindingContext(Dst, "Testing").Position + 1 & " of " & Me.BindingContext(Dst, "Testing").Count

        '  Me.DataGridView.Focus()

    End Sub
    Private Function SNoExist()
        Dim Str, Str1 As String
        Dim i As Integer
        Str = txtdoctorcode.Text
        i = 0
        While i <> Dst.Tables("Testing").Rows.Count
            Str1 = Dst.Tables("Testing").Rows(i)("DoctorCode")
            If Str = Str1 Then
                Return True
            End If
            i += 1
        End While
        Return False
    End Function

    Private Sub PatientCodeNavigation()
        Try
            OleCn.Close()
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Testing.accdb"
            If con.State - System.Data.ConnectionState.Closed Then
                con.Open()
            End If
            myDA = New OleDbDataAdapter("SELECT * From TblDoctor order by 1", con)
            myDA.Fill(Dst, "Testing")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "DoctorCode Error...")
        End Try
    End Sub



    Sub clear()
        txtdoctorsurename.Clear()
        cboreligion.Text = ""
        txtcontactno.Clear()
        txtdoctorsurename.Focus()
        txtdoctorfirstname.Text = ""
        txtdoctormiddlename.Text = ""
        cbogender.Text = ""
        txtemail.Text = ""
        cbonationality.Text = ""
        txtaddress.Text = ""
        cbodoctorspecialization.Text = ""
        cbodoctorcategory.Text = ""
        cbodoctorspecialization.Text = ""
        txtservicecharge.Text = ""
    End Sub

    ''  Private Function RequiredEntry() As Boolean
    '    Public Sub _RequiredEntry()

    'End Sub


    Public Sub PatientCodegenerate()

        Dim a
        Dim i As Integer
        i = 0

        Try

            i = Dst.Tables("Testing").Rows.Count - 1
            a = Dst.Tables("Testing").Rows(i)("DoctorCode").ToString + 1
            txtdoctorcode.Text = a

        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "DoctorCode: Auto Genrate Error...")
        End Try


    End Sub



    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            con.Close()
            OleCn.Close()
            Me.Close()

        Catch ex As Exception
        End Try

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        toolbtnnew.Visible = True
        toolbtnnew.Enabled = True
        '  cmdSave.Visible = False
        ' cmdSave.Enabled = False
        ' cmdCancel.Visible = False
        ' cmdCancel.Enabled = False
        ' cmdClose.Visible = True
        ' cmdClose.Enabled = True
        Me.txtdoctorcode.ReadOnly = True

        tooltxtsearch.Clear()

        Try
            If (DataGridView.Rows.Count > 0) Then
                DataGridView.Rows(0).Selected = True
            End If


            Try
                With OleCn
                    If .State <> ConnectionState.Open Then
                        .ConnectionString = StrConnection()
                        .Open()
                        With myDA

                            .SelectCommand = New OleDbCommand()
                            .SelectCommand.CommandText = "SELECT * FROM TblDoctor order by 1"
                            .SelectCommand.Connection = OleCn

                            Dim Ole As New OleDbCommandBuilder(myDA) 'For Delete... 

                            Dst.Clear()
                            .Fill(Dst, "Testing")
                            Call GridView1(Me.DataGridView)

                            Call Navigation()

                        End With
                    End If
                End With

            Catch ex As Exception
                '  MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
            Finally
                OleCn.Close()
            End Try

        Catch ex As Exception
        End Try

    End Sub

    Private Sub DataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellClick
        Call Navigation()
    End Sub

    Private Sub DataGridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView.SelectionChanged

        On Error Resume Next
        txtdoctorcode.Text = DataGridView.SelectedCells(0).Value.ToString()
        txtdoctorsurename.Text = DataGridView.SelectedCells(1).Value.ToString()
        txtdoctorfirstname.Text = DataGridView.SelectedCells(2).Value.ToString()
        txtdoctormiddlename.Text = DataGridView.SelectedCells(3).Value.ToString()
        dtpdateofbirth.Text = DataGridView.SelectedCells(4).Value.ToString()
        cbogender.Text = DataGridView.SelectedCells(5).Value.ToString()
        cboreligion.Text = DataGridView.SelectedCells(6).Value.ToString()
        txtcontactno.Text = DataGridView.SelectedCells(7).Value.ToString()
        cbonationality.Text = DataGridView.SelectedCells(8).Value.ToString()
        txtemail.Text = DataGridView.SelectedCells(9).Value.ToString()
        txtaddress.Text = DataGridView.SelectedCells(10).Value.ToString()
        cbodoctorspecialization.Text = DataGridView.SelectedCells(11).Value.ToString()
        cbodoctorcategory.Text = DataGridView.SelectedCells(12).Value.ToString()
        txtservicecharge.Text = DataGridView.SelectedCells(13).Value.ToString()
        ' If cmdSave.Visible = True Or cmdSave.Enabled = True Then
        'cmdCancel.PerformClick()
        ' End If

    End Sub

    Private Sub cmdFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirst.Click
        Try
            Me.BindingContext.Item(Dst, "Testing").Position = 0
            Call Navigation()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevious.Click
        Try
            If Not Me.BindingContext(Dst, "Testing").Position = 0 Then
                Me.BindingContext.Item(Dst, "Testing").Position -= 1
                Call Navigation()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        Try
            If Not Me.BindingContext(Dst, "Testing").Position = Me.BindingContext(Dst, "Testing").Count - 1 Then
                Me.BindingContext.Item(Dst, "Testing").Position += 1
                Call Navigation()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLast.Click
        Try
            Me.BindingContext(Dst, "Testing").Position = Me.BindingContext(Dst, "Testing").Count - 1
            Call Navigation()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tooltxtsearch.TextChanged

        toolbtnrefresh.Enabled = True
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Testing.accdb"

        Try
            If CBSearchCategory.Text = "Doctor Code" Then
                If con.State - System.Data.ConnectionState.Closed Then
                    con.Open()
                End If
                Dim dap As OleDbDataAdapter = New OleDbDataAdapter("Select * From TblDoctor  where DoctorCode like '" & Me.tooltxtsearch.Text & "%' ", con)
                Dim ds As DataSet = New DataSet
                dap.Fill(ds, "TblDoctor")
                DataGridView.DataSource = ds.Tables(0)
                Return
            End If
            If CBSearchCategory.Text = "Doctor Family Name" Then
                If con.State - System.Data.ConnectionState.Closed Then
                    con.Open()
                End If
                Dim dap As OleDbDataAdapter = New OleDbDataAdapter("Select * From TblDoctor  where DoctorSureName like '" & Me.tooltxtsearch.Text & "%' ", con)
                Dim ds As DataSet = New DataSet
                dap.Fill(ds, "TblDoctor")
                DataGridView.DataSource = ds.Tables(0)
                Return
            End If

        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Fillter Error...")
        Finally
            con.Close()
        End Try

    End Sub




    Private Sub txtdoctorcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdoctorcode.KeyPress
        Dim NotAllowed As String = "abcdefghijklmnopqrstuvwxyz~`@#$%^&*()_-+={[}]:;'.><?|/\.!"

        'Allowed Numbers Only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtdoctorname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdoctorsurename.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDisease_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub



    Public Sub _Refreshes()

        tooltxtsearch.Clear()

        Try
            If (DataGridView.Rows.Count > 0) Then
                DataGridView.Rows(0).Selected = True
            End If


            Try
                With OleCn
                    If .State <> ConnectionState.Open Then
                        .ConnectionString = StrConnection()
                        .Open()
                        With myDA

                            .SelectCommand = New OleDbCommand()
                            .SelectCommand.CommandText = "SELECT * FROM TblTblDoctor order by 1"
                            .SelectCommand.Connection = OleCn

                            Dim Ole As New OleDbCommandBuilder(myDA) 'For Delete... 

                            Dst.Clear()
                            .Fill(Dst, "Testing")
                            Call GridView1(Me.DataGridView)



                        End With
                    End If
                End With

            Catch ex As Exception
                '  MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
            Finally
                OleCn.Close()
            End Try

            Call Navigation()

        Catch ex As Exception
        End Try

    End Sub

    Private Sub toolbtnnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnnew.Click

        toolbtnnew.Visible = False
        toolbtnsave.Visible = True
        toolbtnsave.Enabled = True
        '    cmdCancel.Visible = True
        '  cmdCancel.Enabled = True
        ' cmdClose.Visible = False
        'cmdClose.Enabled = False
        Call clear()
        Call PatientCodegenerate()
        Me.txtdoctorcode.ReadOnly = False
        tooltxtsearch.Clear()
    End Sub

    Private Sub toolbtnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnsave.Click
        Call PatientCodeNavigation()
        If SNoExist() = True Then
            MsgBox("Doctor CODE : Doctor Code is already exist. Please choose another one..... ", MsgBoxStyle.Exclamation, "Attention...")
            Me.txtdoctorcode.Focus()
            Exit Sub
        End If

        Try
            With OleCn
                If .State <> ConnectionState.Open Then
                    .ConnectionString = StrConnection()
                    .Open()
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try

            Dim sSQL As String = "insert into TblDoctor values(@DoctorCode,@DoctorSureName,@DoctorFirstName,@DoctorMiddleName,@DateOfBirth,@Gender,@Religion,@Mobile,@Nationality,@Email,@Address,@DoctorSpecialization,@DoctorCategory,@ServiceCharge)"

            Dim cmd As OleDbCommand = New OleDbCommand(sSQL, OleCn)

            'DoctorCode
            Dim DoctorCode As OleDbParameter = New OleDbParameter("@DoctorCode", OleDbType.VarChar, 10)
            DoctorCode.Value = txtdoctorcode.Text.ToString()
            cmd.Parameters.Add(DoctorCode)

            'DoctorSureName
            Dim DoctorSureName As OleDbParameter = New OleDbParameter("@DoctorSureName", OleDbType.VarChar, 50)
            DoctorSureName.Value = txtdoctorsurename.Text.ToString()
            cmd.Parameters.Add(DoctorSureName)

            'DoctorFirstName
            Dim DoctorFirstName As OleDbParameter = New OleDbParameter("@DoctorFirstName", OleDbType.VarChar, 50)
            DoctorFirstName.Value = txtdoctorfirstname.Text.ToString()
            cmd.Parameters.Add(DoctorFirstName)

            'DoctorMiddleName
            Dim DoctorMiddleName As OleDbParameter = New OleDbParameter("@DoctorMiddleName", OleDbType.VarChar, 50)
            DoctorMiddleName.Value = txtdoctormiddlename.Text.ToString()
            cmd.Parameters.Add(DoctorMiddleName)

            'DateOfBirth
            Dim DateOfBirth As OleDbParameter = New OleDbParameter("@DateOfBirth", OleDbType.VarChar, 30)
            DateOfBirth.Value = dtpdateofbirth.Text.ToString()
            cmd.Parameters.Add(DateOfBirth)


            'Gender
            Dim Gender As OleDbParameter = New OleDbParameter("@Gender", OleDbType.VarChar, 100)
            Gender.Value = cbogender.Text.ToString()
            cmd.Parameters.Add(Gender)

            'Religion
            Dim Religion As OleDbParameter = New OleDbParameter("@Religion", OleDbType.VarChar, 50)
            Religion.Value = cboreligion.Text.ToString()
            cmd.Parameters.Add(Religion)

            'Mobile
            Dim Mobile As OleDbParameter = New OleDbParameter("@Mobile", OleDbType.VarChar, 20)
            Mobile.Value = txtcontactno.Text.ToString()
            cmd.Parameters.Add(Mobile)

            'Nationality
            Dim Nationality As OleDbParameter = New OleDbParameter("@Nationality", OleDbType.VarChar, 20)
            Nationality.Value = cbonationality.Text.ToString()
            cmd.Parameters.Add(Nationality)

            'Email
            Dim Email As OleDbParameter = New OleDbParameter("@Email", OleDbType.VarChar, 20)
            Email.Value = txtemail.Text.ToString()
            cmd.Parameters.Add(Email)

            'Address
            Dim Address As OleDbParameter = New OleDbParameter("@Address", OleDbType.VarChar, 20)
            Address.Value = txtaddress.Text.ToString()
            cmd.Parameters.Add(Address)

            'DoctorSpecialization
            Dim DoctorSpecialization As OleDbParameter = New OleDbParameter("@DoctorSpecialization", OleDbType.VarChar, 20)
            DoctorSpecialization.Value = cbodoctorspecialization.Text.ToString()
            cmd.Parameters.Add(DoctorSpecialization)

            'DoctorCategory
            Dim DoctorCategory As OleDbParameter = New OleDbParameter("@DoctorCategory", OleDbType.VarChar, 20)
            DoctorCategory.Value = cbodoctorcategory.Text.ToString()
            cmd.Parameters.Add(DoctorCategory)

            'ServiceCharge
            Dim ServiceCharge As OleDbParameter = New OleDbParameter("@ServiceCharge", OleDbType.VarChar, 20)
            ServiceCharge.Value = txtservicecharge.Text.ToString()
            cmd.Parameters.Add(ServiceCharge)

            If cmd.ExecuteNonQuery() Then

                OleCn.Close()
                MessageBox.Show("New Record is Added Successfully.", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                toolbtnsave.Visible = False
                toolbtnnew.Visible = True
                If (DataGridView.Rows.Count > 0) Then
                    DataGridView.Rows(0).Selected = True
                End If


                Try
                    With OleCn
                        If .State <> ConnectionState.Open Then
                            .ConnectionString = StrConnection()
                            .Open()
                            With myDA

                                .SelectCommand = New OleDbCommand()
                                .SelectCommand.CommandText = "SELECT * FROM TblDoctor order by 1"
                                .SelectCommand.Connection = OleCn

                                Dim Ole As New OleDbCommandBuilder(myDA) 'For Delete... 

                                Dst.Clear()
                                .Fill(Dst, "Testing")
                                Call GridView1(Me.DataGridView)

                            End With
                        End If
                    End With

                Catch ex As Exception
                    '  MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
                Finally
                    OleCn.Close()
                End Try

                Call Navigation()

            Else

                MsgBox("Record Addition Failed ", MsgBoxStyle.Critical, "Addition Failed")

                Return
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
            Exit Sub
        End Try
    End Sub

    Private Sub toolbtnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnclear.Click
        If toolbtnsave.Visible = True Or toolbtnsave.Enabled = True Then
            Call clear()
            Call PatientCodegenerate()
        Else
            txtdoctorsurename.Clear()

            txtcontactno.Clear()
        End If
    End Sub

    Private Sub toolbtnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnsearch.Click
        Dim a As String
        a = InputBox("Enter Doctor Code", "Response", 0)
        If a = "" Then
            Exit Sub
        End If


        Try
            With OleCn
                If .State <> ConnectionState.Open Then
                    .ConnectionString = StrConnection()
                    .Open()
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        Try

            Dim dr1 As OleDbDataReader
            Dim com As New OleDbCommand
            com.CommandText = "select [DoctorCode],[DoctorSureName],[DoctorFirstName],[DoctorMiddleName][DateOfBirth],[Gender],[Religion],[Mobile],[Nationality],[Email],[Address],[DoctorSpecialization],[DoctorCategory],[ServiceCharge] from TblDoctor where DoctorCode = '" & a & "'"
            com.Connection = OleCn
            dr1 = com.ExecuteReader
            If dr1.Read Then

                txtdoctorcode.Text = dr1(0).ToString()
                txtdoctorsurename.Text = UCase(dr1(1)).ToString()
                txtdoctorfirstname.Text = UCase(dr1(2)).ToString()
                txtdoctormiddlename.Text = UCase(dr1(3)).ToString()
                dtpdateofbirth.Text = UCase(dr1(4)).ToString()
                cbogender.Text = UCase(dr1(5)).ToString()
                cboreligion.Text = UCase(dr1(6)).ToString()
                txtcontactno.Text = dr1(7).ToString()
                cbonationality.Text = dr1(8).ToString()
                txtemail.Text = dr1(9).ToString()
                txtaddress.Text = dr1(10).ToString()
                cbodoctorspecialization.Text = dr1(11).ToString()
                cbodoctorcategory.Text = dr1(12).ToString()
                txtservicecharge.Text = dr1(13).ToString()

            Else
                MsgBox("Record Searching Failed!!! ", MsgBoxStyle.Critical, "Searching Failed")
            End If
            OleCn.Close()
            dr1.Close()

        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
        End Try
    End Sub

    Private Sub toolbtnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnedit.Click

        '   If toolbtnsave.Visible = True Or toolbtnsave.Enabled = True Then
        'MsgBox("Rcorcd Modification Failed ", MsgBoxStyle.Critical, "Updation Failed")
        '  Return
        '   End If

        Dim msg As DialogResult = MessageBox.Show("Do you want to Update this Record? ", "Response", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (msg = vbYes) Then



            Try
                With OleCn
                    If .State <> ConnectionState.Open Then
                        .ConnectionString = StrConnection()
                        .Open()
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


            ''''''Note:  you can't update patient_code

            Try
                Dim cmd2 As New OleDb.OleDbCommand("Update TblDoctor Set DoctorSureName=@DoctorSureName,DoctorFirstName=@DoctorFirstName,DoctorMiddleName=@DoctorMiddleName,DateOfBirth=@DateOfBirth,Gender=@Gender,Religion=@Religion,Mobile=@Mobile,Nationality=@Nationality,Email=@Email,Address=@Address,DoctorSpecialization=@DoctorSpecialization,DoctorCategory=@DoctorCategory,ServiceCharge=@ServiceCharge Where (DoctorCode=@DoctorCode) ", OleCn)

                'DoctorSureName
                Dim DoctorSureName As OleDbParameter = New OleDbParameter("@DoctorSureName", OleDbType.VarChar, 25)
                DoctorSureName.Value = txtdoctorsurename.Text.ToString()
                cmd2.Parameters.Add(DoctorSureName)


                'DoctorFirstName
                Dim DoctorFirstName As OleDbParameter = New OleDbParameter("@DoctorFirstName", OleDbType.VarChar, 25)
                DoctorFirstName.Value = txtdoctorfirstname.Text.ToString()
                cmd2.Parameters.Add(DoctorFirstName)

                'DoctorMiddleName
                Dim DoctorMiddleName As OleDbParameter = New OleDbParameter("@DoctorMiddleName", OleDbType.VarChar, 25)
                DoctorMiddleName.Value = txtdoctormiddlename.Text.ToString()
                cmd2.Parameters.Add(DoctorMiddleName)


                'DateOfBirth
                Dim DateOfBirth As OleDbParameter = New OleDbParameter("@DateOfBirth", OleDbType.VarChar, 25)
                DateOfBirth.Value = dtpdateofbirth.Text.ToString()
                cmd2.Parameters.Add(DateOfBirth)


                'Address
                Dim Gender As OleDbParameter = New OleDbParameter("@Gender", OleDbType.VarChar, 50)
                Gender.Value = cbogender.Text.ToString()
                cmd2.Parameters.Add(Gender)

                'Religion
                Dim Religion As OleDbParameter = New OleDbParameter("@Religion", OleDbType.VarChar, 25)
                Religion.Value = cboreligion.Text.ToString()
                cmd2.Parameters.Add(Religion)



                'Mobile
                Dim Mobile As OleDbParameter = New OleDbParameter("@Mobile", OleDbType.VarChar, 15)
                Mobile.Value = txtcontactno.Text.ToString()
                cmd2.Parameters.Add(Mobile)

                'Nationality
                Dim Nationality As OleDbParameter = New OleDbParameter("@Nationlity", OleDbType.VarChar, 15)
                Nationality.Value = cbonationality.Text.ToString()
                cmd2.Parameters.Add(Nationality)

                'Email
                Dim Email As OleDbParameter = New OleDbParameter("@Email", OleDbType.VarChar, 30)
                Email.Value = txtemail.Text.ToString()
                cmd2.Parameters.Add(Email)

                'Address
                Dim Address As OleDbParameter = New OleDbParameter("@Address", OleDbType.VarChar, 15)
                Address.Value = txtaddress.Text.ToString()
                cmd2.Parameters.Add(Address)

                'DoctorSpecialization
                Dim DoctorSpecialization As OleDbParameter = New OleDbParameter("@DoctorSpecialization", OleDbType.VarChar, 15)
                DoctorSpecialization.Value = cbodoctorspecialization.Text.ToString()
                cmd2.Parameters.Add(DoctorSpecialization)

                'DoctorCategory
                Dim DoctorCategory As OleDbParameter = New OleDbParameter("@DoctorCategory", OleDbType.VarChar, 15)
                DoctorCategory.Value = cbodoctorcategory.Text.ToString()
                cmd2.Parameters.Add(DoctorCategory)

                'ServiceCharge
                Dim ServiceCharge As OleDbParameter = New OleDbParameter("@ServiceCharge", OleDbType.VarChar, 15)
                ServiceCharge.Value = txtservicecharge.Text.ToString()
                cmd2.Parameters.Add(ServiceCharge)

                'DoctorCode
                Dim DoctorCode As OleDbParameter = New OleDbParameter("@DoctorCode", OleDbType.VarChar, 10)
                DoctorCode.Value = txtdoctorcode.Text.ToString()
                cmd2.Parameters.Add(DoctorCode)


                If cmd2.ExecuteNonQuery() Then
                    OleCn.Close()
                    MessageBox.Show("Record Update Successfully", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' toolbtnrefresh
                    If (DataGridView.Rows.Count > 0) Then
                        DataGridView.Rows(0).Selected = True
                    End If


                    Try
                        With OleCn
                            If .State <> ConnectionState.Open Then
                                .ConnectionString = StrConnection()
                                .Open()
                                With myDA

                                    .SelectCommand = New OleDbCommand()
                                    .SelectCommand.CommandText = "SELECT * FROM TblDoctor order by 1"
                                    .SelectCommand.Connection = OleCn

                                    Dim Ole As New OleDbCommandBuilder(myDA) 'For Delete... 

                                    Dst.Clear()
                                    .Fill(Dst, "Testing")
                                    Call GridView1(Me.DataGridView)

                                End With
                            End If
                        End With

                    Catch ex As Exception
                        '  MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
                    Finally
                        OleCn.Close()
                    End Try

                    Call Navigation()


                Else
                    MsgBox("Record Updation Failed ", MsgBoxStyle.Critical, "Updation Failed")
                    Return
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Udation Error...")
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub toolbtndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtndelete.Click
        '   If toolbtnsave.Visible = True Or toolbtnsave.Enabled = True Then
        'MsgBox("Record Deletion Failed ", MsgBoxStyle.Critical, "Deletion Failed")
        '   Return
        '  End If

        Dim msg As DialogResult = MessageBox.Show("Do you want to delete this Record? ", "Response", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (msg = vbYes) Then



            Try
                With OleCn
                    If .State <> ConnectionState.Open Then
                        .ConnectionString = StrConnection()
                        .Open()
                    End If
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Try
                Dim sSQL As String = "Delete From TblDoctor where [DoctorCode]=@DoctorCode And [DoctorSureName]=@DoctorSureName And [Mobile]=@Mobile "
                Dim cmd2 As OleDbCommand = New OleDbCommand(sSQL, OleCn)

                'DoctorCode
                Dim DoctorCode As OleDbParameter = New OleDbParameter("@DoctorCode", OleDbType.VarChar, 10)
                DoctorCode.Value = txtdoctorcode.Text.ToString()
                cmd2.Parameters.Add(DoctorCode)


                'DoctorSureName
                Dim DoctorSureName As OleDbParameter = New OleDbParameter("@DoctorSureName", OleDbType.VarChar, 25)
                DoctorSureName.Value = txtdoctorsurename.Text.ToString()
                cmd2.Parameters.Add(DoctorSureName)


                'Mobile
                Dim Mobile As OleDbParameter = New OleDbParameter("@Mobile", OleDbType.VarChar, 15)
                Mobile.Value = txtcontactno.Text.ToString()
                cmd2.Parameters.Add(Mobile)


                If cmd2.ExecuteNonQuery() Then
                    OleCn.Close()
                    MessageBox.Show("Record Deleted Successfully", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    If (DataGridView.Rows.Count > 0) Then
                        DataGridView.Rows(0).Selected = True
                    End If


                    Try
                        With OleCn
                            If .State <> ConnectionState.Open Then
                                .ConnectionString = StrConnection()
                                .Open()
                                With myDA

                                    .SelectCommand = New OleDbCommand()
                                    .SelectCommand.CommandText = "SELECT * FROM TblDoctor order by 1"
                                    .SelectCommand.Connection = OleCn

                                    Dim Ole As New OleDbCommandBuilder(myDA) 'For Delete... 

                                    Dst.Clear()
                                    .Fill(Dst, "Testing")
                                    Call GridView1(Me.DataGridView)

                                End With
                            End If
                        End With

                    Catch ex As Exception
                        '  MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
                    Finally
                        OleCn.Close()
                    End Try

                    Call Navigation()


                Else
                    MsgBox("Record Deletion Failed ", MsgBoxStyle.Critical, "Deletion Failed")
                    Return
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString(), "Deletion Error")
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub toolbtnrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnrefresh.Click
        Call _Refreshes()
        toolbtnrefresh.Enabled = False

        Try
            With OleCn
                If .State <> ConnectionState.Open Then
                    .ConnectionString = StrConnection()
                    .Open()
                    With myDA

                        .SelectCommand = New OleDbCommand()
                        .SelectCommand.CommandText = "SELECT * FROM TblDoctor order by 1"
                        .SelectCommand.Connection = OleCn

                        Dim Ole As New OleDbCommandBuilder(myDA) 'For Delete... 

                        Dst.Clear()
                        .Fill(Dst, "Testing")
                        Call GridView1(Me.DataGridView)

                    End With
                End If
            End With

        Catch ex As Exception
            '  MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
        Finally
            OleCn.Close()
        End Try
    End Sub


    Private Sub DataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellContentClick
        'toolbtnrefresh.Enabled = True

    End Sub



    Private Sub cbogender_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbogender.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cboreligion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboreligion.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cbonationality_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbonationality.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtemail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemail.KeyPress
        Dim NotAllowed As String = "1234567890~`#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtaddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaddress.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cbodoctorspecialization_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbodoctorspecialization.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cbodoctorcategory_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbodoctorcategory.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub txtcontactno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontactno.KeyPress
        Dim NotAllowed As String = "abcdefghijklmnopqrstuvwxyz~`@#$%^&*()_-={[}]:;'.><?|/\.!"

        'Allowed Numbers Only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtservicecharge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtservicecharge.KeyPress
        Dim NotAllowed As String = "abcdefghijklmnopqrstuvwxyz~`@#$%^&*()_-={[}]:;'.><?|/\.!"

        'Allowed Numbers Only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
        FrmMain.Show()

    End Sub



    Private Sub Button1_Click_1(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
        FrmMain.Show()
    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
