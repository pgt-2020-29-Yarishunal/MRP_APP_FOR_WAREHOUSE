Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class Form1
    Dim tombol_ As Button
    Dim ganti_form As Form
    Dim data As New Db
    Dim db As String = data.dtbs.ToString()
    Dim con As New MySqlConnection(db)
    Private Sub tombol_test_1_Click(sender As Object, e As EventArgs)
        active_button(sender)
        change_form(New form_input_prpo)
    End Sub

    Private Sub active_button(objek As Object)
        disable_button()
        tombol_ = CType(objek, Button)
        tombol_.BackColor = Color.FromArgb(0, 0, 0)
    End Sub
    Private Sub disable_button()
        If tombol_ IsNot Nothing Then
            tombol_.BackColor = Color.FromArgb(51, 51, 72)
        End If
    End Sub

    Private Sub change_form(formnya As Form)
        If ganti_form IsNot Nothing Then
            ganti_form.Close()
        End If
        ganti_form = formnya
        lbl_judul_page.Text = formnya.Text
        formnya.TopLevel = False
        formnya.FormBorderStyle = FormBorderStyle.None
        formnya.Dock = DockStyle.Fill
        desktop_panel.Controls.Add(formnya)
        desktop_panel.Tag = formnya
        formnya.BringToFront()
        formnya.Show()
    End Sub

    Private Sub tombol_test_2_Click(sender As Object, e As EventArgs)
        active_button(sender)
        change_form(New Form_input_stock)
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        change_form(New home)
        Me.ControlBox = False
        Me.Text = String.Empty
        Me.DoubleBuffered = True
        input_prpo.Visible = False
        input_new.Visible = False
        input_data_gd_ban.Visible = False
        input_demand.Visible = False
        input_stock.Visible = False
        input_outs.Visible = False
        input_in_wh.Visible = False
        lbl_daily.Visible = False
        lbl_stock_mrp.Visible = False
        lbl_outs.Visible = False
        lbl_outs_mrp.Visible = False
        lbl_prpo.Visible = False
        btn_refresh.Visible = False
        teks_outstanding.Visible = False
        teks_outstanding_mrp.Visible = False
        teks_stock_daily.Visible = False
        teks_stock_mrp.Visible = False
        PRPO.Visible = False
        input_so.Visible = False
        btn_customer.Visible = False
        tombol_hide.Location = New Point(13, 64)
        lbl_time.Location = New Point(46, 74)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tombol_ = CType(sender, Button)

        If input_new.Visible Then
            tombol_.Image = Test_UI.My.Resources.arrow_204_16
            input_prpo.Visible = False
            input_new.Visible = False
            input_data_gd_ban.Visible = False
            input_demand.Visible = False
            input_stock.Visible = False
            input_outs.Visible = False
            input_in_wh.Visible = False
            input_so.Visible = False
            btn_customer.Visible = False
        Else
            tombol_.Image = Test_UI.My.Resources.arrow_141_16
            input_prpo.Visible = True
            input_new.Visible = True
            input_data_gd_ban.Visible = True
            input_demand.Visible = True
            input_stock.Visible = True
            input_outs.Visible = True
            input_in_wh.Visible = True
            input_so.Visible = True
            btn_customer.Visible = True
        End If
    End Sub

    Private Sub input_prpo_Click(sender As Object, e As EventArgs) Handles input_prpo.Click
        change_form(New form_input_prpo)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        change_form(New home)
    End Sub

    Private Sub input_stock_Click(sender As Object, e As EventArgs) Handles input_stock.Click
        change_form(New Form_input_stock)
    End Sub

    Private Sub input_new_Click(sender As Object, e As EventArgs) Handles input_new.Click
        change_form(New form_input_new_item)
    End Sub

    Private Sub input_outs_Click(sender As Object, e As EventArgs) Handles input_outs.Click
        change_form(New form_input_outs)
    End Sub

    Private Sub input_demand_Click(sender As Object, e As EventArgs) Handles input_demand.Click
        change_form(New form_input_demand)
    End Sub

    Private Sub input_data_gd_ban_Click(sender As Object, e As EventArgs) Handles input_data_gd_ban.Click
        change_form(New form_input_data_gdban)
    End Sub

    Private Sub input_in_wh_Click(sender As Object, e As EventArgs) Handles input_in_wh.Click
        change_form(New form_input_inwh)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        change_form(New create_mrp)
    End Sub

    Private Sub monitor_Click(sender As Object, e As EventArgs) Handles input_so.Click
        change_form(New form_input_so)
    End Sub

    Private Sub desktop_panel_Paint(sender As Object, e As PaintEventArgs) Handles desktop_panel.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Dim adpt_stck As New MySqlDataAdapter("select * from histori_report", con)
        Dim ds_stck As New DataSet
        Dim tbb_stck As New DataTable
        adpt_stck.Fill(ds_stck, "emp_stck")
        adpt_stck.Fill(tbb_stck)
        If tbb_stck.Rows.Count > 0 Then
            teks_stock_daily.Text = Date.Parse(tbb_stck(0)(0)).ToString("d-MMM-y H:mm:ss")
            teks_stock_mrp.Text = Date.Parse(tbb_stck(0)(1)).ToString("d-MMM-y H:mm:ss")
            teks_outstanding.Text = Date.Parse(tbb_stck(0)(2)).ToString("d-MMM-y H:mm:ss")
            teks_outstanding_mrp.Text = Date.Parse(tbb_stck(0)(5)).ToString("d-MMM-y H:mm:ss")
            PRPO.Text = Date.Parse(tbb_stck(0)(3)).ToString("d-MMM-y H:mm:ss")
        Else
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles tombol_hide.Click
        tombol_ = CType(sender, Button)
        If btn_refresh.Visible Then
            tombol_.Image = Test_UI.My.Resources.arrow_31_16
            lbl_daily.Visible = False
            lbl_stock_mrp.Visible = False
            lbl_outs.Visible = False
            lbl_outs_mrp.Visible = False
            lbl_prpo.Visible = False
            btn_refresh.Visible = False
            teks_outstanding.Visible = False
            teks_outstanding_mrp.Visible = False
            teks_stock_daily.Visible = False
            teks_stock_mrp.Visible = False
            PRPO.Visible = False
            tombol_hide.Location = New Point(13, 64)
            lbl_time.Location = New Point(46, 74)
        Else
            tombol_.Image = Test_UI.My.Resources.arrow_96_16
            lbl_daily.Visible = True
            lbl_stock_mrp.Visible = True
            lbl_outs.Visible = True
            lbl_outs_mrp.Visible = True
            lbl_prpo.Visible = True
            btn_refresh.Visible = True
            teks_outstanding.Visible = True
            teks_outstanding_mrp.Visible = True
            teks_stock_daily.Visible = True
            teks_stock_mrp.Visible = True
            PRPO.Visible = True
            tombol_hide.Location = New Point(736, 64)
            lbl_time.Location = New Point(769, 74)
        End If
    End Sub

    Private Sub monitor_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub monitor_so_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        change_form(New monitoring)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        change_form(New monitoring_SO)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btn_customer.Click
        change_form(New upload_customer)
    End Sub
End Class
