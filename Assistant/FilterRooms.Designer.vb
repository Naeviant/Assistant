<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterRooms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterRooms))
        Me.chk_notes = New System.Windows.Forms.CheckBox()
        Me.com_notes = New System.Windows.Forms.ComboBox()
        Me.RoomsTableBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssistantDS = New Assistant.AssistantDS()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chk_reason = New System.Windows.Forms.CheckBox()
        Me.com_reason = New System.Windows.Forms.ComboBox()
        Me.RoomsTableBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chk_period = New System.Windows.Forms.CheckBox()
        Me.com_period = New System.Windows.Forms.ComboBox()
        Me.RoomsTableBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_day = New System.Windows.Forms.CheckBox()
        Me.com_day = New System.Windows.Forms.ComboBox()
        Me.RoomsTableBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chk_from = New System.Windows.Forms.CheckBox()
        Me.com_from = New System.Windows.Forms.ComboBox()
        Me.RoomsTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_to = New System.Windows.Forms.CheckBox()
        Me.com_to = New System.Windows.Forms.ComboBox()
        Me.RoomsTableBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_subject = New System.Windows.Forms.CheckBox()
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.RoomsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RoomsTableTableAdapter = New Assistant.AssistantDSTableAdapters.RoomsTableTableAdapter()
        CType(Me.RoomsTableBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomsTableBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomsTableBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomsTableBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomsTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomsTableBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_notes
        '
        Me.chk_notes.AutoSize = True
        Me.chk_notes.Location = New System.Drawing.Point(16, 181)
        Me.chk_notes.Name = "chk_notes"
        Me.chk_notes.Size = New System.Drawing.Size(15, 14)
        Me.chk_notes.TabIndex = 159
        Me.chk_notes.UseVisualStyleBackColor = True
        '
        'com_notes
        '
        Me.com_notes.DataSource = Me.RoomsTableBindingSource6
        Me.com_notes.DisplayMember = "Notes"
        Me.com_notes.Enabled = False
        Me.com_notes.FormattingEnabled = True
        Me.com_notes.Location = New System.Drawing.Point(108, 179)
        Me.com_notes.Name = "com_notes"
        Me.com_notes.Size = New System.Drawing.Size(195, 21)
        Me.com_notes.TabIndex = 158
        Me.com_notes.ValueMember = "Notes"
        '
        'RoomsTableBindingSource6
        '
        Me.RoomsTableBindingSource6.DataMember = "RoomsTable"
        Me.RoomsTableBindingSource6.DataSource = Me.AssistantDS
        '
        'AssistantDS
        '
        Me.AssistantDS.DataSetName = "AssistantDS"
        Me.AssistantDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "Notes:"
        '
        'chk_reason
        '
        Me.chk_reason.AutoSize = True
        Me.chk_reason.Location = New System.Drawing.Point(16, 154)
        Me.chk_reason.Name = "chk_reason"
        Me.chk_reason.Size = New System.Drawing.Size(15, 14)
        Me.chk_reason.TabIndex = 156
        Me.chk_reason.UseVisualStyleBackColor = True
        '
        'com_reason
        '
        Me.com_reason.DataSource = Me.RoomsTableBindingSource5
        Me.com_reason.DisplayMember = "Reason"
        Me.com_reason.Enabled = False
        Me.com_reason.FormattingEnabled = True
        Me.com_reason.Location = New System.Drawing.Point(108, 152)
        Me.com_reason.Name = "com_reason"
        Me.com_reason.Size = New System.Drawing.Size(195, 21)
        Me.com_reason.TabIndex = 155
        Me.com_reason.ValueMember = "Reason"
        '
        'RoomsTableBindingSource5
        '
        Me.RoomsTableBindingSource5.DataMember = "RoomsTable"
        Me.RoomsTableBindingSource5.DataSource = Me.AssistantDS
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Reason:"
        '
        'chk_period
        '
        Me.chk_period.AutoSize = True
        Me.chk_period.Location = New System.Drawing.Point(16, 127)
        Me.chk_period.Name = "chk_period"
        Me.chk_period.Size = New System.Drawing.Size(15, 14)
        Me.chk_period.TabIndex = 153
        Me.chk_period.UseVisualStyleBackColor = True
        '
        'com_period
        '
        Me.com_period.DataSource = Me.RoomsTableBindingSource4
        Me.com_period.DisplayMember = "Period"
        Me.com_period.Enabled = False
        Me.com_period.FormattingEnabled = True
        Me.com_period.Location = New System.Drawing.Point(108, 125)
        Me.com_period.Name = "com_period"
        Me.com_period.Size = New System.Drawing.Size(195, 21)
        Me.com_period.TabIndex = 152
        Me.com_period.ValueMember = "Period"
        '
        'RoomsTableBindingSource4
        '
        Me.RoomsTableBindingSource4.DataMember = "RoomsTable"
        Me.RoomsTableBindingSource4.DataSource = Me.AssistantDS
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Period:"
        '
        'chk_day
        '
        Me.chk_day.AutoSize = True
        Me.chk_day.Location = New System.Drawing.Point(16, 100)
        Me.chk_day.Name = "chk_day"
        Me.chk_day.Size = New System.Drawing.Size(15, 14)
        Me.chk_day.TabIndex = 150
        Me.chk_day.UseVisualStyleBackColor = True
        '
        'com_day
        '
        Me.com_day.DataSource = Me.RoomsTableBindingSource3
        Me.com_day.DisplayMember = "Day"
        Me.com_day.Enabled = False
        Me.com_day.FormattingEnabled = True
        Me.com_day.Location = New System.Drawing.Point(108, 98)
        Me.com_day.Name = "com_day"
        Me.com_day.Size = New System.Drawing.Size(195, 21)
        Me.com_day.TabIndex = 149
        Me.com_day.ValueMember = "Day"
        '
        'RoomsTableBindingSource3
        '
        Me.RoomsTableBindingSource3.DataMember = "RoomsTable"
        Me.RoomsTableBindingSource3.DataSource = Me.AssistantDS
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Day:"
        '
        'chk_from
        '
        Me.chk_from.AutoSize = True
        Me.chk_from.Location = New System.Drawing.Point(16, 46)
        Me.chk_from.Name = "chk_from"
        Me.chk_from.Size = New System.Drawing.Size(15, 14)
        Me.chk_from.TabIndex = 147
        Me.chk_from.UseVisualStyleBackColor = True
        '
        'com_from
        '
        Me.com_from.DataSource = Me.RoomsTableBindingSource1
        Me.com_from.DisplayMember = "From"
        Me.com_from.Enabled = False
        Me.com_from.FormattingEnabled = True
        Me.com_from.Location = New System.Drawing.Point(108, 44)
        Me.com_from.Name = "com_from"
        Me.com_from.Size = New System.Drawing.Size(195, 21)
        Me.com_from.TabIndex = 146
        Me.com_from.ValueMember = "From"
        '
        'RoomsTableBindingSource1
        '
        Me.RoomsTableBindingSource1.DataMember = "RoomsTable"
        Me.RoomsTableBindingSource1.DataSource = Me.AssistantDS
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "From Room:"
        '
        'chk_to
        '
        Me.chk_to.AutoSize = True
        Me.chk_to.Location = New System.Drawing.Point(16, 73)
        Me.chk_to.Name = "chk_to"
        Me.chk_to.Size = New System.Drawing.Size(15, 14)
        Me.chk_to.TabIndex = 144
        Me.chk_to.UseVisualStyleBackColor = True
        '
        'com_to
        '
        Me.com_to.DataSource = Me.RoomsTableBindingSource2
        Me.com_to.DisplayMember = "To"
        Me.com_to.Enabled = False
        Me.com_to.FormattingEnabled = True
        Me.com_to.Location = New System.Drawing.Point(108, 71)
        Me.com_to.Name = "com_to"
        Me.com_to.Size = New System.Drawing.Size(195, 21)
        Me.com_to.TabIndex = 143
        Me.com_to.ValueMember = "To"
        '
        'RoomsTableBindingSource2
        '
        Me.RoomsTableBindingSource2.DataMember = "RoomsTable"
        Me.RoomsTableBindingSource2.DataSource = Me.AssistantDS
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "To Room:"
        '
        'chk_subject
        '
        Me.chk_subject.AutoSize = True
        Me.chk_subject.Location = New System.Drawing.Point(16, 19)
        Me.chk_subject.Name = "chk_subject"
        Me.chk_subject.Size = New System.Drawing.Size(15, 14)
        Me.chk_subject.TabIndex = 141
        Me.chk_subject.UseVisualStyleBackColor = True
        '
        'com_subject
        '
        Me.com_subject.DataSource = Me.RoomsTableBindingSource
        Me.com_subject.DisplayMember = "Subject"
        Me.com_subject.Enabled = False
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(108, 17)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(195, 21)
        Me.com_subject.TabIndex = 140
        Me.com_subject.ValueMember = "Subject"
        '
        'RoomsTableBindingSource
        '
        Me.RoomsTableBindingSource.DataMember = "RoomsTable"
        Me.RoomsTableBindingSource.DataSource = Me.AssistantDS
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(16, 248)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(287, 31)
        Me.btn_cancel.TabIndex = 139
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_filter
        '
        Me.btn_filter.Image = CType(resources.GetObject("btn_filter.Image"), System.Drawing.Image)
        Me.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_filter.Location = New System.Drawing.Point(16, 211)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(287, 31)
        Me.btn_filter.TabIndex = 138
        Me.btn_filter.Text = "Filter Rooms"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Subject:"
        '
        'RoomsTableTableAdapter
        '
        Me.RoomsTableTableAdapter.ClearBeforeFill = True
        '
        'FilterRooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 296)
        Me.Controls.Add(Me.chk_notes)
        Me.Controls.Add(Me.com_notes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chk_reason)
        Me.Controls.Add(Me.com_reason)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chk_period)
        Me.Controls.Add(Me.com_period)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chk_day)
        Me.Controls.Add(Me.com_day)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chk_from)
        Me.Controls.Add(Me.com_from)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chk_to)
        Me.Controls.Add(Me.com_to)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chk_subject)
        Me.Controls.Add(Me.com_subject)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FilterRooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter Rooms"
        CType(Me.RoomsTableBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomsTableBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomsTableBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomsTableBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomsTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomsTableBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk_notes As CheckBox
    Friend WithEvents com_notes As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chk_reason As CheckBox
    Friend WithEvents com_reason As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chk_period As CheckBox
    Friend WithEvents com_period As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_day As CheckBox
    Friend WithEvents com_day As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chk_from As CheckBox
    Friend WithEvents com_from As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chk_to As CheckBox
    Friend WithEvents com_to As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chk_subject As CheckBox
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_filter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AssistantDS As AssistantDS
    Friend WithEvents RoomsTableBindingSource As BindingSource
    Friend WithEvents RoomsTableTableAdapter As AssistantDSTableAdapters.RoomsTableTableAdapter
    Friend WithEvents RoomsTableBindingSource1 As BindingSource
    Friend WithEvents RoomsTableBindingSource2 As BindingSource
    Friend WithEvents RoomsTableBindingSource6 As BindingSource
    Friend WithEvents RoomsTableBindingSource5 As BindingSource
    Friend WithEvents RoomsTableBindingSource4 As BindingSource
    Friend WithEvents RoomsTableBindingSource3 As BindingSource
End Class
