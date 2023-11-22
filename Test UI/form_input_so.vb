Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class form_input_so
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Dim con As New MySqlConnection(db)
    Private Sub form_input_so_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                For xlrow = 4 To xlrange.Rows.Count
                    If xlrange.Cells(xlrow, 1).Text = "" Then
                        Exit For
                    End If
                    dataa.Rows.Add(xlrange.Cells(xlrow, 1).Text, xlrange.Cells(xlrow, 3).Text, xlrange.Cells(xlrow, 4).Text, xlrange.Cells(xlrow, 5).Text, xlrange.Cells(xlrow, 6).Text, xlrange.Cells(xlrow, 8).Text, xlrange.Cells(xlrow, 9).Text, xlrange.Cells(xlrow, 10).Text, xlrange.Cells(xlrow, 11).Text, xlrange.Cells(xlrow, 13).Text, xlrange.Cells(xlrow, 15).Text, xlrange.Cells(xlrow, 16).Text, xlrange.Cells(xlrow, 17).Text, xlrange.Cells(xlrow, 20).Text, xlrange.Cells(xlrow, 34).Text)
                    Dim prc As Integer = (xlrow / xlrange.Rows.Count) * 100
                    ProgressBar1.Value = prc
                    label_progress.Text = CStr(prc) + "%"
                Next
                xlworkbook.Close()
                xlapp.Quit()
                MessageBox.Show("Data Selesai Diambil")
            Catch err As Exception
                Me.Show()
                teksfile.Text = ""
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        new_cust.Rows.Clear()

        If teksfile.Text.ToString = "" Then
            MsgBox("Mohon lengkapi data terlebih dahulu!")
            Return
        End If
        Dim cmd As MySqlCommand
        Dim del As MySqlCommand
        Dim hist As MySqlCommand
        con.Open()

        Try
            del = New MySqlCommand("DELETE FROM data_so", con)
            del.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            For i As Integer = 0 To dataa.Rows.Count - 2 Step +1
                cmd = New MySqlCommand("INSERT INTO data_so (no_order, book_date, brand, type_order, bill_to, code, type_item, description, qty, status, no_invoice, loading_date, sch_ship_date, ship_loc) VALUES (@no ,@book_dt , @br,@type_ord, @bill, @code_itm, @type_itm, @desk, @quantity, @stat, @no_inv, @load, @sch_ship, @ship_loc)", con)
                cmd.Parameters.AddWithValue("@no", dataa.Rows(i).Cells(0).Value.ToString())
                cmd.Parameters.AddWithValue("@book_dt", dataa.Rows(i).Cells(1).Value.ToString())
                cmd.Parameters.AddWithValue("@br", dataa.Rows(i).Cells(2).Value.ToString())
                cmd.Parameters.AddWithValue("@type_ord", dataa.Rows(i).Cells(3).Value.ToString())
                cmd.Parameters.AddWithValue("@bill", dataa.Rows(i).Cells(4).Value.ToString())
                cmd.Parameters.AddWithValue("@code_itm", dataa.Rows(i).Cells(5).Value.ToString())
                cmd.Parameters.AddWithValue("@type_itm", dataa.Rows(i).Cells(6).Value.ToString())
                cmd.Parameters.AddWithValue("@desk", dataa.Rows(i).Cells(7).Value.ToString())
                cmd.Parameters.AddWithValue("@quantity", dataa.Rows(i).Cells(8).Value.ToString())
                cmd.Parameters.AddWithValue("@stat", dataa.Rows(i).Cells(9).Value.ToString())
                cmd.Parameters.AddWithValue("@no_inv", dataa.Rows(i).Cells(10).Value.ToString())
                cmd.Parameters.AddWithValue("@load", dataa.Rows(i).Cells(11).Value.ToString())
                cmd.Parameters.AddWithValue("@sch_ship", dataa.Rows(i).Cells(12).Value.ToString())
                cmd.Parameters.AddWithValue("@ship_loc", dataa.Rows(i).Cells(13).Value.ToString())
                cmd.ExecuteNonQuery()

                Dim adpt As New MySqlDataAdapter("select * from data_cust where cust = '" & dataa.Rows(i).Cells(4).Value.ToString() & "'", con)
                Dim ds As New DataSet
                Dim tbb As New DataTable
                adpt.Fill(ds, "emp")
                adpt.Fill(tbb)
                If tbb.Rows.Count < 1 Then
                    new_cust.Rows.Add(dataa.Rows(i).Cells(4).Value.ToString())
                End If

            Next

            hist = New MySqlCommand("UPDATE histori_report SET report_so = @val", con)
            hist.Parameters.AddWithValue("@val", DateTime.Now)
            hist.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Data Dimasukkan")

        Catch erro As Exception
            MsgBox(erro.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dataa.Rows.Clear()
    End Sub
End Class