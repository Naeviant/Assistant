<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditResults
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditResults))
        Me.num_total = New System.Windows.Forms.NumericUpDown()
        Me.num_marks = New System.Windows.Forms.NumericUpDown()
        Me.txt_grade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_notes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.date_date = New System.Windows.Forms.DateTimePicker()
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.SubjectsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssistantDS = New Assistant.AssistantDS()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.SubjectsTableTableAdapter = New Assistant.AssistantDSTableAdapters.SubjectsTableTableAdapter()
        CType(Me.num_total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_marks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'num_total
        '
        Me.num_total.Location = New System.Drawing.Point(82, 95)
        Me.num_total.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num_total.Name = "num_total"
        Me.num_total.Size = New System.Drawing.Size(195, 20)
        Me.num_total.TabIndex = 87
        '
        'num_marks
        '
        Me.num_marks.Location = New System.Drawing.Point(82, 69)
        Me.num_marks.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.num_marks.Name = "num_marks"
        Me.num_marks.Size = New System.Drawing.Size(195, 20)
        Me.num_marks.TabIndex = 86
        '
        'txt_grade
        '
        Me.txt_grade.Location = New System.Drawing.Point(82, 121)
        Me.txt_grade.Name = "txt_grade"
        Me.txt_grade.Size = New System.Drawing.Size(195, 20)
        Me.txt_grade.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Grade:"
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
        'date_date
        '
        Me.date_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_date.Location = New System.Drawing.Point(82, 43)
        Me.date_date.Name = "date_date"
        Me.date_date.Size = New System.Drawing.Size(195, 20)
        Me.date_date.TabIndex = 81
        '
        'com_subject
        '
        Me.com_subject.DataSource = Me.SubjectsTableBindingSource
        Me.com_subject.DisplayMember = "Subject"
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(82, 16)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(195, 21)
        Me.com_subject.TabIndex = 80
        Me.com_subject.ValueMember = "Subject"
        '
        'SubjectsTableBindingSource
        '
        Me.SubjectsTableBindingSource.DataMember = "SubjectsTable"
        Me.SubjectsTableBindingSource.DataSource = Me.AssistantDS
        '
        'AssistantDS
        '
        Me.AssistantDS.DataSetName = "AssistantDS"
        Me.AssistantDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Total Marks:"
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(21, 230)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(536, 31)
        Me.btn_cancel.TabIndex = 78
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(21, 193)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(536, 31)
        Me.btn_clear.TabIndex = 77
        Me.btn_clear.Text = "Clear Fields"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.Location = New System.Drawing.Point(21, 156)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(536, 31)
        Me.btn_edit.TabIndex = 76
        Me.btn_edit.Text = "Edit Result"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Marks:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Day:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Subject:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(298, 127)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 88
        Me.lbl_id.Text = "ID"
        Me.lbl_id.Visible = False
        '
        'SubjectsTableTableAdapter
        '
        Me.SubjectsTableTableAdapter.ClearBeforeFill = True
        '
        'EditResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 276)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.num_total)
        Me.Controls.Add(Me.num_marks)
        Me.Controls.Add(Me.txt_grade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_notes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.date_date)
        Me.Controls.Add(Me.com_subject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Result"
        CType(Me.num_total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_marks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents num_total As NumericUpDown
    Friend WithEvents num_marks As NumericUpDown
    Friend WithEvents txt_grade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_notes As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents date_date As DateTimePicker
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents AssistantDS As AssistantDS
    Friend WithEvents SubjectsTableBindingSource As BindingSource
    Friend WithEvents SubjectsTableTableAdapter As AssistantDSTableAdapters.SubjectsTableTableAdapter
End Class
