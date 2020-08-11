Public Class EditRooms
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If lbl_id.Text = "" Then
            MessageBox.Show("The ID could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf com_subject.Text = "" Or txt_from.Text = "" Or txt_to.Text = "" Or txt_period.Text = "" Or txt_reason.Text = "" Then
            MessageBox.Show("You have not completed a field. Please make sure all fields have been completed before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For Each f In My.Application.OpenForms
                If f.Name = "MainMenu" Then
                    Dim fcast As New MainMenu
                    fcast = f
                    fcast.RoomsTableBindingSource.EndEdit()
                    fcast.RoomsTableTableAdapter.Edit(com_subject.Text, txt_from.Text, txt_to.Text, date_date.Value.ToString("dd MMMM yyyy"), txt_period.Text, txt_reason.Text, txt_notes.Text, lbl_id.Text)
                    fcast.RoomsTableTableAdapter.Fill(fcast.AssistantDS.RoomsTable)
                    com_subject.Text = ""
                    txt_from.Text = ""
                    txt_to.Text = ""
                    date_date.Value = Now
                    txt_period.Text = ""
                    txt_reason.Text = ""
                    txt_notes.Text = ""
                End If
            Next
            Me.Close()
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        com_subject.Text = ""
        txt_from.Text = ""
        txt_to.Text = ""
        date_date.Value = Now
        txt_period.Text = ""
        txt_reason.Text = ""
        txt_notes.Text = ""
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub EditRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssistantDS.SubjectsTable' table. You can move, or remove it, as needed.
        Me.SubjectsTableTableAdapter.Fill(Me.AssistantDS.SubjectsTable)

        com_subject.Text = ""
    End Sub
End Class