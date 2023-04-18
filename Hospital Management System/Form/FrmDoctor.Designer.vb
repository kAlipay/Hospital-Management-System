<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDoctor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDoctor))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtservicecharge = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbodoctorcategory = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbodoctorspecialization = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdoctormiddlename = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdoctorfirstname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbonationality = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboreligion = New System.Windows.Forms.ComboBox()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcontactno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpdateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdoctorcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdoctorsurename = New System.Windows.Forms.TextBox()
        Me.LblRecord = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmdFirst = New System.Windows.Forms.Button()
        Me.cmdPrevious = New System.Windows.Forms.Button()
        Me.cmdLast = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.CBSearchCategory = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.tooltxtsearch = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbtnnew = New System.Windows.Forms.ToolStripButton()
        Me.toolbtnsave = New System.Windows.Forms.ToolStripButton()
        Me.toolbtnedit = New System.Windows.Forms.ToolStripButton()
        Me.toolbtnsearch = New System.Windows.Forms.ToolStripButton()
        Me.toolbtnclear = New System.Windows.Forms.ToolStripButton()
        Me.toolbtndelete = New System.Windows.Forms.ToolStripButton()
        Me.toolbtnrefresh = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtservicecharge)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.cbodoctorcategory)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cbodoctorspecialization)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 285)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(889, 99)
        Me.GroupBox2.TabIndex = 1032
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employee Details"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(394, 51)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 158
        Me.Label18.Text = "(Per Day)"
        '
        'txtservicecharge
        '
        Me.txtservicecharge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtservicecharge.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtservicecharge.Location = New System.Drawing.Point(496, 33)
        Me.txtservicecharge.Name = "txtservicecharge"
        Me.txtservicecharge.Size = New System.Drawing.Size(153, 23)
        Me.txtservicecharge.TabIndex = 156
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(367, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 19)
        Me.Label17.TabIndex = 157
        Me.Label17.Text = "Service Charge :"
        '
        'cbodoctorcategory
        '
        Me.cbodoctorcategory.FormattingEnabled = True
        Me.cbodoctorcategory.Location = New System.Drawing.Point(190, 67)
        Me.cbodoctorcategory.Name = "cbodoctorcategory"
        Me.cbodoctorcategory.Size = New System.Drawing.Size(153, 21)
        Me.cbodoctorcategory.TabIndex = 155
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(56, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(118, 19)
        Me.Label16.TabIndex = 154
        Me.Label16.Text = "Doctor Category:"
        '
        'cbodoctorspecialization
        '
        Me.cbodoctorspecialization.FormattingEnabled = True
        Me.cbodoctorspecialization.Location = New System.Drawing.Point(190, 31)
        Me.cbodoctorspecialization.Name = "cbodoctorspecialization"
        Me.cbodoctorspecialization.Size = New System.Drawing.Size(153, 21)
        Me.cbodoctorspecialization.TabIndex = 152
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(25, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(149, 19)
        Me.Label15.TabIndex = 151
        Me.Label15.Text = "Doctor Specialization:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdoctormiddlename)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtdoctorfirstname)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbonationality)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboreligion)
        Me.GroupBox1.Controls.Add(Me.cbogender)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcontactno)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpdateofbirth)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtdoctorcode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtdoctorsurename)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(889, 235)
        Me.GroupBox1.TabIndex = 1031
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Details"
        '
        'txtdoctormiddlename
        '
        Me.txtdoctormiddlename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdoctormiddlename.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdoctormiddlename.Location = New System.Drawing.Point(387, 70)
        Me.txtdoctormiddlename.Name = "txtdoctormiddlename"
        Me.txtdoctormiddlename.Size = New System.Drawing.Size(51, 23)
        Me.txtdoctormiddlename.TabIndex = 154
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(394, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 15)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "(MI)"
        '
        'txtdoctorfirstname
        '
        Me.txtdoctorfirstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdoctorfirstname.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdoctorfirstname.Location = New System.Drawing.Point(255, 70)
        Me.txtdoctorfirstname.Name = "txtdoctorfirstname"
        Me.txtdoctorfirstname.Size = New System.Drawing.Size(116, 23)
        Me.txtdoctorfirstname.TabIndex = 152
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(252, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 15)
        Me.Label7.TabIndex = 151
        Me.Label7.Text = "(First Name)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "(Sure Name)"
        '
        'txtaddress
        '
        Me.txtaddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtaddress.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(557, 158)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(213, 23)
        Me.txtaddress.TabIndex = 148
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(476, 162)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 19)
        Me.Label13.TabIndex = 149
        Me.Label13.Text = "Address:"
        '
        'txtemail
        '
        Me.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtemail.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(557, 116)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(213, 23)
        Me.txtemail.TabIndex = 146
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(486, 118)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 19)
        Me.Label12.TabIndex = 147
        Me.Label12.Text = "E-Mail:"
        '
        'cbonationality
        '
        Me.cbonationality.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbonationality.FormattingEnabled = True
        Me.cbonationality.Items.AddRange(New Object() {"Filipino ", "Spanish", "American", "Chinese", "Korean", "Taiwanese", "British"})
        Me.cbonationality.Location = New System.Drawing.Point(557, 72)
        Me.cbonationality.Name = "cbonationality"
        Me.cbonationality.Size = New System.Drawing.Size(123, 23)
        Me.cbonationality.TabIndex = 145
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(459, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 19)
        Me.Label9.TabIndex = 143
        Me.Label9.Text = "Nationality:"
        '
        'cboreligion
        '
        Me.cboreligion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboreligion.FormattingEnabled = True
        Me.cboreligion.Items.AddRange(New Object() {"Seventh Day Adventist", "Catholic", "Baptist", "Eglesia Ni Cristo", "Eglesia Sa Dios", "Born Again"})
        Me.cboreligion.Location = New System.Drawing.Point(120, 199)
        Me.cboreligion.Name = "cboreligion"
        Me.cboreligion.Size = New System.Drawing.Size(123, 23)
        Me.cboreligion.TabIndex = 141
        '
        'cbogender
        '
        Me.cbogender.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbogender.Location = New System.Drawing.Point(121, 158)
        Me.cbogender.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(75, 23)
        Me.cbogender.TabIndex = 140
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Gender:"
        '
        'txtcontactno
        '
        Me.txtcontactno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcontactno.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontactno.Location = New System.Drawing.Point(557, 16)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(213, 23)
        Me.txtcontactno.TabIndex = 135
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(486, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 19)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Mobile:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 19)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Religion:"
        '
        'dtpdateofbirth
        '
        Me.dtpdateofbirth.CalendarFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdateofbirth.CustomFormat = "MM/dd/yy"
        Me.dtpdateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdateofbirth.Location = New System.Drawing.Point(121, 118)
        Me.dtpdateofbirth.Name = "dtpdateofbirth"
        Me.dtpdateofbirth.Size = New System.Drawing.Size(123, 20)
        Me.dtpdateofbirth.TabIndex = 127
        Me.dtpdateofbirth.Value = New Date(2011, 1, 1, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 19)
        Me.Label10.TabIndex = 124
        Me.Label10.Text = "Doctor Code:"
        '
        'txtdoctorcode
        '
        Me.txtdoctorcode.BackColor = System.Drawing.Color.White
        Me.txtdoctorcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdoctorcode.Enabled = False
        Me.txtdoctorcode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdoctorcode.Location = New System.Drawing.Point(115, 17)
        Me.txtdoctorcode.Name = "txtdoctorcode"
        Me.txtdoctorcode.ReadOnly = True
        Me.txtdoctorcode.Size = New System.Drawing.Size(75, 23)
        Me.txtdoctorcode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Date of Birth: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 19)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Doctor Name:"
        '
        'txtdoctorsurename
        '
        Me.txtdoctorsurename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdoctorsurename.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdoctorsurename.Location = New System.Drawing.Point(115, 70)
        Me.txtdoctorsurename.Name = "txtdoctorsurename"
        Me.txtdoctorsurename.Size = New System.Drawing.Size(128, 23)
        Me.txtdoctorsurename.TabIndex = 1
        '
        'LblRecord
        '
        Me.LblRecord.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRecord.ForeColor = System.Drawing.Color.Black
        Me.LblRecord.Location = New System.Drawing.Point(387, 620)
        Me.LblRecord.Name = "LblRecord"
        Me.LblRecord.Size = New System.Drawing.Size(111, 18)
        Me.LblRecord.TabIndex = 1040
        Me.LblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(328, 620)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 18)
        Me.Label23.TabIndex = 1039
        Me.Label23.Text = "Record:"
        '
        'cmdFirst
        '
        Me.cmdFirst.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFirst.Location = New System.Drawing.Point(202, 641)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.Size = New System.Drawing.Size(62, 35)
        Me.cmdFirst.TabIndex = 1035
        Me.cmdFirst.Text = "  First"
        Me.cmdFirst.UseVisualStyleBackColor = True
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrevious.Location = New System.Drawing.Point(302, 641)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(62, 35)
        Me.cmdPrevious.TabIndex = 1036
        Me.cmdPrevious.Text = "  Previous"
        Me.cmdPrevious.UseVisualStyleBackColor = True
        '
        'cmdLast
        '
        Me.cmdLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLast.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdLast.Location = New System.Drawing.Point(504, 641)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.Size = New System.Drawing.Size(62, 35)
        Me.cmdLast.TabIndex = 1038
        Me.cmdLast.Text = "    Last"
        Me.cmdLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLast.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNext.Location = New System.Drawing.Point(409, 641)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(62, 35)
        Me.cmdNext.TabIndex = 1037
        Me.cmdNext.Text = "    Next"
        Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView.Location = New System.Drawing.Point(12, 439)
        Me.DataGridView.MultiSelect = False
        Me.DataGridView.Name = "DataGridView"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView.RowHeadersVisible = False
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.ShowCellErrors = False
        Me.DataGridView.ShowRowErrors = False
        Me.DataGridView.Size = New System.Drawing.Size(889, 176)
        Me.DataGridView.TabIndex = 1034
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.CBSearchCategory)
        Me.GroupBox7.Controls.Add(Me.Label39)
        Me.GroupBox7.Controls.Add(Me.tooltxtsearch)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 391)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(889, 42)
        Me.GroupBox7.TabIndex = 1033
        Me.GroupBox7.TabStop = False
        '
        'CBSearchCategory
        '
        Me.CBSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSearchCategory.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSearchCategory.FormattingEnabled = True
        Me.CBSearchCategory.Items.AddRange(New Object() {"Doctor Code", "Doctor Family Name"})
        Me.CBSearchCategory.Location = New System.Drawing.Point(129, 13)
        Me.CBSearchCategory.Name = "CBSearchCategory"
        Me.CBSearchCategory.Size = New System.Drawing.Size(114, 23)
        Me.CBSearchCategory.TabIndex = 1
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label39.Location = New System.Drawing.Point(12, 16)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(111, 18)
        Me.Label39.TabIndex = 3
        Me.Label39.Text = "Search Category:"
        '
        'tooltxtsearch
        '
        Me.tooltxtsearch.BackColor = System.Drawing.Color.White
        Me.tooltxtsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tooltxtsearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tooltxtsearch.Location = New System.Drawing.Point(249, 13)
        Me.tooltxtsearch.Name = "tooltxtsearch"
        Me.tooltxtsearch.Size = New System.Drawing.Size(180, 23)
        Me.tooltxtsearch.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Lavender
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(26, 26)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolbtnnew, Me.toolbtnsave, Me.ToolStripSeparator3, Me.toolbtnedit, Me.ToolStripSeparator4, Me.toolbtnsearch, Me.ToolStripSeparator5, Me.toolbtnclear, Me.ToolStripSeparator1, Me.toolbtndelete, Me.ToolStripSeparator7, Me.toolbtnrefresh, Me.ToolStripSeparator6})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Margin = New System.Windows.Forms.Padding(5)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(959, 36)
        Me.ToolStrip1.TabIndex = 1041
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 36)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 36)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 36)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 36)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 36)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 36)
        '
        'toolbtnnew
        '
        Me.toolbtnnew.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.toolbtnnew.Image = CType(resources.GetObject("toolbtnnew.Image"), System.Drawing.Image)
        Me.toolbtnnew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbtnnew.Margin = New System.Windows.Forms.Padding(0, 1, 0, 5)
        Me.toolbtnnew.Name = "toolbtnnew"
        Me.toolbtnnew.Size = New System.Drawing.Size(61, 30)
        Me.toolbtnnew.Text = "New"
        Me.toolbtnnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.toolbtnnew.ToolTipText = "New"
        '
        'toolbtnsave
        '
        Me.toolbtnsave.Image = CType(resources.GetObject("toolbtnsave.Image"), System.Drawing.Image)
        Me.toolbtnsave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbtnsave.Name = "toolbtnsave"
        Me.toolbtnsave.Size = New System.Drawing.Size(61, 33)
        Me.toolbtnsave.Text = "Save"
        Me.toolbtnsave.Visible = False
        '
        'toolbtnedit
        '
        Me.toolbtnedit.Image = CType(resources.GetObject("toolbtnedit.Image"), System.Drawing.Image)
        Me.toolbtnedit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbtnedit.Name = "toolbtnedit"
        Me.toolbtnedit.Size = New System.Drawing.Size(57, 33)
        Me.toolbtnedit.Text = "Edit"
        Me.toolbtnedit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'toolbtnsearch
        '
        Me.toolbtnsearch.AutoToolTip = False
        Me.toolbtnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.toolbtnsearch.Image = CType(resources.GetObject("toolbtnsearch.Image"), System.Drawing.Image)
        Me.toolbtnsearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbtnsearch.Name = "toolbtnsearch"
        Me.toolbtnsearch.Size = New System.Drawing.Size(72, 33)
        Me.toolbtnsearch.Text = "Search"
        '
        'toolbtnclear
        '
        Me.toolbtnclear.Image = CType(resources.GetObject("toolbtnclear.Image"), System.Drawing.Image)
        Me.toolbtnclear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbtnclear.Name = "toolbtnclear"
        Me.toolbtnclear.Size = New System.Drawing.Size(64, 33)
        Me.toolbtnclear.Text = "Clear"
        '
        'toolbtndelete
        '
        Me.toolbtndelete.Image = CType(resources.GetObject("toolbtndelete.Image"), System.Drawing.Image)
        Me.toolbtndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.toolbtndelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbtndelete.Name = "toolbtndelete"
        Me.toolbtndelete.Size = New System.Drawing.Size(70, 33)
        Me.toolbtndelete.Text = "Delete"
        '
        'toolbtnrefresh
        '
        Me.toolbtnrefresh.Image = CType(resources.GetObject("toolbtnrefresh.Image"), System.Drawing.Image)
        Me.toolbtnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.toolbtnrefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbtnrefresh.Name = "toolbtnrefresh"
        Me.toolbtnrefresh.Size = New System.Drawing.Size(76, 33)
        Me.toolbtnrefresh.Text = "Refresh"
        '
        'FrmDoctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(959, 688)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblRecord)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.cmdFirst)
        Me.Controls.Add(Me.cmdPrevious)
        Me.Controls.Add(Me.cmdLast)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.GroupBox7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDoctor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor Information"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtdoctorcode As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtdoctorsurename As System.Windows.Forms.TextBox
    Friend WithEvents LblRecord As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Private WithEvents cmdFirst As System.Windows.Forms.Button
    Private WithEvents cmdPrevious As System.Windows.Forms.Button
    Private WithEvents cmdLast As System.Windows.Forms.Button
    Private WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents CBSearchCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents tooltxtsearch As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolbtnnew As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolbtnsave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolbtnedit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolbtnsearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolbtnclear As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolbtndelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolbtnrefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents dtpdateofbirth As System.Windows.Forms.DateTimePicker
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboreligion As System.Windows.Forms.ComboBox
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtcontactno As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbonationality As System.Windows.Forms.ComboBox
    Private WithEvents txtemail As System.Windows.Forms.TextBox
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents txtaddress As System.Windows.Forms.TextBox
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbodoctorspecialization As System.Windows.Forms.ComboBox
    Friend WithEvents cbodoctorcategory As System.Windows.Forms.ComboBox
    Private WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents txtservicecharge As System.Windows.Forms.TextBox
    Private WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtdoctorfirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtdoctormiddlename As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
