Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCreateSubmissions.Click
        Dim createNewSubmissionForm As New CreateNewSubmissionForm()
        createNewSubmissionForm.Show()
    End Sub

    Private Sub btnViewSubmissions_Click_1(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmissions.PerformClick()
        End If
    End Sub

End Class
