Public Class AddSubjects
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_subject.Text = "" Or txt_teacher.Text = "" Or txt_room.Text = "" Or txt_class.Text = "" Then
            MessageBox.Show("You have not completed a field. Please make sure all fields have been completed before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For Each f In My.Application.OpenForms
                If f.Name = "MainMenu" Then
                    Dim fcast As New MainMenu
                    fcast = f
                    fcast.SubjectsTableBindingSource.EndEdit()
                    fcast.SubjectsTableTableAdapter.InsertNew(txt_subject.Text, txt_teacher.Text, txt_room.Text, txt_class.Text, Today.ToString("dd MMMM yyyy"), chk_revise.Checked)
                    fcast.SubjectsTableTableAdapter.Fill(fcast.AssistantDS.SubjectsTable)
                    txt_subject.Text = ""
                    txt_teacher.Text = ""
                    txt_room.Text = ""
                    txt_class.Text = ""
                    chk_revise.Checked = False
                    MessageBox.Show("The record was added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Next
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_subject.Text = ""
        txt_teacher.Text = ""
        txt_room.Text = ""
        txt_class.Text = ""
        chk_revise.Checked = False
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class