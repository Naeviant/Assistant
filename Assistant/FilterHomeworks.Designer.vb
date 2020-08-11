<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterHomeworks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterHomeworks))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.com_status = New System.Windows.Forms.ComboBox()
        Me.HomeworkTableBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssistantDS = New Assistant.AssistantDS()
        Me.com_priority = New System.Windows.Forms.ComboBox()
        Me.HomeworkTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.HomeworkTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.com_completion = New System.Windows.Forms.ComboBox()
        Me.HomeworkTableBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.com_setdate = New System.Windows.Forms.ComboBox()
        Me.HomeworkTableBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.com_duedate = New System.Windows.Forms.ComboBox()
        Me.HomeworkTableBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.com_setperiod = New System.Windows.Forms.ComboBox()
        Me.HomeworkTableBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.com_dueperiod = New System.Windows.Forms.ComboBox()
        Me.HomeworkTableBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.com_description = New System.Windows.Forms.ComboBox()
        Me.HomeworkTableBindingSource8 = New System.Windows.Forms.BindingSource(Me.components)
        Me.com_notes = New System.Windows.Forms.ComboBox()
        Me.HomeworkTableBindingSource9 = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_subject = New System.Windows.Forms.CheckBox()
        Me.chk_priority = New System.Windows.Forms.CheckBox()
        Me.chk_status = New System.Windows.Forms.CheckBox()
        Me.chk_completion = New System.Windows.Forms.CheckBox()
        Me.chk_setdate = New System.Windows.Forms.CheckBox()
        Me.chk_setperiod = New System.Windows.Forms.CheckBox()
        Me.chk_duedate = New System.Windows.Forms.CheckBox()
        Me.chk_dueperiod = New System.Windows.Forms.CheckBox()
        Me.chk_description = New System.Windows.Forms.CheckBox()
        Me.chk_notes = New System.Windows.Forms.CheckBox()
        Me.HomeworkTableTableAdapter = New Assistant.AssistantDSTableAdapters.HomeworkTableTableAdapter()
        CType(Me.HomeworkTableBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeworkTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeworkTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeworkTableBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeworkTableBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeworkTableBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeworkTableBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeworkTableBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeworkTableBindingSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeworkTableBindingSource9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'com_status
        '
        Me.com_status.DataSource = Me.HomeworkTableBindingSource2
        Me.com_status.DisplayMember = "Status"
        Me.com_status.Enabled = False
        Me.com_status.FormattingEnabled = True
        Me.com_status.Location = New System.Drawing.Point(106, 65)
        Me.com_status.Name = "com_status"
        Me.com_status.Size = New System.Drawing.Size(171, 21)
        Me.com_status.TabIndex = 78
        Me.com_status.ValueMember = "Status"
        '
        'HomeworkTableBindingSource2
        '
        Me.HomeworkTableBindingSource2.DataMember = "HomeworkTable"
        Me.HomeworkTableBindingSource2.DataSource = Me.AssistantDS
        '
        'AssistantDS
        '
        Me.AssistantDS.DataSetName = "AssistantDS"
        Me.AssistantDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'com_priority
        '
        Me.com_priority.DataSource = Me.HomeworkTableBindingSource1
        Me.com_priority.DisplayMember = "Priority"
        Me.com_priority.Enabled = False
        Me.com_priority.FormattingEnabled = True
        Me.com_priority.Location = New System.Drawing.Point(106, 39)
        Me.com_priority.Name = "com_priority"
        Me.com_priority.Size = New System.Drawing.Size(171, 21)
        Me.com_priority.TabIndex = 77
        Me.com_priority.ValueMember = "Priority"
        '
        'HomeworkTableBindingSource1
        '
        Me.HomeworkTableBindingSource1.DataMember = "HomeworkTable"
        Me.HomeworkTableBindingSource1.DataSource = Me.AssistantDS
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Completion:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(311, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Due Period:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(311, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Due Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(311, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Set Period:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(311, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Set Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(587, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Description:"
        '
        'com_subject
        '
        Me.com_subject.DataSource = Me.HomeworkTableBindingSource
        Me.com_subject.DisplayMember = "Subject"
        Me.com_subject.Enabled = False
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(106, 13)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(171, 21)
        Me.com_subject.TabIndex = 67
        Me.com_subject.ValueMember = "Subject"
        '
        'HomeworkTableBindingSource
        '
        Me.HomeworkTableBindingSource.DataMember = "HomeworkTable"
        Me.HomeworkTableBindingSource.DataSource = Me.AssistantDS
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(569, 123)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(281, 31)
        Me.btn_cancel.TabIndex = 63
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_filter
        '
        Me.btn_filter.Image = CType(resources.GetObject("btn_filter.Image"), System.Drawing.Image)
        Me.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_filter.Location = New System.Drawing.Point(21, 123)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(525, 31)
        Me.btn_filter.TabIndex = 61
        Me.btn_filter.Text = "Filter Homeworks"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Priority:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Subject:"
        '
        'com_completion
        '
        Me.com_completion.DataSource = Me.HomeworkTableBindingSource3
        Me.com_completion.DisplayMember = "Progress"
        Me.com_completion.Enabled = False
        Me.com_completion.FormattingEnabled = True
        Me.com_completion.Location = New System.Drawing.Point(106, 92)
        Me.com_completion.Name = "com_completion"
        Me.com_completion.Size = New System.Drawing.Size(154, 21)
        Me.com_completion.TabIndex = 85
        Me.com_completion.ValueMember = "Progress"
        '
        'HomeworkTableBindingSource3
        '
        Me.HomeworkTableBindingSource3.DataMember = "HomeworkTable"
        Me.HomeworkTableBindingSource3.DataSource = Me.AssistantDS
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(587, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Notes:"
        '
        'com_setdate
        '
        Me.com_setdate.DataSource = Me.HomeworkTableBindingSource4
        Me.com_setdate.DisplayMember = "Set Date"
        Me.com_setdate.Enabled = False
        Me.com_setdate.FormattingEnabled = True
        Me.com_setdate.Location = New System.Drawing.Point(376, 13)
        Me.com_setdate.Name = "com_setdate"
        Me.com_setdate.Size = New System.Drawing.Size(171, 21)
        Me.com_setdate.TabIndex = 88
        Me.com_setdate.ValueMember = "Set Date"
        '
        'HomeworkTableBindingSource4
        '
        Me.HomeworkTableBindingSource4.DataMember = "HomeworkTable"
        Me.HomeworkTableBindingSource4.DataSource = Me.AssistantDS
        '
        'com_duedate
        '
        Me.com_duedate.DataSource = Me.HomeworkTableBindingSource6
        Me.com_duedate.DisplayMember = "Due Date"
        Me.com_duedate.Enabled = False
        Me.com_duedate.FormattingEnabled = True
        Me.com_duedate.Location = New System.Drawing.Point(376, 65)
        Me.com_duedate.Name = "com_duedate"
        Me.com_duedate.Size = New System.Drawing.Size(171, 21)
        Me.com_duedate.TabIndex = 89
        Me.com_duedate.ValueMember = "Due Date"
        '
        'HomeworkTableBindingSource6
        '
        Me.HomeworkTableBindingSource6.DataMember = "HomeworkTable"
        Me.HomeworkTableBindingSource6.DataSource = Me.AssistantDS
        '
        'com_setperiod
        '
        Me.com_setperiod.DataSource = Me.HomeworkTableBindingSource5
        Me.com_setperiod.DisplayMember = "Set Period"
        Me.com_setperiod.Enabled = False
        Me.com_setperiod.FormattingEnabled = True
        Me.com_setperiod.Location = New System.Drawing.Point(376, 39)
        Me.com_setperiod.Name = "com_setperiod"
        Me.com_setperiod.Size = New System.Drawing.Size(171, 21)
        Me.com_setperiod.TabIndex = 90
        Me.com_setperiod.ValueMember = "Set Period"
        '
        'HomeworkTableBindingSource5
        '
        Me.HomeworkTableBindingSource5.DataMember = "HomeworkTable"
        Me.HomeworkTableBindingSource5.DataSource = Me.AssistantDS
        '
        'com_dueperiod
        '
        Me.com_dueperiod.DataSource = Me.HomeworkTableBindingSource7
        Me.com_dueperiod.DisplayMember = "Due Period"
        Me.com_dueperiod.Enabled = False
        Me.com_dueperiod.FormattingEnabled = True
        Me.com_dueperiod.Location = New System.Drawing.Point(376, 91)
        Me.com_dueperiod.Name = "com_dueperiod"
        Me.com_dueperiod.Size = New System.Drawing.Size(171, 21)
        Me.com_dueperiod.TabIndex = 91
        Me.com_dueperiod.ValueMember = "Due Period"
        '
        'HomeworkTableBindingSource7
        '
        Me.HomeworkTableBindingSource7.DataMember = "HomeworkTable"
        Me.HomeworkTableBindingSource7.DataSource = Me.AssistantDS
        '
        'com_description
        '
        Me.com_description.DataSource = Me.HomeworkTableBindingSource8
        Me.com_description.DisplayMember = "Description"
        Me.com_description.Enabled = False
        Me.com_description.FormattingEnabled = True
        Me.com_description.Location = New System.Drawing.Point(653, 13)
        Me.com_description.Name = "com_description"
        Me.com_description.Size = New System.Drawing.Size(197, 21)
        Me.com_description.TabIndex = 92
        Me.com_description.ValueMember = "Description"
        '
        'HomeworkTableBindingSource8
        '
        Me.HomeworkTableBindingSource8.DataMember = "HomeworkTable"
        Me.HomeworkTableBindingSource8.DataSource = Me.AssistantDS
        '
        'com_notes
        '
        Me.com_notes.DataSource = Me.HomeworkTableBindingSource9
        Me.com_notes.DisplayMember = "Notes"
        Me.com_notes.Enabled = False
        Me.com_notes.FormattingEnabled = True
        Me.com_notes.Location = New System.Drawing.Point(653, 39)
        Me.com_notes.Name = "com_notes"
        Me.com_notes.Size = New System.Drawing.Size(197, 21)
        Me.com_notes.TabIndex = 93
        Me.com_notes.ValueMember = "Notes"
        '
        'HomeworkTableBindingSource9
        '
        Me.HomeworkTableBindingSource9.DataMember = "HomeworkTable"
        Me.HomeworkTableBindingSource9.DataSource = Me.AssistantDS
        '
        'chk_subject
        '
        Me.chk_subject.AutoSize = True
        Me.chk_subject.Location = New System.Drawing.Point(21, 16)
        Me.chk_subject.Name = "chk_subject"
        Me.chk_subject.Size = New System.Drawing.Size(15, 14)
        Me.chk_subject.TabIndex = 94
        Me.chk_subject.UseVisualStyleBackColor = True
        '
        'chk_priority
        '
        Me.chk_priority.AutoSize = True
        Me.chk_priority.Location = New System.Drawing.Point(21, 42)
        Me.chk_priority.Name = "chk_priority"
        Me.chk_priority.Size = New System.Drawing.Size(15, 14)
        Me.chk_priority.TabIndex = 95
        Me.chk_priority.UseVisualStyleBackColor = True
        '
        'chk_status
        '
        Me.chk_status.AutoSize = True
        Me.chk_status.Location = New System.Drawing.Point(21, 68)
        Me.chk_status.Name = "chk_status"
        Me.chk_status.Size = New System.Drawing.Size(15, 14)
        Me.chk_status.TabIndex = 96
        Me.chk_status.UseVisualStyleBackColor = True
        '
        'chk_completion
        '
        Me.chk_completion.AutoSize = True
        Me.chk_completion.Location = New System.Drawing.Point(21, 95)
        Me.chk_completion.Name = "chk_completion"
        Me.chk_completion.Size = New System.Drawing.Size(15, 14)
        Me.chk_completion.TabIndex = 97
        Me.chk_completion.UseVisualStyleBackColor = True
        '
        'chk_setdate
        '
        Me.chk_setdate.AutoSize = True
        Me.chk_setdate.Location = New System.Drawing.Point(290, 16)
        Me.chk_setdate.Name = "chk_setdate"
        Me.chk_setdate.Size = New System.Drawing.Size(15, 14)
        Me.chk_setdate.TabIndex = 98
        Me.chk_setdate.UseVisualStyleBackColor = True
        '
        'chk_setperiod
        '
        Me.chk_setperiod.AutoSize = True
        Me.chk_setperiod.Location = New System.Drawing.Point(290, 42)
        Me.chk_setperiod.Name = "chk_setperiod"
        Me.chk_setperiod.Size = New System.Drawing.Size(15, 14)
        Me.chk_setperiod.TabIndex = 99
        Me.chk_setperiod.UseVisualStyleBackColor = True
        '
        'chk_duedate
        '
        Me.chk_duedate.AutoSize = True
        Me.chk_duedate.Location = New System.Drawing.Point(290, 68)
        Me.chk_duedate.Name = "chk_duedate"
        Me.chk_duedate.Size = New System.Drawing.Size(15, 14)
        Me.chk_duedate.TabIndex = 100
        Me.chk_duedate.UseVisualStyleBackColor = True
        '
        'chk_dueperiod
        '
        Me.chk_dueperiod.AutoSize = True
        Me.chk_dueperiod.Location = New System.Drawing.Point(290, 94)
        Me.chk_dueperiod.Name = "chk_dueperiod"
        Me.chk_dueperiod.Size = New System.Drawing.Size(15, 14)
        Me.chk_dueperiod.TabIndex = 101
        Me.chk_dueperiod.UseVisualStyleBackColor = True
        '
        'chk_description
        '
        Me.chk_description.AutoSize = True
        Me.chk_description.Location = New System.Drawing.Point(569, 16)
        Me.chk_description.Name = "chk_description"
        Me.chk_description.Size = New System.Drawing.Size(15, 14)
        Me.chk_description.TabIndex = 102
        Me.chk_description.UseVisualStyleBackColor = True
        '
        'chk_notes
        '
        Me.chk_notes.AutoSize = True
        Me.chk_notes.Location = New System.Drawing.Point(569, 42)
        Me.chk_notes.Name = "chk_notes"
        Me.chk_notes.Size = New System.Drawing.Size(15, 14)
        Me.chk_notes.TabIndex = 103
        Me.chk_notes.UseVisualStyleBackColor = True
        '
        'HomeworkTableTableAdapter
        '
        Me.HomeworkTableTableAdapter.ClearBeforeFill = True
        '
        'FilterHomeworks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 166)
        Me.Controls.Add(Me.chk_notes)
        Me.Controls.Add(Me.chk_description)
        Me.Controls.Add(Me.chk_dueperiod)
        Me.Controls.Add(Me.chk_duedate)
        Me.Controls.Add(Me.chk_setperiod)
        Me.Controls.Add(Me.chk_setdate)
        Me.Controls.Add(Me.chk_completion)
        Me.Controls.Add(Me.chk_status)
        Me.Controls.Add(Me.chk_priority)
        Me.Controls.Add(Me.chk_subject)
        Me.Controls.Add(Me.com_notes)
        Me.Controls.Add(Me.com_description)
        Me.Controls.Add(Me.com_dueperiod)
        Me.Controls.Add(Me.com_setperiod)
        Me.Controls.Add(Me.com_duedate)
        Me.Controls.Add(Me.com_setdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.com_completion)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.com_status)
        Me.Controls.Add(Me.com_priority)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.com_subject)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FilterHomeworks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter Homeworks"
        CType(Me.HomeworkTableBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeworkTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeworkTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeworkTableBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeworkTableBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeworkTableBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeworkTableBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeworkTableBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeworkTableBindingSource8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeworkTableBindingSource9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As Label
    Friend WithEvents com_status As ComboBox
    Friend WithEvents com_priority As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_filter As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents com_completion As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents com_setdate As ComboBox
    Friend WithEvents com_duedate As ComboBox
    Friend WithEvents com_setperiod As ComboBox
    Friend WithEvents com_dueperiod As ComboBox
    Friend WithEvents com_description As ComboBox
    Friend WithEvents com_notes As ComboBox
    Friend WithEvents chk_subject As CheckBox
    Friend WithEvents chk_priority As CheckBox
    Friend WithEvents chk_status As CheckBox
    Friend WithEvents chk_completion As CheckBox
    Friend WithEvents chk_setdate As CheckBox
    Friend WithEvents chk_setperiod As CheckBox
    Friend WithEvents chk_duedate As CheckBox
    Friend WithEvents chk_dueperiod As CheckBox
    Friend WithEvents chk_description As CheckBox
    Friend WithEvents chk_notes As CheckBox
    Friend WithEvents AssistantDS As AssistantDS
    Friend WithEvents HomeworkTableBindingSource As BindingSource
    Friend WithEvents HomeworkTableTableAdapter As AssistantDSTableAdapters.HomeworkTableTableAdapter
    Friend WithEvents HomeworkTableBindingSource2 As BindingSource
    Friend WithEvents HomeworkTableBindingSource1 As BindingSource
    Friend WithEvents HomeworkTableBindingSource3 As BindingSource
    Friend WithEvents HomeworkTableBindingSource4 As BindingSource
    Friend WithEvents HomeworkTableBindingSource6 As BindingSource
    Friend WithEvents HomeworkTableBindingSource5 As BindingSource
    Friend WithEvents HomeworkTableBindingSource7 As BindingSource
    Friend WithEvents HomeworkTableBindingSource8 As BindingSource
    Friend WithEvents HomeworkTableBindingSource9 As BindingSource
End Class
