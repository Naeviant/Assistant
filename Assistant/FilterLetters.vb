Public Class FilterLetters
    Private Sub FilterLetters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssistantDS.LettersTable' table. You can move, or remove it, as needed.
        Me.LettersTableTableAdapter.Fill(Me.AssistantDS.LettersTable)

        com_notes.Text = " "
        com_from.Text = " "
        com_date.Text = " "
        com_topic.Text = " "
    End Sub

    Private Sub chk_notes_CheckedChanged(sender As Object, e As EventArgs) Handles chk_notes.CheckedChanged
        If chk_notes.Checked = True Then
            com_notes.Enabled = True
        Else
            com_notes.Enabled = False
            com_notes.Text = " "
        End If
    End Sub

    Private Sub chk_from_CheckedChanged(sender As Object, e As EventArgs) Handles chk_from.CheckedChanged
        If chk_from.Checked = True Then
            com_from.Enabled = True
        Else
            com_from.Enabled = False
            com_from.Text = " "
        End If
    End Sub

    Private Sub chk_date_CheckedChanged(sender As Object, e As EventArgs) Handles chk_date.CheckedChanged
        If chk_date.Checked = True Then
            com_date.Enabled = True
        Else
            com_date.Enabled = False
            com_date.Text = " "
        End If
    End Sub

    Private Sub chk_topic_CheckedChanged(sender As Object, e As EventArgs) Handles chk_topic.CheckedChanged
        If chk_topic.Checked = True Then
            com_topic.Enabled = True
        Else
            com_topic.Enabled = False
            com_topic.Text = " "
        End If
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        For Each f In My.Application.OpenForms
            If f.Name = "MainMenu" Then
                Dim fcast As New MainMenu
                fcast = f
                fcast.LettersTableTableAdapter.Sort(fcast.AssistantDS.LettersTable, com_topic.Text, com_from.Text, com_date.Text, com_notes.Text)
            End If
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class