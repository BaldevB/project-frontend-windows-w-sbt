Public Class TeacherRegisterForm
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If tbPassword.Text = tbPasswordVerification.Text Then
            Me.Hide()
            With TeacherRegisterInputInstIdForm
                .passwd = tbPassword.Text
                .phoneNo = tbPhoneNo.Text
                .address = tbAddress.Text
            End With
            TeacherRegisterInputInstIdForm.Show()
        Else
            MsgBox("Passwords do not match.", MsgBoxStyle.Critical, "Invalid input")
        End If
    End Sub

    Private Sub TeacherRegisterForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TeacherLoginForm.Show()
    End Sub

    Private Sub TeacherRegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class