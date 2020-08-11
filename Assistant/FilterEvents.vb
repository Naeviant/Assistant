Public Class FilterEvents
    Private Sub FilterEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssistantDS.EventsTable' table. You can move, or remove it, as needed.
        Me.EventsTableTableAdapter.Fill(Me.AssistantDS.EventsTable)

        com_event.Text = " "
        com_location.Text = " "
        com_date.Text = " "
        com_starttime.Text = " "
        com_endtime.Text = " "
        com_notes.Text = " "
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        For Each f In My.Application.OpenForms
            If f.Name = "MainMenu" Then
                Dim fcast As New MainMenu
                fcast = f
                fcast.EventsTableTableAdapter.Sort(fcast.AssistantDS.EventsTable, com_event.Text, com_location.Text, com_date.Text, com_starttime.Text, com_endtime.Text, False, com_notes.Text)
            End If
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub chk_event_CheckedChanged(sender As Object, e As EventArgs) Handles chk_event.CheckedChanged
        If chk_event.Checked = True Then
            com_event.Enabled = True
        Else
            com_event.Enabled = False
            com_event.Text = " "
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

    Private Sub chk_date_CheckedChanged(sender As Object, e As EventArgs) Handles chk_date.CheckedChanged
        If chk_date.Checked = True Then
            com_date.Enabled = True
        Else
            com_date.Enabled = False
            com_date.Text = " "
        End If
    End Sub

    Private Sub chk_starttime_CheckedChanged(sender As Object, e As EventArgs) Handles chk_starttime.CheckedChanged
        If chk_starttime.Checked = True Then
            com_starttime.Enabled = True
        Else
            com_starttime.Enabled = False
            com_starttime.Text = " "
        End If
    End Sub

    Private Sub chk_endtime_CheckedChanged(sender As Object, e As EventArgs) Handles chk_endtime.CheckedChanged
        If chk_endtime.Checked = True Then
            com_endtime.Enabled = True
        Else
            com_endtime.Enabled = False
            com_endtime.Text = " "
        End If
    End Sub
End Class