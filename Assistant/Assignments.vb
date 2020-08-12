Imports Excel = Microsoft.Office.Interop.Excel

Public Class Assignments

    Public Sub Reload_Table(sender As Object, e As EventArgs)
        data_assignments.Rows.Clear()
        Dim Assignments = AssignmentsTableAdapter.GetNonArchived()
        For Each Assignment In Assignments
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

            data_assignments.Rows.Add(Assignment.ID, Assignment.Subject, Assignment.Priority, Assignment.Completion.ToString() + "%", Assignment.Status, Assignment.StartDate.ToString("ddd dd/MM/yy"), Assignment.DueDate.ToString("ddd dd/MM/yyyy"), Assignment.DueTime.ToString("HH:mm"), Assignment.Description, Assignment.Archive, Sortable1, Sortable2)
        Next
        If data_assignments.Rows.Count = 0 Then
            btn_editassignment.Enabled = False
            btn_deleteassignment.Enabled = False
            btn_archiveassignment.Enabled = False
        Else
            btn_editassignment.Enabled = True
            btn_deleteassignment.Enabled = True
            btn_archiveassignment.Enabled = True
        End If
        btn_filterassignments.Visible = True
        btn_unfilterassignments.Visible = False
        btn_showarchived.Visible = True
        btn_hidearchived.Visible = False
        data_assignments.Sort(data_assignments.Columns.Item(11), System.ComponentModel.ListSortDirection.Ascending)
        data_assignments.Sort(data_assignments.Columns.Item(10), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub Assignments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_assignments.ColumnCount = 12
        data_assignments.Columns(0).Name = "ID"
        data_assignments.Columns(0).Visible = False
        data_assignments.Columns(1).Name = "Subject"
        data_assignments.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        data_assignments.Columns(2).Name = "Priority"
        data_assignments.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        data_assignments.Columns(3).Name = "Progress"
        data_assignments.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        data_assignments.Columns(4).Name = "Status"
        data_assignments.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        data_assignments.Columns(5).Name = "Set Date"
        data_assignments.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        data_assignments.Columns(6).Name = "Due Date"
        data_assignments.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        data_assignments.Columns(7).Name = "Due Time"
        data_assignments.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
        data_assignments.Columns(8).Name = "Description"
        data_assignments.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
        data_assignments.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        data_assignments.Columns(9).Name = "Archive"
        data_assignments.Columns(9).Visible = False
        data_assignments.Columns(10).Name = "Sortable1"
        data_assignments.Columns(10).Visible = False
        data_assignments.Columns(11).Name = "Sortable2"
        data_assignments.Columns(11).Visible = False
        Reload_Table(sender, e)
    End Sub

    Private Sub btn_addassignment_Click(sender As Object, e As EventArgs) Handles btn_addassignment.Click
        AssignmentsEdit.com_subject.Text = ""
        AssignmentsEdit.com_priority.Text = "Normal"
        AssignmentsEdit.com_status.Text = "Not Started"
        AssignmentsEdit.num_progress.Value = 0
        AssignmentsEdit.date_start.Value = Today
        AssignmentsEdit.date_due.Value = Today.AddDays(7)
        AssignmentsEdit.time_due.Value = Today.AddHours(9)
        AssignmentsEdit.chk_archive.Checked = False
        AssignmentsEdit.txt_description.Text = ""
        AssignmentsEdit.lbl_id.Text = "None"
        AssignmentsEdit.ShowDialog()
    End Sub

    Private Sub btn_editassignment_Click(sender As Object, e As EventArgs) Handles btn_editassignment.Click
        Dim Selected = data_assignments.CurrentRow.Cells(0).Value
        AssignmentsEdit.lbl_id.Text = data_assignments.CurrentRow.Cells(0).Value
        AssignmentsEdit.com_subject.Text = data_assignments.CurrentRow.Cells(1).Value
        AssignmentsEdit.com_priority.Text = data_assignments.CurrentRow.Cells(2).Value
        AssignmentsEdit.com_status.Text = data_assignments.CurrentRow.Cells(4).Value
        AssignmentsEdit.num_progress.Value = Integer.Parse(Replace(data_assignments.CurrentRow.Cells(3).Value, "%", ""))
        AssignmentsEdit.date_start.Value = data_assignments.CurrentRow.Cells(5).Value
        AssignmentsEdit.date_due.Value = data_assignments.CurrentRow.Cells(6).Value
        AssignmentsEdit.time_due.Value = Today.AddHours(Integer.Parse(Split(data_assignments.CurrentRow.Cells(7).Value, ":")(0).ToString())).AddMinutes(Integer.Parse(Split(data_assignments.CurrentRow.Cells(7).Value, ":")(1).ToString()))
        AssignmentsEdit.chk_archive.Checked = data_assignments.CurrentRow.Cells(9).Value
        AssignmentsEdit.txt_description.Text = data_assignments.CurrentRow.Cells(8).Value
        AssignmentsEdit.ShowDialog()
    End Sub

    Private Sub btn_deleteassignment_Click(sender As Object, e As EventArgs) Handles btn_deleteassignment.Click
        Dim Selected = data_assignments.CurrentRow.Cells(0).Value
        Dim Result = MessageBox.Show("Are you sure you want to delete this assignment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.Yes Then
            AssignmentsTableAdapter.DeleteByID(Selected)
            Reload_Table(sender, e)
        End If
    End Sub

    Private Sub btn_archiveassignment_Click(sender As Object, e As EventArgs) Handles btn_archiveassignment.Click
        Dim Selected = data_assignments.CurrentRow.Cells(0).Value
        AssignmentsTableAdapter.ArchiveByID(Selected)
        Reload_Table(sender, e)
    End Sub

    Private Sub btn_filterassignments_Click(sender As Object, e As EventArgs) Handles btn_filterassignments.Click
        AssignmentsFilter.com_subject.Text = ""
        AssignmentsFilter.com_priority.Text = ""
        AssignmentsFilter.com_status.Text = ""
        AssignmentsFilter.txt_progress.Text =
        AssignmentsFilter.date_start.Value = Today
        AssignmentsFilter.date_start.Checked = False
        AssignmentsFilter.date_due.Value = Today.AddDays(7)
        AssignmentsFilter.date_due.Checked = False
        AssignmentsFilter.ShowDialog()
    End Sub

    Private Sub btn_unfilter_Click(sender As Object, e As EventArgs) Handles btn_unfilterassignments.Click
        Reload_Table(sender, e)
    End Sub

    Private Sub btn_showarchived_Click(sender As Object, e As EventArgs) Handles btn_showarchived.Click
        btn_filterassignments.Visible = True
        btn_unfilterassignments.Visible = False
        btn_showarchived.Visible = False
        btn_hidearchived.Visible = True
        data_assignments.Rows.Clear()
        Dim Assignments = AssignmentsTableAdapter.GetData()
        For Each Assignment In Assignments
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
            data_assignments.Rows.Add(Assignment.ID, Assignment.Subject, Assignment.Priority, Assignment.Completion.ToString() + "%", Assignment.Status, Assignment.StartDate.ToString("ddd dd/MM/yy"), Assignment.DueDate.ToString("ddd dd/MM/yy"), Assignment.DueTime.ToString("HH:mm"), Assignment.Description, Assignment.Archive, Sortable1, Sortable2)
        Next
        If data_assignments.Rows.Count = 0 Then
            btn_editassignment.Enabled = False
            btn_deleteassignment.Enabled = False
        Else
            btn_editassignment.Enabled = True
            btn_deleteassignment.Enabled = True
        End If
        btn_archiveassignment.Enabled = False
        data_assignments.Sort(data_assignments.Columns.Item(11), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub btn_hidearchived_Click(sender As Object, e As EventArgs) Handles btn_hidearchived.Click
        Reload_Table(sender, e)
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Cursor = Cursors.WaitCursor
        Dim ExcelApplication As Excel.Application
        ExcelApplication = CreateObject("Excel.Application")
        ExcelApplication.WindowState = Excel.XlWindowState.xlMaximized

        Dim Workbook As Excel.Workbook
        Workbook = ExcelApplication.Workbooks.Add()

        Dim Sheet2 As Excel.Worksheet
        Sheet2 = Workbook.ActiveSheet
        Dim Sheet1 As Excel.Worksheet
        Sheet1 = Workbook.Sheets.Add()

        Sheet2.Name = "Archived Assignments"

        Sheet2.Cells(1, 1).Value = "Subject"
        Sheet2.Cells(1, 2).Value = "Priority"
        Sheet2.Cells(1, 3).Value = "Progress"
        Sheet2.Cells(1, 4).Value = "Status"
        Sheet2.Cells(1, 5).Value = "Set Date"
        Sheet2.Cells(1, 6).Value = "Due Date"
        Sheet2.Cells(1, 7).Value = "Due Time"
        Sheet2.Cells(1, 8).Value = "Description"

        With Sheet2.Range("A1", "H1")
            .Font.Bold = True
            .ColumnWidth = 16.43
        End With

        Sheet2.Cells(1, 8).ColumnWidth = 100

        Dim ArchivedAssignments = AssignmentsTableAdapter.GetArchived()
        Dim i = 2
        For Each Assignment In ArchivedAssignments
            Sheet2.Cells(i, 1).Value = Assignment.Subject
            Sheet2.Cells(i, 2).Value = Assignment.Priority
            Sheet2.Cells(i, 3).Value = Assignment.Completion.ToString() + "%"
            Sheet2.Cells(i, 3).HorizontalAlignment = HorizontalAlignment.Center
            Sheet2.Cells(i, 4).Value = Assignment.Status
            Sheet2.Cells(i, 5).Value = Assignment.StartDate.ToString("ddd dd/MM/yy")
            Sheet2.Cells(i, 6).Value = Assignment.DueDate.ToString("ddd dd/MM/yy")
            Sheet2.Cells(i, 7).Value = Assignment.DueTime.ToString("HH:mm")
            Sheet2.Cells(i, 7).HorizontalAlignment = HorizontalAlignment.Center
            Sheet2.Cells(i, 8).Value = Assignment.Description
            i += 1
        Next

        Sheet1.Name = "Active Assignments"

        Sheet1.Cells(1, 1).Value = "Subject"
        Sheet1.Cells(1, 2).Value = "Priority"
        Sheet1.Cells(1, 3).Value = "Progress"
        Sheet1.Cells(1, 4).Value = "Status"
        Sheet1.Cells(1, 5).Value = "Set Date"
        Sheet1.Cells(1, 6).Value = "Due Date"
        Sheet1.Cells(1, 7).Value = "Due Time"
        Sheet1.Cells(1, 8).Value = "Description"

        With Sheet1.Range("A1", "H1")
            .Font.Bold = True
            .ColumnWidth = 16.43
        End With

        Sheet1.Cells(1, 8).ColumnWidth = 100

        Dim Assignments = AssignmentsTableAdapter.GetNonArchived()
        i = 2
        For Each Assignment In Assignments
            Sheet1.Cells(i, 1).Value = Assignment.Subject
            Sheet1.Cells(i, 2).Value = Assignment.Priority
            Sheet1.Cells(i, 3).Value = Assignment.Completion.ToString() + "%"
            Sheet1.Cells(i, 3).HorizontalAlignment = HorizontalAlignment.Center
            Sheet1.Cells(i, 4).Value = Assignment.Status
            Sheet1.Cells(i, 5).Value = Assignment.StartDate.ToString("ddd dd/MM/yy")
            Sheet1.Cells(i, 6).Value = Assignment.DueDate.ToString("ddd dd/MM/yy")
            Sheet1.Cells(i, 7).Value = Assignment.DueTime.ToString("HH:mm")
            Sheet1.Cells(i, 7).HorizontalAlignment = HorizontalAlignment.Center
            Sheet1.Cells(i, 8).Value = Assignment.Description
            i += 1
        Next

        ExcelApplication.Visible = True
        ExcelApplication.UserControl = True

        Cursor = Cursors.Default
    End Sub
End Class