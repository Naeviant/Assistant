Public Class ToDosFilter
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        Dim ToDoDate
        If date_datetime.Checked = True Then
            ToDoDate = date_datetime.Value.Date.Add(New TimeSpan(0, 0, 0))
        Else
            ToDoDate = Nothing
        End If
        ToDos.data_todos.Rows.Clear()
        Dim ToDoResults = ToDosTableAdapter.Sort(date_datetime.Value)
        For Each ToDo In ToDoResults
            Dim Sortable As DateTime = New Date(ToDo.AtDateTime.Year, ToDo.AtDateTime.Month, ToDo.AtDateTime.Day, ToDo.AtDateTime.Hour, ToDo.AtDateTime.Minute, 0)
            ToDos.data_todos.Rows.Add(ToDo.ID, ToDo.AtDateTime.ToString("ddd dd/MM/yyyy HH:mm"), ToDo.Description, Sortable)
        Next
        ToDos.btn_filtertodos.Visible = False
        ToDos.btn_unfiltertodos.Visible = True
        If ToDos.data_todos.Rows.Count = 0 Then
            ToDos.btn_edittodo.Enabled = False
            ToDos.btn_deletetodo.Enabled = False
        Else
            ToDos.btn_edittodo.Enabled = True
            ToDos.btn_deletetodo.Enabled = True
        End If
        ToDos.data_todos.Sort(ToDos.data_todos.Columns.Item(3), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub ToDosFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        date_datetime.Checked = False
    End Sub
End Class