<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterSubjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterSubjects))
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_subject = New System.Windows.Forms.CheckBox()
        Me.chk_class = New System.Windows.Forms.CheckBox()
        Me.chk_room = New System.Windows.Forms.CheckBox()
        Me.chk_teacher = New System.Windows.Forms.CheckBox()
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.SubjectsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssistantDS = New Assistant.AssistantDS()
        Me.com_class = New System.Windows.Forms.ComboBox()
        Me.SubjectsTableBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.com_room = New System.Windows.Forms.ComboBox()
        Me.SubjectsTableBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.com_teacher = New System.Windows.Forms.ComboBox()
        Me.SubjectsTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubjectsTableTableAdapter = New Assistant.AssistantDSTableAdapters.SubjectsTableTableAdapter()
        Me.com_lastrevised = New System.Windows.Forms.ComboBox()
        Me.chk_lastrevised = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SubjectsTableBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SubjectsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsTableBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsTableBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsTableBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(16, 194)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(282, 31)
        Me.btn_cancel.TabIndex = 21
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_filter
        '
        Me.btn_filter.Image = CType(resources.GetObject("btn_filter.Image"), System.Drawing.Image)
        Me.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_filter.Location = New System.Drawing.Point(16, 157)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(282, 31)
        Me.btn_filter.TabIndex = 19
        Me.btn_filter.Text = "Filter Subjects"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Class:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Room:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Teacher:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Subject:"
        '
        'chk_subject
        '
        Me.chk_subject.AutoSize = True
        Me.chk_subject.Location = New System.Drawing.Point(16, 26)
        Me.chk_subject.Name = "chk_subject"
        Me.chk_subject.Size = New System.Drawing.Size(15, 14)
        Me.chk_subject.TabIndex = 22
        Me.chk_subject.UseVisualStyleBackColor = True
        '
        'chk_class
        '
        Me.chk_class.AutoSize = True
        Me.chk_class.Location = New System.Drawing.Point(16, 104)
        Me.chk_class.Name = "chk_class"
        Me.chk_class.Size = New System.Drawing.Size(15, 14)
        Me.chk_class.TabIndex = 23
        Me.chk_class.UseVisualStyleBackColor = True
        '
        'chk_room
        '
        Me.chk_room.AutoSize = True
        Me.chk_room.Location = New System.Drawing.Point(16, 78)
        Me.chk_room.Name = "chk_room"
        Me.chk_room.Size = New System.Drawing.Size(15, 14)
        Me.chk_room.TabIndex = 24
        Me.chk_room.UseVisualStyleBackColor = True
        '
        'chk_teacher
        '
        Me.chk_teacher.AutoSize = True
        Me.chk_teacher.Location = New System.Drawing.Point(16, 52)
        Me.chk_teacher.Name = "chk_teacher"
        Me.chk_teacher.Size = New System.Drawing.Size(15, 14)
        Me.chk_teacher.TabIndex = 25
        Me.chk_teacher.UseVisualStyleBackColor = True
        '
        'com_subject
        '
        Me.com_subject.DataSource = Me.SubjectsTableBindingSource
        Me.com_subject.DisplayMember = "Subject"
        Me.com_subject.Enabled = False
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(110, 22)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(188, 21)
        Me.com_subject.TabIndex = 26
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
        'com_class
        '
        Me.com_class.DataSource = Me.SubjectsTableBindingSource3
        Me.com_class.DisplayMember = "Class"
        Me.com_class.Enabled = False
        Me.com_class.FormattingEnabled = True
        Me.com_class.Location = New System.Drawing.Point(110, 101)
        Me.com_class.Name = "com_class"
        Me.com_class.Size = New System.Drawing.Size(188, 21)
        Me.com_class.TabIndex = 27
        Me.com_class.ValueMember = "Class"
        '
        'SubjectsTableBindingSource3
        '
        Me.SubjectsTableBindingSource3.DataMember = "SubjectsTable"
        Me.SubjectsTableBindingSource3.DataSource = Me.AssistantDS
        '
        'com_room
        '
        Me.com_room.DataSource = Me.SubjectsTableBindingSource2
        Me.com_room.DisplayMember = "Room"
        Me.com_room.Enabled = False
        Me.com_room.FormattingEnabled = True
        Me.com_room.Location = New System.Drawing.Point(110, 74)
        Me.com_room.Name = "com_room"
        Me.com_room.Size = New System.Drawing.Size(188, 21)
        Me.com_room.TabIndex = 28
        Me.com_room.ValueMember = "Room"
        '
        'SubjectsTableBindingSource2
        '
        Me.SubjectsTableBindingSource2.DataMember = "SubjectsTable"
        Me.SubjectsTableBindingSource2.DataSource = Me.AssistantDS
        '
        'com_teacher
        '
        Me.com_teacher.DataSource = Me.SubjectsTableBindingSource1
        Me.com_teacher.DisplayMember = "Teacher"
        Me.com_teacher.Enabled = False
        Me.com_teacher.FormattingEnabled = True
        Me.com_teacher.Location = New System.Drawing.Point(110, 48)
        Me.com_teacher.Name = "com_teacher"
        Me.com_teacher.Size = New System.Drawing.Size(188, 21)
        Me.com_teacher.TabIndex = 29
        Me.com_teacher.ValueMember = "Teacher"
        '
        'SubjectsTableBindingSource1
        '
        Me.SubjectsTableBindingSource1.DataMember = "SubjectsTable"
        Me.SubjectsTableBindingSource1.DataSource = Me.AssistantDS
        '
        'SubjectsTableTableAdapter
        '
        Me.SubjectsTableTableAdapter.ClearBeforeFill = True
        '
        'com_lastrevised
        '
        Me.com_lastrevised.DataSource = Me.SubjectsTableBindingSource4
        Me.com_lastrevised.DisplayMember = "Last Revised"
        Me.com_lastrevised.Enabled = False
        Me.com_lastrevised.FormattingEnabled = True
        Me.com_lastrevised.Location = New System.Drawing.Point(110, 128)
        Me.com_lastrevised.Name = "com_lastrevised"
        Me.com_lastrevised.Size = New System.Drawing.Size(188, 21)
        Me.com_lastrevised.TabIndex = 32
        Me.com_lastrevised.ValueMember = "Last Revised"
        '
        'chk_lastrevised
        '
        Me.chk_lastrevised.AutoSize = True
        Me.chk_lastrevised.Location = New System.Drawing.Point(16, 131)
        Me.chk_lastrevised.Name = "chk_lastrevised"
        Me.chk_lastrevised.Size = New System.Drawing.Size(15, 14)
        Me.chk_lastrevised.TabIndex = 31
        Me.chk_lastrevised.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Last Revised:"
        '
        'SubjectsTableBindingSource4
        '
        Me.SubjectsTableBindingSource4.DataMember = "SubjectsTable"
        Me.SubjectsTableBindingSource4.DataSource = Me.AssistantDS
        '
        'FilterSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 236)
        Me.Controls.Add(Me.com_lastrevised)
        Me.Controls.Add(Me.chk_lastrevised)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.com_teacher)
        Me.Controls.Add(Me.com_room)
        Me.Controls.Add(Me.com_class)
        Me.Controls.Add(Me.com_subject)
        Me.Controls.Add(Me.chk_teacher)
        Me.Controls.Add(Me.chk_room)
        Me.Controls.Add(Me.chk_class)
        Me.Controls.Add(Me.chk_subject)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FilterSubjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter Subjects"
        CType(Me.SubjectsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsTableBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsTableBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsTableBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_filter As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chk_subject As CheckBox
    Friend WithEvents chk_class As CheckBox
    Friend WithEvents chk_room As CheckBox
    Friend WithEvents chk_teacher As CheckBox
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents com_class As ComboBox
    Friend WithEvents com_room As ComboBox
    Friend WithEvents com_teacher As ComboBox
    Friend WithEvents AssistantDS As AssistantDS
    Friend WithEvents SubjectsTableBindingSource As BindingSource
    Friend WithEvents SubjectsTableTableAdapter As AssistantDSTableAdapters.SubjectsTableTableAdapter
    Friend WithEvents SubjectsTableBindingSource3 As BindingSource
    Friend WithEvents SubjectsTableBindingSource2 As BindingSource
    Friend WithEvents SubjectsTableBindingSource1 As BindingSource
    Friend WithEvents com_lastrevised As ComboBox
    Friend WithEvents SubjectsTableBindingSource4 As BindingSource
    Friend WithEvents chk_lastrevised As CheckBox
    Friend WithEvents Label5 As Label
End Class
