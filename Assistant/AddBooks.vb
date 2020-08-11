Public Class AddBooks
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If com_subject.Text = "" Or txt_bookname.Text = "" Or txt_location.Text = "" Then
            MessageBox.Show("You have not completed a field. Please make sure all fields have been completed before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For Each f In My.Application.OpenForms
                If f.Name = "MainMenu" Then
                    Dim fcast As New MainMenu
                    fcast = f
                    fcast.BooksTableBindingSource.EndEdit()
                    fcast.BooksTableTableAdapter.InsertNew(com_subject.Text, txt_bookname.Text, txt_location.Text, chk_full.Checked, txt_notes.Text)
                    fcast.BooksTableTableAdapter.Fill(fcast.AssistantDS.BooksTable)
                    com_subject.Text = ""
                    txt_bookname.Text = ""
                    txt_location.Text = ""
                    chk_full.Checked = False
                    txt_notes.Text = ""
                    MessageBox.Show("The record was added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Next
        End If

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        com_subject.Text = ""
        txt_bookname.Text = ""
        txt_location.Text = ""
        chk_full.Checked = False
        txt_notes.Text = ""
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub AddBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssistantDS.SubjectsTable' table. You can move, or remove it, as needed.
        Me.SubjectsTableTableAdapter.Fill(Me.AssistantDS.SubjectsTable)

        com_subject.Text = ""
    End Sub
End Class