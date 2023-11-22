Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class Form_input_stock
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Dim con As New MySqlConnection(db)
    Dim tahun_ini As String = Format(Date.Now(), "yyyy").ToString()
    Dim tahun_hari_ini As String = Format(Date.Now(), "yy").ToString()
    Dim bulan_ini As String = Format(Date.Now(), "MMM").ToString().ToUpper
    Dim hari_ini As String = Format(Date.Now(), "dd").ToString()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xlapp As Excel.Application
        Dim xlworkbook As Excel.Workbook
        Dim xlworksheet As Excel.Worksheet
        Dim xlrange As Excel.Range
        Dim xlrow As Integer

        Dim filename As String
        Dim data(0 To 100) As String

        With OpenFileDialog1
            .Filter = "Excel Office| *.xls;*.xlsx"
            .ShowDialog()
            filename = .FileName
        End With
        dataa.Rows.Clear()
        teksfile.Text = filename

        If teksfile.Text <> String.Empty And teksfile.Text <> "OpenFileDialog1" Then
            xlapp = New Excel.Application
            Try
                xlworkbook = xlapp.Workbooks.Open(teksfile.Text)
                xlworksheet = xlworkbook.Worksheets("Sheet1")
                xlrange = xlworksheet.UsedRange
                For xlrow = 2 To xlrange.Rows.Count
                    If xlrange.Cells(xlrow, 1).Text = "" Then
                        Exit For
                    End If
                    dataa.Rows.Add(xlrange.Cells(xlrow, 1).Text, xlrange.Cells(xlrow, 3).Text, xlrange.Cells(xlrow, 4).Text, xlrange.Cells(xlrow, 5).Text)
                    Dim prc As Integer = (xlrow / xlrange.Rows.Count) * 100
                    ProgressBar1.Value = prc
                    label_progress.Text = CStr(prc) + "%"
                Next
                xlworkbook.Close()
                xlapp.Quit()
                MessageBox.Show("Data Selesai Diambil")
            Catch err As Exception
                Me.Show()
                MsgBox(err.ToString())
            End Try
        End If
        Label2.Enabled = True
        jenis_stock.Enabled = True
    End Sub

    Private Sub Form_input_stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Enabled = False
        Label3.Enabled = False
        Label4.Enabled = False
        Label5.Enabled = False
        periode_stock.Enabled = False
        jenis_stock.Enabled = False
        bulan.Enabled = False
        cut_off_text.Enabled = False
        tahun_text.Text = tahun_ini
        cut_off_text.Text = hari_ini + "-" + bulan_ini + "-" + tahun_hari_ini
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dataa.Rows.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If jenis_stock.Text.ToString = "Stock Daily" Then

            If teksfile.Text.ToString = "" Then
                MsgBox("Mohon lengkapi data terlebih dahulu!")
                Return
            End If

        ElseIf jenis_stock.Text.ToString = "Stock MRP" Then

            If periode_stock.Text.ToString = "Stock Akhir bulan (Last Month)" Then

                If teksfile.Text.ToString = "" Or periode_stock.Text.ToString = "" Or bulan.Text.ToString = "" Or tahun_text.Text.ToString = "" Then
                    MsgBox("Mohon lengkapi data terlebih dahulu!")
                    Return
                End If

            ElseIf periode_stock.Text.ToString = "Stock Awal Bulan (This Month)" Then

                If teksfile.Text.ToString = "" Or periode_stock.Text.ToString = "" Or bulan.Text.ToString = "" Or tahun_text.Text.ToString = "" Or cut_off_text.Text = "" Then
                    MsgBox("Mohon lengkapi data terlebih dahulu!")
                    Return
                End If

            Else
            End If

        ElseIf jenis_stock.Text.ToString = "" Then

            MsgBox("Mohon lengkapi data terlebih dahulu!")
            Return

        End If

        Dim cmd As MySqlCommand, hist As MySqlCommand, del As MySqlCommand, insert_list As MySqlCommand

        con.Open()
        If (jenis_stock.Text.ToString() = "Stock Daily") Then
            Try
                del = New MySqlCommand("DELETE FROM stock", con)
                del.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Data lama Gagal Di Hapus")
            End Try

            Try
                For i As Integer = 0 To dataa.Rows.Count - 2 Step +1
                    cmd = New MySqlCommand("INSERT INTO stock (item_code, stock_in, stock_out, quantity) VALUES (@code ,@in ,@out, @qty)", con)
                    cmd.Parameters.AddWithValue("@code", dataa.Rows(i).Cells(0).Value.ToString())
                    cmd.Parameters.AddWithValue("@in", dataa.Rows(i).Cells(1).Value.ToString())
                    cmd.Parameters.AddWithValue("@out", dataa.Rows(i).Cells(2).Value.ToString())
                    cmd.Parameters.AddWithValue("@qty", dataa.Rows(i).Cells(3).Value.ToString())
                    cmd.ExecuteNonQuery()
                Next
                hist = New MySqlCommand("UPDATE histori_report SET stock_daily = @val", con)
                hist.Parameters.AddWithValue("@val", DateTime.Now)
                hist.ExecuteNonQuery()
                MsgBox("Data Baru Berhasil Dimasukkan")
            Catch ex As Exception
                MsgBox("Data Gagal Di Update")
            End Try

        ElseIf jenis_stock.Text.ToString() = "Stock MRP" Then

            If (periode_stock.Text.ToString() = "" Or bulan.Text.ToString() = "") Then
                MsgBox("Mohon Lengkapi Data Terlebih Dahulu!")
            Else
                If (periode_stock.Text.ToString() = "Stock Awal Bulan (This Month)") Then

                    Dim adpt14_1 As New MySqlDataAdapter("select * from list_stock_mrp WHERE tgl_cut_off = '" & cut_off_text.Text.ToString & "' AND bulan = '" + bulan.Text.ToString + "' AND tahun = '" + tahun_text.Text.ToString + "'", con)
                    Dim ds14_1 As New DataSet
                    Dim tbb14_1 As New DataTable
                    adpt14_1.Fill(ds14_1, "emp14_1")
                    adpt14_1.Fill(tbb14_1)
                    If tbb14_1.Rows.Count() > 0 Then
                        ''KONFIRMASI UNTUK UPDATE DATA
                        Dim result = MessageBox.Show("Stock dengan cut off " + cut_off_text.Text.ToString + " sudah terinput, apakah anda ingin meng-update nya?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        If result = DialogResult.Yes Then
                            Try
                                cmd = New MySqlCommand("DELETE FROM stock_mrp WHERE jenis = 'Stock Awal Bulan (This Month)' AND cut_off = '" & cut_off_text.Text.ToString & "' AND bulan = '" + bulan.Text.ToString + "' AND tahun = '" + tahun_text.Text.ToString + "'", con)
                                del = New MySqlCommand("DELETE FROM list_stock_mrp WHERE tgl_cut_off = '" & cut_off_text.Text.ToString & "' AND bulan = '" + bulan.Text.ToString + "' AND tahun = '" + tahun_text.Text.ToString + "'", con)
                                cmd.ExecuteNonQuery()
                                del.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox("Data lama Gagal Dihapus")
                                con.Close()
                                Return
                            End Try
                        Else
                            con.Close()
                            Return
                        End If

                    End If

                    Dim adpt_14_2 As New MySqlDataAdapter("select * from stock_mrp WHERE jenis = 'Stock Awal Bulan (This Month)' AND bulan = '" & Format(Date.Now().AddMonths(-1), "MMMM") & "' and tahun = '" & Format(Date.Now().AddMonths(-1), "yyyy") & "' ", con)
                    Dim ds_14_2 As New DataSet
                    Dim tbb_14_2 As New DataTable
                    adpt_14_2.Fill(ds_14_2, "emp_14_2")
                    adpt_14_2.Fill(tbb_14_2)
                    If tbb_14_2.Rows.Count() > 0 Then
                        Try
                            cmd = New MySqlCommand("DELETE FROM stock_mrp WHERE jenis = 'Stock Awal Bulan (This Month)' AND bulan = '" & Format(Date.Now().AddMonths(-1), "MMMM") & "' and tahun = '" & Format(Date.Now().AddMonths(-1), "yyyy") & "'", con)
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox("Data Stock Awal Bulan Kemarin Gagal Dihapus")
                        End Try
                    End If

                    Try
                        For i As Integer = 0 To dataa.Rows.Count - 2 Step +1
                            cmd = New MySqlCommand("INSERT INTO stock_mrp (item_code, stock_out, total, jenis, bulan, tahun, cut_off) VALUES (@code ,@out, @total, @jenis, @bulan, @thn, @cut_)", con)
                            cmd.Parameters.AddWithValue("@code", dataa.Rows(i).Cells(0).Value.ToString())
                            cmd.Parameters.AddWithValue("@out", dataa.Rows(i).Cells(2).Value.ToString())
                            cmd.Parameters.AddWithValue("@total", dataa.Rows(i).Cells(3).Value.ToString())
                            cmd.Parameters.AddWithValue("@jenis", periode_stock.Text.ToString())
                            cmd.Parameters.AddWithValue("@bulan", bulan.Text.ToString())
                            cmd.Parameters.AddWithValue("@thn", tahun_text.Text.ToString())
                            cmd.Parameters.AddWithValue("@cut_", cut_off_text.Text.ToString())
                            cmd.ExecuteNonQuery()
                        Next

                        insert_list = New MySqlCommand("INSERT INTO list_stock_mrp (bulan, tahun, tgl_cut_off) VALUES (@bl, @th, @cut)", con)
                        insert_list.Parameters.AddWithValue("@bl", bulan.Text.ToString)
                        insert_list.Parameters.AddWithValue("@th", tahun_text.Text.ToString)
                        insert_list.Parameters.AddWithValue("@cut", cut_off_text.Text.ToString)
                        insert_list.ExecuteNonQuery()

                        hist = New MySqlCommand("UPDATE histori_report SET stock_mrp = @val ", con)
                        hist.Parameters.AddWithValue("@val", DateTime.Now)
                        hist.ExecuteNonQuery()
                        MessageBox.Show("Data Dimasukkan")
                    Catch ex As Exception
                        MsgBox("Data Gagal Di Update | " + ex.ToString())
                    End Try

                ElseIf periode_stock.Text.ToString() = "Stock Akhir bulan (Last Month)" Then

                    Dim adpt As New MySqlDataAdapter("select * from stock_mrp WHERE jenis = 'Stock Akhir bulan (Last Month)' AND bulan = '" & periode_stock.Text.ToString() & "' and tahun = '" & tahun_text.Text.ToString & "'", con)
                    Dim ds As New DataSet
                    Dim tbb As New DataTable
                    adpt.Fill(ds, "emp")
                    adpt.Fill(tbb)
                    If tbb.Rows.Count() > 0 Then
                        Try
                            cmd = New MySqlCommand("DELETE FROM stock_mrp WHERE jenis = 'Stock Akhir bulan (Last Month)' AND bulan = '" & periode_stock.Text.ToString() & "' and tahun = '" & tahun_text.Text.ToString & "'", con)
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox("Data lama Gagal Di Hapus | " + ex.ToString())
                        End Try
                    End If

                    Try
                        For i As Integer = 0 To dataa.Rows.Count - 2 Step +1
                            cmd = New MySqlCommand("INSERT INTO stock_mrp (item_code, stock_out, total, jenis, bulan, tahun, cut_off) VALUES (@code ,@out, @total, @jenis, @bulan, @thun, @cut__)", con)
                            cmd.Parameters.AddWithValue("@code", dataa.Rows(i).Cells(0).Value.ToString())
                            cmd.Parameters.AddWithValue("@out", dataa.Rows(i).Cells(2).Value.ToString())
                            cmd.Parameters.AddWithValue("@total", dataa.Rows(i).Cells(3).Value.ToString())
                            cmd.Parameters.AddWithValue("@jenis", periode_stock.Text.ToString())
                            cmd.Parameters.AddWithValue("@bulan", bulan.Text.ToString())
                            cmd.Parameters.AddWithValue("@thun", tahun_text.Text.ToString())
                            cmd.Parameters.AddWithValue("@cut__", "")
                            cmd.ExecuteNonQuery()
                        Next
                        MessageBox.Show("Data Dimasukkan")
                    Catch ex As Exception
                        MsgBox("Data Gagal Di Update")
                    End Try

                    'HAPUS STOCK AKHIR BULAN 4 BULAN KE BELAKANG
                    'Try
                    'cmd = New MySqlCommand("DELETE FROM stock_mrp WHERE jenis = 'Stock Akhir bulan (Last Month)' AND bulan = '" & Format(Date.Now().AddMonths(-4), "MMMM") & "'", con)
                    'cmd.ExecuteNonQuery()
                    'Catch ex As Exception
                    'MsgBox("Data -4 bulan Gagal Di Hapus | " + ex.ToString())
                    'End Try
                    '

                End If
            End If

        Else
            MsgBox("Data Error!")
        End If
        con.Close()
    End Sub

    Private Sub jenis_stock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jenis_stock.SelectedIndexChanged
        If jenis_stock.Text.ToString() = "Stock MRP" Then
            periode_stock.Enabled = True
            bulan.Enabled = True
            Label4.Enabled = True
            Label3.Enabled = True
            Label5.Enabled = True

            If periode_stock.Text = "Stock Awal Bulan (This Month)" Then
                cut_off_text.Enabled = True
            Else
                cut_off_text.Enabled = False
            End If

        Else
            periode_stock.Enabled = False
            bulan.Enabled = False
            Label4.Enabled = False
            Label3.Enabled = False
            cut_off_text.Enabled = False
            Label5.Enabled = False
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim new_form = New eform_dit_stock_manual
        new_form.Show()
    End Sub

    Private Sub cut_off_text_TextChanged(sender As Object, e As EventArgs) Handles cut_off_text.Leave
        cut_off_text.Text = cut_off_text.Text.ToUpper()
    End Sub

    Private Sub periode_stock_SelectedIndexChanged(sender As Object, e As EventArgs) Handles periode_stock.Leave
        If periode_stock.Text = "Stock Akhir bulan (Last Month)" Then
            cut_off_text.Enabled = False
        Else
            cut_off_text.Enabled = True
        End If
    End Sub

    Private Sub periode_stock_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles periode_stock.SelectedIndexChanged
        If periode_stock.Text = "Stock Awal Bulan (This Month)" Then
            cut_off_text.Enabled = True
        Else
            cut_off_text.Enabled = False
            cut_off_text.Text = ""
        End If
    End Sub

    Private Sub cut_off_text_TextChanged_1(sender As Object, e As EventArgs) Handles cut_off_text.Leave
        If cut_off_text.Text <> "" Then

            If cut_off_text.Text.Contains("-") Then
                Try
                    cut_off_text.Text = Date.Parse(cut_off_text.Text).ToString("dd-MMM-yy")
                    cut_off_text.Text = cut_off_text.Text.ToUpper
                Catch ex As Exception
                    MsgBox("FORMAT TANGGAL TIDAK SESUAI!")
                    cut_off_text.Text = ""
                End Try
            Else
                MsgBox("FORMAT TANGGAL TIDAK SESUAI!")
            End If

        Else

        End If
    End Sub

    Private Sub tahun_text_TextChanged(sender As Object, e As EventArgs) Handles tahun_text.Leave
        If tahun_text.Text <> "" And tahun_text.Text.Length = 4 Then
            Try
                Dim date__ As New Date(CInt(tahun_text.Text), 1, 1)
            Catch ex As Exception
                MsgBox("FORMAT TANGGAL TIDAK SESUAI!")
                tahun_text.Text = ""
            End Try
        Else
            MsgBox("FORMAT TANGGAL TIDAK SESUAI!")
            tahun_text.Text = ""
        End If
    End Sub

End Class