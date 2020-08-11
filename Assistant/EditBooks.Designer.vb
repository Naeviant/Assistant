<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditBooks))
        Me.txt_notes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_full = New System.Windows.Forms.CheckBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_bookname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.com_subject = New System.Windows.Forms.ComboBox()
        Me.SubjectsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssistantDS = New Assistant.AssistantDS()
        Me.SubjectsTableTableAdapter = New Assistant.AssistantDSTableAdapters.SubjectsTableTableAdapter()
        CType(Me.SubjectsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_notes
        '
        Me.txt_notes.Location = New System.Drawing.Point(331, 16)
        Me.txt_notes.Multiline = True
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_notes.Size = New System.Drawing.Size(215, 94)
        Me.txt_notes.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(287, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Notes:"
        '
        'chk_full
        '
        Me.chk_full.AutoSize = True
        Me.chk_full.Location = New System.Drawing.Point(170, 96)
        Me.chk_full.Name = "chk_full"
        Me.chk_full.Size = New System.Drawing.Size(15, 14)
        Me.chk_full.TabIndex = 35
        Me.chk_full.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(290, 163)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(256, 31)
        Me.btn_cancel.TabIndex = 34
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(21, 163)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(256, 31)
        Me.btn_clear.TabIndex = 33
        Me.btn_clear.Text = "Clear Fields"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.Location = New System.Drawing.Point(21, 126)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(525, 31)
        Me.btn_edit.TabIndex = 32
        Me.btn_edit.Text = "Edit Book"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Full:"
        '
        'txt_location
        '
        Me.txt_location.Location = New System.Drawing.Point(85, 68)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(192, 20)
        Me.txt_location.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Location:"
        '
        'txt_bookname
        '
        Me.txt_bookname.Location = New System.Drawing.Point(85, 42)
        Me.txt_bookname.Name = "txt_bookname"
        Me.txt_bookname.Size = New System.Drawing.Size(192, 20)
        Me.txt_bookname.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Book Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Subject:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(237, 95)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 38
        Me.lbl_id.Text = "ID"
        Me.lbl_id.Visible = False
        '
        'com_subject
        '
        Me.com_subject.DataSource = Me.SubjectsTableBindingSource
        Me.com_subject.DisplayMember = "Subject"
        Me.com_subject.FormattingEnabled = True
        Me.com_subject.Location = New System.Drawing.Point(85, 16)
        Me.com_subject.Name = "com_subject"
        Me.com_subject.Size = New System.Drawing.Size(192, 21)
        Me.com_subject.TabIndex = 39
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
        'SubjectsTableTableAdapter
        '
        Me.SubjectsTableTableAdapter.ClearBeforeFill = True
        '
        'EditBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 211)
        Me.Controls.Add(Me.com_subject)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_notes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chk_full)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_bookname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EditBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Book"
        CType(Me.SubjectsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_notes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_full As CheckBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_location As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_bookname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents com_subject As ComboBox
    Friend WithEvents AssistantDS As AssistantDS
    Friend WithEvents SubjectsTableBindingSource As BindingSource
    Friend WithEvents SubjectsTableTableAdapter As AssistantDSTableAdapters.SubjectsTableTableAdapter
End Class
