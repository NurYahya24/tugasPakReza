<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cetak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cetak))
        Me.lb_waktu = New System.Windows.Forms.Label()
        Me.TableDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbktpDataSet = New KTP_Yahya.dbktpDataSet()
        Me.TableDataTableAdapter = New KTP_Yahya.dbktpDataSetTableAdapters.TableDataTableAdapter()
        Me.TableAdapterManager = New KTP_Yahya.dbktpDataSetTableAdapters.TableAdapterManager()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbTglSah = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.BukaFile = New System.Windows.Forms.OpenFileDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.NikLabel1 = New System.Windows.Forms.Label()
        Me.NamaLabel1 = New System.Windows.Forms.Label()
        Me.Tempat_lahirLabel1 = New System.Windows.Forms.Label()
        Me.Tanggal_lahirLabel1 = New System.Windows.Forms.Label()
        Me.JenkelLabel1 = New System.Windows.Forms.Label()
        Me.AlamatLabel1 = New System.Windows.Forms.Label()
        Me.AgamaLabel1 = New System.Windows.Forms.Label()
        Me.StatusLabel1 = New System.Windows.Forms.Label()
        Me.PekerjaanLabel1 = New System.Windows.Forms.Label()
        Me.KewarganegaraanLabel1 = New System.Windows.Forms.Label()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.TableDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbktpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_waktu
        '
        Me.lb_waktu.AutoSize = True
        Me.lb_waktu.BackColor = System.Drawing.Color.Transparent
        Me.lb_waktu.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_waktu.ForeColor = System.Drawing.Color.White
        Me.lb_waktu.Location = New System.Drawing.Point(646, 18)
        Me.lb_waktu.Name = "lb_waktu"
        Me.lb_waktu.Size = New System.Drawing.Size(129, 17)
        Me.lb_waktu.TabIndex = 89
        Me.lb_waktu.Text = "lable_Waktu"
        '
        'TableDataBindingSource
        '
        Me.TableDataBindingSource.DataMember = "TableData"
        Me.TableDataBindingSource.DataSource = Me.DbktpDataSet
        '
        'DbktpDataSet
        '
        Me.DbktpDataSet.DataSetName = "dbktpDataSet"
        Me.DbktpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lbTglSah
        '
        Me.lbTglSah.AutoSize = True
        Me.lbTglSah.BackColor = System.Drawing.Color.Transparent
        Me.lbTglSah.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTglSah.Location = New System.Drawing.Point(655, 346)
        Me.lbTglSah.Name = "lbTglSah"
        Me.lbTglSah.Size = New System.Drawing.Size(74, 17)
        Me.lbTglSah.TabIndex = 86
        Me.lbTglSah.Text = "tglSah"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(653, 320)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(129, 17)
        Me.Label22.TabIndex = 85
        Me.Label22.Text = "KARTANEGARA"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(687, 295)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 17)
        Me.Label21.TabIndex = 84
        Me.Label21.Text = "KUTAI"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(221, 349)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 17)
        Me.Label20.TabIndex = 83
        Me.Label20.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(221, 323)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 17)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(221, 295)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 17)
        Me.Label18.TabIndex = 81
        Me.Label18.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(221, 267)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 17)
        Me.Label17.TabIndex = 80
        Me.Label17.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(221, 239)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 17)
        Me.Label16.TabIndex = 79
        Me.Label16.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(221, 212)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 17)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(221, 184)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 17)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(221, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 17)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("OCR A Extended", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(219, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 29)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(34, 349)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 17)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Kewarganegaraan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 323)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 17)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Pekerjaan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(195, 17)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Status Perkawinan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Agama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 17)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 17)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Tempat/Tgl Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 29)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "NIK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(472, 29)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "KABUPATEN KUTAI KARTANEGARA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(438, 29)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "PROVINSI KALIMANTAN TIMUR"
        '
        'BukaFile
        '
        Me.BukaFile.FileName = "OpenFileDialog1"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'NikLabel1
        '
        Me.NikLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableDataBindingSource, "nik", True))
        Me.NikLabel1.Location = New System.Drawing.Point(271, 124)
        Me.NikLabel1.Name = "NikLabel1"
        Me.NikLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NikLabel1.TabIndex = 90
        Me.NikLabel1.Text = "Label23"
        '
        'NamaLabel1
        '
        Me.NamaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableDataBindingSource, "nama", True))
        Me.NamaLabel1.Location = New System.Drawing.Point(271, 160)
        Me.NamaLabel1.Name = "NamaLabel1"
        Me.NamaLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NamaLabel1.TabIndex = 92
        Me.NamaLabel1.Text = "Label23"
        '
        'Tempat_lahirLabel1
        '
        Me.Tempat_lahirLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableDataBindingSource, "tempat_lahir", True))
        Me.Tempat_lahirLabel1.Location = New System.Drawing.Point(271, 187)
        Me.Tempat_lahirLabel1.Name = "Tempat_lahirLabel1"
        Me.Tempat_lahirLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Tempat_lahirLabel1.TabIndex = 94
        Me.Tempat_lahirLabel1.Text = "Label23"
        '
        'Tanggal_lahirLabel1
        '
        Me.Tanggal_lahirLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableDataBindingSource, "tanggal_lahir", True))
        Me.Tanggal_lahirLabel1.Location = New System.Drawing.Point(377, 187)
        Me.Tanggal_lahirLabel1.Name = "Tanggal_lahirLabel1"
        Me.Tanggal_lahirLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Tanggal_lahirLabel1.TabIndex = 96
        Me.Tanggal_lahirLabel1.Text = "Label23"
        '
        'JenkelLabel1
        '
        Me.JenkelLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableDataBindingSource, "jenkel", True))
        Me.JenkelLabel1.Location = New System.Drawing.Point(271, 215)
        Me.JenkelLabel1.Name = "JenkelLabel1"
        Me.JenkelLabel1.Size = New System.Drawing.Size(100, 23)
        Me.JenkelLabel1.TabIndex = 98
        Me.JenkelLabel1.Text = "Label23"
        '
        'AlamatLabel1
        '
        Me.AlamatLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableDataBindingSource, "alamat", True))
        Me.AlamatLabel1.Location = New System.Drawing.Point(271, 242)
        Me.AlamatLabel1.Name = "AlamatLabel1"
        Me.AlamatLabel1.Size = New System.Drawing.Size(100, 23)
        Me.AlamatLabel1.TabIndex = 100
        Me.AlamatLabel1.Text = "Label23"
        '
        'AgamaLabel1
        '
        Me.AgamaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableDataBindingSource, "agama", True))
        Me.AgamaLabel1.Location = New System.Drawing.Point(271, 270)
        Me.AgamaLabel1.Name = "AgamaLabel1"
        Me.AgamaLabel1.Size = New System.Drawing.Size(100, 23)
        Me.AgamaLabel1.TabIndex = 102
        Me.AgamaLabel1.Text = "Label23"
        '
        'StatusLabel1
        '
        Me.StatusLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableDataBindingSource, "status", True))
        Me.StatusLabel1.Location = New System.Drawing.Point(271, 298)
        Me.StatusLabel1.Name = "StatusLabel1"
        Me.StatusLabel1.Size = New System.Drawing.Size(100, 23)
        Me.StatusLabel1.TabIndex = 104
        Me.StatusLabel1.Text = "Label23"
        '
        'PekerjaanLabel1
        '
        Me.PekerjaanLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableDataBindingSource, "pekerjaan", True))
        Me.PekerjaanLabel1.Location = New System.Drawing.Point(271, 326)
        Me.PekerjaanLabel1.Name = "PekerjaanLabel1"
        Me.PekerjaanLabel1.Size = New System.Drawing.Size(100, 23)
        Me.PekerjaanLabel1.TabIndex = 106
        Me.PekerjaanLabel1.Text = "Label23"
        '
        'KewarganegaraanLabel1
        '
        Me.KewarganegaraanLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableDataBindingSource, "kewarganegaraan", True))
        Me.KewarganegaraanLabel1.Location = New System.Drawing.Point(271, 352)
        Me.KewarganegaraanLabel1.Name = "KewarganegaraanLabel1"
        Me.KewarganegaraanLabel1.Size = New System.Drawing.Size(100, 23)
        Me.KewarganegaraanLabel1.TabIndex = 108
        Me.KewarganegaraanLabel1.Text = "Label23"
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TableDataBindingSource, "foto", True))
        Me.FotoPictureBox.Location = New System.Drawing.Point(658, 140)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(117, 135)
        Me.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FotoPictureBox.TabIndex = 110
        Me.FotoPictureBox.TabStop = False
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.TableDataBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(802, 25)
        Me.BindingNavigator1.TabIndex = 111
        Me.BindingNavigator1.Text = "BindingNavigator1"
        Me.BindingNavigator1.Visible = False
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.btnPrev)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lb_waktu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 395)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 53)
        Me.Panel1.TabIndex = 112
        '
        'btnPrev
        '
        Me.btnPrev.FlatAppearance.BorderSize = 0
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Image = CType(resources.GetObject("btnPrev.Image"), System.Drawing.Image)
        Me.btnPrev.Location = New System.Drawing.Point(37, 9)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(46, 36)
        Me.btnPrev.TabIndex = 91
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Location = New System.Drawing.Point(95, 9)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(46, 36)
        Me.btnNext.TabIndex = 90
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(174, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cetak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 448)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.NikLabel1)
        Me.Controls.Add(Me.NamaLabel1)
        Me.Controls.Add(Me.Tempat_lahirLabel1)
        Me.Controls.Add(Me.Tanggal_lahirLabel1)
        Me.Controls.Add(Me.JenkelLabel1)
        Me.Controls.Add(Me.AlamatLabel1)
        Me.Controls.Add(Me.AgamaLabel1)
        Me.Controls.Add(Me.StatusLabel1)
        Me.Controls.Add(Me.PekerjaanLabel1)
        Me.Controls.Add(Me.KewarganegaraanLabel1)
        Me.Controls.Add(Me.FotoPictureBox)
        Me.Controls.Add(Me.lbTglSah)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cetak"
        Me.Text = "Cetak"
        CType(Me.TableDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbktpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_waktu As Label
    Friend WithEvents TableDataBindingSource As BindingSource
    Friend WithEvents DbktpDataSet As dbktpDataSet
    Friend WithEvents TableDataTableAdapter As dbktpDataSetTableAdapters.TableDataTableAdapter
    Friend WithEvents TableAdapterManager As dbktpDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbTglSah As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents BukaFile As OpenFileDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents NikLabel1 As Label
    Friend WithEvents NamaLabel1 As Label
    Friend WithEvents Tempat_lahirLabel1 As Label
    Friend WithEvents Tanggal_lahirLabel1 As Label
    Friend WithEvents JenkelLabel1 As Label
    Friend WithEvents AlamatLabel1 As Label
    Friend WithEvents AgamaLabel1 As Label
    Friend WithEvents StatusLabel1 As Label
    Friend WithEvents PekerjaanLabel1 As Label
    Friend WithEvents KewarganegaraanLabel1 As Label
    Friend WithEvents FotoPictureBox As PictureBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Button1 As Button
End Class
