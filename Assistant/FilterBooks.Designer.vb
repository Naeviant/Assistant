<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterBooks))
        Me.com_bookname = New System.Windows.Forms.ComboBox()
        Me.BooksTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssistantDS = New Assistant.AssistantDS()
        Me.com_location = New System.Windows.Forms.ComboBox()
        Me.BooksTableBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.BooksTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chk_bookname = New System.Windows.Forms.CheckBox()
        Me.chk_location = New System.Windows.Forms.CheckBox()
        Me.chk_subject = New System.Windows.Forms.CheckBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BooksTableTableAdapter = New Assistant.AssistantDSTableAdapters.BooksTableTableAdapter()
        Me.BooksTableBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.com_notes = New System.Windows.Forms.ComboBox()
        Me.chk_notes = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.BooksTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksTableBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksTableBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'com_bookname
        '
        Me.com_bookname.DataSource = Me.BooksTableBindingSource1
        Me.com_bookname.DisplayMember = "Book Name"
        Me.com_bookname.Enabled = False
        Me.com_bookname.FormattingEnabled = True
        Me.com_bookname.Location = New System.Drawing.Point(100, 45)
        Me.com_bookname.Name = "com_bookname"
        Me.com_bookname.Size = New System.Drawing.Size(170, 21)
        Me.com_bookname.TabIndex = 43
        Me.com_bookname.ValueMember = "Book Name"
        '
        'BooksTableBindingSource1
        '
        Me.BooksTableBindingSource1.DataMember = "BooksTable"
        Me.BooksTableBindingSource1.DataSource = Me.AssistantDS
        '
        'AssistantDS
        '
        Me.AssistantDS.DataSetName = "AssistantDS"
        Me.AssistantDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'com_location
        '
        Me.com_location.DataSource = Me.BooksTableBindingSource2
        Me.com_location.DisplayMember = "Location"
        Me.com_location.Enabled = False
        Me.com_location.FormattingEnabled = True
        Me.com_location.Location = New System.Drawing.Point(100, 71)
        Me.com_location.Name = "com_location"
        Me.com_location.Size = New System.Drawing.Size(170, 21)
        Me.com_location.TabIndex = 42
        Me.com_location.ValueMember = "Location"
        '
        'BooksTableBindingSource2
        '
        Me.BooksTableBindingSource2.DataMember = "BooksTable"
        Me.BooksTableBindingSource2.DataSource = Me.AssistantDS
        '
        'com_subject
        '
        Me.com_subject.DataSource = Me.BooksTableBindingSource
        Me.com_subject.DisplayMember = "Subject"
        Me.com_subject.Enabled = False
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(100, 19)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(170, 21)
        Me.com_subject.TabIndex = 40
        Me.com_subject.ValueMember = "Subject"
        '
        'BooksTableBindingSource
        '
        Me.BooksTableBindingSource.DataMember = "BooksTable"
        Me.BooksTableBindingSource.DataSource = Me.AssistantDS
        '
        'chk_bookname
        '
        Me.chk_bookname.AutoSize = True
        Me.chk_bookname.Location = New System.Drawing.Point(14, 48)
        Me.chk_bookname.Name = "chk_bookname"
        Me.chk_bookname.Size = New System.Drawing.Size(15, 14)
        Me.chk_bookname.TabIndex = 39
        Me.chk_bookname.UseVisualStyleBackColor = True
        '
        'chk_location
        '
        Me.chk_location.AutoSize = True
        Me.chk_location.Location = New System.Drawing.Point(14, 74)
        Me.chk_location.Name = "chk_location"
        Me.chk_location.Size = New System.Drawing.Size(15, 14)
        Me.chk_location.TabIndex = 38
        Me.chk_location.UseVisualStyleBackColor = True
        '
        'chk_subject
        '
        Me.chk_subject.AutoSize = True
        Me.chk_subject.Location = New System.Drawing.Point(14, 22)
        Me.chk_subject.Name = "chk_subject"
        Me.chk_subject.Size = New System.Drawing.Size(15, 14)
        Me.chk_subject.TabIndex = 36
        Me.chk_subject.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(14, 168)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(256, 31)
        Me.btn_cancel.TabIndex = 35
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_filter
        '
        Me.btn_filter.Image = CType(resources.GetObject("btn_filter.Image"), System.Drawing.Image)
        Me.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_filter.Location = New System.Drawing.Point(14, 131)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(256, 31)
        Me.btn_filter.TabIndex = 34
        Me.btn_filter.Text = "Filter Subjects"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Location:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Book Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Subject:"
        '
        'BooksTableTableAdapter
        '
        Me.BooksTableTableAdapter.ClearBeforeFill = True
        '
        'BooksTableBindingSource3
        '
        Me.BooksTableBindingSource3.DataMember = "BooksTable"
        Me.BooksTableBindingSource3.DataSource = Me.AssistantDS
        '
        'com_notes
        '
        Me.com_notes.DataSource = Me.BooksTableBindingSource3
        Me.com_notes.DisplayMember = "Notes"
        Me.com_notes.Enabled = False
        Me.com_notes.FormattingEnabled = True
        Me.com_notes.Location = New System.Drawing.Point(100, 98)
        Me.com_notes.Name = "com_notes"
        Me.com_notes.Size = New System.Drawing.Size(170, 21)
        Me.com_notes.TabIndex = 46
        Me.com_notes.ValueMember = "Notes"
        '
        'chk_notes
        '
        Me.chk_notes.AutoSize = True
        Me.chk_notes.Location = New System.Drawing.Point(14, 100)
        Me.chk_notes.Name = "chk_notes"
        Me.chk_notes.Size = New System.Drawing.Size(15, 14)
        Me.chk_notes.TabIndex = 45
        Me.chk_notes.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Notes:"
        '
        'FilterBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 211)
        Me.Controls.Add(Me.com_notes)
        Me.Controls.Add(Me.chk_notes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.com_bookname)
        Me.Controls.Add(Me.com_location)
        Me.Controls.Add(Me.com_subject)
        Me.Controls.Add(Me.chk_bookname)
        Me.Controls.Add(Me.chk_location)
        Me.Controls.Add(Me.chk_subject)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FilterBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter Books"
        CType(Me.BooksTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksTableBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksTableBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents com_bookname As ComboBox
    Friend WithEvents com_location As ComboBox
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents chk_bookname As CheckBox
    Friend WithEvents chk_location As CheckBox
    Friend WithEvents chk_subject As CheckBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_filter As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AssistantDS As AssistantDS
    Friend WithEvents BooksTableBindingSource As BindingSource
    Friend WithEvents BooksTableTableAdapter As AssistantDSTableAdapters.BooksTableTableAdapter
    Friend WithEvents BooksTableBindingSource1 As BindingSource
    Friend WithEvents BooksTableBindingSource2 As BindingSource
    Friend WithEvents BooksTableBindingSource3 As BindingSource
    Friend WithEvents com_notes As ComboBox
    Friend WithEvents chk_notes As CheckBox
    Friend WithEvents Label4 As Label
End Class
