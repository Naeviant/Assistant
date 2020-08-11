Public Class EditEvents
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If lbl_id.Text = "" Then
            MessageBox.Show("The ID could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txt_event.Text = "" Or txt_location.Text = "" Then
            MessageBox.Show("You have not completed a field. Please make sure all fields have been completed before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For Each f In My.Application.OpenForms
                If f.Name = "MainMenu" Then
                    Dim fcast As New MainMenu
                    fcast = f
                    fcast.EventsTableBindingSource.EndEdit()
                    fcast.EventsTableTableAdapter.Edit(txt_event.Text, txt_location.Text, date_date.Value.ToString("dd MMMM yyyy"), date_starttime.Value.ToString("HH:mm"), date_endtime.Value.ToString("HH:mm"), chk_attending.Checked, txt_notes.Text, lbl_id.Text)
                    fcast.EventsTableTableAdapter.Fill(fcast.AssistantDS.EventsTable)
                End If
            Next
            Me.Close()
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_event.Text = ""
        txt_location.Text = ""
        chk_attending.Checked = False
        date_date.Value = Now
        date_starttime.Value = Now
        date_endtime.Value = Now
        txt_notes.Text = ""
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class