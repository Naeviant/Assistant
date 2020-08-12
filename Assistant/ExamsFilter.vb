Public Class ExamsFilter
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        Dim ExamDate
        If date_datetime.Checked = True Then
            ExamDate = date_datetime.Value.Date.Add(New TimeSpan(0, 0, 0))
        Else
            ExamDate = Nothing
        End If
        Exams.data_exams.Rows.Clear()
        Dim ExamResults = ExamsTableAdapter.Sort(com_subject.Text, com_type.Text, ExamDate, txt_location.Text, txt_seat.Text)
        For Each Exam In ExamResults
            Dim Sortable As DateTime = New Date(Exam.ExamDateTime.Year, Exam.ExamDateTime.Month, Exam.ExamDateTime.Day, Exam.ExamDateTime.Hour, Exam.ExamDateTime.Minute, 0)
            Exams.data_exams.Rows.Add(Exam.ID, Exam.Subject, Exam.Type, Exam.Location, Exam.Seat, Exam.ExamDateTime.ToString("ddd dd/MM/yyyy mm"), Exam.Archive, Sortable)
        Next
        Exams.btn_filterexams.Visible = False
        Exams.btn_unfilterexams.Visible = True
        Exams.btn_showarchived.Visible = True
        Exams.btn_hidearchived.Visible = False
        If Exams.data_exams.Rows.Count = 0 Then
            Exams.btn_editexam.Enabled = False
            Exams.btn_deleteexam.Enabled = False
            Exams.btn_archiveexam.Enabled = False
        Else
            Exams.btn_editexam.Enabled = True
            Exams.btn_deleteexam.Enabled = True
            Exams.btn_archiveexam.Enabled = True
        End If
        Exams.data_exams.Sort(Exams.data_exams.Columns.Item(7), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub ExamsFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        date_datetime.Checked = False
    End Sub
End Class