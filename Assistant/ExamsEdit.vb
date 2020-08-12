Public Class ExamsEdit
    Private Sub ExamsEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            txt_location.Text = ""
            txt_seat.Text = ""
            date_datetime.Value = Today
            chk_archived.Checked = False
        Else
            Dim ID = lbl_id.Text
            Dim Exam = ExamsTableAdapter.GetByID(ID).Rows(0)
            com_subject.Text = Exam.Item(1)
            com_type.Text = Exam.Item(2)
            txt_location.Text = Exam.Item(4)
            txt_seat.Text = Exam.ItemArray(6)
            date_datetime.Value = Exam.Item(3)
            chk_archived.Checked = Exam.Item(5)
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If com_subject.Text <> "" And com_type.Text <> "" And txt_location.Text <> "" And txt_seat.Text <> "" Then
            If lbl_id.Text = "None" Then
                ExamsTableAdapter.Add(com_subject.Text, com_type.Text, date_datetime.Value, txt_location.Text, chk_archived.Checked, txt_seat.Text)
            Else
                ExamsTableAdapter.Edit(com_subject.Text, com_type.Text, date_datetime.Value, txt_location.Text, chk_archived.Checked, txt_seat.Text, lbl_id.Text)
            End If
            Exams.Reload_Table(sender, e)
            Me.Close()
        Else
            MessageBox.Show("Please enter valid inputs for all fields.", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class