Imports CrystalDecisions.Shared

Public Class FrmAdmitPatientReport
    Public FirstDate As Date
    Public SecondDate As Date

    Public Sub GetReport()
        Dim rpt As New PatientDischargeReport
        rpt.Load(Application.StartupPath & "\PatientDischargeReport.rpt")

        Dim pfields As New ParameterFields
        Dim pfield As New ParameterField
        Dim pdiscrete As New ParameterDiscreteValue

        Dim pfield1 As New ParameterField
        Dim pdiscrete1 As New ParameterDiscreteValue

        pfield.Name = "srat_date"
        pdiscrete.Value = FirstDate
        pfield.CurrentValues.Add(pdiscrete)
        pfields.Add(pfield)

        pfield1.Name = "end_date"
        pdiscrete1.Value = SecondDate
        pfield1.CurrentValues.Add(pdiscrete1)
        pfields.Add(pfield1)

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.ParameterFieldInfo = pfields


    End Sub

    Private Sub FrmAdmitPatientReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetReport()
    End Sub

    'Private Sub InitializeComponent()
    '     Me.SuspendLayout()
    '
    'FrmAdmitPatientReport
    '
    '   Me.ClientSize = New System.Drawing.Size(982, 408)
    '     Me.Name = "FrmAdmitPatientReport"
    '   Me.ResumeLayout(False)

    ' End Sub

    ' Private Sub FrmAdmitPatientReport_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    ' End Sub

    ' Private Sub InitializeComponent()
    '     Me.SuspendLayout()
    '
    'FrmAdmitPatientReport
    '
    '    Me.ClientSize = New System.Drawing.Size(284, 262)
    '    Me.Name = "FrmAdmitPatientReport"
    '    Me.ResumeLayout(False)

    '  End Sub
End Class