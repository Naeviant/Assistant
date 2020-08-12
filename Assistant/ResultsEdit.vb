Public Class ResultsEdit
    Private Sub ResultsEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        If lbl_id.Text = "None" Then
            com_subject.Text = ""
            com_type.Text = ""
            num_score.Value = 0
            num_maxscore.Value = 0
            date_exam.Value = Today
            date_grade.Value = Today
            txt_grade.Text = ""
            chk_archive.Checked = False
            txt_description.Text = ""
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If com_subject.Text <> "" And com_type.Text <> "" And num_score.Value <= num_maxscore.Value And date_exam.Value <= date_grade.Value Then
            If lbl_id.Text = "None" Then
                ResultsTableAdapter.Add(com_subject.Text, com_type.Text, txt_description.Text, num_score.Value, num_maxscore.Value, txt_grade.Text, date_exam.Value, date_grade.Value, chk_archive.Checked)
            Else
                ResultsTableAdapter.Edit(com_subject.Text, com_type.Text, txt_description.Text, num_score.Value, num_maxscore.Value, txt_grade.Text, date_exam.Value, date_grade.Value, chk_archive.Checked, lbl_id.Text)
            End If
            Results.Reload_Table(sender, e)
            Me.Close()
        Else
            MessageBox.Show("Please enter valid inputs for all fields.", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class