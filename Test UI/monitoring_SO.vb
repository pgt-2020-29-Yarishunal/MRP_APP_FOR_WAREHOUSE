Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class monitoring_SO
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Public Shared cod_item As String
    Public shared desk_item As String
    Dim con As New MySqlConnection(db)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim teks_ket As String = ""

        Dim adpt_daily As New MySqlDataAdapter("select * from histori_report", con)
        Dim ds_daily As New DataSet
        Dim tbb_daily As New DataTable
        adpt_daily.Fill(ds_daily, "emp_daily")
        adpt_daily.Fill(tbb_daily)

        Dim adpt_demand As New MySqlDataAdapter("select * from list_demand where jenis = '" & jeniss.Text.ToString & "' and bulan = '" & Format(Date.Now, "MMMM").ToUpper & "'", con)
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

            If Format(Date.Parse(tbb_daily(0)(6)), "dd-MMMM-yy") <> Format(Date.Now, "dd-MMMM-yy") Then

                If teks_ket = "" Then
                    teks_ket += "Warning! report SO tidak terupdate"
                Else
                    teks_ket += " - Report SO tidak terupdate"
                End If

            End If

        End If

        Label10.Text = teks_ket
        dataa.Rows.Clear()

        Dim adpt As New MySqlDataAdapter("select * from data_so where code = '" & jeniss.Text.ToString & "-1'", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)
        Dim code As String, desk As String
        If tbb.Rows.Count > 0 Then
            code = tbb(0)(5)
            desk = tbb(0)(7)
            cod_item = code
            desk_item = desk

            Dim total_so_all As Integer = 0
            Dim total_so_entered As Integer = 0
            Dim total_so_booked As Integer = 0
            Dim total_so_as As Integer = 0
            Dim total_so_closed As Integer = 0
            Dim total_so_exp As Integer = 0
            Dim total_so_rpl As Integer = 0

            For awal As Integer = 0 To tbb.Rows.Count - 1
                total_so_all += tbb(awal)(8)
                If tbb(awal)(9) = "ENTERED" Then
                    total_so_entered += tbb(awal)(8)
                End If
                If tbb(awal)(9) = "BOOKED" Then
                    total_so_booked += tbb(awal)(8)
                End If
                If tbb(awal)(9) = "AWAITING_SHIPPING" Then
                    total_so_as += tbb(awal)(8)
                End If
                If tbb(awal)(9) = "CLOSED" Then
                    total_so_closed += tbb(awal)(8)
                End If
                If tbb(awal)(3) = "EXP-Sales" Then
                    total_so_exp += tbb(awal)(8)
                End If
                If tbb(awal)(3) = "REP-Sales-Radial" Then
                    total_so_rpl += tbb(awal)(8)
                End If

            Next

            dataa.Rows.Add(code, desk, "", total_so_all)
            lbl_jmlh_reguler.Text = total_so_rpl
            lbl_jmlh_eropa.Text = total_so_exp
            lbl_jmlh_saso.Text = total_so_entered
            lbl_jmlh_gso.Text = total_so_booked
            lbl_jmlh_inmetro.Text = total_so_closed
            lbl_jmlh_others.Text = total_so_as

        Else
                MsgBox("DATA TIDAK DITEMUKAN!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If jeniss.Text.ToString = "" Then
            MsgBox("Mohon isi item Code!")
            Return
        Else
            cod_item = jeniss.Text.ToString + "-1"
            Dim new_form = New breakdown_cust
            new_form.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim new_form = New filter_item_sticker_so
        new_form.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If file_direktori.Text = "" Then
            MsgBox("Isi folder tujuan untuk save file!")
            Return
        Else
        End If

        For i = 0 To 150
            Dim adpt_daily As New MySqlDataAdapter("select * from histori_report", con)
            Dim ds_daily As New DataSet
            Dim tbb_daily As New DataTable
            adpt_daily.Fill(ds_daily, "emp_daily")
            adpt_daily.Fill(tbb_daily)

            Dim adpt_demand As New MySqlDataAdapter("select * from list_demand where jenis = '" & jeniss.Text.ToString & "' and bulan = '" & Format(Date.Now, "MMMM").ToUpper & "'", con)
            Dim ds_demand As New DataSet
            Dim tbb_demand As New DataTable
            adpt_demand.Fill(ds_demand, "emp_demand")
            adpt_demand.Fill(tbb_demand)

            Dim adpt_stck_gd As New MySqlDataAdapter("select * from data_gd_ban where jenis = '" & jeniss.Text.ToString & "' and bulan = '" & Format(Date.Now, "MMMM").ToUpper & "'", con)
            Dim ds_stck_gd As New DataSet
            Dim tbb_stck_gd As New DataTable
            adpt_stck_gd.Fill(ds_stck_gd, "emp_stck_gd")
            adpt_stck_gd.Fill(tbb_stck_gd)
        Next

        MsgBox("File Telah Di buat!")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
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

End Class