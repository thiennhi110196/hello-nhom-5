<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrangMoDau
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GiớiThiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngNhậpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngKýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐătHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TìmKiếmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiênHệToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinVềSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GiớiThiệuToolStripMenuItem, Me.ĐăngNhậpToolStripMenuItem, Me.ĐăngKýToolStripMenuItem, Me.ĐătHàngToolStripMenuItem, Me.TìmKiếmToolStripMenuItem, Me.LiênHệToolStripMenuItem, Me.ThôngTinVềSáchToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(725, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GiớiThiệuToolStripMenuItem
        '
        Me.GiớiThiệuToolStripMenuItem.Name = "GiớiThiệuToolStripMenuItem"
        Me.GiớiThiệuToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.GiớiThiệuToolStripMenuItem.Text = "Giới Thiệu"
        '
        'ĐăngNhậpToolStripMenuItem
        '
        Me.ĐăngNhậpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.ĐăngNhậpToolStripMenuItem.Name = "ĐăngNhậpToolStripMenuItem"
        Me.ĐăngNhậpToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.ĐăngNhậpToolStripMenuItem.Text = "Đăng Nhập"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'ĐăngKýToolStripMenuItem
        '
        Me.ĐăngKýToolStripMenuItem.Name = "ĐăngKýToolStripMenuItem"
        Me.ĐăngKýToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ĐăngKýToolStripMenuItem.Text = "Đăng Ký"
        '
        'ĐătHàngToolStripMenuItem
        '
        Me.ĐătHàngToolStripMenuItem.Name = "ĐătHàngToolStripMenuItem"
        Me.ĐătHàngToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ĐătHàngToolStripMenuItem.Text = "Đăt Hàng"
        '
        'TìmKiếmToolStripMenuItem
        '
        Me.TìmKiếmToolStripMenuItem.Name = "TìmKiếmToolStripMenuItem"
        Me.TìmKiếmToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.TìmKiếmToolStripMenuItem.Text = "Tìm Kiếm"
        '
        'LiênHệToolStripMenuItem
        '
        Me.LiênHệToolStripMenuItem.Name = "LiênHệToolStripMenuItem"
        Me.LiênHệToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LiênHệToolStripMenuItem.Text = "Liên Hệ"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'ThôngTinVềSáchToolStripMenuItem
        '
        Me.ThôngTinVềSáchToolStripMenuItem.Name = "ThôngTinVềSáchToolStripMenuItem"
        Me.ThôngTinVềSáchToolStripMenuItem.Size = New System.Drawing.Size(156, 20)
        Me.ThôngTinVềSáchToolStripMenuItem.Text = "Thông tin về các loại sách"
        '
        'frmTrangMoDau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nhipttps03246.My.Resources.Resources.hinh_nen_nhung_cuon_sach_dep_cho_may_tinh_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(725, 415)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTrangMoDau"
        Me.Text = "Trang Chủ"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GiớiThiệuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐăngNhậpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐăngKýToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐătHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TìmKiếmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LiênHệToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinVềSáchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
