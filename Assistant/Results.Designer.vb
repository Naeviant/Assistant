<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Results
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Results))
        Me.tool_results = New System.Windows.Forms.ToolStrip()
        Me.btn_addresult = New System.Windows.Forms.ToolStripButton()
        Me.btn_editresult = New System.Windows.Forms.ToolStripButton()
        Me.btn_archiveresult = New System.Windows.Forms.ToolStripButton()
        Me.btn_deleteresult = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_filterresults = New System.Windows.Forms.ToolStripButton()
        Me.btn_unfilterresults = New System.Windows.Forms.ToolStripButton()
        Me.btn_showarchived = New System.Windows.Forms.ToolStripButton()
        Me.btn_hidearchived = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_export = New System.Windows.Forms.ToolStripButton()
        Me.data_results = New System.Windows.Forms.DataGridView()
        Me.ResultsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.ResultsTableAdapter()
        Me.tool_results.SuspendLayout()
        CType(Me.data_results, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tool_results
        '
        Me.tool_results.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tool_results.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_addresult, Me.btn_editresult, Me.btn_archiveresult, Me.btn_deleteresult, Me.ToolStripSeparator1, Me.btn_filterresults, Me.btn_unfilterresults, Me.btn_showarchived, Me.btn_hidearchived, Me.ToolStripSeparator2, Me.btn_export})
        Me.tool_results.Location = New System.Drawing.Point(0, 0)
        Me.tool_results.Name = "tool_results"
        Me.tool_results.Size = New System.Drawing.Size(800, 25)
        Me.tool_results.TabIndex = 1
        Me.tool_results.Text = "ToolStrip1"
        '
        'btn_addresult
        '
        Me.btn_addresult.Image = CType(resources.GetObject("btn_addresult.Image"), System.Drawing.Image)
        Me.btn_addresult.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_addresult.Name = "btn_addresult"
        Me.btn_addresult.Size = New System.Drawing.Size(84, 22)
        Me.btn_addresult.Text = "Add Result"
        '
        'btn_editresult
        '
        Me.btn_editresult.Image = CType(resources.GetObject("btn_editresult.Image"), System.Drawing.Image)
        Me.btn_editresult.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_editresult.Name = "btn_editresult"
        Me.btn_editresult.Size = New System.Drawing.Size(82, 22)
        Me.btn_editresult.Text = "Edit Result"
        '
        'btn_archiveresult
        '
        Me.btn_archiveresult.Image = CType(resources.GetObject("btn_archiveresult.Image"), System.Drawing.Image)
        Me.btn_archiveresult.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_archiveresult.Name = "btn_archiveresult"
        Me.btn_archiveresult.Size = New System.Drawing.Size(102, 22)
        Me.btn_archiveresult.Text = "Archive Result"
        '
        'btn_deleteresult
        '
        Me.btn_deleteresult.Image = CType(resources.GetObject("btn_deleteresult.Image"), System.Drawing.Image)
        Me.btn_deleteresult.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_deleteresult.Name = "btn_deleteresult"
        Me.btn_deleteresult.Size = New System.Drawing.Size(95, 22)
        Me.btn_deleteresult.Text = "Delete Result"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btn_filterresults
        '
        Me.btn_filterresults.Image = CType(resources.GetObject("btn_filterresults.Image"), System.Drawing.Image)
        Me.btn_filterresults.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_filterresults.Name = "btn_filterresults"
        Me.btn_filterresults.Size = New System.Drawing.Size(78, 22)
        Me.btn_filterresults.Text = "Add Filter"
        '
        'btn_unfilterresults
        '
        Me.btn_unfilterresults.Image = CType(resources.GetObject("btn_unfilterresults.Image"), System.Drawing.Image)
        Me.btn_unfilterresults.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_unfilterresults.Name = "btn_unfilterresults"
        Me.btn_unfilterresults.Size = New System.Drawing.Size(99, 22)
        Me.btn_unfilterresults.Text = "Remove Filter"
        Me.btn_unfilterresults.Visible = False
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
        Me.btn_export.Size = New System.Drawing.Size(101, 22)
        Me.btn_export.Text = "Export Results"
        '
        'data_results
        '
        Me.data_results.AllowUserToAddRows = False
        Me.data_results.AllowUserToDeleteRows = False
        Me.data_results.AllowUserToResizeColumns = False
        Me.data_results.AllowUserToResizeRows = False
        Me.data_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_results.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_results.Location = New System.Drawing.Point(0, 25)
        Me.data_results.MultiSelect = False
        Me.data_results.Name = "data_results"
        Me.data_results.ReadOnly = True
        Me.data_results.RowHeadersVisible = False
        Me.data_results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_results.Size = New System.Drawing.Size(800, 425)
        Me.data_results.TabIndex = 2
        '
        'ResultsTableAdapter
        '
        Me.ResultsTableAdapter.ClearBeforeFill = True
        '
        'Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.data_results)
        Me.Controls.Add(Me.tool_results)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Results"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant: Results"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tool_results.ResumeLayout(False)
        Me.tool_results.PerformLayout()
        CType(Me.data_results, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tool_results As ToolStrip
    Friend WithEvents btn_addresult As ToolStripButton
    Friend WithEvents btn_editresult As ToolStripButton
    Friend WithEvents btn_archiveresult As ToolStripButton
    Friend WithEvents btn_deleteresult As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btn_filterresults As ToolStripButton
    Friend WithEvents btn_unfilterresults As ToolStripButton
    Friend WithEvents btn_showarchived As ToolStripButton
    Friend WithEvents btn_hidearchived As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btn_export As ToolStripButton
    Friend WithEvents data_results As DataGridView
    Friend WithEvents ResultsTableAdapter As AssistantDBDataSetTableAdapters.ResultsTableAdapter
End Class
