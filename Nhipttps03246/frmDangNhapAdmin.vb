Public Class frmDangNhapAdmin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtuser.Text = "admin" And txtpass.Text = "admin") Then
            frmTrangChuAdmin.Show()
            Me.Hide()
        Else
            MessageBox.Show("Lỗi đăng nhập", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
        frmTrangMoDau.Show()
    End Sub
End Class