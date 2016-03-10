Public Class frmDanhSachKH

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        System.Diagnostics.Process.Start("https://drive.google.com/file/d/0B41fPCpmT-shWDREb3pGc29yUmc/view")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmTrangMoDau.Show()
    End Sub
End Class