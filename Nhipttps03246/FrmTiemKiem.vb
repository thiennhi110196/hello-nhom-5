Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class FrmTiemKiem
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=Nhipttps03246.mssql.somee.com;packet size=4096;user id=thiennhi110196_SQLLogin_1;pwd=ozp3w2fdlk;data source=Nhipttps03246.mssql.somee.com;persist security info=False;initial catalog=Nhipttps03246"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs) Handles btnTimKiem.Click
        Dim sql As String = "select * from KHACHHANG_PS03246 where TenKH like  '%" & txttimkiem.Text & "%'"

        'load du lieu
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand(sql, conn)
        da.Fill(dt)
        dgv1.DataSource = dt
        txtMKH.DataBindings.Clear()
        txtTenKH.DataBindings.Clear()
        txtDC.DataBindings.Clear()
        txtsdt.DataBindings.Clear()
        txtMKH.DataBindings.Add("text", dt, "MaKH")
        txtTenKH.DataBindings.Add("text", dt, "TenKH")
        txtDC.DataBindings.Add("text", dt, "Diachi")
        txtsdt.DataBindings.Add("text", dt, "SDT")
        txtemail.DataBindings.Add("text", dt, "email")

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
        frmTrangMoDau.Show()
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim click As Integer = dgv1.CurrentCell.RowIndex
        txtMKH.Text = dgv1.Item(0, click).Value
        txtTenKH.Text = dgv1.Item(1, click).Value
        txtsdt.Text = dgv1.Item(2, click).Value
        txtDC.Text = dgv1.Item(3, click).Value
        txtemail.Text = dgv1.Item(4, click).Value
    End Sub

End Class