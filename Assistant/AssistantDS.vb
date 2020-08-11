Partial Class AssistantDS
    Partial Public Class SubjectsTableDataTable
        Private Sub SubjectsTableDataTable_SubjectsTableRowChanging(sender As Object, e As SubjectsTableRowChangeEvent) Handles Me.SubjectsTableRowChanging

        End Sub

    End Class

    Partial Public Class HomeworkTableDataTable
        Private Sub HomeworkTableDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Due_PeriodColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class EventsTableDataTable
    End Class
End Class

Namespace AssistantDSTableAdapters
    Partial Public Class LettersTableTableAdapter
    End Class

    Partial Public Class HomeworkTableTableAdapter
    End Class

    Partial Public Class BooksTableTableAdapter
    End Class
End Namespace
