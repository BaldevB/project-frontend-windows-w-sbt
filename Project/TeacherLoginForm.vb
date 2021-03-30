Imports System.ComponentModel
Imports Newtonsoft.Json.Linq

Public Class TeacherLoginForm
    Dim loginSuccess As Boolean = False
    Private Sub TeacherLoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main.Show()
    End Sub

    Private Sub bwTeacherLogin_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwTeacherLogin.DoWork
        Dim post As New POSTClass
        Dim res As JObject = post.MakePOSTRequest("http://localhost:8080/teacher/login", New With {Key .phoneNo = tbPhoneNo.Text, Key .passwd = tbPassword.Text}).Result
        Dim statusCode = res.GetValue("status_code").ToString()
        If statusCode = "1" Then
            loginSuccess = True
        Else
            loginSuccess = False
        End If
    End Sub

    Private Sub bwTeacherLogin_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwTeacherLogin.RunWorkerCompleted
        If loginSuccess = True Then
            Me.Hide()
            TeacherMain.Show()
        Else
            btnLogin.Enabled = True
            tbPhoneNo.Enabled = True
            tbPassword.Enabled = True
            btnRegister.Enabled = True
            MsgBox("Login failed", MsgBoxStyle.Critical, "Authentication error")
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        btnLogin.Enabled = False
        tbPhoneNo.Enabled = False
        tbPassword.Enabled = False
        btnRegister.Enabled = False
        bwTeacherLogin.RunWorkerAsync()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        TeacherRegisterForm.Show()
    End Sub
End Class