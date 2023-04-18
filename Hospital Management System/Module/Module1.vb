Imports System.Data.OleDb
Module Module1
    Public OleCn As New OleDbConnection()
    '  Public con As OleDb.OleDbConnection = Myconnection()
    Public Dst As New DataSet()
    Public myDA As New OleDbDataAdapter()
    Public sql As String
    Public cmd As New OleDbCommand
    Public dt As New DataTable
    Public dr As OleDbDataReader
    Public result As String
    'Public Function Myconnection() As OleDb.OleDbConnection
    '    Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Monbeladb.accdb")
    ' End Function

    Public RoomID As Integer = 0

    Public Function StrConnection() As String

        StrConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Documents\CODE\School\Hospital Management System\Hospital Management System\bin\Debug\Testing.accdb"

        Return StrConnection
    End Function
    '  FrmPatient 
    

    Dim PatientCode As New DataGridViewTextBoxColumn()
    Dim PatientSureName As New DataGridViewTextBoxColumn()
    Dim PatientFirstName As New DataGridViewTextBoxColumn()
    Dim PatientMiddleName As New DataGridViewTextBoxColumn()
    Dim BloodType As New DataGridViewTextBoxColumn()
    Dim Sex As New DataGridViewTextBoxColumn()
    Dim City As New DataGridViewTextBoxColumn()
    Dim CellPhoneNumber As New DataGridViewTextBoxColumn()
    ' FrmDoctor including Gender And Mobile
    'Dim Gender As New DataGridViewTextBoxColumn()
    'Dim Mobile As New DataGridViewTextBoxColumn()
    Dim DoctorCode As New DataGridViewTextBoxColumn()
    Dim DoctorSureName As New DataGridViewTextBoxColumn()
    Dim DoctorFirstName As New DataGridViewTextBoxColumn()
    Dim DoctorMiddleName As New DataGridViewTextBoxColumn()
    Dim DateOfBirth As New DataGridViewTextBoxColumn()
    Dim Gender As New DataGridViewTextBoxColumn()
    Dim Religion As New DataGridViewTextBoxColumn()
    Dim Mobile As New DataGridViewTextBoxColumn()
    Dim Nationality As New DataGridViewTextBoxColumn()
    Dim Email As New DataGridViewTextBoxColumn()
    Dim Address As New DataGridViewTextBoxColumn()
    Dim DoctorSpecialization As New DataGridViewTextBoxColumn()
    Dim DoctorCategory As New DataGridViewTextBoxColumn()
    Dim ServiceCharge As New DataGridViewTextBoxColumn



    Public Sub GridView(ByVal dgv As DataGridView)
        'FrmPatient
        dgv.AutoGenerateColumns = False
        With PatientCode
            .DataPropertyName = "PatientCode"
            .HeaderText = "Patient Code"
            .Width = 63
        End With
        With PatientSureName
            .DataPropertyName = "PatientSureName"
            .HeaderText = "Family Name"
            .Width = 200
        End With

        With PatientFirstName
            .DataPropertyName = "PatientFirstName"
            .HeaderText = "First Name"
            .Width = 200
        End With

        With PatientMiddleName
            .DataPropertyName = "PatientMiddleName"
            .HeaderText = "Middle Name"
            .Width = 200
        End With
        With BloodType
            .DataPropertyName = "BloodType"
            .HeaderText = "Blood Type"
            .Width = 80
        End With

        With Sex
            .DataPropertyName = "Sex"
            .HeaderText = "Gender"
            .Width = 50
        End With

        With City
            .DataPropertyName = "City"
            .HeaderText = "City"
            .Width = 180
        End With

        With CellPhoneNumber
            .DataPropertyName = "CellPhoneNumber"
            .HeaderText = "Mobile"
            .Width = 85
        End With

        dgv.AutoGenerateColumns = False
        With dgv
            .DataSource = Dst
            .DataMember = "Testing"
            .ReadOnly = True
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ShowRowErrors = False
            .ShowCellErrors = False
            .AllowUserToAddRows = False ' Disabled or hide (*) Symbol...
            .AllowUserToResizeColumns = False 'Disable HearderText Resize Column...
            .AllowUserToResizeRows = False 'Disabled  row resize...
            .RowHeadersVisible = False 'To hide Left indicator...
            .DefaultCellStyle.SelectionBackColor = Color.SteelBlue  'Selection backcolor....
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGoldenrodYellow 'Alternating Backcolor
            .Columns.AddRange(New DataGridViewColumn() {PatientCode, PatientSureName, PatientFirstName, PatientMiddleName, BloodType, Sex, City, CellPhoneNumber})
            ' .Columns(2).DefaultCellStyle.Format = "dd/MM/yyyy"
            ' .Columns(8).DefaultCellStyle.Format = "dd/MM/yyyy"

        End With
    End Sub

    Public Sub GridView1(ByVal dgv As DataGridView)
        'FrmDoctor
        With DoctorCode
            .DataPropertyName = "DoctorCode"
            .HeaderText = "Doctor Code"
            .Width = 63
        End With

        With DoctorSureName
            .DataPropertyName = "DoctorSureName"
            .HeaderText = "Doctor Family Name"
            .Width = 150
        End With

        With DoctorFirstName
            .DataPropertyName = "DoctorFirstName"
            .HeaderText = "Doctor First Name"
            .Width = 150
        End With

        With DoctorMiddleName
            .DataPropertyName = "DoctorMiddleName"
            .HeaderText = "Doctor Middle Name"
            .Width = 150
        End With

        With DateOfBirth
            .DataPropertyName = "DateOfBirth"
            .HeaderText = "Date Of Birth"
            .Width = 63
        End With


        With Gender
            .DataPropertyName = "Gender"
            .HeaderText = "Gender"
            .Width = 50
        End With

        With Religion
            .DataPropertyName = "Religion"
            .HeaderText = "Religion"
            .Width = 120
        End With

        With Mobile
            .DataPropertyName = "Mobile"
            .HeaderText = "Mobile"
            .Width = 85
        End With

        With Nationality
            .DataPropertyName = "Nationality"
            .HeaderText = "Nationality"
            .Width = 85
        End With

        With Email
            .DataPropertyName = "Email"
            .HeaderText = "E-Mail"
            .Width = 150
        End With

        With Address
            .DataPropertyName = "Address"
            .HeaderText = "Address"
            .Width = 200
        End With

        With DoctorSpecialization
            .DataPropertyName = "DoctorSpecialization"
            .HeaderText = "Doctor Specialization"
            .Width = 85
        End With

        With DoctorCategory
            .DataPropertyName = "DoctorCategory"
            .HeaderText = "Doctor Category"
            .Width = 85
        End With

        With ServiceCharge
            .DataPropertyName = "ServiceCharge"
            .HeaderText = "Service Charge"
            .Width = 85
        End With
        dgv.AutoGenerateColumns = False
        With dgv
            .DataSource = Dst
            .DataMember = "Testing"
            .ReadOnly = True
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ShowRowErrors = False
            .ShowCellErrors = False
            .AllowUserToAddRows = False ' Disabled or hide (*) Symbol...
            .AllowUserToResizeColumns = False 'Disable HearderText Resize Column...
            .AllowUserToResizeRows = False 'Disabled  row resize...
            .RowHeadersVisible = False 'To hide Left indicator...
            .DefaultCellStyle.SelectionBackColor = Color.SteelBlue  'Selection backcolor....
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGoldenrodYellow 'Alternating Backcolor
            .Columns.AddRange(New DataGridViewColumn() {DoctorCode, DoctorSureName, DoctorFirstName, DoctorMiddleName, DateOfBirth, Gender, Religion, Mobile, Nationality, Email, Address, DoctorSpecialization, DoctorCategory, ServiceCharge})
            ' .Columns(2).DefaultCellStyle.Format = "dd/MM/yyyy"
            ' .Columns(8).DefaultCellStyle.Format = "dd/MM/yyyy"

        End With
    End Sub


End Module
