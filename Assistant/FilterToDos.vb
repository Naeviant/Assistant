Public Class FilterToDos
    Private Sub FilterToDos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssistantDS.ToDosTable' table. You can move, or remove it, as needed.
        Me.ToDosTableTableAdapter.Fill(Me.AssistantDS.ToDosTable)

        com_title.Text = " "
        com_location.Text = " "
        com_day.Text = " "
        com_time.Text = " "
        com_description.Text = " "
        com_notes.Text = " "
    End Sub

    Private Sub chk_title_CheckedChanged(sender As Object, e As EventArgs) Handles chk_title.CheckedChanged
        If chk_title.Checked = True Then
            com_title.Enabled = True
        Else
            com_title.Enabled = False
            com_title.Text = " "
        End If
    End Sub

    Private Sub chk_day_CheckedChanged(sender As Object, e As EventArgs) Handles chk_day.CheckedChanged
        If chk_day.Checked = True Then
            com_day.Enabled = True
        Else
            com_day.Enabled = False
            com_day.Text = " "
        End If
    End Sub

    Private Sub chk_time_CheckedChanged(sender As Object, e As EventArgs) Handles chk_time.CheckedChanged
        If chk_time.Checked = True Then
            com_time.Enabled = True
        Else
            com_time.Enabled = False
            com_time.Text = " "
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

    Private Sub chk_description_CheckedChanged(sender As Object, e As EventArgs) Handles chk_description.CheckedChanged
        If chk_description.Checked = True Then
            com_description.Enabled = True
        Else
            com_description.Enabled = False
            com_description.Text = " "
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
                fcast.ToDosTableTableAdapter.Sort(fcast.AssistantDS.ToDosTable, com_title.Text, com_day.Text, com_time.Text, com_location.Text, com_description.Text, com_notes.Text)
            End If
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class