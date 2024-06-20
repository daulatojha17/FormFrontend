Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Net.Http
Imports System.Reflection
Imports System.Text

Public Class ViewSubmission
    Dim ind As Integer = -1
    Dim mxInd As Integer = 1
    Dim fData As Dictionary(Of String, String)
    Dim isDeleted As Boolean = False
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            previous.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            nxt.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.D Then
            Delete.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.E Then
            Edit.PerformClick()
        End If

    End Sub
    Private Function SetData(formData As Dictionary(Of String, String)) As Task
        fData = formData
        nameText.Text = formData("name")
        email.Text = formData("email")
        phone.Text = formData("phone")
        github_link.Text = formData("github_link")
        stopwatch_time.Text = formData("stopwatch_time")
        Dim tmp As Integer = formData("mxInd")
        mxInd = tmp
    End Function

    Private Async Function FetchData() As Task
        Using client As New HttpClient()
            Try
                Dim apiUrl As String = "http://localhost:3000/read?index=" + ind.ToString()

                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    Dim jsonObject As JObject = JObject.Parse(jsonResponse)

                    Dim dataObject As JObject = jsonObject("data")

                    Dim dataDict As Dictionary(Of String, String) = dataObject.ToObject(Of Dictionary(Of String, String))()
                    isDeleted = False
                    SetData(dataDict)
                Else
                    MessageBox.Show("Error fetching data: " & response.ReasonPhrase)
                End If
            Catch ex As Exception
                MessageBox.Show("Exception while fetching data: " & ex.Message)
            End Try
        End Using
    End Function

    Private Async Sub Nxt_Click(sender As Object, e As EventArgs) Handles nxt.Click
        If ind = -1 Then
            ind = 0
        ElseIf ind < mxInd Then
            ind += 1
        Else
            MessageBox.Show("No more data available")
            Return
        End If
        Await FetchData()
    End Sub
    Private Async Sub Previous_Click(sender As Object, e As EventArgs) Handles previous.Click

        If ind - 1 >= 0 Then
            ind -= 1
        Else
            MessageBox.Show("No more data available")
            Return
        End If
        Await FetchData()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If ind = -1 Then
            MessageBox.Show("No data to edit")
            Return
        ElseIf isDeleted Then
            MessageBox.Show("Data deleted. Cannot edit")
            Return
        End If

        Dim form1 As New SubmitForm(ind, fData)
        form1.Show()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If ind = -1 Then
            MessageBox.Show("No data to delete")
            Return
        End If
        DeleteData()
    End Sub

    Private Async Function DeleteData() As Task
        Using client As New HttpClient()
            Try
                Dim apiUrl As String = "http://localhost:3000/delete/" + ind.ToString()

                Dim response As HttpResponseMessage = Await client.DeleteAsync(apiUrl)

                If response.IsSuccessStatusCode Then

                    mxInd = mxInd - 1
                    MessageBox.Show("Data deleted successfully!")
                    nameText.Text = ""
                    email.Text = ""
                    phone.Text = ""
                    github_link.Text = ""
                    stopwatch_time.Text = ""
                    isDeleted = True
                Else
                    MessageBox.Show("Error deleting data: " & response.ReasonPhrase)
                End If
            Catch ex As Exception
                MessageBox.Show("Exception deleting data: " & ex.Message)
            End Try
        End Using
    End Function
End Class