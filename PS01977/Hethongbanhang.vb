'hệthốngcơsởdữliệukếtnốivới SQL
Imports System.Data.SqlClient

Public Class frmhtbh
    'sự kiện nút đăng nhập'

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim chuoiketnoiAsString = "workstation id=ps01977.mssql.somee.com;packet size=4096;user id=vuonglab5ps01977;pwd=qpae12345;data source=ps01977.mssql.somee.com;persist security info=False;initial catalog=ps01977"
    Dim KetNoi AsSqlConnection = NewSqlConnection(chuoiketnoi)
    Dim sqlAdapter AsNewSqlDataAdapter("select * from NhanVien_PS01977 where MaNV='"& TextBox1.Text &"' and Pass='"& TextBox2.Text &"' ", KetNoi)
    Dim tb AsNewDataTable
        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("ket nối thành công")
                Main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai Tai Khoan hoac Mat Khau")
            End If

Catch ex AsException

            EndTry()
            EndSub()


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
