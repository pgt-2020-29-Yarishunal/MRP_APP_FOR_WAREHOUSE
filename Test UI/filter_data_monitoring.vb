Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class filter_data_monitoring
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Dim con As New MySqlConnection(db)
    Dim data1 As New monitoring
    Dim kate_ As String = data1.jenis_item.ToString
    Private Sub filter_data_monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.Text = String.Empty
        Me.DoubleBuffered = True
        teks_est.Enabled = False
        teks_in_wh.Enabled = False
        teks_item_cd.Enabled = False
        teks_pcs.Enabled = False
        teks_polos.Enabled = False
        teks_pp.Enabled = False
        teks_sticker.Enabled = False
        teks_stock.Enabled = False
        teks_stock_out.Enabled = False
        combo_est.Enabled = False
        combo_in_wh.Enabled = False
        combo_item_cd.Enabled = False
        combo_pcs.Enabled = False
        combo_polos.Enabled = False
        combo_pp.Enabled = False
        combo_status.Enabled = False
        combo_sticker.Enabled = False
        combo_stock.Enabled = False
        combo_stock_out.Enabled = False
        Button2.Enabled = False

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If teks_item_cd.Text <> String.Empty Then
            combo_item_cd.Items.Add(teks_item_cd.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim filename1 As String
            With SaveFileDialog1
                .Filter = "Excel Office| *.xls;*.xlsx"
                .ShowDialog()
                filename1 = .FileName
            End With
            file_direktori.Text = filename1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub check_all_CheckedChanged(sender As Object, e As EventArgs) Handles check_all.CheckedChanged
        If check_all.Checked Then
            check_est.CheckState = CheckState.Unchecked
            check_in_wh.CheckState = CheckState.Unchecked
            check_pcs.CheckState = CheckState.Unchecked
            check_polos.CheckState = CheckState.Unchecked
            check_prodplan.CheckState = CheckState.Unchecked
            check_status.CheckState = CheckState.Unchecked
            check_sticker.CheckState = CheckState.Unchecked
            check_stock.CheckState = CheckState.Unchecked
            check_stock_out.CheckState = CheckState.Unchecked
            item_cd.CheckState = CheckState.Unchecked
            check_est.Enabled = False
            check_in_wh.Enabled = False
            check_pcs.Enabled = False
            check_polos.Enabled = False
            check_prodplan.Enabled = False
            check_status.Enabled = False
            check_sticker.Enabled = False
            check_stock.Enabled = False
            check_stock_out.Enabled = False
            item_cd.Enabled = False
        Else
            check_est.Enabled = True
            check_in_wh.Enabled = True
            check_pcs.Enabled = True
            check_polos.Enabled = True
            check_prodplan.Enabled = True
            check_status.Enabled = True
            check_sticker.Enabled = True
            check_stock.Enabled = True
            check_stock_out.Enabled = True
            item_cd.Enabled = True
        End If
    End Sub

    Private Sub check_prodplan_CheckedChanged(sender As Object, e As EventArgs) Handles check_prodplan.CheckedChanged
        If check_prodplan.Checked Then
            combo_pp.Enabled = True
            teks_pp.Enabled = True
        Else
            teks_pp.Text = "0"
            combo_pp.Text = String.Empty
            combo_pp.Enabled = False
            teks_pp.Enabled = False
        End If
    End Sub

    Private Sub check_pcs_CheckedChanged(sender As Object, e As EventArgs) Handles check_pcs.CheckedChanged
        If check_pcs.Checked Then
            combo_pcs.Enabled = True
            teks_pcs.Enabled = True
        Else
            combo_pcs.Text = String.Empty
            teks_pcs.Text = "0"
            combo_pcs.Enabled = False
            teks_pcs.Enabled = False
        End If
    End Sub

    Private Sub check_in_wh_CheckedChanged(sender As Object, e As EventArgs) Handles check_in_wh.CheckedChanged
        If check_in_wh.Checked Then
            combo_in_wh.Enabled = True
            teks_in_wh.Enabled = True
        Else
            combo_in_wh.Text = String.Empty
            teks_in_wh.Text = "0"
            combo_in_wh.Enabled = False
            teks_in_wh.Enabled = False
        End If
    End Sub

    Private Sub check_polos_CheckedChanged(sender As Object, e As EventArgs) Handles check_polos.CheckedChanged
        If check_polos.Checked Then
            combo_polos.Enabled = True
            teks_polos.Enabled = True
        Else
            combo_polos.Text = String.Empty
            teks_polos.Text = "0"
            combo_polos.Enabled = False
            teks_polos.Enabled = False
        End If
    End Sub

    Private Sub check_sticker_CheckedChanged(sender As Object, e As EventArgs) Handles check_sticker.CheckedChanged
        If check_sticker.Checked Then
            combo_sticker.Enabled = True
            teks_sticker.Enabled = True
        Else
            combo_sticker.Text = String.Empty
            teks_sticker.Text = "0"
            combo_sticker.Enabled = False
            teks_sticker.Enabled = False
        End If
    End Sub

    Private Sub check_stock_CheckedChanged(sender As Object, e As EventArgs) Handles check_stock.CheckedChanged
        If check_stock.Checked Then
            combo_stock.Enabled = True
            teks_stock.Enabled = True
        Else
            combo_stock.Text = String.Empty
            teks_stock.Text = "0"
            combo_stock.Enabled = False
            teks_stock.Enabled = False
        End If
    End Sub

    Private Sub check_stock_out_CheckedChanged(sender As Object, e As EventArgs) Handles check_stock_out.CheckedChanged
        If check_stock_out.Checked Then
            combo_stock_out.Enabled = True
            teks_stock_out.Enabled = True
        Else
            combo_stock_out.Text = String.Empty
            teks_stock_out.Text = "0"
            combo_stock_out.Enabled = False
            teks_stock_out.Enabled = False
        End If
    End Sub

    Private Sub check_est_CheckedChanged(sender As Object, e As EventArgs) Handles check_est.CheckedChanged
        If check_est.Checked Then
            combo_est.Enabled = True
            teks_est.Enabled = True
        Else
            combo_est.Text = String.Empty
            teks_est.Text = "0"
            combo_est.Enabled = False
            teks_est.Enabled = False
        End If
    End Sub

    Private Sub check_status_CheckedChanged(sender As Object, e As EventArgs) Handles check_status.CheckedChanged
        If check_status.Checked Then
            combo_status.Enabled = True
        Else
            combo_status.Text = String.Empty
            combo_status.Enabled = False
        End If
    End Sub

    Private Sub item_cd_CheckedChanged(sender As Object, e As EventArgs) Handles item_cd.CheckedChanged
        If item_cd.Checked Then
            combo_item_cd.Enabled = True
            teks_item_cd.Enabled = True
            Button2.Enabled = True
            check_est.CheckState = CheckState.Unchecked
            check_in_wh.CheckState = CheckState.Unchecked
            check_pcs.CheckState = CheckState.Unchecked
            check_polos.CheckState = CheckState.Unchecked
            check_prodplan.CheckState = CheckState.Unchecked
            check_status.CheckState = CheckState.Unchecked
            check_sticker.CheckState = CheckState.Unchecked
            check_stock.CheckState = CheckState.Unchecked
            check_stock_out.CheckState = CheckState.Unchecked
            check_all.Enabled = False
            check_est.Enabled = False
            check_in_wh.Enabled = False
            check_pcs.Enabled = False
            check_polos.Enabled = False
            check_prodplan.Enabled = False
            check_status.Enabled = False
            check_sticker.Enabled = False
            check_stock.Enabled = False
            check_stock_out.Enabled = False
        Else
            combo_item_cd.Text = String.Empty
            combo_item_cd.Items.Clear()
            teks_item_cd.Text = String.Empty
            check_all.Enabled = True
            combo_item_cd.Enabled = False
            teks_item_cd.Enabled = False
            Button2.Enabled = False
            check_est.Enabled = True
            check_in_wh.Enabled = True
            check_pcs.Enabled = True
            check_polos.Enabled = True
            check_prodplan.Enabled = True
            check_status.Enabled = True
            check_sticker.Enabled = True
            check_stock.Enabled = True
            check_stock_out.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim list_item_cd As New List(Of String)
        For Each cd In combo_item_cd.Items
            list_item_cd.Add(cd)
        Next
        Try
            ''inisiasi file excel
            Dim file As String = file_direktori.Text
            Dim oexcel As Object
            oexcel = CreateObject("Excel.Application")
            Dim obook As Excel.Workbook
            Dim osheet As Excel.Worksheet
            obook = oexcel.WorkBooks.Add
            osheet = oexcel.Worksheets(1)
            osheet.Name = "MONITORING"
            Dim baris As Integer = 3

            ''BIKIN HEADER

            osheet.Range("B" & baris.ToString).Value = "No."
            osheet.Range("C" & baris.ToString).Value = "Item Code"
            osheet.Range("D" & baris.ToString).Value = "Deskripsi"
            osheet.Range("E" & baris.ToString).Value = "Prodplan"
            osheet.Range("F" & baris.ToString).Value = "Pcs/Day"
            osheet.Range("G" & baris.ToString).Value = "In Warehouse"
            osheet.Range("H" & baris.ToString).Value = "Over Prodplan"
            osheet.Range("I" & baris.ToString).Value = "Stock Polos Gudang Ban"
            osheet.Range("J" & baris.ToString).Value = "Stock Sticker Gudang Ban"
            osheet.Range("K" & baris.ToString).Value = "Stock On Hand Gudang Bahan"
            osheet.Range("L" & baris.ToString).Value = "Stock Out Gudang Bahan"
            osheet.Range("M" & baris.ToString).Value = "Estimasi Habis (Hari)"
            osheet.Range("N" & baris.ToString).Value = "Status"

            If item_cd.Checked Then

                Dim no As Integer = 1

                For i = 0 To list_item_cd.Count - 1
                    baris += 1
                    Dim adpt As New MySqlDataAdapter("select * from data_master where jenis = '" & kate_ & "' AND item_code ='" & list_item_cd(i) & "'", con)
                    Dim ds As New DataSet
                    Dim tbb As New DataTable
                    adpt.Fill(ds, "emp")
                    adpt.Fill(tbb)
                    Dim code As String, code_1 As String, desk As String, status As String
                    Dim prodplan As Integer, stock As Integer, stock_out As Integer, sticker_gd_ban As Integer, stock_polos As Integer, pcs_day As Integer
                    Dim in_days As Double, ovr_prod As Double
                    Dim total_fg As Integer = 0
                    ''ITEM CODE & DESKRIPSI
                    code = tbb(0)(1)
                    desk = tbb(0)(3)

                    ''ITEM FINISHED GOOD
                    Dim item_fg As String() = {tbb(0)(5), tbb(0)(6), tbb(0)(7), tbb(0)(8), tbb(0)(9)}

                    ''PRODPLAN
                    Dim adptr_qty_dmnd_bln_blkng As New MySqlDataAdapter("select * from demand where item_code = '" & code & "' AND bulan = '" & Format(Date.Now(), "MMMM").ToUpper.ToString() & "' ORDER BY revisi DESC", con)
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
                        Dim adptr_qty_in_wh As New MySqlDataAdapter("select * from in_wh where item_fg = '" & code_fg + "-1" & "' AND jenis = '" & kate_ & "';", con)
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
                    Dim adptr_data_gd_ban As New MySqlDataAdapter("select * from data_gd_ban where item_code = '" & code & "' AND jenis = '" & kate_ & "' AND bulan = '" & Format(Date.Now(), "MMMM").ToUpper.ToString() & "'", con)
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

                    ''OVER PRODUKSI
                    ovr_prod = (total_fg - prodplan) / prodplan

                    If prodplan = 0 Then



                    Else

                        If ovr_prod = 0 Or ovr_prod < 0 Then

                            osheet.Range("H" & baris.ToString).Value = "0%"

                        Else

                            osheet.Range("H" & baris.ToString).Value = CInt(ovr_prod) + "%"

                        End If

                    End If

                    ''FILL DATA TABEL

                    osheet.Range("B" & baris.ToString).Value = no
                    osheet.Range("C" & baris.ToString).Value = code
                    osheet.Range("D" & baris.ToString).Value = desk
                    osheet.Range("E" & baris.ToString).Value = prodplan
                    osheet.Range("F" & baris.ToString).Value = pcs_day
                    osheet.Range("G" & baris.ToString).Value = total_fg

                    osheet.Range("I" & baris.ToString).Value = stock_polos
                    osheet.Range("J" & baris.ToString).Value = sticker_gd_ban
                    osheet.Range("K" & baris.ToString).Value = stock
                    osheet.Range("L" & baris.ToString).Value = stock_out
                    osheet.Range("M" & baris.ToString).Value = in_days
                    osheet.Range("N" & baris.ToString).Value = status

                    no += 1
                    osheet.Range("B3" & ":M" & (baris.ToString)).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                    obook.Windows.Application.ActiveWindow.Zoom = 85
                    osheet.Range("B3" & ":M" & (baris.ToString)).EntireColumn.AutoFit()
                Next

            Else

                Dim adpt As New MySqlDataAdapter("select * from data_master where jenis = '" & kate_ & "'", con)
                Dim ds As New DataSet
                Dim tbb As New DataTable
                adpt.Fill(ds, "emp")
                adpt.Fill(tbb)
                Dim item As Integer = 0
                Dim no As Integer = 1
                Dim code As String, code_1 As String, desk As String, status As String
                Dim prodplan As Integer, stock As Integer, stock_out As Integer, sticker_gd_ban As Integer, stock_polos As Integer, pcs_day As Integer
                Dim in_days As Double
                While item < tbb.Rows.Count
                    Dim total_fg As Integer = 0
                    ''ITEM CODE & DESKRIPSI
                    code = tbb(item)(1)
                    desk = tbb(item)(3)

                    ''ITEM FINISHED GOOD
                    Dim item_fg As String() = {tbb(item)(5), tbb(item)(6), tbb(item)(7), tbb(item)(8), tbb(item)(9)}

                    ''PRODPLAN
                    Dim adptr_qty_dmnd_bln_blkng As New MySqlDataAdapter("select * from demand where item_code = '" & code & "' AND bulan = '" & Format(Date.Now(), "MMMM").ToUpper.ToString() & "' ORDER BY revisi DESC", con)
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
                        Dim adptr_qty_in_wh As New MySqlDataAdapter("select * from in_wh where item_fg = '" & code_fg + "-1" & "' AND jenis = '" & kate_ & "';", con)
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
                    Dim adptr_data_gd_ban As New MySqlDataAdapter("select * from data_gd_ban where item_code = '" & code & "' AND jenis = '" & kate_ & "' AND bulan = '" & Format(Date.Now(), "MMMM").ToUpper.ToString() & "'", con)
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

                    Dim list_variable() As Integer = {prodplan, pcs_day, total_fg, stock_polos, sticker_gd_ban, stock, stock_out, CInt(in_days)}
                    Dim list_eq() As String = {combo_pp.Text, combo_pcs.Text, combo_in_wh.Text, combo_polos.Text, combo_sticker.Text, combo_stock.Text, combo_stock_out.Text, combo_est.Text}
                    Dim list_teks() As Integer = {CInt(teks_pp.Text), CInt(teks_pcs.Text), CInt(teks_in_wh.Text), CInt(teks_polos.Text), CInt(teks_sticker.Text), CInt(teks_stock.Text), CInt(teks_stock_out.Text), CInt(teks_est.Text)}
                    Dim list_logic() As Boolean = {True, True, True, True, True, True, True, True, True}

                    If check_all.Checked Then
                        baris += 1

                        ''FILL DATA TABEL

                        osheet.Range("B" & baris.ToString).Value = no
                        osheet.Range("C" & baris.ToString).Value = code
                        osheet.Range("D" & baris.ToString).Value = desk
                        osheet.Range("E" & baris.ToString).Value = prodplan
                        osheet.Range("F" & baris.ToString).Value = pcs_day
                        osheet.Range("G" & baris.ToString).Value = total_fg

                        osheet.Range("I" & baris.ToString).Value = stock_polos
                        osheet.Range("J" & baris.ToString).Value = sticker_gd_ban
                        osheet.Range("K" & baris.ToString).Value = stock
                        osheet.Range("L" & baris.ToString).Value = stock_out
                        osheet.Range("M" & baris.ToString).Value = in_days
                        osheet.Range("N" & baris.ToString).Value = status
                        no += 1
                        osheet.Range("B3" & ":M" & (baris.ToString)).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                        obook.Windows.Application.ActiveWindow.Zoom = 85
                        osheet.Range("B3" & ":M" & (baris.ToString)).EntireColumn.AutoFit()
                    Else

                        For jumlh = 0 To list_logic.Count - 2
                            Try
                                If list_eq(jumlh) = "EQUAL" Then
                                    If list_variable(jumlh) <> list_teks(jumlh) Then
                                        list_logic(jumlh) = False
                                    End If
                                ElseIf list_eq(jumlh) = "LESS THAN" Then
                                    If list_variable(jumlh) > list_teks(jumlh) Or list_variable(jumlh) = list_teks(jumlh) Then
                                        list_logic(jumlh) = False
                                    End If
                                ElseIf list_eq(jumlh) = "MORE THAN" Then
                                    If list_variable(jumlh) < list_teks(jumlh) Or list_variable(jumlh) = list_teks(jumlh) Then
                                        list_logic(jumlh) = False
                                    End If
                                End If
                            Catch ex As Exception
                                list_logic(jumlh) = False
                            End Try
                        Next

                        If check_status.Checked Then
                            If combo_status.Text <> status Then
                                list_logic(8) = False
                            End If
                        End If

                        If list_logic.Contains(False) Then
                        Else
                            baris += 1

                            ''FILL DATA TABEL

                            osheet.Range("B" & baris.ToString).Value = no
                            osheet.Range("C" & baris.ToString).Value = code
                            osheet.Range("D" & baris.ToString).Value = desk
                            osheet.Range("E" & baris.ToString).Value = prodplan
                            osheet.Range("F" & baris.ToString).Value = pcs_day
                            osheet.Range("G" & baris.ToString).Value = total_fg

                            osheet.Range("I" & baris.ToString).Value = stock_polos
                            osheet.Range("J" & baris.ToString).Value = sticker_gd_ban
                            osheet.Range("K" & baris.ToString).Value = stock
                            osheet.Range("L" & baris.ToString).Value = stock_out
                            osheet.Range("M" & baris.ToString).Value = in_days
                            osheet.Range("N" & baris.ToString).Value = status
                            no += 1
                            osheet.Range("B3" & ":M" & (baris.ToString)).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
                            obook.Windows.Application.ActiveWindow.Zoom = 85
                            osheet.Range("B3" & ":M" & (baris.ToString)).EntireColumn.AutoFit()
                        End If
                    End If
                    item += 1
                End While

            End If

            ''save file
            obook.SaveAs(file)
            obook.Close()
            obook = Nothing
            oexcel.quit()
            oexcel = Nothing
            MessageBox.Show("File Telah Dibuat")
        Catch ex As Exception
            MessageBox.Show("File Gagal Dibuat" + " | " + ex.ToString)
        End Try
    End Sub
End Class