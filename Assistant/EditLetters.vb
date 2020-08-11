Public Class EditLetters
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If lbl_id.Text = "" Then
            MessageBox.Show("The ID could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txt_topic.Text = "" Or txt_from.Text = "" Then
            MessageBox.Show("You have not completed a field. Please make sure all fields have been completed before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For Each f In My.Application.OpenForms
                If f.Name = "MainMenu" Then
                    Dim fcast As New MainMenu
                    fcast = f
                    fcast.LettersTableBindingSource.EndEdit()
                    fcast.LettersTableTableAdapter.Edit(txt_topic.Text, txt_from.Text, date_date.Value.ToString("dd MMMM yyyy"), chk_responseneeded.Checked, chk_responsegiven.Checked, txt_notes.Text, lbl_id.Text)
                    fcast.LettersTableTableAdapter.Fill(fcast.AssistantDS.LettersTable)
                    MessageBox.Show("The record was edited.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Next
            Me.Close()
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_topic.Text = ""
        txt_from.Text = ""
        date_date.Value = Now
        chk_responseneeded.Checked = False
        chk_responsegiven.Checked = False
        txt_notes.Text = ""
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class