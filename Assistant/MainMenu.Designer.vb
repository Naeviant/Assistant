<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tab_settings = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.data_subjects = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeacherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastRevisedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Revise = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SubjectsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssistantDS = New Assistant.AssistantDS()
        Me.tools_subjects = New System.Windows.Forms.ToolStrip()
        Me.btn_addsubjects = New System.Windows.Forms.ToolStripButton()
        Me.btn_viewsettings = New System.Windows.Forms.ToolStripButton()
        Me.btn_editsubjects = New System.Windows.Forms.ToolStripButton()
        Me.btn_deletesubjects = New System.Windows.Forms.ToolStripButton()
        Me.btn_clearsubjects = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_showallsubjects = New System.Windows.Forms.ToolStripButton()
        Me.btn_filtersubjects = New System.Windows.Forms.ToolStripButton()
        Me.btn_downloadsubjects = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_homeworkupdate = New System.Windows.Forms.Button()
        Me.chk_homeworksaturday = New System.Windows.Forms.CheckBox()
        Me.chk_homeworksunday = New System.Windows.Forms.CheckBox()
        Me.chk_homeworktuesday = New System.Windows.Forms.CheckBox()
        Me.chk_homeworkwednesday = New System.Windows.Forms.CheckBox()
        Me.chk_homeworkthursday = New System.Windows.Forms.CheckBox()
        Me.chk_homeworkfriday = New System.Windows.Forms.CheckBox()
        Me.chk_homeworkmonday = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_revisionupdate = New System.Windows.Forms.Button()
        Me.chk_revisionsaturday = New System.Windows.Forms.CheckBox()
        Me.chk_revisionsunday = New System.Windows.Forms.CheckBox()
        Me.chk_revisiontuesday = New System.Windows.Forms.CheckBox()
        Me.chk_revisionwednesday = New System.Windows.Forms.CheckBox()
        Me.chk_revisionthursday = New System.Windows.Forms.CheckBox()
        Me.chk_revisionfriday = New System.Windows.Forms.CheckBox()
        Me.chk_revisionmonday = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.link_icons = New System.Windows.Forms.LinkLabel()
        Me.tab_todos = New System.Windows.Forms.TabPage()
        Me.data_todos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToDosTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tools_todos = New System.Windows.Forms.ToolStrip()
        Me.btn_addtodos = New System.Windows.Forms.ToolStripButton()
        Me.btn_viewtodos = New System.Windows.Forms.ToolStripButton()
        Me.btn_edittodos = New System.Windows.Forms.ToolStripButton()
        Me.btn_deletetodos = New System.Windows.Forms.ToolStripButton()
        Me.btn_cleartodos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_showalltodos = New System.Windows.Forms.ToolStripButton()
        Me.btn_filtertodos = New System.Windows.Forms.ToolStripButton()
        Me.btn_downloadrecords = New System.Windows.Forms.ToolStripButton()
        Me.tab_rooms = New System.Windows.Forms.TabPage()
        Me.data_rooms = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tools_rooms = New System.Windows.Forms.ToolStrip()
        Me.btn_addrooms = New System.Windows.Forms.ToolStripButton()
        Me.btn_viewrooms = New System.Windows.Forms.ToolStripButton()
        Me.btn_editrooms = New System.Windows.Forms.ToolStripButton()
        Me.btn_deleterooms = New System.Windows.Forms.ToolStripButton()
        Me.btn_clearrooms = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_showallrooms = New System.Windows.Forms.ToolStripButton()
        Me.btn_filterrooms = New System.Windows.Forms.ToolStripButton()
        Me.btn_downloadrooms = New System.Windows.Forms.ToolStripButton()
        Me.tab_results = New System.Windows.Forms.TabPage()
        Me.data_results = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tools_results = New System.Windows.Forms.ToolStrip()
        Me.btn_addresults = New System.Windows.Forms.ToolStripButton()
        Me.btn_viewresults = New System.Windows.Forms.ToolStripButton()
        Me.btn_editresults = New System.Windows.Forms.ToolStripButton()
        Me.btn_deleteresults = New System.Windows.Forms.ToolStripButton()
        Me.btn_clearresults = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_showallresults = New System.Windows.Forms.ToolStripButton()
        Me.btn_filterresults = New System.Windows.Forms.ToolStripButton()
        Me.btn_downloadresults = New System.Windows.Forms.ToolStripButton()
        Me.tab_letters = New System.Windows.Forms.TabPage()
        Me.data_letters = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LettersTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tools_letters = New System.Windows.Forms.ToolStrip()
        Me.btn_addletters = New System.Windows.Forms.ToolStripButton()
        Me.btn_viewletters = New System.Windows.Forms.ToolStripButton()
        Me.btn_editletters = New System.Windows.Forms.ToolStripButton()
        Me.btn_deleteletters = New System.Windows.Forms.ToolStripButton()
        Me.btn_clearletters = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_showallletters = New System.Windows.Forms.ToolStripButton()
        Me.btn_filterletters = New System.Windows.Forms.ToolStripButton()
        Me.btn_downloadletters = New System.Windows.Forms.ToolStripButton()
        Me.tab_homework = New System.Windows.Forms.TabPage()
        Me.data_homeworks = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HomeworkTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tools_homework = New System.Windows.Forms.ToolStrip()
        Me.btn_addhomeworks = New System.Windows.Forms.ToolStripButton()
        Me.btn_viewhomeworks = New System.Windows.Forms.ToolStripButton()
        Me.btn_edithomeworks = New System.Windows.Forms.ToolStripButton()
        Me.btn_deletehomeworks = New System.Windows.Forms.ToolStripButton()
        Me.btn_clearhomeworks = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_showallhomeworks = New System.Windows.Forms.ToolStripButton()
        Me.btn_filterhomeworks = New System.Windows.Forms.ToolStripButton()
        Me.btn_downloadhomeworks = New System.Windows.Forms.ToolStripButton()
        Me.tab_exams = New System.Windows.Forms.TabPage()
        Me.data_exams = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExamsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tools_exams = New System.Windows.Forms.ToolStrip()
        Me.btn_addexams = New System.Windows.Forms.ToolStripButton()
        Me.btn_viewexams = New System.Windows.Forms.ToolStripButton()
        Me.btn_editexams = New System.Windows.Forms.ToolStripButton()
        Me.btn_deleteexams = New System.Windows.Forms.ToolStripButton()
        Me.btn_clearexams = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_showallexams = New System.Windows.Forms.ToolStripButton()
        Me.btn_filterexams = New System.Windows.Forms.ToolStripButton()
        Me.btn_downloadexams = New System.Windows.Forms.ToolStripButton()
        Me.tab_events = New System.Windows.Forms.TabPage()
        Me.data_events = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventsTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tools_events = New System.Windows.Forms.ToolStrip()
        Me.btn_addevents = New System.Windows.Forms.ToolStripButton()
        Me.btn_viewevents = New System.Windows.Forms.ToolStripButton()
        Me.btn_editevents = New System.Windows.Forms.ToolStripButton()
        Me.btn_deleteevents = New System.Windows.Forms.ToolStripButton()
        Me.btn_clearevents = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_showallevents = New System.Windows.Forms.ToolStripButton()
        Me.btn_filterevents = New System.Windows.Forms.ToolStripButton()
        Me.btn_downloadevents = New System.Windows.Forms.ToolStripButton()
        Me.tab_books = New System.Windows.Forms.TabPage()
        Me.data_books = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooksTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tools_books = New System.Windows.Forms.ToolStrip()
        Me.btn_addbooks = New System.Windows.Forms.ToolStripButton()
        Me.btn_viewbooks = New System.Windows.Forms.ToolStripButton()
        Me.btn_editbooks = New System.Windows.Forms.ToolStripButton()
        Me.btn_deletebooks = New System.Windows.Forms.ToolStripButton()
        Me.btn_clearbooks = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btn_showallbooks = New System.Windows.Forms.ToolStripButton()
        Me.btn_filterbooks = New System.Windows.Forms.ToolStripButton()
        Me.btn_downloadbooks = New System.Windows.Forms.ToolStripButton()
        Me.tab_outlook = New System.Windows.Forms.TabPage()
        Me.flow_outlook = New System.Windows.Forms.FlowLayoutPanel()
        Me.tools_outlook = New System.Windows.Forms.ToolStrip()
        Me.btn_updateoutlook = New System.Windows.Forms.ToolStripButton()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HomeworkTableTableAdapter = New Assistant.AssistantDSTableAdapters.HomeworkTableTableAdapter()
        Me.BooksTableTableAdapter = New Assistant.AssistantDSTableAdapters.BooksTableTableAdapter()
        Me.EventsTableTableAdapter = New Assistant.AssistantDSTableAdapters.EventsTableTableAdapter()
        Me.ExamsTableTableAdapter = New Assistant.AssistantDSTableAdapters.ExamsTableTableAdapter()
        Me.LettersTableTableAdapter = New Assistant.AssistantDSTableAdapters.LettersTableTableAdapter()
        Me.ResultsTableTableAdapter = New Assistant.AssistantDSTableAdapters.ResultsTableTableAdapter()
        Me.RoomsTableTableAdapter = New Assistant.AssistantDSTableAdapters.RoomsTableTableAdapter()
        Me.SubjectsTableTableAdapter = New Assistant.AssistantDSTableAdapters.SubjectsTableTableAdapter()
        Me.ToDosTableTableAdapter = New Assistant.AssistantDSTableAdapters.ToDosTableTableAdapter()
        Me.HomeworkTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableTableAdapter1 = New Assistant.AssistantDSTableAdapters.BooksTableTableAdapter()
        Me.HomeworkTableTableAdapter1 = New Assistant.AssistantDSTableAdapters.HomeworkTableTableAdapter()
        Me.tab_settings.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.data_subjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tools_subjects.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tab_todos.SuspendLayout()
        CType(Me.data_todos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToDosTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tools_todos.SuspendLayout()
        Me.tab_rooms.SuspendLayout()
        CType(Me.data_rooms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tools_rooms.SuspendLayout()
        Me.tab_results.SuspendLayout()
        CType(Me.data_results, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tools_results.SuspendLayout()
        Me.tab_letters.SuspendLayout()
        CType(Me.data_letters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LettersTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tools_letters.SuspendLayout()
        Me.tab_homework.SuspendLayout()
        CType(Me.data_homeworks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeworkTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tools_homework.SuspendLayout()
        Me.tab_exams.SuspendLayout()
        CType(Me.data_exams, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tools_exams.SuspendLayout()
        Me.tab_events.SuspendLayout()
        CType(Me.data_events, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventsTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tools_events.SuspendLayout()
        Me.tab_books.SuspendLayout()
        CType(Me.data_books, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tools_books.SuspendLayout()
        Me.tab_outlook.SuspendLayout()
        Me.tools_outlook.SuspendLayout()
        Me.Tab.SuspendLayout()
        CType(Me.HomeworkTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_settings
        '
        Me.tab_settings.Controls.Add(Me.SplitContainer1)
        Me.tab_settings.Location = New System.Drawing.Point(4, 22)
        Me.tab_settings.Name = "tab_settings"
        Me.tab_settings.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_settings.Size = New System.Drawing.Size(876, 535)
        Me.tab_settings.TabIndex = 10
        Me.tab_settings.Text = "Settings"
        Me.tab_settings.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(870, 529)
        Me.SplitContainer1.SplitterDistance = 318
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.data_subjects)
        Me.GroupBox1.Controls.Add(Me.tools_subjects)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(870, 318)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Subjects"
        '
        'data_subjects
        '
        Me.data_subjects.AllowUserToAddRows = False
        Me.data_subjects.AllowUserToDeleteRows = False
        Me.data_subjects.AllowUserToResizeColumns = False
        Me.data_subjects.AllowUserToResizeRows = False
        Me.data_subjects.AutoGenerateColumns = False
        Me.data_subjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_subjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.data_subjects.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.TeacherDataGridViewTextBoxColumn, Me.RoomDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.LastRevisedDataGridViewTextBoxColumn, Me.Revise})
        Me.data_subjects.DataSource = Me.SubjectsTableBindingSource
        Me.data_subjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_subjects.Location = New System.Drawing.Point(3, 41)
        Me.data_subjects.MultiSelect = False
        Me.data_subjects.Name = "data_subjects"
        Me.data_subjects.ReadOnly = True
        Me.data_subjects.RowHeadersVisible = False
        Me.data_subjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.data_subjects.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_subjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_subjects.Size = New System.Drawing.Size(864, 274)
        Me.data_subjects.TabIndex = 12
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        Me.SubjectDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TeacherDataGridViewTextBoxColumn
        '
        Me.TeacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher"
        Me.TeacherDataGridViewTextBoxColumn.HeaderText = "Teacher"
        Me.TeacherDataGridViewTextBoxColumn.Name = "TeacherDataGridViewTextBoxColumn"
        Me.TeacherDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RoomDataGridViewTextBoxColumn
        '
        Me.RoomDataGridViewTextBoxColumn.DataPropertyName = "Room"
        Me.RoomDataGridViewTextBoxColumn.HeaderText = "Room"
        Me.RoomDataGridViewTextBoxColumn.Name = "RoomDataGridViewTextBoxColumn"
        Me.RoomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        Me.ClassDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastRevisedDataGridViewTextBoxColumn
        '
        Me.LastRevisedDataGridViewTextBoxColumn.DataPropertyName = "Last Revised"
        Me.LastRevisedDataGridViewTextBoxColumn.HeaderText = "Last Revised"
        Me.LastRevisedDataGridViewTextBoxColumn.Name = "LastRevisedDataGridViewTextBoxColumn"
        Me.LastRevisedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Revise
        '
        Me.Revise.DataPropertyName = "Revise"
        Me.Revise.HeaderText = "Revise"
        Me.Revise.Name = "Revise"
        Me.Revise.ReadOnly = True
        '
        'SubjectsTableBindingSource
        '
        Me.SubjectsTableBindingSource.DataMember = "SubjectsTable"
        Me.SubjectsTableBindingSource.DataSource = Me.AssistantDS
        '
        'AssistantDS
        '
        Me.AssistantDS.DataSetName = "AssistantDS"
        Me.AssistantDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tools_subjects
        '
        Me.tools_subjects.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tools_subjects.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_addsubjects, Me.btn_viewsettings, Me.btn_editsubjects, Me.btn_deletesubjects, Me.btn_clearsubjects, Me.ToolStripSeparator10, Me.btn_showallsubjects, Me.btn_filtersubjects, Me.btn_downloadsubjects})
        Me.tools_subjects.Location = New System.Drawing.Point(3, 16)
        Me.tools_subjects.Name = "tools_subjects"
        Me.tools_subjects.Size = New System.Drawing.Size(864, 25)
        Me.tools_subjects.TabIndex = 11
        '
        'btn_addsubjects
        '
        Me.btn_addsubjects.Image = CType(resources.GetObject("btn_addsubjects.Image"), System.Drawing.Image)
        Me.btn_addsubjects.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_addsubjects.Name = "btn_addsubjects"
        Me.btn_addsubjects.Size = New System.Drawing.Size(89, 22)
        Me.btn_addsubjects.Text = "Add Record"
        '
        'btn_viewsettings
        '
        Me.btn_viewsettings.Image = CType(resources.GetObject("btn_viewsettings.Image"), System.Drawing.Image)
        Me.btn_viewsettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_viewsettings.Name = "btn_viewsettings"
        Me.btn_viewsettings.Size = New System.Drawing.Size(92, 22)
        Me.btn_viewsettings.Text = "View Record"
        '
        'btn_editsubjects
        '
        Me.btn_editsubjects.Image = CType(resources.GetObject("btn_editsubjects.Image"), System.Drawing.Image)
        Me.btn_editsubjects.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_editsubjects.Name = "btn_editsubjects"
        Me.btn_editsubjects.Size = New System.Drawing.Size(87, 22)
        Me.btn_editsubjects.Text = "Edit Record"
        '
        'btn_deletesubjects
        '
        Me.btn_deletesubjects.Image = CType(resources.GetObject("btn_deletesubjects.Image"), System.Drawing.Image)
        Me.btn_deletesubjects.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_deletesubjects.Name = "btn_deletesubjects"
        Me.btn_deletesubjects.Size = New System.Drawing.Size(100, 22)
        Me.btn_deletesubjects.Text = "Delete Record"
        '
        'btn_clearsubjects
        '
        Me.btn_clearsubjects.Image = CType(resources.GetObject("btn_clearsubjects.Image"), System.Drawing.Image)
        Me.btn_clearsubjects.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_clearsubjects.Name = "btn_clearsubjects"
        Me.btn_clearsubjects.Size = New System.Drawing.Size(99, 22)
        Me.btn_clearsubjects.Text = "Clear Records"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'btn_showallsubjects
        '
        Me.btn_showallsubjects.Image = CType(resources.GetObject("btn_showallsubjects.Image"), System.Drawing.Image)
        Me.btn_showallsubjects.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_showallsubjects.Name = "btn_showallsubjects"
        Me.btn_showallsubjects.Size = New System.Drawing.Size(73, 22)
        Me.btn_showallsubjects.Text = "Show All"
        '
        'btn_filtersubjects
        '
        Me.btn_filtersubjects.Image = CType(resources.GetObject("btn_filtersubjects.Image"), System.Drawing.Image)
        Me.btn_filtersubjects.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_filtersubjects.Name = "btn_filtersubjects"
        Me.btn_filtersubjects.Size = New System.Drawing.Size(98, 22)
        Me.btn_filtersubjects.Text = "Filter Records"
        '
        'btn_downloadsubjects
        '
        Me.btn_downloadsubjects.Image = CType(resources.GetObject("btn_downloadsubjects.Image"), System.Drawing.Image)
        Me.btn_downloadsubjects.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_downloadsubjects.Name = "btn_downloadsubjects"
        Me.btn_downloadsubjects.Size = New System.Drawing.Size(126, 22)
        Me.btn_downloadsubjects.Text = "Download Records"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer2.Size = New System.Drawing.Size(870, 210)
        Me.SplitContainer2.SplitterDistance = 435
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.IsSplitterFixed = True
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer3.Size = New System.Drawing.Size(435, 210)
        Me.SplitContainer3.SplitterDistance = 215
        Me.SplitContainer3.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_homeworkupdate)
        Me.GroupBox2.Controls.Add(Me.chk_homeworksaturday)
        Me.GroupBox2.Controls.Add(Me.chk_homeworksunday)
        Me.GroupBox2.Controls.Add(Me.chk_homeworktuesday)
        Me.GroupBox2.Controls.Add(Me.chk_homeworkwednesday)
        Me.GroupBox2.Controls.Add(Me.chk_homeworkthursday)
        Me.GroupBox2.Controls.Add(Me.chk_homeworkfriday)
        Me.GroupBox2.Controls.Add(Me.chk_homeworkmonday)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(215, 210)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Homework Availability"
        '
        'btn_homeworkupdate
        '
        Me.btn_homeworkupdate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_homeworkupdate.Enabled = False
        Me.btn_homeworkupdate.Image = CType(resources.GetObject("btn_homeworkupdate.Image"), System.Drawing.Image)
        Me.btn_homeworkupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_homeworkupdate.Location = New System.Drawing.Point(3, 176)
        Me.btn_homeworkupdate.Name = "btn_homeworkupdate"
        Me.btn_homeworkupdate.Size = New System.Drawing.Size(209, 31)
        Me.btn_homeworkupdate.TabIndex = 7
        Me.btn_homeworkupdate.Text = "Update"
        Me.btn_homeworkupdate.UseVisualStyleBackColor = True
        '
        'chk_homeworksaturday
        '
        Me.chk_homeworksaturday.AutoSize = True
        Me.chk_homeworksaturday.Enabled = False
        Me.chk_homeworksaturday.Location = New System.Drawing.Point(4, 135)
        Me.chk_homeworksaturday.Name = "chk_homeworksaturday"
        Me.chk_homeworksaturday.Size = New System.Drawing.Size(68, 17)
        Me.chk_homeworksaturday.TabIndex = 6
        Me.chk_homeworksaturday.Text = "Saturday"
        Me.chk_homeworksaturday.UseVisualStyleBackColor = True
        '
        'chk_homeworksunday
        '
        Me.chk_homeworksunday.AutoSize = True
        Me.chk_homeworksunday.Enabled = False
        Me.chk_homeworksunday.Location = New System.Drawing.Point(4, 158)
        Me.chk_homeworksunday.Name = "chk_homeworksunday"
        Me.chk_homeworksunday.Size = New System.Drawing.Size(62, 17)
        Me.chk_homeworksunday.TabIndex = 5
        Me.chk_homeworksunday.Text = "Sunday"
        Me.chk_homeworksunday.UseVisualStyleBackColor = True
        '
        'chk_homeworktuesday
        '
        Me.chk_homeworktuesday.AutoSize = True
        Me.chk_homeworktuesday.Enabled = False
        Me.chk_homeworktuesday.Location = New System.Drawing.Point(4, 43)
        Me.chk_homeworktuesday.Name = "chk_homeworktuesday"
        Me.chk_homeworktuesday.Size = New System.Drawing.Size(67, 17)
        Me.chk_homeworktuesday.TabIndex = 4
        Me.chk_homeworktuesday.Text = "Tuesday"
        Me.chk_homeworktuesday.UseVisualStyleBackColor = True
        '
        'chk_homeworkwednesday
        '
        Me.chk_homeworkwednesday.AutoSize = True
        Me.chk_homeworkwednesday.Enabled = False
        Me.chk_homeworkwednesday.Location = New System.Drawing.Point(4, 66)
        Me.chk_homeworkwednesday.Name = "chk_homeworkwednesday"
        Me.chk_homeworkwednesday.Size = New System.Drawing.Size(83, 17)
        Me.chk_homeworkwednesday.TabIndex = 3
        Me.chk_homeworkwednesday.Text = "Wednesday"
        Me.chk_homeworkwednesday.UseVisualStyleBackColor = True
        '
        'chk_homeworkthursday
        '
        Me.chk_homeworkthursday.AutoSize = True
        Me.chk_homeworkthursday.Enabled = False
        Me.chk_homeworkthursday.Location = New System.Drawing.Point(4, 89)
        Me.chk_homeworkthursday.Name = "chk_homeworkthursday"
        Me.chk_homeworkthursday.Size = New System.Drawing.Size(70, 17)
        Me.chk_homeworkthursday.TabIndex = 2
        Me.chk_homeworkthursday.Text = "Thursday"
        Me.chk_homeworkthursday.UseVisualStyleBackColor = True
        '
        'chk_homeworkfriday
        '
        Me.chk_homeworkfriday.AutoSize = True
        Me.chk_homeworkfriday.Enabled = False
        Me.chk_homeworkfriday.Location = New System.Drawing.Point(4, 112)
        Me.chk_homeworkfriday.Name = "chk_homeworkfriday"
        Me.chk_homeworkfriday.Size = New System.Drawing.Size(54, 17)
        Me.chk_homeworkfriday.TabIndex = 1
        Me.chk_homeworkfriday.Text = "Friday"
        Me.chk_homeworkfriday.UseVisualStyleBackColor = True
        '
        'chk_homeworkmonday
        '
        Me.chk_homeworkmonday.AutoSize = True
        Me.chk_homeworkmonday.Enabled = False
        Me.chk_homeworkmonday.Location = New System.Drawing.Point(4, 20)
        Me.chk_homeworkmonday.Name = "chk_homeworkmonday"
        Me.chk_homeworkmonday.Size = New System.Drawing.Size(64, 17)
        Me.chk_homeworkmonday.TabIndex = 0
        Me.chk_homeworkmonday.Text = "Monday"
        Me.chk_homeworkmonday.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_revisionupdate)
        Me.GroupBox3.Controls.Add(Me.chk_revisionsaturday)
        Me.GroupBox3.Controls.Add(Me.chk_revisionsunday)
        Me.GroupBox3.Controls.Add(Me.chk_revisiontuesday)
        Me.GroupBox3.Controls.Add(Me.chk_revisionwednesday)
        Me.GroupBox3.Controls.Add(Me.chk_revisionthursday)
        Me.GroupBox3.Controls.Add(Me.chk_revisionfriday)
        Me.GroupBox3.Controls.Add(Me.chk_revisionmonday)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(216, 210)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Revision Availability"
        '
        'btn_revisionupdate
        '
        Me.btn_revisionupdate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_revisionupdate.Image = CType(resources.GetObject("btn_revisionupdate.Image"), System.Drawing.Image)
        Me.btn_revisionupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_revisionupdate.Location = New System.Drawing.Point(3, 176)
        Me.btn_revisionupdate.Name = "btn_revisionupdate"
        Me.btn_revisionupdate.Size = New System.Drawing.Size(210, 31)
        Me.btn_revisionupdate.TabIndex = 15
        Me.btn_revisionupdate.Text = "Update"
        Me.btn_revisionupdate.UseVisualStyleBackColor = True
        '
        'chk_revisionsaturday
        '
        Me.chk_revisionsaturday.AutoSize = True
        Me.chk_revisionsaturday.Location = New System.Drawing.Point(6, 135)
        Me.chk_revisionsaturday.Name = "chk_revisionsaturday"
        Me.chk_revisionsaturday.Size = New System.Drawing.Size(68, 17)
        Me.chk_revisionsaturday.TabIndex = 14
        Me.chk_revisionsaturday.Text = "Saturday"
        Me.chk_revisionsaturday.UseVisualStyleBackColor = True
        '
        'chk_revisionsunday
        '
        Me.chk_revisionsunday.AutoSize = True
        Me.chk_revisionsunday.Location = New System.Drawing.Point(6, 158)
        Me.chk_revisionsunday.Name = "chk_revisionsunday"
        Me.chk_revisionsunday.Size = New System.Drawing.Size(62, 17)
        Me.chk_revisionsunday.TabIndex = 13
        Me.chk_revisionsunday.Text = "Sunday"
        Me.chk_revisionsunday.UseVisualStyleBackColor = True
        '
        'chk_revisiontuesday
        '
        Me.chk_revisiontuesday.AutoSize = True
        Me.chk_revisiontuesday.Location = New System.Drawing.Point(6, 43)
        Me.chk_revisiontuesday.Name = "chk_revisiontuesday"
        Me.chk_revisiontuesday.Size = New System.Drawing.Size(67, 17)
        Me.chk_revisiontuesday.TabIndex = 12
        Me.chk_revisiontuesday.Text = "Tuesday"
        Me.chk_revisiontuesday.UseVisualStyleBackColor = True
        '
        'chk_revisionwednesday
        '
        Me.chk_revisionwednesday.AutoSize = True
        Me.chk_revisionwednesday.Location = New System.Drawing.Point(6, 66)
        Me.chk_revisionwednesday.Name = "chk_revisionwednesday"
        Me.chk_revisionwednesday.Size = New System.Drawing.Size(83, 17)
        Me.chk_revisionwednesday.TabIndex = 11
        Me.chk_revisionwednesday.Text = "Wednesday"
        Me.chk_revisionwednesday.UseVisualStyleBackColor = True
        '
        'chk_revisionthursday
        '
        Me.chk_revisionthursday.AutoSize = True
        Me.chk_revisionthursday.Location = New System.Drawing.Point(6, 89)
        Me.chk_revisionthursday.Name = "chk_revisionthursday"
        Me.chk_revisionthursday.Size = New System.Drawing.Size(70, 17)
        Me.chk_revisionthursday.TabIndex = 10
        Me.chk_revisionthursday.Text = "Thursday"
        Me.chk_revisionthursday.UseVisualStyleBackColor = True
        '
        'chk_revisionfriday
        '
        Me.chk_revisionfriday.AutoSize = True
        Me.chk_revisionfriday.Location = New System.Drawing.Point(6, 112)
        Me.chk_revisionfriday.Name = "chk_revisionfriday"
        Me.chk_revisionfriday.Size = New System.Drawing.Size(54, 17)
        Me.chk_revisionfriday.TabIndex = 9
        Me.chk_revisionfriday.Text = "Friday"
        Me.chk_revisionfriday.UseVisualStyleBackColor = True
        '
        'chk_revisionmonday
        '
        Me.chk_revisionmonday.AutoSize = True
        Me.chk_revisionmonday.Location = New System.Drawing.Point(6, 20)
        Me.chk_revisionmonday.Name = "chk_revisionmonday"
        Me.chk_revisionmonday.Size = New System.Drawing.Size(64, 17)
        Me.chk_revisionmonday.TabIndex = 8
        Me.chk_revisionmonday.Text = "Monday"
        Me.chk_revisionmonday.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.link_icons)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(431, 210)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Information and Credits"
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(421, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "The coding language used is VB.NET and this project was put together in Visual St" &
    "udio."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "This program was created by Sam Hirst in 2017."
        '
        'link_icons
        '
        Me.link_icons.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.link_icons.AutoSize = True
        Me.link_icons.Location = New System.Drawing.Point(2, 194)
        Me.link_icons.Name = "link_icons"
        Me.link_icons.Size = New System.Drawing.Size(183, 13)
        Me.link_icons.TabIndex = 0
        Me.link_icons.TabStop = True
        Me.link_icons.Text = "Icons from http://www.aha-soft.com/"
        '
        'tab_todos
        '
        Me.tab_todos.Controls.Add(Me.data_todos)
        Me.tab_todos.Controls.Add(Me.tools_todos)
        Me.tab_todos.Location = New System.Drawing.Point(4, 22)
        Me.tab_todos.Name = "tab_todos"
        Me.tab_todos.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_todos.Size = New System.Drawing.Size(876, 535)
        Me.tab_todos.TabIndex = 9
        Me.tab_todos.Text = "ToDos"
        Me.tab_todos.UseVisualStyleBackColor = True
        '
        'data_todos
        '
        Me.data_todos.AllowUserToAddRows = False
        Me.data_todos.AllowUserToDeleteRows = False
        Me.data_todos.AllowUserToResizeColumns = False
        Me.data_todos.AllowUserToResizeRows = False
        Me.data_todos.AutoGenerateColumns = False
        Me.data_todos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_todos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.data_todos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62, Me.DataGridViewTextBoxColumn63})
        Me.data_todos.DataSource = Me.ToDosTableBindingSource
        Me.data_todos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_todos.Location = New System.Drawing.Point(3, 28)
        Me.data_todos.MultiSelect = False
        Me.data_todos.Name = "data_todos"
        Me.data_todos.ReadOnly = True
        Me.data_todos.RowHeadersVisible = False
        Me.data_todos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.data_todos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_todos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_todos.Size = New System.Drawing.Size(870, 504)
        Me.data_todos.TabIndex = 9
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn57.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.ReadOnly = True
        Me.DataGridViewTextBoxColumn57.Visible = False
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn58.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.ReadOnly = True
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "Day"
        Me.DataGridViewTextBoxColumn59.HeaderText = "Day"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        Me.DataGridViewTextBoxColumn59.ReadOnly = True
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "Time"
        Me.DataGridViewTextBoxColumn60.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        Me.DataGridViewTextBoxColumn60.ReadOnly = True
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn61.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        Me.DataGridViewTextBoxColumn61.ReadOnly = True
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn62.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        Me.DataGridViewTextBoxColumn62.ReadOnly = True
        '
        'DataGridViewTextBoxColumn63
        '
        Me.DataGridViewTextBoxColumn63.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn63.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
        Me.DataGridViewTextBoxColumn63.ReadOnly = True
        '
        'ToDosTableBindingSource
        '
        Me.ToDosTableBindingSource.DataMember = "ToDosTable"
        Me.ToDosTableBindingSource.DataSource = Me.AssistantDS
        '
        'tools_todos
        '
        Me.tools_todos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tools_todos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_addtodos, Me.btn_viewtodos, Me.btn_edittodos, Me.btn_deletetodos, Me.btn_cleartodos, Me.ToolStripSeparator9, Me.btn_showalltodos, Me.btn_filtertodos, Me.btn_downloadrecords})
        Me.tools_todos.Location = New System.Drawing.Point(3, 3)
        Me.tools_todos.Name = "tools_todos"
        Me.tools_todos.Size = New System.Drawing.Size(870, 25)
        Me.tools_todos.TabIndex = 8
        '
        'btn_addtodos
        '
        Me.btn_addtodos.Image = CType(resources.GetObject("btn_addtodos.Image"), System.Drawing.Image)
        Me.btn_addtodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_addtodos.Name = "btn_addtodos"
        Me.btn_addtodos.Size = New System.Drawing.Size(89, 22)
        Me.btn_addtodos.Text = "Add Record"
        '
        'btn_viewtodos
        '
        Me.btn_viewtodos.Image = CType(resources.GetObject("btn_viewtodos.Image"), System.Drawing.Image)
        Me.btn_viewtodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_viewtodos.Name = "btn_viewtodos"
        Me.btn_viewtodos.Size = New System.Drawing.Size(92, 22)
        Me.btn_viewtodos.Text = "View Record"
        '
        'btn_edittodos
        '
        Me.btn_edittodos.Image = CType(resources.GetObject("btn_edittodos.Image"), System.Drawing.Image)
        Me.btn_edittodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_edittodos.Name = "btn_edittodos"
        Me.btn_edittodos.Size = New System.Drawing.Size(87, 22)
        Me.btn_edittodos.Text = "Edit Record"
        '
        'btn_deletetodos
        '
        Me.btn_deletetodos.Image = CType(resources.GetObject("btn_deletetodos.Image"), System.Drawing.Image)
        Me.btn_deletetodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_deletetodos.Name = "btn_deletetodos"
        Me.btn_deletetodos.Size = New System.Drawing.Size(100, 22)
        Me.btn_deletetodos.Text = "Delete Record"
        '
        'btn_cleartodos
        '
        Me.btn_cleartodos.Image = CType(resources.GetObject("btn_cleartodos.Image"), System.Drawing.Image)
        Me.btn_cleartodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cleartodos.Name = "btn_cleartodos"
        Me.btn_cleartodos.Size = New System.Drawing.Size(99, 22)
        Me.btn_cleartodos.Text = "Clear Records"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'btn_showalltodos
        '
        Me.btn_showalltodos.Image = CType(resources.GetObject("btn_showalltodos.Image"), System.Drawing.Image)
        Me.btn_showalltodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_showalltodos.Name = "btn_showalltodos"
        Me.btn_showalltodos.Size = New System.Drawing.Size(73, 22)
        Me.btn_showalltodos.Text = "Show All"
        '
        'btn_filtertodos
        '
        Me.btn_filtertodos.Image = CType(resources.GetObject("btn_filtertodos.Image"), System.Drawing.Image)
        Me.btn_filtertodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_filtertodos.Name = "btn_filtertodos"
        Me.btn_filtertodos.Size = New System.Drawing.Size(98, 22)
        Me.btn_filtertodos.Text = "Filter Records"
        '
        'btn_downloadrecords
        '
        Me.btn_downloadrecords.Image = CType(resources.GetObject("btn_downloadrecords.Image"), System.Drawing.Image)
        Me.btn_downloadrecords.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_downloadrecords.Name = "btn_downloadrecords"
        Me.btn_downloadrecords.Size = New System.Drawing.Size(126, 22)
        Me.btn_downloadrecords.Text = "Download Records"
        '
        'tab_rooms
        '
        Me.tab_rooms.Controls.Add(Me.data_rooms)
        Me.tab_rooms.Controls.Add(Me.tools_rooms)
        Me.tab_rooms.Location = New System.Drawing.Point(4, 22)
        Me.tab_rooms.Name = "tab_rooms"
        Me.tab_rooms.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_rooms.Size = New System.Drawing.Size(876, 535)
        Me.tab_rooms.TabIndex = 8
        Me.tab_rooms.Text = "Rooms"
        Me.tab_rooms.UseVisualStyleBackColor = True
        '
        'data_rooms
        '
        Me.data_rooms.AllowUserToAddRows = False
        Me.data_rooms.AllowUserToDeleteRows = False
        Me.data_rooms.AllowUserToResizeColumns = False
        Me.data_rooms.AllowUserToResizeRows = False
        Me.data_rooms.AutoGenerateColumns = False
        Me.data_rooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.data_rooms.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.ToDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn55, Me.PeriodDataGridViewTextBoxColumn, Me.ReasonDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn56})
        Me.data_rooms.DataSource = Me.RoomsTableBindingSource
        Me.data_rooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_rooms.Location = New System.Drawing.Point(3, 28)
        Me.data_rooms.MultiSelect = False
        Me.data_rooms.Name = "data_rooms"
        Me.data_rooms.ReadOnly = True
        Me.data_rooms.RowHeadersVisible = False
        Me.data_rooms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.data_rooms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_rooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_rooms.Size = New System.Drawing.Size(870, 504)
        Me.data_rooms.TabIndex = 8
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn52.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.ReadOnly = True
        Me.DataGridViewTextBoxColumn52.Visible = False
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "Subject"
        Me.DataGridViewTextBoxColumn53.HeaderText = "Subject"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        Me.DataGridViewTextBoxColumn53.ReadOnly = True
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "From"
        Me.DataGridViewTextBoxColumn54.HeaderText = "From"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.ReadOnly = True
        '
        'ToDataGridViewTextBoxColumn
        '
        Me.ToDataGridViewTextBoxColumn.DataPropertyName = "To"
        Me.ToDataGridViewTextBoxColumn.HeaderText = "To"
        Me.ToDataGridViewTextBoxColumn.Name = "ToDataGridViewTextBoxColumn"
        Me.ToDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "Day"
        Me.DataGridViewTextBoxColumn55.HeaderText = "Day"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        '
        'PeriodDataGridViewTextBoxColumn
        '
        Me.PeriodDataGridViewTextBoxColumn.DataPropertyName = "Period"
        Me.PeriodDataGridViewTextBoxColumn.HeaderText = "Period"
        Me.PeriodDataGridViewTextBoxColumn.Name = "PeriodDataGridViewTextBoxColumn"
        Me.PeriodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReasonDataGridViewTextBoxColumn
        '
        Me.ReasonDataGridViewTextBoxColumn.DataPropertyName = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.HeaderText = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.Name = "ReasonDataGridViewTextBoxColumn"
        Me.ReasonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn56.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.ReadOnly = True
        '
        'RoomsTableBindingSource
        '
        Me.RoomsTableBindingSource.DataMember = "RoomsTable"
        Me.RoomsTableBindingSource.DataSource = Me.AssistantDS
        '
        'tools_rooms
        '
        Me.tools_rooms.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tools_rooms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_addrooms, Me.btn_viewrooms, Me.btn_editrooms, Me.btn_deleterooms, Me.btn_clearrooms, Me.ToolStripSeparator8, Me.btn_showallrooms, Me.btn_filterrooms, Me.btn_downloadrooms})
        Me.tools_rooms.Location = New System.Drawing.Point(3, 3)
        Me.tools_rooms.Name = "tools_rooms"
        Me.tools_rooms.Size = New System.Drawing.Size(870, 25)
        Me.tools_rooms.TabIndex = 7
        '
        'btn_addrooms
        '
        Me.btn_addrooms.Image = CType(resources.GetObject("btn_addrooms.Image"), System.Drawing.Image)
        Me.btn_addrooms.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_addrooms.Name = "btn_addrooms"
        Me.btn_addrooms.Size = New System.Drawing.Size(89, 22)
        Me.btn_addrooms.Text = "Add Record"
        '
        'btn_viewrooms
        '
        Me.btn_viewrooms.Image = CType(resources.GetObject("btn_viewrooms.Image"), System.Drawing.Image)
        Me.btn_viewrooms.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_viewrooms.Name = "btn_viewrooms"
        Me.btn_viewrooms.Size = New System.Drawing.Size(92, 22)
        Me.btn_viewrooms.Text = "View Record"
        '
        'btn_editrooms
        '
        Me.btn_editrooms.Image = CType(resources.GetObject("btn_editrooms.Image"), System.Drawing.Image)
        Me.btn_editrooms.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_editrooms.Name = "btn_editrooms"
        Me.btn_editrooms.Size = New System.Drawing.Size(87, 22)
        Me.btn_editrooms.Text = "Edit Record"
        '
        'btn_deleterooms
        '
        Me.btn_deleterooms.Image = CType(resources.GetObject("btn_deleterooms.Image"), System.Drawing.Image)
        Me.btn_deleterooms.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_deleterooms.Name = "btn_deleterooms"
        Me.btn_deleterooms.Size = New System.Drawing.Size(100, 22)
        Me.btn_deleterooms.Text = "Delete Record"
        '
        'btn_clearrooms
        '
        Me.btn_clearrooms.Image = CType(resources.GetObject("btn_clearrooms.Image"), System.Drawing.Image)
        Me.btn_clearrooms.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_clearrooms.Name = "btn_clearrooms"
        Me.btn_clearrooms.Size = New System.Drawing.Size(99, 22)
        Me.btn_clearrooms.Text = "Clear Records"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'btn_showallrooms
        '
        Me.btn_showallrooms.Image = CType(resources.GetObject("btn_showallrooms.Image"), System.Drawing.Image)
        Me.btn_showallrooms.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_showallrooms.Name = "btn_showallrooms"
        Me.btn_showallrooms.Size = New System.Drawing.Size(73, 22)
        Me.btn_showallrooms.Text = "Show All"
        '
        'btn_filterrooms
        '
        Me.btn_filterrooms.Image = CType(resources.GetObject("btn_filterrooms.Image"), System.Drawing.Image)
        Me.btn_filterrooms.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_filterrooms.Name = "btn_filterrooms"
        Me.btn_filterrooms.Size = New System.Drawing.Size(98, 22)
        Me.btn_filterrooms.Text = "Filter Records"
        '
        'btn_downloadrooms
        '
        Me.btn_downloadrooms.Image = CType(resources.GetObject("btn_downloadrooms.Image"), System.Drawing.Image)
        Me.btn_downloadrooms.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_downloadrooms.Name = "btn_downloadrooms"
        Me.btn_downloadrooms.Size = New System.Drawing.Size(126, 22)
        Me.btn_downloadrooms.Text = "Download Records"
        '
        'tab_results
        '
        Me.tab_results.Controls.Add(Me.data_results)
        Me.tab_results.Controls.Add(Me.tools_results)
        Me.tab_results.Location = New System.Drawing.Point(4, 22)
        Me.tab_results.Name = "tab_results"
        Me.tab_results.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_results.Size = New System.Drawing.Size(876, 535)
        Me.tab_results.TabIndex = 6
        Me.tab_results.Text = "Results"
        Me.tab_results.UseVisualStyleBackColor = True
        '
        'data_results
        '
        Me.data_results.AllowUserToAddRows = False
        Me.data_results.AllowUserToDeleteRows = False
        Me.data_results.AllowUserToResizeColumns = False
        Me.data_results.AllowUserToResizeRows = False
        Me.data_results.AutoGenerateColumns = False
        Me.data_results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.data_results.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43})
        Me.data_results.DataSource = Me.ResultsTableBindingSource
        Me.data_results.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_results.Location = New System.Drawing.Point(3, 28)
        Me.data_results.MultiSelect = False
        Me.data_results.Name = "data_results"
        Me.data_results.ReadOnly = True
        Me.data_results.RowHeadersVisible = False
        Me.data_results.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.data_results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_results.Size = New System.Drawing.Size(870, 504)
        Me.data_results.TabIndex = 6
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn36.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        Me.DataGridViewTextBoxColumn36.Visible = False
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Subject"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Subject"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.ReadOnly = True
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "Mark"
        Me.DataGridViewTextBoxColumn38.HeaderText = "Mark"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "Grade"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Grade"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.ReadOnly = True
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "Day"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Day"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.ReadOnly = True
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "Percentage"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Percentage"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.ReadOnly = True
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn43.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        '
        'ResultsTableBindingSource
        '
        Me.ResultsTableBindingSource.DataMember = "ResultsTable"
        Me.ResultsTableBindingSource.DataSource = Me.AssistantDS
        '
        'tools_results
        '
        Me.tools_results.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tools_results.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_addresults, Me.btn_viewresults, Me.btn_editresults, Me.btn_deleteresults, Me.btn_clearresults, Me.ToolStripSeparator6, Me.btn_showallresults, Me.btn_filterresults, Me.btn_downloadresults})
        Me.tools_results.Location = New System.Drawing.Point(3, 3)
        Me.tools_results.Name = "tools_results"
        Me.tools_results.Size = New System.Drawing.Size(870, 25)
        Me.tools_results.TabIndex = 5
        '
        'btn_addresults
        '
        Me.btn_addresults.Image = CType(resources.GetObject("btn_addresults.Image"), System.Drawing.Image)
        Me.btn_addresults.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_addresults.Name = "btn_addresults"
        Me.btn_addresults.Size = New System.Drawing.Size(89, 22)
        Me.btn_addresults.Text = "Add Record"
        '
        'btn_viewresults
        '
        Me.btn_viewresults.Image = CType(resources.GetObject("btn_viewresults.Image"), System.Drawing.Image)
        Me.btn_viewresults.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_viewresults.Name = "btn_viewresults"
        Me.btn_viewresults.Size = New System.Drawing.Size(92, 22)
        Me.btn_viewresults.Text = "View Record"
        '
        'btn_editresults
        '
        Me.btn_editresults.Image = CType(resources.GetObject("btn_editresults.Image"), System.Drawing.Image)
        Me.btn_editresults.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_editresults.Name = "btn_editresults"
        Me.btn_editresults.Size = New System.Drawing.Size(87, 22)
        Me.btn_editresults.Text = "Edit Record"
        '
        'btn_deleteresults
        '
        Me.btn_deleteresults.Image = CType(resources.GetObject("btn_deleteresults.Image"), System.Drawing.Image)
        Me.btn_deleteresults.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_deleteresults.Name = "btn_deleteresults"
        Me.btn_deleteresults.Size = New System.Drawing.Size(100, 22)
        Me.btn_deleteresults.Text = "Delete Record"
        '
        'btn_clearresults
        '
        Me.btn_clearresults.Image = CType(resources.GetObject("btn_clearresults.Image"), System.Drawing.Image)
        Me.btn_clearresults.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_clearresults.Name = "btn_clearresults"
        Me.btn_clearresults.Size = New System.Drawing.Size(99, 22)
        Me.btn_clearresults.Text = "Clear Records"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'btn_showallresults
        '
        Me.btn_showallresults.Image = CType(resources.GetObject("btn_showallresults.Image"), System.Drawing.Image)
        Me.btn_showallresults.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_showallresults.Name = "btn_showallresults"
        Me.btn_showallresults.Size = New System.Drawing.Size(73, 22)
        Me.btn_showallresults.Text = "Show All"
        '
        'btn_filterresults
        '
        Me.btn_filterresults.Image = CType(resources.GetObject("btn_filterresults.Image"), System.Drawing.Image)
        Me.btn_filterresults.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_filterresults.Name = "btn_filterresults"
        Me.btn_filterresults.Size = New System.Drawing.Size(98, 22)
        Me.btn_filterresults.Text = "Filter Records"
        '
        'btn_downloadresults
        '
        Me.btn_downloadresults.Image = CType(resources.GetObject("btn_downloadresults.Image"), System.Drawing.Image)
        Me.btn_downloadresults.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_downloadresults.Name = "btn_downloadresults"
        Me.btn_downloadresults.Size = New System.Drawing.Size(126, 22)
        Me.btn_downloadresults.Text = "Download Records"
        '
        'tab_letters
        '
        Me.tab_letters.Controls.Add(Me.data_letters)
        Me.tab_letters.Controls.Add(Me.tools_letters)
        Me.tab_letters.Location = New System.Drawing.Point(4, 22)
        Me.tab_letters.Name = "tab_letters"
        Me.tab_letters.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_letters.Size = New System.Drawing.Size(876, 535)
        Me.tab_letters.TabIndex = 5
        Me.tab_letters.Text = "Letters"
        Me.tab_letters.UseVisualStyleBackColor = True
        '
        'data_letters
        '
        Me.data_letters.AllowUserToAddRows = False
        Me.data_letters.AllowUserToDeleteRows = False
        Me.data_letters.AllowUserToResizeColumns = False
        Me.data_letters.AllowUserToResizeRows = False
        Me.data_letters.AutoGenerateColumns = False
        Me.data_letters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_letters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.data_letters.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewTextBoxColumn35})
        Me.data_letters.DataSource = Me.LettersTableBindingSource
        Me.data_letters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_letters.Location = New System.Drawing.Point(3, 28)
        Me.data_letters.MultiSelect = False
        Me.data_letters.Name = "data_letters"
        Me.data_letters.ReadOnly = True
        Me.data_letters.RowHeadersVisible = False
        Me.data_letters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.data_letters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_letters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_letters.Size = New System.Drawing.Size(870, 504)
        Me.data_letters.TabIndex = 5
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn31.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Visible = False
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "Topic"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Topic"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "From"
        Me.DataGridViewTextBoxColumn33.HeaderText = "From"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Day"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Day"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "Response Needed"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Response Needed"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "Response Given"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "Response Given"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        '
        'LettersTableBindingSource
        '
        Me.LettersTableBindingSource.DataMember = "LettersTable"
        Me.LettersTableBindingSource.DataSource = Me.AssistantDS
        '
        'tools_letters
        '
        Me.tools_letters.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tools_letters.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_addletters, Me.btn_viewletters, Me.btn_editletters, Me.btn_deleteletters, Me.btn_clearletters, Me.ToolStripSeparator5, Me.btn_showallletters, Me.btn_filterletters, Me.btn_downloadletters})
        Me.tools_letters.Location = New System.Drawing.Point(3, 3)
        Me.tools_letters.Name = "tools_letters"
        Me.tools_letters.Size = New System.Drawing.Size(870, 25)
        Me.tools_letters.TabIndex = 4
        '
        'btn_addletters
        '
        Me.btn_addletters.Image = CType(resources.GetObject("btn_addletters.Image"), System.Drawing.Image)
        Me.btn_addletters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_addletters.Name = "btn_addletters"
        Me.btn_addletters.Size = New System.Drawing.Size(89, 22)
        Me.btn_addletters.Text = "Add Record"
        '
        'btn_viewletters
        '
        Me.btn_viewletters.Image = CType(resources.GetObject("btn_viewletters.Image"), System.Drawing.Image)
        Me.btn_viewletters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_viewletters.Name = "btn_viewletters"
        Me.btn_viewletters.Size = New System.Drawing.Size(92, 22)
        Me.btn_viewletters.Text = "View Record"
        '
        'btn_editletters
        '
        Me.btn_editletters.Image = CType(resources.GetObject("btn_editletters.Image"), System.Drawing.Image)
        Me.btn_editletters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_editletters.Name = "btn_editletters"
        Me.btn_editletters.Size = New System.Drawing.Size(87, 22)
        Me.btn_editletters.Text = "Edit Record"
        '
        'btn_deleteletters
        '
        Me.btn_deleteletters.Image = CType(resources.GetObject("btn_deleteletters.Image"), System.Drawing.Image)
        Me.btn_deleteletters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_deleteletters.Name = "btn_deleteletters"
        Me.btn_deleteletters.Size = New System.Drawing.Size(100, 22)
        Me.btn_deleteletters.Text = "Delete Record"
        '
        'btn_clearletters
        '
        Me.btn_clearletters.Image = CType(resources.GetObject("btn_clearletters.Image"), System.Drawing.Image)
        Me.btn_clearletters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_clearletters.Name = "btn_clearletters"
        Me.btn_clearletters.Size = New System.Drawing.Size(99, 22)
        Me.btn_clearletters.Text = "Clear Records"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btn_showallletters
        '
        Me.btn_showallletters.Image = CType(resources.GetObject("btn_showallletters.Image"), System.Drawing.Image)
        Me.btn_showallletters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_showallletters.Name = "btn_showallletters"
        Me.btn_showallletters.Size = New System.Drawing.Size(73, 22)
        Me.btn_showallletters.Text = "Show All"
        '
        'btn_filterletters
        '
        Me.btn_filterletters.Image = CType(resources.GetObject("btn_filterletters.Image"), System.Drawing.Image)
        Me.btn_filterletters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_filterletters.Name = "btn_filterletters"
        Me.btn_filterletters.Size = New System.Drawing.Size(98, 22)
        Me.btn_filterletters.Text = "Filter Records"
        '
        'btn_downloadletters
        '
        Me.btn_downloadletters.Image = CType(resources.GetObject("btn_downloadletters.Image"), System.Drawing.Image)
        Me.btn_downloadletters.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_downloadletters.Name = "btn_downloadletters"
        Me.btn_downloadletters.Size = New System.Drawing.Size(126, 22)
        Me.btn_downloadletters.Text = "Download Records"
        '
        'tab_homework
        '
        Me.tab_homework.Controls.Add(Me.data_homeworks)
        Me.tab_homework.Controls.Add(Me.tools_homework)
        Me.tab_homework.Location = New System.Drawing.Point(4, 22)
        Me.tab_homework.Name = "tab_homework"
        Me.tab_homework.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_homework.Size = New System.Drawing.Size(876, 535)
        Me.tab_homework.TabIndex = 4
        Me.tab_homework.Text = "Homework"
        Me.tab_homework.UseVisualStyleBackColor = True
        '
        'data_homeworks
        '
        Me.data_homeworks.AllowUserToAddRows = False
        Me.data_homeworks.AllowUserToDeleteRows = False
        Me.data_homeworks.AllowUserToResizeColumns = False
        Me.data_homeworks.AllowUserToResizeRows = False
        Me.data_homeworks.AutoGenerateColumns = False
        Me.data_homeworks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_homeworks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.data_homeworks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewCheckBoxColumn3})
        Me.data_homeworks.DataSource = Me.HomeworkTableBindingSource
        Me.data_homeworks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_homeworks.Location = New System.Drawing.Point(3, 28)
        Me.data_homeworks.MultiSelect = False
        Me.data_homeworks.Name = "data_homeworks"
        Me.data_homeworks.ReadOnly = True
        Me.data_homeworks.RowHeadersVisible = False
        Me.data_homeworks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.data_homeworks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_homeworks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_homeworks.Size = New System.Drawing.Size(870, 504)
        Me.data_homeworks.TabIndex = 4
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn20.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Subject"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Subject"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Set Date"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Set Date"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Set Period"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Set Period"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Due Date"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Due Date"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Due Period"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Due Period"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Priority"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Priority"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Progress"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Progress"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Project"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Project"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        '
        'HomeworkTableBindingSource
        '
        Me.HomeworkTableBindingSource.DataMember = "HomeworkTable"
        Me.HomeworkTableBindingSource.DataSource = Me.AssistantDS
        '
        'tools_homework
        '
        Me.tools_homework.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tools_homework.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_addhomeworks, Me.btn_viewhomeworks, Me.btn_edithomeworks, Me.btn_deletehomeworks, Me.btn_clearhomeworks, Me.ToolStripSeparator4, Me.btn_showallhomeworks, Me.btn_filterhomeworks, Me.btn_downloadhomeworks})
        Me.tools_homework.Location = New System.Drawing.Point(3, 3)
        Me.tools_homework.Name = "tools_homework"
        Me.tools_homework.Size = New System.Drawing.Size(870, 25)
        Me.tools_homework.TabIndex = 3
        '
        'btn_addhomeworks
        '
        Me.btn_addhomeworks.Image = CType(resources.GetObject("btn_addhomeworks.Image"), System.Drawing.Image)
        Me.btn_addhomeworks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_addhomeworks.Name = "btn_addhomeworks"
        Me.btn_addhomeworks.Size = New System.Drawing.Size(89, 22)
        Me.btn_addhomeworks.Text = "Add Record"
        '
        'btn_viewhomeworks
        '
        Me.btn_viewhomeworks.Image = CType(resources.GetObject("btn_viewhomeworks.Image"), System.Drawing.Image)
        Me.btn_viewhomeworks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_viewhomeworks.Name = "btn_viewhomeworks"
        Me.btn_viewhomeworks.Size = New System.Drawing.Size(92, 22)
        Me.btn_viewhomeworks.Text = "View Record"
        '
        'btn_edithomeworks
        '
        Me.btn_edithomeworks.Image = CType(resources.GetObject("btn_edithomeworks.Image"), System.Drawing.Image)
        Me.btn_edithomeworks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_edithomeworks.Name = "btn_edithomeworks"
        Me.btn_edithomeworks.Size = New System.Drawing.Size(87, 22)
        Me.btn_edithomeworks.Text = "Edit Record"
        '
        'btn_deletehomeworks
        '
        Me.btn_deletehomeworks.Image = CType(resources.GetObject("btn_deletehomeworks.Image"), System.Drawing.Image)
        Me.btn_deletehomeworks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_deletehomeworks.Name = "btn_deletehomeworks"
        Me.btn_deletehomeworks.Size = New System.Drawing.Size(100, 22)
        Me.btn_deletehomeworks.Text = "Delete Record"
        '
        'btn_clearhomeworks
        '
        Me.btn_clearhomeworks.Image = CType(resources.GetObject("btn_clearhomeworks.Image"), System.Drawing.Image)
        Me.btn_clearhomeworks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_clearhomeworks.Name = "btn_clearhomeworks"
        Me.btn_clearhomeworks.Size = New System.Drawing.Size(99, 22)
        Me.btn_clearhomeworks.Text = "Clear Records"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btn_showallhomeworks
        '
        Me.btn_showallhomeworks.Image = CType(resources.GetObject("btn_showallhomeworks.Image"), System.Drawing.Image)
        Me.btn_showallhomeworks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_showallhomeworks.Name = "btn_showallhomeworks"
        Me.btn_showallhomeworks.Size = New System.Drawing.Size(73, 22)
        Me.btn_showallhomeworks.Text = "Show All"
        '
        'btn_filterhomeworks
        '
        Me.btn_filterhomeworks.Image = CType(resources.GetObject("btn_filterhomeworks.Image"), System.Drawing.Image)
        Me.btn_filterhomeworks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_filterhomeworks.Name = "btn_filterhomeworks"
        Me.btn_filterhomeworks.Size = New System.Drawing.Size(98, 22)
        Me.btn_filterhomeworks.Text = "Filter Records"
        '
        'btn_downloadhomeworks
        '
        Me.btn_downloadhomeworks.Image = CType(resources.GetObject("btn_downloadhomeworks.Image"), System.Drawing.Image)
        Me.btn_downloadhomeworks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_downloadhomeworks.Name = "btn_downloadhomeworks"
        Me.btn_downloadhomeworks.Size = New System.Drawing.Size(126, 22)
        Me.btn_downloadhomeworks.Text = "Download Records"
        '
        'tab_exams
        '
        Me.tab_exams.Controls.Add(Me.data_exams)
        Me.tab_exams.Controls.Add(Me.tools_exams)
        Me.tab_exams.Location = New System.Drawing.Point(4, 22)
        Me.tab_exams.Name = "tab_exams"
        Me.tab_exams.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_exams.Size = New System.Drawing.Size(876, 535)
        Me.tab_exams.TabIndex = 3
        Me.tab_exams.Text = "Exams"
        Me.tab_exams.UseVisualStyleBackColor = True
        '
        'data_exams
        '
        Me.data_exams.AllowUserToAddRows = False
        Me.data_exams.AllowUserToDeleteRows = False
        Me.data_exams.AllowUserToResizeColumns = False
        Me.data_exams.AllowUserToResizeRows = False
        Me.data_exams.AutoGenerateColumns = False
        Me.data_exams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_exams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.data_exams.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.data_exams.DataSource = Me.ExamsTableBindingSource
        Me.data_exams.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_exams.Location = New System.Drawing.Point(3, 28)
        Me.data_exams.MultiSelect = False
        Me.data_exams.Name = "data_exams"
        Me.data_exams.ReadOnly = True
        Me.data_exams.RowHeadersVisible = False
        Me.data_exams.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.data_exams.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_exams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_exams.Size = New System.Drawing.Size(870, 504)
        Me.data_exams.TabIndex = 3
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Subject"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Subject"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Day"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Day"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Start Time"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Start Time"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "End Time"
        Me.DataGridViewTextBoxColumn18.HeaderText = "End Time"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'ExamsTableBindingSource
        '
        Me.ExamsTableBindingSource.DataMember = "ExamsTable"
        Me.ExamsTableBindingSource.DataSource = Me.AssistantDS
        '
        'tools_exams
        '
        Me.tools_exams.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tools_exams.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_addexams, Me.btn_viewexams, Me.btn_editexams, Me.btn_deleteexams, Me.btn_clearexams, Me.ToolStripSeparator3, Me.btn_showallexams, Me.btn_filterexams, Me.btn_downloadexams})
        Me.tools_exams.Location = New System.Drawing.Point(3, 3)
        Me.tools_exams.Name = "tools_exams"
        Me.tools_exams.Size = New System.Drawing.Size(870, 25)
        Me.tools_exams.TabIndex = 2
        '
        'btn_addexams
        '
        Me.btn_addexams.Image = CType(resources.GetObject("btn_addexams.Image"), System.Drawing.Image)
        Me.btn_addexams.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_addexams.Name = "btn_addexams"
        Me.btn_addexams.Size = New System.Drawing.Size(89, 22)
        Me.btn_addexams.Text = "Add Record"
        '
        'btn_viewexams
        '
        Me.btn_viewexams.Image = CType(resources.GetObject("btn_viewexams.Image"), System.Drawing.Image)
        Me.btn_viewexams.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_viewexams.Name = "btn_viewexams"
        Me.btn_viewexams.Size = New System.Drawing.Size(92, 22)
        Me.btn_viewexams.Text = "View Record"
        '
        'btn_editexams
        '
        Me.btn_editexams.Image = CType(resources.GetObject("btn_editexams.Image"), System.Drawing.Image)
        Me.btn_editexams.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_editexams.Name = "btn_editexams"
        Me.btn_editexams.Size = New System.Drawing.Size(87, 22)
        Me.btn_editexams.Text = "Edit Record"
        '
        'btn_deleteexams
        '
        Me.btn_deleteexams.Image = CType(resources.GetObject("btn_deleteexams.Image"), System.Drawing.Image)
        Me.btn_deleteexams.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_deleteexams.Name = "btn_deleteexams"
        Me.btn_deleteexams.Size = New System.Drawing.Size(100, 22)
        Me.btn_deleteexams.Text = "Delete Record"
        '
        'btn_clearexams
        '
        Me.btn_clearexams.Image = CType(resources.GetObject("btn_clearexams.Image"), System.Drawing.Image)
        Me.btn_clearexams.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_clearexams.Name = "btn_clearexams"
        Me.btn_clearexams.Size = New System.Drawing.Size(99, 22)
        Me.btn_clearexams.Text = "Clear Records"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btn_showallexams
        '
        Me.btn_showallexams.Image = CType(resources.GetObject("btn_showallexams.Image"), System.Drawing.Image)
        Me.btn_showallexams.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_showallexams.Name = "btn_showallexams"
        Me.btn_showallexams.Size = New System.Drawing.Size(73, 22)
        Me.btn_showallexams.Text = "Show All"
        '
        'btn_filterexams
        '
        Me.btn_filterexams.Image = CType(resources.GetObject("btn_filterexams.Image"), System.Drawing.Image)
        Me.btn_filterexams.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_filterexams.Name = "btn_filterexams"
        Me.btn_filterexams.Size = New System.Drawing.Size(98, 22)
        Me.btn_filterexams.Text = "Filter Records"
        '
        'btn_downloadexams
        '
        Me.btn_downloadexams.Image = CType(resources.GetObject("btn_downloadexams.Image"), System.Drawing.Image)
        Me.btn_downloadexams.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_downloadexams.Name = "btn_downloadexams"
        Me.btn_downloadexams.Size = New System.Drawing.Size(126, 22)
        Me.btn_downloadexams.Text = "Download Records"
        '
        'tab_events
        '
        Me.tab_events.Controls.Add(Me.data_events)
        Me.tab_events.Controls.Add(Me.tools_events)
        Me.tab_events.Location = New System.Drawing.Point(4, 22)
        Me.tab_events.Name = "tab_events"
        Me.tab_events.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_events.Size = New System.Drawing.Size(876, 535)
        Me.tab_events.TabIndex = 2
        Me.tab_events.Text = "Events"
        Me.tab_events.UseVisualStyleBackColor = True
        '
        'data_events
        '
        Me.data_events.AllowUserToAddRows = False
        Me.data_events.AllowUserToDeleteRows = False
        Me.data_events.AllowUserToResizeColumns = False
        Me.data_events.AllowUserToResizeRows = False
        Me.data_events.AutoGenerateColumns = False
        Me.data_events.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.data_events.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn12})
        Me.data_events.DataSource = Me.EventsTableBindingSource
        Me.data_events.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_events.Location = New System.Drawing.Point(3, 28)
        Me.data_events.MultiSelect = False
        Me.data_events.Name = "data_events"
        Me.data_events.ReadOnly = True
        Me.data_events.RowHeadersVisible = False
        Me.data_events.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.data_events.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_events.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_events.Size = New System.Drawing.Size(870, 504)
        Me.data_events.TabIndex = 2
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Event"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Event"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Day"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn9.HeaderText = "Day"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Start Time"
        DataGridViewCellStyle2.Format = "t"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn10.HeaderText = "Start Time"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "End Time"
        DataGridViewCellStyle3.Format = "t"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn11.HeaderText = "End Time"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Attending"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Attending"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'EventsTableBindingSource
        '
        Me.EventsTableBindingSource.DataMember = "EventsTable"
        Me.EventsTableBindingSource.DataSource = Me.AssistantDS
        '
        'tools_events
        '
        Me.tools_events.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tools_events.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_addevents, Me.btn_viewevents, Me.btn_editevents, Me.btn_deleteevents, Me.btn_clearevents, Me.ToolStripSeparator2, Me.btn_showallevents, Me.btn_filterevents, Me.btn_downloadevents})
        Me.tools_events.Location = New System.Drawing.Point(3, 3)
        Me.tools_events.Name = "tools_events"
        Me.tools_events.Size = New System.Drawing.Size(870, 25)
        Me.tools_events.TabIndex = 1
        '
        'btn_addevents
        '
        Me.btn_addevents.Image = CType(resources.GetObject("btn_addevents.Image"), System.Drawing.Image)
        Me.btn_addevents.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_addevents.Name = "btn_addevents"
        Me.btn_addevents.Size = New System.Drawing.Size(89, 22)
        Me.btn_addevents.Text = "Add Record"
        '
        'btn_viewevents
        '
        Me.btn_viewevents.Image = CType(resources.GetObject("btn_viewevents.Image"), System.Drawing.Image)
        Me.btn_viewevents.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_viewevents.Name = "btn_viewevents"
        Me.btn_viewevents.Size = New System.Drawing.Size(92, 22)
        Me.btn_viewevents.Text = "View Record"
        '
        'btn_editevents
        '
        Me.btn_editevents.Image = CType(resources.GetObject("btn_editevents.Image"), System.Drawing.Image)
        Me.btn_editevents.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_editevents.Name = "btn_editevents"
        Me.btn_editevents.Size = New System.Drawing.Size(87, 22)
        Me.btn_editevents.Text = "Edit Record"
        '
        'btn_deleteevents
        '
        Me.btn_deleteevents.Image = CType(resources.GetObject("btn_deleteevents.Image"), System.Drawing.Image)
        Me.btn_deleteevents.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_deleteevents.Name = "btn_deleteevents"
        Me.btn_deleteevents.Size = New System.Drawing.Size(100, 22)
        Me.btn_deleteevents.Text = "Delete Record"
        '
        'btn_clearevents
        '
        Me.btn_clearevents.Image = CType(resources.GetObject("btn_clearevents.Image"), System.Drawing.Image)
        Me.btn_clearevents.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_clearevents.Name = "btn_clearevents"
        Me.btn_clearevents.Size = New System.Drawing.Size(99, 22)
        Me.btn_clearevents.Text = "Clear Records"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btn_showallevents
        '
        Me.btn_showallevents.Image = CType(resources.GetObject("btn_showallevents.Image"), System.Drawing.Image)
        Me.btn_showallevents.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_showallevents.Name = "btn_showallevents"
        Me.btn_showallevents.Size = New System.Drawing.Size(73, 22)
        Me.btn_showallevents.Text = "Show All"
        '
        'btn_filterevents
        '
        Me.btn_filterevents.Image = CType(resources.GetObject("btn_filterevents.Image"), System.Drawing.Image)
        Me.btn_filterevents.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_filterevents.Name = "btn_filterevents"
        Me.btn_filterevents.Size = New System.Drawing.Size(98, 22)
        Me.btn_filterevents.Text = "Filter Records"
        '
        'btn_downloadevents
        '
        Me.btn_downloadevents.Image = CType(resources.GetObject("btn_downloadevents.Image"), System.Drawing.Image)
        Me.btn_downloadevents.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_downloadevents.Name = "btn_downloadevents"
        Me.btn_downloadevents.Size = New System.Drawing.Size(126, 22)
        Me.btn_downloadevents.Text = "Download Records"
        '
        'tab_books
        '
        Me.tab_books.Controls.Add(Me.data_books)
        Me.tab_books.Controls.Add(Me.tools_books)
        Me.tab_books.Location = New System.Drawing.Point(4, 22)
        Me.tab_books.Name = "tab_books"
        Me.tab_books.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_books.Size = New System.Drawing.Size(876, 535)
        Me.tab_books.TabIndex = 1
        Me.tab_books.Text = "Books"
        Me.tab_books.UseVisualStyleBackColor = True
        '
        'data_books
        '
        Me.data_books.AllowUserToAddRows = False
        Me.data_books.AllowUserToDeleteRows = False
        Me.data_books.AllowUserToResizeColumns = False
        Me.data_books.AllowUserToResizeRows = False
        Me.data_books.AutoGenerateColumns = False
        Me.data_books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.data_books.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn5})
        Me.data_books.DataSource = Me.BooksTableBindingSource
        Me.data_books.Dock = System.Windows.Forms.DockStyle.Fill
        Me.data_books.Location = New System.Drawing.Point(3, 28)
        Me.data_books.MultiSelect = False
        Me.data_books.Name = "data_books"
        Me.data_books.ReadOnly = True
        Me.data_books.RowHeadersVisible = False
        Me.data_books.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.data_books.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_books.Size = New System.Drawing.Size(870, 504)
        Me.data_books.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Subject"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Subject"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Book Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Book Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Full"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Full"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'BooksTableBindingSource
        '
        Me.BooksTableBindingSource.DataMember = "BooksTable"
        Me.BooksTableBindingSource.DataSource = Me.AssistantDS
        '
        'tools_books
        '
        Me.tools_books.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tools_books.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_addbooks, Me.btn_viewbooks, Me.btn_editbooks, Me.btn_deletebooks, Me.btn_clearbooks, Me.ToolStripSeparator1, Me.btn_showallbooks, Me.btn_filterbooks, Me.btn_downloadbooks})
        Me.tools_books.Location = New System.Drawing.Point(3, 3)
        Me.tools_books.Name = "tools_books"
        Me.tools_books.Size = New System.Drawing.Size(870, 25)
        Me.tools_books.TabIndex = 0
        '
        'btn_addbooks
        '
        Me.btn_addbooks.Image = CType(resources.GetObject("btn_addbooks.Image"), System.Drawing.Image)
        Me.btn_addbooks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_addbooks.Name = "btn_addbooks"
        Me.btn_addbooks.Size = New System.Drawing.Size(89, 22)
        Me.btn_addbooks.Text = "Add Record"
        '
        'btn_viewbooks
        '
        Me.btn_viewbooks.Image = CType(resources.GetObject("btn_viewbooks.Image"), System.Drawing.Image)
        Me.btn_viewbooks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_viewbooks.Name = "btn_viewbooks"
        Me.btn_viewbooks.Size = New System.Drawing.Size(92, 22)
        Me.btn_viewbooks.Text = "View Record"
        '
        'btn_editbooks
        '
        Me.btn_editbooks.Image = CType(resources.GetObject("btn_editbooks.Image"), System.Drawing.Image)
        Me.btn_editbooks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_editbooks.Name = "btn_editbooks"
        Me.btn_editbooks.Size = New System.Drawing.Size(87, 22)
        Me.btn_editbooks.Text = "Edit Record"
        '
        'btn_deletebooks
        '
        Me.btn_deletebooks.Image = CType(resources.GetObject("btn_deletebooks.Image"), System.Drawing.Image)
        Me.btn_deletebooks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_deletebooks.Name = "btn_deletebooks"
        Me.btn_deletebooks.Size = New System.Drawing.Size(100, 22)
        Me.btn_deletebooks.Text = "Delete Record"
        '
        'btn_clearbooks
        '
        Me.btn_clearbooks.Image = CType(resources.GetObject("btn_clearbooks.Image"), System.Drawing.Image)
        Me.btn_clearbooks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_clearbooks.Name = "btn_clearbooks"
        Me.btn_clearbooks.Size = New System.Drawing.Size(99, 22)
        Me.btn_clearbooks.Text = "Clear Records"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btn_showallbooks
        '
        Me.btn_showallbooks.Image = CType(resources.GetObject("btn_showallbooks.Image"), System.Drawing.Image)
        Me.btn_showallbooks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_showallbooks.Name = "btn_showallbooks"
        Me.btn_showallbooks.Size = New System.Drawing.Size(73, 22)
        Me.btn_showallbooks.Text = "Show All"
        '
        'btn_filterbooks
        '
        Me.btn_filterbooks.Image = CType(resources.GetObject("btn_filterbooks.Image"), System.Drawing.Image)
        Me.btn_filterbooks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_filterbooks.Name = "btn_filterbooks"
        Me.btn_filterbooks.Size = New System.Drawing.Size(98, 22)
        Me.btn_filterbooks.Text = "Filter Records"
        '
        'btn_downloadbooks
        '
        Me.btn_downloadbooks.Image = CType(resources.GetObject("btn_downloadbooks.Image"), System.Drawing.Image)
        Me.btn_downloadbooks.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_downloadbooks.Name = "btn_downloadbooks"
        Me.btn_downloadbooks.Size = New System.Drawing.Size(126, 22)
        Me.btn_downloadbooks.Text = "Download Records"
        '
        'tab_outlook
        '
        Me.tab_outlook.Controls.Add(Me.flow_outlook)
        Me.tab_outlook.Controls.Add(Me.tools_outlook)
        Me.tab_outlook.Location = New System.Drawing.Point(4, 22)
        Me.tab_outlook.Name = "tab_outlook"
        Me.tab_outlook.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_outlook.Size = New System.Drawing.Size(876, 535)
        Me.tab_outlook.TabIndex = 0
        Me.tab_outlook.Text = "Outlook"
        Me.tab_outlook.UseVisualStyleBackColor = True
        '
        'flow_outlook
        '
        Me.flow_outlook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flow_outlook.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flow_outlook.Location = New System.Drawing.Point(3, 28)
        Me.flow_outlook.Name = "flow_outlook"
        Me.flow_outlook.Padding = New System.Windows.Forms.Padding(5)
        Me.flow_outlook.Size = New System.Drawing.Size(870, 504)
        Me.flow_outlook.TabIndex = 1
        '
        'tools_outlook
        '
        Me.tools_outlook.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tools_outlook.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_updateoutlook})
        Me.tools_outlook.Location = New System.Drawing.Point(3, 3)
        Me.tools_outlook.Name = "tools_outlook"
        Me.tools_outlook.Size = New System.Drawing.Size(870, 25)
        Me.tools_outlook.TabIndex = 0
        '
        'btn_updateoutlook
        '
        Me.btn_updateoutlook.Image = CType(resources.GetObject("btn_updateoutlook.Image"), System.Drawing.Image)
        Me.btn_updateoutlook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_updateoutlook.Name = "btn_updateoutlook"
        Me.btn_updateoutlook.Size = New System.Drawing.Size(65, 22)
        Me.btn_updateoutlook.Text = "Update"
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.tab_outlook)
        Me.Tab.Controls.Add(Me.tab_books)
        Me.Tab.Controls.Add(Me.tab_events)
        Me.Tab.Controls.Add(Me.tab_exams)
        Me.Tab.Controls.Add(Me.tab_homework)
        Me.Tab.Controls.Add(Me.tab_letters)
        Me.Tab.Controls.Add(Me.tab_results)
        Me.Tab.Controls.Add(Me.tab_rooms)
        Me.Tab.Controls.Add(Me.tab_todos)
        Me.Tab.Controls.Add(Me.tab_settings)
        Me.Tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab.Location = New System.Drawing.Point(0, 0)
        Me.Tab.Multiline = True
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(884, 561)
        Me.Tab.TabIndex = 0
        '
        'DataGridViewTextBoxColumn64
        '
        Me.DataGridViewTextBoxColumn64.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn64.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
        Me.DataGridViewTextBoxColumn64.Visible = False
        '
        'DataGridViewTextBoxColumn65
        '
        Me.DataGridViewTextBoxColumn65.DataPropertyName = "Subject"
        Me.DataGridViewTextBoxColumn65.HeaderText = "Subject"
        Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
        Me.DataGridViewTextBoxColumn65.Width = 190
        '
        'DataGridViewTextBoxColumn66
        '
        Me.DataGridViewTextBoxColumn66.DataPropertyName = "Teacher"
        Me.DataGridViewTextBoxColumn66.HeaderText = "Teacher"
        Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
        Me.DataGridViewTextBoxColumn66.Width = 191
        '
        'DataGridViewTextBoxColumn67
        '
        Me.DataGridViewTextBoxColumn67.DataPropertyName = "Room"
        Me.DataGridViewTextBoxColumn67.HeaderText = "Room"
        Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
        Me.DataGridViewTextBoxColumn67.Width = 190
        '
        'DataGridViewTextBoxColumn68
        '
        Me.DataGridViewTextBoxColumn68.DataPropertyName = "Class"
        Me.DataGridViewTextBoxColumn68.HeaderText = "Class"
        Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
        Me.DataGridViewTextBoxColumn68.Width = 190
        '
        'HomeworkTableTableAdapter
        '
        Me.HomeworkTableTableAdapter.ClearBeforeFill = True
        '
        'BooksTableTableAdapter
        '
        Me.BooksTableTableAdapter.ClearBeforeFill = True
        '
        'EventsTableTableAdapter
        '
        Me.EventsTableTableAdapter.ClearBeforeFill = True
        '
        'ExamsTableTableAdapter
        '
        Me.ExamsTableTableAdapter.ClearBeforeFill = True
        '
        'LettersTableTableAdapter
        '
        Me.LettersTableTableAdapter.ClearBeforeFill = True
        '
        'ResultsTableTableAdapter
        '
        Me.ResultsTableTableAdapter.ClearBeforeFill = True
        '
        'RoomsTableTableAdapter
        '
        Me.RoomsTableTableAdapter.ClearBeforeFill = True
        '
        'SubjectsTableTableAdapter
        '
        Me.SubjectsTableTableAdapter.ClearBeforeFill = True
        '
        'ToDosTableTableAdapter
        '
        Me.ToDosTableTableAdapter.ClearBeforeFill = True
        '
        'HomeworkTableBindingSource1
        '
        Me.HomeworkTableBindingSource1.DataMember = "HomeworkTable"
        Me.HomeworkTableBindingSource1.DataSource = Me.AssistantDS
        '
        'BooksTableBindingSource1
        '
        Me.BooksTableBindingSource1.DataMember = "BooksTable"
        Me.BooksTableBindingSource1.DataSource = Me.AssistantDS
        '
        'BooksTableTableAdapter1
        '
        Me.BooksTableTableAdapter1.ClearBeforeFill = True
        '
        'HomeworkTableTableAdapter1
        '
        Me.HomeworkTableTableAdapter1.ClearBeforeFill = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.Tab)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tab_settings.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.data_subjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssistantDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tools_subjects.ResumeLayout(False)
        Me.tools_subjects.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tab_todos.ResumeLayout(False)
        Me.tab_todos.PerformLayout()
        CType(Me.data_todos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToDosTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tools_todos.ResumeLayout(False)
        Me.tools_todos.PerformLayout()
        Me.tab_rooms.ResumeLayout(False)
        Me.tab_rooms.PerformLayout()
        CType(Me.data_rooms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tools_rooms.ResumeLayout(False)
        Me.tools_rooms.PerformLayout()
        Me.tab_results.ResumeLayout(False)
        Me.tab_results.PerformLayout()
        CType(Me.data_results, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tools_results.ResumeLayout(False)
        Me.tools_results.PerformLayout()
        Me.tab_letters.ResumeLayout(False)
        Me.tab_letters.PerformLayout()
        CType(Me.data_letters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LettersTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tools_letters.ResumeLayout(False)
        Me.tools_letters.PerformLayout()
        Me.tab_homework.ResumeLayout(False)
        Me.tab_homework.PerformLayout()
        CType(Me.data_homeworks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeworkTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tools_homework.ResumeLayout(False)
        Me.tools_homework.PerformLayout()
        Me.tab_exams.ResumeLayout(False)
        Me.tab_exams.PerformLayout()
        CType(Me.data_exams, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tools_exams.ResumeLayout(False)
        Me.tools_exams.PerformLayout()
        Me.tab_events.ResumeLayout(False)
        Me.tab_events.PerformLayout()
        CType(Me.data_events, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventsTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tools_events.ResumeLayout(False)
        Me.tools_events.PerformLayout()
        Me.tab_books.ResumeLayout(False)
        Me.tab_books.PerformLayout()
        CType(Me.data_books, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tools_books.ResumeLayout(False)
        Me.tools_books.PerformLayout()
        Me.tab_outlook.ResumeLayout(False)
        Me.tab_outlook.PerformLayout()
        Me.tools_outlook.ResumeLayout(False)
        Me.tools_outlook.PerformLayout()
        Me.Tab.ResumeLayout(False)
        CType(Me.HomeworkTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_settings As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IDDataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents link_icons As LinkLabel
    Friend WithEvents tab_todos As TabPage
    Friend WithEvents data_todos As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DayDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents tools_todos As ToolStrip
    Friend WithEvents btn_addtodos As ToolStripButton
    Friend WithEvents btn_edittodos As ToolStripButton
    Friend WithEvents btn_deletetodos As ToolStripButton
    Friend WithEvents btn_cleartodos As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents btn_filtertodos As ToolStripButton
    Friend WithEvents btn_downloadrecords As ToolStripButton
    Friend WithEvents tab_rooms As TabPage
    Friend WithEvents data_rooms As DataGridView
    Friend WithEvents tools_rooms As ToolStrip
    Friend WithEvents btn_addrooms As ToolStripButton
    Friend WithEvents btn_editrooms As ToolStripButton
    Friend WithEvents btn_deleterooms As ToolStripButton
    Friend WithEvents btn_clearrooms As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents btn_filterrooms As ToolStripButton
    Friend WithEvents btn_downloadrooms As ToolStripButton
    Friend WithEvents SubjectDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents RecentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TopicsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents tab_results As TabPage
    Friend WithEvents data_results As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents MarkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DayDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents PercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents tools_results As ToolStrip
    Friend WithEvents btn_addresults As ToolStripButton
    Friend WithEvents btn_editresults As ToolStripButton
    Friend WithEvents btn_deleteresults As ToolStripButton
    Friend WithEvents btn_clearresults As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents btn_filterresults As ToolStripButton
    Friend WithEvents btn_downloadresults As ToolStripButton
    Friend WithEvents tab_letters As TabPage
    Friend WithEvents data_letters As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents TopicDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FromDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DayDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ResponseNeededDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ResponseGivenDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents tools_letters As ToolStrip
    Friend WithEvents btn_addletters As ToolStripButton
    Friend WithEvents btn_editletters As ToolStripButton
    Friend WithEvents btn_deleteletters As ToolStripButton
    Friend WithEvents btn_clearletters As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents btn_filterletters As ToolStripButton
    Friend WithEvents btn_downloadletters As ToolStripButton
    Friend WithEvents tab_homework As TabPage
    Friend WithEvents data_homeworks As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents SetDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SetPeriodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DuePeriodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriorityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProjectDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProgressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents tools_homework As ToolStrip
    Friend WithEvents btn_addhomeworks As ToolStripButton
    Friend WithEvents btn_edithomeworks As ToolStripButton
    Friend WithEvents btn_deletehomeworks As ToolStripButton
    Friend WithEvents btn_clearhomeworks As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents btn_filterhomeworks As ToolStripButton
    Friend WithEvents btn_downloadhomeworks As ToolStripButton
    Friend WithEvents tab_exams As TabPage
    Friend WithEvents data_exams As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DayDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StartTimeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EndTimeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents tools_exams As ToolStrip
    Friend WithEvents btn_addexams As ToolStripButton
    Friend WithEvents btn_editexams As ToolStripButton
    Friend WithEvents btn_deleteexams As ToolStripButton
    Friend WithEvents btn_clearexams As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btn_filterexams As ToolStripButton
    Friend WithEvents btn_downloadexams As ToolStripButton
    Friend WithEvents tab_events As TabPage
    Friend WithEvents data_events As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EventDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttendingDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents tools_events As ToolStrip
    Friend WithEvents btn_addevents As ToolStripButton
    Friend WithEvents btn_editevents As ToolStripButton
    Friend WithEvents btn_deleteevents As ToolStripButton
    Friend WithEvents btn_clearevents As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btn_filterevents As ToolStripButton
    Friend WithEvents btn_downloadevents As ToolStripButton
    Friend WithEvents tab_books As TabPage
    Friend WithEvents data_books As DataGridView
    Friend WithEvents BookNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents NotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tools_books As ToolStrip
    Friend WithEvents btn_addbooks As ToolStripButton
    Friend WithEvents btn_editbooks As ToolStripButton
    Friend WithEvents btn_deletebooks As ToolStripButton
    Friend WithEvents btn_clearbooks As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btn_filterbooks As ToolStripButton
    Friend WithEvents btn_downloadbooks As ToolStripButton
    Friend WithEvents tab_outlook As TabPage
    Friend WithEvents Tab As TabControl
    Friend WithEvents AssistantDS As AssistantDS
    Friend WithEvents BooksTableBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents EventsTableBindingSource As BindingSource
    Friend WithEvents ExamsTableBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents HomeworkTableBindingSource As BindingSource
    Friend WithEvents HomeworkTableTableAdapter As AssistantDSTableAdapters.HomeworkTableTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents LettersTableBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents ResultsTableBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents RoomsTableBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents ToDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents PeriodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents ToDosTableBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn63 As DataGridViewTextBoxColumn
    Friend WithEvents SubjectsTableBindingSource As BindingSource
    Friend WithEvents data_subjects As DataGridView
    Friend WithEvents tools_subjects As ToolStrip
    Friend WithEvents btn_addsubjects As ToolStripButton
    Friend WithEvents btn_editsubjects As ToolStripButton
    Friend WithEvents btn_deletesubjects As ToolStripButton
    Friend WithEvents btn_clearsubjects As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents btn_filtersubjects As ToolStripButton
    Friend WithEvents btn_downloadsubjects As ToolStripButton
    Friend WithEvents btn_showallsubjects As ToolStripButton
    Friend WithEvents btn_showalltodos As ToolStripButton
    Friend WithEvents btn_showallrooms As ToolStripButton
    Friend WithEvents btn_showallresults As ToolStripButton
    Friend WithEvents btn_showallletters As ToolStripButton
    Friend WithEvents btn_showallhomeworks As ToolStripButton
    Friend WithEvents btn_showallexams As ToolStripButton
    Friend WithEvents btn_showallevents As ToolStripButton
    Friend WithEvents btn_showallbooks As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents BooksTableTableAdapter As AssistantDSTableAdapters.BooksTableTableAdapter
    Friend WithEvents EventsTableTableAdapter As AssistantDSTableAdapters.EventsTableTableAdapter
    Friend WithEvents ExamsTableTableAdapter As AssistantDSTableAdapters.ExamsTableTableAdapter
    Friend WithEvents LettersTableTableAdapter As AssistantDSTableAdapters.LettersTableTableAdapter
    Friend WithEvents ResultsTableTableAdapter As AssistantDSTableAdapters.ResultsTableTableAdapter
    Friend WithEvents RoomsTableTableAdapter As AssistantDSTableAdapters.RoomsTableTableAdapter
    Friend WithEvents SubjectsTableTableAdapter As AssistantDSTableAdapters.SubjectsTableTableAdapter
    Friend WithEvents ToDosTableTableAdapter As AssistantDSTableAdapters.ToDosTableTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn64 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn65 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn66 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn67 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn68 As DataGridViewTextBoxColumn
    Friend WithEvents btn_viewsettings As ToolStripButton
    Friend WithEvents btn_viewtodos As ToolStripButton
    Friend WithEvents btn_viewrooms As ToolStripButton
    Friend WithEvents btn_viewresults As ToolStripButton
    Friend WithEvents btn_viewletters As ToolStripButton
    Friend WithEvents btn_viewhomeworks As ToolStripButton
    Friend WithEvents btn_viewexams As ToolStripButton
    Friend WithEvents btn_viewevents As ToolStripButton
    Friend WithEvents btn_viewbooks As ToolStripButton
    Friend WithEvents btn_homeworkupdate As Button
    Friend WithEvents chk_homeworksaturday As CheckBox
    Friend WithEvents chk_homeworksunday As CheckBox
    Friend WithEvents chk_homeworktuesday As CheckBox
    Friend WithEvents chk_homeworkwednesday As CheckBox
    Friend WithEvents chk_homeworkthursday As CheckBox
    Friend WithEvents chk_homeworkfriday As CheckBox
    Friend WithEvents chk_homeworkmonday As CheckBox
    Friend WithEvents btn_revisionupdate As Button
    Friend WithEvents chk_revisionsaturday As CheckBox
    Friend WithEvents chk_revisionsunday As CheckBox
    Friend WithEvents chk_revisiontuesday As CheckBox
    Friend WithEvents chk_revisionwednesday As CheckBox
    Friend WithEvents chk_revisionthursday As CheckBox
    Friend WithEvents chk_revisionfriday As CheckBox
    Friend WithEvents chk_revisionmonday As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents HomeworkTableBindingSource1 As BindingSource
    Friend WithEvents BooksTableBindingSource1 As BindingSource
    Friend WithEvents BooksTableTableAdapter1 As AssistantDSTableAdapters.BooksTableTableAdapter
    Friend WithEvents HomeworkTableTableAdapter1 As AssistantDSTableAdapters.HomeworkTableTableAdapter
    Friend WithEvents tools_outlook As ToolStrip
    Friend WithEvents btn_updateoutlook As ToolStripButton
    Friend WithEvents flow_outlook As FlowLayoutPanel
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TeacherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastRevisedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Revise As DataGridViewCheckBoxColumn
End Class
