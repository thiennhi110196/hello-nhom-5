Public Class frmThongTin
    Private Sub btnChiTiet_Click(sender As Object, e As EventArgs) Handles btnChiTiet.Click
        System.Diagnostics.Process.Start("http://www.bachkhoatrithuc.vn/")
    End Sub

    Private Sub btnThoat5_Click(sender As Object, e As EventArgs) Handles btnThoat5.Click
        Me.Close()
        frmTrangMoDau.Show()
    End Sub
End Class