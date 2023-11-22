<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class create_mrp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.jeniss = New System.Windows.Forms.ComboBox()
        Me.lbl_kategori = New System.Windows.Forms.Label()
        Me.month_now = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label_progress = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.tmplt_inv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.month_next1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.month_next = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.name_month_now = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.name_month_next = New System.Windows.Forms.ComboBox()
        Me.name_month_next1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_item = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tahun_this_month = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tahun_next_month = New System.Windows.Forms.TextBox()
        Me.tahun_next_month1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.OUTSTANDING = New System.Windows.Forms.Label()
        Me.outs_pr = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.prpo_pr = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.stock_pr = New System.Windows.Forms.ComboBox()
        Me.demand_1 = New System.Windows.Forms.CheckBox()
        Me.demand_2 = New System.Windows.Forms.CheckBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'jeniss
        '
        Me.jeniss.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jeniss.FormattingEnabled = True
        Me.jeniss.Location = New System.Drawing.Point(26, 57)
        Me.jeniss.Name = "jeniss"
        Me.jeniss.Size = New System.Drawing.Size(258, 28)
        Me.jeniss.TabIndex = 49
        '
        'lbl_kategori
        '
        Me.lbl_kategori.AutoSize = True
        Me.lbl_kategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kategori.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lbl_kategori.Location = New System.Drawing.Point(21, 18)
        Me.lbl_kategori.Name = "lbl_kategori"
        Me.lbl_kategori.Size = New System.Drawing.Size(144, 29)
        Me.lbl_kategori.TabIndex = 48
        Me.lbl_kategori.Text = "KATEGORI"
        '
        'month_now
        '
        Me.month_now.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.month_now.FormattingEnabled = True
        Me.month_now.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.month_now.Location = New System.Drawing.Point(30, 182)
        Me.month_now.Name = "month_now"
        Me.month_now.Size = New System.Drawing.Size(174, 28)
        Me.month_now.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(25, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 24)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "PERIODE 1"
        '
        'label_progress
        '
        Me.label_progress.AutoSize = True
        Me.label_progress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_progress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.label_progress.Location = New System.Drawing.Point(296, 577)
        Me.label_progress.Name = "label_progress"
        Me.label_progress.Size = New System.Drawing.Size(67, 13)
        Me.label_progress.TabIndex = 38
        Me.label_progress.Text = "progress..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(30, 578)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(259, 13)
        Me.ProgressBar1.TabIndex = 37
        '
        'tmplt_inv
        '
        Me.tmplt_inv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tmplt_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmplt_inv.Location = New System.Drawing.Point(29, 541)
        Me.tmplt_inv.Name = "tmplt_inv"
        Me.tmplt_inv.Size = New System.Drawing.Size(218, 24)
        Me.tmplt_inv.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(25, 494)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 29)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "INPUT FILE TEMPLATE"
        '
        'month_next1
        '
        Me.month_next1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.month_next1.FormattingEnabled = True
        Me.month_next1.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.month_next1.Location = New System.Drawing.Point(26, 451)
        Me.month_next1.Name = "month_next1"
        Me.month_next1.Size = New System.Drawing.Size(174, 28)
        Me.month_next1.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(26, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 24)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "PERIODE 3"
        '
        'month_next
        '
        Me.month_next.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.month_next.FormattingEnabled = True
        Me.month_next.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.month_next.Location = New System.Drawing.Point(28, 311)
        Me.month_next.Name = "month_next"
        Me.month_next.Size = New System.Drawing.Size(174, 28)
        Me.month_next.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(25, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 24)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "PERIODE 2"
        '
        'name_month_now
        '
        Me.name_month_now.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_month_now.FormattingEnabled = True
        Me.name_month_now.Location = New System.Drawing.Point(205, 182)
        Me.name_month_now.Name = "name_month_now"
        Me.name_month_now.Size = New System.Drawing.Size(174, 28)
        Me.name_month_now.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(294, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 29)
        Me.Label5.TabIndex = 54
        '
        'name_month_next
        '
        Me.name_month_next.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_month_next.FormattingEnabled = True
        Me.name_month_next.Location = New System.Drawing.Point(203, 311)
        Me.name_month_next.Name = "name_month_next"
        Me.name_month_next.Size = New System.Drawing.Size(174, 28)
        Me.name_month_next.TabIndex = 57
        '
        'name_month_next1
        '
        Me.name_month_next1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_month_next1.FormattingEnabled = True
        Me.name_month_next1.Location = New System.Drawing.Point(201, 451)
        Me.name_month_next1.Name = "name_month_next1"
        Me.name_month_next1.Size = New System.Drawing.Size(174, 28)
        Me.name_month_next1.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(304, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 24)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "REVISI"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Test_UI.My.Resources.Resources.search_3_16
        Me.Button1.Location = New System.Drawing.Point(246, 541)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 24)
        Me.Button1.TabIndex = 36
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Image = Global.Test_UI.My.Resources.Resources.excel_2_24
        Me.Button2.Location = New System.Drawing.Point(620, 547)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 43)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "CREATE INVENTORY"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbl_item
        '
        Me.lbl_item.AutoSize = True
        Me.lbl_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_item.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lbl_item.Location = New System.Drawing.Point(26, 592)
        Me.lbl_item.Name = "lbl_item"
        Me.lbl_item.Size = New System.Drawing.Size(29, 20)
        Me.lbl_item.TabIndex = 61
        Me.lbl_item.Text = "...."
        '
        'tahun_this_month
        '
        Me.tahun_this_month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tahun_this_month.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.tahun_this_month.Location = New System.Drawing.Point(416, 182)
        Me.tahun_this_month.Name = "tahun_this_month"
        Me.tahun_this_month.Size = New System.Drawing.Size(152, 27)
        Me.tahun_this_month.TabIndex = 62
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(412, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 24)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "TAHUN"
        '
        'tahun_next_month
        '
        Me.tahun_next_month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tahun_next_month.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.tahun_next_month.Location = New System.Drawing.Point(414, 311)
        Me.tahun_next_month.Name = "tahun_next_month"
        Me.tahun_next_month.Size = New System.Drawing.Size(152, 27)
        Me.tahun_next_month.TabIndex = 64
        '
        'tahun_next_month1
        '
        Me.tahun_next_month1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tahun_next_month1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.tahun_next_month1.Location = New System.Drawing.Point(412, 451)
        Me.tahun_next_month1.Name = "tahun_next_month1"
        Me.tahun_next_month1.Size = New System.Drawing.Size(152, 27)
        Me.tahun_next_month1.TabIndex = 66
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(26, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 24)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "BULAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(24, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 24)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "BULAN"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(410, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 24)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "TAHUN"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(302, 274)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 24)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "REVISI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(26, 410)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 24)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "BULAN"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(412, 410)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 24)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "TAHUN"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(304, 409)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 24)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "REVISI"
        '
        'OUTSTANDING
        '
        Me.OUTSTANDING.AutoSize = True
        Me.OUTSTANDING.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OUTSTANDING.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.OUTSTANDING.Location = New System.Drawing.Point(662, 26)
        Me.OUTSTANDING.Name = "OUTSTANDING"
        Me.OUTSTANDING.Size = New System.Drawing.Size(157, 24)
        Me.OUTSTANDING.TabIndex = 76
        Me.OUTSTANDING.Text = "OUTSTANDING"
        '
        'outs_pr
        '
        Me.outs_pr.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outs_pr.FormattingEnabled = True
        Me.outs_pr.Location = New System.Drawing.Point(666, 56)
        Me.outs_pr.Name = "outs_pr"
        Me.outs_pr.Size = New System.Drawing.Size(128, 28)
        Me.outs_pr.TabIndex = 75
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(662, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 24)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "PR PO"
        '
        'prpo_pr
        '
        Me.prpo_pr.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prpo_pr.FormattingEnabled = True
        Me.prpo_pr.Location = New System.Drawing.Point(666, 137)
        Me.prpo_pr.Name = "prpo_pr"
        Me.prpo_pr.Size = New System.Drawing.Size(128, 28)
        Me.prpo_pr.TabIndex = 77
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(662, 186)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 24)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "STOCK"
        '
        'stock_pr
        '
        Me.stock_pr.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_pr.FormattingEnabled = True
        Me.stock_pr.Location = New System.Drawing.Point(666, 217)
        Me.stock_pr.Name = "stock_pr"
        Me.stock_pr.Size = New System.Drawing.Size(128, 28)
        Me.stock_pr.TabIndex = 79
        '
        'demand_1
        '
        Me.demand_1.AutoSize = True
        Me.demand_1.Location = New System.Drawing.Point(590, 317)
        Me.demand_1.Name = "demand_1"
        Me.demand_1.Size = New System.Drawing.Size(15, 14)
        Me.demand_1.TabIndex = 82
        Me.demand_1.UseVisualStyleBackColor = True
        '
        'demand_2
        '
        Me.demand_2.AutoSize = True
        Me.demand_2.Location = New System.Drawing.Point(590, 458)
        Me.demand_2.Name = "demand_2"
        Me.demand_2.Size = New System.Drawing.Size(15, 14)
        Me.demand_2.TabIndex = 83
        Me.demand_2.UseVisualStyleBackColor = True
        '
        'create_mrp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(929, 607)
        Me.Controls.Add(Me.demand_2)
        Me.Controls.Add(Me.demand_1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.stock_pr)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.prpo_pr)
        Me.Controls.Add(Me.OUTSTANDING)
        Me.Controls.Add(Me.outs_pr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tahun_next_month1)
        Me.Controls.Add(Me.tahun_next_month)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tahun_this_month)
        Me.Controls.Add(Me.lbl_item)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.name_month_next1)
        Me.Controls.Add(Me.name_month_next)
        Me.Controls.Add(Me.name_month_now)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.month_next)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.month_next1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.jeniss)
        Me.Controls.Add(Me.lbl_kategori)
        Me.Controls.Add(Me.month_now)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label_progress)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.tmplt_inv)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "create_mrp"
        Me.Text = "MRP MAKING"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents jeniss As ComboBox
    Friend WithEvents lbl_kategori As Label
    Friend WithEvents month_now As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents label_progress As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents tmplt_inv As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents month_next1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents month_next As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents name_month_now As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents name_month_next As ComboBox
    Friend WithEvents name_month_next1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lbl_item As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents tahun_this_month As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tahun_next_month As TextBox
    Friend WithEvents tahun_next_month1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents OUTSTANDING As Label
    Friend WithEvents outs_pr As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents prpo_pr As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents stock_pr As ComboBox
    Friend WithEvents demand_1 As CheckBox
    Friend WithEvents demand_2 As CheckBox
End Class
