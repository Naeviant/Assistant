Public Class AddExams
    Private Sub AddExams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssistantDS.SubjectsTable' table. You can move, or remove it, as needed.
        Me.SubjectsTableTableAdapter.Fill(Me.AssistantDS.SubjectsTable)

        com_subject.Text = ""
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If com_subject.Text = "" Or txt_location.Text = "" Then
            MessageBox.Show("You have not completed a field. Please make sure all fields have been completed before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For Each f In My.Application.OpenForms
                If f.Name = "MainMenu" Then
                    Dim fcast As New MainMenu
                    fcast = f
                    fcast.ExamsTableBindingSource.EndEdit()
                    fcast.ExamsTableTableAdapter.InsertNew(com_subject.Text, txt_location.Text, date_date.Value.ToString("dd MMMM yyyy"), date_starttime.Value.ToString("HH:mm"), date_endtime.Value.ToString("HH:mm"), txt_notes.Text)
                    fcast.ExamsTableTableAdapter.Fill(fcast.AssistantDS.ExamsTable)
                    com_subject.Text = ""
                    txt_location.Text = ""
                    date_date.Value = Now
                    date_starttime.Value = Now
                    date_endtime.Value = Now
                    txt_notes.Text = ""
                    MessageBox.Show("The record was added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Next
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
End Class