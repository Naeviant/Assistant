Imports Excel = Microsoft.Office.Interop.Excel

Public Class Exams
    Public Sub Reload_Table(sender As Object, e As EventArgs)
        data_exams.Rows.Clear()
        Dim Exams = ExamsTableAdapter.GetNonArchived()
        For Each Exam In Exams
            Dim Sortable As DateTime = New Date(Exam.ExamDateTime.Year, Exam.ExamDateTime.Month, Exam.ExamDateTime.Day, Exam.ExamDateTime.Hour, Exam.ExamDateTime.Minute, 0)
            data_exams.Rows.Add(Exam.ID, Exam.Subject, Exam.Type, Exam.Location, Exam.Seat, Exam.ExamDateTime.ToString("ddd dd/MM/yyyy HH:mm"), Exam.Archive, Sortable)
        Next
        If data_exams.Rows.Count = 0 Then
            btn_editexam.Enabled = False
            btn_deleteexam.Enabled = False
            btn_archiveexam.Enabled = False
        Else
            btn_editexam.Enabled = True
            btn_deleteexam.Enabled = True
            btn_archiveexam.Enabled = True
        End If
        btn_filterexams.Visible = True
        btn_unfilterexams.Visible = False
        btn_showarchived.Visible = True
        btn_hidearchived.Visible = False
        data_exams.Sort(data_exams.Columns.Item(7), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub btn_addexam_Click(sender As Object, e As EventArgs) Handles btn_addexam.Click
        ExamsEdit.com_subject.Text = ""
        ExamsEdit.com_type.Text = ""
        ExamsEdit.txt_location.Text = ""
        ExamsEdit.txt_seat.Text = ""
        ExamsEdit.date_datetime.Value = Today
        ExamsEdit.chk_archived.Checked = False
        ExamsEdit.lbl_id.Text = "None"
        ExamsEdit.ShowDialog()
    End Sub

    Private Sub btn_editexam_Click(sender As Object, e As EventArgs) Handles btn_editexam.Click
        ExamsEdit.lbl_id.Text = data_exams.CurrentRow.Cells(0).Value
        ExamsEdit.com_subject.Text = data_exams.CurrentRow.Cells(1).Value
        ExamsEdit.com_type.Text = data_exams.CurrentRow.Cells(2).Value
        ExamsEdit.txt_location.Text = data_exams.CurrentRow.Cells(3).Value
        ExamsEdit.txt_seat.Text = data_exams.CurrentRow.Cells(4).Value
        Dim DateTimeString = data_exams.CurrentRow.Cells(5).Value
        Dim DateString = Split(DateTimeString)(1)
        Dim TimeString = Split(DateTimeString)(2)
        Dim ExamDateTime = New Date(Split(DateString, "/")(2), Split(DateString, "/")(1), Split(DateString, "/")(0), Split(TimeString, ":")(0), Split(TimeString, ":")(1), 0)
        ExamsEdit.date_datetime.Value = ExamDateTime
        ExamsEdit.chk_archived.Checked = data_exams.CurrentRow.Cells(6).Value
        ExamsEdit.ShowDialog()
    End Sub

    Private Sub btn_archiveexam_Click(sender As Object, e As EventArgs) Handles btn_archiveexam.Click
        Dim Selected = data_exams.CurrentRow.Cells(0).Value
        ExamsTableAdapter.ArchiveByID(Selected)
        Reload_Table(sender, e)
    End Sub

    Private Sub btn_deleteexam_Click(sender As Object, e As EventArgs) Handles btn_deleteexam.Click
        Dim Selected = data_exams.CurrentRow.Cells(0).Value
        Dim Result = MessageBox.Show("Are you sure you want to delete this exam?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.Yes Then
            ExamsTableAdapter.DeleteByID(Selected)
            Reload_Table(sender, e)
        End If
    End Sub

    Private Sub btn_filterexams_Click(sender As Object, e As EventArgs) Handles btn_filterexams.Click
        ExamsFilter.com_subject.Text = ""
        ExamsFilter.com_type.Text = ""
        ExamsFilter.txt_location.Text = ""
        ExamsFilter.txt_seat.Text = ""
        ExamsFilter.date_datetime.Value = Today
        ExamsFilter.date_datetime.Checked = False
        ExamsFilter.ShowDialog()
    End Sub

    Private Sub btn_unfilterexams_Click(sender As Object, e As EventArgs) Handles btn_unfilterexams.Click
        Reload_Table(sender, e)
    End Sub

    Private Sub btn_showarchived_Click(sender As Object, e As EventArgs) Handles btn_showarchived.Click
        btn_filterexams.Visible = True
        btn_unfilterexams.Visible = False
        btn_showarchived.Visible = False
        btn_hidearchived.Visible = True
        data_exams.Rows.Clear()
        Dim Exams = ExamsTableAdapter.GetData()
        For Each Exam In Exams
            Dim Sortable As DateTime = New Date(Exam.ExamDateTime.Year, Exam.ExamDateTime.Month, Exam.ExamDateTime.Day, Exam.ExamDateTime.Hour, Exam.ExamDateTime.Minute, 0)
            data_exams.Rows.Add(Exam.ID, Exam.Subject, Exam.Type, Exam.Location, Exam.Seat, Exam.ExamDateTime.ToString("ddd dd/MM/yyyy HH:mm"), Exam.Archive, Sortable)
        Next
        If data_exams.Rows.Count = 0 Then
            btn_editexam.Enabled = False
            btn_deleteexam.Enabled = False
        Else
            btn_editexam.Enabled = True
            btn_deleteexam.Enabled = True
        End If
        btn_archiveexam.Enabled = False
        data_exams.Sort(data_exams.Columns.Item(6), System.ComponentModel.ListSortDirection.Ascending)
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

        Sheet2.Name = "Archived Exams"

        Sheet2.Cells(1, 1).Value = "Subject"
        Sheet2.Cells(1, 2).Value = "Type"
        Sheet2.Cells(1, 3).Value = "Location"
        Sheet2.Cells(1, 4).Value = "Seat"
        Sheet2.Cells(1, 5).Value = "Date & Time"

        With Sheet2.Range("A1", "E1")
            .Font.Bold = True
            .ColumnWidth = 16.43
        End With

        Sheet2.Cells(1, 5).ColumnWidth = 25

        Dim ArchivedExams = ExamsTableAdapter.GetArchived()
        Dim i = 2
        For Each Exam In ArchivedExams
            Sheet2.Cells(i, 1).Value = Exam.Subject
            Sheet2.Cells(i, 2).Value = Exam.Type
            Sheet2.Cells(i, 3).Value = Exam.Location
            Sheet2.Cells(i, 4).Value = Exam.Seat
            Sheet2.Cells(i, 5).Value = Exam.ExamDateTime.ToString("ddd dd/MM/yyyy HH:mm")
            Sheet2.Cells(i, 5).HorizontalAlignment = HorizontalAlignment.Center
            i += 1
        Next

        Sheet1.Name = "Active Exams"

        Sheet1.Cells(1, 1).Value = "Subject"
        Sheet1.Cells(1, 2).Value = "Type"
        Sheet1.Cells(1, 3).Value = "Location"
        Sheet1.Cells(1, 4).Value = "Seat"
        Sheet1.Cells(1, 5).Value = "Date & Time"

        With Sheet1.Range("A1", "E1")
            .Font.Bold = True
            .ColumnWidth = 16.43
        End With

        Sheet1.Cells(1, 5).ColumnWidth = 25

        Dim Exams = ExamsTableAdapter.GetNonArchived()
        i = 2
        For Each Exam In Exams
            Sheet1.Cells(i, 1).Value = Exam.Subject
            Sheet1.Cells(i, 2).Value = Exam.Type
            Sheet1.Cells(i, 3).Value = Exam.Location
            Sheet1.Cells(i, 4).Value = Exam.Seat
            Sheet1.Cells(i, 5).Value = Exam.ExamDateTime.ToString("ddd dd/MM/yyyy HH:mm")
            Sheet1.Cells(i, 5).HorizontalAlignment = HorizontalAlignment.Center
            i += 1
        Next

        ExcelApplication.Visible = True
        ExcelApplication.UserControl = True

        Cursor = Cursors.Default
    End Sub

    Private Sub Exams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_exams.ColumnCount = 8
        data_exams.Columns(0).Name = "ID"
        data_exams.Columns(0).Visible = False
        data_exams.Columns(1).Name = "Subject"
        data_exams.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        data_exams.Columns(2).Name = "Exam Type"
        data_exams.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        data_exams.Columns(3).Name = "Location"
        data_exams.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        data_exams.Columns(4).Name = "Seat"
        data_exams.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        data_exams.Columns(5).Name = "Date"
        data_exams.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        data_exams.Columns(6).Name = "Archived"
        data_exams.Columns(6).Visible = False
        data_exams.Columns(7).Name = "Sortable"
        data_exams.Columns(7).Visible = False
        Reload_Table(sender, e)
    End Sub
End Class