Public Class frmTrangChuUser

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()
        frmTrangMoDau.Show()
    End Sub

    Private Sub ThôngTinVềCácLoạiSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinVềCácLoạiSáchToolStripMenuItem.Click
        frmThongTin.Show()
        Me.Hide()
    End Sub

    Private Sub DanhSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchToolStripMenuItem.Click
        frmDanhSachKH.Show()
        Me.Close()
    End Sub

    Private Sub DanhSáchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DanhSáchToolStripMenuItem1.Click
        frmDanhSachSP.Show()
        Me.Close()
    End Sub

    Private Sub LiênHệToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiênHệToolStripMenuItem.Click
        frmLienHe.Show()
        Me.Close()
    End Sub

    Private Sub ĐătHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐătHàngToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://docs.google.com/a/fpt.edu.vn/forms/d/1hOICnWs7uQe_kRiZJwGd6r4viYk7zW8mgCWm_D53nyo/viewform")
    End Sub
End Class