Imports System.ComponentModel
Imports Newtonsoft.Json.Linq

Public Class AdminLoginForm
    Dim loginSuccess As Boolean = False
    Private Sub AdminLoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        btnLogin.Enabled = False
        tbPhoneNo.Enabled = False
        tbPassword.Enabled = False
        btnRegister.Enabled = False
        bwAdminLogin.RunWorkerAsync()
    End Sub

    Private Sub bwAdminLogin_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwAdminLogin.DoWork
        Dim post As New POSTClass
        Dim res As JObject = post.MakePOSTRequest("http://localhost:8080/admin/login", New With {Key .phoneNo = tbPhoneNo.Text, Key .passwd = tbPassword.Text}).Result
        Dim statusCode = res.GetValue("status_code").ToString()
        If statusCode = "1" Then
            loginSuccess = True
        Else
            loginSuccess = False
        End If
    End Sub

    Private Sub bwAdminLogin_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwAdminLogin.RunWorkerCompleted
        If loginSuccess = True Then
            Me.Hide()
            AdminMain.Show()
        Else
            btnLogin.Enabled = True
            tbPhoneNo.Enabled = True
            tbPassword.Enabled = True
            btnRegister.Enabled = True
            MsgBox("Login failed", MsgBoxStyle.Critical, "Authentication error")
        End If
    End Sub

    Private Sub AdminLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        AdminRegisterForm.Show()
    End Sub
End Class