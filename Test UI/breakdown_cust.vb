Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class breakdown_cust
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Dim con As New MySqlConnection(db)
    Dim data1 As New monitoring_SO
    Private Sub breakdown_cust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_code.Text = data1.cod_item
        lbl_desk.Text = data1.desk_item
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim total_so_reg As Integer
        Dim total_so_eu As Integer
        Dim total_so_saso As Integer
        Dim total_so_gso As Integer
        Dim total_so_inmetro As Integer
        Dim total_so_sendas As Integer
        Dim total_so_irak As Integer
        Dim total_so_rfid As Integer
        Dim total_so_alves As Integer
        Dim total_so_viramsum As Integer
        Dim total_so_tis As Integer
        Dim total_so_no_stic As Integer
        Dim total_so_gt_us As Integer
        Dim total_so_other As Integer

        Dim query_status As String = ""
        If status_so.Text = "ENTERED" Then
            query_status = " AND status = 'ENTERED'"
        ElseIf status_so.Text = "BOOKED" Then
            query_status = " AND status = 'BOOKED'"
        ElseIf status_so.Text = "AWAITING SHIPPING" Then
            query_status = " AND status = 'AWAITING_SHIPPING'"
        ElseIf status_so.Text = "CLOSED" Then
            query_status = " AND status = 'CLOSED'"
        ElseIf status_so.Text = "ALL" Then
            query_status = ""
        Else
            MsgBox("Tipe status tidak sesuai!")
            Return
        End If

        Dim adpt As New MySqlDataAdapter("select * from data_so where code = '" & data1.cod_item.ToString & "'" & query_status & "", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)

        If tbb.Rows.Count > 0 Then

            total_so_reg = 0
            total_so_eu = 0
            total_so_saso = 0
            total_so_gso = 0
            total_so_inmetro = 0
            total_so_sendas = 0
            total_so_irak = 0
            total_so_rfid = 0
            total_so_alves = 0
            total_so_viramsum = 0
            total_so_tis = 0
            total_so_no_stic = 0
            total_so_gt_us = 0
            total_so_other = 0

            For i As Integer = 0 To tbb.Rows.Count - 1

                ''algoritma sticker reguler

                Dim adpt_rglr As New MySqlDataAdapter("select * from data_cust where reg = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_rglr As New DataSet
                Dim tbb_rglr As New DataTable
                adpt_rglr.Fill(ds_rglr, "emp_rglr")
                adpt_rglr.Fill(tbb_rglr)
                If tbb_rglr.Rows.Count > 0 Then
                    total_so_reg += tbb(i)(8)
                End If

                ''algoritma sticker eropa

                Dim adpt_eropa As New MySqlDataAdapter("select * from data_cust where eropa = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_eropa As New DataSet
                Dim tbb_eropa As New DataTable
                adpt_eropa.Fill(ds_eropa, "emp_eropa")
                adpt_eropa.Fill(tbb_eropa)
                If tbb_eropa.Rows.Count > 0 Then
                    total_so_eu += tbb(i)(8)
                End If

                ''algoritma sticker saso

                Dim adpt_saso As New MySqlDataAdapter("select * from data_cust where saso = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_saso As New DataSet
                Dim tbb_saso As New DataTable
                adpt_saso.Fill(ds_saso, "emp_saso")
                adpt_saso.Fill(tbb_saso)
                If tbb_saso.Rows.Count > 0 Then
                    total_so_saso += tbb(i)(8)
                End If

                ''algoritma sticker gso

                Dim adpt_gso As New MySqlDataAdapter("select * from data_cust where gso = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_gso As New DataSet
                Dim tbb_gso As New DataTable
                adpt_gso.Fill(ds_gso, "emp_gso")
                adpt_gso.Fill(tbb_gso)
                If tbb_gso.Rows.Count > 0 Then
                    total_so_gso += tbb(i)(8)
                End If

                ''algoritma sticker inmetro

                Dim adpt_inmetro As New MySqlDataAdapter("select * from data_cust where inmetro = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_inmetro As New DataSet
                Dim tbb_inmetro As New DataTable
                adpt_inmetro.Fill(ds_inmetro, "emp_inmetro")
                adpt_inmetro.Fill(tbb_inmetro)
                If tbb_inmetro.Rows.Count > 0 Then
                    total_so_inmetro += tbb(i)(8)
                End If

                ''algoritma sticker sendas

                Dim adpt_sendas As New MySqlDataAdapter("select * from data_cust where sendas = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_sendas As New DataSet
                Dim tbb_sendas As New DataTable
                adpt_sendas.Fill(ds_sendas, "emp_sendas")
                adpt_sendas.Fill(tbb_sendas)
                If tbb_sendas.Rows.Count > 0 Then
                    total_so_sendas += tbb(i)(8)
                End If

                ''algoritma sticker alves

                Dim adpt_alves As New MySqlDataAdapter("select * from data_cust where alves = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_alves As New DataSet
                Dim tbb_alves As New DataTable
                adpt_alves.Fill(ds_alves, "emp_alves")
                adpt_alves.Fill(tbb_alves)
                If tbb_alves.Rows.Count > 0 Then
                    total_so_alves += tbb(i)(8)
                End If

                ''algoritma sticker viramsum

                Dim adpt_viramsum As New MySqlDataAdapter("select * from data_cust where viramsum = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_viramsum As New DataSet
                Dim tbb_viramsum As New DataTable
                adpt_viramsum.Fill(ds_viramsum, "emp_viramsum")
                adpt_viramsum.Fill(tbb_viramsum)
                If tbb_viramsum.Rows.Count > 0 Then
                    total_so_viramsum += tbb(i)(8)
                End If

                ''algoritma sticker tis

                Dim adpt_tis As New MySqlDataAdapter("select * from data_cust where tis = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_tis As New DataSet
                Dim tbb_tis As New DataTable
                adpt_tis.Fill(ds_tis, "emp_tis")
                adpt_tis.Fill(tbb_tis)
                If tbb_tis.Rows.Count > 0 Then
                    total_so_tis += tbb(i)(8)
                End If

                ''algoritma no sticker

                Dim adpt_no As New MySqlDataAdapter("select * from data_cust where no_sticker = 'OK'  and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_no As New DataSet
                Dim tbb_no As New DataTable
                adpt_no.Fill(ds_no, "emp_no")
                adpt_no.Fill(tbb_no)
                If tbb_no.Rows.Count > 0 Then
                    total_so_no_stic += tbb(i)(8)
                End If

                ''algoritma US

                If tbb(i)(2).ToString = "GT" And tbb(i)(2).ToString = "AMP Tires" And tbb(i)(2).ToString = "Rocky Mountain" Then

                    Dim adpt_gtus As New MySqlDataAdapter("select * from data_cust where usa = 'OK'  and cust = '" & tbb(i)(4).ToString & "'", con)
                    Dim ds_gtus As New DataSet
                    Dim tbb_gtus As New DataTable
                    adpt_gtus.Fill(ds_gtus, "emp_gtus")
                    adpt_gtus.Fill(tbb_gtus)
                    If tbb_gtus.Rows.Count > 0 Then
                        total_so_gt_us += tbb(i)(8)
                    End If

                ElseIf tbb(i)(2).ToString = "Dextero" Then

                    ''algoritma rfid

                    Dim adpt_gtus As New MySqlDataAdapter("select * from data_cust where rfid = 'OK'  and cust = '" & tbb(i)(4).ToString & "'", con)
                    Dim ds_gtus As New DataSet
                    Dim tbb_gtus As New DataTable
                    adpt_gtus.Fill(ds_gtus, "emp_gtus")
                    adpt_gtus.Fill(tbb_gtus)
                    If tbb_gtus.Rows.Count > 0 Then
                        total_so_rfid += tbb(i)(8)
                    End If


                    ''algoritma sticker iraq

                    Dim adpt_iraq As New MySqlDataAdapter("select * from data_cust where iraq = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                    Dim ds_iraq As New DataSet
                    Dim tbb_iraq As New DataTable
                    adpt_iraq.Fill(ds_iraq, "emp_iraq")
                    adpt_iraq.Fill(tbb_iraq)
                    If tbb_iraq.Rows.Count > 0 Then
                        total_so_irak += tbb(i)(8)
                    End If

                Else
                End If

            Next

        Else
            MsgBox("Data tidak ditemukan! Periksa item Code!")
        End If


        lbl_jmlh_reguler.Text = total_so_reg
        lbl_jmlh_eropa.Text = total_so_eu
        lbl_jmlh_saso.Text = total_so_saso
        lbl_jmlh_gso.Text = total_so_gso
        lbl_jmlh_inmetro.Text = total_so_inmetro
        lbl_jmlh_sendas.Text = total_so_sendas
        lbl_jmlh_irak.Text = total_so_irak
        lbl_jmlh_rfid.Text = total_so_rfid
        lbl_jmlh_alves.Text = total_so_alves
        lbl_jmlh_viramsum.Text = total_so_viramsum
        lbl_jmlh_tis.Text = total_so_tis
        lbl_jmlh_no_sticker.Text = total_so_no_stic
        lbl_jmlh_gt_us.Text = total_so_gt_us

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        dataa.Rows.Clear()
        Dim query_status As String = ""
        If status_so.Text = "ENTERED" Then
            query_status = " AND status = 'ENTERED'"
        ElseIf status_so.Text = "BOOKED" Then
            query_status = " AND status = 'BOOKED'"
        ElseIf status_so.Text = "AWAITING SHIPPING" Then
            query_status = " AND status = 'AWAITING_SHIPPING'"
        ElseIf status_so.Text = "CLOSED" Then
            query_status = " AND status = 'CLOSED'"
        ElseIf status_so.Text = "ALL" Then
            query_status = ""
        Else
            MsgBox("Tipe status tidak sesuai!")
            Return
        End If

        Dim adpt As New MySqlDataAdapter("select * from data_so where code = '" & data1.cod_item.ToString & "'" & query_status & "", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)

        If tbb.Rows.Count > 0 Then


            For i As Integer = 0 To tbb.Rows.Count - 1

                ''algoritma sticker reguler

                Dim adpt_rglr As New MySqlDataAdapter("select * from data_cust where reg = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_rglr As New DataSet
                Dim tbb_rglr As New DataTable
                adpt_rglr.Fill(ds_rglr, "emp_rglr")
                adpt_rglr.Fill(tbb_rglr)
                If tbb_rglr.Rows.Count > 0 Then
                    dataa.Rows.Add(tbb(i)(0), tbb(i)(1), tbb(i)(2), tbb(i)(3), tbb(i)(4), tbb(i)(5), tbb(i)(6), tbb(i)(7), tbb(i)(8), tbb(i)(9), tbb(i)(10), tbb(i)(11), tbb(i)(12))
                End If


            Next


        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dataa.Rows.Clear()
        Dim query_status As String = ""
        If status_so.Text = "ENTERED" Then
            query_status = " AND status = 'ENTERED'"
        ElseIf status_so.Text = "BOOKED" Then
            query_status = " AND status = 'BOOKED'"
        ElseIf status_so.Text = "AWAITING SHIPPING" Then
            query_status = " AND status = 'AWAITING_SHIPPING'"
        ElseIf status_so.Text = "CLOSED" Then
            query_status = " AND status = 'CLOSED'"
        ElseIf status_so.Text = "ALL" Then
            query_status = ""
        Else
            MsgBox("Tipe status tidak sesuai!")
            Return
        End If

        Dim adpt As New MySqlDataAdapter("select * from data_so where code = '" & data1.cod_item.ToString & "'" & query_status & "", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)

        If tbb.Rows.Count > 0 Then


            For i As Integer = 0 To tbb.Rows.Count - 1

                ''algoritma sticker reguler

                Dim adpt_rglr As New MySqlDataAdapter("select * from data_cust where eropa = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_rglr As New DataSet
                Dim tbb_rglr As New DataTable
                adpt_rglr.Fill(ds_rglr, "emp_rglr")
                adpt_rglr.Fill(tbb_rglr)
                If tbb_rglr.Rows.Count > 0 Then
                    dataa.Rows.Add(tbb(i)(0), tbb(i)(1), tbb(i)(2), tbb(i)(3), tbb(i)(4), tbb(i)(5), tbb(i)(6), tbb(i)(7), tbb(i)(8), tbb(i)(9), tbb(i)(10), tbb(i)(11), tbb(i)(12))
                End If


            Next


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dataa.Rows.Clear()
        Dim query_status As String = ""
        If status_so.Text = "ENTERED" Then
            query_status = " AND status = 'ENTERED'"
        ElseIf status_so.Text = "BOOKED" Then
            query_status = " AND status = 'BOOKED'"
        ElseIf status_so.Text = "AWAITING SHIPPING" Then
            query_status = " AND status = 'AWAITING_SHIPPING'"
        ElseIf status_so.Text = "CLOSED" Then
            query_status = " AND status = 'CLOSED'"
        ElseIf status_so.Text = "ALL" Then
            query_status = ""
        Else
            MsgBox("Tipe status tidak sesuai!")
            Return
        End If

        Dim adpt As New MySqlDataAdapter("select * from data_so where code = '" & data1.cod_item.ToString & "'" & query_status & "", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)

        If tbb.Rows.Count > 0 Then


            For i As Integer = 0 To tbb.Rows.Count - 1

                ''algoritma sticker reguler

                Dim adpt_rglr As New MySqlDataAdapter("select * from data_cust where saso = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_rglr As New DataSet
                Dim tbb_rglr As New DataTable
                adpt_rglr.Fill(ds_rglr, "emp_rglr")
                adpt_rglr.Fill(tbb_rglr)
                If tbb_rglr.Rows.Count > 0 Then
                    dataa.Rows.Add(tbb(i)(0), tbb(i)(1), tbb(i)(2), tbb(i)(3), tbb(i)(4), tbb(i)(5), tbb(i)(6), tbb(i)(7), tbb(i)(8), tbb(i)(9), tbb(i)(10), tbb(i)(11), tbb(i)(12))
                End If


            Next


        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        dataa.Rows.Clear()
        Dim query_status As String = ""
        If status_so.Text = "ENTERED" Then
            query_status = " AND status = 'ENTERED'"
        ElseIf status_so.Text = "BOOKED" Then
            query_status = " AND status = 'BOOKED'"
        ElseIf status_so.Text = "AWAITING SHIPPING" Then
            query_status = " AND status = 'AWAITING_SHIPPING'"
        ElseIf status_so.Text = "CLOSED" Then
            query_status = " AND status = 'CLOSED'"
        ElseIf status_so.Text = "ALL" Then
            query_status = ""
        Else
            MsgBox("Tipe status tidak sesuai!")
            Return
        End If

        Dim adpt As New MySqlDataAdapter("select * from data_so where code = '" & data1.cod_item.ToString & "'" & query_status & "", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)

        If tbb.Rows.Count > 0 Then


            For i As Integer = 0 To tbb.Rows.Count - 1

                ''algoritma sticker reguler

                Dim adpt_rglr As New MySqlDataAdapter("select * from data_cust where gso = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_rglr As New DataSet
                Dim tbb_rglr As New DataTable
                adpt_rglr.Fill(ds_rglr, "emp_rglr")
                adpt_rglr.Fill(tbb_rglr)
                If tbb_rglr.Rows.Count > 0 Then
                    dataa.Rows.Add(tbb(i)(0), tbb(i)(1), tbb(i)(2), tbb(i)(3), tbb(i)(4), tbb(i)(5), tbb(i)(6), tbb(i)(7), tbb(i)(8), tbb(i)(9), tbb(i)(10), tbb(i)(11), tbb(i)(12))
                End If


            Next


        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        dataa.Rows.Clear()
        Dim query_status As String = ""
        If status_so.Text = "ENTERED" Then
            query_status = " AND status = 'ENTERED'"
        ElseIf status_so.Text = "BOOKED" Then
            query_status = " AND status = 'BOOKED'"
        ElseIf status_so.Text = "AWAITING SHIPPING" Then
            query_status = " AND status = 'AWAITING_SHIPPING'"
        ElseIf status_so.Text = "CLOSED" Then
            query_status = " AND status = 'CLOSED'"
        ElseIf status_so.Text = "ALL" Then
            query_status = ""
        Else
            MsgBox("Tipe status tidak sesuai!")
            Return
        End If

        Dim adpt As New MySqlDataAdapter("select * from data_so where code = '" & data1.cod_item.ToString & "'" & query_status & "", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)

        If tbb.Rows.Count > 0 Then


            For i As Integer = 0 To tbb.Rows.Count - 1

                ''algoritma sticker reguler

                Dim adpt_rglr As New MySqlDataAdapter("select * from data_cust where inmetro = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_rglr As New DataSet
                Dim tbb_rglr As New DataTable
                adpt_rglr.Fill(ds_rglr, "emp_rglr")
                adpt_rglr.Fill(tbb_rglr)
                If tbb_rglr.Rows.Count > 0 Then
                    dataa.Rows.Add(tbb(i)(0), tbb(i)(1), tbb(i)(2), tbb(i)(3), tbb(i)(4), tbb(i)(5), tbb(i)(6), tbb(i)(7), tbb(i)(8), tbb(i)(9), tbb(i)(10), tbb(i)(11), tbb(i)(12))
                End If


            Next


        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        dataa.Rows.Clear()
        Dim query_status As String = ""
        If status_so.Text = "ENTERED" Then
            query_status = " AND status = 'ENTERED'"
        ElseIf status_so.Text = "BOOKED" Then
            query_status = " AND status = 'BOOKED'"
        ElseIf status_so.Text = "AWAITING SHIPPING" Then
            query_status = " AND status = 'AWAITING_SHIPPING'"
        ElseIf status_so.Text = "CLOSED" Then
            query_status = " AND status = 'CLOSED'"
        ElseIf status_so.Text = "ALL" Then
            query_status = ""
        Else
            MsgBox("Tipe status tidak sesuai!")
            Return
        End If

        Dim adpt As New MySqlDataAdapter("select * from data_so where code = '" & data1.cod_item.ToString & "'" & query_status & "", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)

        If tbb.Rows.Count > 0 Then


            For i As Integer = 0 To tbb.Rows.Count - 1

                ''algoritma sticker reguler

                Dim adpt_rglr As New MySqlDataAdapter("select * from data_cust where sendas = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_rglr As New DataSet
                Dim tbb_rglr As New DataTable
                adpt_rglr.Fill(ds_rglr, "emp_rglr")
                adpt_rglr.Fill(tbb_rglr)
                If tbb_rglr.Rows.Count > 0 Then
                    dataa.Rows.Add(tbb(i)(0), tbb(i)(1), tbb(i)(2), tbb(i)(3), tbb(i)(4), tbb(i)(5), tbb(i)(6), tbb(i)(7), tbb(i)(8), tbb(i)(9), tbb(i)(10), tbb(i)(11), tbb(i)(12))
                End If


            Next


        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        dataa.Rows.Clear()
        Dim query_status As String = ""
        If status_so.Text = "ENTERED" Then
            query_status = " AND status = 'ENTERED'"
        ElseIf status_so.Text = "BOOKED" Then
            query_status = " AND status = 'BOOKED'"
        ElseIf status_so.Text = "AWAITING SHIPPING" Then
            query_status = " AND status = 'AWAITING_SHIPPING'"
        ElseIf status_so.Text = "CLOSED" Then
            query_status = " AND status = 'CLOSED'"
        ElseIf status_so.Text = "ALL" Then
            query_status = ""
        Else
            MsgBox("Tipe status tidak sesuai!")
            Return
        End If

        Dim adpt As New MySqlDataAdapter("select * from data_so where code = '" & data1.cod_item.ToString & "'" & query_status & "", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)

        If tbb.Rows.Count > 0 Then


            For i As Integer = 0 To tbb.Rows.Count - 1

                ''algoritma sticker reguler

                If tbb(i)(2).ToString = "Dextero" Then

                    Dim adpt_rglr As New MySqlDataAdapter("select * from data_cust where iraq = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                    Dim ds_rglr As New DataSet
                    Dim tbb_rglr As New DataTable
                    adpt_rglr.Fill(ds_rglr, "emp_rglr")
                    adpt_rglr.Fill(tbb_rglr)
                    If tbb_rglr.Rows.Count > 0 Then
                        dataa.Rows.Add(tbb(i)(0), tbb(i)(1), tbb(i)(2), tbb(i)(3), tbb(i)(4), tbb(i)(5), tbb(i)(6), tbb(i)(7), tbb(i)(8), tbb(i)(9), tbb(i)(10), tbb(i)(11), tbb(i)(12))
                    End If

                End If

            Next


        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        dataa.Rows.Clear()
        Dim query_status As String = ""
        If status_so.Text = "ENTERED" Then
            query_status = " AND status = 'ENTERED'"
        ElseIf status_so.Text = "BOOKED" Then
            query_status = " AND status = 'BOOKED'"
        ElseIf status_so.Text = "AWAITING SHIPPING" Then
            query_status = " AND status = 'AWAITING_SHIPPING'"
        ElseIf status_so.Text = "CLOSED" Then
            query_status = " AND status = 'CLOSED'"
        ElseIf status_so.Text = "ALL" Then
            query_status = ""
        Else
            MsgBox("Tipe status tidak sesuai!")
            Return
        End If

        Dim adpt As New MySqlDataAdapter("select * from data_so where code = '" & data1.cod_item.ToString & "'" & query_status & "", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)

        If tbb.Rows.Count > 0 Then


            For i As Integer = 0 To tbb.Rows.Count - 1

                ''algoritma sticker reguler

                If tbb(i)(2).ToString = "Dextero" Then

                    Dim adpt_rglr As New MySqlDataAdapter("select * from data_cust where rfid = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                    Dim ds_rglr As New DataSet
                    Dim tbb_rglr As New DataTable
                    adpt_rglr.Fill(ds_rglr, "emp_rglr")
                    adpt_rglr.Fill(tbb_rglr)
                    If tbb_rglr.Rows.Count > 0 Then
                        dataa.Rows.Add(tbb(i)(0), tbb(i)(1), tbb(i)(2), tbb(i)(3), tbb(i)(4), tbb(i)(5), tbb(i)(6), tbb(i)(7), tbb(i)(8), tbb(i)(9), tbb(i)(10), tbb(i)(11), tbb(i)(12))
                    End If

                End If

            Next


        End If
    End Sub

    Private Sub tmbl_Click(sender As Object, e As EventArgs) Handles tmbl.Click
        dataa.Rows.Clear()
        Dim query_status As String = ""
        If status_so.Text = "ENTERED" Then
            query_status = " AND status = 'ENTERED'"
        ElseIf status_so.Text = "BOOKED" Then
            query_status = " AND status = 'BOOKED'"
        ElseIf status_so.Text = "AWAITING SHIPPING" Then
            query_status = " AND status = 'AWAITING_SHIPPING'"
        ElseIf status_so.Text = "CLOSED" Then
            query_status = " AND status = 'CLOSED'"
        ElseIf status_so.Text = "ALL" Then
            query_status = ""
        Else
            MsgBox("Tipe status tidak sesuai!")
            Return
        End If

        Dim adpt As New MySqlDataAdapter("select * from data_so where code = '" & data1.cod_item.ToString & "'" & query_status & "", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)

        If tbb.Rows.Count > 0 Then


            For i As Integer = 0 To tbb.Rows.Count - 1

                ''algoritma sticker reguler

                Dim adpt_rglr As New MySqlDataAdapter("select * from data_cust where no_sticker = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_rglr As New DataSet
                Dim tbb_rglr As New DataTable
                adpt_rglr.Fill(ds_rglr, "emp_rglr")
                adpt_rglr.Fill(tbb_rglr)
                If tbb_rglr.Rows.Count > 0 Then
                    dataa.Rows.Add(tbb(i)(0), tbb(i)(1), tbb(i)(2), tbb(i)(3), tbb(i)(4), tbb(i)(5), tbb(i)(6), tbb(i)(7), tbb(i)(8), tbb(i)(9), tbb(i)(10), tbb(i)(11), tbb(i)(12))
                End If


            Next


        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        dataa.Rows.Clear()
        Dim query_status As String = ""
        If status_so.Text = "ENTERED" Then
            query_status = " AND status = 'ENTERED'"
        ElseIf status_so.Text = "BOOKED" Then
            query_status = " AND status = 'BOOKED'"
        ElseIf status_so.Text = "AWAITING SHIPPING" Then
            query_status = " AND status = 'AWAITING_SHIPPING'"
        ElseIf status_so.Text = "CLOSED" Then
            query_status = " AND status = 'CLOSED'"
        ElseIf status_so.Text = "ALL" Then
            query_status = ""
        Else
            MsgBox("Tipe status tidak sesuai!")
            Return
        End If

        Dim adpt As New MySqlDataAdapter("select * from data_so where code = '" & data1.cod_item.ToString & "'" & query_status & "", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)

        If tbb.Rows.Count > 0 Then


            For i As Integer = 0 To tbb.Rows.Count - 1

                ''algoritma sticker reguler

                Dim adpt_rglr As New MySqlDataAdapter("select * from data_cust where alves = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_rglr As New DataSet
                Dim tbb_rglr As New DataTable
                adpt_rglr.Fill(ds_rglr, "emp_rglr")
                adpt_rglr.Fill(tbb_rglr)
                If tbb_rglr.Rows.Count > 0 Then
                    dataa.Rows.Add(tbb(i)(0), tbb(i)(1), tbb(i)(2), tbb(i)(3), tbb(i)(4), tbb(i)(5), tbb(i)(6), tbb(i)(7), tbb(i)(8), tbb(i)(9), tbb(i)(10), tbb(i)(11), tbb(i)(12))
                End If


            Next


        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        dataa.Rows.Clear()
        Dim query_status As String = ""
        If status_so.Text = "ENTERED" Then
            query_status = " AND status = 'ENTERED'"
        ElseIf status_so.Text = "BOOKED" Then
            query_status = " AND status = 'BOOKED'"
        ElseIf status_so.Text = "AWAITING SHIPPING" Then
            query_status = " AND status = 'AWAITING_SHIPPING'"
        ElseIf status_so.Text = "CLOSED" Then
            query_status = " AND status = 'CLOSED'"
        ElseIf status_so.Text = "ALL" Then
            query_status = ""
        Else
            MsgBox("Tipe status tidak sesuai!")
            Return
        End If

        Dim adpt As New MySqlDataAdapter("select * from data_so where code = '" & data1.cod_item.ToString & "'" & query_status & "", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)

        If tbb.Rows.Count > 0 Then


            For i As Integer = 0 To tbb.Rows.Count - 1

                ''algoritma sticker reguler

                Dim adpt_rglr As New MySqlDataAdapter("select * from data_cust where viramsum = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_rglr As New DataSet
                Dim tbb_rglr As New DataTable
                adpt_rglr.Fill(ds_rglr, "emp_rglr")
                adpt_rglr.Fill(tbb_rglr)
                If tbb_rglr.Rows.Count > 0 Then
                    dataa.Rows.Add(tbb(i)(0), tbb(i)(1), tbb(i)(2), tbb(i)(3), tbb(i)(4), tbb(i)(5), tbb(i)(6), tbb(i)(7), tbb(i)(8), tbb(i)(9), tbb(i)(10), tbb(i)(11), tbb(i)(12))
                End If


            Next


        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        dataa.Rows.Clear()
        Dim query_status As String = ""
        If status_so.Text = "ENTERED" Then
            query_status = " AND status = 'ENTERED'"
        ElseIf status_so.Text = "BOOKED" Then
            query_status = " AND status = 'BOOKED'"
        ElseIf status_so.Text = "AWAITING SHIPPING" Then
            query_status = " AND status = 'AWAITING_SHIPPING'"
        ElseIf status_so.Text = "CLOSED" Then
            query_status = " AND status = 'CLOSED'"
        ElseIf status_so.Text = "ALL" Then
            query_status = ""
        Else
            MsgBox("Tipe status tidak sesuai!")
            Return
        End If

        Dim adpt As New MySqlDataAdapter("select * from data_so where code = '" & data1.cod_item.ToString & "'" & query_status & "", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)
        If tbb.Rows.Count > 0 Then


            For i As Integer = 0 To tbb.Rows.Count - 1

                ''algoritma sticker reguler

                Dim adpt_rglr As New MySqlDataAdapter("select * from data_cust where tis = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                Dim ds_rglr As New DataSet
                Dim tbb_rglr As New DataTable
                adpt_rglr.Fill(ds_rglr, "emp_rglr")
                adpt_rglr.Fill(tbb_rglr)
                If tbb_rglr.Rows.Count > 0 Then
                    dataa.Rows.Add(tbb(i)(0), tbb(i)(1), tbb(i)(2), tbb(i)(3), tbb(i)(4), tbb(i)(5), tbb(i)(6), tbb(i)(7), tbb(i)(8), tbb(i)(9), tbb(i)(10), tbb(i)(11), tbb(i)(12))
                End If


            Next


        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        dataa.Rows.Clear()
        Dim query_status As String = ""
        If status_so.Text = "ENTERED" Then
            query_status = " AND status = 'ENTERED'"
        ElseIf status_so.Text = "BOOKED" Then
            query_status = " AND status = 'BOOKED'"
        ElseIf status_so.Text = "AWAITING SHIPPING" Then
            query_status = " AND status = 'AWAITING_SHIPPING'"
        ElseIf status_so.Text = "CLOSED" Then
            query_status = " AND status = 'CLOSED'"
        ElseIf status_so.Text = "ALL" Then
            query_status = ""
        Else
            MsgBox("Tipe status tidak sesuai!")
            Return
        End If

        Dim adpt As New MySqlDataAdapter("select * from data_so where code = '" & data1.cod_item.ToString & "'" & query_status & "", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)

        If tbb.Rows.Count > 0 Then


            For i As Integer = 0 To tbb.Rows.Count - 1

                ''algoritma sticker usa

                If tbb(i)(2).ToString = "GT" Or tbb(i)(2).ToString = "AMP Tires" Or tbb(i)(2).ToString = "Rocky Mountain" Then

                    Dim adpt_rglr As New MySqlDataAdapter("select * from data_cust where usa = 'OK' and cust = '" & tbb(i)(4).ToString & "'", con)
                    Dim ds_rglr As New DataSet
                    Dim tbb_rglr As New DataTable
                    adpt_rglr.Fill(ds_rglr, "emp_rglr")
                    adpt_rglr.Fill(tbb_rglr)
                    If tbb_rglr.Rows.Count > 0 Then
                        dataa.Rows.Add(tbb(i)(0), tbb(i)(1), tbb(i)(2), tbb(i)(3), tbb(i)(4), tbb(i)(5), tbb(i)(6), tbb(i)(7), tbb(i)(8), tbb(i)(9), tbb(i)(10), tbb(i)(11), tbb(i)(12))
                    End If
                End If

            Next


        End If
    End Sub
End Class