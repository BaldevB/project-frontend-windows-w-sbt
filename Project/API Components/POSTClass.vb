Imports Flurl.Http
Imports Newtonsoft.Json.Linq

Public Class POSTClass
    Public Async Function MakePOSTRequest(url As String, body As Object) As Task(Of JObject)
        Try
            Dim responseString = Await url.PostUrlEncodedAsync(body).ReceiveString()
            Dim d As JObject = Newtonsoft.Json.JsonConvert.DeserializeObject(responseString)
            Return d
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class