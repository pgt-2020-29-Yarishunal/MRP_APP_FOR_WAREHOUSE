Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class edit_kategori
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Dim con As New MySqlConnection(db)
    Private Sub edit_kategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.Text = String.Empty
        Me.DoubleBuffered = True
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If add_supplier_new.Text <> String.Empty Then
            list_supp_new.Rows.Add(add_supplier_new.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If add_search.Text <> String.Empty Then
            list_supp_search.Rows.Add(add_search.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim list_supp_ As String = ""
        Dim data_split As String
        If teks_search.Text <> "" Then
            Dim adpt As New MySqlDataAdapter("select * from kategori where jenis = '" + teks_search.Text.ToString + "'", con)
            Dim ds As New DataSet
            Dim tbb As New DataTable
            adpt.Fill(ds, "emp")
            adpt.Fill(tbb)
            If tbb.Rows.Count > 0 Then
                kategori_search.Text = tbb(0)(1).ToString
                data_split = tbb(0)(2).ToString
                For i = 0 To data_split.Split("-").Length - 1
                    list_supp_search.Rows.Add(data_split.Split("-")(i))
                Next
            Else
                MsgBox("ITEM TIDAK DITEMUKAN!")
            End If
        Else
            MsgBox("MOHON ISI ITEM CODE!")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim updt As MySqlCommand
        Dim cmd As MySqlCommand
        Dim query As String
        If teks_search.Text.ToString = "" And kategori_search.Text.ToString = "" Then
            MsgBox("Mohon lengkapi data terlebih dahulu!")
            Return
        End If
        con.Open()

        Dim list_supplier_ As String = ""
        For i = 0 To list_supp_search.Rows.Count - 2
            If i = list_supp_search.Rows.Count - 2 Then
                list_supplier_ += list_supp_search.Item(0, i).Value.ToString()
            Else
                list_supplier_ += list_supp_search.Item(0, i).Value.ToString() + "-"
            End If
        Next

        Try
            query = "Update kategori set jenis = '" & kategori_search.Text.ToString() & "', supplier = '" & list_supplier_ & "' where jenis = '" & teks_search.Text & "';"
            cmd = New MySqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Dimasukkan")
        Catch erro As Exception
            MsgBox(erro.ToString)
        End Try
        con.Close()

    End Sub

    Private Sub list_supp_new_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles list_supp_new.CellDoubleClick
        If list_supp_new.SelectedRows.Count > 0 Then
            Dim result = MessageBox.Show("Hapus Data?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                list_supp_new.Rows.Remove(list_supp_new.SelectedRows(0))
            ElseIf result = DialogResult.No Then
            Else
            End If
        Else
        End If
    End Sub

    Private Sub list_supp_search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles list_supp_search.CellDoubleClick
        If list_supp_search.SelectedRows.Count > 0 Then
            Dim result = MessageBox.Show("Hapus Data?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                list_supp_search.Rows.Remove(list_supp_search.SelectedRows(0))
            ElseIf result = DialogResult.No Then
            Else
            End If
        Else
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If teks_new_kategori.Text.ToString = "" Then
            MsgBox("Mohon lengkapi data terlebih dahulu!")
            Return
        End If
        Dim cmd As MySqlCommand
        con.Open()

        Dim list_supplier_ As String = ""
        For i = 0 To list_supp_new.Rows.Count - 2
            If i = list_supp_new.Rows.Count - 2 Then
                list_supplier_ += list_supp_new.Item(0, i).Value.ToString()
            Else
                list_supplier_ += list_supp_new.Item(0, i).Value.ToString() + "-"
            End If
        Next


        Try
            cmd = New MySqlCommand("INSERT INTO kategori (jenis, supplier) VALUES (@jns,@splr)", con)
            cmd.Parameters.AddWithValue("@jns", teks_new_kategori.Text)
            cmd.Parameters.AddWithValue("@splr", list_supplier_)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Dimasukkan")
        Catch erro As Exception
            MsgBox(erro.ToString)
        End Try
        con.Close()
    End Sub
End Class