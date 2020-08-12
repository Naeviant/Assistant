<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exams
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Exams))
        Me.tool_exams = New System.Windows.Forms.ToolStrip()
        Me.btn_addexam = New System.Windows.Forms.ToolStripButton()
        Me.btn_editexam = New System.Windows.Forms.ToolStripButton()
        Me.btn_archiveexam = New System.Windows.Forms.ToolStripButton()
        Me.btn_deleteexam = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_filterexams = New System.Windows.Forms.ToolStripButton()
        Me.btn_unfilterexams = New System.Windows.Forms.ToolStripButton()
        Me.btn_showarchived = New System.Windows.Forms.ToolStripButton()
        Me.btn_hidearchived = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_export = New System.Windows.Forms.ToolStripButton()
        Me.data_exams = New System.Windows.Forms.DataGridView()
        Me.ExamsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.ExamsTableAdapter()
        Me.tool_exams.SuspendLayout()
        CType(Me.data_exams, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tool_exams
        '
        Me.tool_exams.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tool_exams.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_addexam, Me.btn_editexam, Me.btn_archiveexam, Me.btn_deleteexam, Me.ToolStripSeparator1, Me.btn_filterexams, Me.btn_unfilterexams, Me.btn_showarchived, Me.btn_hidearchived, Me.ToolStripSeparator2, Me.btn_export})
        Me.tool_exams.Location = New System.Drawing.Point(0, 0)
        Me.tool_exams.Name = "tool_exams"
        Me.tool_exams.Size = New System.Drawing.Size(800, 25)
        Me.tool_exams.TabIndex = 1
        Me.tool_exams.Text = "ToolStrip1"
        '
        'btn_addexam
        '
        Me.btn_addexam.Image = CType(resources.GetObject("btn_addexam.Image"), System.Drawing.Image)
        Me.btn_addexam.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_addexam.Name = "btn_addexam"
        Me.btn_addexam.Size = New System.Drawing.Size(81, 22)
        Me.btn_addexam.Text = "Add Exam"
        '
        'btn_editexam
        '
        Me.btn_editexam.Image = CType(resources.GetObject("btn_editexam.Image"), System.Drawing.Image)
        Me.btn_editexam.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_editexam.Name = "btn_editexam"
        Me.btn_editexam.Size = New System.Drawing.Size(79, 22)
        Me.btn_editexam.Text = "Edit Exam"
        '
        'btn_archiveexam
        '
        Me.btn_archiveexam.Image = CType(resources.GetObject("btn_archiveexam.Image"), System.Drawing.Image)
        Me.btn_archiveexam.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_archiveexam.Name = "btn_archiveexam"
        Me.btn_archiveexam.Size = New System.Drawing.Size(99, 22)
        Me.btn_archiveexam.Text = "Archive Exam"
        '
        'btn_deleteexam
        '
        Me.btn_deleteexam.Image = CType(resources.GetObject("btn_deleteexam.Image"), System.Drawing.Image)
        Me.btn_deleteexam.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_deleteexam.Name = "btn_deleteexam"
        Me.btn_deleteexam.Size = New System.Drawing.Size(92, 22)
        Me.btn_deleteexam.Text = "Delete Exam"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btn_filterexams
        '
        Me.btn_filterexams.Image = CType(resources.GetObject("btn_filterexams.Image"), System.Drawing.Image)
        Me.btn_filterexams.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_filterexams.Name = "btn_filterexams"
        Me.btn_filterexams.Size = New System.Drawing.Size(78, 22)
        Me.btn_filterexams.Text = "Add Filter"
        '
        'btn_unfilterexams
        '
        Me.btn_unfilterexams.Image = CType(resources.GetObject("btn_unfilterexams.Image"), System.Drawing.Image)
        Me.btn_unfilterexams.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_unfilterexams.Name = "btn_unfilterexams"
        Me.btn_unfilterexams.Size = New System.Drawing.Size(99, 22)
        Me.btn_unfilterexams.Text = "Remove Filter"
        Me.btn_unfilterexams.Visible = False
        '
        'btn_showarchived
        '
        Me.btn_showarchived.Image = CType(resources.GetObject("btn_showarchived.Image"), System.Drawing.Image)
        Me.btn_showarchived.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_showarchived.Name = "btn_showarchived"
        Me.btn_showarchived.Size = New System.Drawing.Size(106, 22)
        Me.btn_showarchived.Text = "Show Archived"
        '
        'btn_hidearchived
        '
        Me.btn_hidearchived.Image = CType(resources.GetObject("btn_hidearchived.Image"), System.Drawing.Image)
        Me.btn_hidearchived.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_hidearchived.Name = "btn_hidearchived"
        Me.btn_hidearchived.Size = New System.Drawing.Size(102, 22)
        Me.btn_hidearchived.Text = "Hide Archived"
        Me.btn_hidearchived.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btn_export
        '
        Me.btn_export.Image = CType(resources.GetObject("btn_export.Image"), System.Drawing.Image)
        Me.btn_export.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(98, 22)
        Me.btn_export.Text = "Export Exams"
        '
        'data_exams
        '
        Me.data_exams.AllowUserToAddRows = False
        Me.data_exams.AllowUserToDeleteRows = False
        Me.data_exams.AllowUserToResizeColumns = False
        Me.data_exams.AllowUserToResizeRows = False
        Me.data_exams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_exams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_exams.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_exams.Location = New System.Drawing.Point(0, 25)
        Me.data_exams.MultiSelect = False
        Me.data_exams.Name = "data_exams"
        Me.data_exams.ReadOnly = True
        Me.data_exams.RowHeadersVisible = False
        Me.data_exams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_exams.Size = New System.Drawing.Size(800, 425)
        Me.data_exams.TabIndex = 2
        '
        'ExamsTableAdapter
        '
        Me.ExamsTableAdapter.ClearBeforeFill = True
        '
        'Exams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.data_exams)
        Me.Controls.Add(Me.tool_exams)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Exams"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assignment: Exams"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tool_exams.ResumeLayout(False)
        Me.tool_exams.PerformLayout()
        CType(Me.data_exams, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tool_exams As ToolStrip
    Friend WithEvents btn_addexam As ToolStripButton
    Friend WithEvents btn_editexam As ToolStripButton
    Friend WithEvents btn_archiveexam As ToolStripButton
    Friend WithEvents btn_deleteexam As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btn_filterexams As ToolStripButton
    Friend WithEvents btn_unfilterexams As ToolStripButton
    Friend WithEvents btn_showarchived As ToolStripButton
    Friend WithEvents btn_hidearchived As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btn_export As ToolStripButton
    Friend WithEvents data_exams As DataGridView
    Friend WithEvents ExamsTableAdapter As AssistantDBDataSetTableAdapters.ExamsTableAdapter
End Class
