Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class form_input_outs
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
                    dataa.Rows.Add(xlrange.Cells(xlrow, 1).Text, xlrange.Cells(xlrow, 2).Text, xlrange.Cells(xlrow, 3).Text, xlrange.Cells(xlrow, 5).Text, xlrange.Cells(xlrow, 6).Text, xlrange.Cells(xlrow, 7).Text)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dataa.Rows.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If jenis_outs.Text.ToString = "" Or teksfile.Text.ToString = "" Then
            MsgBox("Mohon lengkapi data terlebih dahulu!")
            Return
        End If
        Dim cmd As MySqlCommand, cmd1 As MySqlCommand
        Dim del As MySqlCommand, del1 As MySqlCommand
        Dim hist As MySqlCommand
        con.Open()

        Dim nama_table As String
        If jenis_outs.Text.ToString = "Outstanding MRP" Then

            nama_table = "outstanding_mrp"

            Dim adpt14_1 As New MySqlDataAdapter("SELECT * FROM list_outstanding_mrp WHERE tgl_cut_off = '" & cut_off_text.Text.ToString & "'", con)
            Dim ds14_1 As New DataSet
            Dim tbb14_1 As New DataTable
            adpt14_1.Fill(ds14_1, "emp14_1")
            adpt14_1.Fill(tbb14_1)
            If tbb14_1.Rows.Count() > 0 Then

                Dim result = MessageBox.Show("Data Outstanding Order pada tanggal cut off " + cut_off_text.Text.ToString() + " sudah terinput, apakah anda ingin meng-update nya?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then

                    Try
                        del = New MySqlCommand("DELETE FROM outstanding_mrp WHERE cut_off = '" & cut_off_text.Text.ToString & "'", con)
                        del1 = New MySqlCommand("DELETE FROM list_outstanding_mrp WHERE tgl_cut_off = '" & cut_off_text.Text.ToString & "'", con)
                        del.ExecuteNonQuery()
                        del1.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                        con.Close()
                        Return
                    End Try

                Else
                    con.Close()
                    Return
                End If

            End If

                Try
                For i As Integer = 0 To dataa.Rows.Count - 2 Step +1
                    cmd = New MySqlCommand("INSERT INTO outstanding_mrp (item_code, quantity, po, supplier, date, cut_off) VALUES (@code ,@qty ,@po, @supp, @date, @cutf)", con)
                    cmd.Parameters.AddWithValue("@code", dataa.Rows(i).Cells(0).Value.ToString())
                    cmd.Parameters.AddWithValue("@qty", dataa.Rows(i).Cells(2).Value.ToString())
                    cmd.Parameters.AddWithValue("@po", dataa.Rows(i).Cells(3).Value.ToString())
                    cmd.Parameters.AddWithValue("@supp", dataa.Rows(i).Cells(4).Value.ToString())
                    cmd.Parameters.AddWithValue("@date", dataa.Rows(i).Cells(5).Value.ToString())
                    cmd.Parameters.AddWithValue("@cutf", cut_off_text.Text.ToString())
                    cmd.ExecuteNonQuery()
                Next

                cmd1 = New MySqlCommand("INSERT INTO list_outstanding_mrp (tgl_cut_off) VALUES (@cut)", con)
                cmd1.Parameters.AddWithValue("@cut", cut_off_text.Text.ToString)
                cmd1.ExecuteNonQuery()

                hist = New MySqlCommand("UPDATE histori_report SET outstanding_mrp = @val", con)
                hist.Parameters.AddWithValue("@val", DateTime.Now)
                hist.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Data Dimasukkan")
            Catch erro As Exception
                MsgBox(erro.ToString)
            End Try

        ElseIf jenis_outs.Text.ToString = "Outstanding Daily" Then

            nama_table = "outstanding"
            Try
                del = New MySqlCommand("DELETE FROM outstanding", con)

                del.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Try
                For i As Integer = 0 To dataa.Rows.Count - 2 Step +1
                    cmd = New MySqlCommand("INSERT INTO outstanding (item_code, quantity, po, supplier, date) VALUES (@code ,@qty ,@po, @supp, @date)", con)
                    cmd.Parameters.AddWithValue("@code", dataa.Rows(i).Cells(0).Value.ToString())
                    cmd.Parameters.AddWithValue("@qty", dataa.Rows(i).Cells(2).Value.ToString())
                    cmd.Parameters.AddWithValue("@po", dataa.Rows(i).Cells(3).Value.ToString())
                    cmd.Parameters.AddWithValue("@supp", dataa.Rows(i).Cells(4).Value.ToString())
                    cmd.Parameters.AddWithValue("@date", dataa.Rows(i).Cells(5).Value.ToString())
                    cmd.ExecuteNonQuery()
                Next

                hist = New MySqlCommand("UPDATE histori_report SET outstanding = @val", con)
                hist.Parameters.AddWithValue("@val", DateTime.Now)
                hist.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Data Dimasukkan")
            Catch erro As Exception
                MsgBox(erro.ToString)
            End Try

        Else
            MsgBox("Jenis outstanding belum terisi!")
            Return
        End If

        con.Close()
    End Sub

    Private Sub form_input_outs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cut_off_text.Text = hari_ini + "-" + bulan_ini + "-" + tahun_ini
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

    Private Sub jenis_outs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jenis_outs.SelectedIndexChanged
        If jenis_outs.Text.ToString = "Outstanding MRP" Then
        Else
            cut_off_text.Text = ""
            cut_off_text.Enabled = False
        End If
    End Sub

End Class