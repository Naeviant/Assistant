<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignmentsFilter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssignmentsFilter))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.date_due = New System.Windows.Forms.DateTimePicker()
        Me.date_start = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.com_status = New System.Windows.Forms.ComboBox()
        Me.com_priority = New System.Windows.Forms.ComboBox()
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SubjectsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.SubjectsTableAdapter()
        Me.txt_progress = New System.Windows.Forms.TextBox()
        Me.AssignmentsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.AssignmentsTableAdapter()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(196, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "%"
        '
        'btn_filter
        '
        Me.btn_filter.Location = New System.Drawing.Point(233, 87)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(200, 23)
        Me.btn_filter.TabIndex = 43
        Me.btn_filter.Text = "Filter"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(21, 87)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(190, 23)
        Me.btn_close.TabIndex = 41
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'date_due
        '
        Me.date_due.CustomFormat = "ddd dd/MM/yyyy"
        Me.date_due.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_due.Location = New System.Drawing.Point(294, 58)
        Me.date_due.Name = "date_due"
        Me.date_due.ShowCheckBox = True
        Me.date_due.Size = New System.Drawing.Size(139, 20)
        Me.date_due.TabIndex = 36
        '
        'date_start
        '
        Me.date_start.CustomFormat = "ddd dd/MM/yyyy"
        Me.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_start.Location = New System.Drawing.Point(294, 36)
        Me.date_start.Name = "date_start"
        Me.date_start.ShowCheckBox = True
        Me.date_start.Size = New System.Drawing.Size(139, 20)
        Me.date_start.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(230, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Due Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(230, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Set Date:"
        '
        'com_status
        '
        Me.com_status.AutoCompleteCustomSource.AddRange(New String() {"Not Started", "In Progress", "On Hold", "Completed"})
        Me.com_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.com_status.FormattingEnabled = True
        Me.com_status.Items.AddRange(New Object() {"Not Started", "In Progress", "On Hold", "Completed"})
        Me.com_status.Location = New System.Drawing.Point(73, 60)
        Me.com_status.Name = "com_status"
        Me.com_status.Size = New System.Drawing.Size(138, 21)
        Me.com_status.TabIndex = 30
        '
        'com_priority
        '
        Me.com_priority.AutoCompleteCustomSource.AddRange(New String() {"High", "Normal", "Low"})
        Me.com_priority.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_priority.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.com_priority.FormattingEnabled = True
        Me.com_priority.Items.AddRange(New Object() {"High", "Normal", "Low"})
        Me.com_priority.Location = New System.Drawing.Point(294, 13)
        Me.com_priority.Name = "com_priority"
        Me.com_priority.Size = New System.Drawing.Size(139, 21)
        Me.com_priority.TabIndex = 28
        '
        'com_subject
        '
        Me.com_subject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.com_subject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(73, 13)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(138, 21)
        Me.com_subject.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Status: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Progress:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Priority:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Subject: "
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
        '
        'txt_progress
        '
        Me.txt_progress.Location = New System.Drawing.Point(73, 37)
        Me.txt_progress.Name = "txt_progress"
        Me.txt_progress.Size = New System.Drawing.Size(117, 20)
        Me.txt_progress.TabIndex = 45
        '
        'AssignmentsTableAdapter
        '
        Me.AssignmentsTableAdapter.ClearBeforeFill = True
        '
        'AssignmentsFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 125)
        Me.Controls.Add(Me.txt_progress)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.date_due)
        Me.Controls.Add(Me.date_start)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.com_status)
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
        Me.Name = "AssignmentsFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant: Filter Assignments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_filter As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents date_due As DateTimePicker
    Friend WithEvents date_start As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents com_status As ComboBox
    Friend WithEvents com_priority As ComboBox
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SubjectsTableAdapter As AssistantDBDataSetTableAdapters.SubjectsTableAdapter
    Friend WithEvents txt_progress As TextBox
    Friend WithEvents AssignmentsTableAdapter As AssistantDBDataSetTableAdapters.AssignmentsTableAdapter
End Class
