<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.grp_subjects = New System.Windows.Forms.GroupBox()
        Me.btn_removesubject = New System.Windows.Forms.Button()
        Me.btn_newsubject = New System.Windows.Forms.Button()
        Me.lst_subjects = New System.Windows.Forms.ListBox()
        Me.txt_subject = New System.Windows.Forms.TextBox()
        Me.grp_exams = New System.Windows.Forms.GroupBox()
        Me.btn_deleteexam = New System.Windows.Forms.Button()
        Me.btn_addexam = New System.Windows.Forms.Button()
        Me.lst_exams = New System.Windows.Forms.ListBox()
        Me.txt_exam = New System.Windows.Forms.TextBox()
        Me.SubjectsTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.SubjectsTableAdapter()
        Me.Exam_TypesTableAdapter = New Assistant.AssistantDBDataSetTableAdapters.Exam_TypesTableAdapter()
        Me.grp_assets = New System.Windows.Forms.GroupBox()
        Me.lbl_icon4 = New System.Windows.Forms.LinkLabel()
        Me.lbl_icon3 = New System.Windows.Forms.LinkLabel()
        Me.lbl_icon2 = New System.Windows.Forms.LinkLabel()
        Me.lbl_icon1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grp_subjects.SuspendLayout()
        Me.grp_exams.SuspendLayout()
        Me.grp_assets.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_subjects
        '
        Me.grp_subjects.Controls.Add(Me.btn_removesubject)
        Me.grp_subjects.Controls.Add(Me.btn_newsubject)
        Me.grp_subjects.Controls.Add(Me.lst_subjects)
        Me.grp_subjects.Controls.Add(Me.txt_subject)
        Me.grp_subjects.Location = New System.Drawing.Point(13, 13)
        Me.grp_subjects.Name = "grp_subjects"
        Me.grp_subjects.Size = New System.Drawing.Size(302, 117)
        Me.grp_subjects.TabIndex = 0
        Me.grp_subjects.TabStop = False
        Me.grp_subjects.Text = "Manage Subjects"
        '
        'btn_removesubject
        '
        Me.btn_removesubject.Location = New System.Drawing.Point(6, 78)
        Me.btn_removesubject.Name = "btn_removesubject"
        Me.btn_removesubject.Size = New System.Drawing.Size(123, 23)
        Me.btn_removesubject.TabIndex = 3
        Me.btn_removesubject.Text = "Remove Subject"
        Me.btn_removesubject.UseVisualStyleBackColor = True
        '
        'btn_newsubject
        '
        Me.btn_newsubject.Location = New System.Drawing.Point(6, 49)
        Me.btn_newsubject.Name = "btn_newsubject"
        Me.btn_newsubject.Size = New System.Drawing.Size(123, 23)
        Me.btn_newsubject.TabIndex = 2
        Me.btn_newsubject.Text = "Add Subject"
        Me.btn_newsubject.UseVisualStyleBackColor = True
        '
        'lst_subjects
        '
        Me.lst_subjects.FormattingEnabled = True
        Me.lst_subjects.Location = New System.Drawing.Point(135, 19)
        Me.lst_subjects.Name = "lst_subjects"
        Me.lst_subjects.Size = New System.Drawing.Size(147, 82)
        Me.lst_subjects.TabIndex = 1
        '
        'txt_subject
        '
        Me.txt_subject.Location = New System.Drawing.Point(6, 19)
        Me.txt_subject.Name = "txt_subject"
        Me.txt_subject.Size = New System.Drawing.Size(123, 20)
        Me.txt_subject.TabIndex = 0
        '
        'grp_exams
        '
        Me.grp_exams.Controls.Add(Me.btn_deleteexam)
        Me.grp_exams.Controls.Add(Me.btn_addexam)
        Me.grp_exams.Controls.Add(Me.lst_exams)
        Me.grp_exams.Controls.Add(Me.txt_exam)
        Me.grp_exams.Location = New System.Drawing.Point(13, 136)
        Me.grp_exams.Name = "grp_exams"
        Me.grp_exams.Size = New System.Drawing.Size(302, 117)
        Me.grp_exams.TabIndex = 1
        Me.grp_exams.TabStop = False
        Me.grp_exams.Text = "Manage Exam Types"
        '
        'btn_deleteexam
        '
        Me.btn_deleteexam.Location = New System.Drawing.Point(6, 78)
        Me.btn_deleteexam.Name = "btn_deleteexam"
        Me.btn_deleteexam.Size = New System.Drawing.Size(123, 23)
        Me.btn_deleteexam.TabIndex = 3
        Me.btn_deleteexam.Text = "Remove Exam Type"
        Me.btn_deleteexam.UseVisualStyleBackColor = True
        '
        'btn_addexam
        '
        Me.btn_addexam.Location = New System.Drawing.Point(6, 49)
        Me.btn_addexam.Name = "btn_addexam"
        Me.btn_addexam.Size = New System.Drawing.Size(123, 23)
        Me.btn_addexam.TabIndex = 2
        Me.btn_addexam.Text = "Add Exam Type"
        Me.btn_addexam.UseVisualStyleBackColor = True
        '
        'lst_exams
        '
        Me.lst_exams.FormattingEnabled = True
        Me.lst_exams.Location = New System.Drawing.Point(135, 19)
        Me.lst_exams.Name = "lst_exams"
        Me.lst_exams.Size = New System.Drawing.Size(147, 82)
        Me.lst_exams.TabIndex = 1
        '
        'txt_exam
        '
        Me.txt_exam.Location = New System.Drawing.Point(6, 19)
        Me.txt_exam.Name = "txt_exam"
        Me.txt_exam.Size = New System.Drawing.Size(123, 20)
        Me.txt_exam.TabIndex = 0
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
        '
        'Exam_TypesTableAdapter
        '
        Me.Exam_TypesTableAdapter.ClearBeforeFill = True
        '
        'grp_assets
        '
        Me.grp_assets.Controls.Add(Me.lbl_icon4)
        Me.grp_assets.Controls.Add(Me.lbl_icon3)
        Me.grp_assets.Controls.Add(Me.lbl_icon2)
        Me.grp_assets.Controls.Add(Me.lbl_icon1)
        Me.grp_assets.Controls.Add(Me.Label1)
        Me.grp_assets.Location = New System.Drawing.Point(321, 14)
        Me.grp_assets.Name = "grp_assets"
        Me.grp_assets.Size = New System.Drawing.Size(422, 116)
        Me.grp_assets.TabIndex = 2
        Me.grp_assets.TabStop = False
        Me.grp_assets.Text = "Assets"
        '
        'lbl_icon4
        '
        Me.lbl_icon4.AutoSize = True
        Me.lbl_icon4.Location = New System.Drawing.Point(6, 83)
        Me.lbl_icon4.Name = "lbl_icon4"
        Me.lbl_icon4.Size = New System.Drawing.Size(406, 13)
        Me.lbl_icon4.TabIndex = 4
        Me.lbl_icon4.TabStop = True
        Me.lbl_icon4.Text = "https://iconarchive.com/show/ravenna-3d-icons-by-double-j-design/Books-icon.html"
        '
        'lbl_icon3
        '
        Me.lbl_icon3.AutoSize = True
        Me.lbl_icon3.Location = New System.Drawing.Point(6, 65)
        Me.lbl_icon3.Name = "lbl_icon3"
        Me.lbl_icon3.Size = New System.Drawing.Size(380, 13)
        Me.lbl_icon3.TabIndex = 3
        Me.lbl_icon3.TabStop = True
        Me.lbl_icon3.Text = "https://iconarchive.com/show/farm-fresh-icons-by-fatcow/filter-delete-icon.html"
        '
        'lbl_icon2
        '
        Me.lbl_icon2.AutoSize = True
        Me.lbl_icon2.Location = New System.Drawing.Point(6, 48)
        Me.lbl_icon2.Name = "lbl_icon2"
        Me.lbl_icon2.Size = New System.Drawing.Size(369, 13)
        Me.lbl_icon2.TabIndex = 2
        Me.lbl_icon2.TabStop = True
        Me.lbl_icon2.Text = "https://iconarchive.com/show/farm-fresh-icons-by-fatcow/filter-add-icon.html"
        '
        'lbl_icon1
        '
        Me.lbl_icon1.AutoSize = True
        Me.lbl_icon1.Location = New System.Drawing.Point(6, 31)
        Me.lbl_icon1.Name = "lbl_icon1"
        Me.lbl_icon1.Size = New System.Drawing.Size(381, 13)
        Me.lbl_icon1.TabIndex = 1
        Me.lbl_icon1.TabStop = True
        Me.lbl_icon1.Text = "http://www.customicondesign.com/free-icons/flatastic-icon-set/flatastic-part-1/"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Icons:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(321, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 116)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Product:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Version:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Year:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Author:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Sam Hirst"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "2020"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(78, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "2.0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(78, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Assistant"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 265)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_assets)
        Me.Controls.Add(Me.grp_exams)
        Me.Controls.Add(Me.grp_subjects)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant: Settings"
        Me.grp_subjects.ResumeLayout(False)
        Me.grp_subjects.PerformLayout()
        Me.grp_exams.ResumeLayout(False)
        Me.grp_exams.PerformLayout()
        Me.grp_assets.ResumeLayout(False)
        Me.grp_assets.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grp_subjects As GroupBox
    Friend WithEvents btn_removesubject As Button
    Friend WithEvents btn_newsubject As Button
    Friend WithEvents lst_subjects As ListBox
    Friend WithEvents txt_subject As TextBox
    Friend WithEvents grp_exams As GroupBox
    Friend WithEvents btn_deleteexam As Button
    Friend WithEvents btn_addexam As Button
    Friend WithEvents lst_exams As ListBox
    Friend WithEvents txt_exam As TextBox
    Friend WithEvents SubjectsTableAdapter As AssistantDBDataSetTableAdapters.SubjectsTableAdapter
    Friend WithEvents Exam_TypesTableAdapter As AssistantDBDataSetTableAdapters.Exam_TypesTableAdapter
    Friend WithEvents grp_assets As GroupBox
    Friend WithEvents lbl_icon4 As LinkLabel
    Friend WithEvents lbl_icon3 As LinkLabel
    Friend WithEvents lbl_icon2 As LinkLabel
    Friend WithEvents lbl_icon1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
