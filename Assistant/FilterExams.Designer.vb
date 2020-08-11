<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterExams
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterExams))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.com_location = New System.Windows.Forms.ComboBox()
        Me.com_date = New System.Windows.Forms.ComboBox()
        Me.com_starttime = New System.Windows.Forms.ComboBox()
        Me.com_endtime = New System.Windows.Forms.ComboBox()
        Me.com_notes = New System.Windows.Forms.ComboBox()
        Me.chk_subject = New System.Windows.Forms.CheckBox()
        Me.chk_notes = New System.Windows.Forms.CheckBox()
        Me.chk_endtime = New System.Windows.Forms.CheckBox()
        Me.chk_starttime = New System.Windows.Forms.CheckBox()
        Me.chk_date = New System.Windows.Forms.CheckBox()
        Me.chk_location = New System.Windows.Forms.CheckBox()
        Me.AssistantDS = New Assistant.AssistantDS()
        Me.ExamsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsTableTableAdapter = New Assistant.AssistantDSTableAdapters.ExamsTableTableAdapter()
        Me.ExamsTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsTableBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsTableBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsTableBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsTableBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsTableBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsTableBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsTableBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsTableBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(318, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Notes:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(318, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "End Time:"
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(21, 142)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(536, 31)
        Me.btn_cancel.TabIndex = 60
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_filter
        '
        Me.btn_filter.Image = CType(resources.GetObject("btn_filter.Image"), System.Drawing.Image)
        Me.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_filter.Location = New System.Drawing.Point(21, 105)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(536, 31)
        Me.btn_filter.TabIndex = 58
        Me.btn_filter.Text = "Filter Exams"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(318, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Start Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Day:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Location:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Subject:"
        '
        'com_subject
        '
        Me.com_subject.DataSource = Me.ExamsTableBindingSource
        Me.com_subject.DisplayMember = "Subject"
        Me.com_subject.Enabled = False
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(97, 16)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(180, 21)
        Me.com_subject.TabIndex = 62
        Me.com_subject.ValueMember = "Subject"
        '
        'com_location
        '
        Me.com_location.DataSource = Me.ExamsTableBindingSource1
        Me.com_location.DisplayMember = "Location"
        Me.com_location.Enabled = False
        Me.com_location.FormattingEnabled = True
        Me.com_location.Location = New System.Drawing.Point(97, 42)
        Me.com_location.Name = "com_location"
        Me.com_location.Size = New System.Drawing.Size(180, 21)
        Me.com_location.TabIndex = 68
        Me.com_location.ValueMember = "Location"
        '
        'com_date
        '
        Me.com_date.DataSource = Me.ExamsTableBindingSource2
        Me.com_date.DisplayMember = "Day"
        Me.com_date.Enabled = False
        Me.com_date.FormattingEnabled = True
        Me.com_date.Location = New System.Drawing.Point(97, 68)
        Me.com_date.Name = "com_date"
        Me.com_date.Size = New System.Drawing.Size(180, 21)
        Me.com_date.TabIndex = 69
        Me.com_date.ValueMember = "Day"
        '
        'com_starttime
        '
        Me.com_starttime.DataSource = Me.ExamsTableBindingSource3
        Me.com_starttime.DisplayMember = "Start Time"
        Me.com_starttime.Enabled = False
        Me.com_starttime.FormattingEnabled = True
        Me.com_starttime.Location = New System.Drawing.Point(377, 16)
        Me.com_starttime.Name = "com_starttime"
        Me.com_starttime.Size = New System.Drawing.Size(180, 21)
        Me.com_starttime.TabIndex = 70
        Me.com_starttime.ValueMember = "Start Time"
        '
        'com_endtime
        '
        Me.com_endtime.DataSource = Me.ExamsTableBindingSource4
        Me.com_endtime.DisplayMember = "End Time"
        Me.com_endtime.Enabled = False
        Me.com_endtime.FormattingEnabled = True
        Me.com_endtime.Location = New System.Drawing.Point(377, 42)
        Me.com_endtime.Name = "com_endtime"
        Me.com_endtime.Size = New System.Drawing.Size(180, 21)
        Me.com_endtime.TabIndex = 71
        Me.com_endtime.ValueMember = "End Time"
        '
        'com_notes
        '
        Me.com_notes.DataSource = Me.ExamsTableBindingSource5
        Me.com_notes.DisplayMember = "Notes"
        Me.com_notes.Enabled = False
        Me.com_notes.FormattingEnabled = True
        Me.com_notes.Location = New System.Drawing.Point(377, 68)
        Me.com_notes.Name = "com_notes"
        Me.com_notes.Size = New System.Drawing.Size(180, 21)
        Me.com_notes.TabIndex = 72
        Me.com_notes.ValueMember = "Notes"
        '
        'chk_subject
        '
        Me.chk_subject.AutoSize = True
        Me.chk_subject.Location = New System.Drawing.Point(21, 18)
        Me.chk_subject.Name = "chk_subject"
        Me.chk_subject.Size = New System.Drawing.Size(15, 14)
        Me.chk_subject.TabIndex = 73
        Me.chk_subject.UseVisualStyleBackColor = True
        '
        'chk_notes
        '
        Me.chk_notes.AutoSize = True
        Me.chk_notes.Location = New System.Drawing.Point(297, 71)
        Me.chk_notes.Name = "chk_notes"
        Me.chk_notes.Size = New System.Drawing.Size(15, 14)
        Me.chk_notes.TabIndex = 74
        Me.chk_notes.UseVisualStyleBackColor = True
        '
        'chk_endtime
        '
        Me.chk_endtime.AutoSize = True
        Me.chk_endtime.Location = New System.Drawing.Point(297, 45)
        Me.chk_endtime.Name = "chk_endtime"
        Me.chk_endtime.Size = New System.Drawing.Size(15, 14)
        Me.chk_endtime.TabIndex = 75
        Me.chk_endtime.UseVisualStyleBackColor = True
        '
        'chk_starttime
        '
        Me.chk_starttime.AutoSize = True
        Me.chk_starttime.Location = New System.Drawing.Point(297, 19)
        Me.chk_starttime.Name = "chk_starttime"
        Me.chk_starttime.Size = New System.Drawing.Size(15, 14)
        Me.chk_starttime.TabIndex = 76
        Me.chk_starttime.UseVisualStyleBackColor = True
        '
        'chk_date
        '
        Me.chk_date.AutoSize = True
        Me.chk_date.Location = New System.Drawing.Point(21, 71)
        Me.chk_date.Name = "chk_date"
        Me.chk_date.Size = New System.Drawing.Size(15, 14)
        Me.chk_date.TabIndex = 77
        Me.chk_date.UseVisualStyleBackColor = True
        '
        'chk_location
        '
        Me.chk_location.AutoSize = True
        Me.chk_location.Location = New System.Drawing.Point(21, 44)
        Me.chk_location.Name = "chk_location"
        Me.chk_location.Size = New System.Drawing.Size(15, 14)
        Me.chk_location.TabIndex = 78
        Me.chk_location.UseVisualStyleBackColor = True
        '
        'AssistantDS
        '
        Me.AssistantDS.DataSetName = "AssistantDS"
        Me.AssistantDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExamsTableBindingSource
        '
        Me.ExamsTableBindingSource.DataMember = "ExamsTable"
        Me.ExamsTableBindingSource.DataSource = Me.AssistantDS
        '
        'ExamsTableTableAdapter
        '
        Me.ExamsTableTableAdapter.ClearBeforeFill = True
        '
        'ExamsTableBindingSource1
        '
        Me.ExamsTableBindingSource1.DataMember = "ExamsTable"
        Me.ExamsTableBindingSource1.DataSource = Me.AssistantDS
        '
        'ExamsTableBindingSource2
        '
        Me.ExamsTableBindingSource2.DataMember = "ExamsTable"
        Me.ExamsTableBindingSource2.DataSource = Me.AssistantDS
        '
        'ExamsTableBindingSource3
        '
        Me.ExamsTableBindingSource3.DataMember = "ExamsTable"
        Me.ExamsTableBindingSource3.DataSource = Me.AssistantDS
        '
        'ExamsTableBindingSource4
        '
        Me.ExamsTableBindingSource4.DataMember = "ExamsTable"
        Me.ExamsTableBindingSource4.DataSource = Me.AssistantDS
        '
        'ExamsTableBindingSource5
        '
        Me.ExamsTableBindingSource5.DataMember = "ExamsTable"
        Me.ExamsTableBindingSource5.DataSource = Me.AssistantDS
        '
        'FilterExams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 186)
        Me.Controls.Add(Me.chk_location)
        Me.Controls.Add(Me.chk_date)
        Me.Controls.Add(Me.chk_starttime)
        Me.Controls.Add(Me.chk_endtime)
        Me.Controls.Add(Me.chk_notes)
        Me.Controls.Add(Me.chk_subject)
        Me.Controls.Add(Me.com_notes)
        Me.Controls.Add(Me.com_endtime)
        Me.Controls.Add(Me.com_starttime)
        Me.Controls.Add(Me.com_date)
        Me.Controls.Add(Me.com_location)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.com_subject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FilterExams"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter Exams"
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsTableBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsTableBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsTableBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsTableBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_filter As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents com_location As ComboBox
    Friend WithEvents com_date As ComboBox
    Friend WithEvents com_starttime As ComboBox
    Friend WithEvents com_endtime As ComboBox
    Friend WithEvents com_notes As ComboBox
    Friend WithEvents chk_subject As CheckBox
    Friend WithEvents chk_notes As CheckBox
    Friend WithEvents chk_endtime As CheckBox
    Friend WithEvents chk_starttime As CheckBox
    Friend WithEvents chk_date As CheckBox
    Friend WithEvents chk_location As CheckBox
    Friend WithEvents AssistantDS As AssistantDS
    Friend WithEvents ExamsTableBindingSource As BindingSource
    Friend WithEvents ExamsTableTableAdapter As AssistantDSTableAdapters.ExamsTableTableAdapter
    Friend WithEvents ExamsTableBindingSource1 As BindingSource
    Friend WithEvents ExamsTableBindingSource2 As BindingSource
    Friend WithEvents ExamsTableBindingSource3 As BindingSource
    Friend WithEvents ExamsTableBindingSource4 As BindingSource
    Friend WithEvents ExamsTableBindingSource5 As BindingSource
End Class
