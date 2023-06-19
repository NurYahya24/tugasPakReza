<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grafik
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.umurChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TableDataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbktpDataSet = New KTP_Yahya.dbktpDataSet()
        Me.TableDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableDataTableAdapter1 = New KTP_Yahya.dbktpDataSetTableAdapters.TableDataTableAdapter()
        CType(Me.umurChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableDataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbktpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'umurChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.umurChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.umurChart.Legends.Add(Legend1)
        Me.umurChart.Location = New System.Drawing.Point(211, 12)
        Me.umurChart.Name = "umurChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Umur"
        Me.umurChart.Series.Add(Series1)
        Me.umurChart.Size = New System.Drawing.Size(405, 358)
        Me.umurChart.TabIndex = 0
        Me.umurChart.Text = "umurChart"
        '
        'TableDataBindingSource1
        '
        Me.TableDataBindingSource1.DataMember = "TableData"
        Me.TableDataBindingSource1.DataSource = Me.DbktpDataSet
        '
        'DbktpDataSet
        '
        Me.DbktpDataSet.DataSetName = "dbktpDataSet"
        Me.DbktpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableDataBindingSource
        '
        Me.TableDataBindingSource.DataMember = "TableData"
        Me.TableDataBindingSource.DataSource = Me.DbktpDataSet
        '
        'TableDataTableAdapter1
        '
        Me.TableDataTableAdapter1.ClearBeforeFill = True
        '
        'Grafik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.umurChart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Grafik"
        Me.Text = "Grafik"
        CType(Me.umurChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableDataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbktpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents umurChart As DataVisualization.Charting.Chart
    Friend WithEvents DbktpDataSet As dbktpDataSet
    Friend WithEvents TableDataBindingSource As BindingSource
    Friend WithEvents TableDataTableAdapter As dbktpDataSetTableAdapters.TableDataTableAdapter
    Friend WithEvents TableAdapterManager As dbktpDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableDataBindingSource1 As BindingSource
    Friend WithEvents TableDataTableAdapter1 As dbktpDataSetTableAdapters.TableDataTableAdapter
End Class
