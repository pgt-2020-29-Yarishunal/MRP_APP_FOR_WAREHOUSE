Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class form_input_inwh
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Dim con As New MySqlConnection(db)
    Dim tahun_ini As String = Format(Date.Now(), "yy").ToString()
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
                    dataa.Rows.Add(xlrange.Cells(xlrow, 1).Text, xlrange.Cells(xlrow, 35).Text)
                    Dim prc As Integer = (xlrow / xlrange.Rows.Count) * 100
                    ProgressBar1.Value = prc
                    Label6.Text = CStr(prc) + "%"
                Next
                xlworkbook.Close()
                xlapp.Quit()
                MessageBox.Show("Data Selesai Diambil")
            Catch err As Exception
                Me.Show()
                MsgBox(err.ToString())
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If jeniss.Text.ToString = "" Or teksfile.Text.ToString = "" Then
            MsgBox("Mohon lengkapi data terlebih dahulu!")
            Return
        End If
        Dim cmd As MySqlCommand
        Dim del As MySqlCommand
        Dim hist As MySqlCommand
        con.Open()

        Try

            Dim adpt1 As New MySqlDataAdapter("SELECT * FROM in_wh WHERE jenis = '" & jeniss.Text.ToString() & "' and cut_off = '" & tgl_cut_text.Text.ToString & "'", con)
            Dim ds1 As New DataSet
            Dim tbb1 As New DataTable
            adpt1.Fill(ds1, "emp1")
            adpt1.Fill(tbb1)
            If tbb1.Rows.Count() > 0 Then
                Dim result = MessageBox.Show("Data In Warehouse pada jenis " + jeniss.Text.ToString() + " sudah terinput, apakah anda ingin meng-update nya?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    del = New MySqlCommand("DELETE FROM in_wh WHERE jenis = '" & jeniss.Text.ToString() & "' and cut_off = '" & tgl_cut_text.Text.ToString & "'", con)
                    del.ExecuteNonQuery()
                    For i As Integer = 0 To dataa.Rows.Count - 2 Step +1
                        cmd = New MySqlCommand("INSERT INTO in_wh (item_fg, qty, jenis, cut_off) VALUES ( @cod, @quty, @jns, @cutf)", con)
                        cmd.Parameters.AddWithValue("@cod", dataa.Rows(i).Cells(0).Value.ToString())
                        cmd.Parameters.AddWithValue("@quty", dataa.Rows(i).Cells(1).Value.ToString())
                        cmd.Parameters.AddWithValue("@jns", jeniss.Text.ToString())
                        cmd.Parameters.AddWithValue("@cutf", tgl_cut_text.Text.ToString())
                        cmd.ExecuteNonQuery()
                    Next i
                    hist = New MySqlCommand("UPDATE histori_report SET in_wh = @val", con)
                    hist.Parameters.AddWithValue("@val", DateTime.Now)
                    hist.ExecuteNonQuery()
                    MessageBox.Show("Data Selesai Dimasukkan")
                ElseIf result = DialogResult.No Then

                End If
            Else
                For i As Integer = 0 To dataa.Rows.Count - 2 Step +1
                    cmd = New MySqlCommand("INSERT INTO in_wh (item_fg, qty, jenis, cut_off) VALUES ( @cod, @quty, @jns, @cutf)", con)
                    cmd.Parameters.AddWithValue("@cod", dataa.Rows(i).Cells(0).Value.ToString())
                    cmd.Parameters.AddWithValue("@quty", dataa.Rows(i).Cells(1).Value.ToString())
                    cmd.Parameters.AddWithValue("@jns", jeniss.Text.ToString())
                    cmd.Parameters.AddWithValue("@cutf", tgl_cut_text.Text.ToString())
                    cmd.ExecuteNonQuery()
                Next
                hist = New MySqlCommand("UPDATE histori_report SET in_wh = @val", con)
                hist.Parameters.AddWithValue("@val", DateTime.Now)
                hist.ExecuteNonQuery()
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

    Private Sub form_input_inwh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tgl_cut_text.Text = hari_ini + "-" + bulan_ini + "-" + tahun_ini

        Dim adpt As New MySqlDataAdapter("select * from kategori", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)
        For i = 0 To tbb.Rows.Count - 1
            jeniss.Items.Add(tbb(i)(1))
        Next
    End Sub

    Private Sub tgl_cut_text_TextChanged(sender As Object, e As EventArgs) Handles tgl_cut_text.Leave
        tgl_cut_text.Text = tgl_cut_text.Text.ToUpper()
    End Sub

End Class