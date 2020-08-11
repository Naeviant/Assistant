<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewExams
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewExams))
        Me.txt_notes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_subject = New System.Windows.Forms.TextBox()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.txt_starttime = New System.Windows.Forms.TextBox()
        Me.txt_endtime = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_notes
        '
        Me.txt_notes.Location = New System.Drawing.Point(342, 16)
        Me.txt_notes.Multiline = True
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_notes.Size = New System.Drawing.Size(215, 124)
        Me.txt_notes.TabIndex = 83
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(298, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Notes:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "End Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Start Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Day:"
        '
        'txt_location
        '
        Me.txt_location.Location = New System.Drawing.Point(82, 42)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(195, 20)
        Me.txt_location.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Location:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Subject:"
        '
        'txt_subject
        '
        Me.txt_subject.Location = New System.Drawing.Point(82, 16)
        Me.txt_subject.Name = "txt_subject"
        Me.txt_subject.Size = New System.Drawing.Size(195, 20)
        Me.txt_subject.TabIndex = 84
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(82, 68)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(195, 20)
        Me.txt_date.TabIndex = 85
        '
        'txt_starttime
        '
        Me.txt_starttime.Location = New System.Drawing.Point(82, 94)
        Me.txt_starttime.Name = "txt_starttime"
        Me.txt_starttime.Size = New System.Drawing.Size(195, 20)
        Me.txt_starttime.TabIndex = 86
        '
        'txt_endtime
        '
        Me.txt_endtime.Location = New System.Drawing.Point(82, 120)
        Me.txt_endtime.Name = "txt_endtime"
        Me.txt_endtime.Size = New System.Drawing.Size(195, 20)
        Me.txt_endtime.TabIndex = 87
        '
        'ViewExams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 156)
        Me.Controls.Add(Me.txt_endtime)
        Me.Controls.Add(Me.txt_starttime)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.txt_subject)
        Me.Controls.Add(Me.txt_notes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ViewExams"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Exam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_notes As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_location As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_subject As TextBox
    Friend WithEvents txt_date As TextBox
    Friend WithEvents txt_starttime As TextBox
    Friend WithEvents txt_endtime As TextBox
End Class
