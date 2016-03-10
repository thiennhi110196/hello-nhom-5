Public Class frmDangKy

    Private Sub btnxacnhan_Click(sender As Object, e As EventArgs) Handles btnxacnhan.Click
        If txthovaten.Text = "" Or txtmatkhau.Text = "" Or txttaikhoan.Text = "" Or txttuoi.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "BÁO LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MsgBox(" Bạn đã cấp account thành công", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txthovaten.Text = ""
        txtmatkhau.Text = ""
        txttaikhoan.Text = ""
        txttuoi.Text = ""
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat6.Click
        Me.Close()
        frmTrangMoDau.Show()
    End Sub
End Class