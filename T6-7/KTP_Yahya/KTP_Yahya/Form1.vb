Imports System.Drawing.Printing
Imports System.IO
Imports System.Runtime.CompilerServices

Public Class Form1


    Inherits Form

    Public Sub New()

        MyBase.New()

        InitializeComponent()


    End Sub

    Public Property tambah As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbktpDataSet.TableData' table. You can move, or remove it, as needed.
        Me.TableDataTableAdapter.Fill(Me.DbktpDataSet.TableData)
        'dtpLahir.Format = DateTimePickerFormat.Custom
        'dtpLahir.CustomFormat = "dd-MM-yyyy"
        'txtNIK.Focus()

        If tambah Then
            Me.BindingNavigatorAddNewItem.PerformClick()
            Me.Tanggal_lahirDateTimePicker.CustomFormat = " "
        End If

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbTglSah.Text = DateTime.Now.ToString("dd-MM-yyyy")
        lb_waktu.Text = DateTime.Now.ToString("hh:mm:ss")
    End Sub




    Private Sub TableDataBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableDataBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableDataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbktpDataSet)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim kondisi As Boolean = True
        If NikTextBox.Text = "" Then
            kondisi = False
        ElseIf NamaTextBox.Text = "" Then
            kondisi = False
        ElseIf Tempat_lahirTextBox.Text = "" Then
            kondisi = False
        ElseIf Tanggal_lahirDateTimePicker.CustomFormat = " " Then
            kondisi = False
        ElseIf JenkelComboBox.SelectedIndex < 1 Then
            kondisi = False
        ElseIf AlamatTextBox.Text = "" Then
            kondisi = False
        ElseIf AgamaComboBox.SelectedIndex < 1 Then
            kondisi = False
        ElseIf StatusComboBox.SelectedIndex < 1 Then
            kondisi = False
        ElseIf PekerjaanTextBox.Text = "" Then
            kondisi = False
        ElseIf KewarganegaraanComboBox.SelectedIndex < 1 Then
            kondisi = False
        ElseIf FotoPictureBox.Image Is Nothing Then
            kondisi = False
        End If
        If kondisi Then
            Me.TableDataBindingNavigatorSaveItem.PerformClick()
            MenuAwal.btnData.PerformClick()
        Else
            MessageBox.Show("DATA BELUM LENGKAP")
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Dispose()
        MenuAwal.btnData.PerformClick()
    End Sub

    Private Sub FotoPictureBox_Click(sender As Object, e As EventArgs) Handles FotoPictureBox.Click
        BukaFile.Filter = "Picture files(*.jpg, *.png)|*.jpg;*.png|All files(*.*)|*.*"
        BukaFile.ShowDialog()
        FotoPictureBox.ImageLocation = BukaFile.FileName
    End Sub

    Private Sub Tanggal_lahirDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Tanggal_lahirDateTimePicker.ValueChanged
        Me.Tanggal_lahirDateTimePicker.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub NikTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NikTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
