<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterEvents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterEvents))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.com_event = New System.Windows.Forms.ComboBox()
        Me.EventsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssistantDS = New Assistant.AssistantDS()
        Me.com_location = New System.Windows.Forms.ComboBox()
        Me.EventsTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.com_date = New System.Windows.Forms.ComboBox()
        Me.EventsTableBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.com_starttime = New System.Windows.Forms.ComboBox()
        Me.EventsTableBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.com_endtime = New System.Windows.Forms.ComboBox()
        Me.EventsTableBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.com_notes = New System.Windows.Forms.ComboBox()
        Me.EventsTableBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EventsTableTableAdapter = New Assistant.AssistantDSTableAdapters.EventsTableTableAdapter()
        Me.chk_endtime = New System.Windows.Forms.CheckBox()
        Me.chk_starttime = New System.Windows.Forms.CheckBox()
        Me.chk_date = New System.Windows.Forms.CheckBox()
        Me.chk_notes = New System.Windows.Forms.CheckBox()
        Me.chk_location = New System.Windows.Forms.CheckBox()
        Me.chk_event = New System.Windows.Forms.CheckBox()
        CType(Me.EventsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventsTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventsTableBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventsTableBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventsTableBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventsTableBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(318, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "End Time:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(318, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Start Time:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(318, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Notes:"
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.Location = New System.Drawing.Point(297, 98)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(256, 31)
        Me.btn_cancel.TabIndex = 57
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_filter
        '
        Me.btn_filter.Image = CType(resources.GetObject("btn_filter.Image"), System.Drawing.Image)
        Me.btn_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_filter.Location = New System.Drawing.Point(28, 98)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(256, 31)
        Me.btn_filter.TabIndex = 55
        Me.btn_filter.Text = "Filter Events"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Location:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Event:"
        '
        'com_event
        '
        Me.com_event.DataSource = Me.EventsTableBindingSource
        Me.com_event.DisplayMember = "Event"
        Me.com_event.Enabled = False
        Me.com_event.FormattingEnabled = True
        Me.com_event.Location = New System.Drawing.Point(110, 18)
        Me.com_event.Name = "com_event"
        Me.com_event.Size = New System.Drawing.Size(174, 21)
        Me.com_event.TabIndex = 67
        Me.com_event.ValueMember = "Event"
        '
        'EventsTableBindingSource
        '
        Me.EventsTableBindingSource.DataMember = "EventsTable"
        Me.EventsTableBindingSource.DataSource = Me.AssistantDS
        '
        'AssistantDS
        '
        Me.AssistantDS.DataSetName = "AssistantDS"
        Me.AssistantDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'com_location
        '
        Me.com_location.DataSource = Me.EventsTableBindingSource1
        Me.com_location.DisplayMember = "Location"
        Me.com_location.Enabled = False
        Me.com_location.FormattingEnabled = True
        Me.com_location.Location = New System.Drawing.Point(110, 44)
        Me.com_location.Name = "com_location"
        Me.com_location.Size = New System.Drawing.Size(174, 21)
        Me.com_location.TabIndex = 68
        Me.com_location.ValueMember = "Location"
        '
        'EventsTableBindingSource1
        '
        Me.EventsTableBindingSource1.DataMember = "EventsTable"
        Me.EventsTableBindingSource1.DataSource = Me.AssistantDS
        '
        'com_date
        '
        Me.com_date.DataSource = Me.EventsTableBindingSource2
        Me.com_date.DisplayMember = "Day"
        Me.com_date.Enabled = False
        Me.com_date.FormattingEnabled = True
        Me.com_date.Location = New System.Drawing.Point(110, 70)
        Me.com_date.Name = "com_date"
        Me.com_date.Size = New System.Drawing.Size(174, 21)
        Me.com_date.TabIndex = 69
        Me.com_date.ValueMember = "Day"
        '
        'EventsTableBindingSource2
        '
        Me.EventsTableBindingSource2.DataMember = "EventsTable"
        Me.EventsTableBindingSource2.DataSource = Me.AssistantDS
        '
        'com_starttime
        '
        Me.com_starttime.DataSource = Me.EventsTableBindingSource3
        Me.com_starttime.DisplayMember = "Start Time"
        Me.com_starttime.Enabled = False
        Me.com_starttime.FormattingEnabled = True
        Me.com_starttime.Location = New System.Drawing.Point(379, 18)
        Me.com_starttime.Name = "com_starttime"
        Me.com_starttime.Size = New System.Drawing.Size(174, 21)
        Me.com_starttime.TabIndex = 70
        Me.com_starttime.ValueMember = "Start Time"
        '
        'EventsTableBindingSource3
        '
        Me.EventsTableBindingSource3.DataMember = "EventsTable"
        Me.EventsTableBindingSource3.DataSource = Me.AssistantDS
        '
        'com_endtime
        '
        Me.com_endtime.DataSource = Me.EventsTableBindingSource4
        Me.com_endtime.DisplayMember = "End Time"
        Me.com_endtime.Enabled = False
        Me.com_endtime.FormattingEnabled = True
        Me.com_endtime.Location = New System.Drawing.Point(379, 44)
        Me.com_endtime.Name = "com_endtime"
        Me.com_endtime.Size = New System.Drawing.Size(174, 21)
        Me.com_endtime.TabIndex = 71
        Me.com_endtime.ValueMember = "End Time"
        '
        'EventsTableBindingSource4
        '
        Me.EventsTableBindingSource4.DataMember = "EventsTable"
        Me.EventsTableBindingSource4.DataSource = Me.AssistantDS
        '
        'com_notes
        '
        Me.com_notes.DataSource = Me.EventsTableBindingSource5
        Me.com_notes.DisplayMember = "Notes"
        Me.com_notes.Enabled = False
        Me.com_notes.FormattingEnabled = True
        Me.com_notes.Location = New System.Drawing.Point(379, 70)
        Me.com_notes.Name = "com_notes"
        Me.com_notes.Size = New System.Drawing.Size(174, 21)
        Me.com_notes.TabIndex = 72
        Me.com_notes.ValueMember = "Notes"
        '
        'EventsTableBindingSource5
        '
        Me.EventsTableBindingSource5.DataMember = "EventsTable"
        Me.EventsTableBindingSource5.DataSource = Me.AssistantDS
        '
        'EventsTableTableAdapter
        '
        Me.EventsTableTableAdapter.ClearBeforeFill = True
        '
        'chk_endtime
        '
        Me.chk_endtime.AutoSize = True
        Me.chk_endtime.Location = New System.Drawing.Point(300, 48)
        Me.chk_endtime.Name = "chk_endtime"
        Me.chk_endtime.Size = New System.Drawing.Size(15, 14)
        Me.chk_endtime.TabIndex = 73
        Me.chk_endtime.UseVisualStyleBackColor = True
        '
        'chk_starttime
        '
        Me.chk_starttime.AutoSize = True
        Me.chk_starttime.Location = New System.Drawing.Point(300, 21)
        Me.chk_starttime.Name = "chk_starttime"
        Me.chk_starttime.Size = New System.Drawing.Size(15, 14)
        Me.chk_starttime.TabIndex = 74
        Me.chk_starttime.UseVisualStyleBackColor = True
        '
        'chk_date
        '
        Me.chk_date.AutoSize = True
        Me.chk_date.Location = New System.Drawing.Point(28, 73)
        Me.chk_date.Name = "chk_date"
        Me.chk_date.Size = New System.Drawing.Size(15, 14)
        Me.chk_date.TabIndex = 75
        Me.chk_date.UseVisualStyleBackColor = True
        '
        'chk_notes
        '
        Me.chk_notes.AutoSize = True
        Me.chk_notes.Location = New System.Drawing.Point(300, 74)
        Me.chk_notes.Name = "chk_notes"
        Me.chk_notes.Size = New System.Drawing.Size(15, 14)
        Me.chk_notes.TabIndex = 76
        Me.chk_notes.UseVisualStyleBackColor = True
        '
        'chk_location
        '
        Me.chk_location.AutoSize = True
        Me.chk_location.Location = New System.Drawing.Point(28, 47)
        Me.chk_location.Name = "chk_location"
        Me.chk_location.Size = New System.Drawing.Size(15, 14)
        Me.chk_location.TabIndex = 78
        Me.chk_location.UseVisualStyleBackColor = True
        '
        'chk_event
        '
        Me.chk_event.AutoSize = True
        Me.chk_event.Location = New System.Drawing.Point(28, 21)
        Me.chk_event.Name = "chk_event"
        Me.chk_event.Size = New System.Drawing.Size(15, 14)
        Me.chk_event.TabIndex = 79
        Me.chk_event.UseVisualStyleBackColor = True
        '
        'FilterEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 141)
        Me.Controls.Add(Me.chk_event)
        Me.Controls.Add(Me.chk_location)
        Me.Controls.Add(Me.chk_notes)
        Me.Controls.Add(Me.chk_date)
        Me.Controls.Add(Me.chk_starttime)
        Me.Controls.Add(Me.chk_endtime)
        Me.Controls.Add(Me.com_notes)
        Me.Controls.Add(Me.com_endtime)
        Me.Controls.Add(Me.com_starttime)
        Me.Controls.Add(Me.com_date)
        Me.Controls.Add(Me.com_location)
        Me.Controls.Add(Me.com_event)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_filter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FilterEvents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter Events"
        CType(Me.EventsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventsTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventsTableBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventsTableBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventsTableBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventsTableBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_filter As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents com_event As ComboBox
    Friend WithEvents com_location As ComboBox
    Friend WithEvents com_date As ComboBox
    Friend WithEvents com_starttime As ComboBox
    Friend WithEvents com_endtime As ComboBox
    Friend WithEvents com_notes As ComboBox
    Friend WithEvents AssistantDS As AssistantDS
    Friend WithEvents EventsTableBindingSource As BindingSource
    Friend WithEvents EventsTableTableAdapter As AssistantDSTableAdapters.EventsTableTableAdapter
    Friend WithEvents EventsTableBindingSource1 As BindingSource
    Friend WithEvents EventsTableBindingSource2 As BindingSource
    Friend WithEvents EventsTableBindingSource3 As BindingSource
    Friend WithEvents EventsTableBindingSource4 As BindingSource
    Friend WithEvents EventsTableBindingSource5 As BindingSource
    Friend WithEvents chk_endtime As CheckBox
    Friend WithEvents chk_starttime As CheckBox
    Friend WithEvents chk_date As CheckBox
    Friend WithEvents chk_notes As CheckBox
    Friend WithEvents chk_location As CheckBox
    Friend WithEvents chk_event As CheckBox
End Class
