<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenue
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ViewSubmission = New System.Windows.Forms.Button()
        Me.CreateSubmission = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(28, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Slidely Task 2 - Slidely Form App"
        '
        'ViewSubmission
        '
        Me.ViewSubmission.BackColor = System.Drawing.Color.Khaki
        Me.ViewSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ViewSubmission.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ViewSubmission.Location = New System.Drawing.Point(12, 63)
        Me.ViewSubmission.Name = "ViewSubmission"
        Me.ViewSubmission.Size = New System.Drawing.Size(337, 47)
        Me.ViewSubmission.TabIndex = 6
        Me.ViewSubmission.Text = "VIEW SUBMISSIONS (CTRL + V)"
        Me.ViewSubmission.UseVisualStyleBackColor = False
        '
        'CreateSubmission
        '
        Me.CreateSubmission.BackColor = System.Drawing.Color.SkyBlue
        Me.CreateSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CreateSubmission.ForeColor = System.Drawing.SystemColors.Desktop
        Me.CreateSubmission.Location = New System.Drawing.Point(12, 129)
        Me.CreateSubmission.Name = "CreateSubmission"
        Me.CreateSubmission.Size = New System.Drawing.Size(337, 45)
        Me.CreateSubmission.TabIndex = 7
        Me.CreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        Me.CreateSubmission.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 186)
        Me.Controls.Add(Me.CreateSubmission)
        Me.Controls.Add(Me.ViewSubmission)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ViewSubmission As Button
    Friend WithEvents CreateSubmission As Button
End Class
