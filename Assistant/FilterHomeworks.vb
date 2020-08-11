Public Class FilterHomeworks
    Private Sub chk_subject_CheckedChanged(sender As Object, e As EventArgs) Handles chk_subject.CheckedChanged
        If chk_subject.Checked = True Then
            com_subject.Enabled = True
        Else
            com_subject.Enabled = False
            com_subject.Text = " "
        End If
    End Sub

    Private Sub chk_priority_CheckedChanged(sender As Object, e As EventArgs) Handles chk_priority.CheckedChanged
        If chk_priority.Checked = True Then
            com_priority.Enabled = True
        Else
            com_priority.Enabled = False
            com_priority.Text = " "
        End If
    End Sub

    Private Sub chk_status_CheckedChanged(sender As Object, e As EventArgs) Handles chk_status.CheckedChanged
        If chk_status.Checked = True Then
            com_status.Enabled = True
        Else
            com_status.Enabled = False
            com_status.Text = " "
        End If
    End Sub

    Private Sub chk_completion_CheckedChanged(sender As Object, e As EventArgs) Handles chk_completion.CheckedChanged
        If chk_completion.Checked = True Then
            com_completion.Enabled = True
        Else
            com_completion.Enabled = False
            com_completion.Text = " "
        End If
    End Sub

    Private Sub chk_setdate_CheckedChanged(sender As Object, e As EventArgs) Handles chk_setdate.CheckedChanged
        If chk_setdate.Checked = True Then
            com_setdate.Enabled = True
        Else
            com_setdate.Enabled = False
            com_setdate.Text = " "
        End If
    End Sub

    Private Sub chk_setperiod_CheckedChanged(sender As Object, e As EventArgs) Handles chk_setperiod.CheckedChanged
        If chk_setperiod.Checked = True Then
            com_setperiod.Enabled = True
        Else
            com_setperiod.Enabled = False
            com_setperiod.Text = " "
        End If
    End Sub

    Private Sub chk_duedate_CheckedChanged(sender As Object, e As EventArgs) Handles chk_duedate.CheckedChanged
        If chk_duedate.Checked = True Then
            com_duedate.Enabled = True
        Else
            com_duedate.Enabled = False
            com_duedate.Text = " "
        End If
    End Sub

    Private Sub chk_dueperiod_CheckedChanged(sender As Object, e As EventArgs) Handles chk_dueperiod.CheckedChanged
        If chk_dueperiod.Checked = True Then
            com_dueperiod.Enabled = True
        Else
            com_dueperiod.Enabled = False
            com_dueperiod.Text = " "
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
                Dim progress As Integer
                If chk_completion.Checked = True Then
                    progress = com_completion.Text
                Else
                    progress = -1
                End If
                fcast = f
                fcast.HomeworkTableTableAdapter.Sort(fcast.AssistantDS.HomeworkTable, com_subject.Text, com_setdate.Text, com_setperiod.Text, com_duedate.Text, com_dueperiod.Text, com_priority.Text, com_status.Text, progress, com_description.Text, com_notes.Text)
            End If
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub FilterHomeworks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssistantDS.HomeworkTable' table. You can move, or remove it, as needed.
        Me.HomeworkTableTableAdapter.Fill(Me.AssistantDS.HomeworkTable)

        com_subject.Text = ""
        com_priority.Text = ""
        com_status.Text = ""
        com_completion.Text = ""
        com_setdate.Text = ""
        com_setperiod.Text = ""
        com_duedate.Text = ""
        com_dueperiod.Text = ""
        com_description.Text = ""
        com_notes.Text = ""
    End Sub
End Class