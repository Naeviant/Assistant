<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToDosFilter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToDosFilter))
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.date_datetime = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToDosTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.ToDosTableAdapter()
        Me.SuspendLayout()
        '
        'btn_filter
        '
        Me.btn_filter.Location = New System.Drawing.Point(153, 40)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(120, 23)
        Me.btn_filter.TabIndex = 14
        Me.btn_filter.Text = "Filter"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(21, 40)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(120, 23)
        Me.btn_close.TabIndex = 12
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'date_datetime
        '
        Me.date_datetime.CustomFormat = "ddd dd/MM/yyyy"
        Me.date_datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_datetime.Location = New System.Drawing.Point(86, 14)
        Me.date_datetime.Name = "date_datetime"
        Me.date_datetime.ShowCheckBox = True
        Me.date_datetime.Size = New System.Drawing.Size(187, 20)
        Me.date_datetime.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Date/Time: "
        '
        'ToDosTableAdapter
        '
        Me.ToDosTableAdapter.ClearBeforeFill = True
        '
        'ToDosFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 75)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.date_datetime)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ToDosFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant: Filter ToDos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_filter As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents date_datetime As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents ToDosTableAdapter As AssistantDBDataSetTableAdapters.ToDosTableAdapter
End Class
