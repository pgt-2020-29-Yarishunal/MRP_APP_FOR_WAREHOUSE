Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class form_input_data_gdban
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Dim con As New MySqlConnection(db)
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
                    If xlrange.Cells(xlrow, 2).Text = "" Then
                        Exit For
                    End If
                    dataa.Rows.Add(xlrange.Cells(xlrow, 2).Text, xlrange.Cells(xlrow, 3).Text, xlrange.Cells(xlrow, 4).Text)
                    Dim prc As Integer = (xlrow / xlrange.Rows.Count) * 100
                    ProgressBar1.Value = prc
                    label_progress.Text = CStr(prc) + "%"
                Next
                xlworkbook.Close()
                xlapp.Quit()
                MessageBox.Show("Data Selesai Diambil")
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Month.Text.ToString = "" Or jeniss.Text.ToString = "" Or teksfile.Text.ToString = "" Then
            MsgBox("Mohon lengkapi data terlebih dahulu!")
            Return
        End If
        Dim cmd As MySqlCommand
        Dim del As MySqlCommand
        Dim del1 As MySqlCommand
        con.Open()

        Try

            Dim adpt1 As New MySqlDataAdapter("SELECT * FROM data_gd_ban WHERE jenis = '" & jeniss.Text.ToString() & "' AND bulan = '" & Month.Text.ToString() & "'", con)
            Dim ds1 As New DataSet
            Dim tbb1 As New DataTable
            adpt1.Fill(ds1, "emp1")
            adpt1.Fill(tbb1)
            If tbb1.Rows.Count() > 0 Then
                Dim result = MessageBox.Show("Data Gudang ban pada bulan " + Month.Text.ToString() + " untuk kategori " + jeniss.Text.ToString() + " sudah terinput, apakah anda ingin meng-update nya?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    del = New MySqlCommand("DELETE FROM data_gd_ban WHERE jenis = '" & jeniss.Text.ToString() & "' AND bulan = '" & Month.Text.ToString() & "'", con)
                    del.ExecuteNonQuery()
                    For i As Integer = 0 To dataa.Rows.Count - 2 Step +1
                        cmd = New MySqlCommand("INSERT INTO data_gd_ban (item_code, stock_sticker, stock_polos, jenis, bulan) VALUES ( @cod ,@sticker , @polos, @jns , @bln)", con)
                        cmd.Parameters.AddWithValue("@cod", dataa.Rows(i).Cells(0).Value.ToString())
                        cmd.Parameters.AddWithValue("@sticker", dataa.Rows(i).Cells(1).Value.ToString())
                        cmd.Parameters.AddWithValue("@polos", dataa.Rows(i).Cells(2).Value.ToString())
                        cmd.Parameters.AddWithValue("@jns", jeniss.Text.ToString())
                        cmd.Parameters.AddWithValue("@bln", Month.Text.ToString())
                        cmd.ExecuteNonQuery()
                    Next i
                    MessageBox.Show("Data Selesai Dimasukkan")
                ElseIf result = DialogResult.No Then
                End If
            Else
                For i As Integer = 0 To dataa.Rows.Count - 2 Step +1
                    cmd = New MySqlCommand("INSERT INTO data_gd_ban (item_code, stock_sticker, stock_polos, jenis, bulan) VALUES ( @cod ,@sticker , @polos, @jns , @bln)", con)
                    cmd.Parameters.AddWithValue("@cod", dataa.Rows(i).Cells(0).Value.ToString())
                    cmd.Parameters.AddWithValue("@sticker", dataa.Rows(i).Cells(1).Value.ToString())
                    cmd.Parameters.AddWithValue("@polos", dataa.Rows(i).Cells(2).Value.ToString())
                    cmd.Parameters.AddWithValue("@jns", jeniss.Text.ToString())
                    cmd.Parameters.AddWithValue("@bln", Month.Text.ToString())
                    cmd.ExecuteNonQuery()
                Next i
                MessageBox.Show("Data Selesai Dimasukkan")
            End If
        Catch err As Exception
            MsgBox(err.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dataa.Rows.Clear()
    End Sub

    Private Sub form_input_data_gdban_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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