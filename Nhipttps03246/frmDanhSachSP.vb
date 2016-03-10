Public Class frmDanhSachSP

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("http://thichtruyen.vn/truyen-ngon-tinh/danh-sach-truyen-ngon-tinh-nguoc")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("http://tienhieptruyen.com/truyendanhsach.html")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        frmTrangMoDau.Show()
    End Sub
End Class