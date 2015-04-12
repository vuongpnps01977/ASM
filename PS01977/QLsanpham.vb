Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmQLsanpham
    'ket noi den somee
    Dim tb As New DataTable
    Dim connect As String = "workstation id=PS01977.mssql.somee.com;packet size=4096;user id=vuonglab5ps01977;pwd=qpae12345;data source=PS01977.mssql.somee.com;persist security info=False;initial catalog=PS01977"

    Private Sub frmQLsanpham_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim KetNoi As New SqlConnection(connect)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', Soluong as 'Số lượng', ChitietSP as 'Chi tiết sản phẩm', Dongia as 'đơn giá', Loaisanpham_PS01977_Maloai as 'Mã loại sản phẩm' from Sanpham_ps01977", KetNoi)
        Try
            KetNoi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        viewsp.DataSource = tb
        KetNoi.Close()
    End Sub

    Private Sub viewsp_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles viewsp.CellContentClick
        Dim dr As DataRow = tb.NewRow
        Dim index As Integer = viewsp.CurrentCell.RowIndex
        txtMasp.Text = viewsp.Item(0, index).Value
        txtTensp.Text = viewsp.Item(1, index).Value
        txtSoluong.Text = viewsp.Item(2, index).Value
        txtChitietsp.Text = viewsp.Item(3, index).Value
        txtDongia.Text = viewsp.Item(4, index).Value
        txtMaloai.Text = viewsp.Item(5, index).Value
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        End
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Dim ketnoi As New SqlConnection(connect)
        ketnoi.Open()
        Dim stradd As String = "UPDATE Sanpham_Ps01977 SET TenSP= @TenSP,  Dongia = @Dongia, Soluong = @Soluong, ChitietSP = @ChitietSP, Loaisanpham_PS01977_Maloai = @Maloai where MaSP = @MaSP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSP", txtMasp.Text)
            com.Parameters.AddWithValue("@TenSP", txtTensp.Text)
            com.Parameters.AddWithValue("@Maloai", txtMaloai.Text)
            com.Parameters.AddWithValue("@Dongia", txtDongia.Text)
            com.Parameters.AddWithValue("@Soluong", txtSoluong.Text)
            com.Parameters.AddWithValue("@ChitietSP", txtChitietsp.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa thành công")

        Catch ex As Exception
            MessageBox.Show("Lỗi! Nhập sai kiểu kí tự.")
        End Try
        tb.Clear()
        viewsp.DataSource = tb
        viewsp.DataSource = Nothing
        xuat_lai_sql()
    End Sub
    Private Sub xuat_lai_sql()

        Dim KetNoi As New SqlConnection(connect)
        Dim sqlAdapter As New SqlDataAdapter("select MaSP as 'Mã sản phẩm', TenSP as 'Tên sản phẩm', Soluong as 'Số lượng', ChitietSP as 'Chi tiết sản phẩm', Dongia as 'đơn giá', Loaisanpham_PS01977_Maloai as 'Mã loại sản phẩm' from Sanpham_ps01977", KetNoi)

        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        viewsp.DataSource = tb
        ketnoi.Close()
    End Sub


    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim ketnoi As New SqlConnection(connect)
        ketnoi.Open()
        Dim stradd As String = "Delete from  Sanpham_PS01977 where MaSP = @MaSP"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaSP", txtMasp.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa thành công")
        Catch ex As Exception
            MessageBox.Show("Lỗi!")
        End Try
        tb.Clear()
        viewsp.DataSource = tb
        viewsp.DataSource = Nothing
        xuat_lai_sql()
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Dim ketnoi As New SqlConnection(connect)
        Dim stradd As String = "insert into Sanpham_PS01977 (MaSP,TenSP,Soluong,ChitietSP,Dongia,Loaisanpham_PS01977_Maloai) values('" & txtMasp.Text & "','" & txtTensp.Text & "' ,'" & txtSoluong.Text & "','" & txtChitietsp.Text & "','" & txtDongia.Text & "','" & txtMaloai.Text & "')"

        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            ketnoi.Open()
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Thêm thành công")
        Catch ex As Exception
            MessageBox.Show("Lỗi!")
        End Try
        tb.Clear()
        viewsp.DataSource = tb
        viewsp.DataSource = Nothing
        xuat_lai_sql()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmmain.Show()
    End Sub
End Class