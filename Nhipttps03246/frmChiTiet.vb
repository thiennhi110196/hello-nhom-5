Imports System.IO

Public Class frmChiTiet
    ' khai báo
    Dim filename As String
    Dim statusNew As Boolean

    Private Sub frmListbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        statusNew = True
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnopen.Click
        Dim r As DialogResult = ofdFile.ShowDialog()
        If r <> System.Windows.Forms.DialogResult.Cancel Then
            filename = ofdFile.filename
            If Not filename.EndsWith(".txt") Then
                MessageBox.Show("Tập tin không phù hợp")
            Else
                showBookList()
            End If
        End If
        btnopen.Enabled = False
        btnadd.Enabled = True
        btnsave.Enabled = True
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If testPage() Then
            If statusNew Then
                Dim book As String
                Using output = New StreamWriter(filename, True)
                    book = txtid.Text & ControlChars.Tab & txtten.Text _
                        & ControlChars.Tab & txtngaydang.Text & ControlChars.Tab _
                        & txtluotxem.Text & ControlChars.Tab & txttacgia.Text
                    output.WriteLine(book)
                    lsblistbox.Items.Add(book)
                End Using
            Else
                Dim book As String = txtid.Text & ControlChars.Tab & txtten.Text _
                        & ControlChars.Tab & txtngaydang.Text & ControlChars.Tab _
                        & txtluotxem.Text & ControlChars.Tab & txttacgia.Text
                Using output = New StreamWriter(filename, False)
                    For i As Integer = 0 To lsblistbox.Items.Count - 1
                        If i <> lsblistbox.SelectedIndex Then
                            output.WriteLine(lsblistbox.Items(i))
                        Else
                            output.WriteLine(book)
                        End If
                    Next
                End Using
            End If
        End If
        showBookList()
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Using output = New StreamWriter(filename, False)
            For i As Integer = 0 To lsblistbox.Items.Count - 1
                If i <> lsblistbox.SelectedIndex Then
                    output.WriteLine(lsblistbox.Items(i))
                End If
            Next
        End Using
        showBookList()
    End Sub

    Private Sub lstBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsblistbox.SelectedIndexChanged
        Dim book As String = lsblistbox.SelectedItem.ToString()
        Dim attributes As String() = book.Split(ControlChars.Tab)
        txtid.Text = attributes(0)
        txtten.Text = attributes(1)
        txtngaydang.Text = attributes(2)
        txtluotxem.Text = attributes(3)
        txttacgia.Text = attributes(4)
        statusNew = False
        btnsave.Enabled = True
        btndelete.Enabled = True
    End Sub

    Public Sub setNew()
        txtId.Text = ""
        txtten.Text = ""
        txtngaydang.Text = ""
        txtluotxem.Text = ""
        txttacgia.Text = ""
    End Sub

    Public Sub showBookList()
        lsblistbox.Items.Clear()
        Using input = New StreamReader(filename)
            Do Until input.EndOfStream
                Dim line As String = input.ReadLine()
                lsblistbox.Items.Add(line)
            Loop
        End Using
    End Sub

    Public Function testPage() As Boolean
        Dim status As Boolean = False
        If txtId.Text = "" Then
            MessageBox.Show("Bạn chưa nhập Id", "Book Management", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtId.Focus()
        ElseIf txtten.Text = "" Then
            MessageBox.Show("Bạn chưa nhập Name", "Book Management", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtten.Focus()
        ElseIf txtngaydang.Text = "" Then
            MessageBox.Show("Bạn chưa nhập Date", "Book Management", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtngaydang.Focus()
        ElseIf txtluotxem.Text = "" Then
            MessageBox.Show("Bạn chưa nhập Image", "Book Management", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtluotxem.Focus()
        ElseIf txttacgia.Text = "" Then
            MessageBox.Show("Bạn chưa nhập Author", "Book Management", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txttacgia.Focus()
        Else
            status = True
        End If
        Return status
    End Function

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
        frmTrangChuAdmin.Show()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim book As String

        book = txtid.Text & ControlChars.Tab & txtten.Text _
            & ControlChars.Tab & txtngaydang.Text & ControlChars.Tab _
            & txtluotxem.Text & ControlChars.Tab & ControlChars.Tab & txttacgia.Text

        lsblistbox.Items.Add(book)

    End Sub
End Class