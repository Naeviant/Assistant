<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSubjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditSubjects))
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.txt_class = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_room = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_teacher = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_subject = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_lastrevised = New System.Windows.Forms.Label()
        Me.chk_revise = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(16, 225)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(256, 31)
        Me.btn_cancel.TabIndex = 21
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(16, 188)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(256, 31)
        Me.btn_clear.TabIndex = 20
        Me.btn_clear.Text = "Clear Fields"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.Location = New System.Drawing.Point(16, 151)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(256, 31)
        Me.btn_edit.TabIndex = 19
        Me.btn_edit.Text = "Edit Subject"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'txt_class
        '
        Me.txt_class.Location = New System.Drawing.Point(65, 101)
        Me.txt_class.Name = "txt_class"
        Me.txt_class.Size = New System.Drawing.Size(207, 20)
        Me.txt_class.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Class:"
        '
        'txt_room
        '
        Me.txt_room.Location = New System.Drawing.Point(65, 75)
        Me.txt_room.Name = "txt_room"
        Me.txt_room.Size = New System.Drawing.Size(207, 20)
        Me.txt_room.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Room:"
        '
        'txt_teacher
        '
        Me.txt_teacher.Location = New System.Drawing.Point(65, 49)
        Me.txt_teacher.Name = "txt_teacher"
        Me.txt_teacher.Size = New System.Drawing.Size(207, 20)
        Me.txt_teacher.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Teacher:"
        '
        'txt_subject
        '
        Me.txt_subject.Location = New System.Drawing.Point(65, 23)
        Me.txt_subject.Name = "txt_subject"
        Me.txt_subject.Size = New System.Drawing.Size(207, 20)
        Me.txt_subject.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Subject:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(62, 7)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 22
        Me.lbl_id.Text = "ID"
        Me.lbl_id.Visible = False
        '
        'lbl_lastrevised
        '
        Me.lbl_lastrevised.AutoSize = True
        Me.lbl_lastrevised.Location = New System.Drawing.Point(203, 7)
        Me.lbl_lastrevised.Name = "lbl_lastrevised"
        Me.lbl_lastrevised.Size = New System.Drawing.Size(69, 13)
        Me.lbl_lastrevised.TabIndex = 23
        Me.lbl_lastrevised.Text = "Last Revised"
        Me.lbl_lastrevised.Visible = False
        '
        'chk_revise
        '
        Me.chk_revise.AutoSize = True
        Me.chk_revise.Location = New System.Drawing.Point(161, 129)
        Me.chk_revise.Name = "chk_revise"
        Me.chk_revise.Size = New System.Drawing.Size(15, 14)
        Me.chk_revise.TabIndex = 25
        Me.chk_revise.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Revise:"
        '
        'EditSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 266)
        Me.Controls.Add(Me.chk_revise)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_lastrevised)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_edit)
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
        Me.Name = "EditSubjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Subject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents txt_class As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_room As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_teacher As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_subject As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_lastrevised As Label
    Friend WithEvents chk_revise As CheckBox
    Friend WithEvents Label5 As Label
End Class
