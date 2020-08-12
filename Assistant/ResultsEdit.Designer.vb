<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResultsEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResultsEdit))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.com_type = New System.Windows.Forms.ComboBox()
        Me.num_score = New System.Windows.Forms.NumericUpDown()
        Me.num_maxscore = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.date_exam = New System.Windows.Forms.DateTimePicker()
        Me.date_grade = New System.Windows.Forms.DateTimePicker()
        Me.txt_grade = New System.Windows.Forms.TextBox()
        Me.chk_archive = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.ExamTypesTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.Exam_TypesTableAdapter()
        Me.SubjectsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.SubjectsTableAdapter()
        Me.ResultsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.ResultsTableAdapter()
        CType(Me.num_score, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_maxscore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Max Score: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Score:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Subject: "
        '
        'com_subject
        '
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(80, 9)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(121, 21)
        Me.com_subject.TabIndex = 8
        '
        'com_type
        '
        Me.com_type.FormattingEnabled = True
        Me.com_type.Location = New System.Drawing.Point(80, 31)
        Me.com_type.Name = "com_type"
        Me.com_type.Size = New System.Drawing.Size(121, 21)
        Me.com_type.TabIndex = 9
        '
        'num_score
        '
        Me.num_score.Location = New System.Drawing.Point(80, 53)
        Me.num_score.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num_score.Name = "num_score"
        Me.num_score.Size = New System.Drawing.Size(121, 20)
        Me.num_score.TabIndex = 10
        '
        'num_maxscore
        '
        Me.num_maxscore.Location = New System.Drawing.Point(80, 75)
        Me.num_maxscore.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num_maxscore.Name = "num_maxscore"
        Me.num_maxscore.Size = New System.Drawing.Size(121, 20)
        Me.num_maxscore.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(224, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Exam Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(224, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Grade Date: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(224, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Grade:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(224, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Archive:"
        '
        'date_exam
        '
        Me.date_exam.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_exam.Location = New System.Drawing.Point(296, 10)
        Me.date_exam.Name = "date_exam"
        Me.date_exam.Size = New System.Drawing.Size(122, 20)
        Me.date_exam.TabIndex = 16
        '
        'date_grade
        '
        Me.date_grade.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_grade.Location = New System.Drawing.Point(296, 31)
        Me.date_grade.Name = "date_grade"
        Me.date_grade.Size = New System.Drawing.Size(122, 20)
        Me.date_grade.TabIndex = 17
        '
        'txt_grade
        '
        Me.txt_grade.Location = New System.Drawing.Point(296, 53)
        Me.txt_grade.Name = "txt_grade"
        Me.txt_grade.Size = New System.Drawing.Size(122, 20)
        Me.txt_grade.TabIndex = 18
        '
        'chk_archive
        '
        Me.chk_archive.AutoSize = True
        Me.chk_archive.Location = New System.Drawing.Point(349, 77)
        Me.chk_archive.Name = "chk_archive"
        Me.chk_archive.Size = New System.Drawing.Size(15, 14)
        Me.chk_archive.TabIndex = 19
        Me.chk_archive.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(445, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Description:"
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(514, 9)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_description.Size = New System.Drawing.Size(121, 86)
        Me.txt_description.TabIndex = 21
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(12, 111)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(189, 23)
        Me.btn_close.TabIndex = 22
        Me.btn_close.Text = "Cancel"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(227, 111)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(191, 23)
        Me.btn_clear.TabIndex = 23
        Me.btn_clear.Text = "Reset Fields"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(448, 111)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(187, 23)
        Me.btn_save.TabIndex = 24
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(448, 81)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 25
        Me.lbl_id.Text = "ID"
        Me.lbl_id.Visible = False
        '
        'ExamTypesTableAdapter
        '
        Me.ExamTypesTableAdapter.ClearBeforeFill = True
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
        '
        'ResultsTableAdapter
        '
        Me.ResultsTableAdapter.ClearBeforeFill = True
        '
        'ResultsEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 150)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chk_archive)
        Me.Controls.Add(Me.txt_grade)
        Me.Controls.Add(Me.date_grade)
        Me.Controls.Add(Me.date_exam)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.num_maxscore)
        Me.Controls.Add(Me.num_score)
        Me.Controls.Add(Me.com_type)
        Me.Controls.Add(Me.com_subject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ResultsEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant: Results Details"
        CType(Me.num_score, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_maxscore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents com_type As ComboBox
    Friend WithEvents num_score As NumericUpDown
    Friend WithEvents num_maxscore As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents date_exam As DateTimePicker
    Friend WithEvents date_grade As DateTimePicker
    Friend WithEvents txt_grade As TextBox
    Friend WithEvents chk_archive As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_description As TextBox
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents ExamTypesTableAdapter As AssistantDBDataSetTableAdapters.Exam_TypesTableAdapter
    Friend WithEvents SubjectsTableAdapter As AssistantDBDataSetTableAdapters.SubjectsTableAdapter
    Friend WithEvents ResultsTableAdapter As AssistantDBDataSetTableAdapters.ResultsTableAdapter
End Class
