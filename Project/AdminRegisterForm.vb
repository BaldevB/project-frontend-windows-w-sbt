Imports System.ComponentModel
Imports Newtonsoft.Json.Linq

Public Class AdminRegisterForm
    Dim registerSuccess As Boolean = False
    Private Sub AdminRegisterForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AdminLoginForm.Show()
    End Sub

    Private Sub AdminRegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbInstId.Text = GenerateNewInstId()
    End Sub

    Private Function GenerateNewInstId() As String
        Dim val1 As Integer, val2 As Integer
        Dim random As New Random
        val1 = random.Next(100, 1000)
        val2 = random.Next(100, 1000)
        Return val1 & "-" & val2
    End Function

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If tbPassword.Text = tbPasswordVerification.Text Then
            tbFullName.Enabled = False
            tbEmail.Enabled = False
            tbPhoneNo.Enabled = False
            GroupBox4.Enabled = False
            tbPassword.Enabled = False
            tbPasswordVerification.Enabled = False
            btnRegister.Enabled = False
            bwAdminRegister.RunWorkerAsync()
        Else
            MsgBox("Passwords do not match.", MsgBoxStyle.Critical, "Invalid input")
        End If
    End Sub

    Private Function GetSelectedGender() As String
        If rbMale.Checked = True Then
            Return "male"
        ElseIf rbFemale.Checked = True Then
            Return "female"
        ElseIf rbNone.Checked = True Then
            Return "none"
        Else
            Return Nothing
        End If
    End Function

    Private Sub bwAdminRegister_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwAdminRegister.DoWork
        Dim post As New POSTClass
        Dim res As JObject = post.MakePOSTRequest("http://localhost:8080/admin/register", New With {Key .fullName = tbFullName.Text, Key .email = tbEmail.Text, Key .phoneNo = tbPhoneNo.Text,
                                                  Key .gender = GetSelectedGender(), Key .passwd = tbPassword.Text, Key .deviceId = "123123123", Key .instId = lbInstId.Text}).Result
        Dim statusCode = res.GetValue("status_code").ToString()
        If statusCode = "1" Then
            registerSuccess = True
        Else
            registerSuccess = False
        End If
    End Sub

    Private Sub bwAdminRegister_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwAdminRegister.RunWorkerCompleted
        If registerSuccess = True Then
            MsgBox("Registration successful.", MsgBoxStyle.Information, "Success")
            Me.Close()
        Else
            tbFullName.Enabled = True
            tbEmail.Enabled = True
            tbPhoneNo.Enabled = True
            GroupBox4.Enabled = True
            tbPassword.Enabled = True
            tbPasswordVerification.Enabled = True
            btnRegister.Enabled = True
            MsgBox("Registration failed.", MsgBoxStyle.Critical, "Failed")
        End If
    End Sub
End Class