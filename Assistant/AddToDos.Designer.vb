<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddToDos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddToDos))
        Me.date_time = New System.Windows.Forms.DateTimePicker()
        Me.date_date = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_notes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'date_time
        '
        Me.date_time.CustomFormat = "HH:mm"
        Me.date_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_time.Location = New System.Drawing.Point(92, 95)
        Me.date_time.Name = "date_time"
        Me.date_time.ShowUpDown = True
        Me.date_time.Size = New System.Drawing.Size(192, 20)
        Me.date_time.TabIndex = 65
        '
        'date_date
        '
        Me.date_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_date.Location = New System.Drawing.Point(92, 70)
        Me.date_date.Name = "date_date"
        Me.date_date.Size = New System.Drawing.Size(192, 20)
        Me.date_date.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Time:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 73)
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
        Me.txt_notes.Size = New System.Drawing.Size(215, 100)
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
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(567, 128)
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
        Me.btn_clear.Location = New System.Drawing.Point(297, 128)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(256, 31)
        Me.btn_clear.TabIndex = 56
        Me.btn_clear.Text = "Clear Fields"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(28, 128)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(256, 31)
        Me.btn_add.TabIndex = 55
        Me.btn_add.Text = "Add ToDo"
        Me.btn_add.UseVisualStyleBackColor = True
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
        'txt_title
        '
        Me.txt_title.Location = New System.Drawing.Point(92, 18)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(192, 20)
        Me.txt_title.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Title:"
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(363, 15)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_description.Size = New System.Drawing.Size(190, 100)
        Me.txt_description.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(294, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Description:"
        '
        'AddToDos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 171)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.date_time)
        Me.Controls.Add(Me.date_date)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_notes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_title)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AddToDos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add ToDo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents date_time As DateTimePicker
    Friend WithEvents date_date As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_notes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents txt_location As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_title As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_description As TextBox
    Friend WithEvents Label1 As Label
End Class
