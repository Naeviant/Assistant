Imports Excel = Microsoft.Office.Interop.Excel

Public Class ToDos
    Public Sub Reload_Table(sender As Object, e As EventArgs)
        data_todos.Rows.Clear()
        Dim ToDos = ToDosTableAdapter.GetData()
        For Each ToDo In ToDos
            Dim Sortable As DateTime = New Date(ToDo.AtDateTime.Year, ToDo.AtDateTime.Month, ToDo.AtDateTime.Day, ToDo.AtDateTime.Hour, ToDo.AtDateTime.Minute, 0)
            data_todos.Rows.Add(ToDo.ID, ToDo.AtDateTime.ToString("ddd dd/MM/yyyy HH:mm"), ToDo.Description, Sortable)
        Next
        If data_todos.Rows.Count = 0 Then
            btn_edittodo.Enabled = False
            btn_deletetodo.Enabled = False
        Else
            btn_edittodo.Enabled = True
            btn_deletetodo.Enabled = True
        End If
        btn_filtertodos.Visible = True
        btn_unfiltertodos.Visible = False
        data_todos.Sort(data_todos.Columns.Item(3), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub ToDos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_todos.ColumnCount = 4
        data_todos.Columns(0).Name = "ID"
        data_todos.Columns(0).Visible = False
        data_todos.Columns(1).Name = "Date & Time"
        data_todos.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        data_todos.Columns(1).Width = 250
        data_todos.Columns(2).Name = "Description"
        data_todos.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        data_todos.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        data_todos.Columns(3).Name = "Sortable"
        data_todos.Columns(3).Visible = False
        Reload_Table(sender, e)
    End Sub

    Private Sub btn_addtodo_Click(sender As Object, e As EventArgs) Handles btn_addtodo.Click
        ToDosEdit.date_datetime.Value = Today.AddDays(1).Add(New TimeSpan(9, 0, 0))
        ToDosEdit.txt_description.Text = ""
        ToDosEdit.lbl_id.Text = "None"
        ToDosEdit.Show()
    End Sub

    Private Sub btn_edittodo_Click(sender As Object, e As EventArgs) Handles btn_edittodo.Click
        ToDosEdit.lbl_id.Text = data_todos.CurrentRow.Cells(0).Value
        ToDosEdit.date_datetime.Text = data_todos.CurrentRow.Cells(1).Value
        ToDosEdit.txt_description.Text = data_todos.CurrentRow.Cells(2).Value
        ToDosEdit.ShowDialog()
    End Sub

    Private Sub btn_deletetodo_Click(sender As Object, e As EventArgs) Handles btn_deletetodo.Click
        Dim Selected = data_todos.CurrentRow.Cells(0).Value
        Dim Result = MessageBox.Show("Are you sure you want to delete this todo?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Result = DialogResult.Yes Then
            ToDosTableAdapter.DeleteByID(Selected)
            Reload_Table(sender, e)
        End If
    End Sub

    Private Sub btn_filtertodos_Click(sender As Object, e As EventArgs) Handles btn_filtertodos.Click
        ToDosFilter.date_datetime.Value = Today.AddDays(1).Add(New TimeSpan(9, 0, 0))
        ToDosFilter.date_datetime.Checked = False
        ToDosFilter.ShowDialog()
    End Sub

    Private Sub btn_unfiltertodos_Click(sender As Object, e As EventArgs) Handles btn_unfiltertodos.Click
        Reload_Table(sender, e)
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Cursor = Cursors.WaitCursor
        Dim ExcelApplication As Excel.Application
        ExcelApplication = CreateObject("Excel.Application")
        ExcelApplication.WindowState = Excel.XlWindowState.xlMaximized

        Dim Workbook As Excel.Workbook
        Workbook = ExcelApplication.Workbooks.Add()

        Dim Sheet As Excel.Worksheet
        Sheet = Workbook.ActiveSheet

        Sheet.Name = "ToDos"

        Sheet.Cells(1, 1).Value = "Date & Time"
        Sheet.Cells(1, 2).Value = "Description"

        With Sheet.Range("A1", "B1")
            .Font.Bold = True
        End With

        Sheet.Cells(1, 1).ColumnWidth = 16
        Sheet.Cells(1, 2).ColumnWidth = 100

        Dim ToDos = ToDosTableAdapter.GetData()
        Dim i = 2
        For Each ToDo In ToDos
            Sheet.Cells(i, 1).Value = ToDo.AtDateTime
            Sheet.Cells(i, 1).HorizontalAlignment = HorizontalAlignment.Center
            Sheet.Cells(i, 2).Value = ToDo.Description
            i += 1
        Next

        ExcelApplication.Visible = True
        ExcelApplication.UserControl = True

        Cursor = Cursors.Default
    End Sub
End Class