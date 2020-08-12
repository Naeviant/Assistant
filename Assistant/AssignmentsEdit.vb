Public Class AssignmentsEdit
    Private Sub EditAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        com_subject.Items.Clear()
        com_subject.Items.Add("")
        Dim Subjects = SubjectsTableAdapter.GetData()
        For Each Subject In Subjects
            com_subject.Items.Add(Subject.SubjectName)
        Next
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        If lbl_id.Text = "None" Then
            com_subject.Text = ""
            com_priority.Text = "Normal"
            com_status.Text = "Not Started"
            num_progress.Value = 0
            date_start.Value = Today
            date_due.Value = Today.AddDays(7)
            time_due.Value = Today.AddHours(9)
            chk_archive.Checked = False
            txt_description.Text = ""
        Else
            Dim ID = lbl_id.Text
            Dim Assignment = AssignmentsTableAdapter.GetByID(ID).Rows(0)
            com_subject.Text = Assignment.Item(1)
            com_priority.Text = Assignment.Item(2)
            com_status.Text = Assignment.Item(4)
            num_progress.Value = Assignment.Item(3)
            date_start.Value = Assignment.Item(6)
            date_due.Value = Assignment.Item(7)
            time_due.Value = Assignment.Item(9)
            chk_archive.Checked = Assignment.Item(8)
            txt_description.Text = Assignment.Item(5)
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        date_start.Value.Date.Add(New TimeSpan(0, 0, 0))
        date_due.Value.Date.Add(New TimeSpan(0, 0, 0))
        If com_subject.Text <> "" And (com_priority.Text = "High" Or com_priority.Text = "Normal" Or com_priority.Text = "Low") And (com_status.Text = "Not Started" Or com_status.Text = "In Progress" Or com_status.Text = "On Hold" Or com_status.Text = "Completed") And txt_description.Text <> "" And date_start.Value < date_due.Value Then
            If lbl_id.Text = "None" Then
                AssignmentsTableAdapter.Add(com_subject.Text, com_priority.Text, num_progress.Value, com_status.Text, txt_description.Text, date_start.Value, date_due.Value, chk_archive.Checked, time_due.Value)
            Else
                AssignmentsTableAdapter.Edit(com_subject.Text, com_priority.Text, num_progress.Value, com_status.Text, txt_description.Text, date_start.Value, date_due.Value, chk_archive.Checked, time_due.Value, lbl_id.Text)
            End If
            Assignments.Reload_Table(sender, e)
            Me.Close()
        Else
            MessageBox.Show("Please enter valid inputs for all fields.", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class