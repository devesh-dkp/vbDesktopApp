Imports Newtonsoft.Json
Imports System.Net.Http

Public Class Form1
    ' Event handler for "View Submissions" button click
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    ' Event handler for "Create New Submission" button click
    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    ' Handle the KeyDown event for shortcuts
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.V
                    ' Ctrl+V for View Submissions
                    btnViewSubmissions.PerformClick()
                    e.SuppressKeyPress = True ' Prevents the key event from being passed to other controls
                Case Keys.N
                    ' Ctrl+N for Create New Submission
                    btnCreateNewSubmission.PerformClick()
                    e.SuppressKeyPress = True ' Prevents the key event from being passed to other controls
                Case Keys.E
                    ' Ctrl+E for Search Submissions by Email
                    btnSearch.PerformClick()
                    e.SuppressKeyPress = True ' Prevents the key event from being passed to other controls
            End Select
        End If
    End Sub

    ' Event handler for "Search" button click
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim email As String = txtEmailSearch.Text.Trim()
        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please enter an email address to search.")
            Return
        End If

        Try
            Dim client As New HttpClient()
            Dim response As HttpResponseMessage = client.GetAsync("http://localhost:5000/search?email=" & email).Result

            If response.IsSuccessStatusCode Then
                ' Parse the JSON response
                Dim submissions As String = response.Content.ReadAsStringAsync().Result
                Dim data As List(Of Dictionary(Of String, String)) = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, String)))(submissions)

                If data.Count > 0 Then
                    ' Display the first matching submission
                    Dim viewForm As New ViewSubmissionsForm(data)
                    viewForm.Show()
                Else
                    MessageBox.Show("No submissions found for the given email address.")
                End If
            Else
                MessageBox.Show("Failed to fetch submissions.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub txtEmailSearch_TextChanged(sender As Object, e As EventArgs) Handles txtEmailSearch.TextChanged
        ' You can handle any additional logic when the text changes, if needed.
    End Sub
End Class
