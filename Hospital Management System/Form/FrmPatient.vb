Imports System.Data.OleDb
Imports System.IO



Public Class FrmPatient

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
        CBSearchCategory.SelectedItem = "Patient code"
        tooltxtsearch.Clear()
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
                            .SelectCommand.CommandText = "SELECT * FROM TblPatient order by 1"
                            .SelectCommand.Connection = OleCn

                            Dim Ole As New OleDbCommandBuilder(myDA) 'For Delete... 

                            Dst.Clear()
                            .Fill(Dst, "Testing")
                            Call GridView(Me.DataGridView)



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

        Me.DataGridView.Focus()

    End Sub
    Private Function SNoExist()
        Dim Str, Str1 As String
        Dim i As Integer
        Str = txtpatientcode.Text
        i = 0
        While i <> Dst.Tables("Testing").Rows.Count
            Str1 = Dst.Tables("Testing").Rows(i)("PatientCode")
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
            myDA = New OleDbDataAdapter("SELECT * From TblPatient order by 1", con)
            myDA.Fill(Dst, "Testing")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "PatientCode Error...")
        End Try
    End Sub

    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Sub clear()
        txtpatientcode.Clear()
        txtpatientsurename.Clear()
        txtpatientfirstname.Clear()
        txtpatientmi.Clear()
        txtaddress.Clear()
        txtcontactno.Clear()
        txtpatientsurename.Focus()
        cboblod.Text = ""
        cbogender.Text = ""

    End Sub

    '' Private Function RequiredEntry() As Boolean
    Public Sub _RequiredEntry()

    End Sub


    Public Sub PatientCodegenerate()

        Dim a
        Dim i As Integer
        i = 0

        Try

            i = Dst.Tables("Testing").Rows.Count - 1
            a = Dst.Tables("Testing").Rows(i)("PatientCode").ToString + 1
            txtpatientcode.Text = a

        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "PatientCode: Auto Genrate Error...")
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
        Me.txtpatientcode.ReadOnly = True

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
                            .SelectCommand.CommandText = "SELECT * FROM TblPatient order by 1"
                            .SelectCommand.Connection = OleCn

                            Dim Ole As New OleDbCommandBuilder(myDA) 'For Delete... 

                            Dst.Clear()
                            .Fill(Dst, "Testing")
                            Call GridView(Me.DataGridView)

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
        txtpatientcode.Text = DataGridView.SelectedCells(0).Value.ToString()
        txtpatientsurename.Text = DataGridView.SelectedCells(1).Value.ToString()
        txtpatientfirstname.Text = DataGridView.SelectedCells(2).Value.ToString()
        txtpatientmi.Text = DataGridView.SelectedCells(3).Value.ToString()
        cboblod.Text = DataGridView.SelectedCells(4).Value.ToString()
        cbogender.Text = DataGridView.SelectedCells(5).Value.ToString()
        txtaddress.Text = DataGridView.SelectedCells(6).Value.ToString()
        txtcontactno.Text = DataGridView.SelectedCells(7).Value.ToString()

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

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Testing.accdb"

        Try
            If CBSearchCategory.Text = "Patient code" Then
                If con.State - System.Data.ConnectionState.Closed Then
                    con.Open()
                End If
                Dim dap As OleDbDataAdapter = New OleDbDataAdapter("Select * From TblPatient  where PatientCode like '" & Me.tooltxtsearch.Text & "%' ", con)
                Dim ds As DataSet = New DataSet
                dap.Fill(ds, "TblPatient")
                DataGridView.DataSource = ds.Tables(0)
                Return
            End If
            If CBSearchCategory.Text = "Patient First Name" Then
                If con.State - System.Data.ConnectionState.Closed Then
                    con.Open()
                End If
                Dim dap As OleDbDataAdapter = New OleDbDataAdapter("Select * From TblPatient  where PatientSureName like '" & Me.tooltxtsearch.Text & "%' ", con)
                Dim ds As DataSet = New DataSet
                dap.Fill(ds, "TblPatient")
                DataGridView.DataSource = ds.Tables(0)
                Return
            End If
            If CBSearchCategory.Text = "Blood Type" Then
                If con.State - System.Data.ConnectionState.Closed Then
                    con.Open()
                End If
                Dim dap As OleDbDataAdapter = New OleDbDataAdapter("Select * From TblPatient  where BloodType like '" & Me.tooltxtsearch.Text & "%' ", con)
                Dim ds As DataSet = New DataSet
                dap.Fill(ds, "TblPatient")
                DataGridView.DataSource = ds.Tables(0)
                Return
            End If

        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Fillter Error...")
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs)





    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
        Catch ex As Exception
        End Try
    End Sub



    Private Sub txtPatientCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpatientcode.KeyPress
        Dim NotAllowed As String = "abcdefghijklmnopqrstuvwxyz~`@#$%^&*()_-+={[}]:;'.><?|/\.!"

        'Allowed Numbers Only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPatientName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpatientsurename.KeyPress
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

    Private Sub txtCity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtaddress.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtMobile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontactno.KeyPress
        Dim NotAllowed As String = "abcdefghijklmnopqrstuvwxyz~`@#$%^&*()_-={[}]:;'.><?|/\.!"

        'Allowed Numbers Only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
                            .SelectCommand.CommandText = "SELECT * FROM TblPatient order by 1"
                            .SelectCommand.Connection = OleCn

                            Dim Ole As New OleDbCommandBuilder(myDA) 'For Delete... 

                            Dst.Clear()
                            .Fill(Dst, "Testing")
                            Call GridView(Me.DataGridView)



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
        Me.txtpatientcode.ReadOnly = False
        tooltxtsearch.Clear()
    End Sub

    Private Sub toolbtnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnsave.Click
        Call PatientCodeNavigation()
        If SNoExist() = True Then
            MsgBox("PATIENT CODE : Patient Code is already exist. Please choose another one..... ", MsgBoxStyle.Exclamation, "Attention...")
            Me.txtpatientcode.Focus()
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

            Dim sSQL As String = "insert into TblPatient values(@PatientCode,@PatientSureName,@PatientFirstName,@PatientMiddleName,@BloodType,@Sex,@City,@CellPhoneNumber)"

            Dim cmd As OleDbCommand = New OleDbCommand(sSQL, OleCn)

            'PatientCode
            Dim PatientCode As OleDbParameter = New OleDbParameter("@PatientCode", OleDbType.VarChar, 10)
            PatientCode.Value = txtpatientcode.Text.ToString()
            cmd.Parameters.Add(PatientCode)

            'PatientSureName
            Dim PatientSureName As OleDbParameter = New OleDbParameter("@PatientSureName", OleDbType.VarChar, 50)
            PatientSureName.Value = txtpatientsurename.Text.ToString()
            cmd.Parameters.Add(PatientSureName)

            'PatientFirstName
            Dim PatientFirstName As OleDbParameter = New OleDbParameter("@PatientFirstName", OleDbType.VarChar, 50)
            PatientFirstName.Value = txtpatientfirstname.Text.ToString()
            cmd.Parameters.Add(PatientFirstName)

            'PatientMiddleName
            Dim PatientMiddleName As OleDbParameter = New OleDbParameter("@PatientMiddleName", OleDbType.VarChar, 50)
            PatientMiddleName.Value = txtpatientmi.Text.ToString()
            cmd.Parameters.Add(PatientMiddleName)

            'Blood
            Dim BloodType As OleDbParameter = New OleDbParameter("@BloodType", OleDbType.VarChar, 30)
            BloodType.Value = cboblod.Text.ToString()
            cmd.Parameters.Add(BloodType)


            'Sex
            Dim Sex As OleDbParameter = New OleDbParameter("@Sex", OleDbType.VarChar, 100)
            Sex.Value = cbogender.Text.ToString()
            cmd.Parameters.Add(Sex)

            'City
            Dim City As OleDbParameter = New OleDbParameter("@City", OleDbType.VarChar, 50)
            City.Value = txtaddress.Text.ToString()
            cmd.Parameters.Add(City)



            'CellPhoneNumber
            Dim CellPhoneNumber As OleDbParameter = New OleDbParameter("@CellPhoneNumber", OleDbType.VarChar, 20)
            CellPhoneNumber.Value = txtcontactno.Text.ToString()
            cmd.Parameters.Add(CellPhoneNumber)


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
                                .SelectCommand.CommandText = "SELECT * FROM TblPatient order by 1"
                                .SelectCommand.Connection = OleCn

                                Dim Ole As New OleDbCommandBuilder(myDA) 'For Delete... 

                                Dst.Clear()
                                .Fill(Dst, "Testing")
                                Call GridView(Me.DataGridView)

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
            txtpatientsurename.Clear()

            txtaddress.Clear()
            txtcontactno.Clear()
        End If
    End Sub

    Private Sub toolbtnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolbtnsearch.Click
        Dim a As String
        a = InputBox("Enter Patient Code", "Response", 0)
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
            com.CommandText = "select [PatientCode],[PatientSureName],[PatientFirstName],[PatientMiddleName],[BloodType],[Sex],[City],[CellPhoneNumber] from TblPatient where PatientCode = '" & a & "'"
            com.Connection = OleCn
            dr1 = com.ExecuteReader
            If dr1.Read Then

                txtpatientcode.Text = dr1(0).ToString()
                txtpatientsurename.Text = UCase(dr1(1)).ToString()
                txtpatientfirstname.Text = UCase(dr1(2)).ToString()
                txtpatientmi.Text = UCase(dr1(3)).ToString()
                cboblod.Text = UCase(dr1(4)).ToString()
                cbogender.Text = UCase(dr1(5)).ToString()
                txtaddress.Text = UCase(dr1(6)).ToString()
                txtcontactno.Text = dr1(7).ToString()


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
                Dim cmd2 As New OleDb.OleDbCommand("Update TblPatient Set PatientSureName=@PatientSureName,PatientFirstName=@PatientFirstName,PatientMiddleName=@PatientMiddleName,BloodType=@BloodType,Sex=@Sex,City=@City,CellPhoneNumber=@CellPhoneNumber Where (PatientCode=@PatientCode) ", OleCn)

                'PatientSureName
                Dim PatientSureName As OleDbParameter = New OleDbParameter("@PatientSureName", OleDbType.VarChar, 25)
                PatientSureName.Value = txtpatientsurename.Text.ToString()
                cmd2.Parameters.Add(PatientSureName)

                'PatientFirstName
                Dim PatientFirstName As OleDbParameter = New OleDbParameter("@PatienFirstName", OleDbType.VarChar, 25)
                PatientFirstName.Value = txtpatientfirstname.Text.ToString()
                cmd2.Parameters.Add(PatientFirstName)

                'PatientMiddleName
                Dim PatientMiddleName As OleDbParameter = New OleDbParameter("@PatientMiddleName", OleDbType.VarChar, 25)
                PatientMiddleName.Value = txtpatientmi.Text.ToString()
                cmd2.Parameters.Add(PatientMiddleName)

                'Blood
                Dim BloodType As OleDbParameter = New OleDbParameter("@BloodType", OleDbType.VarChar, 25)
                BloodType.Value = cboblod.Text.ToString()
                cmd2.Parameters.Add(BloodType)


                'Sex
                Dim Sex As OleDbParameter = New OleDbParameter("@Sex", OleDbType.VarChar, 50)
                Sex.Value = cbogender.Text.ToString()
                cmd2.Parameters.Add(Sex)

                'City
                Dim City As OleDbParameter = New OleDbParameter("@City", OleDbType.VarChar, 25)
                City.Value = txtaddress.Text.ToString()
                cmd2.Parameters.Add(City)



                'CellPhoneNumber
                Dim CellPhoneNumber As OleDbParameter = New OleDbParameter("@CellPhoneNumber", OleDbType.VarChar, 15)
                CellPhoneNumber.Value = txtcontactno.Text.ToString()
                cmd2.Parameters.Add(CellPhoneNumber)


                'PatientCode
                Dim PatientCode As OleDbParameter = New OleDbParameter("@PatientCode", OleDbType.VarChar, 10)
                PatientCode.Value = txtpatientcode.Text.ToString()
                cmd2.Parameters.Add(PatientCode)


                If cmd2.ExecuteNonQuery() Then
                    OleCn.Close()
                    MessageBox.Show("Record Update Successfully", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
                                    .SelectCommand.CommandText = "SELECT * FROM TblPatient order by 1"
                                    .SelectCommand.Connection = OleCn

                                    Dim Ole As New OleDbCommandBuilder(myDA) 'For Delete... 

                                    Dst.Clear()
                                    .Fill(Dst, "Testing")
                                    Call GridView(Me.DataGridView)

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
                Dim sSQL As String = "Delete From TblPatient where [PatientCode]=@PatientCode And [PatientSureName]=@PatientSureName And [CellPhoneNumber]=@CellPhoneNumber "
                Dim cmd2 As OleDbCommand = New OleDbCommand(sSQL, OleCn)

                'PatientCode
                Dim PatientCode As OleDbParameter = New OleDbParameter("@PatientCode", OleDbType.VarChar, 10)
                PatientCode.Value = txtpatientcode.Text.ToString()
                cmd2.Parameters.Add(PatientCode)


                'PatientSureName
                Dim PatientSureName As OleDbParameter = New OleDbParameter("@PatientSureName", OleDbType.VarChar, 25)
                PatientSureName.Value = txtpatientsurename.Text.ToString()
                cmd2.Parameters.Add(PatientSureName)


                'CellPhoneNumber
                Dim CellPhoneNumber As OleDbParameter = New OleDbParameter("@CellPhoneNumber", OleDbType.VarChar, 15)
                CellPhoneNumber.Value = txtcontactno.Text.ToString()
                cmd2.Parameters.Add(CellPhoneNumber)


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
                                    .SelectCommand.CommandText = "SELECT * FROM TblPatient order by 1"
                                    .SelectCommand.Connection = OleCn

                                    Dim Ole As New OleDbCommandBuilder(myDA) 'For Delete... 

                                    Dst.Clear()
                                    .Fill(Dst, "Testing")
                                    Call GridView(Me.DataGridView)

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
    End Sub

  

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.Close()
        FrmMain.Show()

    End Sub


    Private Sub LblRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblRecord.Click

    End Sub

    Private Sub DataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellContentClick

    End Sub


    Private Sub txtpatientfirstname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpatientfirstname.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtpatientmi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpatientmi.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;!><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
