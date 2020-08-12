Public Class AssignmentsFilter
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        Dim StartDate
        Dim DueDate
        Dim Completion
        If date_start.Checked = True Then
            StartDate = date_start.Value.Date.Add(New TimeSpan(0, 0, 0))
        Else
            StartDate = Nothing
        End If
        If date_due.Checked = True Then
            DueDate = date_due.Value.Date.Add(New TimeSpan(0, 0, 0))
        Else
            DueDate = Nothing
        End If
        If txt_progress.Text <> "" Then
            Completion = Integer.Parse(txt_progress.Text)
        Else
            Completion = -1
        End If
        Assignments.data_assignments.Rows.Clear()
        Dim AssignmentResults = AssignmentsTableAdapter.Sort(com_subject.Text, com_priority.Text, Completion, com_status.Text, StartDate, DueDate)
        For Each Assignment In AssignmentResults
            Dim Sortable1 As Int32
            Select Case Assignment.Priority
                Case "High"
                    Sortable1 = 3
                Case "Normal"
                    Sortable1 = 2
                Case "Low"
                    Sortable1 = 1
                Case Else
                    Sortable1 = 0
            End Select

            Dim Sortable2 As DateTime = New Date(Assignment.DueDate.Year, Assignment.DueDate.Month, Assignment.DueDate.Day, Assignment.DueTime.Hour, Assignment.DueTime.Minute, 0)
            Assignments.data_assignments.Rows.Add(Assignment.ID, Assignment.Subject, Assignment.Priority, Assignment.Completion.ToString() + "%", Assignment.Status, Assignment.StartDate.ToString("ddd dd/MM/yy"), Assignment.DueDate.ToString("ddd dd/MM/yy"), Assignment.DueTime.ToString("HH:mm"), Assignment.Description, Assignment.Archive, Sortable1, Sortable2)
        Next
        Assignments.btn_filterassignments.Visible = False
        Assignments.btn_unfilterassignments.Visible = True
        Assignments.btn_showarchived.Visible = True
        Assignments.btn_hidearchived.Visible = False
        If Assignments.data_assignments.Rows.Count = 0 Then
            Assignments.btn_editassignment.Enabled = False
            Assignments.btn_deleteassignment.Enabled = False
            Assignments.btn_archiveassignment.Enabled = False
        Else
            Assignments.btn_editassignment.Enabled = True
            Assignments.btn_deleteassignment.Enabled = True
            Assignments.btn_archiveassignment.Enabled = True
        End If
        Assignments.data_assignments.Sort(Assignments.data_assignments.Columns.Item(11), System.ComponentModel.ListSortDirection.Ascending)
        Assignments.data_assignments.Sort(Assignments.data_assignments.Columns.Item(10), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub AssignmentsFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        com_subject.Items.Add("")
        Dim Subjects = SubjectsTableAdapter.GetData()
        For Each Subject In Subjects
            com_subject.Items.Add(Subject.SubjectName)
        Next
        date_start.Checked = False
        date_due.Checked = False
    End Sub

    Private Sub txt_progress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_progress.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class