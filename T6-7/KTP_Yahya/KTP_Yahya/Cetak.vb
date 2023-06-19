Imports System.Drawing.Printing
Imports System.Runtime.CompilerServices
Public Class Cetak

    Inherits Form

    Public Sub New()

        MyBase.New()

        InitializeComponent()


    End Sub
    Private Sub Cetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TableDataTableAdapter.Fill(Me.DbktpDataSet.TableData)

        AddHandler PrintDocument1.PrintPage, AddressOf Me.printDocument1_PrintPage
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1

    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)


        Dim f As Font = New Font("OCR A Extended", 14, FontStyle.Bold)
        Dim br As SolidBrush = New SolidBrush(Color.Black) 'br = adalah warna font
        Dim p As Pen = New Pen(Color.Black) 'p = adalah warna garis kotak
        Dim dt As DateTime = Convert.ToDateTime(Tanggal_lahirLabel1.Text)
        Dim format As String = "dd-MM-yyyy"
        Dim str As String = dt.ToString(format)

        e.Graphics.DrawImage(Form1.BackgroundImage, 50, 50, 720, 400)
        e.Graphics.DrawString("PROVINSI KALIMANTAN TIMUR", f, br, 250, 60)
        e.Graphics.DrawString("KABUPATEN KUTAI KARTANEGARA", f, br, 235, 80)
        e.Graphics.DrawString("NIK", f, br, 60, 120)
        e.Graphics.DrawString(": " + NikLabel1.Text, f, br, 275, 120)
        e.Graphics.DrawString("Nama", f, br, 60, 140)
        e.Graphics.DrawString(": " + NamaLabel1.Text, f, br, 275, 140)
        e.Graphics.DrawString("Tempat/Tgl Lahir", f, br, 60, 160)
        e.Graphics.DrawString(": " + Tempat_lahirLabel1.Text & "/" & str, f, br, 275, 160)
        e.Graphics.DrawString("Alamat", f, br, 60, 200)
        e.Graphics.DrawString(": " + AlamatLabel1.Text, f, br, 275, 200)
        e.Graphics.DrawString("Jenis Kelamin", f, br, 60, 180)
        e.Graphics.DrawString(": " + JenkelLabel1.Text, f, br, 275, 180)
        e.Graphics.DrawString("Agama", f, br, 60, 220)
        e.Graphics.DrawString(": " + AgamaLabel1.Text, f, br, 275, 220)
        e.Graphics.DrawString("Status Perkawinan", f, br, 60, 240)
        e.Graphics.DrawString(": " + StatusLabel1.Text, f, br, 275, 240)
        e.Graphics.DrawString("Pekerjaan", f, br, 60, 260)
        e.Graphics.DrawString(": " + PekerjaanLabel1.Text, f, br, 275, 260)
        e.Graphics.DrawString("Kewarganegaraan", f, br, 60, 280)
        e.Graphics.DrawString(": " + KewarganegaraanLabel1.Text, f, br, 275, 280)
        e.Graphics.DrawString("Berlaku Hingga", f, br, 60, 300)
        e.Graphics.DrawString(": SEUMUR HIDUP", f, br, 275, 300)
        e.Graphics.DrawRectangle(p, 50, 50, 720, 400)
        e.Graphics.DrawImage(FotoPictureBox.Image, 635, 130, 113, 127)
        e.Graphics.DrawString("KUTAI", f, br, 650, 270)
        e.Graphics.DrawString("KARTANEGARA", f, br, 615, 290)
        e.Graphics.DrawString(lbTglSah.Text, f, br, 617, 310)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbTglSah.Text = DateTime.Now.ToString("dd-MM-yyyy")
        lb_waktu.Text = DateTime.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.BindingNavigatorMoveNextItem1.PerformClick()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Me.BindingNavigatorMovePreviousItem1.PerformClick()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FotoPictureBox.Image Is Nothing Then
            MessageBox.Show("Data Tidak Lengkap")
        Else
            Me.PrintPreviewDialog1.ShowDialog()
        End If

    End Sub
End Class