Public Class FilterBooks
    Private Sub FilterBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssistantDS.BooksTable' table. You can move, or remove it, as needed.
        Me.BooksTableTableAdapter.Fill(Me.AssistantDS.BooksTable)

        com_subject.Text = " "
        com_bookname.Text = " "
        com_location.Text = " "
        com_notes.Text = " "

    End Sub

    Private Sub chk_subject_CheckedChanged(sender As Object, e As EventArgs) Handles chk_subject.CheckedChanged
        If chk_subject.Checked = True Then
            com_subject.Enabled = True
        Else
            com_subject.Enabled = False
            com_subject.Text = " "
        End If
    End Sub

    Private Sub chk_bookname_CheckedChanged(sender As Object, e As EventArgs) Handles chk_bookname.CheckedChanged
        If chk_bookname.Checked = True Then
            com_bookname.Enabled = True
        Else
            com_bookname.Enabled = False
            com_bookname.Text = " "
        End If
    End Sub

    Private Sub chk_location_CheckedChanged(sender As Object, e As EventArgs) Handles chk_location.CheckedChanged
        If chk_location.Checked = True Then
            com_location.Enabled = True
        Else
            com_location.Enabled = False
            com_location.Text = " "
        End If
    End Sub

    Private Sub chk_notes_CheckedChanged(sender As Object, e As EventArgs) Handles chk_notes.CheckedChanged
        If chk_notes.Checked = True Then
            com_notes.Enabled = True
        Else
            com_notes.Enabled = False
            com_notes.Text = " "
        End If
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        For Each f In My.Application.OpenForms
            If f.Name = "MainMenu" Then
                Dim fcast As New MainMenu
                fcast = f
                fcast.BooksTableTableAdapter.Sort(fcast.AssistantDS.BooksTable, com_subject.Text, com_bookname.Text, com_location.Text, False, com_notes.Text)
            End If
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class