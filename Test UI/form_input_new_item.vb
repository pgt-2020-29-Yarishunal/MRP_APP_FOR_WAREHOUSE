Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Public Class form_input_new_item
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Dim con As New MySqlConnection(db)
    Private Sub form_input_new_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label_item_code.Visible = False
        label_item_code_2.Visible = False
        label_item_desk.Visible = False
        label_item_safety.Visible = False
        label_item_tire_1.Visible = False
        label_item_tire_2.Visible = False
        label_item_tire_3.Visible = False
        label_item_tire_4.Visible = False
        label_item_tire_5.Visible = False
        teks_item_code.Visible = False
        teks_item_code2.Visible = False
        teks_item_desk.Visible = False
        teks_item_safety.Visible = False
        teks_item_tire1.Visible = False
        teks_item_tire2.Visible = False
        teks_item_tire3.Visible = False
        teks_item_tire4.Visible = False
        teks_item_tire5.Visible = False
        tmbl_insert.Visible = False
        teks_sub_kategori.Visible = False
        lbl_sub.Visible = False
        rd_button_upload.Checked = True
        Dim adpt As New MySqlDataAdapter("select * from kategori", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)
        For i = 0 To tbb.Rows.Count - 1
            combo_kategori.Items.Add(tbb(i)(1))
        Next
    End Sub

    Private Sub rd_button_manual_CheckedChanged(sender As Object, e As EventArgs) Handles rd_button_manual.CheckedChanged
        If rd_button_manual.Checked Then
            label_item_code.Visible = True
            label_item_code_2.Visible = True
            label_item_desk.Visible = True
            label_item_safety.Visible = True
            label_item_tire_1.Visible = True
            label_item_tire_2.Visible = True
            label_item_tire_3.Visible = True
            label_item_tire_4.Visible = True
            label_item_tire_5.Visible = True
            teks_item_code.Visible = True
            teks_item_code2.Visible = True
            teks_item_desk.Visible = True
            teks_item_safety.Visible = True
            teks_item_tire1.Visible = True
            teks_item_tire2.Visible = True
            teks_item_tire3.Visible = True
            teks_item_tire4.Visible = True
            teks_item_tire5.Visible = True
            tmbl_insert.Visible = True
            teks_sub_kategori.Visible = True
            lbl_sub.Visible = True
            lbl_input.Visible = False
            teksfile.Visible = False
            tmbl_search.Visible = False
            ProgressBar1.Visible = False
            Label10.Visible = False
        End If
    End Sub

    Private Sub rd_button_upload_CheckedChanged(sender As Object, e As EventArgs) Handles rd_button_upload.CheckedChanged
        If rd_button_upload.Checked Then
            label_item_code.Visible = False
            label_item_code_2.Visible = False
            label_item_desk.Visible = False
            label_item_safety.Visible = False
            label_item_tire_1.Visible = False
            label_item_tire_2.Visible = False
            label_item_tire_3.Visible = False
            label_item_tire_4.Visible = False
            label_item_tire_5.Visible = False
            teks_item_code.Visible = False
            teks_item_code2.Visible = False
            teks_item_desk.Visible = False
            teks_item_safety.Visible = False
            teks_item_tire1.Visible = False
            teks_item_tire2.Visible = False
            teks_item_tire3.Visible = False
            teks_item_tire4.Visible = False
            teks_item_tire5.Visible = False
            tmbl_insert.Visible = False
            teks_sub_kategori.Visible = False
            lbl_sub.Visible = False
            lbl_input.Visible = True
            teksfile.Visible = True
            tmbl_search.Visible = True
            ProgressBar1.Visible = True
            Label10.Visible = True
        End If
    End Sub

    Private Sub rd_button_upload_Clicked(sender As Object, e As EventArgs) Handles rd_button_upload.Click
        rd_button_upload.Checked = True
    End Sub

    Private Sub rd_button_manual_Clicked(sender As Object, e As EventArgs) Handles rd_button_manual.Click
        rd_button_manual.Checked = True
    End Sub

    Private Sub tmbl_search_Click(sender As Object, e As EventArgs) Handles tmbl_search.Click
        If combo_kategori.Text.ToString = "" Then
            MsgBox("MOHON ISI KATEGORI ITEM!")
            Return
        End If
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
        teksfile.Text = filename
        If teksfile.Text <> String.Empty And teksfile.Text <> "OpenFileDialog1" Then
            xlapp = New Excel.Application
            Try
                xlworkbook = xlapp.Workbooks.Open(teksfile.Text)
                xlworksheet = xlworkbook.Worksheets("Sheet1")
                xlrange = xlworksheet.UsedRange
                For xlrow = 2 To xlrange.Rows.Count
                    If xlrange.Cells(xlrow, 2).Text = "" Then
                        Dim prc As Integer = (xlrow / xlrange.Rows.Count) * 100
                        ProgressBar1.Value = prc
                        Label10.Text = CStr(prc) + "%"
                        Exit For
                    Else
                        Dim prc As Integer = (xlrow / xlrange.Rows.Count) * 100
                        ProgressBar1.Value = prc
                        Label10.Text = CStr(prc) + "%"
                    End If
                    dataa.Rows.Add(xlrange.Cells(xlrow, 2).Text, xlrange.Cells(xlrow, 3).Text, xlrange.Cells(xlrow, 4).Text, combo_kategori.Text, xlrange.Cells(xlrow, 5).Text, xlrange.Cells(xlrow, 6).Text, xlrange.Cells(xlrow, 7).Text, xlrange.Cells(xlrow, 8).Text, xlrange.Cells(xlrow, 9).Text, xlrange.Cells(xlrow, 10).Text, xlrange.Cells(xlrow, 11).Text)
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

    Private Sub tmbl_insert_Click(sender As Object, e As EventArgs) Handles tmbl_insert.Click
        dataa.Rows.Add(teks_item_code.Text.ToString(), teks_item_code2.Text.ToString(), teks_item_desk.Text.ToString(), combo_kategori.Text.ToString(), teks_item_tire1.Text.ToString(), teks_item_tire2.Text.ToString(), teks_item_tire3.Text.ToString(), teks_item_tire4.Text.ToString(), teks_item_tire5.Text.ToString(), teks_item_safety.Text.ToString(), teks_sub_kategori.Text.ToString)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If combo_kategori.Text.ToString = "" Then
            MsgBox("MOHON ISI KATEGORI ITEM!")
            Return
        End If
        Dim cmd As MySqlCommand, insrt As MySqlCommand
        con.Open()
        Try
            For i As Integer = 0 To dataa.Rows.Count - 2 Step +1
                cmd = New MySqlCommand("INSERT INTO data_master (item_code, item_code_1, deskripsi, jenis,item_tire,item_tire1,item_tire2,item_tire3,item_tire4,safety_stock,sub_kategori) VALUES (@code,@code1,@desk,@jenis,@item_tire,@item_tire1,@item_tire2,@item_tire3,@item_tire4,@safety,@sub)", con)
                cmd.Parameters.AddWithValue("@code", dataa.Rows(i).Cells(0).Value.ToString())
                cmd.Parameters.AddWithValue("@code1", dataa.Rows(i).Cells(1).Value.ToString())
                cmd.Parameters.AddWithValue("@desk", dataa.Rows(i).Cells(2).Value.ToString())
                cmd.Parameters.AddWithValue("@jenis", dataa.Rows(i).Cells(3).Value.ToString())
                cmd.Parameters.AddWithValue("@item_tire", dataa.Rows(i).Cells(4).Value.ToString())
                cmd.Parameters.AddWithValue("@item_tire1", dataa.Rows(i).Cells(5).Value.ToString())
                cmd.Parameters.AddWithValue("@item_tire2", dataa.Rows(i).Cells(6).Value.ToString())
                cmd.Parameters.AddWithValue("@item_tire3", dataa.Rows(i).Cells(7).Value.ToString())
                cmd.Parameters.AddWithValue("@item_tire4", dataa.Rows(i).Cells(8).Value.ToString())
                cmd.Parameters.AddWithValue("@safety", dataa.Rows(i).Cells(9).Value.ToString())
                cmd.Parameters.AddWithValue("@sub", dataa.Rows(i).Cells(10).Value.ToString())
                cmd.ExecuteNonQuery()
                Dim adpt As New MySqlDataAdapter("select * from list_sub_kategori where jenis = '" & dataa.Rows(i).Cells(3).Value.ToString() & "' and sub_kategori = '" & dataa.Rows(i).Cells(10).Value.ToString() & "'", con)
                Dim ds As New DataSet
                Dim tbb As New DataTable
                adpt.Fill(ds, "emp")
                adpt.Fill(tbb)
                If tbb.Rows.Count > 0 Then
                Else
                    insrt = New MySqlCommand("INSERT INTO list_sub_kategori (jenis, sub_kategori) VALUES (@jns,@sub)", con)
                    insrt.Parameters.AddWithValue("@jns", dataa.Rows(i).Cells(3).Value.ToString())
                    insrt.Parameters.AddWithValue("@sub", dataa.Rows(i).Cells(10).Value.ToString())
                    insrt.ExecuteNonQuery()
                End If
            Next
            MessageBox.Show("Data Dimasukkan")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dataa.Rows.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim new_form = New form_edit_item_manual
        new_form.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim new_form = New edit_kategori
        new_form.Show()
    End Sub
End Class