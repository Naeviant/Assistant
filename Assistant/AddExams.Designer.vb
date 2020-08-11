<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddExams
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddExams))
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.SubjectsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssistantDS = New Assistant.AssistantDS()
        Me.date_date = New System.Windows.Forms.DateTimePicker()
        Me.date_starttime = New System.Windows.Forms.DateTimePicker()
        Me.date_endtime = New System.Windows.Forms.DateTimePicker()
        Me.SubjectsTableTableAdapter = New Assistant.AssistantDSTableAdapters.SubjectsTableTableAdapter()
        Me.txt_notes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.SubjectsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(16, 237)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(536, 31)
        Me.btn_cancel.TabIndex = 21
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(16, 200)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(536, 31)
        Me.btn_clear.TabIndex = 20
        Me.btn_clear.Text = "Clear Fields"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(16, 163)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(536, 31)
        Me.btn_add.TabIndex = 19
        Me.btn_add.Text = "Add Exam"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Start Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Day:"
        '
        'txt_location
        '
        Me.txt_location.Location = New System.Drawing.Point(77, 49)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(195, 20)
        Me.txt_location.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Location:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Subject:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "End Time:"
        '
        'com_subject
        '
        Me.com_subject.DataSource = Me.SubjectsTableBindingSource
        Me.com_subject.DisplayMember = "Subject"
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(77, 23)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(195, 21)
        Me.com_subject.TabIndex = 24
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
        'date_date
        '
        Me.date_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_date.Location = New System.Drawing.Point(77, 75)
        Me.date_date.Name = "date_date"
        Me.date_date.Size = New System.Drawing.Size(195, 20)
        Me.date_date.TabIndex = 48
        '
        'date_starttime
        '
        Me.date_starttime.CustomFormat = "HH:mm"
        Me.date_starttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_starttime.Location = New System.Drawing.Point(77, 101)
        Me.date_starttime.Name = "date_starttime"
        Me.date_starttime.ShowUpDown = True
        Me.date_starttime.Size = New System.Drawing.Size(195, 20)
        Me.date_starttime.TabIndex = 49
        '
        'date_endtime
        '
        Me.date_endtime.CustomFormat = "HH:mm"
        Me.date_endtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_endtime.Location = New System.Drawing.Point(77, 127)
        Me.date_endtime.Name = "date_endtime"
        Me.date_endtime.ShowUpDown = True
        Me.date_endtime.Size = New System.Drawing.Size(195, 20)
        Me.date_endtime.TabIndex = 50
        '
        'SubjectsTableTableAdapter
        '
        Me.SubjectsTableTableAdapter.ClearBeforeFill = True
        '
        'txt_notes
        '
        Me.txt_notes.Location = New System.Drawing.Point(337, 23)
        Me.txt_notes.Multiline = True
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_notes.Size = New System.Drawing.Size(215, 124)
        Me.txt_notes.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(293, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Notes:"
        '
        'AddExams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 276)
        Me.Controls.Add(Me.txt_notes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.date_endtime)
        Me.Controls.Add(Me.date_starttime)
        Me.Controls.Add(Me.date_date)
        Me.Controls.Add(Me.com_subject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AddExams"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Exam"
        CType(Me.SubjectsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_location As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents date_date As DateTimePicker
    Friend WithEvents date_starttime As DateTimePicker
    Friend WithEvents date_endtime As DateTimePicker
    Friend WithEvents AssistantDS As AssistantDS
    Friend WithEvents SubjectsTableBindingSource As BindingSource
    Friend WithEvents SubjectsTableTableAdapter As AssistantDSTableAdapters.SubjectsTableTableAdapter
    Friend WithEvents txt_notes As TextBox
    Friend WithEvents Label6 As Label
End Class
