Public Class AddToDos
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_title.Text = "" Or txt_location.Text = "" Or txt_description.Text = "" Then
            MessageBox.Show("You have not completed a field. Please make sure all fields have been completed before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For Each f In My.Application.OpenForms
                If f.Name = "MainMenu" Then
                    Dim fcast As New MainMenu
                    fcast = f
                    fcast.ToDosTableBindingSource.EndEdit()
                    fcast.ToDosTableTableAdapter.InsertNew(txt_title.Text, date_date.Value.ToString("dd MMMM yyyy"), date_time.Value.ToString("HH:mm"), txt_location.Text, txt_description.Text, txt_notes.Text)
                    fcast.ToDosTableTableAdapter.Fill(fcast.AssistantDS.ToDosTable)
                    txt_title.Text = ""
                    txt_location.Text = ""
                    date_date.Value = Now
                    date_time.Value = Now
                    txt_description.Text = ""
                    txt_notes.Text = ""
                    MessageBox.Show("The record was added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Next
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_title.Text = ""
        txt_location.Text = ""
        date_date.Value = Now
        date_time.Value = Now
        txt_description.Text = ""
        txt_notes.Text = ""
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class