Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmCapNhatKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=Nhipttps03246.mssql.somee.com;packet size=4096;user id=thiennhi110196_SQLLogin_1;pwd=ozp3w2fdlk;data source=Nhipttps03246.mssql.somee.com;persist security info=False;initial catalog=Nhipttps03246"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThoat3_Click(sender As Object, e As EventArgs) Handles btnThoat3.Click
        Me.Close()
        frmTrangChuAdmin.Show()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', Diachi as 'Địa chỉ', SDT as 'SĐT', email from KHACHHANG_PS03246 where MaKH=N'" & txtMKH.Text & "'", connect)
        Try
            If txtMKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập MaKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvKH.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvKH.DataSource = db.DefaultView
                    txtMKH.Text = Nothing
                    btnDelete.Enabled = True
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtMKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KHACHHANG_PS03246 values(@MaKH,@TenKH,@SDT,@Diachi,@email)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtMKH.Focus()
            If txtMKH.Text = "" Then
                MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMKH.Focus()
                If txtTKH.Text = "" Then
                    MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTKH.Focus()
                    If txtSDT.Text = "" Then
                        MessageBox.Show("Vui lòng nhập SĐT", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtSDT.Focus()
                        If txtEmail.Text = "" Then
                            MessageBox.Show("Vui lòng nhập Email", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtEmail.Focus()
                            If txtDC.Text = "" Then
                                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                save.Parameters.AddWithValue("@MaKH", txtMKH.Text)
                                save.Parameters.AddWithValue("@TenKH", txtTKH.Text)
                                save.Parameters.AddWithValue("@SDT", txtSDT.Text)
                                save.Parameters.AddWithValue("@Diachi", txtDC.Text)
                                save.Parameters.AddWithValue("@email", txtEmail.Text)
                                save.ExecuteNonQuery()
                                MessageBox.Show("Lưu thành công")
                                'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                txtMKH.Text = Nothing
                                txtTKH.Text = Nothing
                                txtSDT.Text = Nothing
                                txtEmail.Text = Nothing
                                txtDC.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH', TenKH as 'Tên KH', SDT as 'SĐT', email as 'email',Diachi as 'Địa chỉ' from KHACHHANG_PS03246", conn)
        db.Clear()
        refesh.Fill(db)
        dgvKH.DataSource = db.DefaultView
    End Sub

    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick
        Dim click As Integer = dgvKH.CurrentCell.RowIndex
        txtMKH.Text = dgvKH.Item(0, click).Value
        txtTKH.Text = dgvKH.Item(1, click).Value
        txtSDT.Text = dgvKH.Item(2, click).Value
        txtDC.Text = dgvKH.Item(3, click).Value
        txtEmail.Text = dgvKH.Item(4, click).Value

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim delquery As String = "delete from KHACHHANG_PS03246 where MaKH=@MaKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtMKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtMKH.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MaKH", txtMKH.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtMKH.Text = Nothing
                    txtTKH.Text = Nothing
                    txtSDT.Text = Nothing
                    txtDC.Text = Nothing
                    txtEmail.Text = Nothing
                    txtMKH.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()
    End Sub
    'sự kiện làm mới
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', Diachi as 'Địa chỉ', SDT as 'SĐT', email from KHACHHANG_PS03246", conn)

        conn.Open()
        load.Fill(db)
        dgvKH.DataSource = db.DefaultView

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update KHACHHANG_PS03246 set MaKH=@MaKH, TenKH=@TenKH, Diachi=@Diachi, SDT=@SDT, email=@email where MaKH=@MaKH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtMKH.Focus()
            If txtMKH.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMKH.Focus()
                If txtTKH.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTKH.Focus()
                    If txtDC.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtDC.Focus()
                        If txtSDT.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtSDT.Focus()
                            If txtEmail.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else

                                addupdate.Parameters.AddWithValue("@MaKH", txtMKH.Text)
                                addupdate.Parameters.AddWithValue("@TenKH", txtTKH.Text)
                                addupdate.Parameters.AddWithValue("@SDT", txtSDT.Text)
                                addupdate.Parameters.AddWithValue("@Diachi", txtDC.Text)
                                addupdate.Parameters.AddWithValue("@email", txtEmail.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                                txtMKH.Text = Nothing
                                txtTKH.Text = Nothing
                                txtDC.Text = Nothing
                                txtSDT.Text = Nothing
                                txtEmail.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvKH.DataSource = db
        dgvKH.DataSource = Nothing
        LoadData()

    End Sub
   
End Class