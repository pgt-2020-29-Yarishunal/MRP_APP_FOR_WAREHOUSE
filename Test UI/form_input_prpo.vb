Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class form_input_prpo
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Dim con As New MySqlConnection(db)
    Dim tahun_ini As String = Format(Date.Now(), "yy").ToString()
    Dim bulan_ini As String = Format(Date.Now(), "MMM").ToString().ToUpper
    Dim hari_ini As String = Format(Date.Now(), "dd").ToString()
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Month.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Month.Text.ToString = "" Or teksfile.Text.ToString = "" Or cut_off_text.Text.ToString = "" Then
            MsgBox("Mohon lengkapi data terlebih dahulu!")
            Return
        End If
        Dim cmd As MySqlCommand, cmd1 As MySqlCommand
        Dim del As MySqlCommand, del1 As MySqlCommand
        Dim hist As MySqlCommand
        con.Open()
        Dim adpt1 As New MySqlDataAdapter("SELECT * FROM list_pr_po WHERE cut_off = '" & cut_off_text.Text.ToString & "' and bulan = '" + Month.Text.ToString + "'", con)
        Dim ds1 As New DataSet
        Dim tbb1 As New DataTable
        adpt1.Fill(ds1, "emp1")
        adpt1.Fill(tbb1)
        If tbb1.Rows.Count() > 0 Then
            Dim result = MessageBox.Show("PRPO dengan tanggal cut off " + cut_off_text.Text.ToString() + " sudah terinput, apakah anda ingin meng-update nya?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then

                Try

                    If check_OR.CheckState = CheckState.Checked Or check_OT.CheckState = CheckState.Checked Then

                    Else

                        del = New MySqlCommand("DELETE FROM pr_po WHERE cut_off = '" & cut_off_text.Text.ToString & "' and bulan = '" + Month.Text.ToString + "'", con)
                        del1 = New MySqlCommand("DELETE from list_pr_po where cut_off = '" & cut_off_text.Text.ToString & "' and bulan = '" + Month.Text.ToString + "'", con)
                        del.ExecuteNonQuery()
                        del1.ExecuteNonQuery()

                    End If

                Catch ex As Exception
                    MsgBox("Data lama Gagal Di Hapus")
                    con.Close()
                    Return
                End Try

            Else
                con.Close()
                Return
            End If

            For i As Integer = 0 To dataa.Rows.Count - 2 Step +1
                cmd = New MySqlCommand("INSERT INTO pr_po (item_code, no_pr, qty_pr, qty_rcpt, outs_sisa, bulan, cut_off) VALUES (@code ,@pr ,@qty_pr, @rcpt, @outs, @month, @cutf)", con)
                cmd.Parameters.AddWithValue("@code", dataa.Rows(i).Cells(0).Value.ToString())
                cmd.Parameters.AddWithValue("@pr", dataa.Rows(i).Cells(1).Value.ToString())
                cmd.Parameters.AddWithValue("@qty_pr", dataa.Rows(i).Cells(2).Value.ToString())
                cmd.Parameters.AddWithValue("@rcpt", dataa.Rows(i).Cells(3).Value.ToString())
                cmd.Parameters.AddWithValue("@outs", dataa.Rows(i).Cells(4).Value.ToString())
                cmd.Parameters.AddWithValue("@month", Month.Text.ToString())
                cmd.Parameters.AddWithValue("@cutf", cut_off_text.Text.ToString())
                cmd.ExecuteNonQuery()
            Next

            If check_OR.CheckState = CheckState.Checked Or check_OT.CheckState = CheckState.Checked Then
            Else

                cmd1 = New MySqlCommand("INSERT INTO list_pr_po (bulan, cut_off) VALUES (@buln, @ct_of)", con)
                cmd1.Parameters.AddWithValue("@buln", Month.Text.ToString)
                cmd1.Parameters.AddWithValue("@ct_of", cut_off_text.Text.ToString)
                cmd1.ExecuteNonQuery()

            End If

            hist = New MySqlCommand("UPDATE histori_report SET prpo = @val", con)
            hist.Parameters.AddWithValue("@val", DateTime.Now)
            hist.ExecuteNonQuery()
            MessageBox.Show("Data Dimasukkan")
        Else
            For i As Integer = 0 To dataa.Rows.Count - 2 Step +1
                cmd = New MySqlCommand("INSERT INTO pr_po (item_code, no_pr, qty_pr, qty_rcpt, outs_sisa, bulan, cut_off) VALUES (@code ,@pr ,@qty_pr, @rcpt, @outs, @month, @cutf)", con)
                cmd.Parameters.AddWithValue("@code", dataa.Rows(i).Cells(0).Value.ToString())
                cmd.Parameters.AddWithValue("@pr", dataa.Rows(i).Cells(1).Value.ToString())
                cmd.Parameters.AddWithValue("@qty_pr", dataa.Rows(i).Cells(2).Value.ToString())
                cmd.Parameters.AddWithValue("@rcpt", dataa.Rows(i).Cells(3).Value.ToString())
                cmd.Parameters.AddWithValue("@outs", dataa.Rows(i).Cells(4).Value.ToString())
                cmd.Parameters.AddWithValue("@month", Month.Text.ToString())
                cmd.Parameters.AddWithValue("@cutf", cut_off_text.Text.ToString())
                cmd.ExecuteNonQuery()
            Next

            cmd1 = New MySqlCommand("INSERT INTO list_pr_po (bulan, cut_off) VALUES (@buln, @ct_of)", con)
            cmd1.Parameters.AddWithValue("@buln", Month.Text.ToString)
            cmd1.Parameters.AddWithValue("@ct_of", cut_off_text.Text.ToString)
            cmd1.ExecuteNonQuery()

            hist = New MySqlCommand("UPDATE histori_report SET prpo = @val", con)
            hist.Parameters.AddWithValue("@val", DateTime.Now)
            hist.ExecuteNonQuery()
            MessageBox.Show("Data Dimasukkan")
        End If
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xlapp As Excel.Application
        Dim xlworkbook As Excel.Workbook
        Dim xlworksheet As Excel.Worksheet
        Dim xlrange As Excel.Range
        Dim xlrow As Integer

        Dim filename As String
        Dim data(0 To 100) As String

        With OpenFileDialog1
            .Filter = "Excel Office| *.xls;*.xlsx;*.xlsm"
            .ShowDialog()
            filename = .FileName
        End With
        dataa.Rows.Clear()
        teksfile.Text = filename
        If teksfile.Text <> String.Empty And teksfile.Text <> "OpenFileDialog1" Then
            xlapp = New Excel.Application
            xlworkbook = xlapp.Workbooks.Open(teksfile.Text)

            If check_OT.CheckState = CheckState.Checked Then

                xlworksheet = xlworkbook.Worksheets("LAMPIRAN BULAN H")
                xlrange = xlworksheet.UsedRange
                For xlrow = 17 To xlrange.Rows.Count
                    If xlrange.Cells(xlrow, 2).Text = "" Then
                        Exit For
                    End If
                    Dim receipt As Double
                    dataa.Rows.Add(xlrange.Cells(xlrow, 2).Text, xlrange.Cells(9, 3).Text, xlrange.Cells(xlrow, 14).Text, 0, xlrange.Cells(xlrow, 14).Text)
                    Dim prc As Integer = (xlrow / xlrange.Rows.Count) * 100
                    ProgressBar1.Value = prc
                    label_progress.Text = CStr(prc) + "%"
                Next

            ElseIf check_OR.CheckState = CheckState.Checked Then


                xlworksheet = xlworkbook.Worksheets("LAMPIRAN BULAN H+1")
                xlrange = xlworksheet.UsedRange
                For xlrow = 17 To xlrange.Rows.Count
                    If xlrange.Cells(xlrow, 2).Text = "" Then
                        Exit For
                    End If
                    Dim receipt As Double
                    dataa.Rows.Add(xlrange.Cells(xlrow, 2).Text, xlrange.Cells(9, 3).Text, xlrange.Cells(xlrow, 13).Text, 0, xlrange.Cells(xlrow, 13).Text)
                    Dim prc As Integer = (xlrow / xlrange.Rows.Count) * 100
                    ProgressBar1.Value = prc
                    label_progress.Text = CStr(prc) + "%"
                Next


            Else

                xlworksheet = xlworkbook.Worksheets("Sheet1")
                xlrange = xlworksheet.UsedRange
                For xlrow = 4 To xlrange.Rows.Count
                    If xlrange.Cells(xlrow, 5).Text = "" Then
                        Exit For
                    End If
                    Dim receipt As Double
                    dataa.Rows.Add(xlrange.Cells(xlrow, 5).Text, xlrange.Cells(xlrow, 3).Text, xlrange.Cells(xlrow, 9).Text, -xlrange.Cells(xlrow, 13).Text, xlrange.Cells(xlrow, 15).Text)
                    Dim prc As Integer = (xlrow / xlrange.Rows.Count) * 100
                    ProgressBar1.Value = prc
                    label_progress.Text = CStr(prc) + "%"
                Next

            End If

            xlworkbook.Close()
            xlapp.Quit()
            MessageBox.Show("Data Selesai Diambil")

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dataa.Rows.Clear()
    End Sub

    Private Sub cut_off_text_TextChanged(sender As Object, e As EventArgs) Handles cut_off_text.Leave
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

    Private Sub form_input_prpo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cut_off_text.Text = hari_ini + "-" + bulan_ini + "-" + tahun_ini
    End Sub

End Class