<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPatient))
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.CBSearchCategory = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.tooltxtsearch = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcontactno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpatientmi = New System.Windows.Forms.TextBox()
        Me.txtpatientfirstname = New System.Windows.Forms.TextBox()
        Me.cboblod = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtpatientcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpatientsurename = New System.Windows.Forms.TextBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.LblRecord = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmdFirst = New System.Windows.Forms.Button()
        Me.cmdPrevious = New System.Windows.Forms.Button()
        Me.cmdLast = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolbtnnew = New System.Windows.Forms.ToolStripButton()
        Me.toolbtnsave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbtnedit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbtnsearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbtnclear = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbtndelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbtnrefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.CBSearchCategory)
        Me.GroupBox7.Controls.Add(Me.Label39)
        Me.GroupBox7.Controls.Add(Me.tooltxtsearch)
        Me.GroupBox7.Location = New System.Drawing.Point(15, 234)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(812, 42)
        Me.GroupBox7.TabIndex = 193
        Me.GroupBox7.TabStop = False
        '
        'CBSearchCategory
        '
        Me.CBSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSearchCategory.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSearchCategory.FormattingEnabled = True
        Me.CBSearchCategory.Items.AddRange(New Object() {"Patient code", "Patient First Name", "Blood Type"})
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
        Me.tooltxtsearch.Location = New System.Drawing.Point(271, 11)
        Me.tooltxtsearch.Name = "tooltxtsearch"
        Me.tooltxtsearch.Size = New System.Drawing.Size(158, 23)
        Me.tooltxtsearch.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbogender)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtcontactno)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtaddress)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(454, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 173)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cbogender
        '
        Me.cbogender.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbogender.Location = New System.Drawing.Point(86, 23)
        Me.cbogender.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(119, 23)
        Me.cbogender.TabIndex = 133
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Gender:"
        '
        'txtcontactno
        '
        Me.txtcontactno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcontactno.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontactno.Location = New System.Drawing.Point(86, 99)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(192, 23)
        Me.txtcontactno.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 19)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Mobile:"
        '
        'txtaddress
        '
        Me.txtaddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtaddress.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(86, 61)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(192, 23)
        Me.txtaddress.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Address:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtpatientmi)
        Me.GroupBox1.Controls.Add(Me.txtpatientfirstname)
        Me.GroupBox1.Controls.Add(Me.cboblod)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtpatientcode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtpatientsurename)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 173)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Details"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(385, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 15)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "(MI)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(249, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 15)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = "(First Name)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "(Sure Name)"
        '
        'txtpatientmi
        '
        Me.txtpatientmi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpatientmi.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatientmi.Location = New System.Drawing.Point(378, 87)
        Me.txtpatientmi.Name = "txtpatientmi"
        Me.txtpatientmi.Size = New System.Drawing.Size(42, 23)
        Me.txtpatientmi.TabIndex = 129
        '
        'txtpatientfirstname
        '
        Me.txtpatientfirstname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpatientfirstname.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatientfirstname.Location = New System.Drawing.Point(252, 87)
        Me.txtpatientfirstname.Name = "txtpatientfirstname"
        Me.txtpatientfirstname.Size = New System.Drawing.Size(120, 23)
        Me.txtpatientfirstname.TabIndex = 128
        '
        'cboblod
        '
        Me.cboblod.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboblod.FormattingEnabled = True
        Me.cboblod.Items.AddRange(New Object() {"A+", "A-", "AB+", "AB-", "O+", "O-"})
        Me.cboblod.Location = New System.Drawing.Point(115, 129)
        Me.cboblod.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboblod.Name = "cboblod"
        Me.cboblod.Size = New System.Drawing.Size(109, 23)
        Me.cboblod.TabIndex = 127
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 19)
        Me.Label10.TabIndex = 124
        Me.Label10.Text = "Patient Code:"
        '
        'txtpatientcode
        '
        Me.txtpatientcode.BackColor = System.Drawing.Color.White
        Me.txtpatientcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpatientcode.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatientcode.Location = New System.Drawing.Point(115, 23)
        Me.txtpatientcode.Name = "txtpatientcode"
        Me.txtpatientcode.ReadOnly = True
        Me.txtpatientcode.Size = New System.Drawing.Size(75, 23)
        Me.txtpatientcode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Blood Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Patient Name:"
        '
        'txtpatientsurename
        '
        Me.txtpatientsurename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpatientsurename.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpatientsurename.Location = New System.Drawing.Point(115, 87)
        Me.txtpatientsurename.Name = "txtpatientsurename"
        Me.txtpatientsurename.Size = New System.Drawing.Size(128, 23)
        Me.txtpatientsurename.TabIndex = 1
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
        Me.DataGridView.Location = New System.Drawing.Point(15, 282)
        Me.DataGridView.MultiSelect = False
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
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
        Me.DataGridView.Size = New System.Drawing.Size(812, 233)
        Me.DataGridView.TabIndex = 1019
        '
        'LblRecord
        '
        Me.LblRecord.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRecord.ForeColor = System.Drawing.Color.Black
        Me.LblRecord.Location = New System.Drawing.Point(361, 535)
        Me.LblRecord.Name = "LblRecord"
        Me.LblRecord.Size = New System.Drawing.Size(111, 18)
        Me.LblRecord.TabIndex = 1030
        Me.LblRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(300, 535)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 18)
        Me.Label23.TabIndex = 1029
        Me.Label23.Text = "Record:"
        '
        'cmdFirst
        '
        Me.cmdFirst.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFirst.Location = New System.Drawing.Point(211, 565)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.Size = New System.Drawing.Size(62, 35)
        Me.cmdFirst.TabIndex = 1025
        Me.cmdFirst.Text = "  First"
        Me.cmdFirst.UseVisualStyleBackColor = True
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrevious.Location = New System.Drawing.Point(298, 565)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(62, 35)
        Me.cmdPrevious.TabIndex = 1026
        Me.cmdPrevious.Text = "  Previous"
        Me.cmdPrevious.UseVisualStyleBackColor = True
        '
        'cmdLast
        '
        Me.cmdLast.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLast.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdLast.Location = New System.Drawing.Point(479, 565)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.Size = New System.Drawing.Size(62, 35)
        Me.cmdLast.TabIndex = 1028
        Me.cmdLast.Text = "    Last"
        Me.cmdLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLast.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNext.Location = New System.Drawing.Point(388, 565)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(62, 35)
        Me.cmdNext.TabIndex = 1027
        Me.cmdNext.Text = "    Next"
        Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(26, 26)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolbtnnew, Me.toolbtnsave, Me.ToolStripSeparator3, Me.toolbtnedit, Me.ToolStripSeparator4, Me.toolbtnsearch, Me.ToolStripSeparator5, Me.toolbtnclear, Me.ToolStripSeparator1, Me.toolbtndelete, Me.ToolStripSeparator7, Me.toolbtnrefresh, Me.ToolStripSeparator6})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Margin = New System.Windows.Forms.Padding(5)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(847, 36)
        Me.ToolStrip1.TabIndex = 1032
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 36)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 36)
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
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 36)
        '
        'toolbtnclear
        '
        Me.toolbtnclear.Image = CType(resources.GetObject("toolbtnclear.Image"), System.Drawing.Image)
        Me.toolbtnclear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolbtnclear.Name = "toolbtnclear"
        Me.toolbtnclear.Size = New System.Drawing.Size(64, 33)
        Me.toolbtnclear.Text = "Clear"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 36)
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
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 36)
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
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 36)
        '
        'FrmPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(847, 645)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Information"
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtcontactno As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtaddress As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtpatientcode As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtpatientsurename As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LblRecord As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Private WithEvents cmdFirst As System.Windows.Forms.Button
    Private WithEvents cmdPrevious As System.Windows.Forms.Button
    Private WithEvents cmdLast As System.Windows.Forms.Button
    Private WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cboblod As System.Windows.Forms.ComboBox
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolbtnnew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolbtnedit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolbtndelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolbtnrefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolbtnsearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolbtnsave As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolbtnclear As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tooltxtsearch As System.Windows.Forms.TextBox
    Friend WithEvents CBSearchCategory As System.Windows.Forms.ComboBox
    Private WithEvents txtpatientfirstname As System.Windows.Forms.TextBox
    Private WithEvents txtpatientmi As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
