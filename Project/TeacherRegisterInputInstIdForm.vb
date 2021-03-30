Imports System.ComponentModel
Imports Newtonsoft.Json.Linq

Public Class TeacherRegisterInputInstIdForm
    Dim exceptn As Boolean = False
    Dim registerSuccess As Boolean = False

    Public phoneNo As String, passwd As String, address As String
    Private Sub TeacherRegisterInputInstIdForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If exceptn = False Then
            TeacherRegisterForm.Show()
        End If
    End Sub

    Private Sub bwTeacherRegister_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwTeacherRegister.DoWork
        Dim post As New POSTClass
        Dim res As JObject = post.MakePOSTRequest("http://localhost:8080/teacher/register/existing", New With {Key .phoneNo = phoneNo, Key .address = address,
                                                  Key .passwd = passwd, Key .deviceId = "123123123",
                                                  Key .instId = tbInstId1.Text & "-" & tbInstId2.Text}).Result
        Dim statusCode = res.GetValue("status_code").ToString()
        If statusCode = "1" Then
            registerSuccess = True
        Else
            registerSuccess = False
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        tbInstId1.ForeColor = SystemColors.WindowText
        tbInstId2.ForeColor = SystemColors.WindowText
        If tbInstId1.Text.Length = 3 And tbInstId2.Text.Length = 3 Then
            btnRegister.Enabled = False
            tbInstId1.Enabled = False
            tbInstId2.Enabled = False
            bwTeacherRegister.RunWorkerAsync()
        Else
            If tbInstId1.Text.Length = 3 Then
                tbInstId2.ForeColor = Color.Red
            Else
                tbInstId1.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub tbInstId1_TextChanged(sender As Object, e As EventArgs) Handles tbInstId1.TextChanged
        If tbInstId1.TextLength = 3 Then
            tbInstId2.Focus()
        End If
    End Sub

    Private Sub tbInstId2_TextChanged(sender As Object, e As EventArgs) Handles tbInstId2.TextChanged
        If tbInstId2.TextLength = 0 Then
            tbInstId1.Focus()
            tbInstId1.Select(3, 0)
        End If
    End Sub

    Private Sub bwTeacherRegister_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwTeacherRegister.RunWorkerCompleted
        If registerSuccess = True Then
            exceptn = True
            MsgBox("Registration success.", MsgBoxStyle.Information, "Success")
            TeacherLoginForm.Show()
            TeacherRegisterForm.Close()
            Me.Close()
        Else
            MsgBox("Registration failed. Please make sure you have entered your phone number and institution id correctly.", MsgBoxStyle.Critical, "Failed")
            Me.Close()
        End If
    End Sub
End Class