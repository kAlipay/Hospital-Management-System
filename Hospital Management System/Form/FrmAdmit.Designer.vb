<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdmit
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
        Me.txtpatientname = New System.Windows.Forms.TextBox()
        Me.txtroomnumber = New System.Windows.Forms.TextBox()
        Me.txtroomrate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtdoctorcategory = New System.Windows.Forms.TextBox()
        Me.txtdoctorname = New System.Windows.Forms.TextBox()
        Me.txtservicecharge = New System.Windows.Forms.TextBox()
        Me.txtroomtype = New System.Windows.Forms.TextBox()
        Me.txtdate = New System.Windows.Forms.DateTimePicker()
        Me.txtdoctorname1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtservicecharge1 = New System.Windows.Forms.TextBox()
        Me.txtdoctorcategory1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btncheckin = New System.Windows.Forms.Button()
        Me.txtroomID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpatientname
        '
        Me.txtpatientname.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtpatientname.Location = New System.Drawing.Point(411, 224)
        Me.txtpatientname.Name = "txtpatientname"
        Me.txtpatientname.Size = New System.Drawing.Size(192, 23)
        Me.txtpatientname.TabIndex = 0
        '
        'txtroomnumber
        '
        Me.txtroomnumber.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtroomnumber.Location = New System.Drawing.Point(411, 272)
        Me.txtroomnumber.Name = "txtroomnumber"
        Me.txtroomnumber.Size = New System.Drawing.Size(192, 23)
        Me.txtroomnumber.TabIndex = 1
        '
        'txtroomrate
        '
        Me.txtroomrate.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtroomrate.Location = New System.Drawing.Point(412, 370)
        Me.txtroomrate.Name = "txtroomrate"
        Me.txtroomrate.Size = New System.Drawing.Size(192, 23)
        Me.txtroomrate.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(407, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Patient Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(408, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Room Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(407, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Room Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(407, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Room Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(408, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Check in Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(49, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 19)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Doctor Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(49, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 19)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Doctor Category:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(49, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 19)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Service Charge:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(654, 218)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 33)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "...."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(654, 272)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(57, 33)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "...."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtdoctorcategory
        '
        Me.txtdoctorcategory.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtdoctorcategory.Location = New System.Drawing.Point(50, 272)
        Me.txtdoctorcategory.Name = "txtdoctorcategory"
        Me.txtdoctorcategory.Size = New System.Drawing.Size(192, 23)
        Me.txtdoctorcategory.TabIndex = 33
        Me.txtdoctorcategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdoctorname
        '
        Me.txtdoctorname.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtdoctorname.Location = New System.Drawing.Point(50, 224)
        Me.txtdoctorname.Name = "txtdoctorname"
        Me.txtdoctorname.Size = New System.Drawing.Size(192, 23)
        Me.txtdoctorname.TabIndex = 34
        '
        'txtservicecharge
        '
        Me.txtservicecharge.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtservicecharge.Location = New System.Drawing.Point(50, 322)
        Me.txtservicecharge.Name = "txtservicecharge"
        Me.txtservicecharge.Size = New System.Drawing.Size(192, 23)
        Me.txtservicecharge.TabIndex = 35
        Me.txtservicecharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtroomtype
        '
        Me.txtroomtype.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtroomtype.Location = New System.Drawing.Point(411, 322)
        Me.txtroomtype.Name = "txtroomtype"
        Me.txtroomtype.Size = New System.Drawing.Size(192, 23)
        Me.txtroomtype.TabIndex = 36
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtdate.Location = New System.Drawing.Point(412, 418)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(192, 23)
        Me.txtdate.TabIndex = 37
        '
        'txtdoctorname1
        '
        Me.txtdoctorname1.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtdoctorname1.Location = New System.Drawing.Point(50, 370)
        Me.txtdoctorname1.Name = "txtdoctorname1"
        Me.txtdoctorname1.Size = New System.Drawing.Size(192, 23)
        Me.txtdoctorname1.TabIndex = 39
        Me.txtdoctorname1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(46, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 19)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Doctor Name:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(282, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 33)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "...."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtservicecharge1
        '
        Me.txtservicecharge1.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtservicecharge1.Location = New System.Drawing.Point(50, 466)
        Me.txtservicecharge1.Name = "txtservicecharge1"
        Me.txtservicecharge1.Size = New System.Drawing.Size(192, 23)
        Me.txtservicecharge1.TabIndex = 44
        Me.txtservicecharge1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdoctorcategory1
        '
        Me.txtdoctorcategory1.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtdoctorcategory1.Location = New System.Drawing.Point(50, 418)
        Me.txtdoctorcategory1.Name = "txtdoctorcategory1"
        Me.txtdoctorcategory1.Size = New System.Drawing.Size(192, 23)
        Me.txtdoctorcategory1.TabIndex = 43
        Me.txtdoctorcategory1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(49, 444)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 19)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Service Charge:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(49, 396)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 19)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Doctor Category:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(-2, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 179)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label25.Location = New System.Drawing.Point(195, 130)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(125, 25)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Since 1997"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label24.Location = New System.Drawing.Point(193, 82)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(285, 39)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Valencia, Bukidnon"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label23.Location = New System.Drawing.Point(193, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(620, 42)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "LAVINA GENERAL HOSPITAL, INC."
        '
        'PictureBox1
        '
        '  Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources._14232501_555176128007695_2808778614139142104_n
        Me.PictureBox1.Location = New System.Drawing.Point(-8, -26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(282, 360)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(57, 33)
        Me.Button5.TabIndex = 93
        Me.Button5.Text = "...."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        ' Me.Button2.Image = Global.Hospital_Management_System.My.Resources.Resources.Clear_icon1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(541, 500)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 41)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "&Clear"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btncheckin
        '
        '   Me.btncheckin.Image = Global.Hospital_Management_System.My.Resources.Resources.medical_bed_icon1
        Me.btncheckin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncheckin.Location = New System.Drawing.Point(398, 500)
        Me.btncheckin.Name = "btncheckin"
        Me.btncheckin.Size = New System.Drawing.Size(78, 41)
        Me.btncheckin.TabIndex = 11
        Me.btncheckin.Text = "&Admit"
        Me.btncheckin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncheckin.UseVisualStyleBackColor = True
        '
        'txtroomID
        '
        Me.txtroomID.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.txtroomID.Location = New System.Drawing.Point(852, 418)
        Me.txtroomID.Name = "txtroomID"
        Me.txtroomID.Size = New System.Drawing.Size(157, 23)
        Me.txtroomID.TabIndex = 94
        '
        'FrmAdmit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(830, 603)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.txtservicecharge1)
        Me.Controls.Add(Me.txtdoctorcategory1)
        Me.Controls.Add(Me.txtroomID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtdoctorname1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.txtroomtype)
        Me.Controls.Add(Me.txtservicecharge)
        Me.Controls.Add(Me.txtdoctorname)
        Me.Controls.Add(Me.txtdoctorcategory)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btncheckin)
        Me.Controls.Add(Me.txtroomrate)
        Me.Controls.Add(Me.txtroomnumber)
        Me.Controls.Add(Me.txtpatientname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Name = "FrmAdmit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admit . . ."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpatientname As System.Windows.Forms.TextBox
    Friend WithEvents txtroomnumber As System.Windows.Forms.TextBox
    Friend WithEvents txtroomrate As System.Windows.Forms.TextBox
    Friend WithEvents btncheckin As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtdoctorcategory As System.Windows.Forms.TextBox
    Friend WithEvents txtdoctorname As System.Windows.Forms.TextBox
    Friend WithEvents txtservicecharge As System.Windows.Forms.TextBox
    Friend WithEvents txtroomtype As System.Windows.Forms.TextBox
    Friend WithEvents txtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtdoctorname1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtservicecharge1 As System.Windows.Forms.TextBox
    Friend WithEvents txtdoctorcategory1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtroomID As System.Windows.Forms.TextBox
End Class
