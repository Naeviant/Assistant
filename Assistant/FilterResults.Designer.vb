<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterResults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterResults))
        Me.chk_subject = New System.Windows.Forms.CheckBox()
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_total = New System.Windows.Forms.CheckBox()
        Me.com_total = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_marks = New System.Windows.Forms.CheckBox()
        Me.com_marks = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chk_grade = New System.Windows.Forms.CheckBox()
        Me.com_grade = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chk_day = New System.Windows.Forms.CheckBox()
        Me.com_day = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_percentage = New System.Windows.Forms.CheckBox()
        Me.com_percentage = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chk_notes = New System.Windows.Forms.CheckBox()
        Me.com_notes = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AssistantDS = New Assistant.AssistantDS()
        Me.ResultsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResultsTableTableAdapter = New Assistant.AssistantDSTableAdapters.ResultsTableTableAdapter()
        Me.ResultsTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResultsTableBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResultsTableBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResultsTableBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResultsTableBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResultsTableBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsTableBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsTableBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsTableBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsTableBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsTableBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_subject
        '
        Me.chk_subject.AutoSize = True
        Me.chk_subject.Location = New System.Drawing.Point(19, 21)
        Me.chk_subject.Name = "chk_subject"
        Me.chk_subject.Size = New System.Drawing.Size(15, 14)
        Me.chk_subject.TabIndex = 118
        Me.chk_subject.UseVisualStyleBackColor = True
        '
        'com_subject
        '
        Me.com_subject.DataSource = Me.ResultsTableBindingSource
        Me.com_subject.DisplayMember = "Subject"
        Me.com_subject.Enabled = False
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(111, 19)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(195, 21)
        Me.com_subject.TabIndex = 114
        Me.com_subject.ValueMember = "Subject"
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(19, 250)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(287, 31)
        Me.btn_cancel.TabIndex = 112
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_filter
        '
        Me.btn_filter.Image = CType(resources.GetObject("btn_filter.Image"), System.Drawing.Image)
        Me.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_filter.Location = New System.Drawing.Point(19, 213)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(287, 31)
        Me.btn_filter.TabIndex = 111
        Me.btn_filter.Text = "Filter Results"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Subject:"
        '
        'chk_total
        '
        Me.chk_total.AutoSize = True
        Me.chk_total.Location = New System.Drawing.Point(19, 75)
        Me.chk_total.Name = "chk_total"
        Me.chk_total.Size = New System.Drawing.Size(15, 14)
        Me.chk_total.TabIndex = 121
        Me.chk_total.UseVisualStyleBackColor = True
        '
        'com_total
        '
        Me.com_total.DataSource = Me.ResultsTableBindingSource2
        Me.com_total.DisplayMember = "Total"
        Me.com_total.Enabled = False
        Me.com_total.FormattingEnabled = True
        Me.com_total.Location = New System.Drawing.Point(111, 73)
        Me.com_total.Name = "com_total"
        Me.com_total.Size = New System.Drawing.Size(195, 21)
        Me.com_total.TabIndex = 120
        Me.com_total.ValueMember = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Total Marks:"
        '
        'chk_marks
        '
        Me.chk_marks.AutoSize = True
        Me.chk_marks.Location = New System.Drawing.Point(19, 48)
        Me.chk_marks.Name = "chk_marks"
        Me.chk_marks.Size = New System.Drawing.Size(15, 14)
        Me.chk_marks.TabIndex = 124
        Me.chk_marks.UseVisualStyleBackColor = True
        '
        'com_marks
        '
        Me.com_marks.DataSource = Me.ResultsTableBindingSource1
        Me.com_marks.DisplayMember = "Mark"
        Me.com_marks.Enabled = False
        Me.com_marks.FormattingEnabled = True
        Me.com_marks.Location = New System.Drawing.Point(111, 46)
        Me.com_marks.Name = "com_marks"
        Me.com_marks.Size = New System.Drawing.Size(195, 21)
        Me.com_marks.TabIndex = 123
        Me.com_marks.ValueMember = "Mark"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "Marks:"
        '
        'chk_grade
        '
        Me.chk_grade.AutoSize = True
        Me.chk_grade.Location = New System.Drawing.Point(19, 102)
        Me.chk_grade.Name = "chk_grade"
        Me.chk_grade.Size = New System.Drawing.Size(15, 14)
        Me.chk_grade.TabIndex = 127
        Me.chk_grade.UseVisualStyleBackColor = True
        '
        'com_grade
        '
        Me.com_grade.DataSource = Me.ResultsTableBindingSource3
        Me.com_grade.DisplayMember = "Grade"
        Me.com_grade.Enabled = False
        Me.com_grade.FormattingEnabled = True
        Me.com_grade.Location = New System.Drawing.Point(111, 100)
        Me.com_grade.Name = "com_grade"
        Me.com_grade.Size = New System.Drawing.Size(195, 21)
        Me.com_grade.TabIndex = 126
        Me.com_grade.ValueMember = "Grade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Grade:"
        '
        'chk_day
        '
        Me.chk_day.AutoSize = True
        Me.chk_day.Location = New System.Drawing.Point(19, 129)
        Me.chk_day.Name = "chk_day"
        Me.chk_day.Size = New System.Drawing.Size(15, 14)
        Me.chk_day.TabIndex = 130
        Me.chk_day.UseVisualStyleBackColor = True
        '
        'com_day
        '
        Me.com_day.DataSource = Me.ResultsTableBindingSource4
        Me.com_day.DisplayMember = "Day"
        Me.com_day.Enabled = False
        Me.com_day.FormattingEnabled = True
        Me.com_day.Location = New System.Drawing.Point(111, 127)
        Me.com_day.Name = "com_day"
        Me.com_day.Size = New System.Drawing.Size(195, 21)
        Me.com_day.TabIndex = 129
        Me.com_day.ValueMember = "Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "Day:"
        '
        'chk_percentage
        '
        Me.chk_percentage.AutoSize = True
        Me.chk_percentage.Location = New System.Drawing.Point(19, 156)
        Me.chk_percentage.Name = "chk_percentage"
        Me.chk_percentage.Size = New System.Drawing.Size(15, 14)
        Me.chk_percentage.TabIndex = 133
        Me.chk_percentage.UseVisualStyleBackColor = True
        '
        'com_percentage
        '
        Me.com_percentage.DataSource = Me.ResultsTableBindingSource5
        Me.com_percentage.DisplayMember = "Percentage"
        Me.com_percentage.Enabled = False
        Me.com_percentage.FormattingEnabled = True
        Me.com_percentage.Location = New System.Drawing.Point(111, 154)
        Me.com_percentage.Name = "com_percentage"
        Me.com_percentage.Size = New System.Drawing.Size(195, 21)
        Me.com_percentage.TabIndex = 132
        Me.com_percentage.ValueMember = "Percentage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "Percentage:"
        '
        'chk_notes
        '
        Me.chk_notes.AutoSize = True
        Me.chk_notes.Location = New System.Drawing.Point(19, 183)
        Me.chk_notes.Name = "chk_notes"
        Me.chk_notes.Size = New System.Drawing.Size(15, 14)
        Me.chk_notes.TabIndex = 136
        Me.chk_notes.UseVisualStyleBackColor = True
        '
        'com_notes
        '
        Me.com_notes.DataSource = Me.ResultsTableBindingSource6
        Me.com_notes.DisplayMember = "Notes"
        Me.com_notes.Enabled = False
        Me.com_notes.FormattingEnabled = True
        Me.com_notes.Location = New System.Drawing.Point(111, 181)
        Me.com_notes.Name = "com_notes"
        Me.com_notes.Size = New System.Drawing.Size(195, 21)
        Me.com_notes.TabIndex = 135
        Me.com_notes.ValueMember = "Notes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Notes:"
        '
        'AssistantDS
        '
        Me.AssistantDS.DataSetName = "AssistantDS"
        Me.AssistantDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ResultsTableBindingSource
        '
        Me.ResultsTableBindingSource.DataMember = "ResultsTable"
        Me.ResultsTableBindingSource.DataSource = Me.AssistantDS
        '
        'ResultsTableTableAdapter
        '
        Me.ResultsTableTableAdapter.ClearBeforeFill = True
        '
        'ResultsTableBindingSource1
        '
        Me.ResultsTableBindingSource1.DataMember = "ResultsTable"
        Me.ResultsTableBindingSource1.DataSource = Me.AssistantDS
        '
        'ResultsTableBindingSource2
        '
        Me.ResultsTableBindingSource2.DataMember = "ResultsTable"
        Me.ResultsTableBindingSource2.DataSource = Me.AssistantDS
        '
        'ResultsTableBindingSource3
        '
        Me.ResultsTableBindingSource3.DataMember = "ResultsTable"
        Me.ResultsTableBindingSource3.DataSource = Me.AssistantDS
        '
        'ResultsTableBindingSource4
        '
        Me.ResultsTableBindingSource4.DataMember = "ResultsTable"
        Me.ResultsTableBindingSource4.DataSource = Me.AssistantDS
        '
        'ResultsTableBindingSource5
        '
        Me.ResultsTableBindingSource5.DataMember = "ResultsTable"
        Me.ResultsTableBindingSource5.DataSource = Me.AssistantDS
        '
        'ResultsTableBindingSource6
        '
        Me.ResultsTableBindingSource6.DataMember = "ResultsTable"
        Me.ResultsTableBindingSource6.DataSource = Me.AssistantDS
        '
        'FilterResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 296)
        Me.Controls.Add(Me.chk_notes)
        Me.Controls.Add(Me.com_notes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chk_percentage)
        Me.Controls.Add(Me.com_percentage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chk_day)
        Me.Controls.Add(Me.com_day)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chk_grade)
        Me.Controls.Add(Me.com_grade)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chk_marks)
        Me.Controls.Add(Me.com_marks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chk_total)
        Me.Controls.Add(Me.com_total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chk_subject)
        Me.Controls.Add(Me.com_subject)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FilterResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter Results"
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultsTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultsTableBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultsTableBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultsTableBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultsTableBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultsTableBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_subject As CheckBox
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_filter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents chk_total As CheckBox
    Friend WithEvents com_total As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chk_marks As CheckBox
    Friend WithEvents com_marks As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chk_grade As CheckBox
    Friend WithEvents com_grade As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chk_day As CheckBox
    Friend WithEvents com_day As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_percentage As CheckBox
    Friend WithEvents com_percentage As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chk_notes As CheckBox
    Friend WithEvents com_notes As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AssistantDS As AssistantDS
    Friend WithEvents ResultsTableBindingSource As BindingSource
    Friend WithEvents ResultsTableTableAdapter As AssistantDSTableAdapters.ResultsTableTableAdapter
    Friend WithEvents ResultsTableBindingSource2 As BindingSource
    Friend WithEvents ResultsTableBindingSource1 As BindingSource
    Friend WithEvents ResultsTableBindingSource3 As BindingSource
    Friend WithEvents ResultsTableBindingSource4 As BindingSource
    Friend WithEvents ResultsTableBindingSource5 As BindingSource
    Friend WithEvents ResultsTableBindingSource6 As BindingSource
End Class
