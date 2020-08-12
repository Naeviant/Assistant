<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamsEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExamsEdit))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.com_type = New System.Windows.Forms.ComboBox()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.chk_archived = New System.Windows.Forms.CheckBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.SubjectsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.SubjectsTableAdapter()
        Me.ExamTypesTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.Exam_TypesTableAdapter()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.ExamsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.ExamsTableAdapter()
        Me.date_datetime = New System.Windows.Forms.DateTimePicker()
        Me.txt_seat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subject:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Location:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date/Time:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Archived:"
        '
        'com_subject
        '
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(78, 10)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(156, 21)
        Me.com_subject.TabIndex = 5
        '
        'com_type
        '
        Me.com_type.FormattingEnabled = True
        Me.com_type.Location = New System.Drawing.Point(78, 33)
        Me.com_type.Name = "com_type"
        Me.com_type.Size = New System.Drawing.Size(156, 21)
        Me.com_type.TabIndex = 6
        '
        'txt_location
        '
        Me.txt_location.Location = New System.Drawing.Point(78, 56)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(156, 20)
        Me.txt_location.TabIndex = 7
        '
        'chk_archived
        '
        Me.chk_archived.AutoSize = True
        Me.chk_archived.Location = New System.Drawing.Point(143, 125)
        Me.chk_archived.Name = "chk_archived"
        Me.chk_archived.Size = New System.Drawing.Size(15, 14)
        Me.chk_archived.TabIndex = 9
        Me.chk_archived.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(16, 148)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(218, 23)
        Me.btn_close.TabIndex = 10
        Me.btn_close.Text = "Cancel"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(16, 177)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(218, 23)
        Me.btn_clear.TabIndex = 11
        Me.btn_clear.Text = "Reset Fields"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(16, 206)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(218, 23)
        Me.btn_save.TabIndex = 12
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
        '
        'ExamTypesTableAdapter
        '
        Me.ExamTypesTableAdapter.ClearBeforeFill = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(216, 126)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 13
        Me.lbl_id.Text = "ID"
        Me.lbl_id.Visible = False
        '
        'ExamsTableAdapter
        '
        Me.ExamsTableAdapter.ClearBeforeFill = True
        '
        'date_datetime
        '
        Me.date_datetime.CustomFormat = "ddd dd/MM/yyyy HH:mm"
        Me.date_datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_datetime.Location = New System.Drawing.Point(78, 100)
        Me.date_datetime.Name = "date_datetime"
        Me.date_datetime.Size = New System.Drawing.Size(156, 20)
        Me.date_datetime.TabIndex = 14
        '
        'txt_seat
        '
        Me.txt_seat.Location = New System.Drawing.Point(78, 78)
        Me.txt_seat.Name = "txt_seat"
        Me.txt_seat.Size = New System.Drawing.Size(156, 20)
        Me.txt_seat.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Seat:"
        '
        'ExamsEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 241)
        Me.Controls.Add(Me.txt_seat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.date_datetime)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.chk_archived)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.com_type)
        Me.Controls.Add(Me.com_subject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExamsEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant: Exam Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents com_type As ComboBox
    Friend WithEvents txt_location As TextBox
    Friend WithEvents chk_archived As CheckBox
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents SubjectsTableAdapter As AssistantDBDataSetTableAdapters.SubjectsTableAdapter
    Friend WithEvents ExamTypesTableAdapter As AssistantDBDataSetTableAdapters.Exam_TypesTableAdapter
    Friend WithEvents lbl_id As Label
    Friend WithEvents ExamsTableAdapter As AssistantDBDataSetTableAdapters.ExamsTableAdapter
    Friend WithEvents date_datetime As DateTimePicker
    Friend WithEvents txt_seat As TextBox
    Friend WithEvents Label6 As Label
End Class
