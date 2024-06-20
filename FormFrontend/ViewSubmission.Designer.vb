<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmission
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
        Me.stopwatch_time = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.github_link = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.nameText = New System.Windows.Forms.TextBox()
        Me.feild4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.feild2 = New System.Windows.Forms.Label()
        Me.feild1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.previous = New System.Windows.Forms.Button()
        Me.nxt = New System.Windows.Forms.Button()
        Me.feild5 = New System.Windows.Forms.Label()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'stopwatch_time
        '
        Me.stopwatch_time.Location = New System.Drawing.Point(260, 244)
        Me.stopwatch_time.Name = "stopwatch_time"
        Me.stopwatch_time.ReadOnly = True
        Me.stopwatch_time.Size = New System.Drawing.Size(95, 22)
        Me.stopwatch_time.TabIndex = 19
        Me.stopwatch_time.Text = "00:00:00"
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(133, 127)
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Size = New System.Drawing.Size(215, 22)
        Me.email.TabIndex = 13
        '
        'github_link
        '
        Me.github_link.Location = New System.Drawing.Point(133, 209)
        Me.github_link.Name = "github_link"
        Me.github_link.ReadOnly = True
        Me.github_link.Size = New System.Drawing.Size(215, 22)
        Me.github_link.TabIndex = 16
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(133, 168)
        Me.phone.Name = "phone"
        Me.phone.ReadOnly = True
        Me.phone.Size = New System.Drawing.Size(215, 22)
        Me.phone.TabIndex = 15
        '
        'nameText
        '
        Me.nameText.Location = New System.Drawing.Point(133, 92)
        Me.nameText.Name = "nameText"
        Me.nameText.ReadOnly = True
        Me.nameText.Size = New System.Drawing.Size(215, 22)
        Me.nameText.TabIndex = 11
        '
        'feild4
        '
        Me.feild4.AutoSize = True
        Me.feild4.Location = New System.Drawing.Point(12, 212)
        Me.feild4.Name = "feild4"
        Me.feild4.Size = New System.Drawing.Size(72, 16)
        Me.feild4.TabIndex = 17
        Me.feild4.Text = "Github Link"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Phone No."
        '
        'feild2
        '
        Me.feild2.AutoSize = True
        Me.feild2.Location = New System.Drawing.Point(12, 133)
        Me.feild2.Name = "feild2"
        Me.feild2.Size = New System.Drawing.Size(41, 16)
        Me.feild2.TabIndex = 12
        Me.feild2.Text = "Email"
        '
        'feild1
        '
        Me.feild1.AutoSize = True
        Me.feild1.Location = New System.Drawing.Point(12, 92)
        Me.feild1.Name = "feild1"
        Me.feild1.Size = New System.Drawing.Size(44, 16)
        Me.feild1.TabIndex = 10
        Me.feild1.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(312, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Slidely Task 2 - View Submissions"
        '
        'previous
        '
        Me.previous.BackColor = System.Drawing.Color.Khaki
        Me.previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.previous.Location = New System.Drawing.Point(12, 334)
        Me.previous.Name = "previous"
        Me.previous.Size = New System.Drawing.Size(180, 32)
        Me.previous.TabIndex = 21
        Me.previous.Text = "PREVIOUS (CTRL + P)"
        Me.previous.UseVisualStyleBackColor = False
        '
        'nxt
        '
        Me.nxt.BackColor = System.Drawing.Color.SkyBlue
        Me.nxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nxt.Location = New System.Drawing.Point(198, 334)
        Me.nxt.Name = "nxt"
        Me.nxt.Size = New System.Drawing.Size(174, 32)
        Me.nxt.TabIndex = 23
        Me.nxt.Text = "NEXT (CTRL + N)"
        Me.nxt.UseVisualStyleBackColor = False
        '
        'feild5
        '
        Me.feild5.AutoSize = True
        Me.feild5.Location = New System.Drawing.Point(12, 250)
        Me.feild5.Name = "feild5"
        Me.feild5.Size = New System.Drawing.Size(220, 16)
        Me.feild5.TabIndex = 24
        Me.feild5.Text = "TOGGLE STOPWATCH (CTRL + T)"
        '
        'Edit
        '
        Me.Edit.BackColor = System.Drawing.Color.PaleGreen
        Me.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Edit.Location = New System.Drawing.Point(12, 285)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(180, 32)
        Me.Edit.TabIndex = 25
        Me.Edit.Text = "EDIT FORM (CTRL + E)"
        Me.Edit.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete.Location = New System.Drawing.Point(198, 285)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(174, 32)
        Me.Delete.TabIndex = 26
        Me.Delete.Text = "DELETE (CTRL + D)"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'ViewSubmission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 378)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Edit)
        Me.Controls.Add(Me.feild5)
        Me.Controls.Add(Me.nxt)
        Me.Controls.Add(Me.previous)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.stopwatch_time)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.github_link)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.nameText)
        Me.Controls.Add(Me.feild4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.feild2)
        Me.Controls.Add(Me.feild1)
        Me.KeyPreview = True
        Me.Name = "ViewSubmission"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stopwatch_time As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents github_link As TextBox
    Friend WithEvents phone As TextBox
    Friend WithEvents nameText As TextBox
    Friend WithEvents feild4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents feild2 As Label
    Friend WithEvents feild1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents previous As Button
    Friend WithEvents nxt As Button
    Friend WithEvents feild5 As Label
    Friend WithEvents Edit As Button
    Friend WithEvents Delete As Button
End Class
