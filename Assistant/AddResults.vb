Public Class AddResults
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If com_subject.Text = "" Or txt_grade.Text = "" Or num_total.Value = 0 Then
            MessageBox.Show("You have not completed a field. Please make sure all fields have been completed before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf num_marks.Value > num_total.Value Then
            MessageBox.Show("The number of marks achieved cannot exceed the total number of marks!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For Each f In My.Application.OpenForms
                If f.Name = "MainMenu" Then
                    Dim fcast As New MainMenu
                    fcast = f
                    fcast.ResultsTableBindingSource.EndEdit()
                    fcast.ResultsTableTableAdapter.InsertNew(com_subject.Text, num_marks.Value, num_total.Value, txt_grade.Text, date_date.Value.ToString("dd MMMM yyyy"), txt_notes.Text)
                    fcast.ResultsTableTableAdapter.Fill(fcast.AssistantDS.ResultsTable)
                    com_subject.Text = ""
                    date_date.Value = Now
                    num_marks.Value = 0
                    num_total.Value = 0
                    txt_grade.Text = ""
                    txt_notes.Text = ""
                    MessageBox.Show("The record was added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Next
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        com_subject.Text = ""
        date_date.Value = Now
        num_marks.Value = 0
        num_total.Value = 0
        txt_grade.Text = ""
        txt_notes.Text = ""
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub AddResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssistantDS.SubjectsTable' table. You can move, or remove it, as needed.
        Me.SubjectsTableTableAdapter.Fill(Me.AssistantDS.SubjectsTable)

        com_subject.Text = ""
    End Sub
End Class