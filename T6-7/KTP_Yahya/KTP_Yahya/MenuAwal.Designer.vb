<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuAwal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAwal))
        Me.pnSideBar = New System.Windows.Forms.Panel()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnGrafik = New System.Windows.Forms.Button()
        Me.btnData = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnTopBar = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnCanvas = New System.Windows.Forms.Panel()
        Me.DbktpDataSet = New KTP_Yahya.dbktpDataSet()
        Me.TableDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableDataTableAdapter = New KTP_Yahya.dbktpDataSetTableAdapters.TableDataTableAdapter()
        Me.TableAdapterManager = New KTP_Yahya.dbktpDataSetTableAdapters.TableAdapterManager()
        Me.TableDataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TableDataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.pnSideBar.SuspendLayout()
        Me.pnTopBar.SuspendLayout()
        CType(Me.DbktpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableDataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableDataBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnSideBar
        '
        Me.pnSideBar.BackColor = System.Drawing.Color.White
        Me.pnSideBar.Controls.Add(Me.btnCetak)
        Me.pnSideBar.Controls.Add(Me.btnExit)
        Me.pnSideBar.Controls.Add(Me.btnGrafik)
        Me.pnSideBar.Controls.Add(Me.btnData)
        Me.pnSideBar.Controls.Add(Me.Panel1)
        Me.pnSideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnSideBar.Location = New System.Drawing.Point(0, 0)
        Me.pnSideBar.Name = "pnSideBar"
        Me.pnSideBar.Size = New System.Drawing.Size(200, 500)
        Me.pnSideBar.TabIndex = 0
        '
        'btnCetak
        '
        Me.btnCetak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCetak.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCetak.FlatAppearance.BorderSize = 0
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.Image = CType(resources.GetObject("btnCetak.Image"), System.Drawing.Image)
        Me.btnCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCetak.Location = New System.Drawing.Point(0, 172)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnCetak.Size = New System.Drawing.Size(200, 46)
        Me.btnCetak.TabIndex = 6
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(0, 454)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnExit.Size = New System.Drawing.Size(200, 46)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Keluar"
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnGrafik
        '
        Me.btnGrafik.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGrafik.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGrafik.FlatAppearance.BorderSize = 0
        Me.btnGrafik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrafik.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrafik.Image = CType(resources.GetObject("btnGrafik.Image"), System.Drawing.Image)
        Me.btnGrafik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrafik.Location = New System.Drawing.Point(0, 126)
        Me.btnGrafik.Name = "btnGrafik"
        Me.btnGrafik.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnGrafik.Size = New System.Drawing.Size(200, 46)
        Me.btnGrafik.TabIndex = 4
        Me.btnGrafik.Text = "Grafik"
        Me.btnGrafik.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGrafik.UseVisualStyleBackColor = True
        '
        'btnData
        '
        Me.btnData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnData.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnData.FlatAppearance.BorderSize = 0
        Me.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnData.Image = CType(resources.GetObject("btnData.Image"), System.Drawing.Image)
        Me.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnData.Location = New System.Drawing.Point(0, 80)
        Me.btnData.Name = "btnData"
        Me.btnData.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnData.Size = New System.Drawing.Size(200, 46)
        Me.btnData.TabIndex = 1
        Me.btnData.Text = "Data"
        Me.btnData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnData.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 80)
        Me.Panel1.TabIndex = 0
        '
        'pnTopBar
        '
        Me.pnTopBar.BackColor = System.Drawing.Color.White
        Me.pnTopBar.Controls.Add(Me.btnAdd)
        Me.pnTopBar.Controls.Add(Me.Panel2)
        Me.pnTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTopBar.Location = New System.Drawing.Point(200, 0)
        Me.pnTopBar.Name = "pnTopBar"
        Me.pnTopBar.Size = New System.Drawing.Size(800, 50)
        Me.pnTopBar.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(538, 0)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 50)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Tambah"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(651, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(149, 50)
        Me.Panel2.TabIndex = 0
        '
        'pnCanvas
        '
        Me.pnCanvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnCanvas.Location = New System.Drawing.Point(200, 50)
        Me.pnCanvas.Name = "pnCanvas"
        Me.pnCanvas.Size = New System.Drawing.Size(800, 450)
        Me.pnCanvas.TabIndex = 2
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
        'TableDataTableAdapter
        '
        Me.TableDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TableDataTableAdapter = Me.TableDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = KTP_Yahya.dbktpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableDataBindingNavigator
        '
        Me.TableDataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TableDataBindingNavigator.BindingSource = Me.TableDataBindingSource
        Me.TableDataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TableDataBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TableDataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TableDataBindingNavigatorSaveItem})
        Me.TableDataBindingNavigator.Location = New System.Drawing.Point(200, 50)
        Me.TableDataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TableDataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TableDataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TableDataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TableDataBindingNavigator.Name = "TableDataBindingNavigator"
        Me.TableDataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TableDataBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.TableDataBindingNavigator.TabIndex = 3
        Me.TableDataBindingNavigator.Text = "BindingNavigator1"
        Me.TableDataBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TableDataBindingNavigatorSaveItem
        '
        Me.TableDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TableDataBindingNavigatorSaveItem.Image = CType(resources.GetObject("TableDataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TableDataBindingNavigatorSaveItem.Name = "TableDataBindingNavigatorSaveItem"
        Me.TableDataBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TableDataBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MenuAwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.Controls.Add(Me.TableDataBindingNavigator)
        Me.Controls.Add(Me.pnCanvas)
        Me.Controls.Add(Me.pnTopBar)
        Me.Controls.Add(Me.pnSideBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuAwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.pnSideBar.ResumeLayout(False)
        Me.pnTopBar.ResumeLayout(False)
        CType(Me.DbktpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableDataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableDataBindingNavigator.ResumeLayout(False)
        Me.TableDataBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnSideBar As Panel
    Friend WithEvents pnTopBar As Panel
    Friend WithEvents pnCanvas As Panel
    Friend WithEvents btnData As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGrafik As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DbktpDataSet As dbktpDataSet
    Friend WithEvents TableDataBindingSource As BindingSource
    Friend WithEvents TableDataTableAdapter As dbktpDataSetTableAdapters.TableDataTableAdapter
    Friend WithEvents TableAdapterManager As dbktpDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableDataBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TableDataBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents btnCetak As Button
End Class
