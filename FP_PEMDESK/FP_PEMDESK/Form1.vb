Imports System.Data.Odbc
Imports System.Data.SqlClient

Public Class Form1

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


    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint
        koneksi()

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername IsNot Nothing And txtpassword IsNot Nothing Then
            If ds IsNot Nothing Then
              ds.Clear()
            Else
                ds = New DataSet() ' Inisialisasi dataset jika belum diinisialisasi
            End If

            da = New OdbcDataAdapter("select * from user where username='" & txtusername.Text & "' AND password='" & txtpassword.Text & "';", conn)
            da.Fill(ds, "user")
            If ds.Tables("user").Rows.Count > 0 Then
                Me.Hide()
                Form2.Show()

            Else
                MessageBox.Show("Invalid Username or Password")
            End If
        End If
    End Sub
End Class
