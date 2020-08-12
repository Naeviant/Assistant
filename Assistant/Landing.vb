Public Class Landing
    Private Sub Landing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grp_assignments.Controls.Clear()
        grp_overdue.Controls.Clear()
        grp_exams.Controls.Clear()
        grp_results.Controls.Clear()
        grp_todos.Controls.Clear()

        Dim Assignments = AssignmentsTableAdapter.GetNonArchived().OrderBy(Function(assignment) assignment.DueDate).ThenBy(Function(assignment) assignment.DueTime)
        Dim Top1 As Integer = 20
        Dim Top2 As Integer = 20
        Dim Count1 As Integer = 0
        Dim Count2 As Integer = 0
        For Each Assignment In Assignments
            Dim NewLabel As New Label
            Dim LabelText As String
            If Assignment.Status = "Not Started" Or Assignment.Status = "Completed" Then
                LabelText = Assignment.Subject + " due on " + Assignment.DueDate.ToString("ddd dd/MM/yyyy") + " at " + Assignment.DueTime.ToString("HH:mm") + " (" + Assignment.Status + ")"
            Else
                LabelText = Assignment.Subject + " due on " + Assignment.DueDate.ToString("ddd dd/MM/yyyy") + " at " + Assignment.DueTime.ToString("HH:mm") + " (" + Assignment.Status + ", " + Assignment.Completion.ToString() + "% Completed)"
            End If
            NewLabel.Text = LabelText
            NewLabel.Left = 6
            NewLabel.AutoSize = True
            If Assignment.DueDate > Today Then
                If Count1 < 5 Then
                    NewLabel.Top = Top1
                    grp_assignments.Controls.Add(NewLabel)
                    Top1 = Top1 + 15
                    Count1 = Count1 + 1
                End If
            Else
                If Count2 < 5 Then
                    NewLabel.Top = Top2
                    grp_overdue.Controls.Add(NewLabel)
                    Top2 = Top2 + 15
                    Count2 = Count2 + 1
                End If
            End If
        Next

        Dim Exams = ExamsTableAdapter.GetNonArchived().OrderBy(Function(exam) exam.ExamDateTime)
        Dim Top As Integer = 20
        Dim Count As Integer = 0
        For Each Exam In Exams
            If Exam.ExamDateTime > Today Then
                Dim NewLabel As New Label
                Dim LabelText As String = Exam.Type + " for " + Exam.Subject + " on " + Exam.ExamDateTime.ToString("ddd dd/MM/yyyy \a\t HH:mm") + " in " + Exam.Location + " (Seat " + Exam.Seat + ")"
                NewLabel.Text = LabelText
                NewLabel.Top = Top
                NewLabel.Left = 6
                NewLabel.AutoSize = True
                grp_exams.Controls.Add(NewLabel)
                Top = Top + 15
            End If
            Count = Count + 1
            If Count > 4 Then
                Exit For
            End If
        Next

        Dim Results = ResultsTableAdapter.GetNonArchived().OrderBy(Function(result) result.GradeDate)
        Top = 20
        Count = 0
        For Each Result In Results
            Dim NewLabel As New Label
            Dim LabelText As String
            If Result.Grade <> "" And Result.MaxScore > 0 Then
                LabelText = Result.Score.ToString() + "/" + Result.MaxScore.ToString() + " (" + (Result.Score / Result.MaxScore * 100).ToString() + "%, Grade " + Result.Grade + ") achieved in " + Result.Subject + " " + Result.Type + " on " + Result.GradeDate.ToString("ddd dd/MM/yyyy")
            ElseIf Result.MaxScore > 0 Then
                LabelText = Result.Score.ToString() + "/" + Result.MaxScore.ToString() + " (" + (Result.Score / Result.MaxScore * 100).ToString() + "%) achieved in " + Result.Subject + " " + Result.Type + " on " + Result.GradeDate.ToString("ddd dd/MM/yyyy")
            ElseIf Result.Grade <> "" Then
                LabelText = "Grade " + Result.Grade + " achieved in " + Result.Subject + " " + Result.Type + " on " + Result.GradeDate.ToString("ddd dd/MM/yyyy")
            Else
                Continue For
            End If
            NewLabel.Text = LabelText
            NewLabel.Top = Top
            NewLabel.Left = 6
            NewLabel.AutoSize = True
            grp_results.Controls.Add(NewLabel)
            Top = Top + 15
            Count = Count + 1
            If Count > 4 Then
                Exit For
            End If
        Next

        Dim ToDos = ToDosTableAdapter.GetData().OrderBy(Function(todo) todo.AtDateTime)
        Top = 20
        Count = 0
        For Each ToDo In ToDos
            Dim NewLabel As New Label
            Dim LabelText As String = ToDo.AtDateTime.ToString("ddd dd/MM/yyyy \a\t HH:mm") + ": " + ToDo.Description
            NewLabel.Text = LabelText
            NewLabel.Top = Top
            NewLabel.Left = 6
            NewLabel.AutoSize = True
            grp_todos.Controls.Add(NewLabel)
            Top = Top + 15
            Count = Count + 1
            If Count > 4 Then
                Exit For
            End If
        Next

        If grp_assignments.Controls.Count = 0 Then
            Dim NoneLabel As New Label With {
                .Text = "None",
                .Top = 20,
                .Left = 6,
                .AutoSize = True
            }
            NoneLabel.Font = New Font(NoneLabel.Font, FontStyle.Italic)
            grp_assignments.Controls.Add(NoneLabel)
        End If
        If grp_overdue.Controls.Count = 0 Then
            Dim NoneLabel As New Label With {
                .Text = "None",
                .Top = 20,
                .Left = 6,
                .AutoSize = True
            }
            NoneLabel.Font = New Font(NoneLabel.Font, FontStyle.Italic)
            grp_overdue.Controls.Add(NoneLabel)
        End If
        If grp_exams.Controls.Count = 0 Then
            Dim NoneLabel As New Label With {
                .Text = "None",
                .Top = 20,
                .Left = 6,
                .AutoSize = True
            }
            NoneLabel.Font = New Font(NoneLabel.Font, FontStyle.Italic)
            grp_exams.Controls.Add(NoneLabel)
        End If
        If grp_results.Controls.Count = 0 Then
            Dim NoneLabel As New Label With {
                .Text = "None",
                .Top = 20,
                .Left = 6,
                .AutoSize = True
            }
            NoneLabel.Font = New Font(NoneLabel.Font, FontStyle.Italic)
            grp_results.Controls.Add(NoneLabel)
        End If
        If grp_todos.Controls.Count = 0 Then
            Dim NoneLabel As New Label With {
                .Text = "None",
                .Top = 20,
                .Left = 6,
                .AutoSize = True
            }
            NoneLabel.Font = New Font(NoneLabel.Font, FontStyle.Italic)
            grp_todos.Controls.Add(NoneLabel)
        End If

    End Sub

    Private Sub btn_assignments_Click(sender As Object, e As EventArgs) Handles btn_assignments.Click
        Assignments.Show()
    End Sub

    Private Sub btn_exams_Click(sender As Object, e As EventArgs) Handles btn_exams.Click
        Exams.Show()
    End Sub

    Private Sub btn_results_Click(sender As Object, e As EventArgs) Handles btn_results.Click
        Results.Show()
    End Sub

    Private Sub btn_todos_Click(sender As Object, e As EventArgs) Handles btn_todos.Click
        ToDos.Show()
    End Sub

    Private Sub btn_settings_Click(sender As Object, e As EventArgs) Handles btn_settings.Click
        Settings.ShowDialog()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Landing_Load(sender, e)
    End Sub
End Class
