<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToDosEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToDosEdit))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date_datetime = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.ToDosTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.ToDosTableAdapter()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date/Time: "
        '
        'date_datetime
        '
        Me.date_datetime.CustomFormat = "ddd dd/MM/yyyy HH:mm"
        Me.date_datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_datetime.Location = New System.Drawing.Point(81, 10)
        Me.date_datetime.Name = "date_datetime"
        Me.date_datetime.Size = New System.Drawing.Size(158, 20)
        Me.date_datetime.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description:"
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(81, 33)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_description.Size = New System.Drawing.Size(158, 60)
        Me.txt_description.TabIndex = 3
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(16, 109)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(223, 23)
        Me.btn_close.TabIndex = 4
        Me.btn_close.Text = "Cancel"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(16, 138)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(223, 23)
        Me.btn_clear.TabIndex = 5
        Me.btn_clear.Text = "Reset Fields"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(16, 167)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(223, 23)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(16, 79)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 7
        Me.lbl_id.Text = "ID"
        Me.lbl_id.Visible = False
        '
        'ToDosTableAdapter
        '
        Me.ToDosTableAdapter.ClearBeforeFill = True
        '
        'ToDosEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 208)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.date_datetime)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ToDosEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant: ToDo Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents date_datetime As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_description As TextBox
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents ToDosTableAdapter As AssistantDBDataSetTableAdapters.ToDosTableAdapter
End Class
