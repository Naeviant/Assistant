Public Class ResultsFilter
    Private Sub ResultsFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        com_subject.Items.Clear()
        com_subject.Items.Add("")
        Dim Subjects = SubjectsTableAdapter.GetData()
        For Each Subject In Subjects
            com_subject.Items.Add(Subject.SubjectName)
        Next

        com_type.Items.Clear()
        com_type.Items.Add("")
        Dim ExamTypes = ExamTypesTableAdapter.GetData()
        For Each ExamType In ExamTypes
            com_type.Items.Add(ExamType.ExamType)
        Next

        date_exam.Checked = False
        date_grade.Checked = False
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        Dim ExamDate
        Dim GradeDate
        Dim Percentage
        If date_exam.Checked = True Then
            ExamDate = date_exam.Value.Date.Add(New TimeSpan(0, 0, 0))
        Else
            ExamDate = Nothing
        End If
        If date_grade.Checked = True Then
            GradeDate = date_grade.Value.Date.Add(New TimeSpan(0, 0, 0))
        Else
            GradeDate = Nothing
        End If
        Results.data_results.Rows.Clear()
        Dim ExamResults = ResultsTableAdapter.Sort(com_subject.Text, com_type.Text, txt_grade.Text, ExamDate, GradeDate)
        For Each Result In ExamResults
            Percentage = Result.Score / Result.MaxScore * 100
            If Double.IsNaN(Percentage) Then
                Percentage = Nothing
            End If
            Dim Sortable As DateTime = New Date(Result.ExamDate.Year, Result.ExamDate.Month, Result.ExamDate.Day, Result.ExamDate.Hour, Result.ExamDate.Minute, 0)
            Results.data_results.Rows.Add(Result.ID, Result.Subject, Result.Type, Result.Score, Result.MaxScore, Percentage, Result.Grade, Result.ExamDate.ToString("dd/MM/yyyy"), Result.GradeDate.ToString("dd/MM/yyyy"), Result.Description, Result.Archive, Sortable)
        Next
        Results.btn_filterresults.Visible = False
        Results.btn_unfilterresults.Visible = True
        Results.btn_showarchived.Visible = True
        Results.btn_hidearchived.Visible = False
        If Results.data_results.Rows.Count = 0 Then
            Results.btn_editresult.Enabled = False
            Results.btn_deleteresult.Enabled = False
            Results.btn_archiveresult.Enabled = False
        Else
            Results.btn_editresult.Enabled = True
            Results.btn_deleteresult.Enabled = True
            Results.btn_archiveresult.Enabled = True
        End If
        Results.data_results.Sort(Results.data_results.Columns.Item(11), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
End Class