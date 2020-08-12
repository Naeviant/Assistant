Imports Excel = Microsoft.Office.Interop.Excel

Public Class Results
    Public Sub Reload_Table(sender As Object, e As EventArgs)
        data_results.Rows.Clear()
        Dim Results = ResultsTableAdapter.GetNonArchived()
        Dim Percentage
        For Each Result In Results
            Percentage = Result.Score / Result.MaxScore * 100
            If Double.IsNaN(Percentage) Then
                Percentage = Nothing
            End If
            Dim Sortable As DateTime = New Date(Result.ExamDate.Year, Result.ExamDate.Month, Result.ExamDate.Day, Result.ExamDate.Hour, Result.ExamDate.Minute, 0)
            data_results.Rows.Add(Result.ID, Result.Subject, Result.Type, Result.Score, Result.MaxScore, Percentage, Result.Grade, Result.ExamDate.ToString("dd/MM/yyyy"), Result.GradeDate.ToString("dd/MM/yyyy"), Result.Description, Result.Archive, Sortable)
        Next
        If data_results.Rows.Count = 0 Then
            btn_editresult.Enabled = False
            btn_deleteresult.Enabled = False
            btn_archiveresult.Enabled = False
        Else
            btn_editresult.Enabled = True
            btn_deleteresult.Enabled = True
            btn_archiveresult.Enabled = True
        End If
        btn_filterresults.Visible = True
        btn_unfilterresults.Visible = False
        btn_showarchived.Visible = True
        btn_hidearchived.Visible = False
        data_results.Sort(data_results.Columns.Item(11), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_results.ColumnCount = 12
        data_results.Columns(0).Name = "ID"
        data_results.Columns(0).Visible = False
        data_results.Columns(1).Name = "Subject"
        data_results.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        data_results.Columns(2).Name = "Type"
        data_results.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        data_results.Columns(3).Name = "Score"
        data_results.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        data_results.Columns(4).Name = "Max Score"
        data_results.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        data_results.Columns(5).Name = "Percentage"
        data_results.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        data_results.Columns(6).Name = "Grade"
        data_results.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        data_results.Columns(7).Name = "Exam Date"
        data_results.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
        data_results.Columns(8).Name = "Grade Date"
        data_results.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
        data_results.Columns(9).Name = "Description"
        data_results.Columns(9).SortMode = DataGridViewColumnSortMode.NotSortable
        data_results.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        data_results.Columns(10).Name = "Archived"
        data_results.Columns(10).Visible = False
        data_results.Columns(11).Name = "Sortable"
        data_results.Columns(11).Visible = False
        Reload_Table(sender, e)
    End Sub

    Private Sub btn_addresult_Click(sender As Object, e As EventArgs) Handles btn_addresult.Click
        ResultsEdit.com_subject.Text = ""
        ResultsEdit.com_type.Text = ""
        ResultsEdit.num_score.Value = 0
        ResultsEdit.num_maxscore.Value = 0
        ResultsEdit.date_exam.Value = Today
        ResultsEdit.date_grade.Value = Today
        ResultsEdit.txt_grade.Text = ""
        ResultsEdit.chk_archive.Checked = False
        ResultsEdit.txt_description.Text = ""
        ResultsEdit.lbl_id.Text = "None"
        ResultsEdit.ShowDialog()
    End Sub

    Private Sub btn_editresult_Click(sender As Object, e As EventArgs) Handles btn_editresult.Click
        ResultsEdit.com_subject.Text = data_results.CurrentRow.Cells(1).Value
        ResultsEdit.com_type.Text = data_results.CurrentRow.Cells(2).Value
        ResultsEdit.num_score.Value = data_results.CurrentRow.Cells(3).Value
        ResultsEdit.num_maxscore.Value = data_results.CurrentRow.Cells(4).Value
        ResultsEdit.date_exam.Value = data_results.CurrentRow.Cells(7).Value
        ResultsEdit.date_grade.Value = data_results.CurrentRow.Cells(8).Value
        ResultsEdit.txt_grade.Text = data_results.CurrentRow.Cells(6).Value
        ResultsEdit.chk_archive.Checked = data_results.CurrentRow.Cells(10).Value
        ResultsEdit.txt_description.Text = data_results.CurrentRow.Cells(9).Value
        ResultsEdit.lbl_id.Text = data_results.CurrentRow.Cells(0).Value
        ResultsEdit.ShowDialog()
    End Sub

    Private Sub btn_archiveresult_Click(sender As Object, e As EventArgs) Handles btn_archiveresult.Click
        Dim Selected = data_results.CurrentRow.Cells(0).Value
        ResultsTableAdapter.ArchiveByID(Selected)
        Reload_Table(sender, e)
    End Sub

    Private Sub btn_deleteresult_Click(sender As Object, e As EventArgs) Handles btn_deleteresult.Click
        Dim Selected = data_results.CurrentRow.Cells(0).Value
        Dim Result = MessageBox.Show("Are you sure you want to delete this result?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.Yes Then
            ResultsTableAdapter.DeleteByID(Selected)
            Reload_Table(sender, e)
        End If
    End Sub

    Private Sub btn_filterresults_Click(sender As Object, e As EventArgs) Handles btn_filterresults.Click
        ResultsFilter.com_subject.Text = ""
        ResultsFilter.com_type.Text = ""
        ResultsFilter.date_exam.Value = Today
        ResultsFilter.date_exam.Checked = False
        ResultsFilter.date_grade.Value = Today
        ResultsFilter.date_grade.Checked = False
        ResultsFilter.txt_grade.Text = ""
        ResultsFilter.ShowDialog()
    End Sub

    Private Sub btn_unfilterresults_Click(sender As Object, e As EventArgs) Handles btn_unfilterresults.Click
        Reload_Table(sender, e)
    End Sub

    Private Sub btn_showarchived_Click(sender As Object, e As EventArgs) Handles btn_showarchived.Click
        btn_filterresults.Visible = True
        btn_unfilterresults.Visible = False
        btn_showarchived.Visible = False
        btn_hidearchived.Visible = True
        data_results.Rows.Clear()
        Dim Results = ResultsTableAdapter.GetData()
        Dim Percentage
        For Each Result In Results
            Percentage = Result.Score / Result.MaxScore * 100
            If Double.IsNaN(Percentage) Then
                Percentage = Nothing
            End If
            Dim Sortable As DateTime = New Date(Result.ExamDate.Year, Result.ExamDate.Month, Result.ExamDate.Day, Result.ExamDate.Hour, Result.ExamDate.Minute, 0)
            data_results.Rows.Add(Result.ID, Result.Subject, Result.Type, Result.Score, Result.MaxScore, Percentage, Result.Grade, Result.ExamDate.ToString("dd/MM/yyyy"), Result.GradeDate.ToString("dd/MM/yyyy"), Result.Description, Result.Archive, Sortable)
        Next
        If data_results.Rows.Count = 0 Then
            btn_editresult.Enabled = False
            btn_deleteresult.Enabled = False
        End If
        btn_archiveresult.Enabled = False
        data_results.Sort(data_results.Columns.Item(11), System.ComponentModel.ListSortDirection.Ascending)
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

        Sheet2.Name = "Archived Results"

        Sheet2.Cells(1, 1).Value = "Subject"
        Sheet2.Cells(1, 2).Value = "Type"
        Sheet2.Cells(1, 3).Value = "Score"
        Sheet2.Cells(1, 4).Value = "Max Score"
        Sheet2.Cells(1, 5).Value = "Percentage"
        Sheet2.Cells(1, 6).Value = "Grade"
        Sheet2.Cells(1, 7).Value = "Exam Date"
        Sheet2.Cells(1, 8).Value = "Grade Date"
        Sheet2.Cells(1, 9).Value = "Description"

        With Sheet2.Range("A1", "I1")
            .Font.Bold = True
            .ColumnWidth = 16.43
        End With

        Sheet2.Cells(1, 9).ColumnWidth = 100

        Dim ArchivedResults = ResultsTableAdapter.GetArchived()
        Dim i = 2
        Dim Percentage
        For Each Result In ArchivedResults
            Percentage = Result.Score / Result.MaxScore * 100
            If Double.IsNaN(Percentage) Then
                Percentage = Nothing
            End If
            Sheet2.Cells(i, 1).Value = Result.Subject
            Sheet2.Cells(i, 2).Value = Result.Type
            Sheet2.Cells(i, 3).Value = Result.Score
            Sheet2.Cells(i, 4).Value = Result.MaxScore
            Sheet2.Cells(i, 5).Value = Percentage
            Sheet2.Cells(i, 6).Value = Result.Grade
            Sheet2.Cells(i, 7).Value = Result.ExamDate.ToString("dd/MM/yyyy")
            Sheet2.Cells(i, 7).HorizontalAlignment = HorizontalAlignment.Center
            Sheet2.Cells(i, 8).Value = Result.GradeDate.ToString("dd/MM/yyyy")
            Sheet2.Cells(i, 8).HorizontalAlignment = HorizontalAlignment.Center
            Sheet2.Cells(i, 9).Value = Result.Description
            i += 1
        Next

        Sheet1.Name = "Active Results"

        Sheet1.Cells(1, 1).Value = "Subject"
        Sheet1.Cells(1, 2).Value = "Type"
        Sheet1.Cells(1, 3).Value = "Score"
        Sheet1.Cells(1, 4).Value = "Max Score"
        Sheet1.Cells(1, 5).Value = "Percentage"
        Sheet1.Cells(1, 6).Value = "Grade"
        Sheet1.Cells(1, 7).Value = "Exam Date"
        Sheet1.Cells(1, 8).Value = "Grade Date"
        Sheet1.Cells(1, 9).Value = "Description"

        With Sheet1.Range("A1", "I1")
            .Font.Bold = True
            .ColumnWidth = 16.43
        End With

        Sheet1.Cells(1, 9).ColumnWidth = 100

        Dim Results = ResultsTableAdapter.GetNonArchived()
        i = 2
        For Each Result In Results
            Percentage = Result.Score / Result.MaxScore * 100
            If Double.IsNaN(Percentage) Then
                Percentage = Nothing
            End If
            Sheet1.Cells(i, 1).Value = Result.Subject
            Sheet1.Cells(i, 2).Value = Result.Type
            Sheet1.Cells(i, 3).Value = Result.Score
            Sheet1.Cells(i, 4).Value = Result.MaxScore
            Sheet1.Cells(i, 5).Value = Percentage
            Sheet1.Cells(i, 6).Value = Result.Grade
            Sheet1.Cells(i, 7).Value = Result.ExamDate.ToString("dd/MM/yyyy")
            Sheet1.Cells(i, 7).HorizontalAlignment = HorizontalAlignment.Center
            Sheet1.Cells(i, 8).Value = Result.GradeDate.ToString("dd/MM/yyyy")
            Sheet1.Cells(i, 8).HorizontalAlignment = HorizontalAlignment.Center
            Sheet1.Cells(i, 9).Value = Result.Description
            i += 1
        Next

        ExcelApplication.Visible = True
        ExcelApplication.UserControl = True

        Cursor = Cursors.Default
    End Sub
End Class