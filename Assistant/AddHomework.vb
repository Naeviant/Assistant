Public Class AddHomework
    Private Sub AddHomework_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssistantDS.SubjectsTable' table. You can move, or remove it, as needed.
        Me.SubjectsTableTableAdapter1.Fill(Me.AssistantDS.SubjectsTable)

        com_subject.Text = ""
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If com_subject.Text = "" Or com_priority.Text = "" Or com_status.Text = "" Or num_completion.Value > 100 Or num_completion.Value < 0 Or (txt_set.Text = "" And chk_set.Checked = True) Or (txt_due.Text = "" And chk_due.Checked = True) Or txt_description.Text = "" Then
            MessageBox.Show("You have not completed a field. Please make sure all fields have been completed before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            For Each f In My.Application.OpenForms
                If f.Name = "MainMenu" Then
                    Dim fcast As New MainMenu
                    Dim setdate As String
                    Dim duedate As String
                    If chk_set.Checked = False Then
                        setdate = Nothing
                    Else
                        setdate = date_set.Value.ToString("dd MMMM yyyy")
                    End If
                    If chk_due.Checked = False Then
                        duedate = Nothing
                    Else
                        duedate = date_due.Value.ToString("dd MMMM yyyy")
                    End If
                    fcast = f
                    fcast.HomeworkTableBindingSource.EndEdit()
                    fcast.HomeworkTableTableAdapter.InsertNew(com_subject.Text, setdate, txt_set.Text, duedate, txt_due.Text, com_priority.Text, com_status.Text, num_completion.Text, txt_description.Text, txt_notes.Text, chk_project.Checked)
                    fcast.HomeworkTableTableAdapter.Fill(fcast.AssistantDS.HomeworkTable)
                    com_subject.Text = ""
                    com_priority.Text = ""
                    com_status.Text = ""
                    num_completion.Value = 0
                    chk_set.Checked = True
                    date_set.Value = Now
                    date_set.Enabled = True
                    txt_set.Text = ""
                    txt_set.Enabled = True
                    chk_due.Checked = True
                    date_due.Value = Now
                    date_due.Enabled = True
                    txt_due.Text = ""
                    txt_due.Enabled = True
                    txt_description.Text = ""
                    txt_notes.Text = ""
                    chk_project.Checked = False
                    MessageBox.Show("The record was added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Next
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        com_subject.Text = ""
        com_priority.Text = ""
        com_status.Text = ""
        num_completion.Value = 0
        chk_set.Checked = True
        date_set.Value = Now
        date_set.Enabled = True
        txt_set.Text = ""
        txt_set.Enabled = True
        chk_due.Checked = True
        date_due.Value = Now
        date_due.Enabled = True
        txt_due.Text = ""
        txt_due.Enabled = True
        txt_description.Text = ""
        txt_notes.Text = ""
        chk_project.Checked = False
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub chk_set_CheckedChanged(sender As Object, e As EventArgs) Handles chk_set.CheckedChanged
        If chk_set.Checked = False Then
            date_set.Enabled = False
            txt_set.Enabled = False
            txt_set.Text = ""
        Else
            date_set.Enabled = True
            txt_set.Enabled = True
        End If
    End Sub

    Private Sub chk_due_CheckedChanged(sender As Object, e As EventArgs) Handles chk_due.CheckedChanged
        If chk_due.Checked = False Then
            date_due.Enabled = False
            txt_due.Enabled = False
            txt_due.Text = ""
        Else
            date_due.Enabled = True
            txt_due.Enabled = True
        End If
    End Sub
End Class