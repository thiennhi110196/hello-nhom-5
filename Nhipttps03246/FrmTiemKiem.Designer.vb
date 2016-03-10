<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTiemKiem
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTimKiem = New System.Windows.Forms.Button()
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMKH = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtDC = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(76, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(395, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tìm Kiếm Thông Tin"
        '
        'btnTimKiem
        '
        Me.btnTimKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnTimKiem.ForeColor = System.Drawing.Color.Navy
        Me.btnTimKiem.Location = New System.Drawing.Point(402, 218)
        Me.btnTimKiem.Name = "btnTimKiem"
        Me.btnTimKiem.Size = New System.Drawing.Size(154, 40)
        Me.btnTimKiem.TabIndex = 2
        Me.btnTimKiem.Text = "Tìm Kiếm"
        Me.btnTimKiem.UseVisualStyleBackColor = True
        '
        'txttimkiem
        '
        Me.txttimkiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txttimkiem.Location = New System.Drawing.Point(15, 228)
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(381, 30)
        Me.txttimkiem.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mã Khách Hàng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tên Khách Hàng"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(12, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Địa Chỉ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(12, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Số Điện Thoại"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(12, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Email"
        '
        'txtMKH
        '
        Me.txtMKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMKH.Location = New System.Drawing.Point(141, 63)
        Me.txtMKH.Name = "txtMKH"
        Me.txtMKH.Size = New System.Drawing.Size(255, 23)
        Me.txtMKH.TabIndex = 10
        '
        'txtTenKH
        '
        Me.txtTenKH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenKH.Location = New System.Drawing.Point(140, 93)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(255, 23)
        Me.txtTenKH.TabIndex = 11
        '
        'txtDC
        '
        Me.txtDC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtDC.Location = New System.Drawing.Point(141, 126)
        Me.txtDC.Name = "txtDC"
        Me.txtDC.Size = New System.Drawing.Size(255, 23)
        Me.txtDC.TabIndex = 12
        '
        'txtsdt
        '
        Me.txtsdt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtsdt.Location = New System.Drawing.Point(140, 161)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(255, 23)
        Me.txtsdt.TabIndex = 13
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtemail.Location = New System.Drawing.Point(141, 192)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(255, 23)
        Me.txtemail.TabIndex = 14
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnThoat.ForeColor = System.Drawing.Color.Navy
        Me.btnThoat.Location = New System.Drawing.Point(402, 173)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(154, 39)
        Me.btnThoat.TabIndex = 16
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(4, 265)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(552, 216)
        Me.dgv1.TabIndex = 17
        '
        'FrmTiemKiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nhipttps03246.My.Resources.Resources.tai_hinh_nen_dep_1_620x388
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(563, 484)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtDC)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.txtMKH)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttimkiem)
        Me.Controls.Add(Me.btnTimKiem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmTiemKiem"
        Me.Text = "Tìm Kiếm"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTimKiem As System.Windows.Forms.Button
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMKH As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents txtDC As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
End Class
