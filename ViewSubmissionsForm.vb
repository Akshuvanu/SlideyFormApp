Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        submissions = SubmissionManager.LoadSubmissions()
        DisplaySubmission(currentIndex)


        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)

        End If

    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            txtName.Text = submissions(index).Name
            txtEmail.Text = submissions(index).Email
            txtPhoneNumber.Text = submissions(index).PhoneNumber
            txtGithubRepo.Text = submissions(index).GitHubLink
            txtTimestamp.Text = submissions(index).Timestamp

        End If
    End Sub
End Class