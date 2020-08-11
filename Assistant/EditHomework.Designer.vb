<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditHomework
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditHomework))
        Me.chk_set = New System.Windows.Forms.CheckBox()
        Me.chk_due = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.date_due = New System.Windows.Forms.DateTimePicker()
        Me.date_set = New System.Windows.Forms.DateTimePicker()
        Me.num_completion = New System.Windows.Forms.NumericUpDown()
        Me.com_status = New System.Windows.Forms.ComboBox()
        Me.com_priority = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_due = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_set = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.SubjectsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssistantDS = New Assistant.AssistantDS()
        Me.txt_notes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_project = New System.Windows.Forms.CheckBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.SubjectsTableTableAdapter = New Assistant.AssistantDSTableAdapters.SubjectsTableTableAdapter()
        CType(Me.num_completion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_set
        '
        Me.chk_set.AutoSize = True
        Me.chk_set.Location = New System.Drawing.Point(354, 16)
        Me.chk_set.Name = "chk_set"
        Me.chk_set.Size = New System.Drawing.Size(15, 14)
        Me.chk_set.TabIndex = 84
        Me.chk_set.UseVisualStyleBackColor = True
        '
        'chk_due
        '
        Me.chk_due.AutoSize = True
        Me.chk_due.Location = New System.Drawing.Point(354, 69)
        Me.chk_due.Name = "chk_due"
        Me.chk_due.Size = New System.Drawing.Size(15, 14)
        Me.chk_due.TabIndex = 83
        Me.chk_due.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(266, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 13)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "%"
        '
        'date_due
        '
        Me.date_due.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_due.Location = New System.Drawing.Point(377, 65)
        Me.date_due.Name = "date_due"
        Me.date_due.Size = New System.Drawing.Size(169, 20)
        Me.date_due.TabIndex = 81
        '
        'date_set
        '
        Me.date_set.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_set.Location = New System.Drawing.Point(377, 13)
        Me.date_set.Name = "date_set"
        Me.date_set.Size = New System.Drawing.Size(169, 20)
        Me.date_set.TabIndex = 80
        '
        'num_completion
        '
        Me.num_completion.Location = New System.Drawing.Point(85, 92)
        Me.num_completion.Name = "num_completion"
        Me.num_completion.Size = New System.Drawing.Size(179, 20)
        Me.num_completion.TabIndex = 79
        '
        'com_status
        '
        Me.com_status.FormattingEnabled = True
        Me.com_status.Items.AddRange(New Object() {"Handed In", "Completed", "In Progress", "On Hold", "Not Started"})
        Me.com_status.Location = New System.Drawing.Point(85, 65)
        Me.com_status.Name = "com_status"
        Me.com_status.Size = New System.Drawing.Size(192, 21)
        Me.com_status.TabIndex = 78
        '
        'com_priority
        '
        Me.com_priority.FormattingEnabled = True
        Me.com_priority.Items.AddRange(New Object() {"Urgent", "High", "Normal", "Low", "Optional"})
        Me.com_priority.Location = New System.Drawing.Point(85, 39)
        Me.com_priority.Name = "com_priority"
        Me.com_priority.Size = New System.Drawing.Size(192, 21)
        Me.com_priority.TabIndex = 77
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Completion:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(287, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Due Period:"
        '
        'txt_due
        '
        Me.txt_due.Location = New System.Drawing.Point(354, 91)
        Me.txt_due.Name = "txt_due"
        Me.txt_due.Size = New System.Drawing.Size(192, 20)
        Me.txt_due.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(287, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Due Date:"
        '
        'txt_set
        '
        Me.txt_set.Location = New System.Drawing.Point(354, 39)
        Me.txt_set.Name = "txt_set"
        Me.txt_set.Size = New System.Drawing.Size(192, 20)
        Me.txt_set.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(287, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Set Period:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(287, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Set Date:"
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(635, 13)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_description.Size = New System.Drawing.Size(215, 72)
        Me.txt_description.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(566, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Description:"
        '
        'com_subject
        '
        Me.com_subject.DataSource = Me.SubjectsTableBindingSource
        Me.com_subject.DisplayMember = "Subject"
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(85, 13)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(192, 21)
        Me.com_subject.TabIndex = 67
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
        'txt_notes
        '
        Me.txt_notes.Location = New System.Drawing.Point(902, 13)
        Me.txt_notes.Multiline = True
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_notes.Size = New System.Drawing.Size(215, 94)
        Me.txt_notes.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(858, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Notes:"
        '
        'chk_project
        '
        Me.chk_project.AutoSize = True
        Me.chk_project.Location = New System.Drawing.Point(735, 94)
        Me.chk_project.Name = "chk_project"
        Me.chk_project.Size = New System.Drawing.Size(15, 14)
        Me.chk_project.TabIndex = 64
        Me.chk_project.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(861, 123)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(256, 31)
        Me.btn_cancel.TabIndex = 63
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(569, 123)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(281, 31)
        Me.btn_clear.TabIndex = 62
        Me.btn_clear.Text = "Clear Fields"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.Location = New System.Drawing.Point(21, 123)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(525, 31)
        Me.btn_edit.TabIndex = 61
        Me.btn_edit.Text = "Edit Homework"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(586, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Project:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Priority:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Subject:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(832, 95)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 85
        Me.lbl_id.Text = "ID"
        Me.lbl_id.Visible = False
        '
        'SubjectsTableTableAdapter
        '
        Me.SubjectsTableTableAdapter.ClearBeforeFill = True
        '
        'EditHomework
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 166)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.chk_set)
        Me.Controls.Add(Me.chk_due)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.date_due)
        Me.Controls.Add(Me.date_set)
        Me.Controls.Add(Me.num_completion)
        Me.Controls.Add(Me.com_status)
        Me.Controls.Add(Me.com_priority)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_due)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_set)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.com_subject)
        Me.Controls.Add(Me.txt_notes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chk_project)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EditHomework"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Homework"
        CType(Me.num_completion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk_set As CheckBox
    Friend WithEvents chk_due As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents date_due As DateTimePicker
    Friend WithEvents date_set As DateTimePicker
    Friend WithEvents num_completion As NumericUpDown
    Friend WithEvents com_status As ComboBox
    Friend WithEvents com_priority As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_due As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_set As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_description As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents txt_notes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_project As CheckBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents AssistantDS As AssistantDS
    Friend WithEvents SubjectsTableBindingSource As BindingSource
    Friend WithEvents SubjectsTableTableAdapter As AssistantDSTableAdapters.SubjectsTableTableAdapter
End Class
