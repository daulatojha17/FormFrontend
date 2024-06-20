Public Class MainMenue

    Private Sub CreateSubmission_Click(sender As Object, e As EventArgs) Handles CreateSubmission.Click
        Dim form1 As New SubmitForm()
        form1.Show()
    End Sub

    Private Sub ViewSubmission_Click(sender As Object, e As EventArgs) Handles ViewSubmission.Click
        Dim form2 As New ViewSubmission()
        form2.Show()
    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            CreateSubmission_Click(sender, e)
        End If

        If e.Control AndAlso e.KeyCode = Keys.V Then
            ViewSubmission_Click(sender, e)
        End If
    End Sub

End Class
