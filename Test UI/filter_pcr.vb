Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Public Class filter_pcr
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Dim con As New MySqlConnection(db)
    Dim cmd As MySqlCommand
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim list_item_cd As New List(Of String)
        For Each cd In combo_item_cd.Items
            list_item_cd.Add(cd)
        Next

        Dim adpt As New MySqlDataAdapter("select * from data_so", con)
        Dim ds As New DataSet
        Dim tbb As New DataTable
        adpt.Fill(ds, "emp")
        adpt.Fill(tbb)
                
        /'''

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
        Dim baris_baru As Integer

        osheet.Range("B" & baris.ToString).Value = "No."
        osheet.Range("C" & baris.ToString).Value = "Item Code"
        osheet.Range("D" & baris.ToString).Value = "Deskripsi"
        osheet.Range("F" & baris.ToString).Value = "Pcs/Day"
        osheet.Range("G" & baris.ToString).Value = "Stock On Hand Gudang Bahan"
        osheet.Range("H" & baris.ToString).Value = "Estimasi Habis (Hari)"
        osheet.Range("I" & baris.ToString).Value = "Qty"
        osheet.Range("J" & baris.ToString).Value = "PO"
        osheet.Range("K" & baris.ToString).Value = "Supplier"
        osheet.Range("L" & baris.ToString).Value = "Need By Date"
        osheet.Range("M" & baris.ToString).Value = "Tanggal Shortage"
        osheet.Range("E" & baris.ToString).Value = "Prodplan"



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

    Private Sub file_direktori_TextChanged(sender As Object, e As EventArgs) Handles file_direktori.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class