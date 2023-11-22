Public Class upload_customer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub rd_button_manual_CheckedChanged(sender As Object, e As EventArgs) Handles rd_button_manual.CheckedChanged
        If rd_button_manual.Checked Then
            label_item_code.Visible = True
            tmbl_insert.Visible = True
            lbl_kategori.Visible = True
            combo_kategori.Visible = True
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
            tmbl_insert.Visible = False
            lbl_kategori.Visible = False
            combo_kategori.Visible = False

            lbl_input.Visible = True
            teksfile.Visible = True
            tmbl_search.Visible = True
            ProgressBar1.Visible = True
            Label10.Visible = True
        End If
    End Sub

    Private Sub upload_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label_item_code.Visible = False
        tmbl_insert.Visible = False
        lbl_kategori.Visible = False
        combo_kategori.Visible = False

        lbl_input.Visible = True
        teksfile.Visible = True
        tmbl_search.Visible = True
        ProgressBar1.Visible = True
        Label10.Visible = True
    End Sub
End Class