Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class create_mrp
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Dim con As New MySqlConnection(db)
    Dim tahun_ini As String = Format(Date.Now(), "yyyy").ToString()

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles name_month_now.Click
        If month_now.Text.ToString = "" Then
            MsgBox("Mohon isi Bulan untuk kebutuhan Periode 1!")
            Return
        Else
        End If
    End Sub

    Private Sub create_mrp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Tambah kategori ke List KATEGORI ITEM
        Dim adpt As New MySqlDataAdapter("select * from kategori", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)
        For i = 0 To tbb.Rows.Count - 1
            jeniss.Items.Add(tbb(i)(1))
        Next

        tahun_this_month.Text = tahun_ini
        tahun_next_month.Text = tahun_ini
        tahun_next_month1.Text = tahun_ini
        demand_1.CheckState = CheckState.Unchecked
        demand_2.CheckState = CheckState.Unchecked
        name_month_next1.Enabled = False
        month_next1.Enabled = False
        tahun_next_month1.Enabled = False
        name_month_next.Enabled = False
        month_next.Enabled = False
        tahun_next_month.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim list_logic() As Boolean = {True, True, True, True, True, True}

        Dim adpt_stck As New MySqlDataAdapter("select * from histori_report", con)
        Dim ds_stck As New DataSet
        Dim tbb_stck As New DataTable
        adpt_stck.Fill(ds_stck, "emp_stck")
        adpt_stck.Fill(tbb_stck)

        '' START CHECK ROW DATABASE

        Dim adpt_pro As New MySqlDataAdapter("select * from pr_po where bulan = '" & Format(Date.Now, "MMMM").ToUpper & "'", con)
        Dim ds_pro As New DataSet
        Dim tbb_pro As New DataTable
        adpt_pro.Fill(ds_pro, "emp_pro")
        adpt_pro.Fill(tbb_pro)

        Dim adpt_sche As New MySqlDataAdapter("select * from list_demand where jenis = '" & jeniss.Text.ToString() & "' AND bulan = '" & month_now.Text & "' and revisi = '" & name_month_now.Text & "' and tahun = '" & tahun_this_month.Text.ToString & "'", con)
        Dim ds_sche As New DataSet
        Dim tbb_sche As New DataTable
        adpt_sche.Fill(ds_sche, "emp_sche")
        adpt_sche.Fill(tbb_sche)

        Dim adpt_sche1 As New MySqlDataAdapter("select * from list_demand where jenis = '" & jeniss.Text.ToString() & "' AND bulan = '" & month_next.Text & "' and revisi = '" & name_month_next.Text & "' and tahun = '" & tahun_next_month.Text.ToString & "' ", con)
        Dim ds_sche1 As New DataSet
        Dim tbb_sche1 As New DataTable
        adpt_sche1.Fill(ds_sche1, "emp_sche1")
        adpt_sche1.Fill(tbb_sche1)

        Dim adpt_sche2 As New MySqlDataAdapter("select * from list_demand where jenis = '" & jeniss.Text.ToString() & "' AND bulan = '" & month_next1.Text & "' and revisi = '" & name_month_next1.Text & "' and tahun = '" & tahun_next_month1.Text.ToString & "'", con)
        Dim ds_sche2 As New DataSet
        Dim tbb_sche2 As New DataTable
        adpt_sche2.Fill(ds_sche2, "emp_sche2")
        adpt_sche2.Fill(tbb_sche2)

        '' END CHECK BARIS

        If jeniss.Text = "" Then
            MsgBox("Mohon isi Kategori item!!")
            list_logic(0) = False
        Else

            If demand_1.CheckState = CheckState.Checked Then


                If demand_2.CheckState = CheckState.Checked Then


                    If (month_next.Text = "" Or month_now.Text = "" Or name_month_now.Text = "" Or name_month_next.Text = "" Or tahun_this_month.Text = "" Or tahun_next_month.Text = "" Or month_next1.Text = "" Or name_month_next1.Text = "" Or tahun_next_month1.Text = "") Then
                        MsgBox("Mohon Lengkapi Data Terlebih Dahulu!")
                        list_logic(0) = False
                    Else
                        If Format(Date.Parse(tbb_stck(0)(1)), "dd-MMMM-yy") <> Format(Date.Now(), "dd-MMMM-yy") Then

                            Dim result = MessageBox.Show("Report Stock terakhir diupdate pada tanggal " & Format(Date.Parse(tbb_stck(0)(1)), "dd-MMM-y").ToString & ", ingin melanjutkan?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If result = DialogResult.Yes Then
                            Else
                                list_logic(0) = False
                            End If
                        End If
                        If Format(Date.Parse(tbb_stck(0)(5)), "dd-MMMM-yy") <> Format(Date.Now(), "dd-MMMM-yy") Then

                            Dim result = MessageBox.Show("Report Outstanding terakhir diupdate pada tanggal " & Format(Date.Parse(tbb_stck(0)(1)), "dd-MMM-y").ToString & ", ingin melanjutkan?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If result = DialogResult.Yes Then
                            Else
                                list_logic(1) = False
                            End If
                        End If
                        If tbb_pro.Rows.Count < 1 Then

                            Dim result = MessageBox.Show("Report PRPO belum diupdate pada bulan " & Format(Date.Now, "MMMM").ToUpper.ToString & ", ingin melanjutkan?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If result = DialogResult.Yes Then
                            Else
                                list_logic(2) = False
                            End If
                        End If
                        If month_now.Text <> "" And name_month_now.Text <> "" Then

                            If tbb_sche.Rows.Count < 0 Then
                                MessageBox.Show("Demand pada bulan " & month_now.Text & " " & name_month_now.Text & " belum terinput! Pembuatan MRP gagal. ")
                                list_logic(3) = False
                            Else
                            End If
                        End If
                        If month_next.Text <> "" And name_month_next.Text <> "" Then

                            If tbb_sche1.Rows.Count < 0 Then
                                MessageBox.Show("Demand pada bulan " & month_next.Text & " " & name_month_next.Text & " belum terinput! Pembuatan MRP gagal. ")
                                list_logic(4) = False
                            Else
                            End If
                        End If
                        If month_next1.Text <> "" And name_month_next1.Text <> "" Then

                            If tbb_sche2.Rows.Count < 0 Then
                                MessageBox.Show("Demand pada bulan " & month_next1.Text & " " & name_month_next1.Text & " belum terinput! Pembuatan MRP gagal. ")
                                list_logic(5) = False
                            Else
                            End If
                        End If
                    End If

                ElseIf demand_2.CheckState = CheckState.Unchecked Then

                    If (month_next.Text = "" Or month_now.Text = "" Or name_month_now.Text = "" Or name_month_next.Text = "" Or tahun_this_month.Text = "" Or tahun_next_month.Text = "") Then
                        MsgBox("Mohon Lengkapi Data Terlebih Dahulu!")
                        list_logic(0) = False
                    Else
                        If Format(Date.Parse(tbb_stck(0)(1)), "dd-MMMM-yy") <> Format(Date.Now(), "dd-MMMM-yy") Then

                            Dim result = MessageBox.Show("Report Stock terakhir diupdate pada tanggal " & Format(Date.Parse(tbb_stck(0)(1)), "dd-MMM-y").ToString & ", ingin melanjutkan?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If result = DialogResult.Yes Then
                            Else
                                list_logic(0) = False
                            End If
                        End If
                        If Format(Date.Parse(tbb_stck(0)(5)), "dd-MMMM-yy") <> Format(Date.Now(), "dd-MMMM-yy") Then

                            Dim result = MessageBox.Show("Report Outstanding terakhir diupdate pada tanggal " & Format(Date.Parse(tbb_stck(0)(1)), "dd-MMM-y").ToString & ", ingin melanjutkan?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If result = DialogResult.Yes Then
                            Else
                                list_logic(1) = False
                            End If
                        End If
                        If tbb_pro.Rows.Count < 1 Then

                            Dim result = MessageBox.Show("Report PRPO belum diupdate pada bulan " & Format(Date.Now, "MMMM").ToUpper.ToString & ", ingin melanjutkan?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If result = DialogResult.Yes Then
                            Else
                                list_logic(2) = False
                            End If
                        End If
                        If month_now.Text <> "" And name_month_now.Text <> "" Then

                            If tbb_sche.Rows.Count < 0 Then
                                MessageBox.Show("Demand pada bulan " & month_now.Text & " " & name_month_now.Text & " belum terinput! Pembuatan MRP gagal. ")
                                list_logic(3) = False
                            Else
                            End If
                        End If
                        If month_next.Text <> "" And name_month_next.Text <> "" Then

                            If tbb_sche1.Rows.Count < 0 Then
                                MessageBox.Show("Demand pada bulan " & month_next.Text & " " & name_month_next.Text & " belum terinput! Pembuatan MRP gagal. ")
                                list_logic(4) = False
                            Else
                            End If
                        End If
                        If month_next1.Text <> "" And name_month_next1.Text <> "" Then

                            If tbb_sche2.Rows.Count < 0 Then
                                MessageBox.Show("Demand pada bulan " & month_next1.Text & " " & name_month_next1.Text & " belum terinput! Pembuatan MRP gagal. ")
                                list_logic(5) = False
                            Else
                            End If
                        End If
                    End If

                End If

            ElseIf demand_1.CheckState = CheckState.Unchecked Then

                If (month_now.Text = "" Or name_month_now.Text = "" Or tahun_this_month.Text = "") Then
                    MsgBox("Mohon Lengkapi Data Terlebih Dahulu!")
                    list_logic(0) = False
                Else
                    If Format(Date.Parse(tbb_stck(0)(1)), "dd-MMMM-yy") <> Format(Date.Now(), "dd-MMMM-yy") Then

                        Dim result = MessageBox.Show("Report Stock terakhir diupdate pada tanggal " & Format(Date.Parse(tbb_stck(0)(1)), "dd-MMM-y").ToString & ", ingin melanjutkan?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        If result = DialogResult.Yes Then
                        Else
                            list_logic(0) = False
                        End If
                    End If
                    If Format(Date.Parse(tbb_stck(0)(5)), "dd-MMMM-yy") <> Format(Date.Now(), "dd-MMMM-yy") Then

                        Dim result = MessageBox.Show("Report Outstanding terakhir diupdate pada tanggal " & Format(Date.Parse(tbb_stck(0)(1)), "dd-MMM-y").ToString & ", ingin melanjutkan?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        If result = DialogResult.Yes Then
                        Else
                            list_logic(1) = False
                        End If
                    End If
                    If tbb_pro.Rows.Count < 1 Then

                        Dim result = MessageBox.Show("Report PRPO belum diupdate pada bulan " & Format(Date.Now, "MMMM").ToUpper.ToString & ", ingin melanjutkan?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        If result = DialogResult.Yes Then
                        Else
                            list_logic(2) = False
                        End If
                    End If
                    If month_now.Text <> "" And name_month_now.Text <> "" Then

                        If tbb_sche.Rows.Count < 0 Then
                            MessageBox.Show("Demand pada bulan " & month_now.Text & " " & name_month_now.Text & " belum terinput! Pembuatan MRP gagal. ")
                            list_logic(3) = False
                        Else
                        End If
                    End If
                    If month_next.Text <> "" And name_month_next.Text <> "" Then

                        If tbb_sche1.Rows.Count < 0 Then
                            MessageBox.Show("Demand pada bulan " & month_next.Text & " " & name_month_next.Text & " belum terinput! Pembuatan MRP gagal. ")
                            list_logic(4) = False
                        Else
                        End If
                    End If
                    If month_next1.Text <> "" And name_month_next1.Text <> "" Then

                        If tbb_sche2.Rows.Count < 0 Then
                            MessageBox.Show("Demand pada bulan " & month_next1.Text & " " & name_month_next1.Text & " belum terinput! Pembuatan MRP gagal. ")
                            list_logic(5) = False
                        Else
                        End If
                    End If
                End If

            End If

        End If

        If list_logic.Contains(False) Then
        Else
            formula_order()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filename1 As String
        With OpenFileDialog1
            .Filter = "Excel Office| *.xls;*.xlsx;*.xlsm"
            .ShowDialog()
            filename1 = .FileName
        End With
        tmplt_inv.Text = filename1
    End Sub

    Public Function formula_order()
        con.Open()
        Dim mulai_baris As Integer = 16
        Dim reader1 As MySqlDataReader
        Dim codd As String, desk As String
        Dim kategori_demand As String = ""
        Dim kategori_demand2 As String = ""
        Dim pengali_n1 As Double, pengali_n2 As Double
        Dim app As New Excel.Application
        Dim wb As Excel.Workbook = app.Workbooks.Open(tmplt_inv.Text.ToString())
        Dim ws As Excel.Worksheet = app.Worksheets(1)
        ws.Range("C6").Value = DateTime.Now.ToString("d-MMM-y H:mm:ss")
        Dim list_revisi_sch() As String = {"", "", "", "", "", ""}
        Dim kolom_title_bulan() As String = {"Z", "U", "R", "O", "L", "I", "F"}
        Dim kolom_title_prodplan() As String = {"AF", "AS", "BE"}
        Dim teks_bln As String = ""
        Dim tambah_item As Integer = 0
        Dim jumlah_list_item As Integer
        Dim adpt_list_jumlah_master As New MySqlDataAdapter("select * from data_master where jenis = '" & jeniss.Text.ToString() & "'", con)
        Dim ds_list_jumlah_master As New DataSet
        Dim tbb_list_jumlah_master As New DataTable
        adpt_list_jumlah_master.Fill(ds_list_jumlah_master, "emp_list_jumlah_master")
        adpt_list_jumlah_master.Fill(tbb_list_jumlah_master)
        jumlah_list_item = tbb_list_jumlah_master.Rows.Count

        ''tentuin pengali demand n+1 dan n+2
        Dim adpt_data_pengali1 As New MySqlDataAdapter("select * from list_demand where bulan = '" & month_next.Text.ToString & "' AND revisi = '" & name_month_next.Text.ToString() & "' AND jenis = '" & jeniss.Text.ToString() & "'", con)
        Dim ds_data_pengali1 As New DataSet
        Dim tbb_data_pengali1 As New DataTable
        adpt_data_pengali1.Fill(ds_data_pengali1, "emp_data_pengali1")
        adpt_data_pengali1.Fill(tbb_data_pengali1)
        If tbb_data_pengali1.Rows.Count > 0 Then
            If jeniss.Text.ToString = "STICKER PCR MICHELLIN" Or jeniss.Text.ToString = "STICKER PCR PRIMEWELL" Or jeniss.Text.ToString = "STICKER TBR REGULAR" Then
                If tbb_data_pengali1(0)(5) = "SALES FORECAST" Then
                    pengali_n1 = 0.8
                    kategori_demand = tbb_data_pengali1(0)(5)
                    ws.Range("AY13").Value = "80% dari kebutuhan"
                End If
            ElseIf jeniss.Text.ToString = "STICKER PCR GT US" Or jeniss.Text.ToString = "STICKER PCR DEXTERO RFID" Then
                If tbb_data_pengali1(0)(5) = "SALES FORECAST" Then
                    pengali_n1 = 0.7
                    kategori_demand = tbb_data_pengali1(0)(5)
                    ws.Range("AY13").Value = "70% dari kebutuhan"
                End If
            ElseIf jeniss.Text.ToString = "STICKER PCR RADIAL NON EROPA" Then
                If tbb_data_pengali1(0)(5) = "SALES FORECAST" Then
                    pengali_n1 = 0.5
                    kategori_demand = tbb_data_pengali1(0)(5)
                    ws.Range("AY13").Value = "50% dari kebutuhan"
                End If
            End If
        End If
        Dim adpt_data_pengali2 As New MySqlDataAdapter("select * from list_demand where bulan = '" & month_next1.Text.ToString & "' AND revisi = '" & name_month_next1.Text.ToString() & "' AND jenis = '" & jeniss.Text.ToString() & "'", con)
        Dim ds_data_pengali2 As New DataSet
        Dim tbb_data_pengali2 As New DataTable
        adpt_data_pengali2.Fill(ds_data_pengali2, "emp_data_pengali2")
        adpt_data_pengali2.Fill(tbb_data_pengali2)
        If tbb_data_pengali2.Rows.Count > 0 Then
            If jeniss.Text.ToString = "STICKER PCR MICHELLIN" Or jeniss.Text.ToString = "STICKER PCR PRIMEWELL" Or jeniss.Text.ToString = "STICKER TBR REGULAR" Or jeniss.Text.ToString = "STICKER TBR EROPA" Then
                If tbb_data_pengali2(0)(5) = "SALES FORECAST" Then
                    pengali_n2 = 0.8
                    kategori_demand2 = tbb_data_pengali2(0)(5)
                    ws.Range("BK13").Value = "80% dari kebutuhan"
                End If
            ElseIf jeniss.Text.ToString = "STICKER PCR GT US" Or jeniss.Text.ToString = "STICKER PCR DEXTERO RFID" Then
                If tbb_data_pengali2(0)(5) = "SALES FORECAST" Then
                    pengali_n2 = 0.7
                    kategori_demand2 = tbb_data_pengali2(0)(5)
                    ws.Range("BK13").Value = "70% dari kebutuhan"
                End If
            ElseIf jeniss.Text.ToString = "STICKER PCR RADIAL NON EROPA" Then
                If tbb_data_pengali2(0)(5) = "SALES FORECAST" Then
                    pengali_n2 = 0.5
                    kategori_demand2 = tbb_data_pengali2(0)(5)
                    ws.Range("BK13").Value = "50% dari kebutuhan"
                End If
            End If
        End If

        '' title -3 bulan 
        For no_title_bulan As Integer = 0 To 6
            ws.Range(kolom_title_bulan(no_title_bulan) & (mulai_baris - 2).ToString).Value = Format(Date.Now().AddMonths(-(no_title_bulan)), "MMMM")
        Next
        '' title bulan prodplan
        For no_title_prodplan As Integer = 0 To 2
            ws.Range(kolom_title_prodplan(no_title_prodplan) & (mulai_baris - 4).ToString).Value = Format(Date.Now().AddMonths(no_title_prodplan), "MMMM")
        Next

        For ii As Integer = 1 To 6
            Dim adptr_bln_dmnd As New MySqlDataAdapter("select * from list_demand where jenis = '" & jeniss.Text.ToString() & "' AND bulan = '" & Format(Date.Now().AddMonths(-(ii)), "MMMM").ToUpper.ToString() & "'", con)
            Dim bln_dmnd As New DataSet
            Dim data_bln_dmnd As New DataTable
            Dim array_list_revisi() As String = {"", "", "", "", ""}
            Dim rvs_demand_bulan_kemarin As String = ""
            adptr_bln_dmnd.Fill(bln_dmnd, "bln_dmnd")
            adptr_bln_dmnd.Fill(data_bln_dmnd)
            If data_bln_dmnd.Rows.Count() > 0 Then
                For jj As Integer = 0 To data_bln_dmnd.Rows.Count() - 1
                    array_list_revisi(jj) = data_bln_dmnd(jj)(4)
                Next
                If array_list_revisi.Contains("R0") Then
                    list_revisi_sch(ii - 1) = "R0"
                End If
                If array_list_revisi.Contains("R1") Then
                    list_revisi_sch(ii - 1) = "R1"
                End If
                If array_list_revisi.Contains("R2") Then
                    list_revisi_sch(ii - 1) = "R2"
                End If
                If array_list_revisi.Contains("R3") Then
                    list_revisi_sch(ii - 1) = "R3"
                End If
                If array_list_revisi.Contains("R4") Then
                    list_revisi_sch(ii - 1) = "R4"
                End If
            End If
        Next



        '' START PR MAKING
        Dim item_1 As Integer = 0
        Dim tambah_baris As Integer = 0
        Dim kolom_had_order(,) As String = {{"AM", "AN"}, {"AZ", "BA"}, {"BL", "BM"}}
        Dim list_kolom_demand As String() = {"U", "R", "O", "L", "I", "F"}
        Dim list_kolom_act_const As String() = {"V", "S", "P", "M", "J", "G"}
        Dim list_no_revisi() As String = {"R0", "R1", "R2", "R3", "R4"}
        Dim kolom_list_demand(,) As String = {{"AF", "AG", "AH", "AI", "AJ"}, {"AT", "AU", "AV", "AW", "AX"}, {"BF", "BG", "BH", "BI", "BJ"}}
        Dim kolom() As String = {"F", "G", "I", "J", "L", "M", "O", "P", "R", "S", "U", "V", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AS", "AT", "AU", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP"}
        Dim kolom_presentase(,) As String = {{"H", "G", "F"}, {"K", "J", "I"}, {"N", "M", "L"}, {"Q", "P", "O"}, {"T", "S", "R"}, {"W", "V", "U"}}

        label_progress.Text = CStr(tambah_item) + "/" + CStr(jumlah_list_item)

        Dim adpt_sub As New MySqlDataAdapter("select * from list_sub_kategori where jenis = '" & jeniss.Text.ToString() & "'", con)
        Dim ds_sub As New DataSet
        Dim tbb_sub As New DataTable
        adpt_sub.Fill(ds_sub, "emp_sub")
        adpt_sub.Fill(tbb_sub)
        While item_1 < ds_sub.Tables("emp_sub").Rows.Count
            Dim item As Integer = 0
            Dim adpt As New MySqlDataAdapter("select * from data_master where jenis = '" & jeniss.Text.ToString() & "' AND sub_kategori = '" & tbb_sub(item_1)(2) & "'", con)
            Dim ds As New DataSet
            Dim tbb As New DataTable
            adpt.Fill(ds, "emp")
            adpt.Fill(tbb)
            While item < ds.Tables("emp").Rows.Count
                ''VARIABEL STORE 
                Dim order1 As Double, order2 As Double, order3 As Double
                Dim condition As Double, condition1 As Double, condition2 As Double
                Dim out As Integer = 0
                Dim stock As Integer = 0
                Dim stock_out As Integer = 0
                Dim sch1 As Integer = 0
                Dim sch2 As Integer = 0
                Dim sch As Integer = 0
                Dim stock_sticker_gd_ban As Integer = 0
                Dim stock_polos As Integer = 0
                Dim round As Integer = 0
                Dim round1 As Integer = 0
                Dim round2 As Integer = 0
                Dim remain1 As Double, remain2 As Double, remain3 As Double
                Dim list_had_order(,) As Integer = {{0, 0}, {0, 0}, {0, 0}}
                codd = ds.Tables("emp").Rows(item).Item(1).ToString()
                desk = ds.Tables("emp").Rows(item).Item(3).ToString()
                lbl_item.Text = codd
                '' item code
                ws.Range("B" & (tambah_baris + mulai_baris).ToString()).Value = codd
                '' deskripsi
                ws.Range("C" & (tambah_baris + mulai_baris).ToString()).Value = desk
                '' oums
                ws.Range("D" & (tambah_baris + mulai_baris).ToString()).Value = "PCS"

                '' STOCK ON HAND
                Dim adpt1 As New MySqlDataAdapter("select * from stock_mrp where item_code = '" & codd & "' AND jenis = 'Stock Awal Bulan (This Month)' AND bulan = '" & Format(Date.Now(), "MMMM") & "' AND cut_off = '" & stock_pr.Text & "'", con)
                Dim ds1 As New DataSet
                Dim tbb1 As New DataTable
                adpt1.Fill(ds1, "emp1")
                adpt1.Fill(tbb1)
                If tbb1.Rows.Count() > 0 Then
                    stock = tbb1(0)(3)
                    stock_out = tbb1(0)(2)
                    ws.Range("AC" & (tambah_baris + mulai_baris).ToString()).Value = stock
                    ws.Range("AA" & (tambah_baris + mulai_baris).ToString()).Value = stock_out
                Else
                    ws.Range("AC" & (tambah_baris + mulai_baris).ToString()).Value = 0
                    ws.Range("AA" & (tambah_baris + mulai_baris).ToString()).Value = 0
                End If

                ws.Range("AD" & (tambah_baris + mulai_baris).ToString()).Formula = "=SUM(Sheet1!AB" & (tambah_baris + mulai_baris).ToString() & ":AC" & (tambah_baris + mulai_baris).ToString() & ")"

                ''STOCK PACKING DAN STOCK POLOS GD BAN
                Dim adpt_data_gd_ban As New MySqlDataAdapter("select * from data_gd_ban where item_code = '" & codd & "' AND jenis = '" & jeniss.Text.ToString() & "' AND bulan = '" & Format(Date.Now(), "MMMM") & "'", con)
                Dim ds_data_gd_ban As New DataSet
                Dim tbb_data_gd_ban As New DataTable
                adpt_data_gd_ban.Fill(ds_data_gd_ban, "emp_data_gd_ban_")
                adpt_data_gd_ban.Fill(tbb_data_gd_ban)
                If tbb_data_gd_ban.Rows.Count() > 0 Then
                    stock_sticker_gd_ban = tbb_data_gd_ban(0)(1)
                    stock_polos = tbb_data_gd_ban(0)(2)
                    ws.Range("AB" & (tambah_baris + mulai_baris).ToString()).Value = stock_sticker_gd_ban
                    ws.Range("AK" & (tambah_baris + mulai_baris).ToString()).Value = stock_polos
                Else
                    stock_sticker_gd_ban = 0
                    stock_polos = 0
                    ws.Range("AB" & (tambah_baris + mulai_baris).ToString()).Value = stock_sticker_gd_ban
                    ws.Range("AK" & (tambah_baris + mulai_baris).ToString()).Value = stock_polos
                End If

                '' OUTSTANDING

                Dim adpt2 As New MySqlDataAdapter("select * from outstanding_mrp where item_code = '" & codd & "' AND cut_off = '" & outs_pr.Text.ToString & "'", con)
                Dim ds2 As New DataSet
                Dim tbb2 As New DataTable
                adpt2.Fill(ds2, "emp2")
                adpt2.Fill(tbb2)
                If tbb2.Rows.Count() > 0 Then
                    If tbb2.Rows.Count() > 1 Then
                        Dim angka As Integer = 0
                        For i = 0 To tbb2.Rows.Count() - 1
                            out += tbb2(i)(2)
                        Next
                        ws.Range("AE" & (tambah_baris + mulai_baris).ToString()).Value = out
                    Else
                        out = tbb2(0)(2)
                        ws.Range("AE" & (tambah_baris + mulai_baris).ToString()).Value = out
                    End If
                Else
                    out = 0
                    ws.Range("AE" & (tambah_baris + mulai_baris).ToString()).Value = out
                End If

                ''HAD ORDER AND IN GT THIS MONTH, MONTH + 1, MONTH + 2

                Dim jml_loop_hdord As Integer

                If demand_1.CheckState = CheckState.Checked Then
                    If demand_2.CheckState = CheckState.Checked Then
                        jml_loop_hdord = 2
                    ElseIf demand_2.CheckState = CheckState.Unchecked Then
                        jml_loop_hdord = 1
                    End If
                Else
                    jml_loop_hdord = 0
                End If

                For iiii As Integer = 0 To jml_loop_hdord
                    Dim adpt_had_order As New MySqlDataAdapter("select * from pr_po where bulan = '" & Format(Date.Now().AddMonths(iiii), "MMMM").ToUpper.ToString() & "' AND item_code = '" & codd & "' AND cut_off = '" & prpo_pr.Text.ToString & "'", con)
                    Dim ds_had_order As New DataSet
                    Dim tbb_had_order As New DataTable
                    adpt_had_order.Fill(ds_had_order, "emp13")
                    adpt_had_order.Fill(tbb_had_order)
                    Dim had_order As Integer = 0
                    Dim in_gt As Integer = 0
                    If tbb_had_order.Rows.Count() > 0 Then
                        If tbb_had_order.Rows.Count() > 1 Then
                            For i = 0 To tbb_had_order.Rows.Count() - 1
                                had_order += tbb_had_order(i)(3)
                                in_gt += tbb_had_order(i)(4)
                            Next
                            list_had_order(iiii, 0) = in_gt
                            list_had_order(iiii, 1) = had_order
                            ws.Range(kolom_had_order(iiii, 1) & (tambah_baris + mulai_baris).ToString()).Value = had_order
                            ws.Range(kolom_had_order(iiii, 0) & (tambah_baris + mulai_baris).ToString()).Value = in_gt
                        Else
                            in_gt = tbb_had_order(0)(4)
                            had_order = tbb_had_order(0)(3)
                            list_had_order(iiii, 1) = tbb_had_order(0)(3)
                            list_had_order(iiii, 0) = tbb_had_order(0)(4)
                            ws.Range(kolom_had_order(iiii, 1) & (tambah_baris + mulai_baris).ToString()).Value = tbb_had_order(0)(3)
                            ws.Range(kolom_had_order(iiii, 0) & (tambah_baris + mulai_baris).ToString()).Value = tbb_had_order(0)(4)
                        End If
                    Else
                        in_gt = 0
                        had_order = 0
                        list_had_order(iiii, 1) = 0
                        list_had_order(iiii, 0) = 0
                        ws.Range(kolom_had_order(iiii, 1) & (tambah_baris + mulai_baris).ToString()).Value = 0
                        ws.Range(kolom_had_order(iiii, 0) & (tambah_baris + mulai_baris).ToString()).Value = 0
                    End If
                    If iiii = 0 Then
                        ws.Range("AO" & (tambah_baris + mulai_baris).ToString()).Value = "= AM" & (tambah_baris + mulai_baris).ToString().ToString & " + AN" & (tambah_baris + mulai_baris).ToString().ToString & " + AE" & (tambah_baris + mulai_baris).ToString().ToString & ""
                    End If
                Next

                ''AMBIL HISTORY KEBUTUHAN 6 BULAN KE BELAKANG

                For mundur_bulan As Integer = 1 To 6
                    Dim adptr_qty_dmnd_bln_blkng As New MySqlDataAdapter("select * from demand where item_code = '" & codd & "' AND bulan = '" & Format(Date.Now().AddMonths(-(mundur_bulan)), "MMMM").ToUpper.ToString() & "' AND revisi ='" & list_revisi_sch(mundur_bulan - 1) & "'", con)
                    Dim qty_bln_dmnd As New DataSet
                    Dim qty_data_bln_dmnd As New DataTable
                    adptr_qty_dmnd_bln_blkng.Fill(qty_bln_dmnd, "qty_bln_dmnd")
                    adptr_qty_dmnd_bln_blkng.Fill(qty_data_bln_dmnd)
                    If qty_data_bln_dmnd.Rows.Count() > 0 Then
                        ws.Range(list_kolom_demand(mundur_bulan - 1) & (tambah_baris + mulai_baris).ToString()).Value = qty_data_bln_dmnd(0)(2)
                    Else
                        ws.Range(list_kolom_demand(mundur_bulan - 1) & (tambah_baris + mulai_baris).ToString()).Value = "0"
                    End If
                Next

                '' AMBIL HISTORY STOCK 6 BULAN KE BELAKANG

                For iii As Integer = 1 To 6
                    Dim adptr_bln_act As New MySqlDataAdapter("select * from stock_mrp where item_code = '" & codd & "' AND bulan = '" & Format(Date.Now().AddMonths(-(iii)), "MMMM").ToUpper.ToString() & "' AND jenis ='Stock Akhir bulan (Last Month)'", con)
                    Dim bln_act As New DataSet
                    Dim data_bln_act As New DataTable
                    adptr_bln_act.Fill(bln_act, "bln_dmnd")
                    adptr_bln_act.Fill(data_bln_act)
                    If data_bln_act.Rows.Count() > 0 Then
                        ws.Range(list_kolom_act_const(iii - 1) & (tambah_baris + mulai_baris).ToString()).Value = data_bln_act(0)(2)
                    Else
                        ws.Range(list_kolom_act_const(iii - 1) & (tambah_baris + mulai_baris).ToString()).Value = "0"
                    End If
                Next

                ''SCHEDULE

                ''MONTH NOW

                Dim adpt_SCH As New MySqlDataAdapter("select * from demand where item_code = '" & codd & "' AND revisi = '" & name_month_now.Text.ToString() & "' AND bulan = '" & month_now.Text.ToString() & "' and tahun = '" & tahun_this_month.Text.ToString & "'", con)
                Dim ds_SCH As New DataSet
                Dim tbb_SCH As New DataTable
                adpt_SCH.Fill(ds_SCH, "emp_SCH")
                adpt_SCH.Fill(tbb_SCH)
                If tbb_SCH.Rows.Count() > 0 Then
                    sch = tbb_SCH(0)(2).ToString()
                Else
                    sch = 0
                End If

                ws.Range("Z" & (tambah_baris + mulai_baris).ToString()).Value = sch

                If demand_1.CheckState = CheckState.Checked Then

                    ''MONTH +1

                    Dim adpt_SCH1 As New MySqlDataAdapter("select * from demand where item_code = '" & codd & "' AND revisi = '" & name_month_next.Text.ToString() & "' AND bulan = '" & month_next.Text.ToString() & "' and tahun = '" & tahun_next_month.Text.ToString & "'", con)
                    Dim ds_SCH1 As New DataSet
                    Dim tbb_SCH1 As New DataTable
                    adpt_SCH1.Fill(ds_SCH1, "emp_SCH1")
                    adpt_SCH1.Fill(tbb_SCH1)
                    If tbb_SCH1.Rows.Count() > 0 Then
                        If jeniss.Text.ToString = "STICKER PCR MICHELLIN" Or jeniss.Text.ToString = "STICKER PCR PRIMEWELL" Or jeniss.Text.ToString = "STICKER PCR GT US" Or jeniss.Text.ToString = "STICKER PCR DEXTERO RFID" Or jeniss.Text.ToString = "STICKER PCR RADIAL NON EROPA" Or jeniss.Text.ToString = "STICKER TBR REGULAR" Or jeniss.Text.ToString = "STICKER TBR EROPA" Then

                            If kategori_demand = "SALES FORECAST" Then
                                sch1 = tbb_SCH1(0)(2) * pengali_n1
                            Else
                                sch1 = tbb_SCH1(0)(2)
                            End If

                        Else
                            sch1 = tbb_SCH1(0)(2)
                        End If
                    Else
                        sch1 = 0
                    End If

                    ws.Range("AY" & (tambah_baris + mulai_baris).ToString()).Value = sch1.ToString

                    If demand_2.CheckState = CheckState.Checked Then

                        ''MONTH +2

                        Dim adpt_SCH2 As New MySqlDataAdapter("select * from demand where item_code = '" & codd & "' AND revisi = '" & name_month_next1.Text.ToString() & "' AND bulan = '" & month_next1.Text.ToString() & "' and tahun = '" & tahun_next_month1.Text.ToString & "'", con)
                        Dim ds_SCH2 As New DataSet
                        Dim tbb_SCH2 As New DataTable
                        adpt_SCH2.Fill(ds_SCH2, "emp_SCH2")
                        adpt_SCH2.Fill(tbb_SCH2)
                        If tbb_SCH2.Rows.Count() > 0 Then
                            If jeniss.Text.ToString = "STICKER PCR MICHELLIN" Or jeniss.Text.ToString = "STICKER PCR PRIMEWELL" Or jeniss.Text.ToString = "STICKER PCR GT US" Or jeniss.Text.ToString = "STICKER PCR DEXTERO RFID" Or jeniss.Text.ToString = "STICKER PCR RADIAL NON EROPA" Or jeniss.Text.ToString = "STICKER TBR REGULAR" Or jeniss.Text.ToString = "STICKER TBR EROPA" Then

                                If kategori_demand2 = "SALES FORECAST" Then
                                    sch2 = tbb_SCH2(0)(2) * pengali_n2
                                Else
                                    sch2 = tbb_SCH2(0)(2)
                                End If

                            Else
                                sch2 = tbb_SCH2(0)(2)
                            End If
                        Else
                            sch2 = 0
                        End If

                        ws.Range("BK" & (tambah_baris + mulai_baris).ToString()).Value = sch2.ToString

                    ElseIf demand_2.CheckState = CheckState.Unchecked Then

                    End If
                Else

                End If


                ''LIST REVISI DEMAND BULAN H, N+1, N+2

                Dim jml_loop_rvs As Integer

                If demand_1.CheckState = CheckState.Checked Then
                    If demand_2.CheckState = CheckState.Checked Then
                        jml_loop_rvs = 2
                    ElseIf demand_2.CheckState = CheckState.Unchecked Then
                        jml_loop_rvs = 1
                    End If
                Else
                    jml_loop_rvs = 0
                End If

                For no_bulan As Integer = 0 To jml_loop_rvs
                    For no_revisi As Integer = 0 To 4
                        '' REGULER
                        Dim adpt3 As New MySqlDataAdapter("select * from demand where item_code = '" & codd & "' AND revisi = '" & list_no_revisi(no_revisi) & "' AND bulan = '" & Format(Date.Now().AddMonths(no_bulan), "MMMM").ToUpper.ToString() & "'", con)
                        Dim ds3 As New DataSet
                        Dim tbb3 As New DataTable
                        adpt3.Fill(ds3, "emp3")
                        adpt3.Fill(tbb3)
                        If tbb3.Rows.Count() > 0 Then
                            ws.Range(kolom_list_demand(no_bulan, no_revisi) & (tambah_baris + mulai_baris).ToString()).Value = tbb3(0)(2)
                        Else
                            ws.Range(kolom_list_demand(no_bulan, no_revisi) & (tambah_baris + mulai_baris).ToString()).Value = ""
                        End If
                    Next
                Next

                ''SAFETY STOCK

                Dim safety As Double
                Dim adpt_sft As New MySqlDataAdapter("select * from data_master where item_code = '" & codd & "'", con)
                Dim ds_sft As New DataSet
                Dim tbb_sft As New DataTable
                adpt_sft.Fill(ds_sft, "emp3")
                adpt_sft.Fill(tbb_sft)
                safety = tbb_sft(0)(10)

                If jeniss.Text.ToString = "STICKER PCR MICHELLIN" Or jeniss.Text.ToString = "STICKER MC TIRE YAMAHA POD" Then
                    ws.Range("AL" & (tambah_baris + mulai_baris).ToString()).Value = safety
                Else
                    ws.Range("AL" & (tambah_baris + mulai_baris).ToString()).Formula = "=" & "Z" & (tambah_baris + mulai_baris).ToString() & "*" & "E" & (tambah_baris + mulai_baris).ToString()
                End If

                ''REMAIN CONSUMPTION

                remain1 = sch + (sch * (CDbl(safety) / 100)) + stock_out + stock_polos


                ' Safety Stock
                ws.Range("E" & (tambah_baris + mulai_baris).ToString()).Value = (safety / 100).ToString

                If demand_1.CheckState = CheckState.Checked Then

                    ' Safety Stock N+1
                    ws.Range("AS" & (tambah_baris + mulai_baris).ToString()).Value = (safety / 100).ToString

                    If demand_2.CheckState = CheckState.Checked Then
                        ' Safety Stock N+2
                        ws.Range("BE" & (tambah_baris + mulai_baris).ToString()).Value = (safety / 100).ToString
                    ElseIf demand_2.CheckState = CheckState.Unchecked Then

                    End If
                Else

                End If


                ''HITUNG ORDER


                '' ORDER BULAN N
                condition = ((out + list_had_order(0, 0)) + list_had_order(0, 1) + (stock + stock_sticker_gd_ban)) - remain1

                order1 = remain1 - ((stock + stock_sticker_gd_ban) + list_had_order(0, 1) + (out + list_had_order(0, 0)))
                round = Math.Ceiling(order1 / 1000) * 1000
                ws.Range("AP" & (tambah_baris + mulai_baris).ToString()).Formula = "=IF(" & "AE" & (tambah_baris + mulai_baris) & "+" & "AN" & (tambah_baris + mulai_baris) & "+" & "AM" & (tambah_baris + mulai_baris) & "+" & "AD" & (tambah_baris + mulai_baris) & "-" & "Z" & (tambah_baris + mulai_baris) & "-" & "AL" & (tambah_baris + mulai_baris) & "-" & "AA" & (tambah_baris + mulai_baris) & "-" & "AK" & (tambah_baris + mulai_baris) & "< 0" & "," & "Z" & (tambah_baris + mulai_baris) & "+" & "AL" & (tambah_baris + mulai_baris) & "+" & "AA" & (tambah_baris + mulai_baris) & "+" & "AK" & (tambah_baris + mulai_baris) & "-" & "(" & "AE" & (tambah_baris + mulai_baris) & "+" & "AN" & (tambah_baris + mulai_baris) & "+" & "AM" & (tambah_baris + mulai_baris) & "+" & "AD" & (tambah_baris + mulai_baris) & "), 0)"
                If jeniss.Text.ToString = "STICKER MC TIRE IRC TUBELESS" Or jeniss.Text.ToString = "STICKER MC TIRE IRC TUBETYPE" Or jeniss.Text.ToString = "STICKER MC TIRE ZENEOS" Or jeniss.Text.ToString = "STICKER MC TIRE YAMAHA POD" Or jeniss.Text.ToString = "DOOS&BOX" Then
                    If jeniss.Text.ToString = "DOOS&BOX" And tbb_sub(item_1)(2).ToString.Contains("BOX") Then
                        ws.Range("AQ" & (tambah_baris + mulai_baris).ToString()).Value = "=ROUNDUP" & "(" & "AP" & (tambah_baris + mulai_baris) & "/ 100,0)*100"
                    Else
                        ws.Range("AQ" & (tambah_baris + mulai_baris).ToString()).Value = "=ROUNDUP" & "(" & "AP" & (tambah_baris + mulai_baris) & "/ 1000,0)*1000"
                    End If
                Else
                    If jeniss.Text.ToString = "KANTONG & KARUNG" And tbb_sub(item_1)(2).ToString.Contains("KARUNG") Then
                        ws.Range("AQ" & (tambah_baris + mulai_baris).ToString()).Value = "=ROUNDUP" & "(" & "AP" & (tambah_baris + mulai_baris) & "/ 500,0)*500"
                    ElseIf jeniss.Text.ToString = "KANTONG & KARUNG" And tbb_sub(item_1)(2).ToString.Contains("KANTONG") Then
                        ws.Range("AQ" & (tambah_baris + mulai_baris).ToString()).Value = "=ROUNDUP" & "(" & "AP" & (tambah_baris + mulai_baris) & "/ 500,0)*500"
                    Else
                        ws.Range("AQ" & (tambah_baris + mulai_baris).ToString()).Value = "=IF(" & "AP" & (tambah_baris + mulai_baris) & ">0,IF(" & "AP" & (tambah_baris + mulai_baris) & "<1000,1000,ROUNDUP(" & "AP" & (tambah_baris + mulai_baris) & "/500,0)*500),0)"
                    End If
                End If

                '' EST STOCK BULAN N
                Dim est_stock = (out + list_had_order(0, 0)) + (stock_sticker_gd_ban + stock) + list_had_order(0, 1) + round - (sch + stock_out + stock_polos)
                ws.Range("AR" & (tambah_baris + mulai_baris).ToString()).Value = "=" & "AE" & (tambah_baris + mulai_baris) & "+" & "AD" & (tambah_baris + mulai_baris) & "+" & "AN" & (tambah_baris + mulai_baris) & "+" & "AM" & (tambah_baris + mulai_baris) & "+" & "AQ" & (tambah_baris + mulai_baris) & "-" & "(" & "Z" & (tambah_baris + mulai_baris) & "+" & "AA" & (tambah_baris + mulai_baris) & "+" & "AK" & (tambah_baris + mulai_baris) & ")"


                If demand_1.CheckState = CheckState.Checked Then

                    '' ORDER BULAN N+1
                    condition1 = est_stock + list_had_order(1, 1) - (sch1 + (sch1 * (CDbl(safety) / 100)))
                    order2 = (sch1 + (sch1 * (CDbl(safety) / 100))) - (list_had_order(1, 1) + est_stock)
                    round1 = Math.Ceiling(order2 / 1000) * 1000
                    If jeniss.Text.ToString = "STICKER PCR MICHELLIN" Or jeniss.Text.ToString = "STICKER MC TIRE YAMAHA POD" Then
                        ws.Range("BB" & (tambah_baris + mulai_baris).ToString()).Value = "=IF" & "(" & "AR" & (tambah_baris + mulai_baris) & "+" & "BA" & (tambah_baris + mulai_baris) & "+" & "AZ" & (tambah_baris + mulai_baris) & "-(" & "AY" & (tambah_baris + mulai_baris) & "+(" & "AS" & (tambah_baris + mulai_baris) & "))<0,(" & "AY" & (tambah_baris + mulai_baris) & "+(" & "AS" & (tambah_baris + mulai_baris) & "))-(" & "AR" & (tambah_baris + mulai_baris) & "+" & "BA" & (tambah_baris + mulai_baris) & "+" & "AZ" & (tambah_baris + mulai_baris) & "),0)"
                    Else
                        ws.Range("BB" & (tambah_baris + mulai_baris).ToString()).Value = "=IF" & "(" & "AR" & (tambah_baris + mulai_baris) & "+" & "BA" & (tambah_baris + mulai_baris) & "+" & "AZ" & (tambah_baris + mulai_baris) & "-(" & "AY" & (tambah_baris + mulai_baris) & "+(" & "AY" & (tambah_baris + mulai_baris) & "*" & "AS" & (tambah_baris + mulai_baris) & "))<0,(" & "AY" & (tambah_baris + mulai_baris) & "+(" & "AY" & (tambah_baris + mulai_baris) & "*" & "AS" & (tambah_baris + mulai_baris) & "))-(" & "AR" & (tambah_baris + mulai_baris) & "+" & "BA" & (tambah_baris + mulai_baris) & "+" & "AZ" & (tambah_baris + mulai_baris) & "),0)"
                    End If

                    If jeniss.Text.ToString = "STICKER MC TIRE IRC TUBELESS" Or jeniss.Text.ToString = "STICKER MC TIRE IRC TUBETYPE" Or jeniss.Text.ToString = "STICKER MC TIRE ZENEOS" Or jeniss.Text.ToString = "STICKER MC TIRE YAMAHA POD" Or jeniss.Text.ToString = "DOOS&BOX" Then
                        If jeniss.Text.ToString = "DOOS&BOX" And tbb_sub(item_1)(2).ToString.Contains("BOX") Then
                            ws.Range("BC" & (tambah_baris + mulai_baris).ToString()).Value = "=ROUNDUP" & "(" & "BB" & (tambah_baris + mulai_baris) & "/ 100,0)*100"
                        Else
                            ws.Range("BC" & (tambah_baris + mulai_baris).ToString()).Value = "=ROUNDUP" & "(" & "BB" & (tambah_baris + mulai_baris) & "/ 1000,0)*1000"
                        End If
                    Else
                        If jeniss.Text.ToString = "KANTONG & KARUNG" And tbb_sub(item_1)(2).ToString.Contains("KARUNG") Then
                            ws.Range("BC" & (tambah_baris + mulai_baris).ToString()).Value = "=ROUNDUP" & "(" & "BB" & (tambah_baris + mulai_baris) & "/ 500,0)*500"
                        ElseIf jeniss.Text.ToString = "KANTONG & KARUNG" And tbb_sub(item_1)(2).ToString.Contains("KANTONG") Then
                            ws.Range("BC" & (tambah_baris + mulai_baris).ToString()).Value = "=ROUNDUP" & "(" & "BB" & (tambah_baris + mulai_baris) & "/ 500,0)*500"
                        Else
                            ws.Range("BC" & (tambah_baris + mulai_baris).ToString()).Value = "=IF(" & "BB" & (tambah_baris + mulai_baris) & ">0,IF(" & "BB" & (tambah_baris + mulai_baris) & "<1000,1000,ROUNDUP(" & "BB" & (tambah_baris + mulai_baris) & "/500,0)*500),0)"
                        End If
                    End If

                    '' EST STOCK BULAN N+1
                    Dim est_stock1 = est_stock + list_had_order(1, 1) + round1 - sch1
                    ws.Range("BD" & (tambah_baris + mulai_baris).ToString()).Value = "=" & "AR" & (tambah_baris + mulai_baris) & "+" & "BA" & (tambah_baris + mulai_baris) & "+" & "AZ" & (tambah_baris + mulai_baris) & "+" & "BC" & (tambah_baris + mulai_baris) & "-" & "AY" & (tambah_baris + mulai_baris)

                    If demand_2.CheckState = CheckState.Checked Then

                        '' ORDER BULAN N+2
                        condition2 = est_stock1 + list_had_order(2, 1) - (sch2 + (sch2 * (CDbl(safety) / 100)))

                        order3 = (sch2 + (sch2 * (CDbl(safety) / 100))) - (list_had_order(2, 1) + est_stock1)
                        round2 = Math.Ceiling(order3 / 1000) * 1000

                        If jeniss.Text.ToString = "STICKER PCR MICHELLIN" Or jeniss.Text.ToString = "STICKER MC TIRE YAMAHA POD" Then
                            ws.Range("BN" & (tambah_baris + mulai_baris).ToString()).Value = "=IF" & "(" & "BD" & (tambah_baris + mulai_baris) & "+" & "BM" & (tambah_baris + mulai_baris) & "+" & "BL" & (tambah_baris + mulai_baris) & "-(" & "BK" & (tambah_baris + mulai_baris) & "+(" & "BE" & (tambah_baris + mulai_baris) & "))<0,(" & "BK" & (tambah_baris + mulai_baris) & "+(" & "BE" & (tambah_baris + mulai_baris) & "))-(" & "BD" & (tambah_baris + mulai_baris) & "+" & "BM" & (tambah_baris + mulai_baris) & "+" & "BL" & (tambah_baris + mulai_baris) & "),0)"
                        Else
                            ws.Range("BN" & (tambah_baris + mulai_baris).ToString()).Value = "=IF" & "(" & "BD" & (tambah_baris + mulai_baris) & "+" & "BM" & (tambah_baris + mulai_baris) & "+" & "BL" & (tambah_baris + mulai_baris) & "-(" & "BK" & (tambah_baris + mulai_baris) & "+(" & "BK" & (tambah_baris + mulai_baris) & "*" & "BE" & (tambah_baris + mulai_baris) & "))<0,(" & "BK" & (tambah_baris + mulai_baris) & "+(" & "BK" & (tambah_baris + mulai_baris) & "*" & "BE" & (tambah_baris + mulai_baris) & "))-(" & "BD" & (tambah_baris + mulai_baris) & "+" & "BM" & (tambah_baris + mulai_baris) & "+" & "BL" & (tambah_baris + mulai_baris) & "),0)"
                        End If

                        If jeniss.Text.ToString = "STICKER MC TIRE IRC TUBELESS" Or jeniss.Text.ToString = "STICKER MC TIRE IRC TUBETYPE" Or jeniss.Text.ToString = "STICKER MC TIRE ZENEOS" Or jeniss.Text.ToString = "STICKER MC TIRE YAMAHA POD" Or jeniss.Text.ToString = "DOOS&BOX" Then
                            If jeniss.Text.ToString = "DOOS&BOX" And tbb_sub(item_1)(2).ToString.Contains("BOX") Then
                                ws.Range("BO" & (tambah_baris + mulai_baris).ToString()).Value = "=ROUNDUP" & "(" & "BN" & (tambah_baris + mulai_baris) & "/ 100,0)*100"
                            Else
                                ws.Range("BO" & (tambah_baris + mulai_baris).ToString()).Value = "=ROUNDUP" & "(" & "BN" & (tambah_baris + mulai_baris) & "/ 1000,0)*1000"
                            End If
                        Else
                            If jeniss.Text.ToString = "KANTONG & KARUNG" And tbb_sub(item_1)(2).ToString.Contains("KARUNG") Then
                                ws.Range("BO" & (tambah_baris + mulai_baris).ToString()).Value = "=ROUNDUP" & "(" & "BN" & (tambah_baris + mulai_baris) & "/ 100,0)*100"
                            ElseIf jeniss.Text.ToString = "KANTONG & KARUNG" And tbb_sub(item_1)(2).ToString.Contains("KANTONG") Then
                                ws.Range("BO" & (tambah_baris + mulai_baris).ToString()).Value = "=ROUNDUP" & "(" & "BN" & (tambah_baris + mulai_baris) & "/ 500,0)*500"
                            Else
                                ws.Range("BO" & (tambah_baris + mulai_baris).ToString()).Value = "=IF(" & "BN" & (tambah_baris + mulai_baris) & ">0,IF(" & "BN" & (tambah_baris + mulai_baris) & "<1000,1000,ROUNDUP(" & "BN" & (tambah_baris + mulai_baris) & "/500,0)*500),0)"
                            End If
                        End If

                        '' EST STOCK BULAN N+2
                        Dim est_stock2 = est_stock1 + list_had_order(2, 1) + round2 - sch2
                        ws.Range("BP" & (tambah_baris + mulai_baris).ToString()).Value = "=" & "BD" & (tambah_baris + mulai_baris) & "+" & "BO" & (tambah_baris + mulai_baris) & "+" & "BM" & (tambah_baris + mulai_baris) & "+" & "BL" & (tambah_baris + mulai_baris) & "-" & "BK" & (tambah_baris + mulai_baris)

                    ElseIf demand_2.CheckState = CheckState.Unchecked Then

                    End If
                Else

                End If


                ''END HITUNG ORDER


                ''KASIH SUBTOTAL

                For Each value As String In kolom
                    ws.Range(value + (mulai_baris - 5).ToString).Formula = "=SUBTOTAL(9," & value & mulai_baris.ToString() & ":" & value & (tambah_baris + mulai_baris).ToString() & ")"
                Next

                ''KASIH PRESENTASE PEBANDINGAN DEMAND V ACTUAL

                For i As Integer = 0 To 5
                    ws.Range(kolom_presentase(i, 0) + (tambah_baris + mulai_baris).ToString()).Formula = "=(" + kolom_presentase(i, 1) + (tambah_baris + mulai_baris).ToString() + "/" + kolom_presentase(i, 2) + (tambah_baris + mulai_baris).ToString() + ")"
                    If ws.Range(kolom_presentase(i, 2) + (tambah_baris + mulai_baris).ToString()).Value = "0" Then
                        ws.Range(kolom_presentase(i, 0) + (tambah_baris + mulai_baris).ToString()).Formula = "0%"
                    End If
                Next
                ws.Range("X" + (tambah_baris + mulai_baris).ToString()).Formula = "=AVERAGE(" + kolom_presentase(0, 2) + (tambah_baris + mulai_baris).ToString() + "," + kolom_presentase(1, 2) + (tambah_baris + mulai_baris).ToString() + "," + kolom_presentase(2, 2) + (tambah_baris + mulai_baris).ToString() + "," + kolom_presentase(3, 2) + (tambah_baris + mulai_baris).ToString() + "," + kolom_presentase(4, 2) + (tambah_baris + mulai_baris).ToString() + "," + kolom_presentase(5, 2) + (tambah_baris + mulai_baris).ToString() + ")"
                ws.Range("Y" + (tambah_baris + mulai_baris).ToString()).Formula = "=AVERAGE(" + kolom_presentase(0, 1) + (tambah_baris + mulai_baris).ToString() + "," + kolom_presentase(1, 1) + (tambah_baris + mulai_baris).ToString() + "," + kolom_presentase(2, 1) + (tambah_baris + mulai_baris).ToString() + "," + kolom_presentase(3, 1) + (tambah_baris + mulai_baris).ToString() + "," + kolom_presentase(4, 1) + (tambah_baris + mulai_baris).ToString() + "," + kolom_presentase(5, 1) + (tambah_baris + mulai_baris).ToString() + ")"
                item += 1
                tambah_baris += 1
                tambah_item += 1
                label_progress.Text = CStr(tambah_item) + "/" + CStr(jumlah_list_item)
            End While

            ws.Range("B" + (tambah_baris + mulai_baris).ToString() + ":BP" + (tambah_baris + mulai_baris).ToString()).Interior.Color = Color.AntiqueWhite
            ws.Range("B" + (tambah_baris + mulai_baris).ToString()).Value = tbb_sub(item_1)(2)
            item_1 += 1
            tambah_baris += 1

        End While

        '' END PR MAKING
        ws.Range("B" & (mulai_baris - 3).ToString & ":BP" & (tambah_baris + mulai_baris).ToString()).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous
        ws.Range("C6:C9").NumberFormat = "d-mmm-y || h:mm:ss"
        ws.Range("C2").Value = "Material Requisition Planning For " + jeniss.Text.ToString()
        ws.Range("C4").Value = Format(Date.Now().AddMonths(-3), "Y").ToString() + " - " + Format(Date.Now().AddMonths(-2), "Y").ToString() + " - " + Format(Date.Now().AddMonths(-1), "Y").ToString()
        ws.Range("C3").Value = Format(Date.Now(), "Y").ToString() + " - " + Format(Date.Now().AddMonths(1), "Y").ToString() + " - " + Format(Date.Now().AddMonths(2), "Y").ToString()
        app.ActiveWindow.Zoom = 85

        Dim adpt_hstr As New MySqlDataAdapter("select * from histori_report", con)
        Dim ds_hstr As New DataSet
        Dim tbb_hstr As New DataTable
        adpt_hstr.Fill(ds_hstr, "emp_hstr")
        adpt_hstr.Fill(tbb_hstr)
        ws.Range("C7").Value = Date.Parse(tbb_hstr(0)(1)).ToString("d-MMM-y H:mm:ss")
        ws.Range("C9").Value = Date.Parse(tbb_hstr(0)(2)).ToString("d-MMM-y H:mm:ss")
        ws.Range("C8").Value = Date.Parse(tbb_hstr(0)(5)).ToString("d-MMM-y H:mm:ss")
        con.Close()
        app.Visible = True
    End Function

    Private Sub tahun_this_month_TextChanged(sender As Object, e As EventArgs) Handles tahun_this_month.Leave
        If tahun_this_month.Text.Length <> 4 Then

            MsgBox("FORMAT TAHUN TIDAK SESUAI!")
            tahun_this_month.Clear()

        Else

            Try
                Date.Parse("01-01-" + tahun_this_month.Text)
            Catch ex As Exception
                MsgBox("FORMAT TAHUN TIDAK SESUAI!")
                tahun_this_month.Clear()
            End Try

        End If
    End Sub

    Private Sub name_month_next_SelectedIndexChanged(sender As Object, e As EventArgs) Handles name_month_next.Click
        If month_next.Text.ToString = "" Then
            MsgBox("Mohon isi Bulan untuk kebutuhan Periode 2!")
            Return
        Else
        End If
    End Sub

    Private Sub name_month_next1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles name_month_next1.Click
        If month_next1.Text.ToString = "" Then
            MsgBox("Mohon isi Bulan untuk kebutuhan Periode 3!")
            Return
        Else
        End If
    End Sub

    Private Sub month_now_SelectedIndexChanged(sender As Object, e As EventArgs) Handles month_now.SelectedIndexChanged
        If tahun_this_month.Text = "" Then
            MsgBox("Mohon isi kolom tahun terlebih dahulu!")
            Return
        Else
        End If

        name_month_now.Text = ""

        outs_pr.Text = ""
        prpo_pr.Text = ""
        stock_pr.Text = ""
        outs_pr.Items.Clear()
        prpo_pr.Items.Clear()
        stock_pr.Items.Clear()

        ''CHECK REVISI KEBUTUHAN BULAN BERJALAN
        Dim adpt As New MySqlDataAdapter("select * from list_demand where jenis = '" & jeniss.Text.ToString() & "' AND bulan = '" & month_now.Text.ToString() & "' and tahun = '" & tahun_this_month.Text.ToString & "'", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)
        Dim baris As Integer
        name_month_now.Items.Clear()
        While baris < ds.Tables("emp").Rows.Count
            name_month_now.Items.Add(tbb(baris)(4))
            baris += 1
        End While

        ''Tambah outstanding ke list
        Dim adpt_outs As New MySqlDataAdapter("select * from list_outstanding_mrp WHERE tgl_cut_off LIKE '%" + Mid(month_now.Text, 1, 3) + "-" + Mid(tahun_this_month.Text, 3, 2) + "'", con)
        Dim ds_outs As New DataSet
        Dim tbb_outs As New DataTable
        adpt_outs.Fill(ds_outs, "emp_outs")
        adpt_outs.Fill(tbb_outs)
        For i = 0 To tbb_outs.Rows.Count - 1
            outs_pr.Items.Add(tbb_outs(i)(1))
        Next

        ''Tambah prpo ke list
        Dim adpt_prp As New MySqlDataAdapter("select * from list_pr_po WHERE bulan = '" + month_now.Text.ToString + "' AND cut_off LIKE '%" + Mid(month_now.Text, 1, 3) + "-" + Mid(tahun_this_month.Text, 3, 2) + "'", con)
        Dim ds_prp As New DataSet
        Dim tbb_prp As New DataTable
        adpt_prp.Fill(ds_prp, "emp_prp")
        adpt_prp.Fill(tbb_prp)
        For i = 0 To tbb_prp.Rows.Count - 1
            prpo_pr.Items.Add(tbb_prp(i)(2))
        Next

        ''Tambah stock ke list
        Dim adpt_stk As New MySqlDataAdapter("select * from list_stock_mrp WHERE bulan = '" + month_now.Text.ToString + "' AND tahun = '" + tahun_this_month.Text.ToString + "' AND tgl_cut_off LIKE '%" + Mid(month_now.Text, 1, 3) + "-" + Mid(tahun_this_month.Text, 3, 2) + "'", con)
        Dim ds_stk As New DataSet
        Dim tbb_stk As New DataTable
        adpt_stk.Fill(ds_stk, "emp_stk")
        adpt_stk.Fill(tbb_stk)
        For i = 0 To tbb_stk.Rows.Count - 1
            stock_pr.Items.Add(tbb_stk(i)(3))
        Next

    End Sub

    Private Sub month_next_SelectedIndexChanged(sender As Object, e As EventArgs) Handles month_next.SelectedIndexChanged
        If tahun_next_month.Text = "" Then
            MsgBox("Mohon isi kolom tahun terlebih dahulu!")
            Return
        Else
            name_month_next.Text = ""
        End If
        ''CHECK REVISI KEBUTUHAN BULAN H+1
        Dim adpt As New MySqlDataAdapter("select * from list_demand where jenis = '" & jeniss.Text.ToString() & "' AND bulan = '" & month_next.Text.ToString() & "' and tahun = '" & tahun_next_month.Text.ToString & "'", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)
        Dim baris As Integer
        name_month_next.Items.Clear()
        While baris < ds.Tables("emp").Rows.Count
            name_month_next.Items.Add(tbb(baris)(4))
            baris += 1
        End While
    End Sub

    Private Sub month_next1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles month_next1.SelectedIndexChanged
        If tahun_next_month1.Text = "" Then
            MsgBox("Mohon isi kolom tahun terlebih dahulu!")
            Return
        Else
        End If

        name_month_next1.Text = ""

        ''CHECK REVISI KEBUTUHAN BULAN BERJALAN H+2
        Dim adpt As New MySqlDataAdapter("select * from list_demand where jenis = '" & jeniss.Text.ToString() & "' AND bulan = '" & month_next1.Text.ToString() & "' and tahun = '" & tahun_next_month1.Text.ToString & "'", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)
        Dim baris As Integer
        name_month_next1.Items.Clear()
        While baris < ds.Tables("emp").Rows.Count
            name_month_next1.Items.Add(tbb(baris)(4))
            baris += 1
        End While
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles demand_1.CheckedChanged
        If demand_1.CheckState = CheckState.Checked Then
            name_month_next.Enabled = True
            name_month_next.Text = ""
            month_next.Enabled = True
            month_next.Text = ""
            tahun_next_month.Enabled = True
        Else
            name_month_next.Enabled = False
            month_next.Enabled = False
            tahun_next_month.Enabled = False
            name_month_next.Text = ""
            month_next.Text = ""
            demand_2.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles demand_2.CheckedChanged
        If demand_2.CheckState = CheckState.Checked Then
            If demand_1.CheckState = CheckState.Checked Then
                name_month_next1.Enabled = True
                month_next1.Enabled = True
                tahun_next_month1.Enabled = True
            Else
                name_month_next1.Enabled = False
                name_month_next1.Text = ""
                month_next1.Enabled = False
                month_next1.Text = ""
                tahun_next_month1.Enabled = False
                demand_2.CheckState = CheckState.Unchecked
            End If
        Else
            name_month_next1.Enabled = False
            name_month_next1.Text = ""
            month_next1.Enabled = False
            month_next1.Text = ""
            tahun_next_month1.Enabled = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles outs_pr.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles outs_pr.Click
        If month_now.Text.ToString = "" Then
            MsgBox("Mohon isi Bulan untuk kebutuhan Periode 1!")
            Return
        Else
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prpo_pr.Click
        If month_now.Text.ToString = "" Then
            MsgBox("Mohon isi Bulan untuk kebutuhan Periode 1!")
            Return
        Else
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stock_pr.Click
        If month_now.Text.ToString = "" Then
            MsgBox("Mohon isi Bulan untuk kebutuhan Periode 1!")
            Return
        Else
        End If
    End Sub

End Class