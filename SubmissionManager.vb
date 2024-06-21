Public Class SubmissionManager
    Public Shared Function LoadSubmissions() As List(Of Submission)
        ' Replace this with actual data loading logic
        Return New List(Of Submission) From {
            New Submission() With {.Name = "Akshaya", .Email = "akshayaap1001@gmail.com", .PhoneNum = "1234567890", .GitHubLink = "https://github.com/johndoe", .Timestamp = "2024-06-20 10:00:00"},
            New Submission() With {.Name = "Jane Smith", .Email = "jane@example.com", .PhoneNum = "0987654321", .GitHubLink = "https://github.com/janesmith", .Timestamp = "2024-06-20 11:00:00"}
        }
    End Function


End Class
