Public Class input
    Private Sub input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbktpDataSet.TableData' table. You can move, or remove it, as needed.
        Me.TableDataTableAdapter.Fill(Me.DbktpDataSet.TableData)

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Form1.Dispose()
        Form1.tambah = False
        MenuAwal.btnAdd.PerformClick()
        Dim idx As Integer = TableDataDataGridView.CurrentRow.Index
        While idx > 0
            Form1.BindingNavigatorMoveNextItem.PerformClick()
            idx -= 1
        End While

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Form1.Dispose()
        Form1.tambah = False
        Form1.Opacity = 0%
        Form1.Show()
        Dim idx As Integer = TableDataDataGridView.CurrentRow.Index
        While idx > 0
            Form1.BindingNavigatorMoveNextItem.PerformClick()
            idx -= 1
        End While
        Form1.BindingNavigatorDeleteItem.PerformClick()
        Form1.btnSimpan.PerformClick()
    End Sub
End Class