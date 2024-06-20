<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        etxt = New TextBox()
        ptxt = New TextBox()
        ntxt = New TextBox()
        gtxt = New TextBox()
        submitButton = New Button()
        timertxt = New Label()
        toggleButton = New Button()
        Timer1 = New Timer(components)
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(142, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(142, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(142, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 2
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(142, 269)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 20)
        Label4.TabIndex = 3
        Label4.Text = "Github Repo Link"
        ' 
        ' etxt
        ' 
        etxt.Location = New Point(301, 157)
        etxt.Name = "etxt"
        etxt.Size = New Size(343, 27)
        etxt.TabIndex = 4
        ' 
        ' ptxt
        ' 
        ptxt.Location = New Point(301, 213)
        ptxt.Name = "ptxt"
        ptxt.Size = New Size(343, 27)
        ptxt.TabIndex = 5
        ' 
        ' ntxt
        ' 
        ntxt.Location = New Point(301, 94)
        ntxt.Name = "ntxt"
        ntxt.Size = New Size(343, 27)
        ntxt.TabIndex = 6
        ' 
        ' gtxt
        ' 
        gtxt.Location = New Point(301, 269)
        gtxt.Name = "gtxt"
        gtxt.Size = New Size(343, 27)
        gtxt.TabIndex = 7
        ' 
        ' submitButton
        ' 
        submitButton.BackColor = SystemColors.MenuHighlight
        submitButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        submitButton.Location = New Point(322, 357)
        submitButton.Name = "submitButton"
        submitButton.Size = New Size(132, 29)
        submitButton.TabIndex = 8
        submitButton.Text = "Submit (ctrl+S)"
        submitButton.UseVisualStyleBackColor = False
        ' 
        ' timertxt
        ' 
        timertxt.AutoSize = True
        timertxt.Font = New Font("Segoe UI", 15F)
        timertxt.Location = New Point(420, 313)
        timertxt.Name = "timertxt"
        timertxt.Size = New Size(103, 35)
        timertxt.TabIndex = 9
        timertxt.Text = "00:00:00"
        ' 
        ' toggleButton
        ' 
        toggleButton.BackColor = Color.Yellow
        toggleButton.Location = New Point(97, 319)
        toggleButton.Name = "toggleButton"
        toggleButton.Size = New Size(208, 29)
        toggleButton.TabIndex = 10
        toggleButton.Text = "Toggle Stopwatch (ctrl+T)"
        toggleButton.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Fuchsia
        Label5.Font = New Font("Segoe UI Black", 15F)
        Label5.Location = New Point(248, 28)
        Label5.Name = "Label5"
        Label5.Size = New Size(168, 35)
        Label5.TabIndex = 11
        Label5.Text = "Fill the form"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.AppWorkspace
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(211, 408)
        Label6.Name = "Label6"
        Label6.Size = New Size(301, 23)
        Label6.TabIndex = 12
        Label6.Text = "Copyright 2024 Devesh Kumar Pandey"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(toggleButton)
        Controls.Add(timertxt)
        Controls.Add(submitButton)
        Controls.Add(gtxt)
        Controls.Add(ntxt)
        Controls.Add(ptxt)
        Controls.Add(etxt)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents etxt As TextBox
    Friend WithEvents ptxt As TextBox
    Friend WithEvents ntxt As TextBox
    Friend WithEvents gtxt As TextBox
    Friend WithEvents submitButton As Button
    Friend WithEvents timertxt As Label
    Friend WithEvents toggleButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
