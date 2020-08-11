Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssistantDS.SubjectsTable' table. You can move, or remove it, as needed.
        Me.SubjectsTableTableAdapter.Fill(Me.AssistantDS.SubjectsTable)
        'TODO: This line of code loads data into the 'AssistantDS.ToDosTable' table. You can move, or remove it, as needed.
        Me.ToDosTableTableAdapter.Fill(Me.AssistantDS.ToDosTable)
        'TODO: This line of code loads data into the 'AssistantDS.RoomsTable' table. You can move, or remove it, as needed.
        Me.RoomsTableTableAdapter.Fill(Me.AssistantDS.RoomsTable)
        'TODO: This line of code loads data into the 'AssistantDS.ResultsTable' table. You can move, or remove it, as needed.
        Me.ResultsTableTableAdapter.Fill(Me.AssistantDS.ResultsTable)
        'TODO: This line of code loads data into the 'AssistantDS.LettersTable' table. You can move, or remove it, as needed.
        Me.LettersTableTableAdapter.Fill(Me.AssistantDS.LettersTable)
        'TODO: This line of code loads data into the 'AssistantDS.HomeworkTable' table. You can move, or remove it, as needed.
        Me.HomeworkTableTableAdapter.Fill(Me.AssistantDS.HomeworkTable)
        'TODO: This line of code loads data into the 'AssistantDS.ExamsTable' table. You can move, or remove it, as needed.
        Me.ExamsTableTableAdapter.Fill(Me.AssistantDS.ExamsTable)
        'TODO: This line of code loads data into the 'AssistantDS.EventsTable' table. You can move, or remove it, as needed.
        Me.EventsTableTableAdapter.Fill(Me.AssistantDS.EventsTable)
        'TODO: This line of code loads data into the 'AssistantDS.BooksTable' table. You can move, or remove it, as needed.
        Me.BooksTableTableAdapter.Fill(Me.AssistantDS.BooksTable)

        If My.Settings.HomeworkMonday = True Then
            chk_homeworkmonday.Checked = True
        Else
            chk_homeworkmonday.Checked = False
        End If

        If My.Settings.HomeworkTuesday = True Then
            chk_homeworktuesday.Checked = True
        Else
            chk_homeworktuesday.Checked = False
        End If

        If My.Settings.HomeworkWednesday = True Then
            chk_homeworkwednesday.Checked = True
        Else
            chk_homeworkwednesday.Checked = False
        End If

        If My.Settings.HomeworkThursday = True Then
            chk_homeworkthursday.Checked = True
        Else
            chk_homeworkthursday.Checked = False
        End If

        If My.Settings.HomeworkFriday = True Then
            chk_homeworkfriday.Checked = True
        Else
            chk_homeworkfriday.Checked = False
        End If

        If My.Settings.HomeworkSaturday = True Then
            chk_homeworksaturday.Checked = True
        Else
            chk_homeworksaturday.Checked = False
        End If

        If My.Settings.HomeworkSunday = True Then
            chk_homeworksunday.Checked = True
        Else
            chk_homeworksunday.Checked = False
        End If

        If My.Settings.RevisionMonday = True Then
            chk_revisionmonday.Checked = True
        Else
            chk_revisionmonday.Checked = False
        End If

        If My.Settings.RevisionTuesday = True Then
            chk_revisiontuesday.Checked = True
        Else
            chk_revisiontuesday.Checked = False
        End If

        If My.Settings.RevisionWednesday = True Then
            chk_revisionwednesday.Checked = True
        Else
            chk_revisionwednesday.Checked = False
        End If

        If My.Settings.RevisionThursday = True Then
            chk_revisionthursday.Checked = True
        Else
            chk_revisionthursday.Checked = False
        End If

        If My.Settings.RevisionFriday = True Then
            chk_revisionfriday.Checked = True
        Else
            chk_revisionfriday.Checked = False
        End If

        If My.Settings.RevisionSaturday = True Then
            chk_revisionsaturday.Checked = True
        Else
            chk_revisionsaturday.Checked = False
        End If

        If My.Settings.RevisionSunday = True Then
            chk_revisionsunday.Checked = True
        Else
            chk_revisionsunday.Checked = False
        End If

        btn_updateoutlook_Click(sender, e)
    End Sub

    Private Sub link_icons_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_icons.LinkClicked
        System.Diagnostics.Process.Start("http://www.aha-soft.com/")
    End Sub

    Private Sub btn_addsubjects_Click(sender As Object, e As EventArgs) Handles btn_addsubjects.Click
        AddSubjects.Show()
    End Sub

    Private Sub btn_viewsettings_Click(sender As Object, e As EventArgs) Handles btn_viewsettings.Click
        If data_subjects.SelectedRows.Count > 0 Then
            ViewSubjects.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "ViewSubjects" Then
                    Dim fcast As New ViewSubjects
                    fcast = f
                    fcast.txt_subject.Text = data_subjects.CurrentRow.Cells(1).Value
                    fcast.txt_teacher.Text = data_subjects.CurrentRow.Cells(2).Value
                    fcast.txt_room.Text = data_subjects.CurrentRow.Cells(3).Value
                    fcast.txt_class.Text = data_subjects.CurrentRow.Cells(4).Value
                    fcast.txt_lastrevised.Text = data_subjects.CurrentRow.Cells(5).Value
                    fcast.chk_revise.Checked = data_subjects.CurrentRow.Cells(6).Value
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_editsubjects_Click(sender As Object, e As EventArgs) Handles btn_editsubjects.Click
        If data_subjects.SelectedRows.Count > 0 Then
            EditSubjects.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "EditSubjects" Then
                    Dim fcast As New EditSubjects
                    fcast = f
                    fcast.lbl_id.Text = data_subjects.CurrentRow.Cells(0).Value
                    fcast.txt_subject.Text = data_subjects.CurrentRow.Cells(1).Value
                    fcast.txt_teacher.Text = data_subjects.CurrentRow.Cells(2).Value
                    fcast.txt_room.Text = data_subjects.CurrentRow.Cells(3).Value
                    fcast.txt_class.Text = data_subjects.CurrentRow.Cells(4).Value
                    fcast.lbl_lastrevised.Text = data_subjects.CurrentRow.Cells(5).Value
                    fcast.chk_revise.Checked = data_subjects.CurrentRow.Cells(6).Value
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btn_deletesubjects_Click(sender As Object, e As EventArgs) Handles btn_deletesubjects.Click
        If data_subjects.SelectedRows.Count > 0 Then
            Dim result As Integer = MessageBox.Show("Are you sure you would like to delete this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                SubjectsTableBindingSource.EndEdit()
                SubjectsTableTableAdapter.Remove(data_subjects.CurrentRow.Cells(0).Value)
                SubjectsTableTableAdapter.Fill(AssistantDS.SubjectsTable)
                MessageBox.Show("The record was deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You have not selected a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btn_clearsubjects_Click(sender As Object, e As EventArgs) Handles btn_clearsubjects.Click
        Dim result As Integer = MessageBox.Show("Are you sure you would like to delete all records?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            SubjectsTableBindingSource.EndEdit()
            SubjectsTableTableAdapter.Clear()
            SubjectsTableTableAdapter.Fill(AssistantDS.SubjectsTable)
        End If
        MessageBox.Show("All records have been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub btn_showallsubjects_Click(sender As Object, e As EventArgs) Handles btn_showallsubjects.Click
        Me.SubjectsTableTableAdapter.Fill(Me.AssistantDS.SubjectsTable)
    End Sub
    Private Sub btn_filtersubjects_Click(sender As Object, e As EventArgs) Handles btn_filtersubjects.Click
        FilterSubjects.Show()
    End Sub
    Private Sub btn_downloadsubjects_Click(sender As Object, e As EventArgs) Handles btn_downloadsubjects.Click
        Dim FileName As String
        FileName = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant\Subjects.csv"
        If (Not System.IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")) Then
            System.IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")
        End If
        Dim objWriter As New System.IO.StreamWriter(FileName)

        For Each c In data_subjects.Columns
            If (Not c.index = 0) Then
                objWriter.Write(data_subjects.Columns(c.index).HeaderText + ",")
            End If
        Next

        objWriter.Write(Environment.NewLine)

        For Each r In data_subjects.Rows
            For Each c In r.Cells
                If (Not c.ColumnIndex = 0) Then
                    objWriter.Write(c.Value.ToString + ",")
                End If
            Next
            objWriter.Write(Environment.NewLine)
        Next

        objWriter.Close()
        MessageBox.Show("The data has been downloaded to " + FileName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_addbooks_Click(sender As Object, e As EventArgs) Handles btn_addbooks.Click
        AddBooks.Show()
    End Sub

    Private Sub btn_viewbooks_Click(sender As Object, e As EventArgs) Handles btn_viewbooks.Click
        If data_books.SelectedRows.Count > 0 Then
            ViewBooks.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "ViewBooks" Then
                    Dim fcast As New ViewBooks
                    fcast = f
                    fcast.txt_subject.Text = data_books.CurrentRow.Cells(1).Value
                    fcast.txt_bookname.Text = data_books.CurrentRow.Cells(2).Value
                    fcast.txt_location.Text = data_books.CurrentRow.Cells(3).Value
                    fcast.chk_full.Checked = data_books.CurrentRow.Cells(4).Value
                    fcast.txt_notes.Text = data_books.CurrentRow.Cells(5).Value
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to view.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_editbooks_Click(sender As Object, e As EventArgs) Handles btn_editbooks.Click
        If data_books.SelectedRows.Count > 0 Then
            EditBooks.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "EditBooks" Then
                    Dim fcast As New EditBooks
                    fcast = f
                    fcast.lbl_id.Text = data_books.CurrentRow.Cells(0).Value
                    fcast.com_subject.Text = data_books.CurrentRow.Cells(1).Value
                    fcast.txt_bookname.Text = data_books.CurrentRow.Cells(2).Value
                    fcast.txt_location.Text = data_books.CurrentRow.Cells(3).Value
                    fcast.chk_full.Checked = data_books.CurrentRow.Cells(4).Value
                    fcast.txt_notes.Text = data_books.CurrentRow.Cells(5).Value
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_deletebooks_Click(sender As Object, e As EventArgs) Handles btn_deletebooks.Click
        If data_books.SelectedRows.Count > 0 Then
            Dim result As Integer = MessageBox.Show("Are you sure you would like to delete this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                BooksTableBindingSource.EndEdit()
                BooksTableTableAdapter.Remove(data_books.CurrentRow.Cells(0).Value)
                BooksTableTableAdapter.Fill(AssistantDS.BooksTable)
                MessageBox.Show("The record was deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You have not selected a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_clearbooks_Click(sender As Object, e As EventArgs) Handles btn_clearbooks.Click
        Dim result As Integer = MessageBox.Show("Are you sure you would like to delete all records?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            BooksTableBindingSource.EndEdit()
            BooksTableTableAdapter.Clear()
            BooksTableTableAdapter.Fill(AssistantDS.BooksTable)
            MessageBox.Show("All records have been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_showallbooks_Click(sender As Object, e As EventArgs) Handles btn_showallbooks.Click
        Me.BooksTableTableAdapter.Fill(Me.AssistantDS.BooksTable)
    End Sub

    Private Sub btn_filterbooks_Click(sender As Object, e As EventArgs) Handles btn_filterbooks.Click
        FilterBooks.Show()
    End Sub

    Private Sub btn_downloadbooks_Click(sender As Object, e As EventArgs) Handles btn_downloadbooks.Click
        Dim FileName As String
        FileName = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant\Books.csv"
        If (Not System.IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")) Then
            System.IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")
        End If
        Dim objWriter As New System.IO.StreamWriter(FileName)

        For Each c In data_books.Columns
            If (Not c.index = 0) Then
                objWriter.Write(data_books.Columns(c.index).HeaderText + ",")
            End If
        Next

        objWriter.Write(Environment.NewLine)

        For Each r In data_books.Rows
            For Each c In r.Cells
                If (Not c.ColumnIndex = 0) Then
                    objWriter.Write(c.Value.ToString + ",")
                End If
            Next
            objWriter.Write(Environment.NewLine)
        Next

        objWriter.Close()
        MessageBox.Show("The data has been downloaded to " + FileName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_addevents_Click(sender As Object, e As EventArgs) Handles btn_addevents.Click
        AddEvents.Show()
    End Sub

    Private Sub btn_viewevents_Click(sender As Object, e As EventArgs) Handles btn_viewevents.Click
        If data_events.SelectedRows.Count > 0 Then
            ViewEvents.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "ViewEvents" Then
                    Dim fcast As New ViewEvents
                    fcast = f
                    fcast.txt_event.Text = data_events.CurrentRow.Cells(1).Value
                    fcast.txt_location.Text = data_events.CurrentRow.Cells(2).Value
                    fcast.txt_date.Text = data_events.CurrentRow.Cells(3).Value
                    fcast.txt_starttime.Text = data_events.CurrentRow.Cells(4).Value
                    fcast.txt_endtime.Text = data_events.CurrentRow.Cells(5).Value
                    fcast.chk_attending.Checked = data_events.CurrentRow.Cells(6).Value
                    If IsDBNull(data_events.CurrentRow.Cells(7).Value) Then
                        fcast.txt_notes.Text = data_events.CurrentRow.Cells(7).Value
                    End If
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to view.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_editevents_Click(sender As Object, e As EventArgs) Handles btn_editevents.Click
        If data_events.SelectedRows.Count > 0 Then
            EditEvents.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "EditEvents" Then
                    Dim fcast As New EditEvents
                    fcast = f
                    fcast.lbl_id.Text = data_events.CurrentRow.Cells(0).Value
                    fcast.txt_event.Text = data_events.CurrentRow.Cells(1).Value
                    fcast.txt_location.Text = data_events.CurrentRow.Cells(2).Value
                    fcast.date_date.Value = Date.Parse(data_events.CurrentRow.Cells(3).Value)
                    fcast.date_starttime.Value = Date.Parse(data_events.CurrentRow.Cells(4).Value)
                    fcast.date_endtime.Value = Date.Parse(data_events.CurrentRow.Cells(5).Value)
                    fcast.chk_attending.Checked = data_events.CurrentRow.Cells(6).Value
                    If IsDBNull(data_events.CurrentRow.Cells(7).Value) Then
                        fcast.txt_notes.Text = data_events.CurrentRow.Cells(7).Value
                    End If
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_deleteevents_Click(sender As Object, e As EventArgs) Handles btn_deleteevents.Click
        If data_events.SelectedRows.Count > 0 Then
            Dim result As Integer = MessageBox.Show("Are you sure you would like to delete this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                EventsTableBindingSource.EndEdit()
                EventsTableTableAdapter.Remove(data_events.CurrentRow.Cells(0).Value)
                EventsTableTableAdapter.Fill(AssistantDS.EventsTable)
                MessageBox.Show("The record was deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You have not selected a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_clearevents_Click(sender As Object, e As EventArgs) Handles btn_clearevents.Click
        Dim result As Integer = MessageBox.Show("Are you sure you would like to delete all records?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            EventsTableBindingSource.EndEdit()
            EventsTableTableAdapter.Clear()
            EventsTableTableAdapter.Fill(AssistantDS.EventsTable)
            MessageBox.Show("All records have been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_showallevents_Click(sender As Object, e As EventArgs) Handles btn_showallevents.Click
        Me.EventsTableTableAdapter.Fill(Me.AssistantDS.EventsTable)
    End Sub

    Private Sub btn_filterevents_Click(sender As Object, e As EventArgs) Handles btn_filterevents.Click
        FilterEvents.Show()
    End Sub

    Private Sub btn_downloadevents_Click(sender As Object, e As EventArgs) Handles btn_downloadevents.Click
        Dim FileName As String
        FileName = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant\Events.csv"
        If (Not System.IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")) Then
            System.IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")
        End If
        Dim objWriter As New System.IO.StreamWriter(FileName)

        For Each c In data_events.Columns
            If (Not c.index = 0) Then
                objWriter.Write(data_events.Columns(c.index).HeaderText + ",")
            End If
        Next

        objWriter.Write(Environment.NewLine)

        For Each r In data_events.Rows
            For Each c In r.Cells
                If (Not c.ColumnIndex = 0) Then
                    objWriter.Write(c.Value.ToString + ",")
                End If
            Next
            objWriter.Write(Environment.NewLine)
        Next

        objWriter.Close()
        MessageBox.Show("The data has been downloaded to " + FileName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_addexams_Click(sender As Object, e As EventArgs) Handles btn_addexams.Click
        AddExams.Show()
    End Sub

    Private Sub btn_viewexams_Click(sender As Object, e As EventArgs) Handles btn_viewexams.Click
        If data_exams.SelectedRows.Count > 0 Then
            ViewExams.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "ViewExams" Then
                    Dim fcast As New ViewExams
                    fcast = f
                    fcast.txt_subject.Text = data_exams.CurrentRow.Cells(1).Value
                    fcast.txt_location.Text = data_exams.CurrentRow.Cells(2).Value
                    fcast.txt_date.Text = data_exams.CurrentRow.Cells(3).Value
                    fcast.txt_starttime.Text = data_exams.CurrentRow.Cells(4).Value
                    fcast.txt_endtime.Text = data_exams.CurrentRow.Cells(5).Value
                    If IsDBNull(data_exams.CurrentRow.Cells(6).Value) Then
                        fcast.txt_notes.Text = data_exams.CurrentRow.Cells(6).Value
                    End If
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to view.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_editexams_Click(sender As Object, e As EventArgs) Handles btn_editexams.Click
        If data_exams.SelectedRows.Count > 0 Then
            EditExams.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "EditExams" Then
                    Dim fcast As New EditExams
                    fcast = f
                    fcast.lbl_id.Text = data_exams.CurrentRow.Cells(0).Value
                    fcast.com_subject.Text = data_exams.CurrentRow.Cells(1).Value
                    fcast.txt_location.Text = data_exams.CurrentRow.Cells(2).Value
                    fcast.date_date.Value = Date.Parse(data_exams.CurrentRow.Cells(3).Value)
                    fcast.date_starttime.Value = Date.Parse(data_exams.CurrentRow.Cells(4).Value)
                    fcast.date_endtime.Value = Date.Parse(data_exams.CurrentRow.Cells(5).Value)
                    If IsDBNull(data_exams.CurrentRow.Cells(6).Value) Then
                        fcast.txt_notes.Text = data_exams.CurrentRow.Cells(6).Value
                    End If
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_deleteexams_Click(sender As Object, e As EventArgs) Handles btn_deleteexams.Click
        If data_exams.SelectedRows.Count > 0 Then
            Dim result As Integer = MessageBox.Show("Are you sure you would like to delete this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                ExamsTableBindingSource.EndEdit()
                ExamsTableTableAdapter.Remove(data_exams.CurrentRow.Cells(0).Value)
                ExamsTableTableAdapter.Fill(AssistantDS.ExamsTable)
                MessageBox.Show("The record was deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You have not selected a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_clearexams_Click(sender As Object, e As EventArgs) Handles btn_clearexams.Click
        Dim result As Integer = MessageBox.Show("Are you sure you would like to delete all records?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            ExamsTableBindingSource.EndEdit()
            ExamsTableTableAdapter.Clear()
            ExamsTableTableAdapter.Fill(AssistantDS.ExamsTable)
            MessageBox.Show("All records have been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_showallexams_Click(sender As Object, e As EventArgs) Handles btn_showallexams.Click
        Me.EventsTableTableAdapter.Fill(Me.AssistantDS.EventsTable)
    End Sub

    Private Sub btn_filterexams_Click(sender As Object, e As EventArgs) Handles btn_filterexams.Click
        FilterExams.Show()
    End Sub

    Private Sub btn_downloadexams_Click(sender As Object, e As EventArgs) Handles btn_downloadexams.Click
        Dim FileName As String
        FileName = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant\Exams.csv"
        If (Not System.IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")) Then
            System.IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")
        End If
        Dim objWriter As New System.IO.StreamWriter(FileName)

        For Each c In data_exams.Columns
            If (Not c.index = 0) Then
                objWriter.Write(data_exams.Columns(c.index).HeaderText + ",")
            End If
        Next

        objWriter.Write(Environment.NewLine)

        For Each r In data_exams.Rows
            For Each c In r.Cells
                If (Not c.ColumnIndex = 0) Then
                    objWriter.Write(c.Value.ToString + ",")
                End If
            Next
            objWriter.Write(Environment.NewLine)
        Next

        objWriter.Close()
        MessageBox.Show("The data has been downloaded to " + FileName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_addhomeworks_Click(sender As Object, e As EventArgs) Handles btn_addhomeworks.Click
        AddHomework.Show()
    End Sub

    Private Sub btn_viewhomeworks_Click(sender As Object, e As EventArgs) Handles btn_viewhomeworks.Click
        If data_homeworks.SelectedRows.Count > 0 Then
            ViewHomework.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "ViewHomework" Then
                    Dim fcast As New ViewHomework
                    fcast = f
                    fcast.txt_subject.Text = data_homeworks.CurrentRow.Cells(1).Value
                    If IsDBNull(data_homeworks.CurrentRow.Cells(2).Value) Then
                        fcast.txt_setdate.Enabled = False
                        fcast.txt_setdate.Text = ""
                        fcast.txt_set.Enabled = False
                        fcast.txt_set.Text = ""
                        fcast.chk_set.Checked = False
                    Else
                        fcast.txt_setdate.Enabled = True
                        fcast.txt_set.Enabled = True
                        fcast.txt_setdate.Text = data_homeworks.CurrentRow.Cells(2).Value
                        fcast.txt_set.Text = data_homeworks.CurrentRow.Cells(3).Value
                        fcast.chk_set.Checked = True
                    End If
                    If IsDBNull(data_homeworks.CurrentRow.Cells(4).Value) Then
                        fcast.txt_duedate.Enabled = False
                        fcast.txt_duedate.Text = ""
                        fcast.txt_due.Enabled = False
                        fcast.txt_due.Text = ""
                        fcast.chk_due.Checked = False
                    Else
                        fcast.txt_duedate.Enabled = True
                        fcast.txt_due.Enabled = True
                        fcast.txt_duedate.Text = data_homeworks.CurrentRow.Cells(4).Value
                        fcast.txt_due.Text = data_homeworks.CurrentRow.Cells(5).Value
                        fcast.chk_due.Checked = True
                    End If
                    fcast.txt_priority.Text = data_homeworks.CurrentRow.Cells(6).Value
                    fcast.txt_status.Text = data_homeworks.CurrentRow.Cells(7).Value
                    fcast.txt_completion.Text = data_homeworks.CurrentRow.Cells(8).Value
                    fcast.txt_description.Text = data_homeworks.CurrentRow.Cells(9).Value
                    If IsDBNull(data_homeworks.CurrentRow.Cells(10).Value) Then
                        fcast.txt_notes.Text = data_homeworks.CurrentRow.Cells(10).Value
                    End If
                    fcast.chk_project.Checked = data_homeworks.CurrentRow.Cells(11).Value
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to view.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_edithomeworks_Click(sender As Object, e As EventArgs) Handles btn_edithomeworks.Click
        If data_homeworks.SelectedRows.Count > 0 Then
            EditHomework.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "EditHomework" Then
                    Dim fcast As New EditHomework
                    fcast = f
                    fcast.lbl_id.Text = data_homeworks.CurrentRow.Cells(0).Value
                    fcast.com_subject.Text = data_homeworks.CurrentRow.Cells(1).Value
                    If IsDBNull(data_homeworks.CurrentRow.Cells(2).Value) Then
                        fcast.date_set.Enabled = False
                        fcast.txt_set.Enabled = False
                        fcast.date_set.Value = Now
                        fcast.txt_set.Text = ""
                        fcast.chk_set.Checked = False
                    Else
                        fcast.date_set.Enabled = True
                        fcast.txt_set.Enabled = True
                        fcast.date_set.Value = Date.Parse(data_homeworks.CurrentRow.Cells(2).Value)
                        fcast.txt_set.Text = data_homeworks.CurrentRow.Cells(3).Value
                        fcast.chk_set.Checked = True
                    End If
                    If IsDBNull(data_homeworks.CurrentRow.Cells(4).Value) Then
                        fcast.date_due.Enabled = False
                        fcast.txt_due.Enabled = False
                        fcast.date_due.Value = Now
                        fcast.txt_due.Text = ""
                        fcast.chk_due.Checked = False
                    Else
                        fcast.date_due.Enabled = True
                        fcast.txt_due.Enabled = True
                        fcast.date_due.Value = Date.Parse(data_homeworks.CurrentRow.Cells(4).Value)
                        fcast.txt_due.Text = data_homeworks.CurrentRow.Cells(5).Value
                        fcast.chk_due.Checked = True
                    End If
                    fcast.com_priority.Text = data_homeworks.CurrentRow.Cells(6).Value
                    fcast.com_status.Text = data_homeworks.CurrentRow.Cells(7).Value
                    fcast.num_completion.Value = data_homeworks.CurrentRow.Cells(8).Value
                    fcast.txt_description.Text = data_homeworks.CurrentRow.Cells(9).Value
                    If IsDBNull(data_homeworks.CurrentRow.Cells(10).Value) Then
                        fcast.txt_notes.Text = data_homeworks.CurrentRow.Cells(10).Value
                    End If
                    fcast.chk_project.Checked = data_homeworks.CurrentRow.Cells(11).Value
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_deletehomeworks_Click(sender As Object, e As EventArgs) Handles btn_deletehomeworks.Click
        If data_homeworks.SelectedRows.Count > 0 Then
            Dim result As Integer = MessageBox.Show("Are you sure you would like to delete this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                HomeworkTableBindingSource.EndEdit()
                HomeworkTableTableAdapter.Remove(data_homeworks.CurrentRow.Cells(0).Value)
                HomeworkTableTableAdapter.Fill(AssistantDS.HomeworkTable)
                MessageBox.Show("The record was deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You have not selected a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_clearhomeworks_Click(sender As Object, e As EventArgs) Handles btn_clearhomeworks.Click
        Dim result As Integer = MessageBox.Show("Are you sure you would like to delete all records?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            HomeworkTableBindingSource.EndEdit()
            HomeworkTableTableAdapter.Clear()
            HomeworkTableTableAdapter.Fill(AssistantDS.HomeworkTable)
            MessageBox.Show("All records have been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_showallhomeworks_Click(sender As Object, e As EventArgs) Handles btn_showallhomeworks.Click
        Me.HomeworkTableTableAdapter.Fill(Me.AssistantDS.HomeworkTable)
    End Sub

    Private Sub btn_filterhomeworks_Click(sender As Object, e As EventArgs) Handles btn_filterhomeworks.Click
        FilterHomeworks.Show()
    End Sub

    Private Sub btn_downloadhomeworks_Click(sender As Object, e As EventArgs) Handles btn_downloadhomeworks.Click
        Dim FileName As String
        FileName = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant\Homeworks.csv"
        If (Not System.IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")) Then
            System.IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")
        End If
        Dim objWriter As New System.IO.StreamWriter(FileName)

        For Each c In data_homeworks.Columns
            If (Not c.index = 0) Then
                objWriter.Write(data_homeworks.Columns(c.index).HeaderText + ",")
            End If
        Next

        objWriter.Write(Environment.NewLine)

        For Each r In data_homeworks.Rows
            For Each c In r.Cells
                If (Not c.ColumnIndex = 0) Then
                    objWriter.Write(c.Value.ToString + ",")
                End If
            Next
            objWriter.Write(Environment.NewLine)
        Next

        objWriter.Close()
        MessageBox.Show("The data has been downloaded to " + FileName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_addletters_Click(sender As Object, e As EventArgs) Handles btn_addletters.Click
        AddLetters.Show()
    End Sub

    Private Sub btn_viewletters_Click(sender As Object, e As EventArgs) Handles btn_viewletters.Click
        If data_letters.SelectedRows.Count > 0 Then
            ViewLetters.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "ViewLetters" Then
                    Dim fcast As New ViewLetters
                    fcast = f
                    fcast.txt_topic.Text = data_letters.CurrentRow.Cells(1).Value
                    fcast.txt_from.Text = data_letters.CurrentRow.Cells(2).Value
                    fcast.txt_date.Text = data_letters.CurrentRow.Cells(3).Value
                    fcast.chk_responseneeded.Checked = data_letters.CurrentRow.Cells(4).Value
                    fcast.chk_responsegiven.Checked = data_letters.CurrentRow.Cells(5).Value
                    If IsDBNull(data_letters.CurrentRow.Cells(6).Value) Then
                        fcast.txt_notes.Text = data_letters.CurrentRow.Cells(6).Value
                    End If
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to view.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_editletters_Click(sender As Object, e As EventArgs) Handles btn_editletters.Click
        If data_letters.SelectedRows.Count > 0 Then
            EditLetters.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "EditLetters" Then
                    Dim fcast As New EditLetters
                    fcast = f
                    fcast.lbl_id.Text = data_letters.CurrentRow.Cells(0).Value
                    fcast.txt_topic.Text = data_letters.CurrentRow.Cells(1).Value
                    fcast.txt_from.Text = data_letters.CurrentRow.Cells(2).Value
                    fcast.date_date.Value = Date.Parse(data_letters.CurrentRow.Cells(3).Value)
                    fcast.chk_responseneeded.Checked = data_letters.CurrentRow.Cells(4).Value
                    fcast.chk_responsegiven.Checked = data_letters.CurrentRow.Cells(5).Value
                    If IsDBNull(data_letters.CurrentRow.Cells(6).Value) Then
                        fcast.txt_notes.Text = data_letters.CurrentRow.Cells(6).Value
                    End If
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_deleteletters_Click(sender As Object, e As EventArgs) Handles btn_deleteletters.Click
        If data_letters.SelectedRows.Count > 0 Then
            Dim result As Integer = MessageBox.Show("Are you sure you would like to delete this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                LettersTableBindingSource.EndEdit()
                LettersTableTableAdapter.Remove(data_letters.CurrentRow.Cells(0).Value)
                LettersTableTableAdapter.Fill(AssistantDS.LettersTable)
                MessageBox.Show("The record was deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You have not selected a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_clearletters_Click(sender As Object, e As EventArgs) Handles btn_clearletters.Click
        Dim result As Integer = MessageBox.Show("Are you sure you would like to delete all records?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            LettersTableBindingSource.EndEdit()
            LettersTableTableAdapter.Clear()
            LettersTableTableAdapter.Fill(AssistantDS.LettersTable)
            MessageBox.Show("All records have been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_showallletters_Click(sender As Object, e As EventArgs) Handles btn_showallletters.Click
        Me.LettersTableTableAdapter.Fill(Me.AssistantDS.LettersTable)
    End Sub

    Private Sub btn_filterletters_Click(sender As Object, e As EventArgs) Handles btn_filterletters.Click
        FilterLetters.Show()
    End Sub

    Private Sub btn_downloadletters_Click(sender As Object, e As EventArgs) Handles btn_downloadletters.Click
        Dim FileName As String
        FileName = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant\Letters.csv"
        If (Not System.IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")) Then
            System.IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")
        End If
        Dim objWriter As New System.IO.StreamWriter(FileName)

        For Each c In data_letters.Columns
            If (Not c.index = 0) Then
                objWriter.Write(data_letters.Columns(c.index).HeaderText + ",")
            End If
        Next

        objWriter.Write(Environment.NewLine)

        For Each r In data_letters.Rows
            For Each c In r.Cells
                If (Not c.ColumnIndex = 0) Then
                    objWriter.Write(c.Value.ToString + ",")
                End If
            Next
            objWriter.Write(Environment.NewLine)
        Next

        objWriter.Close()
        MessageBox.Show("The data has been downloaded to " + FileName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_addresults_Click(sender As Object, e As EventArgs) Handles btn_addresults.Click
        AddResults.Show()
    End Sub

    Private Sub btn_viewresults_Click(sender As Object, e As EventArgs) Handles btn_viewresults.Click
        If data_results.SelectedRows.Count > 0 Then
            ViewResults.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "ViewResults" Then
                    Dim fcast As New ViewResults
                    fcast = f
                    fcast.txt_subject.Text = data_results.CurrentRow.Cells(1).Value
                    fcast.txt_marks.Text = data_results.CurrentRow.Cells(2).Value
                    fcast.txt_total.Text = data_results.CurrentRow.Cells(3).Value
                    fcast.txt_grade.Text = data_results.CurrentRow.Cells(4).Value
                    fcast.txt_date.Text = Date.Parse(data_results.CurrentRow.Cells(5).Value)
                    If IsDBNull(data_results.CurrentRow.Cells(6).Value) Then
                        fcast.txt_notes.Text = data_results.CurrentRow.Cells(6).Value
                    End If
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to view.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_editresults_Click(sender As Object, e As EventArgs) Handles btn_editresults.Click
        If data_results.SelectedRows.Count > 0 Then
            EditResults.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "EditResults" Then
                    Dim fcast As New EditResults
                    fcast = f
                    fcast.lbl_id.Text = data_results.CurrentRow.Cells(0).Value
                    fcast.com_subject.Text = data_results.CurrentRow.Cells(1).Value
                    fcast.num_marks.Value = data_results.CurrentRow.Cells(2).Value
                    fcast.num_total.Value = data_results.CurrentRow.Cells(3).Value
                    fcast.txt_grade.Text = data_results.CurrentRow.Cells(4).Value
                    fcast.date_date.Value = Date.Parse(data_results.CurrentRow.Cells(5).Value)
                    If IsDBNull(data_results.CurrentRow.Cells(6).Value) Then
                        fcast.txt_notes.Text = data_results.CurrentRow.Cells(6).Value
                    End If
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_deleteresults_Click(sender As Object, e As EventArgs) Handles btn_deleteresults.Click
        If data_results.SelectedRows.Count > 0 Then
            Dim result As Integer = MessageBox.Show("Are you sure you would like to delete this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                ResultsTableBindingSource.EndEdit()
                ResultsTableTableAdapter.Remove(data_results.CurrentRow.Cells(0).Value)
                ResultsTableTableAdapter.Fill(AssistantDS.ResultsTable)
                MessageBox.Show("The record was deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You have not selected a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_clearresults_Click(sender As Object, e As EventArgs) Handles btn_clearresults.Click
        Dim result As Integer = MessageBox.Show("Are you sure you would like to delete all records?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            ResultsTableBindingSource.EndEdit()
            ResultsTableTableAdapter.Clear()
            ResultsTableTableAdapter.Fill(AssistantDS.ResultsTable)
            MessageBox.Show("All records have been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_showallresults_Click(sender As Object, e As EventArgs) Handles btn_showallresults.Click
        Me.ResultsTableTableAdapter.Fill(Me.AssistantDS.ResultsTable)
    End Sub

    Private Sub btn_filterresults_Click(sender As Object, e As EventArgs) Handles btn_filterresults.Click
        FilterResults.Show()
    End Sub

    Private Sub btn_downloadresults_Click(sender As Object, e As EventArgs) Handles btn_downloadresults.Click
        Dim FileName As String
        FileName = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant\Results.csv"
        If (Not System.IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")) Then
            System.IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")
        End If
        Dim objWriter As New System.IO.StreamWriter(FileName)

        For Each c In data_results.Columns
            If (Not c.index = 0) Then
                objWriter.Write(data_results.Columns(c.index).HeaderText + ",")
            End If
        Next

        objWriter.Write(Environment.NewLine)

        For Each r In data_results.Rows
            For Each c In r.Cells
                If (Not c.ColumnIndex = 0) Then
                    objWriter.Write(c.Value.ToString + ",")
                End If
            Next
            objWriter.Write(Environment.NewLine)
        Next

        objWriter.Close()
        MessageBox.Show("The data has been downloaded to " + FileName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_addrooms_Click(sender As Object, e As EventArgs) Handles btn_addrooms.Click
        AddRooms.Show()
    End Sub

    Private Sub btn_viewrooms_Click(sender As Object, e As EventArgs) Handles btn_viewrooms.Click
        If data_rooms.SelectedRows.Count > 0 Then
            ViewRooms.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "ViewRooms" Then
                    Dim fcast As New ViewRooms
                    fcast = f
                    fcast.txt_subject.Text = data_rooms.CurrentRow.Cells(1).Value
                    fcast.txt_from.Text = data_rooms.CurrentRow.Cells(2).Value
                    fcast.txt_to.Text = data_rooms.CurrentRow.Cells(3).Value
                    fcast.txt_date.Text = data_rooms.CurrentRow.Cells(4).Value
                    fcast.txt_period.Text = data_rooms.CurrentRow.Cells(5).Value
                    fcast.txt_reason.Text = data_rooms.CurrentRow.Cells(6).Value
                    If IsDBNull(data_rooms.CurrentRow.Cells(7).Value) Then
                        fcast.txt_notes.Text = data_rooms.CurrentRow.Cells(7).Value
                    End If
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to view.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_editrooms_Click(sender As Object, e As EventArgs) Handles btn_editrooms.Click
        If data_rooms.SelectedRows.Count > 0 Then
            EditRooms.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "EditRooms" Then
                    Dim fcast As New EditRooms
                    fcast = f
                    fcast.lbl_id.Text = data_rooms.CurrentRow.Cells(0).Value
                    fcast.com_subject.Text = data_rooms.CurrentRow.Cells(1).Value
                    fcast.txt_from.Text = data_rooms.CurrentRow.Cells(2).Value
                    fcast.txt_to.Text = data_rooms.CurrentRow.Cells(3).Value
                    fcast.date_date.Value = Date.Parse(data_rooms.CurrentRow.Cells(4).Value)
                    fcast.txt_period.Text = data_rooms.CurrentRow.Cells(5).Value
                    fcast.txt_reason.Text = data_rooms.CurrentRow.Cells(6).Value
                    If IsDBNull(data_rooms.CurrentRow.Cells(7).Value) Then
                        fcast.txt_notes.Text = data_rooms.CurrentRow.Cells(7).Value
                    End If
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_deleterooms_Click(sender As Object, e As EventArgs) Handles btn_deleterooms.Click
        If data_rooms.SelectedRows.Count > 0 Then
            Dim result As Integer = MessageBox.Show("Are you sure you would like to delete this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                RoomsTableBindingSource.EndEdit()
                RoomsTableTableAdapter.Remove(data_rooms.CurrentRow.Cells(0).Value)
                RoomsTableTableAdapter.Fill(AssistantDS.RoomsTable)
                MessageBox.Show("The record was deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You have not selected a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_clearrooms_Click(sender As Object, e As EventArgs) Handles btn_clearrooms.Click
        Dim result As Integer = MessageBox.Show("Are you sure you would like to delete all records?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            RoomsTableBindingSource.EndEdit()
            RoomsTableTableAdapter.Clear()
            RoomsTableTableAdapter.Fill(AssistantDS.RoomsTable)
            MessageBox.Show("All records have been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_showallrooms_Click(sender As Object, e As EventArgs) Handles btn_showallrooms.Click
        Me.RoomsTableTableAdapter.Fill(Me.AssistantDS.RoomsTable)
    End Sub

    Private Sub btn_filterrooms_Click(sender As Object, e As EventArgs) Handles btn_filterrooms.Click
        FilterRooms.Show()
    End Sub

    Private Sub btn_downloadrooms_Click(sender As Object, e As EventArgs) Handles btn_downloadrooms.Click
        Dim FileName As String
        FileName = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant\Rooms.csv"
        If (Not System.IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")) Then
            System.IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")
        End If
        Dim objWriter As New System.IO.StreamWriter(FileName)

        For Each c In data_rooms.Columns
            If (Not c.index = 0) Then
                objWriter.Write(data_rooms.Columns(c.index).HeaderText + ",")
            End If
        Next

        objWriter.Write(Environment.NewLine)

        For Each r In data_rooms.Rows
            For Each c In r.Cells
                If (Not c.ColumnIndex = 0) Then
                    objWriter.Write(c.Value.ToString + ",")
                End If
            Next
            objWriter.Write(Environment.NewLine)
        Next

        objWriter.Close()
        MessageBox.Show("The data has been downloaded to " + FileName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_addtodos_Click(sender As Object, e As EventArgs) Handles btn_addtodos.Click
        AddToDos.Show()
    End Sub

    Private Sub btn_viewtodos_Click(sender As Object, e As EventArgs) Handles btn_viewtodos.Click
        If data_todos.SelectedRows.Count > 0 Then
            ViewToDos.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "ViewToDos" Then
                    Dim fcast As New ViewToDos
                    fcast = f
                    fcast.txt_title.Text = data_todos.CurrentRow.Cells(1).Value
                    fcast.txt_location.Text = data_todos.CurrentRow.Cells(2).Value
                    fcast.txt_date.Text = data_todos.CurrentRow.Cells(3).Value
                    fcast.txt_time.Text = data_todos.CurrentRow.Cells(4).Value
                    fcast.txt_description.Text = data_todos.CurrentRow.Cells(5).Value
                    If IsDBNull(data_todos.CurrentRow.Cells(6).Value) Then
                        fcast.txt_notes.Text = data_todos.CurrentRow.Cells(6).Value
                    End If
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_edittodos_Click(sender As Object, e As EventArgs) Handles btn_edittodos.Click
        If data_todos.SelectedRows.Count > 0 Then
            EditToDos.Show()
            For Each f In My.Application.OpenForms
                If f.Name = "EditToDos" Then
                    Dim fcast As New EditToDos
                    fcast = f
                    fcast.lbl_id.Text = data_todos.CurrentRow.Cells(0).Value
                    fcast.txt_title.Text = data_todos.CurrentRow.Cells(1).Value
                    fcast.txt_location.Text = data_todos.CurrentRow.Cells(2).Value
                    fcast.date_date.Value = Date.Parse(data_todos.CurrentRow.Cells(3).Value)
                    fcast.date_time.Value = Date.Parse(data_todos.CurrentRow.Cells(4).Value)
                    fcast.txt_description.Text = data_todos.CurrentRow.Cells(5).Value
                    If IsDBNull(data_todos.CurrentRow.Cells(6).Value) Then
                        fcast.txt_notes.Text = data_todos.CurrentRow.Cells(6).Value
                    End If
                End If
            Next
        Else
            MessageBox.Show("You have not selected a record to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_deletetodos_Click(sender As Object, e As EventArgs) Handles btn_deletetodos.Click
        If data_todos.SelectedRows.Count > 0 Then
            Dim result As Integer = MessageBox.Show("Are you sure you would like to delete this record?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                ToDosTableBindingSource.EndEdit()
                ToDosTableTableAdapter.Remove(data_todos.CurrentRow.Cells(0).Value)
                ToDosTableTableAdapter.Fill(AssistantDS.ToDosTable)
                MessageBox.Show("The record was deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("You have not selected a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_cleartodos_Click(sender As Object, e As EventArgs) Handles btn_cleartodos.Click
        Dim result As Integer = MessageBox.Show("Are you sure you would like to delete all records?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            ToDosTableBindingSource.EndEdit()
            ToDosTableTableAdapter.Clear()
            ToDosTableTableAdapter.Fill(AssistantDS.ToDosTable)
            MessageBox.Show("All records have been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_showalltodos_Click(sender As Object, e As EventArgs) Handles btn_showalltodos.Click
        Me.ToDosTableTableAdapter.Fill(Me.AssistantDS.ToDosTable)
    End Sub

    Private Sub btn_filtertodos_Click(sender As Object, e As EventArgs) Handles btn_filtertodos.Click
        FilterToDos.Show()
    End Sub

    Private Sub btn_downloadrecords_Click(sender As Object, e As EventArgs) Handles btn_downloadrecords.Click
        Dim FileName As String
        FileName = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant\ToDos.csv"
        If (Not System.IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")) Then
            System.IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Assistant")
        End If
        Dim objWriter As New System.IO.StreamWriter(FileName)

        For Each c In data_todos.Columns
            If (Not c.index = 0) Then
                objWriter.Write(data_todos.Columns(c.index).HeaderText + ",")
            End If
        Next

        objWriter.Write(Environment.NewLine)

        For Each r In data_todos.Rows
            For Each c In r.Cells
                If (Not c.ColumnIndex = 0) Then
                    objWriter.Write(c.Value.ToString + ",")
                End If
            Next
            objWriter.Write(Environment.NewLine)
        Next

        objWriter.Close()
        MessageBox.Show("The data has been downloaded to " + FileName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_homeworkupdate_Click(sender As Object, e As EventArgs) Handles btn_homeworkupdate.Click
        If chk_homeworkmonday.Checked = True Then
            My.Settings.HomeworkMonday = True
        Else
            My.Settings.HomeworkMonday = False
        End If

        If chk_homeworktuesday.Checked = True Then
            My.Settings.HomeworkTuesday = True
        Else
            My.Settings.HomeworkTuesday = False
        End If

        If chk_homeworkwednesday.Checked = True Then
            My.Settings.HomeworkWednesday = True
        Else
            My.Settings.HomeworkWednesday = False
        End If

        If chk_homeworkthursday.Checked = True Then
            My.Settings.HomeworkThursday = True
        Else
            My.Settings.HomeworkThursday = False
        End If

        If chk_homeworkfriday.Checked = True Then
            My.Settings.HomeworkFriday = True
        Else
            My.Settings.HomeworkFriday = False
        End If

        If chk_homeworksaturday.Checked = True Then
            My.Settings.HomeworkSaturday = True
        Else
            My.Settings.HomeworkSaturday = False
        End If

        If chk_homeworksunday.Checked = True Then
            My.Settings.HomeworkSunday = True
        Else
            My.Settings.HomeworkSunday = False
        End If

        MessageBox.Show("Settings Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_revisionupdate_Click(sender As Object, e As EventArgs) Handles btn_revisionupdate.Click
        If chk_revisionmonday.Checked = True Then
            My.Settings.RevisionMonday = True
        Else
            My.Settings.RevisionMonday = False
        End If

        If chk_revisiontuesday.Checked = True Then
            My.Settings.RevisionTuesday = True
        Else
            My.Settings.RevisionTuesday = False
        End If

        If chk_revisionwednesday.Checked = True Then
            My.Settings.RevisionWednesday = True
        Else
            My.Settings.RevisionWednesday = False
        End If

        If chk_revisionthursday.Checked = True Then
            My.Settings.RevisionThursday = True
        Else
            My.Settings.RevisionThursday = False
        End If

        If chk_revisionfriday.Checked = True Then
            My.Settings.RevisionFriday = True
        Else
            My.Settings.RevisionFriday = False
        End If

        If chk_revisionsaturday.Checked = True Then
            My.Settings.RevisionSaturday = True
        Else
            My.Settings.RevisionSaturday = False
        End If

        If chk_revisionsunday.Checked = True Then
            My.Settings.RevisionSunday = True
        Else
            My.Settings.RevisionSunday = False
        End If

        MessageBox.Show("Settings Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_updateoutlook_Click(sender As Object, e As EventArgs) Handles btn_updateoutlook.Click
        flow_outlook.Controls.Clear()

        Dim Events As New List(Of List(Of String))
        For Each r As DataGridViewRow In data_events.Rows
            Dim EventsRow As New List(Of String)
            For Each c As DataGridViewCell In r.Cells
                EventsRow.Add(c.Value.ToString())
            Next
            Events.Add(EventsRow)
        Next

        Dim Exams As New List(Of List(Of String))
        For Each r As DataGridViewRow In data_exams.Rows
            Dim ExamsRow As New List(Of String)
            For Each c As DataGridViewCell In r.Cells
                ExamsRow.Add(c.Value.ToString())
            Next
            Exams.Add(ExamsRow)
        Next

        Dim Homework As New List(Of List(Of String))
        For Each r As DataGridViewRow In data_homeworks.Rows
            Dim HomeworkRow As New List(Of String)
            For Each c As DataGridViewCell In r.Cells
                HomeworkRow.Add(c.Value.ToString())
            Next
            Homework.Add(HomeworkRow)
        Next

        Dim Rooms As New List(Of List(Of String))
        For Each r As DataGridViewRow In data_rooms.Rows
            Dim RoomsRow As New List(Of String)
            For Each c As DataGridViewCell In r.Cells
                RoomsRow.Add(c.Value.ToString())
            Next
            Rooms.Add(RoomsRow)
        Next

        Dim Subjects As New List(Of List(Of String))
        For Each r As DataGridViewRow In data_subjects.Rows
            Dim SubjectsRow As New List(Of String)
            For Each c As DataGridViewCell In r.Cells
                SubjectsRow.Add(c.Value.ToString())
            Next
            Subjects.Add(SubjectsRow)
        Next

        Dim ToDos As New List(Of List(Of String))
        For Each r As DataGridViewRow In data_todos.Rows
            Dim ToDosRow As New List(Of String)
            For Each c As DataGridViewCell In r.Cells
                ToDosRow.Add(c.Value.ToString())
            Next
            ToDos.Add(ToDosRow)
        Next

        Dim Days As New List(Of String)
        Days.Add(Today.ToString("dd MMMM yyyy"))
        Days.Add(Today.AddDays(1).ToString("dd MMMM yyyy"))
        Days.Add(Today.AddDays(2).ToString("dd MMMM yyyy"))
        Days.Add(Today.AddDays(3).ToString("dd MMMM yyyy"))
        Days.Add(Today.AddDays(4).ToString("dd MMMM yyyy"))
        Days.Add(Today.AddDays(5).ToString("dd MMMM yyyy"))
        Days.Add(Today.AddDays(6).ToString("dd MMMM yyyy"))
        Days.Add(Today.AddDays(7).ToString("dd MMMM yyyy"))

        Dim Outlook As New List(Of Dictionary(Of String, List(Of List(Of String))))
        Outlook.Add(New Dictionary(Of String, List(Of List(Of String))))
        Outlook.Add(New Dictionary(Of String, List(Of List(Of String))))
        Outlook.Add(New Dictionary(Of String, List(Of List(Of String))))
        Outlook.Add(New Dictionary(Of String, List(Of List(Of String))))
        Outlook.Add(New Dictionary(Of String, List(Of List(Of String))))
        Outlook.Add(New Dictionary(Of String, List(Of List(Of String))))
        Outlook.Add(New Dictionary(Of String, List(Of List(Of String))))
        Outlook.Add(New Dictionary(Of String, List(Of List(Of String))))

        Dim Index As Integer = 0

        Dim RevisionList As New List(Of List(Of String))
        Dim a As Integer = Subjects.Count
        Dim b As Integer = 0
        Dim f As Integer = 0
        Dim Min As List(Of String)
        For Each s In Subjects
            If s(6) = False Then
                f = f + 1
            End If
        Next
        Dim g As Integer = a - f
        While b < g
            For Each s In Subjects
                If s(6) = True Then
                    If RevisionList.Contains(s) = False Then
                        If Min Is Nothing Then
                            Min = s
                        Else
                            If Date.Parse(s(5)) < Date.Parse(Min(5)) Then
                                Min = s
                            End If
                        End If
                    End If
                End If
            Next
            RevisionList.Add(Min)
            Min = Nothing
            b = b + 1
        End While

        'Dim PendingList As New List(Of List(Of String))
        'Dim w As Integer = Subjects.Count
        'Dim x As Integer = 0
        'Dim v As Integer = 0
        'Min = Nothing
        'For Each s In Subjects
        ' If s(6) = False Then
        ' v = v + 1
        ' End If
        ' Next
        ' Dim z As Integer = w - v
        ' While x < z
        ' For Each s In Homework
        'If s(7) <> "Handed In" And s(7) <> "Completed" And s(7) <> "On Hold" Then
        ' If PendingList.Contains(s) = False Then
        'If Min Is Nothing Then
        'Min = s
        'Else
        'If Date.Parse(s(4)) < Date.Parse(Min(4)) Then
        'Min = s
        'End If
        'End If
        'End If
        'End If
        'Next
        'PendingList.Add(Min)
        ''Min = Nothing
        'x = x + 1
        'End While

        For Each d In Days
            Dim EventList As New List(Of List(Of String))
            For Each i In Events
                If i(3) = d Then
                    EventList.Add(i)
                End If
            Next
            If EventList.Count > 0 Then
                Outlook(Index).Add("Event", EventList)
            End If

            Dim ExamList As New List(Of List(Of String))
            For Each i In Exams
                If i(3) = d Then
                    ExamList.Add(i)
                End If
            Next
            If ExamList.Count > 0 Then
                Outlook(Index).Add("Exam", ExamList)
            End If

            Dim HomeworkList As New List(Of List(Of String))
            For Each i In Homework
                If i(4) = d Then
                    HomeworkList.Add(i)
                End If
            Next
            If HomeworkList.Count > 0 Then
                Outlook(Index).Add("Homework Due", HomeworkList)
            End If

            Dim RoomsList As New List(Of List(Of String))
            For Each i In Rooms
                If i(4) = d Then
                    RoomsList.Add(i)
                End If
            Next
            If RoomsList.Count > 0 Then
                Outlook(Index).Add("Room Change", RoomsList)
            End If

            Dim ReviseToday As New List(Of List(Of String))
            If Date.Parse(d).DayOfWeek = 0 And My.Settings.RevisionSunday = True Then
                If RevisionList.Count >= 2 Then
                    ReviseToday.Add(RevisionList(0))
                    ReviseToday.Add(RevisionList(1))
                    RevisionList.RemoveAt(1)
                    RevisionList.RemoveAt(0)
                    Outlook(Index).Add("Revise", ReviseToday)
                ElseIf RevisionList.Count = 1 Then
                    ReviseToday.Add(RevisionList(0))
                    RevisionList.RemoveAt(0)
                    Outlook(Index).Add("Revise", ReviseToday)
                End If
            End If
            If Date.Parse(d).DayOfWeek = 1 And My.Settings.RevisionMonday = True Then
                If RevisionList.Count >= 2 Then
                    ReviseToday.Add(RevisionList(0))
                    ReviseToday.Add(RevisionList(1))
                    RevisionList.RemoveAt(1)
                    RevisionList.RemoveAt(0)
                    Outlook(Index).Add("Revise", ReviseToday)
                ElseIf RevisionList.Count = 1 Then
                    ReviseToday.Add(RevisionList(0))
                    RevisionList.RemoveAt(0)
                    Outlook(Index).Add("Revise", ReviseToday)
                End If
            End If
            If Date.Parse(d).DayOfWeek = 2 And My.Settings.RevisionTuesday = True Then
                If RevisionList.Count >= 2 Then
                    ReviseToday.Add(RevisionList(0))
                    ReviseToday.Add(RevisionList(1))
                    RevisionList.RemoveAt(1)
                    RevisionList.RemoveAt(0)
                    Outlook(Index).Add("Revise", ReviseToday)
                ElseIf RevisionList.Count = 1 Then
                    ReviseToday.Add(RevisionList(0))
                    RevisionList.RemoveAt(0)
                    Outlook(Index).Add("Revise", ReviseToday)
                End If
            End If
            If Date.Parse(d).DayOfWeek = 3 And My.Settings.RevisionWednesday = True Then
                If RevisionList.Count >= 2 Then
                    ReviseToday.Add(RevisionList(0))
                    ReviseToday.Add(RevisionList(1))
                    RevisionList.RemoveAt(1)
                    RevisionList.RemoveAt(0)
                    Outlook(Index).Add("Revise", ReviseToday)
                ElseIf RevisionList.Count = 1 Then
                    ReviseToday.Add(RevisionList(0))
                    RevisionList.RemoveAt(0)
                    Outlook(Index).Add("Revise", ReviseToday)
                End If
            End If
            If Date.Parse(d).DayOfWeek = 4 And My.Settings.RevisionThursday = True Then
                If RevisionList.Count >= 2 Then
                    ReviseToday.Add(RevisionList(0))
                    ReviseToday.Add(RevisionList(1))
                    RevisionList.RemoveAt(1)
                    RevisionList.RemoveAt(0)
                    Outlook(Index).Add("Revise", ReviseToday)
                ElseIf RevisionList.Count = 1 Then
                    ReviseToday.Add(RevisionList(0))
                    RevisionList.RemoveAt(0)
                    Outlook(Index).Add("Revise", ReviseToday)
                End If
            End If
            If Date.Parse(d).DayOfWeek = 5 And My.Settings.RevisionFriday = True Then
                If RevisionList.Count >= 2 Then
                    ReviseToday.Add(RevisionList(0))
                    ReviseToday.Add(RevisionList(1))
                    RevisionList.RemoveAt(1)
                    RevisionList.RemoveAt(0)
                    Outlook(Index).Add("Revise", ReviseToday)
                ElseIf RevisionList.Count = 1 Then
                    ReviseToday.Add(RevisionList(0))
                    RevisionList.RemoveAt(0)
                    Outlook(Index).Add("Revise", ReviseToday)
                End If
            End If
            If Date.Parse(d).DayOfWeek = 6 And My.Settings.RevisionSaturday = True Then
                If RevisionList.Count >= 2 Then
                    ReviseToday.Add(RevisionList(0))
                    ReviseToday.Add(RevisionList(1))
                    RevisionList.RemoveAt(1)
                    RevisionList.RemoveAt(0)
                    Outlook(Index).Add("Revise", ReviseToday)
                ElseIf RevisionList.Count = 1 Then
                    ReviseToday.Add(RevisionList(0))
                    RevisionList.RemoveAt(0)
                    Outlook(Index).Add("Revise", ReviseToday)
                End If
            End If

            Dim ToDoList As New List(Of List(Of String))
            For Each i In ToDos
                If i(2) = d Then
                    ToDoList.Add(i)
                End If
            Next
            If ToDoList.Count > 0 Then
                Outlook(Index).Add("ToDo", ToDoList)
            End If

            Index = Index + 1
        Next

        Index = 0

        Dim Y As Integer = 32

        For Each o In Outlook
            If o.Keys.Count > 0 Then
                Dim lbl As New Label
                If Index = 0 Then
                    lbl.Text = "Today"
                ElseIf Index = 1 Then
                    lbl.Text = "Tomorrow"
                Else
                    lbl.Text = Days(Index)
                End If
                lbl.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Bold Or FontStyle.Underline)
                flow_outlook.Controls.Add(lbl)
            End If
            For Each k In o.Keys
                For Each s In o(k)
                    Dim lbl As New Label
                    Dim Graphics As Graphics = lbl.CreateGraphics()
                    Dim Text As String = String.Concat("[" + k + "] ", s(1))
                    lbl.Text = Text
                    lbl.Width = CInt(Graphics.MeasureString(lbl.Text, lbl.Font).Width)
                    flow_outlook.Controls.Add(lbl)
                Next
            Next
            Index = Index + 1
        Next
    End Sub
End Class
