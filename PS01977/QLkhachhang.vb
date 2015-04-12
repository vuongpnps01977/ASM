Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmQLKH
    'ket noi den somee
    Dim tb As New DataTable
    Dim connect As String = "workstation id=PS01977.mssql.somee.com;packet size=4096;user id=vuonglab5ps01977;pwd=qpae12345;data source=PS01977.mssql.somee.com;persist security info=False;initial catalog=PS01977"
    Private Sub frmQLloaisanpham_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim KetNoi As New SqlConnection(connect)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select MaKH as 'Mã khách hàng', TenKH as 'Tên khách hàng', SoDT as 'Số điện thoại', Diachi as 'Số nhà', Gioitinh as 'Giới tính' from Khachhang_PS01977", KetNoi)
        Try
            KetNoi.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        viewkh.DataSource = tb
        KetNoi.Close()
    End Sub

    Private Sub viewsp_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles viewkh.CellContentClick
        Dim dr As DataRow = tb.NewRow
        Dim index As Integer = viewkh.CurrentCell.RowIndex
        txtMakh.Text = viewkh.Item(0, index).Value
        txtTenkh.Text = viewkh.Item(1, index).Value
        txtSodt.Text = viewkh.Item(2, index).Value
        txtDiachi.Text = viewkh.Item(3, index).Value
        txtGioitinh.Text = viewkh.Item(4, index).Value
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        End
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        Dim ketnoi As New SqlConnection(connect)
        ketnoi.Open()
        Dim stradd As String = "UPDATE Khachhang_Ps01977 SET TenKH= @TenKH,  SoDT = @SoDT, Diachi = @Diachi, Gioitinh = @Gioitinh where MaKH = @MaKH"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaKH", txtMakh.Text)
            com.Parameters.AddWithValue("@TenKH", txtTenkh.Text)
            com.Parameters.AddWithValue("@SoDT", txtSodt.Text)
            com.Parameters.AddWithValue("@Diachi", txtDiachi.Text)
            com.Parameters.AddWithValue("@Gioitinh", txtGioitinh.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Sửa thành công")

        Catch ex As Exception
            MessageBox.Show("Lỗi! Nhập sai kiểu kí tự.")
        End Try
        tb.Clear()
        viewkh.DataSource = tb
        viewkh.DataSource = Nothing
        xuat_lai_sql()
    End Sub
    Private Sub xuat_lai_sql()

        Dim KetNoi As New SqlConnection(connect)
        Dim sqlAdapter As New SqlDataAdapter("select MaKH as 'Mã khách hàng', TenKH as 'Tên khách hàng', SoDT as 'Số điện thoại', Diachi as 'Số nhà', Gioitinh as 'Giới tính' from Khachhang_PS01977", KetNoi)

        Try
            sqlAdapter.Fill(tb)
        Catch ex As Exception

        End Try
        viewkh.DataSource = tb
        ketnoi.Close()
    End Sub


    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        Dim ketnoi As New SqlConnection(connect)
        ketnoi.Open()
        Dim stradd As String = "Delete from  Khachhang_PS01977 where MaKH = @MaKH"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaKH", txtMakh.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
            MessageBox.Show("Xóa thành công")
        Catch ex As Exception
            MessageBox.Show("Lỗi!")
        End Try
        tb.Clear()
        viewkh.DataSource = tb
        viewkh.DataSource = Nothing
        xuat_lai_sql()
    End Sub

    Private Sub btnThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem.Click
        Dim ketnoi As New SqlConnection(connect)
        Dim stradd As String = "insert into Khachhang_PS01977 (MaKH,TenKH,SoDT,Diachi,Gioitinh) values('" & txtMakh.Text & "','" & txtTenkh.Text & "' ,'" & txtSodt.Text & "','" & txtDiachi.Text & "','" & txtGioitinh.Text & "')"

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
        viewkh.DataSource = tb
        viewkh.DataSource = Nothing
        xuat_lai_sql()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmmain.Show()
    End Sub
End Class