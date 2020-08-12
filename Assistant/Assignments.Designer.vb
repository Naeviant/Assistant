<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Assignments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Assignments))
        Me.tool_assignments = New System.Windows.Forms.ToolStrip()
        Me.btn_addassignment = New System.Windows.Forms.ToolStripButton()
        Me.btn_editassignment = New System.Windows.Forms.ToolStripButton()
        Me.btn_archiveassignment = New System.Windows.Forms.ToolStripButton()
        Me.btn_deleteassignment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_filterassignments = New System.Windows.Forms.ToolStripButton()
        Me.btn_unfilterassignments = New System.Windows.Forms.ToolStripButton()
        Me.btn_showarchived = New System.Windows.Forms.ToolStripButton()
        Me.btn_hidearchived = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_export = New System.Windows.Forms.ToolStripButton()
        Me.data_assignments = New System.Windows.Forms.DataGridView()
        Me.AssignmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssistantDBDataSet = New Assistant.AssistantDBDataSet()
        Me.AssignmentsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.AssignmentsTableAdapter()
        Me.tool_assignments.SuspendLayout()
        CType(Me.data_assignments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssignmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistantDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tool_assignments
        '
        Me.tool_assignments.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tool_assignments.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_addassignment, Me.btn_editassignment, Me.btn_archiveassignment, Me.btn_deleteassignment, Me.ToolStripSeparator1, Me.btn_filterassignments, Me.btn_unfilterassignments, Me.btn_showarchived, Me.btn_hidearchived, Me.ToolStripSeparator2, Me.btn_export})
        Me.tool_assignments.Location = New System.Drawing.Point(0, 0)
        Me.tool_assignments.Name = "tool_assignments"
        Me.tool_assignments.Size = New System.Drawing.Size(884, 25)
        Me.tool_assignments.TabIndex = 0
        Me.tool_assignments.Text = "ToolStrip1"
        '
        'btn_addassignment
        '
        Me.btn_addassignment.Image = CType(resources.GetObject("btn_addassignment.Image"), System.Drawing.Image)
        Me.btn_addassignment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_addassignment.Name = "btn_addassignment"
        Me.btn_addassignment.Size = New System.Drawing.Size(115, 22)
        Me.btn_addassignment.Text = "Add Assignment"
        '
        'btn_editassignment
        '
        Me.btn_editassignment.Image = CType(resources.GetObject("btn_editassignment.Image"), System.Drawing.Image)
        Me.btn_editassignment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_editassignment.Name = "btn_editassignment"
        Me.btn_editassignment.Size = New System.Drawing.Size(113, 22)
        Me.btn_editassignment.Text = "Edit Assignment"
        '
        'btn_archiveassignment
        '
        Me.btn_archiveassignment.Image = CType(resources.GetObject("btn_archiveassignment.Image"), System.Drawing.Image)
        Me.btn_archiveassignment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_archiveassignment.Name = "btn_archiveassignment"
        Me.btn_archiveassignment.Size = New System.Drawing.Size(133, 22)
        Me.btn_archiveassignment.Text = "Archive Assignment"
        '
        'btn_deleteassignment
        '
        Me.btn_deleteassignment.Image = CType(resources.GetObject("btn_deleteassignment.Image"), System.Drawing.Image)
        Me.btn_deleteassignment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_deleteassignment.Name = "btn_deleteassignment"
        Me.btn_deleteassignment.Size = New System.Drawing.Size(126, 22)
        Me.btn_deleteassignment.Text = "Delete Assignment"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btn_filterassignments
        '
        Me.btn_filterassignments.Image = CType(resources.GetObject("btn_filterassignments.Image"), System.Drawing.Image)
        Me.btn_filterassignments.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_filterassignments.Name = "btn_filterassignments"
        Me.btn_filterassignments.Size = New System.Drawing.Size(78, 22)
        Me.btn_filterassignments.Text = "Add Filter"
        '
        'btn_unfilterassignments
        '
        Me.btn_unfilterassignments.Image = CType(resources.GetObject("btn_unfilterassignments.Image"), System.Drawing.Image)
        Me.btn_unfilterassignments.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_unfilterassignments.Name = "btn_unfilterassignments"
        Me.btn_unfilterassignments.Size = New System.Drawing.Size(99, 22)
        Me.btn_unfilterassignments.Text = "Remove Filter"
        Me.btn_unfilterassignments.Visible = False
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
        Me.btn_export.Size = New System.Drawing.Size(132, 22)
        Me.btn_export.Text = "Export Assignments"
        '
        'data_assignments
        '
        Me.data_assignments.AllowUserToAddRows = False
        Me.data_assignments.AllowUserToDeleteRows = False
        Me.data_assignments.AllowUserToResizeColumns = False
        Me.data_assignments.AllowUserToResizeRows = False
        Me.data_assignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_assignments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_assignments.Location = New System.Drawing.Point(0, 25)
        Me.data_assignments.MultiSelect = False
        Me.data_assignments.Name = "data_assignments"
        Me.data_assignments.ReadOnly = True
        Me.data_assignments.RowHeadersVisible = False
        Me.data_assignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_assignments.Size = New System.Drawing.Size(884, 436)
        Me.data_assignments.TabIndex = 1
        '
        'AssignmentsBindingSource
        '
        Me.AssignmentsBindingSource.DataMember = "Assignments"
        Me.AssignmentsBindingSource.DataSource = Me.AssistantDBDataSet
        '
        'AssistantDBDataSet
        '
        Me.AssistantDBDataSet.DataSetName = "AssistantDBDataSet"
        Me.AssistantDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AssignmentsTableAdapter
        '
        Me.AssignmentsTableAdapter.ClearBeforeFill = True
        '
        'Assignments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.data_assignments)
        Me.Controls.Add(Me.tool_assignments)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(900, 300)
        Me.Name = "Assignments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant: Assignments"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tool_assignments.ResumeLayout(False)
        Me.tool_assignments.PerformLayout()
        CType(Me.data_assignments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssignmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistantDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tool_assignments As ToolStrip
    Friend WithEvents btn_addassignment As ToolStripButton
    Friend WithEvents btn_editassignment As ToolStripButton
    Friend WithEvents btn_deleteassignment As ToolStripButton
    Friend WithEvents data_assignments As DataGridView
    Friend WithEvents AssistantDBDataSet As AssistantDBDataSet
    Friend WithEvents AssignmentsBindingSource As BindingSource
    Friend WithEvents AssignmentsTableAdapter As AssistantDBDataSetTableAdapters.AssignmentsTableAdapter
    Friend WithEvents btn_archiveassignment As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btn_filterassignments As ToolStripButton
    Friend WithEvents btn_unfilterassignments As ToolStripButton
    Friend WithEvents btn_showarchived As ToolStripButton
    Friend WithEvents btn_hidearchived As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btn_export As ToolStripButton
End Class
