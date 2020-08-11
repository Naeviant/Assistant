<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditEvents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditEvents))
        Me.date_endtime = New System.Windows.Forms.DateTimePicker()
        Me.date_starttime = New System.Windows.Forms.DateTimePicker()
        Me.date_date = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_notes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_attending = New System.Windows.Forms.CheckBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_event = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'date_endtime
        '
        Me.date_endtime.CustomFormat = "HH:mm"
        Me.date_endtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_endtime.Location = New System.Drawing.Point(361, 68)
        Me.date_endtime.Name = "date_endtime"
        Me.date_endtime.ShowUpDown = True
        Me.date_endtime.Size = New System.Drawing.Size(192, 20)
        Me.date_endtime.TabIndex = 66
        '
        'date_starttime
        '
        Me.date_starttime.CustomFormat = "HH:mm"
        Me.date_starttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_starttime.Location = New System.Drawing.Point(361, 43)
        Me.date_starttime.Name = "date_starttime"
        Me.date_starttime.ShowUpDown = True
        Me.date_starttime.Size = New System.Drawing.Size(192, 20)
        Me.date_starttime.TabIndex = 65
        '
        'date_date
        '
        Me.date_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_date.Location = New System.Drawing.Point(361, 18)
        Me.date_date.Name = "date_date"
        Me.date_date.Size = New System.Drawing.Size(192, 20)
        Me.date_date.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(294, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "End Time:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(294, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Start Time:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(294, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Date:"
        '
        'txt_notes
        '
        Me.txt_notes.Location = New System.Drawing.Point(608, 15)
        Me.txt_notes.Multiline = True
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_notes.Size = New System.Drawing.Size(215, 72)
        Me.txt_notes.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(564, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Notes:"
        '
        'chk_attending
        '
        Me.chk_attending.AutoSize = True
        Me.chk_attending.Location = New System.Drawing.Point(177, 73)
        Me.chk_attending.Name = "chk_attending"
        Me.chk_attending.Size = New System.Drawing.Size(15, 14)
        Me.chk_attending.TabIndex = 58
        Me.chk_attending.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(567, 104)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(256, 31)
        Me.btn_cancel.TabIndex = 57
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(297, 104)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(256, 31)
        Me.btn_clear.TabIndex = 56
        Me.btn_clear.Text = "Clear Fields"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit.Location = New System.Drawing.Point(28, 104)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(256, 31)
        Me.btn_edit.TabIndex = 55
        Me.btn_edit.Text = "Edit Event"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Attending:"
        '
        'txt_location
        '
        Me.txt_location.Location = New System.Drawing.Point(92, 44)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(192, 20)
        Me.txt_location.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Location:"
        '
        'txt_event
        '
        Me.txt_event.Location = New System.Drawing.Point(92, 18)
        Me.txt_event.Name = "txt_event"
        Me.txt_event.Size = New System.Drawing.Size(192, 20)
        Me.txt_event.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Event:"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(89, 71)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 67
        Me.lbl_id.Text = "ID"
        Me.lbl_id.Visible = False
        '
        'EditEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 151)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.date_endtime)
        Me.Controls.Add(Me.date_starttime)
        Me.Controls.Add(Me.date_date)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_notes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chk_attending)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_event)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EditEvents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Event"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents date_endtime As DateTimePicker
    Friend WithEvents date_starttime As DateTimePicker
    Friend WithEvents date_date As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_notes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_attending As CheckBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_location As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_event As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_id As Label
End Class
