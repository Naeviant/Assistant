<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToDos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToDos))
        Me.tool_todos = New System.Windows.Forms.ToolStrip()
        Me.btn_addtodo = New System.Windows.Forms.ToolStripButton()
        Me.btn_edittodo = New System.Windows.Forms.ToolStripButton()
        Me.btn_deletetodo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_filtertodos = New System.Windows.Forms.ToolStripButton()
        Me.btn_unfiltertodos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_export = New System.Windows.Forms.ToolStripButton()
        Me.data_todos = New System.Windows.Forms.DataGridView()
        Me.ToDosTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.ToDosTableAdapter()
        Me.tool_todos.SuspendLayout()
        CType(Me.data_todos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tool_todos
        '
        Me.tool_todos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tool_todos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_addtodo, Me.btn_edittodo, Me.btn_deletetodo, Me.ToolStripSeparator1, Me.btn_filtertodos, Me.btn_unfiltertodos, Me.ToolStripSeparator2, Me.btn_export})
        Me.tool_todos.Location = New System.Drawing.Point(0, 0)
        Me.tool_todos.Name = "tool_todos"
        Me.tool_todos.Size = New System.Drawing.Size(800, 25)
        Me.tool_todos.TabIndex = 2
        Me.tool_todos.Text = "ToolStrip1"
        '
        'btn_addtodo
        '
        Me.btn_addtodo.Image = CType(resources.GetObject("btn_addtodo.Image"), System.Drawing.Image)
        Me.btn_addtodo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_addtodo.Name = "btn_addtodo"
        Me.btn_addtodo.Size = New System.Drawing.Size(79, 22)
        Me.btn_addtodo.Text = "Add ToDo"
        '
        'btn_edittodo
        '
        Me.btn_edittodo.Image = CType(resources.GetObject("btn_edittodo.Image"), System.Drawing.Image)
        Me.btn_edittodo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_edittodo.Name = "btn_edittodo"
        Me.btn_edittodo.Size = New System.Drawing.Size(77, 22)
        Me.btn_edittodo.Text = "Edit ToDo"
        '
        'btn_deletetodo
        '
        Me.btn_deletetodo.Image = CType(resources.GetObject("btn_deletetodo.Image"), System.Drawing.Image)
        Me.btn_deletetodo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_deletetodo.Name = "btn_deletetodo"
        Me.btn_deletetodo.Size = New System.Drawing.Size(90, 22)
        Me.btn_deletetodo.Text = "Delete ToDo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btn_filtertodos
        '
        Me.btn_filtertodos.Image = CType(resources.GetObject("btn_filtertodos.Image"), System.Drawing.Image)
        Me.btn_filtertodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_filtertodos.Name = "btn_filtertodos"
        Me.btn_filtertodos.Size = New System.Drawing.Size(78, 22)
        Me.btn_filtertodos.Text = "Add Filter"
        '
        'btn_unfiltertodos
        '
        Me.btn_unfiltertodos.Image = CType(resources.GetObject("btn_unfiltertodos.Image"), System.Drawing.Image)
        Me.btn_unfiltertodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_unfiltertodos.Name = "btn_unfiltertodos"
        Me.btn_unfiltertodos.Size = New System.Drawing.Size(99, 22)
        Me.btn_unfiltertodos.Text = "Remove Filter"
        Me.btn_unfiltertodos.Visible = False
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
        Me.btn_export.Size = New System.Drawing.Size(96, 22)
        Me.btn_export.Text = "Export ToDos"
        '
        'data_todos
        '
        Me.data_todos.AllowUserToAddRows = False
        Me.data_todos.AllowUserToDeleteRows = False
        Me.data_todos.AllowUserToResizeColumns = False
        Me.data_todos.AllowUserToResizeRows = False
        Me.data_todos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_todos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_todos.Location = New System.Drawing.Point(0, 25)
        Me.data_todos.MultiSelect = False
        Me.data_todos.Name = "data_todos"
        Me.data_todos.ReadOnly = True
        Me.data_todos.RowHeadersVisible = False
        Me.data_todos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_todos.Size = New System.Drawing.Size(800, 425)
        Me.data_todos.TabIndex = 3
        '
        'ToDosTableAdapter
        '
        Me.ToDosTableAdapter.ClearBeforeFill = True
        '
        'ToDos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.data_todos)
        Me.Controls.Add(Me.tool_todos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ToDos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant: ToDos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tool_todos.ResumeLayout(False)
        Me.tool_todos.PerformLayout()
        CType(Me.data_todos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tool_todos As ToolStrip
    Friend WithEvents btn_addtodo As ToolStripButton
    Friend WithEvents btn_edittodo As ToolStripButton
    Friend WithEvents btn_deletetodo As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btn_filtertodos As ToolStripButton
    Friend WithEvents btn_unfiltertodos As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btn_export As ToolStripButton
    Friend WithEvents data_todos As DataGridView
    Friend WithEvents ToDosTableAdapter As AssistantDBDataSetTableAdapters.ToDosTableAdapter
End Class
