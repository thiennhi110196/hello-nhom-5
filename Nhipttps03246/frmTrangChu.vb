Public Class frmTrangMoDau

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        frmDangNhapAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub GiớiThiệuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiớiThiệuToolStripMenuItem.Click
        frmGioiThieu.Show()
        Me.Hide()
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        frmDangNhapUser.Show()
        Me.Hide()
    End Sub

    Private Sub ĐăngKýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngKýToolStripMenuItem.Click
        frmDangKy.Show()
        Me.Hide()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        If (MessageBox.Show("bạn đã chắc chắn muốn thoát", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Me.Close()
            Global.System.Windows.Forms.Application.Exit()
        End If
    End Sub

    Private Sub ĐătHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐătHàngToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://docs.google.com/a/fpt.edu.vn/forms/d/1hOICnWs7uQe_kRiZJwGd6r4viYk7zW8mgCWm_D53nyo/viewform")
    End Sub

    Private Sub TìmKiếmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmToolStripMenuItem.Click
        FrmTiemKiem.Show()
        Me.Hide()
    End Sub

    Private Sub LiênHệToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiênHệToolStripMenuItem.Click
        frmLienHe.Show()
        Me.Hide()
    End Sub

    Private Sub ThôngTinVềSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinVềSáchToolStripMenuItem.Click
        frmThongTin.Show()
        Me.Hide()
    End Sub
End Class
