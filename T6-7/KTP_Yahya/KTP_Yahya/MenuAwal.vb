Public Class MenuAwal
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        pnCanvas.Controls.Clear()
        btnAdd.Visible = False
        With Form1
            .TopLevel = False
            pnCanvas.Controls.Add(Form1)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnData_Click(sender As Object, e As EventArgs) Handles btnData.Click
        input.Dispose()
        Form1.Dispose()
        Cetak.Dispose()
        pnCanvas.Controls.Clear()
        btnAdd.Visible = True
        btnData.BackColor = Color.Gray
        btnGrafik.BackColor = Color.White
        btnCetak.BackColor = Color.White
        With input
            .TopLevel = False
            pnCanvas.Controls.Add(input)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnGrafik_Click(sender As Object, e As EventArgs) Handles btnGrafik.Click
        pnCanvas.Controls.Clear()
        btnAdd.Visible = False
        btnData.BackColor = Color.White
        btnGrafik.BackColor = Color.Gray
        btnCetak.BackColor = Color.White
        With Grafik
            .TopLevel = False
            pnCanvas.Controls.Add(Grafik)
            .BringToFront()
            .Show()
        End With
        Grafik.fillChart()
    End Sub

    Private Sub TableDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableDataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbktpDataSet)

    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbktpDataSet.TableData' table. You can move, or remove it, as needed.
        Me.TableDataTableAdapter.Fill(Me.DbktpDataSet.TableData)
        btnData.PerformClick()
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        pnCanvas.Controls.Clear()
        btnAdd.Visible = False
        btnData.BackColor = Color.White
        btnGrafik.BackColor = Color.White
        btnCetak.BackColor = Color.Gray
        With Cetak
            .TopLevel = False
            pnCanvas.Controls.Add(Cetak)
            .BringToFront()
            .Show()
        End With
    End Sub

End Class