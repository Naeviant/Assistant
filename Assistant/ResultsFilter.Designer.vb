<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResultsFilter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResultsFilter))
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.txt_grade = New System.Windows.Forms.TextBox()
        Me.date_grade = New System.Windows.Forms.DateTimePicker()
        Me.date_exam = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.com_type = New System.Windows.Forms.ComboBox()
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SubjectsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.SubjectsTableAdapter()
        Me.ExamTypesTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.Exam_TypesTableAdapter()
        Me.ResultsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.ResultsTableAdapter()
        Me.SuspendLayout()
        '
        'btn_filter
        '
        Me.btn_filter.Location = New System.Drawing.Point(20, 156)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(221, 23)
        Me.btn_filter.TabIndex = 46
        Me.btn_filter.Text = "Filter"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(20, 127)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(221, 23)
        Me.btn_close.TabIndex = 44
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'txt_grade
        '
        Me.txt_grade.Location = New System.Drawing.Point(89, 101)
        Me.txt_grade.Name = "txt_grade"
        Me.txt_grade.Size = New System.Drawing.Size(152, 20)
        Me.txt_grade.TabIndex = 40
        '
        'date_grade
        '
        Me.date_grade.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_grade.Location = New System.Drawing.Point(89, 79)
        Me.date_grade.Name = "date_grade"
        Me.date_grade.ShowCheckBox = True
        Me.date_grade.Size = New System.Drawing.Size(152, 20)
        Me.date_grade.TabIndex = 39
        '
        'date_exam
        '
        Me.date_exam.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_exam.Location = New System.Drawing.Point(89, 58)
        Me.date_exam.Name = "date_exam"
        Me.date_exam.ShowCheckBox = True
        Me.date_exam.Size = New System.Drawing.Size(152, 20)
        Me.date_exam.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Grade:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Grade Date: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Exam Date:"
        '
        'com_type
        '
        Me.com_type.FormattingEnabled = True
        Me.com_type.Location = New System.Drawing.Point(89, 36)
        Me.com_type.Name = "com_type"
        Me.com_type.Size = New System.Drawing.Size(152, 21)
        Me.com_type.TabIndex = 31
        '
        'com_subject
        '
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(89, 14)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(152, 21)
        Me.com_subject.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Subject: "
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
        '
        'ExamTypesTableAdapter
        '
        Me.ExamTypesTableAdapter.ClearBeforeFill = True
        '
        'ResultsTableAdapter
        '
        Me.ResultsTableAdapter.ClearBeforeFill = True
        '
        'ResultsFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 190)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.txt_grade)
        Me.Controls.Add(Me.date_grade)
        Me.Controls.Add(Me.date_exam)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.com_type)
        Me.Controls.Add(Me.com_subject)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ResultsFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant: Filter Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_filter As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents txt_grade As TextBox
    Friend WithEvents date_grade As DateTimePicker
    Friend WithEvents date_exam As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents com_type As ComboBox
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SubjectsTableAdapter As AssistantDBDataSetTableAdapters.SubjectsTableAdapter
    Friend WithEvents ExamTypesTableAdapter As AssistantDBDataSetTableAdapters.Exam_TypesTableAdapter
    Friend WithEvents ResultsTableAdapter As AssistantDBDataSetTableAdapters.ResultsTableAdapter
End Class
