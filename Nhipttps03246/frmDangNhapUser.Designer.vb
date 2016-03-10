<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhapUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangNhapUser))
        Me.btnLogin2 = New System.Windows.Forms.Button()
        Me.btnThoat2 = New System.Windows.Forms.Button()
        Me.txtpass2 = New System.Windows.Forms.TextBox()
        Me.txtuser2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin2
        '
        Me.btnLogin2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnLogin2.ForeColor = System.Drawing.Color.Navy
        Me.btnLogin2.Location = New System.Drawing.Point(317, 210)
        Me.btnLogin2.Name = "btnLogin2"
        Me.btnLogin2.Size = New System.Drawing.Size(122, 33)
        Me.btnLogin2.TabIndex = 14
        Me.btnLogin2.Text = "Login"
        Me.btnLogin2.UseVisualStyleBackColor = True
        '
        'btnThoat2
        '
        Me.btnThoat2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoat2.ForeColor = System.Drawing.Color.Navy
        Me.btnThoat2.Location = New System.Drawing.Point(445, 210)
        Me.btnThoat2.Name = "btnThoat2"
        Me.btnThoat2.Size = New System.Drawing.Size(122, 33)
        Me.btnThoat2.TabIndex = 13
        Me.btnThoat2.Text = "Cannel"
        Me.btnThoat2.UseVisualStyleBackColor = True
        '
        'txtpass2
        '
        Me.txtpass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtpass2.Location = New System.Drawing.Point(310, 135)
        Me.txtpass2.Name = "txtpass2"
        Me.txtpass2.Size = New System.Drawing.Size(257, 30)
        Me.txtpass2.TabIndex = 12
        Me.txtpass2.UseSystemPasswordChar = True
        '
        'txtuser2
        '
        Me.txtuser2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtuser2.Location = New System.Drawing.Point(310, 84)
        Me.txtuser2.Name = "txtuser2"
        Me.txtuser2.Size = New System.Drawing.Size(253, 30)
        Me.txtuser2.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(192, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "PassWord"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(191, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "UserName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 46)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "LOGIN"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Nhipttps03246.My.Resources.Resources.Untitled1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 209)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'frmDangNhapUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nhipttps03246.My.Resources.Resources.tai_hinh_nen_dep_1_620x388
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(583, 292)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogin2)
        Me.Controls.Add(Me.btnThoat2)
        Me.Controls.Add(Me.txtpass2)
        Me.Controls.Add(Me.txtuser2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDangNhapUser"
        Me.Text = "Đăng Nhập"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogin2 As System.Windows.Forms.Button
    Friend WithEvents btnThoat2 As System.Windows.Forms.Button
    Friend WithEvents txtpass2 As System.Windows.Forms.TextBox
    Friend WithEvents txtuser2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
