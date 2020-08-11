Public Class FilterSubjects
    Private Sub chk_subject_CheckedChanged(sender As Object, e As EventArgs) Handles chk_subject.CheckedChanged
        If chk_subject.Checked = True Then
            com_subject.Enabled = True
        Else
            com_subject.Enabled = False
            com_subject.Text = " "
        End If
    End Sub

    Private Sub chk_teacher_CheckedChanged(sender As Object, e As EventArgs) Handles chk_teacher.CheckedChanged
        If chk_teacher.Checked = True Then
            com_teacher.Enabled = True
        Else
            com_teacher.Enabled = False
            com_teacher.Text = " "
        End If
    End Sub

    Private Sub chk_room_CheckedChanged(sender As Object, e As EventArgs) Handles chk_room.CheckedChanged
        If chk_room.Checked = True Then
            com_room.Enabled = True
        Else
            com_room.Enabled = False
            com_room.Text = " "
        End If
    End Sub

    Private Sub chk_class_CheckedChanged(sender As Object, e As EventArgs) Handles chk_class.CheckedChanged
        If chk_class.Checked = True Then
            com_class.Enabled = True
        Else
            com_class.Enabled = False
            com_class.Text = " "
        End If
    End Sub

    Private Sub FilterSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssistantDS.SubjectsTable' table. You can move, or remove it, as needed.
        Me.SubjectsTableTableAdapter.Fill(Me.AssistantDS.SubjectsTable)

        com_subject.Text = " "
        com_teacher.Text = " "
        com_room.Text = " "
        com_class.Text = " "
        com_lastrevised.Text = " "
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        For Each f In My.Application.OpenForms
            If f.Name = "MainMenu" Then
                Dim fcast As New MainMenu
                fcast = f
                fcast.SubjectsTableTableAdapter.Sort(fcast.AssistantDS.SubjectsTable, com_subject.Text, com_teacher.Text, com_room.Text, com_class.Text, com_lastrevised.Text)
            End If
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub chk_lastrevised_CheckedChanged(sender As Object, e As EventArgs) Handles chk_lastrevised.CheckedChanged
        If chk_lastrevised.Checked = True Then
            com_lastrevised.Enabled = True
        Else
            com_lastrevised.Enabled = False
            com_lastrevised.Text = " "
        End If
    End Sub
End Class