Imports System.Data.Odbc
Imports System.Data.SqlClient

Public Class Form2

    Dim conn As OdbcConnection
    Dim da As OdbcDataAdapter
    Dim dr As OdbcDataReader
    Dim cmd As OdbcCommand
    Dim ds As DataSet

    Sub koneksi()
        conn = New OdbcConnection("dsn=db_cu_fixx;database=dummy_kasir;id=root")
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                'MsgBox("Koneksi Berhasil")
            End If
        Catch ex As Exception
            MsgBox("Koneksi Gagal..." & ex.Message)
        End Try
    End Sub

    Public Sub tampilData()
        Try
            da = New OdbcDataAdapter("SELECT * FROM tbl_penjualan", conn)
            ds = New DataSet
            da.Fill(ds, "tbl_penjualan")
            dgvdata.DataSource = ds.Tables("tbl_penjualan")

        Catch ex As Exception
            MsgBox("Error saat menampilkan data : " & ex.Message, MsgBoxStyle.Exclamation, "Peringatan")

        End Try
    End Sub

    Sub hapusPenjualan()
        Try
            Call koneksi()
            Dim selected_id As String

            If dgvdata.SelectedRows.Count > 0 Then
                selected_id = dgvdata.SelectedRows(0).Cells("faktur_penjualan").Value
            Else
                MessageBox.Show("Pilih baris data terlebih dahulu")
                Return
            End If

            Dim query As String = "DELETE FROM tbl_penjualan WHERE faktur_penjualan = ?"

            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("faktur_penjualan", selected_id)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Data berhasil dihapus")
                tampilData()

            Else
                MessageBox.Show("Data gagal dihapus")

            End If

        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)

        Finally
            conn.Close()

        End Try
    End Sub

    Sub simpanPenjualan()
        Dim noFaktur = txtfaktur.Text
        Dim tgl = txttanggal.Text
        Dim kodePelanggan = txtnamapembeli.Text
        Dim totalPembelian = txttotal.Text
        Dim query As String = "INSERT INTO tbl_penjualan (faktur_penjualan, kode_pelanggan, total) VALUES (?, ?, ?)"

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("?", noFaktur)
            cmd.Parameters.AddWithValue("?", kodePelanggan)
            cmd.Parameters.AddWithValue("?", totalPembelian)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil ditambahkan ke dalam tabel")
            tampilData()


        Catch ex As Exception
            MsgBox("Kesalahan saat menyimpan data: " & ex.Message)

        End Try
    End Sub

    Sub clear()
        txtnamapembeli.Text = ""
        cbomakanan.SelectedItem = -1
        txtfaktur.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        txttotal.Text = ""
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                DirectCast(ctr, TextBox).Text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            End If
        Next
    End Sub

    Sub isicombo()
        Try
            Dim query As String = "SELECT nama_barang FROM tblbarang"
            cmd = New OdbcCommand(query, conn)
            dr = cmd.ExecuteReader()
            cbomakanan.Items.Clear()
            While dr.Read
                cbomakanan.Items.Add(dr("nama_barang").ToString())
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error..." & ex.Message)
        End Try
    End Sub

    Sub invoice()
        ds.Clear()
        da = New OdbcDataAdapter("SELECT CASE WHEN MAX(CAST(SUBSTRING(kode_pelanggan, 5, 3) AS UNSIGNED)) IS NULL THEN 1
                                    ELSE MAX(CAST(SUBSTRING(kode_pelanggan, 5, 3) AS UNSIGNED)) + 1 END AS nomor
                                    FROM (SELECT
                                    MAX(CAST(SUBSTRING(kode_pelanggan, 9, 2) AS UNSIGNED)) AS bln
                                    MAX(CAST(SUBSTRING(kode_pelanggan, 12, 4) AS UNSIGNED)) AS thn
                                    kode_pelanggan 
                                    FROM tbl_pelanggan
                                    GROUP BY kode_pelanggan) a WHERE a.bln = MONTH(NOW()) AND a.thn = YEAR(NOW());", conn)
        da.Fill(ds, "kode_pelanggan")
        Dim nom As Integer
        nom = Integer.Parse(ds.Tables("nomor").Rows(0).Item(0))
        txtfaktur.Text = "INV/" & Format(nom, "0##") & "/" & Format(Now.Month, "0#") & "/" & Now.Year
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilData()

        Try
            isicombo()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbomakanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomakanan.SelectedIndexChanged
        Try
            Dim selectedBarang As String = cbomakanan.SelectedItem.ToString()
            Dim query As String = "SELECT kode_barang, nama_barang, jenis, harga, stock FROM tblbarang WHERE nama_barang = ?"
            cmd = New OdbcCommand(query, conn)
            cmd.Parameters.AddWithValue("nama_barang", selectedBarang)

            dr = cmd.ExecuteReader
            If dr.Read() Then
                ' txtjumlah.Text = dr("jumlah").ToString()
                txtharga.Text = dr("harga").ToString()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error..." & ex.Message)
        End Try
    End Sub

    Private Sub txtjumlah_TextChanged(sender As Object, e As EventArgs) Handles txtjumlah.TextChanged, txtharga.TextChanged, txtnamapembeli.TextChanged, txtfaktur.TextChanged
        Try
            Dim jumlahBeli As Integer = Integer.Parse(txtjumlah.Text)
            Dim hargaBeli As Double = Double.Parse(txtharga.Text)
            Dim subTotal As Double = jumlahBeli * hargaBeli
            txttotal.Text = subTotal
        Catch ex As Exception
            'MsgBox("Error:, Masukkan Angka , bukan huruf " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click, Guna2HtmlLabel5.Click

    End Sub

    Private Sub dgvdata_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdata.CellContentClick
        tampilData()

    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        simpanPenjualan()
        clear()


    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub btnlaporan_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        hapusPenjualan()

    End Sub
End Class