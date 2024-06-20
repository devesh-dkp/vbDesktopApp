Imports System.Net.Http
Imports Newtonsoft.Json
Imports System.Text

Public Class CreateSubmissionForm
    ' Timer start time and total elapsed time
    Private startTime As DateTime
    Private totalElapsedTime As TimeSpan

    ' Form Load event to initialize the timer
    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize timer variables
        startTime = DateTime.Now
        totalElapsedTime = TimeSpan.Zero
        Timer1.Interval = 1000 ' Set the timer interval to 1 second
        Timer1.Start()

        ' Set KeyPreview to True to handle key events
        Me.KeyPreview = True
    End Sub

    ' Event handler for submitButton Click event
    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        ' Gather data from text boxes
        Dim name As String = ntxt.Text
        Dim email As String = etxt.Text
        Dim phone As String = ptxt.Text
        Dim githubLink As String = gtxt.Text
        Dim timerValue As String = timertxt.Text ' Assuming this is where you display timer value

        ' Create a dictionary to hold the data
        Dim submissionData As New Dictionary(Of String, String)() From {
            {"name", name},
            {"email", email},
            {"phone", phone},
            {"github_link", githubLink},
            {"stopwatch_time", timerValue}
        }

        ' Convert the dictionary to JSON
        Dim jsonData As String = JsonConvert.SerializeObject(submissionData)
        Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")

        ' Send data to backend
        Dim client As New HttpClient()
        Dim response As HttpResponseMessage = client.PostAsync("http://localhost:5000/submit", content).Result

        ' Handle response if needed
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Data submitted successfully!")
        Else
            MessageBox.Show("Failed to submit data.")
        End If
    End Sub

    ' Event handler for toggleButton Click event
    Private Sub toggleButton_Click(sender As Object, e As EventArgs) Handles toggleButton.Click
        ' Toggle Timer1
        If Timer1.Enabled Then
            ' Stop the timer and accumulate the elapsed time
            Timer1.Stop()
            totalElapsedTime += DateTime.Now - startTime
        Else
            ' Start the timer and reset the start time
            startTime = DateTime.Now
            Timer1.Start()
        End If
    End Sub

    ' Event handler for Timer1 Tick event
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Calculate the total elapsed time including the current interval
        Dim elapsed As TimeSpan = totalElapsedTime + (DateTime.Now - startTime)

        ' Update the timertxt label with the current timer value
        timertxt.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", elapsed.Hours, elapsed.Minutes, elapsed.Seconds)
    End Sub

    ' Handle the KeyDown event for shortcuts
    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.S
                    ' Ctrl+S for submit
                    submitButton.PerformClick()
                    e.SuppressKeyPress = True ' Prevents the key event from being passed to other controls
                Case Keys.T
                    ' Ctrl+T for toggle stopwatch
                    toggleButton.PerformClick()
                    e.SuppressKeyPress = True ' Prevents the key event from being passed to other controls
            End Select
        End If
    End Sub
End Class
