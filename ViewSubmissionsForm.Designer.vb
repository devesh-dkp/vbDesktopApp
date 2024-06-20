<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        lblName = New TextBox()
        lblEmail = New TextBox()
        lblPhone = New TextBox()
        lblGithubLink = New TextBox()
        Label5 = New Label()
        lblStopwatchTime = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(111, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnPrevious.Location = New Point(103, 322)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(151, 29)
        btnPrevious.TabIndex = 2
        btnPrevious.Text = "Previous (ctrl+P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.MenuHighlight
        btnNext.Location = New Point(485, 322)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(121, 29)
        btnNext.TabIndex = 3
        btnNext.Text = "Next (ctrl+N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(111, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 4
        Label3.Text = "Phone Num"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(111, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 5
        Label2.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(111, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 20)
        Label4.TabIndex = 6
        Label4.Text = "Github Repo Link"
        ' 
        ' lblName
        ' 
        lblName.BackColor = SystemColors.Info
        lblName.Enabled = False
        lblName.Location = New Point(278, 66)
        lblName.Name = "lblName"
        lblName.Size = New Size(226, 27)
        lblName.TabIndex = 7
        ' 
        ' lblEmail
        ' 
        lblEmail.BackColor = SystemColors.Info
        lblEmail.Enabled = False
        lblEmail.Location = New Point(278, 114)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(226, 27)
        lblEmail.TabIndex = 8
        ' 
        ' lblPhone
        ' 
        lblPhone.BackColor = SystemColors.Info
        lblPhone.Enabled = False
        lblPhone.Location = New Point(278, 171)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(226, 27)
        lblPhone.TabIndex = 9
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.BackColor = SystemColors.Info
        lblGithubLink.Enabled = False
        lblGithubLink.Location = New Point(278, 226)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(226, 27)
        lblGithubLink.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(111, 281)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 20)
        Label5.TabIndex = 11
        Label5.Text = "Stopwatch time"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.BackColor = SystemColors.Info
        lblStopwatchTime.Enabled = False
        lblStopwatchTime.Location = New Point(278, 278)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(226, 27)
        lblStopwatchTime.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.DarkViolet
        Label6.Font = New Font("Segoe UI Black", 15F)
        Label6.Location = New Point(225, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(237, 35)
        Label6.TabIndex = 13
        Label6.Text = "View Submissions"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.LightSlateGray
        Label7.Font = New Font("MingLiU_HKSCS-ExtB", 10F)
        Label7.Location = New Point(203, 405)
        Label7.Name = "Label7"
        Label7.Padding = New Padding(2)
        Label7.Size = New Size(318, 21)
        Label7.TabIndex = 14
        Label7.Text = "Copyright 2024 Devesh Kumar Pandey"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.ActiveCaption
        btnDelete.Location = New Point(593, 28)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(125, 29)
        btnDelete.TabIndex = 15
        btnDelete.Text = "Delete (ctrl+D)"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDelete)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(lblStopwatchTime)
        Controls.Add(Label5)
        Controls.Add(lblGithubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblName As TextBox
    Friend WithEvents lblEmail As TextBox
    Friend WithEvents lblPhone As TextBox
    Friend WithEvents lblGithubLink As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStopwatchTime As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDelete As Button
End Class
