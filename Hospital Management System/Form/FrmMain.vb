Public Class FrmMain
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Hide()



    End Sub



    Private Sub toolbtndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim choice As String

        choice = MsgBox("are you sure you want to logout?", vbQuestion + vbYesNo, "logout confirmation")

        If choice = vbYes Then

            Me.Close()

        End If
    End Sub



    Private Sub toolbtnuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub toolbtndoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmDoctor.Show()
    End Sub

    Private Sub toolbtnpatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmPatient.Show()
    End Sub

    Private Sub RoomsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransactionsToolStripMenuItem.Click

    End Sub

    Private Sub AvailableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmitToolStripMenuItem.Click
        FrmAdmit.ShowDialog()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        toolstripdate.Text = Date.Now.ToString("dd-MM-yyyy")
        toolstriptime.Text = TimeOfDay.ToString("hh:mm:ss")

    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub toolstripusername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripusername.Click

    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationToolStripMenuItem.Click
        FrmRegistration.lbluser.Text = toolstripusername.Text
        FrmRegistration.ShowDialog()

    End Sub

    Private Sub frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub toolstripadmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstrippatient.Click
        FrmPatient.ShowDialog()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmChangePassword.ShowDialog()

    End Sub

    Private Sub LockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmLock.ShowDialog()
    End Sub

    Private Sub DischargeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DischargeToolStripMenuItem.Click
        FrmCashier.ShowDialog()

    End Sub

    Private Sub PatientInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientInformationToolStripMenuItem.Click
        FrmPatient.ShowDialog()
    End Sub

    Private Sub DoctorInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorInformationToolStripMenuItem.Click
        FrmDoctor.ShowDialog()

    End Sub

    Private Sub AdmitPatientToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmitPatientToolStripMenuItem.Click
        FrmAdmitPatientReport.ShowDialog()


    End Sub

    Private Sub DischargeReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DischargeReportToolStripMenuItem.Click
        FrmDischargeReport.ShowDialog()

    End Sub

    Private Sub toolstripdoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripdoctor.Click
        FrmDoctor.ShowDialog()

    End Sub

    Private Sub toolstripadmit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripadmit.Click
        FrmAdmit.ShowDialog()

    End Sub

    Private Sub toolstripdischarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstripdischarge.Click
        FrmCashier.ShowDialog()

    End Sub

    Private Sub toolstrippatientreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstrippatientreport.Click
        FrmAdmitPatientReport.ShowDialog()

    End Sub

    Private Sub toolstrippatientvisit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolstrippatientvisit.Click
        FrmAdmitHistory.ShowDialog()

    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click

    End Sub

    Private Sub NotePadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotePadToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Notepad.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Calc.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub WordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("Word.exe")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        FrmChangePassword.ShowDialog()

    End Sub

    Private Sub LockToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockToolStripMenuItem.Click
        FrmLock.ShowDialog()

    End Sub
End Class