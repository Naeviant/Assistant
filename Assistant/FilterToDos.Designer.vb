<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterToDos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterToDos))
        Me.chk_notes = New System.Windows.Forms.CheckBox()
        Me.com_notes = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chk_description = New System.Windows.Forms.CheckBox()
        Me.com_description = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chk_location = New System.Windows.Forms.CheckBox()
        Me.com_location = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_time = New System.Windows.Forms.CheckBox()
        Me.com_time = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chk_day = New System.Windows.Forms.CheckBox()
        Me.com_day = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_title = New System.Windows.Forms.CheckBox()
        Me.com_title = New System.Windows.Forms.ComboBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AssistantDS = New Assistant.AssistantDS()
        Me.ToDosTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToDosTableTableAdapter = New Assistant.AssistantDSTableAdapters.ToDosTableTableAdapter()
        Me.ToDosTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToDosTableBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToDosTableBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToDosTableBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToDosTableBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDosTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDosTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDosTableBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDosTableBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDosTableBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDosTableBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_notes
        '
        Me.chk_notes.AutoSize = True
        Me.chk_notes.Location = New System.Drawing.Point(16, 154)
        Me.chk_notes.Name = "chk_notes"
        Me.chk_notes.Size = New System.Drawing.Size(15, 14)
        Me.chk_notes.TabIndex = 159
        Me.chk_notes.UseVisualStyleBackColor = True
        '
        'com_notes
        '
        Me.com_notes.DataSource = Me.ToDosTableBindingSource5
        Me.com_notes.DisplayMember = "Notes"
        Me.com_notes.Enabled = False
        Me.com_notes.FormattingEnabled = True
        Me.com_notes.Location = New System.Drawing.Point(108, 152)
        Me.com_notes.Name = "com_notes"
        Me.com_notes.Size = New System.Drawing.Size(195, 21)
        Me.com_notes.TabIndex = 158
        Me.com_notes.ValueMember = "Notes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "Notes:"
        '
        'chk_description
        '
        Me.chk_description.AutoSize = True
        Me.chk_description.Location = New System.Drawing.Point(16, 127)
        Me.chk_description.Name = "chk_description"
        Me.chk_description.Size = New System.Drawing.Size(15, 14)
        Me.chk_description.TabIndex = 156
        Me.chk_description.UseVisualStyleBackColor = True
        '
        'com_description
        '
        Me.com_description.DataSource = Me.ToDosTableBindingSource4
        Me.com_description.DisplayMember = "Description"
        Me.com_description.Enabled = False
        Me.com_description.FormattingEnabled = True
        Me.com_description.Location = New System.Drawing.Point(108, 125)
        Me.com_description.Name = "com_description"
        Me.com_description.Size = New System.Drawing.Size(195, 21)
        Me.com_description.TabIndex = 155
        Me.com_description.ValueMember = "Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Description:"
        '
        'chk_location
        '
        Me.chk_location.AutoSize = True
        Me.chk_location.Location = New System.Drawing.Point(16, 100)
        Me.chk_location.Name = "chk_location"
        Me.chk_location.Size = New System.Drawing.Size(15, 14)
        Me.chk_location.TabIndex = 153
        Me.chk_location.UseVisualStyleBackColor = True
        '
        'com_location
        '
        Me.com_location.DataSource = Me.ToDosTableBindingSource3
        Me.com_location.DisplayMember = "Location"
        Me.com_location.Enabled = False
        Me.com_location.FormattingEnabled = True
        Me.com_location.Location = New System.Drawing.Point(108, 98)
        Me.com_location.Name = "com_location"
        Me.com_location.Size = New System.Drawing.Size(195, 21)
        Me.com_location.TabIndex = 152
        Me.com_location.ValueMember = "Location"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Location:"
        '
        'chk_time
        '
        Me.chk_time.AutoSize = True
        Me.chk_time.Location = New System.Drawing.Point(16, 73)
        Me.chk_time.Name = "chk_time"
        Me.chk_time.Size = New System.Drawing.Size(15, 14)
        Me.chk_time.TabIndex = 150
        Me.chk_time.UseVisualStyleBackColor = True
        '
        'com_time
        '
        Me.com_time.DataSource = Me.ToDosTableBindingSource2
        Me.com_time.DisplayMember = "Time"
        Me.com_time.Enabled = False
        Me.com_time.FormattingEnabled = True
        Me.com_time.Location = New System.Drawing.Point(108, 71)
        Me.com_time.Name = "com_time"
        Me.com_time.Size = New System.Drawing.Size(195, 21)
        Me.com_time.TabIndex = 149
        Me.com_time.ValueMember = "Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Time:"
        '
        'chk_day
        '
        Me.chk_day.AutoSize = True
        Me.chk_day.Location = New System.Drawing.Point(16, 46)
        Me.chk_day.Name = "chk_day"
        Me.chk_day.Size = New System.Drawing.Size(15, 14)
        Me.chk_day.TabIndex = 147
        Me.chk_day.UseVisualStyleBackColor = True
        '
        'com_day
        '
        Me.com_day.DataSource = Me.ToDosTableBindingSource1
        Me.com_day.Enabled = False
        Me.com_day.FormattingEnabled = True
        Me.com_day.Location = New System.Drawing.Point(108, 44)
        Me.com_day.Name = "com_day"
        Me.com_day.Size = New System.Drawing.Size(195, 21)
        Me.com_day.TabIndex = 146
        Me.com_day.ValueMember = "Mark"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Day:"
        '
        'chk_title
        '
        Me.chk_title.AutoSize = True
        Me.chk_title.Location = New System.Drawing.Point(16, 19)
        Me.chk_title.Name = "chk_title"
        Me.chk_title.Size = New System.Drawing.Size(15, 14)
        Me.chk_title.TabIndex = 141
        Me.chk_title.UseVisualStyleBackColor = True
        '
        'com_title
        '
        Me.com_title.DataSource = Me.ToDosTableBindingSource
        Me.com_title.DisplayMember = "Title"
        Me.com_title.Enabled = False
        Me.com_title.FormattingEnabled = True
        Me.com_title.Location = New System.Drawing.Point(108, 17)
        Me.com_title.Name = "com_title"
        Me.com_title.Size = New System.Drawing.Size(195, 21)
        Me.com_title.TabIndex = 140
        Me.com_title.ValueMember = "Title"
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(16, 221)
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
        Me.btn_filter.Location = New System.Drawing.Point(16, 184)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(287, 31)
        Me.btn_filter.TabIndex = 138
        Me.btn_filter.Text = "Filter ToDos"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Title:"
        '
        'AssistantDS
        '
        Me.AssistantDS.DataSetName = "AssistantDS"
        Me.AssistantDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToDosTableBindingSource
        '
        Me.ToDosTableBindingSource.DataMember = "ToDosTable"
        Me.ToDosTableBindingSource.DataSource = Me.AssistantDS
        '
        'ToDosTableTableAdapter
        '
        Me.ToDosTableTableAdapter.ClearBeforeFill = True
        '
        'ToDosTableBindingSource1
        '
        Me.ToDosTableBindingSource1.DataMember = "ToDosTable"
        Me.ToDosTableBindingSource1.DataSource = Me.AssistantDS
        '
        'ToDosTableBindingSource2
        '
        Me.ToDosTableBindingSource2.DataMember = "ToDosTable"
        Me.ToDosTableBindingSource2.DataSource = Me.AssistantDS
        '
        'ToDosTableBindingSource3
        '
        Me.ToDosTableBindingSource3.DataMember = "ToDosTable"
        Me.ToDosTableBindingSource3.DataSource = Me.AssistantDS
        '
        'ToDosTableBindingSource4
        '
        Me.ToDosTableBindingSource4.DataMember = "ToDosTable"
        Me.ToDosTableBindingSource4.DataSource = Me.AssistantDS
        '
        'ToDosTableBindingSource5
        '
        Me.ToDosTableBindingSource5.DataMember = "ToDosTable"
        Me.ToDosTableBindingSource5.DataSource = Me.AssistantDS
        '
        'FilterToDos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 266)
        Me.Controls.Add(Me.chk_notes)
        Me.Controls.Add(Me.com_notes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chk_description)
        Me.Controls.Add(Me.com_description)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chk_location)
        Me.Controls.Add(Me.com_location)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chk_time)
        Me.Controls.Add(Me.com_time)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chk_day)
        Me.Controls.Add(Me.com_day)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chk_title)
        Me.Controls.Add(Me.com_title)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FilterToDos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter ToDos"
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDosTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDosTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDosTableBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDosTableBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDosTableBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDosTableBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk_notes As CheckBox
    Friend WithEvents com_notes As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chk_description As CheckBox
    Friend WithEvents com_description As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chk_location As CheckBox
    Friend WithEvents com_location As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_time As CheckBox
    Friend WithEvents com_time As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chk_day As CheckBox
    Friend WithEvents com_day As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chk_title As CheckBox
    Friend WithEvents com_title As ComboBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_filter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AssistantDS As AssistantDS
    Friend WithEvents ToDosTableBindingSource As BindingSource
    Friend WithEvents ToDosTableTableAdapter As AssistantDSTableAdapters.ToDosTableTableAdapter
    Friend WithEvents ToDosTableBindingSource5 As BindingSource
    Friend WithEvents ToDosTableBindingSource4 As BindingSource
    Friend WithEvents ToDosTableBindingSource3 As BindingSource
    Friend WithEvents ToDosTableBindingSource2 As BindingSource
    Friend WithEvents ToDosTableBindingSource1 As BindingSource
End Class
