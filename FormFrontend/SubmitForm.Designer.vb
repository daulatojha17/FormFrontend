<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SubmitForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nameText = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.github_link = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.toggleStopwatch = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.stopwatch_time = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Github Link"
        '
        'nameText
        '
        Me.nameText.Location = New System.Drawing.Point(133, 85)
        Me.nameText.Name = "nameText"
        Me.nameText.Size = New System.Drawing.Size(215, 22)
        Me.nameText.TabIndex = 1
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(133, 161)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(215, 22)
        Me.phone.TabIndex = 3
        '
        'github_link
        '
        Me.github_link.Location = New System.Drawing.Point(133, 202)
        Me.github_link.Name = "github_link"
        Me.github_link.Size = New System.Drawing.Size(215, 22)
        Me.github_link.TabIndex = 4
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(133, 120)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(215, 22)
        Me.email.TabIndex = 2
        '
        'Submit
        '
        Me.Submit.BackColor = System.Drawing.Color.SkyBlue
        Me.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Submit.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Submit.Location = New System.Drawing.Point(12, 289)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(336, 32)
        Me.Submit.TabIndex = 6
        Me.Submit.Text = "SUBMIT (CTRL + S)"
        Me.Submit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(323, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Slidely Task - 2, Create Submission"
        '
        'toggleStopwatch
        '
        Me.toggleStopwatch.BackColor = System.Drawing.Color.Khaki
        Me.toggleStopwatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.toggleStopwatch.ForeColor = System.Drawing.SystemColors.Desktop
        Me.toggleStopwatch.Location = New System.Drawing.Point(12, 235)
        Me.toggleStopwatch.Name = "toggleStopwatch"
        Me.toggleStopwatch.Size = New System.Drawing.Size(235, 24)
        Me.toggleStopwatch.TabIndex = 5
        Me.toggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.toggleStopwatch.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'stopwatch_time
        '
        Me.stopwatch_time.Location = New System.Drawing.Point(260, 237)
        Me.stopwatch_time.Name = "stopwatch_time"
        Me.stopwatch_time.ReadOnly = True
        Me.stopwatch_time.Size = New System.Drawing.Size(95, 22)
        Me.stopwatch_time.TabIndex = 9
        Me.stopwatch_time.Text = "00:00:00"
        '
        'SubmitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 347)
        Me.Controls.Add(Me.toggleStopwatch)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.stopwatch_time)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.github_link)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.nameText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.KeyPreview = True
        Me.Name = "SubmitForm"
        Me.Text = "Submission Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nameText As TextBox
    Friend WithEvents phone As TextBox
    Friend WithEvents github_link As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents Submit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents toggleStopwatch As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents stopwatch_time As TextBox
End Class
