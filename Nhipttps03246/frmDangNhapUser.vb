Public Class frmDangNhapUser

    Private Sub btnLogin2_Click(sender As Object, e As EventArgs) Handles btnLogin2.Click
        'Điều kiện báo lỗi
        If txtuser2.Text = "" And txtpass2.Text = "" Then
            MessageBox.Show("Thiếu thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            If txtuser2.Text = "thiennhi" And txtpass2.Text = "12345" Then
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK)

                'Mở giao diện , đồng thời đóng giao diện đăng nhập
                frmTrangChuUser.ShowDialog()
                Me.Hide()

            Else
                MessageBox.Show("Nhập sai mật khẩu hoặc tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnThoat2_Click(sender As Object, e As EventArgs) Handles btnThoat2.Click
        Me.Close()
        frmTrangMoDau.Show()
    End Sub

End Class