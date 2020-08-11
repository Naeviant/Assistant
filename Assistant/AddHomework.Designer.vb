<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddHomework
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddHomework))
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.SubjectsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssistantDS = New Assistant.AssistantDS()
        Me.txt_notes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_project = New System.Windows.Forms.CheckBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_due = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_set = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.com_priority = New System.Windows.Forms.ComboBox()
        Me.com_status = New System.Windows.Forms.ComboBox()
        Me.num_completion = New System.Windows.Forms.NumericUpDown()
        Me.date_set = New System.Windows.Forms.DateTimePicker()
        Me.date_due = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chk_due = New System.Windows.Forms.CheckBox()
        Me.chk_set = New System.Windows.Forms.CheckBox()
        Me.SubjectsTableTableAdapter1 = New Assistant.AssistantDSTableAdapters.SubjectsTableTableAdapter()
        CType(Me.SubjectsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_completion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'com_subject
        '
        Me.com_subject.DataSource = Me.SubjectsTableBindingSource
        Me.com_subject.DisplayMember = "Subject"
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(85, 16)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(192, 21)
        Me.com_subject.TabIndex = 38
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
        Me.txt_notes.Location = New System.Drawing.Point(902, 16)
        Me.txt_notes.Multiline = True
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_notes.Size = New System.Drawing.Size(215, 94)
        Me.txt_notes.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(858, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Notes:"
        '
        'chk_project
        '
        Me.chk_project.AutoSize = True
        Me.chk_project.Location = New System.Drawing.Point(735, 97)
        Me.chk_project.Name = "chk_project"
        Me.chk_project.Size = New System.Drawing.Size(15, 14)
        Me.chk_project.TabIndex = 35
        Me.chk_project.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(861, 126)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(256, 31)
        Me.btn_cancel.TabIndex = 34
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(569, 126)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(281, 31)
        Me.btn_clear.TabIndex = 33
        Me.btn_clear.Text = "Clear Fields"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(21, 126)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(525, 31)
        Me.btn_add.TabIndex = 32
        Me.btn_add.Text = "Add Homework"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(586, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Project:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Priority:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Subject:"
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(635, 16)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_description.Size = New System.Drawing.Size(215, 72)
        Me.txt_description.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(566, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Description:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(287, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Due Period:"
        '
        'txt_due
        '
        Me.txt_due.Location = New System.Drawing.Point(354, 94)
        Me.txt_due.Name = "txt_due"
        Me.txt_due.Size = New System.Drawing.Size(192, 20)
        Me.txt_due.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(287, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Due Date:"
        '
        'txt_set
        '
        Me.txt_set.Location = New System.Drawing.Point(354, 42)
        Me.txt_set.Name = "txt_set"
        Me.txt_set.Size = New System.Drawing.Size(192, 20)
        Me.txt_set.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(287, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Set Period:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(287, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Set Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Completion:"
        '
        'com_priority
        '
        Me.com_priority.FormattingEnabled = True
        Me.com_priority.Items.AddRange(New Object() {"Urgent", "High", "Normal", "Low", "Optional"})
        Me.com_priority.Location = New System.Drawing.Point(85, 42)
        Me.com_priority.Name = "com_priority"
        Me.com_priority.Size = New System.Drawing.Size(192, 21)
        Me.com_priority.TabIndex = 49
        '
        'com_status
        '
        Me.com_status.FormattingEnabled = True
        Me.com_status.Items.AddRange(New Object() {"Handed In", "Completed", "In Progress", "On Hold", "Not Started"})
        Me.com_status.Location = New System.Drawing.Point(85, 68)
        Me.com_status.Name = "com_status"
        Me.com_status.Size = New System.Drawing.Size(192, 21)
        Me.com_status.TabIndex = 50
        '
        'num_completion
        '
        Me.num_completion.Location = New System.Drawing.Point(85, 95)
        Me.num_completion.Name = "num_completion"
        Me.num_completion.Size = New System.Drawing.Size(179, 20)
        Me.num_completion.TabIndex = 51
        '
        'date_set
        '
        Me.date_set.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_set.Location = New System.Drawing.Point(377, 16)
        Me.date_set.Name = "date_set"
        Me.date_set.Size = New System.Drawing.Size(169, 20)
        Me.date_set.TabIndex = 52
        '
        'date_due
        '
        Me.date_due.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_due.Location = New System.Drawing.Point(377, 68)
        Me.date_due.Name = "date_due"
        Me.date_due.Size = New System.Drawing.Size(169, 20)
        Me.date_due.TabIndex = 53
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(266, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 13)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "%"
        '
        'chk_due
        '
        Me.chk_due.AutoSize = True
        Me.chk_due.Checked = True
        Me.chk_due.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_due.Location = New System.Drawing.Point(354, 72)
        Me.chk_due.Name = "chk_due"
        Me.chk_due.Size = New System.Drawing.Size(15, 14)
        Me.chk_due.TabIndex = 55
        Me.chk_due.UseVisualStyleBackColor = True
        '
        'chk_set
        '
        Me.chk_set.AutoSize = True
        Me.chk_set.Checked = True
        Me.chk_set.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_set.Location = New System.Drawing.Point(354, 19)
        Me.chk_set.Name = "chk_set"
        Me.chk_set.Size = New System.Drawing.Size(15, 14)
        Me.chk_set.TabIndex = 56
        Me.chk_set.UseVisualStyleBackColor = True
        '
        'SubjectsTableTableAdapter1
        '
        Me.SubjectsTableTableAdapter1.ClearBeforeFill = True
        '
        'AddHomework
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 166)
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
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AddHomework"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Homework"
        CType(Me.SubjectsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_completion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents com_subject As ComboBox
    Friend WithEvents txt_notes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_project As CheckBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_description As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_due As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_set As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents com_priority As ComboBox
    Friend WithEvents com_status As ComboBox
    Friend WithEvents num_completion As NumericUpDown
    Friend WithEvents date_set As DateTimePicker
    Friend WithEvents date_due As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents chk_due As CheckBox
    Friend WithEvents chk_set As CheckBox
    Friend WithEvents SubjectsTableTableAdapter As AssistantDSTableAdapters.SubjectsTableTableAdapter
    Friend WithEvents AssistantDS As AssistantDS
    Friend WithEvents SubjectsTableBindingSource As BindingSource
    Friend WithEvents SubjectsTableTableAdapter1 As AssistantDSTableAdapters.SubjectsTableTableAdapter
End Class
