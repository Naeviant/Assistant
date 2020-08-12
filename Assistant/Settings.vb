Public Class Settings
    Private Sub btn_newsubject_Click(sender As Object, e As EventArgs) Handles btn_newsubject.Click
        lst_subjects.Items.Add(txt_subject.Text)
        SubjectsTableAdapter.Add(txt_subject.Text)
        txt_subject.Text = ""
    End Sub

    Private Sub btn_removesubject_Click(sender As Object, e As EventArgs) Handles btn_removesubject.Click
        Dim Subject = lst_subjects.SelectedItem
        lst_subjects.Items.Remove(Subject)
        SubjectsTableAdapter.DeleteByName(Subject)
    End Sub

    Private Sub btn_addexam_Click(sender As Object, e As EventArgs) Handles btn_addexam.Click
        lst_exams.Items.Add(txt_exam.Text)
        Exam_TypesTableAdapter.Add(txt_exam.Text)
        txt_exam.Text = ""
    End Sub

    Private Sub btn_deleteexam_Click(sender As Object, e As EventArgs) Handles btn_deleteexam.Click
        Dim Exam = lst_exams.SelectedItem
        lst_exams.Items.Remove(Exam)
        SubjectsTableAdapter.DeleteByName(Exam)
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Subjects = SubjectsTableAdapter.GetData()
        For Each Subject In Subjects
            lst_subjects.Items.Add(Subject.SubjectName)
        Next
        Dim Exams = Exam_TypesTableAdapter.GetData()
        For Each Exam In Exams
            lst_exams.Items.Add(Exam.ExamType)
        Next
    End Sub

    Private Sub lbl_icon1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_icon1.LinkClicked
        Process.Start("http://www.customicondesign.com/free-icons/flatastic-icon-set/flatastic-part-1/")
    End Sub

    Private Sub lbl_icon2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_icon2.LinkClicked
        Process.Start("https://iconarchive.com/show/farm-fresh-icons-by-fatcow/filter-add-icon.html")
    End Sub

    Private Sub lbl_icon3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_icon3.LinkClicked
        Process.Start("https://iconarchive.com/show/farm-fresh-icons-by-fatcow/filter-delete-icon.html")
    End Sub

    Private Sub lbl_icon4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_icon4.LinkClicked
        Process.Start("https://iconarchive.com/show/ravenna-3d-icons-by-double-j-design/Books-icon.html")
    End Sub

    Private Sub lbl_icon5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) 
        Process.Start("https://iconarchive.com/show/flatastic-3-icons-by-custom-icon-design.html")
    End Sub
End Class