<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignmentsEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssignmentsEdit))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.SubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssistantDBDataSet = New Assistant.AssistantDBDataSet()
        Me.SubjectsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.SubjectsTableAdapter()
        Me.com_priority = New System.Windows.Forms.ComboBox()
        Me.num_progress = New System.Windows.Forms.NumericUpDown()
        Me.com_status = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.date_start = New System.Windows.Forms.DateTimePicker()
        Me.date_due = New System.Windows.Forms.DateTimePicker()
        Me.time_due = New System.Windows.Forms.DateTimePicker()
        Me.chk_archive = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.AssignmentsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.AssignmentsTableAdapter()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistantDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_progress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subject: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Priority:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Progress:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status: "
        '
        'com_subject
        '
        Me.com_subject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_subject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(68, 10)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(121, 21)
        Me.com_subject.TabIndex = 4
        '
        'SubjectsBindingSource
        '
        Me.SubjectsBindingSource.DataMember = "Subjects"
        Me.SubjectsBindingSource.DataSource = Me.AssistantDBDataSet
        '
        'AssistantDBDataSet
        '
        Me.AssistantDBDataSet.DataSetName = "AssistantDBDataSet"
        Me.AssistantDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
        '
        'com_priority
        '
        Me.com_priority.AutoCompleteCustomSource.AddRange(New String() {"High", "Normal", "Low"})
        Me.com_priority.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_priority.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.com_priority.FormattingEnabled = True
        Me.com_priority.Items.AddRange(New Object() {"High", "Normal", "Low"})
        Me.com_priority.Location = New System.Drawing.Point(68, 32)
        Me.com_priority.Name = "com_priority"
        Me.com_priority.Size = New System.Drawing.Size(121, 21)
        Me.com_priority.TabIndex = 5
        '
        'num_progress
        '
        Me.num_progress.Location = New System.Drawing.Point(68, 56)
        Me.num_progress.Name = "num_progress"
        Me.num_progress.Size = New System.Drawing.Size(108, 20)
        Me.num_progress.TabIndex = 6
        Me.num_progress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num_progress.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'com_status
        '
        Me.com_status.AutoCompleteCustomSource.AddRange(New String() {"Not Started", "In Progress", "On Hold", "Completed"})
        Me.com_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.com_status.FormattingEnabled = True
        Me.com_status.Items.AddRange(New Object() {"Not Started", "In Progress", "On Hold", "Completed"})
        Me.com_status.Location = New System.Drawing.Point(68, 80)
        Me.com_status.Name = "com_status"
        Me.com_status.Size = New System.Drawing.Size(121, 21)
        Me.com_status.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(210, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Set Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(210, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Due Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(210, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Due Time:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(210, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Archive:"
        '
        'date_start
        '
        Me.date_start.CustomFormat = "ddd dd/MM/yyyy"
        Me.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_start.Location = New System.Drawing.Point(274, 10)
        Me.date_start.Name = "date_start"
        Me.date_start.Size = New System.Drawing.Size(122, 20)
        Me.date_start.TabIndex = 12
        '
        'date_due
        '
        Me.date_due.CustomFormat = "ddd dd/MM/yyyy"
        Me.date_due.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_due.Location = New System.Drawing.Point(274, 32)
        Me.date_due.Name = "date_due"
        Me.date_due.Size = New System.Drawing.Size(122, 20)
        Me.date_due.TabIndex = 13
        '
        'time_due
        '
        Me.time_due.CustomFormat = "HH:mm"
        Me.time_due.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.time_due.Location = New System.Drawing.Point(274, 56)
        Me.time_due.Name = "time_due"
        Me.time_due.ShowUpDown = True
        Me.time_due.Size = New System.Drawing.Size(122, 20)
        Me.time_due.TabIndex = 14
        '
        'chk_archive
        '
        Me.chk_archive.AutoSize = True
        Me.chk_archive.Location = New System.Drawing.Point(324, 83)
        Me.chk_archive.Name = "chk_archive"
        Me.chk_archive.Size = New System.Drawing.Size(15, 14)
        Me.chk_archive.TabIndex = 15
        Me.chk_archive.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(421, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Description:"
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(490, 10)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_description.Size = New System.Drawing.Size(122, 91)
        Me.txt_description.TabIndex = 17
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(16, 119)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(172, 23)
        Me.btn_close.TabIndex = 18
        Me.btn_close.Text = "Cancel"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(213, 119)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(183, 23)
        Me.btn_clear.TabIndex = 19
        Me.btn_clear.Text = "Reset Fields"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(424, 119)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(188, 23)
        Me.btn_save.TabIndex = 20
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(177, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "%"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(424, 87)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 22
        Me.lbl_id.Text = "ID"
        Me.lbl_id.Visible = False
        '
        'AssignmentsTableAdapter
        '
        Me.AssignmentsTableAdapter.ClearBeforeFill = True
        '
        'AssignmentsEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 159)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chk_archive)
        Me.Controls.Add(Me.time_due)
        Me.Controls.Add(Me.date_due)
        Me.Controls.Add(Me.date_start)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.com_status)
        Me.Controls.Add(Me.num_progress)
        Me.Controls.Add(Me.com_priority)
        Me.Controls.Add(Me.com_subject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AssignmentsEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant: Assignment Details"
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistantDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_progress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents AssistantDBDataSet As AssistantDBDataSet
    Friend WithEvents SubjectsBindingSource As BindingSource
    Friend WithEvents SubjectsTableAdapter As AssistantDBDataSetTableAdapters.SubjectsTableAdapter
    Friend WithEvents com_priority As ComboBox
    Friend WithEvents num_progress As NumericUpDown
    Friend WithEvents com_status As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents date_start As DateTimePicker
    Friend WithEvents date_due As DateTimePicker
    Friend WithEvents time_due As DateTimePicker
    Friend WithEvents chk_archive As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_description As TextBox
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents AssignmentsTableAdapter As AssistantDBDataSetTableAdapters.AssignmentsTableAdapter
End Class
