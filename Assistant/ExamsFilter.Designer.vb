<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamsFilter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExamsFilter))
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.date_datetime = New System.Windows.Forms.DateTimePicker()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.com_type = New System.Windows.Forms.ComboBox()
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExamTypesTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.Exam_TypesTableAdapter()
        Me.SubjectsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.SubjectsTableAdapter()
        Me.ExamsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.ExamsTableAdapter()
        Me.txt_seat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_filter
        '
        Me.btn_filter.Location = New System.Drawing.Point(19, 159)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(218, 23)
        Me.btn_filter.TabIndex = 25
        Me.btn_filter.Text = "Filter"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(19, 130)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(218, 23)
        Me.btn_close.TabIndex = 23
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'date_datetime
        '
        Me.date_datetime.Checked = False
        Me.date_datetime.CustomFormat = "ddd dd/MM/yyyy"
        Me.date_datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_datetime.Location = New System.Drawing.Point(81, 104)
        Me.date_datetime.Name = "date_datetime"
        Me.date_datetime.ShowCheckBox = True
        Me.date_datetime.Size = New System.Drawing.Size(156, 20)
        Me.date_datetime.TabIndex = 21
        '
        'txt_location
        '
        Me.txt_location.Location = New System.Drawing.Point(81, 59)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(156, 20)
        Me.txt_location.TabIndex = 20
        '
        'com_type
        '
        Me.com_type.FormattingEnabled = True
        Me.com_type.Location = New System.Drawing.Point(81, 36)
        Me.com_type.Name = "com_type"
        Me.com_type.Size = New System.Drawing.Size(156, 21)
        Me.com_type.TabIndex = 19
        '
        'com_subject
        '
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(81, 13)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(156, 21)
        Me.com_subject.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Location:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Subject:"
        '
        'ExamTypesTableAdapter
        '
        Me.ExamTypesTableAdapter.ClearBeforeFill = True
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
        '
        'ExamsTableAdapter
        '
        Me.ExamsTableAdapter.ClearBeforeFill = True
        '
        'txt_seat
        '
        Me.txt_seat.Location = New System.Drawing.Point(81, 81)
        Me.txt_seat.Name = "txt_seat"
        Me.txt_seat.Size = New System.Drawing.Size(156, 20)
        Me.txt_seat.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Seat:"
        '
        'ExamsFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 195)
        Me.Controls.Add(Me.txt_seat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.date_datetime)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.com_type)
        Me.Controls.Add(Me.com_subject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExamsFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant: Filter Exams"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_filter As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents date_datetime As DateTimePicker
    Friend WithEvents txt_location As TextBox
    Friend WithEvents com_type As ComboBox
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ExamTypesTableAdapter As AssistantDBDataSetTableAdapters.Exam_TypesTableAdapter
    Friend WithEvents SubjectsTableAdapter As AssistantDBDataSetTableAdapters.SubjectsTableAdapter
    Friend WithEvents ExamsTableAdapter As AssistantDBDataSetTableAdapters.ExamsTableAdapter
    Friend WithEvents txt_seat As TextBox
    Friend WithEvents Label5 As Label
End Class
