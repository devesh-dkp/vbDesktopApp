<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnViewSubmissions = New Button()
        btnCreateNewSubmission = New Button()
        Label1 = New Label()
        Label2 = New Label()
        btnSearch = New Button()
        txtEmailSearch = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.Yellow
        btnViewSubmissions.Cursor = Cursors.Hand
        btnViewSubmissions.Location = New Point(216, 137)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(334, 29)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "View Submissions (ctrl+V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateNewSubmission
        ' 
        btnCreateNewSubmission.BackColor = SystemColors.MenuHighlight
        btnCreateNewSubmission.Cursor = Cursors.Hand
        btnCreateNewSubmission.Location = New Point(216, 206)
        btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        btnCreateNewSubmission.Size = New Size(334, 29)
        btnCreateNewSubmission.TabIndex = 1
        btnCreateNewSubmission.Text = "Create New Submission (ctrl+N)"
        btnCreateNewSubmission.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        Label1.Font = New Font("Segoe UI Black", 18F)
        Label1.Location = New Point(240, 38)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(10, 6, 10, 6)
        Label1.Size = New Size(289, 53)
        Label1.TabIndex = 2
        Label1.Text = "Slidely Form App"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Silver
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(224, 392)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(2)
        Label2.Size = New Size(305, 27)
        Label2.TabIndex = 3
        Label2.Text = "Copyright 2024 Devesh Kumar Pandey"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Yellow
        btnSearch.Cursor = Cursors.Hand
        btnSearch.Location = New Point(216, 311)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(334, 29)
        btnSearch.TabIndex = 4
        btnSearch.Text = "View Submission (ctrl+E)"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtEmailSearch
        ' 
        txtEmailSearch.Location = New Point(332, 278)
        txtEmailSearch.Name = "txtEmailSearch"
        txtEmailSearch.Size = New Size(249, 27)
        txtEmailSearch.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonShadow
        Label3.Location = New Point(178, 281)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 20)
        Label3.TabIndex = 6
        Label3.Text = "Enter email to search"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(txtEmailSearch)
        Controls.Add(btnSearch)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCreateNewSubmission)
        Controls.Add(btnViewSubmissions)
        KeyPreview = True
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateNewSubmission As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtEmailSearch As TextBox
    Friend WithEvents Label3 As Label

End Class
