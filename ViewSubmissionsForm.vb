Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private totalSubmissions As Integer = 0
    Private searchResults As List(Of Dictionary(Of String, String))

    ' Constructor to accept search results
    Public Sub New(Optional ByVal results As List(Of Dictionary(Of String, String)) = Nothing)
        InitializeComponent()
        searchResults = results
    End Sub

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If searchResults IsNot Nothing AndAlso searchResults.Count > 0 Then
            ' Load the first submission from search results
            totalSubmissions = searchResults.Count
            DisplaySubmission(searchResults(currentIndex))
        Else
            ' Load the first submission from the backend
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub LoadSubmission(index As Integer)
        If searchResults IsNot Nothing AndAlso searchResults.Count > 0 Then
            DisplaySubmission(searchResults(index))
        Else
            Try
                ' Create HttpClient to fetch data from the backend
                Dim client As New HttpClient()
                Dim response As HttpResponseMessage = client.GetAsync("http://localhost:5000/read?index=" & index).Result

                If response.IsSuccessStatusCode Then
                    ' Parse the JSON response
                    Dim submission As String = response.Content.ReadAsStringAsync().Result
                    Dim data As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(submission)

                    ' Display the submission details
                    DisplaySubmission(data)

                    ' Update total submissions count (you might need a separate endpoint to get this count)
                    totalSubmissions = GetTotalSubmissions()
                Else
                    MessageBox.Show("Failed to fetch submission.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End If
    End Sub

    Private Function GetTotalSubmissions() As Integer
        ' Fetch total submissions count from the backend (assuming you have an endpoint for this)
        Dim client As New HttpClient()
        Dim response As HttpResponseMessage = client.GetAsync("http://localhost:5000/count").Result

        If response.IsSuccessStatusCode Then
            Dim count As Integer = Integer.Parse(response.Content.ReadAsStringAsync().Result)
            Return count
        Else
            Return 0
        End If
    End Function

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < totalSubmissions - 1 Then
            currentIndex += 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    ' Handle the KeyDown event for shortcuts
    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.P
                    ' Ctrl+P for Previous
                    btnPrevious.PerformClick()
                    e.SuppressKeyPress = True ' Prevents the key event from being passed to other controls
                Case Keys.N
                    ' Ctrl+N for Next
                    btnNext.PerformClick()
                    e.SuppressKeyPress = True ' Prevents the key event from being passed to other controls
                Case Keys.D
                    ' Ctrl+D for Delete
                    btnDelete.PerformClick()
                    e.SuppressKeyPress = True ' Prevents the key event from being passed to other controls
            End Select
        End If
    End Sub

    ' Handle delete button click
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim client As New HttpClient()
            Dim response As HttpResponseMessage = client.DeleteAsync("http://localhost:5000/delete?index=" & currentIndex).Result

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission deleted successfully.")
                ' Update total submissions count
                totalSubmissions = GetTotalSubmissions()

                ' Adjust currentIndex if needed
                If currentIndex >= totalSubmissions Then
                    currentIndex = totalSubmissions - 1
                End If

                ' Load the next submission if available
                If totalSubmissions > 0 Then
                    LoadSubmission(currentIndex)
                Else
                    ' Clear the form if no submissions are left
                    ClearSubmissionDetails()
                End If
            Else
                MessageBox.Show("Failed to delete submission.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    ' Clear the form details
    Private Sub ClearSubmissionDetails()
        lblName.Text = ""
        lblEmail.Text = ""
        lblPhone.Text = ""
        lblGithubLink.Text = ""
        lblStopwatchTime.Text = ""
    End Sub

    ' Display submission details
    Private Sub DisplaySubmission(submission As Dictionary(Of String, String))
        lblName.Text = submission("name")
        lblEmail.Text = submission("email")
        lblPhone.Text = submission("phone")
        lblGithubLink.Text = submission("githubLink")
        lblStopwatchTime.Text = submission("stopwatchTime")
    End Sub
End Class
