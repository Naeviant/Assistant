Public Class EditSubjects
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If lbl_id.Text = "" Then
            MessageBox.Show("The ID could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txt_subject.Text = "" Or txt_teacher.Text = "" Or txt_room.Text = "" Or txt_class.Text = "" Then
            MessageBox.Show("You have not completed a field. Please make sure all fields have been completed before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For Each f In My.Application.OpenForms
                If f.Name = "MainMenu" Then
                    Dim fcast As New MainMenu
                    fcast = f
                    fcast.SubjectsTableBindingSource.EndEdit()
                    fcast.SubjectsTableTableAdapter.Edit(txt_subject.Text, txt_teacher.Text, txt_room.Text, txt_class.Text, lbl_lastrevised.Text, lbl_id.Text)
                    fcast.SubjectsTableTableAdapter.Fill(fcast.AssistantDS.SubjectsTable)
                End If
            Next
            Me.Close()
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_subject.Text = ""
        txt_teacher.Text = ""
        txt_room.Text = ""
        txt_class.Text = ""
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class