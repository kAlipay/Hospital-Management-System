Public Class FrmDischargeReport


    Private Sub btnreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreport.Click
        If Val(DateTimePicker1.Value) < Val(DateTimePicker2.Value) Then
            MsgBox("Not to over due")
        Else
            FrmAdmitPatientReport.FirstDate = DateTimePicker1.Value
            FrmAdmitPatientReport.SecondDate = DateTimePicker2.Value
            FrmAdmitPatientReport.Show()
        End If
    End Sub
End Class