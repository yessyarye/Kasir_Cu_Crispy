Imports System.Data.Odbc

Public Class Form3

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

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class