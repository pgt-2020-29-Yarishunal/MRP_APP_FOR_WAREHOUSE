Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class monitoring
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Public Shared jenis_item As String
    Dim con As New MySqlConnection(db)
    Dim tahun_ini As String = Format(Date.Now(), "yyyy").ToString()
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If jeniss.Text.ToString = "" Then
            MsgBox("Mohon pilih kategori item terlebih dahulu!")
            Return
        Else

            Dim adpt As New MySqlDataAdapter("select * from data_master where jenis = '" & jeniss.Text.ToString & "'", con)
            Dim ds As New DataSet
            Dim tbb As New DataTable
            adpt.Fill(ds, "emp")
            adpt.Fill(tbb)
            If tbb.Rows.Count > 0 Then
                jenis_item = jeniss.Text.ToString
                Dim new_form = New filter_data_monitoring
                new_form.Show()
            Else
                MsgBox("Kategori item tidak ada di database!")
                Return
            End If

        End If


    End Sub

    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If jeniss.Text.ToString = "" Then
            MsgBox("Mohon pilih kategori item terlebih dahulu!")
            Return
        Else

            Dim adpt As New MySqlDataAdapter("select * from data_master where jenis = '" & jeniss.Text.ToString & "'", con)
            Dim ds As New DataSet
            Dim tbb As New DataTable
            adpt.Fill(ds, "emp")
            adpt.Fill(tbb)
            If tbb.Rows.Count() > 0 Then
                jenis_item = jeniss.Text.ToString
                Dim new_form = New filter_data__outstanding
                new_form.Show()
            Else
                MsgBox("Kategori item tidak ada di database!")
                Return
            End If

        End If


    End Sub


    Private Sub dataa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataa.CellContentClick
        Dim row As DataGridViewRow
        If e.RowIndex < 0 Then
            Return
        Else
            row = dataa.Rows(e.RowIndex)
        End If

        Dim status_prodplan As String
        Dim jmlh_over As Integer
        Dim prsc_over As Double

        If row.Cells(2).Value < row.Cells(4).Value Then
            status_prodplan = "OVER"
            jmlh_over = CInt(row.Cells(4).Value) - CInt(row.Cells(2).Value)
            If CInt(row.Cells(2).Value) = 0 Then
                prsc_over = 0
            Else
                prsc_over = ((jmlh_over) / CInt(row.Cells(2).Value)) * 100
            End If
        Else
            status_prodplan = "AMAN"
            jmlh_over = 0
            prsc_over = 0
        End If

        label_jmlh_over.Text = CStr(jmlh_over)
        label_knds_prod.Text = status_prodplan
        label_prsc_over.Text = CStr(prsc_over) + "%"
        label_tgl_shortg.Text = Format(Date.Now().AddDays(CInt(row.Cells(9).Value.ToString)), "dd-MMM-y")

        data_outs.Rows.Clear()

        Dim adpt2 As New MySqlDataAdapter("select * from outstanding where item_code = '" & row.Cells(0).Value & "'", con)
        Dim ds2 As New DataSet
        Dim tbb2 As New DataTable
        adpt2.Fill(ds2, "emp2")
        adpt2.Fill(tbb2)
        If tbb2.Rows.Count() > 0 Then
            For i = 0 To tbb2.Rows.Count() - 1
                data_outs.Rows.Add(tbb2(i)(2), tbb2(i)(3), tbb2(i)(4), tbb2(i)(5))
            Next
        End If
    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim adpt_master As New MySqlDataAdapter("select * from data_master where jenis = '" & jeniss.Text.ToString & "'", con)
        Dim ds_master As New DataSet
        Dim tbb_master As New DataTable
        adpt_master.Fill(ds_master, "emp_master")
        adpt_master.Fill(tbb_master)
        If tbb_master.Rows.Count > 0 Then
        Else
            MsgBox("Kategori item tidak ada di database!")
            Return
        End If

        Dim teks_ket As String = ""
        jenis_item = jeniss.Text.ToString

        Dim adpt_daily As New MySqlDataAdapter("select * from histori_report", con)
        Dim ds_daily As New DataSet
        Dim tbb_daily As New DataTable
        adpt_daily.Fill(ds_daily, "emp_daily")
        adpt_daily.Fill(tbb_daily)

        Dim adpt_demand As New MySqlDataAdapter("select * from list_demand where jenis = '" & jeniss.Text.ToString & "' and bulan = '" & Format(Date.Now, "MMMM").ToUpper & "' and tahun = '" & tahun_ini & "'", con)
        Dim ds_demand As New DataSet
        Dim tbb_demand As New DataTable
        adpt_demand.Fill(ds_demand, "emp_demand")
        adpt_demand.Fill(tbb_demand)

        Dim adpt_stck_gd As New MySqlDataAdapter("select * from data_gd_ban where jenis = '" & jeniss.Text.ToString & "' and bulan = '" & Format(Date.Now, "MMMM").ToUpper & "'", con)
        Dim ds_stck_gd As New DataSet
        Dim tbb_stck_gd As New DataTable
        adpt_stck_gd.Fill(ds_stck_gd, "emp_stck_gd")
        adpt_stck_gd.Fill(tbb_stck_gd)

        If tbb_daily.Rows.Count > 0 Then

            If Format(Date.Parse(tbb_daily(0)(0)), "dd-MMMM-yy") <> Format(Date.Now, "dd-MMMM-yy") Then

                If teks_ket = "" Then
                    teks_ket += "Warning! Stock daily tidak terupdate"
                Else
                    teks_ket += " - Stock daily tidak terupdate"
                End If

            End If

            If Format(Date.Parse(tbb_daily(0)(4)), "dd-MMMM-yy") <> Format(Date.Now, "dd-MMMM-yy") Then

                If teks_ket = "" Then
                    teks_ket += "Warning! Data In Warehouse tidak terupdate"
                Else
                    teks_ket += " - Data In Warehouse tidak terupdate"
                End If

            End If

        End If

        If tbb_demand.Rows.Count < 1 Then

            If teks_ket = "" Then
                teks_ket += "Warning! Data Demand tidak terupdate"
            Else
                teks_ket += " - Data Demand tidak terupdate"
            End If

        End If

        If tbb_stck_gd.Rows.Count < 1 Then

            If teks_ket = "" Then
                teks_ket += "Warning! Data Gudang Ban tidak terupdate"
            Else
                teks_ket += " - Data Gudang Ban tidak terupdate"
            End If

        End If

        Label10.Text = teks_ket
        dataa.Rows.Clear()

        Dim adpt As New MySqlDataAdapter("select * from data_master where jenis = '" & jeniss.Text.ToString & "'", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)
        Dim item As Integer = 0
        Dim code As String, code_1 As String, desk As String, status As String
        Dim prodplan As Integer, stock As Integer, stock_out As Integer, sticker_gd_ban As Integer, stock_polos As Integer, pcs_day As Integer
        Dim in_days As Double
        If tbb.Rows.Count > 0 Then
            While item < tbb.Rows.Count
                Dim total_fg As Integer = 0
                ''ITEM CODE & DESKRIPSI
                code = tbb(item)(1)
                desk = tbb(item)(3)

                ''ITEM FINISHED GOOD
                Dim item_fg As String() = {tbb(item)(5), tbb(item)(6), tbb(item)(7), tbb(item)(8), tbb(item)(9)}

                ''PRODPLAN
                Dim adptr_qty_dmnd_bln_blkng As New MySqlDataAdapter("select * from demand where item_code = '" & code & "' AND bulan = '" & Format(Date.Now(), "MMMM").ToUpper.ToString() & "' AND tahun = '" & tahun_ini & "' ORDER BY revisi DESC", con)
                Dim qty_bln_dmnd As New DataSet
                Dim qty_data_bln_dmnd As New DataTable
                adptr_qty_dmnd_bln_blkng.Fill(qty_bln_dmnd, "qty_bln_dmnd")
                adptr_qty_dmnd_bln_blkng.Fill(qty_data_bln_dmnd)
                If qty_data_bln_dmnd.Rows.Count > 0 Then
                    prodplan = qty_data_bln_dmnd(0)(2)
                    pcs_day = qty_data_bln_dmnd(0)(7)
                Else
                    prodplan = 0
                    pcs_day = 0
                End If

                ''IN WH
                For Each code_fg In item_fg
                    Dim adptr_qty_in_wh As New MySqlDataAdapter("select * from in_wh where item_fg = '" & code_fg + "-1" & "' AND jenis = '" & jeniss.Text.ToString & "';", con)
                    Dim qty_in_wh As New DataSet
                    Dim qty_data_in_wh As New DataTable
                    adptr_qty_in_wh.Fill(qty_in_wh, "qty_in_wh_")
                    adptr_qty_in_wh.Fill(qty_data_in_wh)
                    If qty_data_in_wh.Rows.Count > 0 Then
                        total_fg += qty_data_in_wh(0)(1)
                    Else
                        total_fg += 0
                    End If
                Next

                ''STOCK GUDANG BAHAN
                Dim adptr_qty_stock As New MySqlDataAdapter("select * from stock where item_code = '" & code & "'", con)
                Dim qty_stock As New DataSet
                Dim qty_data_stock As New DataTable
                adptr_qty_stock.Fill(qty_stock, "qty_stock")
                adptr_qty_stock.Fill(qty_data_stock)
                If qty_data_stock.Rows.Count > 0 Then
                    stock = qty_data_stock(0)(4)
                    stock_out = qty_data_stock(0)(3)
                Else
                    stock = 0
                    stock_out = 0
                End If

                ''DATA GUDANG BAN (AWAL BULAN)
                Dim adptr_data_gd_ban As New MySqlDataAdapter("select * from data_gd_ban where item_code = '" & code & "' AND jenis = '" & jeniss.Text.ToString & "' AND bulan = '" & Format(Date.Now(), "MMMM").ToUpper.ToString() & "'", con)
                Dim qty_data_gd_ban As New DataSet
                Dim qty_data_stock_gd_ban As New DataTable
                adptr_data_gd_ban.Fill(qty_data_gd_ban, "qty_gd_ban")
                adptr_data_gd_ban.Fill(qty_data_stock_gd_ban)
                If qty_data_stock_gd_ban.Rows.Count > 0 Then
                    sticker_gd_ban = qty_data_stock_gd_ban(0)(1)
                    stock_polos = qty_data_stock_gd_ban(0)(2)
                Else
                    sticker_gd_ban = 0
                    stock_polos = 0
                End If

                ''IN DAYS
                If prodplan > 0 And pcs_day > 0 Then
                    in_days = stock / pcs_day
                Else
                    in_days = 0
                End If

                ''STICKER VS TIRE
                If prodplan + stock_polos + stock_out - sticker_gd_ban < 0 Then
                    status = "OVER"
                ElseIf prodplan + stock_polos + stock_out - sticker_gd_ban = 0 Then
                    status = "TERPENUHI"
                Else
                    status = "BELUM TERPENUHI"
                End If

                dataa.Rows.Add(code, desk, prodplan, pcs_day, total_fg, stock_polos, sticker_gd_ban, stock, stock_out, CInt(in_days), status)

                item += 1
            End While
        Else
            MsgBox("DATA TIDAK DITEMUKAN!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim teks_ket As String = ""

        Dim adpt_daily As New MySqlDataAdapter("select * from histori_report", con)
        Dim ds_daily As New DataSet
        Dim tbb_daily As New DataTable
        adpt_daily.Fill(ds_daily, "emp_daily")
        adpt_daily.Fill(tbb_daily)

        Dim adpt_demand As New MySqlDataAdapter("select * from list_demand where jenis = '" & jeniss.Text.ToString & "' and bulan = '" & Format(Date.Now, "MMMM").ToUpper & "' tahun = '" & tahun_ini & "' ", con)
        Dim ds_demand As New DataSet
        Dim tbb_demand As New DataTable
        adpt_demand.Fill(ds_demand, "emp_demand")
        adpt_demand.Fill(tbb_demand)

        Dim adpt_stck_gd As New MySqlDataAdapter("select * from data_gd_ban where jenis = '" & jeniss.Text.ToString & "' and bulan = '" & Format(Date.Now, "MMMM").ToUpper & "'", con)
        Dim ds_stck_gd As New DataSet
        Dim tbb_stck_gd As New DataTable
        adpt_stck_gd.Fill(ds_stck_gd, "emp_stck_gd")
        adpt_stck_gd.Fill(tbb_stck_gd)

        If tbb_daily.Rows.Count > 0 Then

            If Format(Date.Parse(tbb_daily(0)(0)), "dd-MMMM-yy") <> Format(Date.Now, "dd-MMMM-yy") Then

                If teks_ket = "" Then
                    teks_ket += "Warning! Stock daily tidak terupdate"
                Else
                    teks_ket += " - Stock daily tidak terupdate"
                End If

            End If

            If Format(Date.Parse(tbb_daily(0)(4)), "dd-MMMM-yy") <> Format(Date.Now, "dd-MMMM-yy") Then

                If teks_ket = "" Then
                    teks_ket += "Warning! Data In Warehouse tidak terupdate"
                Else
                    teks_ket += " - Data In Warehouse tidak terupdate"
                End If

            End If

        End If

        If tbb_demand.Rows.Count < 1 Then

            If teks_ket = "" Then
                teks_ket += "Warning! Data Demand tidak terupdate"
            Else
                teks_ket += " - Data Demand tidak terupdate"
            End If

        End If

        If tbb_stck_gd.Rows.Count < 1 Then

            If teks_ket = "" Then
                teks_ket += "Warning! Data Gudang Ban tidak terupdate"
            Else
                teks_ket += " - Data Gudang Ban tidak terupdate"
            End If

        End If

        Label10.Text = teks_ket

        dataa.Rows.Clear()

        Dim adpt As New MySqlDataAdapter("select * from data_master where jenis = '" & jeniss.Text.ToString & "' AND item_code = '" & teks_item_code.Text.ToString & "'", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)
        Dim item As Integer = 0
        Dim code As String, code_1 As String, desk As String, status As String
        Dim prodplan As Integer, stock As Integer, stock_out As Integer, sticker_gd_ban As Integer, stock_polos As Integer, pcs_day As Integer
        Dim in_days As Double
        If tbb.Rows.Count > 0 Then
            While item < tbb.Rows.Count
                Dim total_fg As Integer = 0
                ''ITEM CODE & DESKRIPSI
                code = tbb(item)(1)
                desk = tbb(item)(3)

                ''ITEM FINISHED GOOD
                Dim item_fg As String() = {tbb(item)(5), tbb(item)(6), tbb(item)(7), tbb(item)(8), tbb(item)(9)}

                ''PRODPLAN
                Dim adptr_qty_dmnd_bln_blkng As New MySqlDataAdapter("select * from demand where item_code = '" & code & "' AND bulan = '" & Format(Date.Now(), "MMMM").ToUpper.ToString() & "' and tahun = '" & tahun_ini & "' ORDER BY revisi DESC", con)
                Dim qty_bln_dmnd As New DataSet
                Dim qty_data_bln_dmnd As New DataTable
                adptr_qty_dmnd_bln_blkng.Fill(qty_bln_dmnd, "qty_bln_dmnd")
                adptr_qty_dmnd_bln_blkng.Fill(qty_data_bln_dmnd)
                If qty_data_bln_dmnd.Rows.Count > 0 Then
                    prodplan = qty_data_bln_dmnd(0)(2)
                    pcs_day = qty_data_bln_dmnd(0)(7)
                Else
                    prodplan = 0
                    pcs_day = 0
                End If

                ''IN WH
                For Each code_fg In item_fg
                    Dim adptr_qty_in_wh As New MySqlDataAdapter("select * from in_wh where item_fg = '" & code_fg + "-1" & "' AND jenis = '" & jeniss.Text.ToString & "';", con)
                    Dim qty_in_wh As New DataSet
                    Dim qty_data_in_wh As New DataTable
                    adptr_qty_in_wh.Fill(qty_in_wh, "qty_in_wh_")
                    adptr_qty_in_wh.Fill(qty_data_in_wh)
                    If qty_data_in_wh.Rows.Count > 0 Then
                        total_fg += qty_data_in_wh(0)(1)
                    Else
                        total_fg += 0
                    End If
                Next

                ''STOCK GUDANG BAHAN
                Dim adptr_qty_stock As New MySqlDataAdapter("select * from stock where item_code = '" & code & "'", con)
                Dim qty_stock As New DataSet
                Dim qty_data_stock As New DataTable
                adptr_qty_stock.Fill(qty_stock, "qty_stock")
                adptr_qty_stock.Fill(qty_data_stock)
                If qty_data_stock.Rows.Count > 0 Then
                    stock = qty_data_stock(0)(4)
                    stock_out = qty_data_stock(0)(3)
                Else
                    stock = 0
                    stock_out = 0
                End If

                ''DATA GUDANG BAN (AWAL BULAN)
                Dim adptr_data_gd_ban As New MySqlDataAdapter("select * from data_gd_ban where item_code = '" & code & "' AND jenis = '" & jeniss.Text.ToString & "' AND bulan = '" & Format(Date.Now(), "MMMM").ToUpper.ToString() & "'", con)
                Dim qty_data_gd_ban As New DataSet
                Dim qty_data_stock_gd_ban As New DataTable
                adptr_data_gd_ban.Fill(qty_data_gd_ban, "qty_gd_ban")
                adptr_data_gd_ban.Fill(qty_data_stock_gd_ban)
                If qty_data_stock_gd_ban.Rows.Count > 0 Then
                    sticker_gd_ban = qty_data_stock_gd_ban(0)(1)
                    stock_polos = qty_data_stock_gd_ban(0)(2)
                Else
                    sticker_gd_ban = 0
                    stock_polos = 0
                End If

                ''IN DAYS
                If prodplan > 0 And pcs_day > 0 Then
                    in_days = stock / pcs_day
                Else
                    in_days = 0
                End If

                ''STICKER VS TIRE
                If prodplan + stock_polos + stock_out - sticker_gd_ban < 0 Then
                    status = "OVER"
                ElseIf prodplan + stock_polos + stock_out - sticker_gd_ban = 0 Or prodplan + stock_polos + stock_out - sticker_gd_ban - stock < 0 Then
                    status = "TERPENUHI"
                Else
                    status = "BELUM TERPENUHI"
                End If

                dataa.Rows.Add(code, desk, prodplan, pcs_day, total_fg, stock_polos, sticker_gd_ban, stock, stock_out, CInt(in_days), status)

                item += 1
            End While
        Else
            MsgBox("DATA TIDAK DITEMUKAN!")
        End If
    End Sub

    Private Sub monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adpt As New MySqlDataAdapter("select * from kategori", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)
        For i = 0 To tbb.Rows.Count - 1
            jeniss.Items.Add(tbb(i)(1))
        Next
    End Sub
End Class