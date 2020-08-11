<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSubjects))
        Me.txt_class = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_room = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_teacher = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_subject = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_lastrevised = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_revise = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_class
        '
        Me.txt_class.Location = New System.Drawing.Point(91, 95)
        Me.txt_class.Name = "txt_class"
        Me.txt_class.Size = New System.Drawing.Size(206, 20)
        Me.txt_class.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Class:"
        '
        'txt_room
        '
        Me.txt_room.Location = New System.Drawing.Point(91, 69)
        Me.txt_room.Name = "txt_room"
        Me.txt_room.Size = New System.Drawing.Size(206, 20)
        Me.txt_room.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Room:"
        '
        'txt_teacher
        '
        Me.txt_teacher.Location = New System.Drawing.Point(91, 43)
        Me.txt_teacher.Name = "txt_teacher"
        Me.txt_teacher.Size = New System.Drawing.Size(206, 20)
        Me.txt_teacher.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Teacher:"
        '
        'txt_subject
        '
        Me.txt_subject.Location = New System.Drawing.Point(91, 17)
        Me.txt_subject.Name = "txt_subject"
        Me.txt_subject.Size = New System.Drawing.Size(206, 20)
        Me.txt_subject.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Subject:"
        '
        'txt_lastrevised
        '
        Me.txt_lastrevised.Location = New System.Drawing.Point(91, 121)
        Me.txt_lastrevised.Name = "txt_lastrevised"
        Me.txt_lastrevised.Size = New System.Drawing.Size(206, 20)
        Me.txt_lastrevised.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Last Revised:"
        '
        'chk_revise
        '
        Me.chk_revise.AutoSize = True
        Me.chk_revise.Location = New System.Drawing.Point(188, 150)
        Me.chk_revise.Name = "chk_revise"
        Me.chk_revise.Size = New System.Drawing.Size(15, 14)
        Me.chk_revise.TabIndex = 35
        Me.chk_revise.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Revise:"
        '
        'ViewSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 176)
        Me.Controls.Add(Me.chk_revise)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_lastrevised)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_class)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_room)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_teacher)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_subject)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ViewSubjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Subject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_class As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_room As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_teacher As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_subject As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_lastrevised As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_revise As CheckBox
    Friend WithEvents Label6 As Label
End Class
