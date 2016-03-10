Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmCapNhatSP
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=Nhipttps03246.mssql.somee.com;packet size=4096;user id=thiennhi110196_SQLLogin_1;pwd=ozp3w2fdlk;data source=Nhipttps03246.mssql.somee.com;persist security info=False;initial catalog=Nhipttps03246"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SANPHAM_PS03246 values(@MaSP,@Maloai,@TenSP,@NgaySX,@NoiSX)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMSP.Focus()
            If txtMSP.Text = "" Then
                MessageBox.Show("Vui lòng nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMSP.Focus()
                If txtML.Text = "" Then
                    MessageBox.Show("Vui lòng nhập mã loại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtML.Focus()
                    If txtTenSP.Text = "" Then
                        MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtTenSP.Focus()
                        If txtNSX.Text = "" Then
                            MessageBox.Show("Vui lòng nhập ngày SX", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtNSX.Focus()
                            If txtNoiSX.Text = "" Then
                                MessageBox.Show("Vui lòng nhập địa chỉ SX", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                save.Parameters.AddWithValue("@MaSP", txtMSP.Text)
                                save.Parameters.AddWithValue("@Maloai", txtML.Text)
                                save.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
                                save.Parameters.AddWithValue("@NgaySX", txtNSX.Text)
                                save.Parameters.AddWithValue("@NoiSX", txtNoiSX.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtMSP.Text = Nothing
                                txtML.Text = Nothing
                                txtTenSP.Text = Nothing
                                txtNSX.Text = Nothing
                                txtNoiSX.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select SANPHAM_PS03246.MaSP as 'Mã sản phẩm',LOAISP_PS03246.Maloai as 'Mã Loại', SANPHAM_PS03246.TenSP as 'Tên Sản Phẩm',SANPHAM_PS03246.NgaySX as 'Ngày SX',SANPHAM_PS03246.NoiSX as 'Nơi SX' from SANPHAM_PS03246 inner join LOAISP_PS03246 on SANPHAM_PS03246.Maloai = LOAISP_PS03246.Maloai", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSP.DataSource = db.DefaultView
    End Sub

    Private Sub frmsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select SANPHAM_PS03246.MaSP as 'Mã sản phẩm',LOAISP_PS03246.Maloai as 'Mã Loại', SANPHAM_PS03246.TenSP as 'Tên Sản Phẩm',SANPHAM_PS03246.NgaySX as 'Ngày SX',SANPHAM_PS03246.NoiSX as 'Nơi SX' from SANPHAM_PS03246 inner join LOAISP_PS03246 on SANPHAM_PS03246.Maloai = LOAISP_PS03246.Maloai", conn)
        conn.Open()
        load.Fill(db)
        dgvSP.DataSource = db.DefaultView
    End Sub

    Private Sub btnDelete2_Click(sender As Object, e As EventArgs) Handles btnDelete2.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Delete As String = ("DELETE SANPHAM_PS03246 WHERE MaSP = @MaSP") 'Truy van xoa
    Dim CONNECT As SqlCommand = New SqlCommand(Delete, conn)
        conn.Open() 'Mo ket noi CSDL
        Try
            txtMSP.Focus()
            If txtMSP.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                CONNECT.Parameters.AddWithValue("@MaSP", txtMSP.Text)
                CONNECT.ExecuteNonQuery()
                conn.Close() 'Dong ket noi CSDL
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch EX As Exception
    'Thong bao xoa that bai
            MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    'Lam moi lai CSDL
        db.Clear()
        dgvSP.DataSource = db
        dgvSP.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        'Truy van du lieu
        Dim TRUYVAN As SqlDataAdapter = New SqlDataAdapter("select SANPHAM_PS03246.MaSP as 'Mã sản phẩm',LOAISP_PS03246.Maloai as 'Mã Loại', SANPHAM_PS03246.TenSP as 'Tên Sản Phẩm',SANPHAM_PS03246.NgaySX as 'Ngày SX',SANPHAM_PS03246.NoiSX as 'Nơi SX' from SANPHAM_PS03246 inner join LOAISP_PS03246 on SANPHAM_PS03246.Maloai = LOAISP_PS03246.Maloai", conn)
        conn.Open() 'Mo ket noi CSDL
        TRUYVAN.Fill(db)
        dgvSP.DataSource = db.DefaultView 'Dua len DataGridView
    End Sub

    Private Sub btnThoat4_Click(sender As Object, e As EventArgs) Handles btnThoat4.Click
        Me.Close()
        frmTrangChuAdmin.Show()
    End Sub
End Class