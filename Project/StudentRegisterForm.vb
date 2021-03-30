Public Class StudentRegisterForm
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        GroupBox6.ForeColor = SystemColors.WindowText
        If tbPassword.Text = tbPasswordVerification.Text Then
            Me.Hide()
            With StudentRegisterInputInstIdForm
                .email = tbEmail.Text
                .passwd = tbPassword.Text
                .phoneNo = tbPhoneNo.Text
                .address = tbAddress.Text
            End With
            StudentRegisterInputInstIdForm.Show()
        Else
            GroupBox6.ForeColor = Color.Red
        End If
    End Sub

    Private Sub StudentRegisterForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        StudentLoginForm.Show()
    End Sub
End Class