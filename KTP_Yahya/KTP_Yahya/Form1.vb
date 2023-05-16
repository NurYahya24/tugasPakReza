Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices

Public Class Form1

    Inherits Form
    Dim jenkel, status, agama As String
    Dim kondisi As Boolean

    Public Sub New()

        MyBase.New()

        InitializeComponent()


    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler PrintDocument1.PrintPage, AddressOf Me.printDocument1_PrintPage
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        dtpLahir.Format = DateTimePickerFormat.Custom
        dtpLahir.CustomFormat = "dd-MM-yyyy"
        txtNIK.Focus()
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim opa As Integer
        For opa = 0 To 10000
            Me.Opacity = Me.Opacity - 0.0001
        Next
        If Me.Opacity = 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub pbFotoKtp_Click(sender As Object, e As EventArgs) Handles pbFotoKtp.Click
        BukaFile.Filter = "Picture files(*.jpg, *.png)|*.jpg;*.png|All files(*.*)|*.*"
        BukaFile.ShowDialog()
        pbFotoKtp.ImageLocation = BukaFile.FileName
    End Sub


    Private Sub txtNIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIK.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = Chr(13) Then
            txtNama.Focus()
        End If
    End Sub


    Private Sub printDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)


        Dim f As Font = New Font("OCR A Extended", 14, FontStyle.Bold)
        Dim br As SolidBrush = New SolidBrush(Color.Black) 'br = adalah warna font
        Dim p As Pen = New Pen(Color.Black) 'p = adalah warna garis kotak


        e.Graphics.DrawString("PROVINSI KALIMANTAN TIMUR", f, br, 250, 60)
        e.Graphics.DrawString("KABUPATEN KUTAI KARTANEGARA", f, br, 230, 80)
        e.Graphics.DrawString("NIK               : " + txtNIK.Text, f, br, 60, 120)
        e.Graphics.DrawString("Nama              : " + txtNama.Text, f, br, 60, 140)
        e.Graphics.DrawString("Tempat/Tgl Lahir  : " + txtTempat.Text & "/" & dtpLahir.Text, f, br, 60, 160)
        e.Graphics.DrawString("Alamat            : " + txtAlamat.Text, f, br, 60, 200)
        e.Graphics.DrawString("Jenis Kelamin     : " + jenkel, f, br, 60, 180)
        e.Graphics.DrawString("Agama             : " + agama, f, br, 60, 220)
        e.Graphics.DrawString("Status Perkawinan : " + status, f, br, 60, 240)
        e.Graphics.DrawString("Pekerjaan         : " + txtJob.Text, f, br, 60, 260)
        e.Graphics.DrawString("Kewarganegaraan   : " + txtWni.Text, f, br, 60, 280)
        e.Graphics.DrawString("Berlaku Hingga    : " + "SEUMUR HIDUP", f, br, 60, 300)
        e.Graphics.DrawRectangle(p, 50, 50, 720, 400)
        e.Graphics.DrawImage(pbFotoKtp.Image, 635, 130, 100, 140)
        e.Graphics.DrawString("KUTAI", f, br, 650, 270)
        e.Graphics.DrawString("KARTANEGARA", f, br, 615, 290)
        e.Graphics.DrawString(lbTglSah.Text, f, br, 617, 310)

    End Sub
    Sub cekdata()
        If txtNIK.Text = "" Then
            kondisi = False
        ElseIf txtNama.Text = "" Then
            kondisi = False
        ElseIf txtTempat.Text = "" Then
            kondisi = False
        ElseIf jenkel = "" Then
            kondisi = False
        ElseIf txtAlamat.Text = "" Then
            kondisi = False
        ElseIf cbAgama.SelectedIndex = -1 Then
            kondisi = False
        ElseIf cbKawin.SelectedIndex = -1 Then
            kondisi = False
        ElseIf txtJob.Text = "" Then
            kondisi = False
        ElseIf txtWni.Text = "" Then
            kondisi = False
        ElseIf pbFotoKtp.Image Is Nothing Then
            kondisi = False
        End If
    End Sub
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        kondisi = True
        If rbLaki.Checked Then
            jenkel = "Laki-laki"
        ElseIf rbBini.Checked Then
            jenkel = "Perempuan"
        End If
        If cbAgama.SelectedIndex > -1 Then
            agama = cbAgama.SelectedItem.ToString
        End If
        If cbKawin.SelectedIndex > -1 Then
            status = cbKawin.SelectedItem.ToString
        End If
        Call cekdata()
        If kondisi = False Then
            MsgBox("DATA BELUM LENGKAP !!")
            Exit Sub
        End If
        Me.PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtNIK.Focus()
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            txtTempat.Focus()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbTglSah.Text = DateTime.Now.ToString("dd-MM-yyyy")
        lb_waktu.Text = DateTime.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub txtTempat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTempat.KeyPress
        If e.KeyChar = Chr(13) Then
            rbLaki.Focus()
        End If
    End Sub



    Private Sub txtAlamat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlamat.KeyPress
        If e.KeyChar = Chr(13) Then
            cbAgama.Focus()
        End If
    End Sub

    Private Sub txtNama_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNama.KeyDown
        If e.KeyCode = Keys.Down Then
            txtTempat.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtNIK.Focus()
        End If
    End Sub

    Private Sub txtNIK_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNIK.KeyDown
        If e.KeyCode = Keys.Down Then
            txtNama.Focus()
        End If
    End Sub

    Private Sub txtTempat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTempat.KeyDown
        If e.KeyCode = Keys.Down Then
            rbLaki.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtNama.Focus()
        End If
    End Sub

    Private Sub dtpLahir_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpLahir.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAlamat.Focus()
        End If
    End Sub

    Private Sub txtAlamat_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAlamat.KeyDown
        If e.KeyCode = Keys.Down Then
            cbAgama.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            dtpLahir.Focus()
        End If
    End Sub

    Private Sub cbAgama_KeyDown(sender As Object, e As KeyEventArgs) Handles cbAgama.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbKawin.Focus()
        End If
    End Sub

    Private Sub cbKawin_KeyDown(sender As Object, e As KeyEventArgs) Handles cbKawin.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtJob.Focus()
        End If
    End Sub

    Private Sub txtJob_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJob.KeyDown
        If e.KeyCode = Keys.Down Then
            txtWni.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            cbKawin.Focus()
        End If
    End Sub

    Private Sub txtWni_KeyDown(sender As Object, e As KeyEventArgs) Handles txtWni.KeyDown
        If e.KeyCode = Keys.Down Then
            btnCetak.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            txtJob.Focus()
        End If
    End Sub
End Class
