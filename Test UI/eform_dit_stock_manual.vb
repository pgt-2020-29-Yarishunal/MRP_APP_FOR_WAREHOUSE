Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class eform_dit_stock_manual
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Dim con As New MySqlConnection(db)
    Private Sub eform_dit_stock_manual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Enabled = False
        Label4.Enabled = False
        periode_stock.Enabled = False
        bulan.Enabled = False
        Me.ControlBox = False
        Me.Text = String.Empty
        Me.DoubleBuffered = True
    End Sub

    Private Sub jenis_stock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jenis_stock.SelectedIndexChanged
        If jenis_stock.Text.ToString() = "Stock MRP" Then
            periode_stock.Enabled = True
            bulan.Enabled = True
            Label4.Enabled = True
            Label3.Enabled = True
        Else
            periode_stock.Enabled = False
            bulan.Enabled = False
            Label4.Enabled = False
            Label3.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nama_table As String
        If jenis_stock.Text.ToString = "Stock Daily" Then
            teks_stock_in.Enabled = True
            If teks_item.Text.ToString = "" Then
                MsgBox("Mohon lengkapi data terlebih dahulu!")
                Return
            End If
            Dim adpt1 As New MySqlDataAdapter("select * from stock where item_code = '" & teks_item.Text.ToString & "'", con)
            Dim ds1 As New DataSet
            Dim tbb1 As New DataTable
            adpt1.Fill(ds1, "emp1")
            adpt1.Fill(tbb1)
            If tbb1.Rows.Count() > 0 Then
                teks_on_hand.Text = tbb1(0)(4)
                teks_stock_out.Text = tbb1(0)(3)
                teks_stock_in.Text = tbb1(0)(2)
            Else
                MsgBox("DATA TIDAK DITEMUKAN!")
            End If
        ElseIf jenis_stock.Text.ToString = "Stock MRP" Then
            teks_stock_in.Enabled = False
            If teks_item.Text.ToString = "" Or periode_stock.Text.ToString = "" Or bulan.Text.ToString = "" Then
                MsgBox("Mohon lengkapi data terlebih dahulu!")
                Return
            End If
            Dim adpt1 As New MySqlDataAdapter("select * from stock_mrp where item_code = '" & teks_item.Text.ToString & "' AND jenis = '" & periode_stock.Text.ToString & "' AND bulan = '" & bulan.Text.ToString & "' AND tahun = '" & tahun_text.Text.ToString & "' and cut_off = '" & cut_off_text.Text.ToString & "'", con)
            Dim ds1 As New DataSet
            Dim tbb1 As New DataTable
            adpt1.Fill(ds1, "emp1")
            adpt1.Fill(tbb1)
            If tbb1.Rows.Count() > 0 Then
                teks_on_hand.Text = tbb1(0)(3)
                teks_stock_out.Text = tbb1(0)(2)
            Else
                MsgBox("DATA TIDAK DITEMUKAN!")
            End If
        ElseIf jenis_stock.Text.ToString = "" Then

            MsgBox("Mohon lengkapi data terlebih dahulu!")
            Return

        End If

    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub tmbl_insert_Click(sender As Object, e As EventArgs) Handles tmbl_insert.Click
        Dim cmd As MySqlCommand
        Dim query As String
        con.Open()
        If jenis_stock.Text.ToString = "Stock Daily" Then
            Try
                If teks_item.Text <> "" Then
                    Try
                        query = "Update stock set stock_in = '" & teks_stock_in.Text.ToString() & "', stock_out = '" & teks_stock_out.Text.ToString() & "', quantity = '" & teks_on_hand.Text.ToString() & "' where item_code = '" & teks_item.Text.ToString & "'"
                        cmd = New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Data Dimasukkan")
                    Catch ex As Exception
                        MsgBox("Mohon Lengkapi Data!")
                    End Try
                Else
                    MessageBox.Show("MOHON LENGKAPI ITEM CODE!")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        ElseIf jenis_stock.Text.ToString = "Stock MRP" Then
            Try
                If teks_item.Text <> "" Then
                    Try
                        query = "Update stock_mrp set  stock_out = '" & teks_stock_out.Text.ToString() & "', total = '" & teks_on_hand.Text.ToString() & "' where item_code = '" & teks_item.Text.ToString & "' AND jenis = '" & periode_stock.Text.ToString & "' AND bulan = '" & bulan.Text.ToString & "' AND tahun = '" & tahun_text.Text.ToString & "' and cut_off = '" & cut_off_text.Text.ToString & "'"
                        cmd = New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Data Dimasukkan")
                    Catch ex As Exception
                        MsgBox("Mohon Lengkapi Data!")
                    End Try
                Else
                    MessageBox.Show("MOHON LENGKAPI ITEM CODE!")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        ElseIf jenis_stock.Text.ToString = "" Then
            MsgBox("Mohon lengkapi data terlebih dahulu!")
            Return
        End If

        con.Close()
    End Sub
End Class