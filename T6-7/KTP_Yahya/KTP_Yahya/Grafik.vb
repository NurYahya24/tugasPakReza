Imports System.Windows.Forms.DataVisualization.Charting

Public Class Grafik
    Private Sub TableDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbktpDataSet)

    End Sub

    Private Sub Grafik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbktpDataSet.TableData' table. You can move, or remove it, as needed.


    End Sub

    Sub fillChart()
        Dim dataumur As New DataTable
        dataumur.Columns.Add("Range", GetType(String))
        dataumur.Columns.Add("jumlah", GetType(Integer))
        dataumur.Rows.Add("18-25", Me.TableDataTableAdapter1.umur18_25())
        dataumur.Rows.Add("26-30", Me.TableDataTableAdapter1.umur26_30())
        dataumur.Rows.Add(">30", Me.TableDataTableAdapter1.umurLebih30())

        umurChart.Series("Umur").ChartType = DataVisualization.Charting.SeriesChartType.Column
        umurChart.Series("Umur").Points.Clear()

        For hitung As Integer = 0 To dataumur.Rows.Count - 1
            umurChart.Series("Umur").Points.AddXY(dataumur.Rows(hitung).Field(Of String)(0), dataumur.Rows(hitung).Field(Of Integer)(1))

        Next

        umurChart.ChartAreas("ChartArea1").AxisX.Title = "Umur"
        umurChart.ChartAreas("ChartArea1").AxisY.Title = "Jumlah"
    End Sub

End Class