Public Class AddLetters
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_topic.Text = "" Or txt_from.Text = "" Then
            MessageBox.Show("You have not completed a field. Please make sure all fields have been completed before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For Each f In My.Application.OpenForms
                If f.Name = "MainMenu" Then
                    Dim fcast As New MainMenu
                    fcast = f
                    fcast.LettersTableBindingSource.EndEdit()
                    fcast.LettersTableTableAdapter.InsertNew(txt_topic.Text, txt_from.Text, date_date.Value.ToString("dd MMMM yyyy"), chk_responseneeded.Checked, chk_responsegiven.Checked, txt_notes.Text)
                    fcast.LettersTableTableAdapter.Fill(fcast.AssistantDS.LettersTable)
                    txt_topic.Text = ""
                    txt_from.Text = ""
                    date_date.Value = Now
                    chk_responseneeded.Checked = False
                    chk_responsegiven.Checked = False
                    txt_notes.Text = ""
                    MessageBox.Show("The record was added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Next
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