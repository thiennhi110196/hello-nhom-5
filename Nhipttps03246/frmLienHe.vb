Public Class frmLienHe

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLH.Click
        System.Diagnostics.Process.Start("https://docs.google.com/a/fpt.edu.vn/forms/d/1RSXxIYLspFQ93x2JfwyG05Y3-bw2216SP7El4MVHbzA/viewform")
    End Sub

    Private Sub btnThoat7_Click(sender As Object, e As EventArgs) Handles btnThoat7.Click
        Me.Close()
        frmTrangMoDau.Show()
    End Sub

    Private Sub frmLienHe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class