<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Landing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Landing))
        Me.tsr_navigation = New System.Windows.Forms.ToolStrip()
        Me.btn_assignments = New System.Windows.Forms.ToolStripButton()
        Me.btn_exams = New System.Windows.Forms.ToolStripButton()
        Me.btn_results = New System.Windows.Forms.ToolStripButton()
        Me.btn_todos = New System.Windows.Forms.ToolStripButton()
        Me.btn_settings = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_refresh = New System.Windows.Forms.ToolStripButton()
        Me.AssignmentsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.AssignmentsTableAdapter()
        Me.ExamsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.ExamsTableAdapter()
        Me.ResultsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.ResultsTableAdapter()
        Me.ToDosTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.ToDosTableAdapter()
        Me.grp_assignments = New System.Windows.Forms.GroupBox()
        Me.grp_exams = New System.Windows.Forms.GroupBox()
        Me.grp_results = New System.Windows.Forms.GroupBox()
        Me.grp_todos = New System.Windows.Forms.GroupBox()
        Me.grp_overdue = New System.Windows.Forms.GroupBox()
        Me.tsr_navigation.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsr_navigation
        '
        Me.tsr_navigation.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsr_navigation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_assignments, Me.btn_exams, Me.btn_results, Me.btn_todos, Me.btn_settings, Me.ToolStripSeparator1, Me.btn_refresh})
        Me.tsr_navigation.Location = New System.Drawing.Point(0, 0)
        Me.tsr_navigation.Name = "tsr_navigation"
        Me.tsr_navigation.Size = New System.Drawing.Size(836, 25)
        Me.tsr_navigation.TabIndex = 0
        Me.tsr_navigation.Text = "ToolStrip1"
        '
        'btn_assignments
        '
        Me.btn_assignments.Image = CType(resources.GetObject("btn_assignments.Image"), System.Drawing.Image)
        Me.btn_assignments.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_assignments.Name = "btn_assignments"
        Me.btn_assignments.Size = New System.Drawing.Size(95, 22)
        Me.btn_assignments.Text = "Assignments"
        '
        'btn_exams
        '
        Me.btn_exams.Image = CType(resources.GetObject("btn_exams.Image"), System.Drawing.Image)
        Me.btn_exams.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_exams.Name = "btn_exams"
        Me.btn_exams.Size = New System.Drawing.Size(61, 22)
        Me.btn_exams.Text = "Exams"
        '
        'btn_results
        '
        Me.btn_results.Image = CType(resources.GetObject("btn_results.Image"), System.Drawing.Image)
        Me.btn_results.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_results.Name = "btn_results"
        Me.btn_results.Size = New System.Drawing.Size(64, 22)
        Me.btn_results.Text = "Results"
        Me.btn_results.ToolTipText = "Results"
        '
        'btn_todos
        '
        Me.btn_todos.Image = CType(resources.GetObject("btn_todos.Image"), System.Drawing.Image)
        Me.btn_todos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_todos.Name = "btn_todos"
        Me.btn_todos.Size = New System.Drawing.Size(59, 22)
        Me.btn_todos.Text = "ToDos"
        '
        'btn_settings
        '
        Me.btn_settings.Image = CType(resources.GetObject("btn_settings.Image"), System.Drawing.Image)
        Me.btn_settings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_settings.Name = "btn_settings"
        Me.btn_settings.Size = New System.Drawing.Size(69, 22)
        Me.btn_settings.Text = "Settings"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btn_refresh
        '
        Me.btn_refresh.Image = CType(resources.GetObject("btn_refresh.Image"), System.Drawing.Image)
        Me.btn_refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(66, 22)
        Me.btn_refresh.Text = "Refresh"
        '
        'AssignmentsTableAdapter
        '
        Me.AssignmentsTableAdapter.ClearBeforeFill = True
        '
        'ExamsTableAdapter
        '
        Me.ExamsTableAdapter.ClearBeforeFill = True
        '
        'ResultsTableAdapter
        '
        Me.ResultsTableAdapter.ClearBeforeFill = True
        '
        'ToDosTableAdapter
        '
        Me.ToDosTableAdapter.ClearBeforeFill = True
        '
        'grp_assignments
        '
        Me.grp_assignments.Location = New System.Drawing.Point(12, 28)
        Me.grp_assignments.Name = "grp_assignments"
        Me.grp_assignments.Size = New System.Drawing.Size(400, 100)
        Me.grp_assignments.TabIndex = 1
        Me.grp_assignments.TabStop = False
        Me.grp_assignments.Text = "Upcoming Assignments Due"
        '
        'grp_exams
        '
        Me.grp_exams.Location = New System.Drawing.Point(12, 134)
        Me.grp_exams.Name = "grp_exams"
        Me.grp_exams.Size = New System.Drawing.Size(400, 100)
        Me.grp_exams.TabIndex = 2
        Me.grp_exams.TabStop = False
        Me.grp_exams.Text = "Upcoming Exams"
        '
        'grp_results
        '
        Me.grp_results.Location = New System.Drawing.Point(418, 134)
        Me.grp_results.Name = "grp_results"
        Me.grp_results.Size = New System.Drawing.Size(400, 100)
        Me.grp_results.TabIndex = 4
        Me.grp_results.TabStop = False
        Me.grp_results.Text = "Recent Results"
        '
        'grp_todos
        '
        Me.grp_todos.Location = New System.Drawing.Point(12, 240)
        Me.grp_todos.Name = "grp_todos"
        Me.grp_todos.Size = New System.Drawing.Size(806, 100)
        Me.grp_todos.TabIndex = 3
        Me.grp_todos.TabStop = False
        Me.grp_todos.Text = "Upcoming ToDos"
        '
        'grp_overdue
        '
        Me.grp_overdue.Location = New System.Drawing.Point(418, 28)
        Me.grp_overdue.Name = "grp_overdue"
        Me.grp_overdue.Size = New System.Drawing.Size(400, 100)
        Me.grp_overdue.TabIndex = 5
        Me.grp_overdue.TabStop = False
        Me.grp_overdue.Text = "Overdue Assignments"
        '
        'Landing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 357)
        Me.Controls.Add(Me.grp_overdue)
        Me.Controls.Add(Me.grp_results)
        Me.Controls.Add(Me.grp_todos)
        Me.Controls.Add(Me.grp_exams)
        Me.Controls.Add(Me.grp_assignments)
        Me.Controls.Add(Me.tsr_navigation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Landing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant"
        Me.tsr_navigation.ResumeLayout(False)
        Me.tsr_navigation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsr_navigation As ToolStrip
    Friend WithEvents btn_assignments As ToolStripButton
    Friend WithEvents btn_exams As ToolStripButton
    Friend WithEvents btn_results As ToolStripButton
    Friend WithEvents btn_todos As ToolStripButton
    Friend WithEvents btn_settings As ToolStripButton
    Friend WithEvents AssignmentsTableAdapter As AssistantDBDataSetTableAdapters.AssignmentsTableAdapter
    Friend WithEvents ExamsTableAdapter As AssistantDBDataSetTableAdapters.ExamsTableAdapter
    Friend WithEvents ResultsTableAdapter As AssistantDBDataSetTableAdapters.ResultsTableAdapter
    Friend WithEvents ToDosTableAdapter As AssistantDBDataSetTableAdapters.ToDosTableAdapter
    Friend WithEvents grp_assignments As GroupBox
    Friend WithEvents grp_exams As GroupBox
    Friend WithEvents grp_results As GroupBox
    Friend WithEvents grp_todos As GroupBox
    Friend WithEvents grp_overdue As GroupBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btn_refresh As ToolStripButton
End Class
