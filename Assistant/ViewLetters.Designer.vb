<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewLetters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewLetters))
        Me.chk_responsegiven = New System.Windows.Forms.CheckBox()
        Me.chk_responseneeded = New System.Windows.Forms.CheckBox()
        Me.txt_topic = New System.Windows.Forms.TextBox()
        Me.txt_notes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_from = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'chk_responsegiven
        '
        Me.chk_responsegiven.AutoSize = True
        Me.chk_responsegiven.Location = New System.Drawing.Point(188, 122)
        Me.chk_responsegiven.Name = "chk_responsegiven"
        Me.chk_responsegiven.Size = New System.Drawing.Size(15, 14)
        Me.chk_responsegiven.TabIndex = 101
        Me.chk_responsegiven.UseVisualStyleBackColor = True
        '
        'chk_responseneeded
        '
        Me.chk_responseneeded.AutoSize = True
        Me.chk_responseneeded.Location = New System.Drawing.Point(188, 97)
        Me.chk_responseneeded.Name = "chk_responseneeded"
        Me.chk_responseneeded.Size = New System.Drawing.Size(15, 14)
        Me.chk_responseneeded.TabIndex = 100
        Me.chk_responseneeded.UseVisualStyleBackColor = True
        '
        'txt_topic
        '
        Me.txt_topic.Location = New System.Drawing.Point(82, 16)
        Me.txt_topic.Name = "txt_topic"
        Me.txt_topic.Size = New System.Drawing.Size(195, 20)
        Me.txt_topic.TabIndex = 99
        '
        'txt_notes
        '
        Me.txt_notes.Location = New System.Drawing.Point(342, 16)
        Me.txt_notes.Multiline = True
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_notes.Size = New System.Drawing.Size(215, 124)
        Me.txt_notes.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(298, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Notes:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Response Given:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Response Needed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Day:"
        '
        'txt_from
        '
        Me.txt_from.Location = New System.Drawing.Point(82, 42)
        Me.txt_from.Name = "txt_from"
        Me.txt_from.Size = New System.Drawing.Size(195, 20)
        Me.txt_from.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "From:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Topic:"
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(82, 68)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(195, 20)
        Me.txt_date.TabIndex = 102
        '
        'ViewLetters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 156)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.chk_responsegiven)
        Me.Controls.Add(Me.chk_responseneeded)
        Me.Controls.Add(Me.txt_topic)
        Me.Controls.Add(Me.txt_notes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_from)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ViewLetters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Letter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk_responsegiven As CheckBox
    Friend WithEvents chk_responseneeded As CheckBox
    Friend WithEvents txt_topic As TextBox
    Friend WithEvents txt_notes As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_from As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_date As TextBox
End Class
