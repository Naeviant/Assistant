Public Class EditExams
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If lbl_id.Text = "" Then
            MessageBox.Show("The ID could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf com_subject.Text = "" Or txt_location.Text = "" Then
            MessageBox.Show("You have not completed a field. Please make sure all fields have been completed before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For Each f In My.Application.OpenForms
                If f.Name = "MainMenu" Then
                    Dim fcast As New MainMenu
                    fcast = f
                    fcast.ExamsTableBindingSource.EndEdit()
                    fcast.ExamsTableTableAdapter.Edit(com_subject.Text, txt_location.Text, date_date.Value.ToString("dd MMMM yyyy"), date_starttime.Value.ToString("HH:mm"), date_endtime.Value.ToString("HH:mm"), txt_notes.Text, lbl_id.Text)
                    fcast.ExamsTableTableAdapter.Fill(fcast.AssistantDS.ExamsTable)
                End If
            Next
            Me.Close()
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        com_subject.Text = ""
        txt_location.Text = ""
        date_date.Value = Now
        date_starttime.Value = Now
        date_endtime.Value = Now
        txt_notes.Text = ""
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub EditExams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssistantDS.SubjectsTable' table. You can move, or remove it, as needed.
        Me.SubjectsTableTableAdapter.Fill(Me.AssistantDS.SubjectsTable)

    End Sub
End Class