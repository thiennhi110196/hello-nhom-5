Public Class frmTrangChuAdmin

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()
        frmTrangMoDau.Show()
    End Sub

    Private Sub CậpNhậtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậpNhậtToolStripMenuItem.Click
        frmCapNhatKH.Show()
        Me.Hide()
    End Sub

    Private Sub CậpNhậtToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CậpNhậtToolStripMenuItem1.Click
        frmCapNhatSP.Show()
        Me.Hide()
    End Sub

    Private Sub ThôngTinVềCácLoạiSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinVềCácLoạiSáchToolStripMenuItem.Click
        frmThongTin.Show()
        Me.Hide()
    End Sub

    Private Sub ChiTiếtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtToolStripMenuItem.Click
        frmChiTiet.Show()
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
End Class