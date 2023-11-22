Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class form_edit_item_manual
    Dim tombol_ As Button
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Dim con As New MySqlConnection(db)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.MouseHover
        tombol_ = CType(sender, Button)
        tombol_.BackColor = Color.FromArgb(26, 25, 62)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If teks_item.Text <> "" Then
            Dim adpt As New MySqlDataAdapter("select * from data_master where item_code = '" + teks_item.Text.ToString + "'", con)
            Dim ds As New DataSet
            Dim tbb As New DataTable
            adpt.Fill(ds, "emp")
            adpt.Fill(tbb)
            If tbb.Rows.Count > 0 Then
                teks_item_code.Text = tbb(0)(1)
                teks_item_code2.Text = tbb(0)(2)
                teks_item_desk.Text = tbb(0)(3)
                teks_item_tire1.Text = tbb(0)(5)
                teks_item_tire2.Text = tbb(0)(6)
                teks_item_tire3.Text = tbb(0)(7)
                teks_item_tire4.Text = tbb(0)(8)
                teks_item_tire5.Text = tbb(0)(9)
                teks_item_safety.Text = tbb(0)(10)
                teks_sub_kategori.Text = tbb(0)(11)
                combo_kategori.Text = tbb(0)(4)
            Else
                MsgBox("ITEM TIDAK DITEMUKAN!")
            End If
        Else
            MsgBox("MOHON ISI ITEM CODE!")
        End If
    End Sub

    Private Sub tmbl_insert_Click(sender As Object, e As EventArgs) Handles tmbl_insert.Click
        Dim cmd As MySqlCommand, insrt As MySqlCommand
        Dim query As String
        con.Open()
        Try
            If teks_item.Text <> "" Then

                query = "Update data_master set item_code = '" & teks_item_code.Text.ToString() & "', item_code_1 = '" & teks_item_code2.Text.ToString() & "', deskripsi = '" & teks_item_desk.Text.ToString() & "', jenis = '" & combo_kategori.Text.ToString() & "', item_tire = '" & teks_item_tire1.Text.ToString() & "', item_tire1 = '" & teks_item_tire2.Text.ToString() & "', item_tire2 = '" & teks_item_tire3.Text.ToString() & "', item_tire3 = '" & teks_item_tire4.Text.ToString() & "', item_tire4 = '" & teks_item_tire5.Text.ToString() & "', safety_stock = '" & teks_item_safety.Text.ToString() & "', sub_kategori = '" & teks_sub_kategori.Text.ToString() & "' where item_code = '" & teks_item.Text.ToString & "'"
                cmd = New MySqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Dimasukkan")

                Dim adpt As New MySqlDataAdapter("select * from list_sub_kategori where jenis = '" & combo_kategori.Text.ToString() & "' and sub_kategori = '" & teks_sub_kategori.Text.ToString() & "'", con)
                Dim ds As New DataSet
                Dim tbb As New DataTable
                adpt.Fill(ds, "emp")
                adpt.Fill(tbb)
                If tbb.Rows.Count > 0 Then
                Else
                    Dim result = MessageBox.Show("Sub kategori '" + teks_sub_kategori.Text.ToString() + "' belum ada pada kategori item '" + combo_kategori.Text.ToString() + "', apakah anda ingin menambahkan sub kategori baru?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If result = DialogResult.Yes Then
                        insrt = New MySqlCommand("INSERT INTO list_sub_kategori (jenis, sub_kategori) VALUES (@jns,@sub)", con)
                        insrt.Parameters.AddWithValue("@jns", combo_kategori.Text.ToString())
                        insrt.Parameters.AddWithValue("@sub", teks_sub_kategori.Text.ToString())
                        insrt.ExecuteNonQuery()
                    Else
                    End If
                End If
            Else
                MessageBox.Show("MOHON LENGKAPI ITEM CODE!")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        con.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub form_edit_item_manual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.Text = String.Empty
        Me.DoubleBuffered = True
        Dim adpt As New MySqlDataAdapter("select * from kategori", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)
        For i = 0 To tbb.Rows.Count - 1
            combo_kategori.Items.Add(tbb(i)(1))
        Next
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

End Class