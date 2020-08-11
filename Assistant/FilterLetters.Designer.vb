<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterLetters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterLetters))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.com_topic = New System.Windows.Forms.ComboBox()
        Me.LettersTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssistantDS = New Assistant.AssistantDS()
        Me.com_from = New System.Windows.Forms.ComboBox()
        Me.LettersTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.com_date = New System.Windows.Forms.ComboBox()
        Me.LettersTableBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.com_notes = New System.Windows.Forms.ComboBox()
        Me.LettersTableBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LettersTableTableAdapter = New Assistant.AssistantDSTableAdapters.LettersTableTableAdapter()
        Me.chk_topic = New System.Windows.Forms.CheckBox()
        Me.chk_from = New System.Windows.Forms.CheckBox()
        Me.chk_date = New System.Windows.Forms.CheckBox()
        Me.chk_notes = New System.Windows.Forms.CheckBox()
        CType(Me.LettersTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LettersTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LettersTableBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LettersTableBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Notes:"
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(21, 167)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(256, 31)
        Me.btn_cancel.TabIndex = 94
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_filter
        '
        Me.btn_filter.Image = CType(resources.GetObject("btn_filter.Image"), System.Drawing.Image)
        Me.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_filter.Location = New System.Drawing.Point(21, 130)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(256, 31)
        Me.btn_filter.TabIndex = 92
        Me.btn_filter.Text = "Filter Letters"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Day:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "From:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Topic:"
        '
        'com_topic
        '
        Me.com_topic.DataSource = Me.LettersTableBindingSource
        Me.com_topic.DisplayMember = "Topic"
        Me.com_topic.Enabled = False
        Me.com_topic.FormattingEnabled = True
        Me.com_topic.Location = New System.Drawing.Point(82, 16)
        Me.com_topic.Name = "com_topic"
        Me.com_topic.Size = New System.Drawing.Size(195, 21)
        Me.com_topic.TabIndex = 100
        Me.com_topic.ValueMember = "Topic"
        '
        'LettersTableBindingSource
        '
        Me.LettersTableBindingSource.DataMember = "LettersTable"
        Me.LettersTableBindingSource.DataSource = Me.AssistantDS
        '
        'AssistantDS
        '
        Me.AssistantDS.DataSetName = "AssistantDS"
        Me.AssistantDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'com_from
        '
        Me.com_from.DataSource = Me.LettersTableBindingSource1
        Me.com_from.DisplayMember = "From"
        Me.com_from.Enabled = False
        Me.com_from.FormattingEnabled = True
        Me.com_from.Location = New System.Drawing.Point(82, 42)
        Me.com_from.Name = "com_from"
        Me.com_from.Size = New System.Drawing.Size(195, 21)
        Me.com_from.TabIndex = 101
        Me.com_from.ValueMember = "From"
        '
        'LettersTableBindingSource1
        '
        Me.LettersTableBindingSource1.DataMember = "LettersTable"
        Me.LettersTableBindingSource1.DataSource = Me.AssistantDS
        '
        'com_date
        '
        Me.com_date.DataSource = Me.LettersTableBindingSource2
        Me.com_date.DisplayMember = "Day"
        Me.com_date.Enabled = False
        Me.com_date.FormattingEnabled = True
        Me.com_date.Location = New System.Drawing.Point(82, 68)
        Me.com_date.Name = "com_date"
        Me.com_date.Size = New System.Drawing.Size(195, 21)
        Me.com_date.TabIndex = 102
        Me.com_date.ValueMember = "Day"
        '
        'LettersTableBindingSource2
        '
        Me.LettersTableBindingSource2.DataMember = "LettersTable"
        Me.LettersTableBindingSource2.DataSource = Me.AssistantDS
        '
        'com_notes
        '
        Me.com_notes.DataSource = Me.LettersTableBindingSource3
        Me.com_notes.DisplayMember = "Notes"
        Me.com_notes.Enabled = False
        Me.com_notes.FormattingEnabled = True
        Me.com_notes.Location = New System.Drawing.Point(82, 94)
        Me.com_notes.Name = "com_notes"
        Me.com_notes.Size = New System.Drawing.Size(195, 21)
        Me.com_notes.TabIndex = 103
        Me.com_notes.ValueMember = "Notes"
        '
        'LettersTableBindingSource3
        '
        Me.LettersTableBindingSource3.DataMember = "LettersTable"
        Me.LettersTableBindingSource3.DataSource = Me.AssistantDS
        '
        'LettersTableTableAdapter
        '
        Me.LettersTableTableAdapter.ClearBeforeFill = True
        '
        'chk_topic
        '
        Me.chk_topic.AutoSize = True
        Me.chk_topic.Location = New System.Drawing.Point(21, 18)
        Me.chk_topic.Name = "chk_topic"
        Me.chk_topic.Size = New System.Drawing.Size(15, 14)
        Me.chk_topic.TabIndex = 104
        Me.chk_topic.UseVisualStyleBackColor = True
        '
        'chk_from
        '
        Me.chk_from.AutoSize = True
        Me.chk_from.Location = New System.Drawing.Point(21, 45)
        Me.chk_from.Name = "chk_from"
        Me.chk_from.Size = New System.Drawing.Size(15, 14)
        Me.chk_from.TabIndex = 105
        Me.chk_from.UseVisualStyleBackColor = True
        '
        'chk_date
        '
        Me.chk_date.AutoSize = True
        Me.chk_date.Location = New System.Drawing.Point(21, 70)
        Me.chk_date.Name = "chk_date"
        Me.chk_date.Size = New System.Drawing.Size(15, 14)
        Me.chk_date.TabIndex = 106
        Me.chk_date.UseVisualStyleBackColor = True
        '
        'chk_notes
        '
        Me.chk_notes.AutoSize = True
        Me.chk_notes.Location = New System.Drawing.Point(21, 97)
        Me.chk_notes.Name = "chk_notes"
        Me.chk_notes.Size = New System.Drawing.Size(15, 14)
        Me.chk_notes.TabIndex = 107
        Me.chk_notes.UseVisualStyleBackColor = True
        '
        'FilterLetters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 206)
        Me.Controls.Add(Me.chk_notes)
        Me.Controls.Add(Me.chk_date)
        Me.Controls.Add(Me.chk_from)
        Me.Controls.Add(Me.chk_topic)
        Me.Controls.Add(Me.com_notes)
        Me.Controls.Add(Me.com_date)
        Me.Controls.Add(Me.com_from)
        Me.Controls.Add(Me.com_topic)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FilterLetters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter Letters"
        CType(Me.LettersTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LettersTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LettersTableBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LettersTableBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_filter As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents com_topic As ComboBox
    Friend WithEvents com_from As ComboBox
    Friend WithEvents com_date As ComboBox
    Friend WithEvents com_notes As ComboBox
    Friend WithEvents AssistantDS As AssistantDS
    Friend WithEvents LettersTableBindingSource As BindingSource
    Friend WithEvents LettersTableTableAdapter As AssistantDSTableAdapters.LettersTableTableAdapter
    Friend WithEvents LettersTableBindingSource1 As BindingSource
    Friend WithEvents LettersTableBindingSource2 As BindingSource
    Friend WithEvents LettersTableBindingSource3 As BindingSource
    Friend WithEvents chk_topic As CheckBox
    Friend WithEvents chk_from As CheckBox
    Friend WithEvents chk_date As CheckBox
    Friend WithEvents chk_notes As CheckBox
End Class
