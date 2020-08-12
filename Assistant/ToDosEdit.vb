Public Class ToDosEdit
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        If lbl_id.Text = "None" Then
            date_datetime.Value = Today.AddDays(1).Add(New TimeSpan(9, 0, 0))
            txt_description.Text = ""
        Else
            Dim ID = lbl_id.Text
            Dim ToDo = ToDosTableAdapter.GetByID(ID).Rows(0)
            date_datetime.Value = ToDo.Item(1)
            txt_description.Text = ToDo.Item(2)
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_description.Text <> "" Then
            If lbl_id.Text = "None" Then
                ToDosTableAdapter.Add(date_datetime.Value, txt_description.Text)
            Else
                ToDosTableAdapter.Edit(date_datetime.Value, txt_description.Text, lbl_id.Text)
            End If
            ToDos.Reload_Table(sender, e)
            Me.Close()
        Else
            MessageBox.Show("Please enter valid inputs for all fields.", "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class