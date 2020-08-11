Public Class FilterResults
    Private Sub FilterResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssistantDS.ResultsTable' table. You can move, or remove it, as needed.
        Me.ResultsTableTableAdapter.Fill(Me.AssistantDS.ResultsTable)

        com_subject.Text = " "
        com_marks.Text = " "
        com_total.Text = " "
        com_grade.Text = " "
        com_day.Text = " "
        com_percentage.Text = " "
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

    Private Sub chk_marks_CheckedChanged(sender As Object, e As EventArgs) Handles chk_marks.CheckedChanged
        If chk_marks.Checked = True Then
            com_marks.Enabled = True
        Else
            com_marks.Enabled = False
            com_marks.Text = " "
        End If
    End Sub

    Private Sub chk_total_CheckedChanged(sender As Object, e As EventArgs) Handles chk_total.CheckedChanged
        If chk_total.Checked = True Then
            com_total.Enabled = True
        Else
            com_total.Enabled = False
            com_total.Text = " "
        End If
    End Sub

    Private Sub chk_grade_CheckedChanged(sender As Object, e As EventArgs) Handles chk_grade.CheckedChanged
        If chk_grade.Checked = True Then
            com_grade.Enabled = True
        Else
            com_grade.Enabled = False
            com_grade.Text = " "
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

    Private Sub chk_percentage_CheckedChanged(sender As Object, e As EventArgs) Handles chk_percentage.CheckedChanged
        If chk_percentage.Checked = True Then
            com_percentage.Enabled = True
        Else
            com_percentage.Enabled = False
            com_percentage.Text = " "
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
                Dim marks As Integer
                Dim total As Integer
                Dim percentage As Double
                If chk_marks.Checked = True Then
                    marks = com_marks.Text
                Else
                    marks = -1
                End If
                If chk_total.Checked = True Then
                    total = com_total.Text
                Else
                    total = -1
                End If
                If chk_percentage.Checked = True Then
                    percentage = com_percentage.Text
                Else
                    percentage = -1
                End If
                fcast = f
                fcast.ResultsTableTableAdapter.Sort(fcast.AssistantDS.ResultsTable, com_subject.Text, marks, total, com_grade.Text, com_day.Text, percentage, com_notes.Text)
            End If
        Next
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class