Imports System.Windows.Forms
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateNewSubmissionForm
    ' Variables to manage the stopwatch
    Private stopwatchRunning As Boolean = False
    Private elapsedTime As TimeSpan = TimeSpan.Zero
    Private startTime As DateTime

    ' HttpClient for API calls
    Private ReadOnly client As New HttpClient()

    ' Event handler for Form Load
    Private Sub CreateNewSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True ' Enables form to capture key presses
    End Sub

    ' Event handler for KeyDown to handle keyboard shortcuts
    Private Sub CreateNewSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Trigger Submit button click
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            ' Trigger Toggle Stopwatch button click
            btnToggle.PerformClick()
        End If
    End Sub

    ' Event handler for Submit button click
    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Retrieve input values from textboxes
        Dim name As String = TextBox1.Text
        Dim email As String = TextBox2.Text
        Dim phoneNum As String = TextBox3.Text
        Dim gitHubLink As String = TextBox4.Text

        ' Prepare submission data
        Dim submission As New With {
            .name = name,
            .email = email,
            .phone = phoneNum,
            .github_link = gitHubLink,
            .stopwatch_time = elapsedTime.ToString("hh\:mm\:ss")
        }

        ' Convert to JSON
        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        ' Send POST request to the backend
        Dim response = Await client.PostAsync("http://localhost:3000/submit", content)
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Form Submitted!" & vbCrLf &
                            "Name: " & name & vbCrLf &
                            "Email: " & email & vbCrLf &
                            "Phone Num: " & phoneNum & vbCrLf &
                            "GitHub Link: " & gitHubLink)
        Else
            MessageBox.Show("Error submitting form.")
        End If

        ' Reset form fields after submission
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        elapsedTime = TimeSpan.Zero
        btnTime.Text = "00:00:00"
    End Sub

    ' Event handler for Toggle Stopwatch button click
    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        If stopwatchRunning Then
            ' Stop the stopwatch
            Timer1.Stop()
            elapsedTime += DateTime.Now - startTime
            btnToggle.Text = "START STOPWATCH (CTRL + T)"
        Else
            ' Start the stopwatch
            startTime = DateTime.Now
            Timer1.Start()
            btnToggle.Text = "STOP STOPWATCH (CTRL + T)"
        End If

        ' Toggle the running state
        stopwatchRunning = Not stopwatchRunning
    End Sub

    ' Event handler for Timer Tick
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Calculate elapsed time
        Dim currentTime As TimeSpan = elapsedTime + (DateTime.Now - startTime)
        btnTime.Text = currentTime.ToString("hh\:mm\:ss")
    End Sub

    ' Event handler for form closing to ensure Timer stops
    Private Sub CreateNewSubmissionForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Ensure the timer is stopped to release resources
        Timer1.Stop()
    End Sub
End Class
