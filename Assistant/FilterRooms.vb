Public Class FilterRooms
    Private Sub FilterRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssistantDS.RoomsTable' table. You can move, or remove it, as needed.
        Me.RoomsTableTableAdapter.Fill(Me.AssistantDS.RoomsTable)

        com_subject.Text = " "
        com_from.Text = " "
        com_to.Text = " "
        com_day.Text = " "
        com_period.Text = " "
        com_reason.Text = " "
        com_notes.Text = " "
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        For Each f In My.Application.OpenForms
            If f.Name = "MainMenu" Then
                Dim fcast As New MainMenu
                fcast = f
                fcast.RoomsTableTableAdapter.Sort(fcast.AssistantDS.RoomsTable, com_subject.Text, com_from.Text, com_to.Text, com_day.Text, com_period.Text, com_reason.Text, com_reason.Text)
            End If
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub chk_subject_CheckedChanged(sender As Object, e As EventArgs) Handles chk_subject.CheckedChanged
        If chk_subject.Checked = True Then
            com_subject.Enabled = True
        Else
            com_subject.Enabled = False
            com_subject.Text = " "
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

    Private Sub chk_to_CheckedChanged(sender As Object, e As EventArgs) Handles chk_to.CheckedChanged
        If chk_to.Checked = True Then
            com_to.Enabled = True
        Else
            com_to.Enabled = False
            com_to.Text = " "
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

    Private Sub chk_period_CheckedChanged(sender As Object, e As EventArgs) Handles chk_period.CheckedChanged
        If chk_period.Checked = True Then
            com_period.Enabled = True
        Else
            com_period.Enabled = False
            com_period.Text = " "
        End If
    End Sub

    Private Sub chk_reason_CheckedChanged(sender As Object, e As EventArgs) Handles chk_reason.CheckedChanged
        If chk_reason.Checked = True Then
            com_reason.Enabled = True
        Else
            com_reason.Enabled = False
            com_reason.Text = " "
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
End Class