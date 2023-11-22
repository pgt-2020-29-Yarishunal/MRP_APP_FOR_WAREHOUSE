<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filter_data_monitoring
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_judul_page = New System.Windows.Forms.Label()
        Me.file_direktori = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.teks_item_cd = New System.Windows.Forms.TextBox()
        Me.combo_item_cd = New System.Windows.Forms.ComboBox()
        Me.item_cd = New System.Windows.Forms.CheckBox()
        Me.combo_status = New System.Windows.Forms.ComboBox()
        Me.check_status = New System.Windows.Forms.CheckBox()
        Me.teks_est = New System.Windows.Forms.TextBox()
        Me.combo_est = New System.Windows.Forms.ComboBox()
        Me.check_est = New System.Windows.Forms.CheckBox()
        Me.teks_stock_out = New System.Windows.Forms.TextBox()
        Me.combo_stock_out = New System.Windows.Forms.ComboBox()
        Me.check_stock_out = New System.Windows.Forms.CheckBox()
        Me.teks_stock = New System.Windows.Forms.TextBox()
        Me.combo_stock = New System.Windows.Forms.ComboBox()
        Me.check_stock = New System.Windows.Forms.CheckBox()
        Me.teks_sticker = New System.Windows.Forms.TextBox()
        Me.combo_sticker = New System.Windows.Forms.ComboBox()
        Me.check_sticker = New System.Windows.Forms.CheckBox()
        Me.teks_polos = New System.Windows.Forms.TextBox()
        Me.combo_polos = New System.Windows.Forms.ComboBox()
        Me.check_polos = New System.Windows.Forms.CheckBox()
        Me.teks_in_wh = New System.Windows.Forms.TextBox()
        Me.combo_in_wh = New System.Windows.Forms.ComboBox()
        Me.check_in_wh = New System.Windows.Forms.CheckBox()
        Me.teks_pcs = New System.Windows.Forms.TextBox()
        Me.combo_pcs = New System.Windows.Forms.ComboBox()
        Me.check_pcs = New System.Windows.Forms.CheckBox()
        Me.teks_pp = New System.Windows.Forms.TextBox()
        Me.combo_pp = New System.Windows.Forms.ComboBox()
        Me.check_prodplan = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.check_all = New System.Windows.Forms.CheckBox()
        Me.lbl_kategori = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lbl_judul_page)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(539, 41)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Test_UI.My.Resources.Resources.x_mark_3_16
        Me.PictureBox1.Location = New System.Drawing.Point(520, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 22)
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        '
        'lbl_judul_page
        '
        Me.lbl_judul_page.AutoSize = True
        Me.lbl_judul_page.Font = New System.Drawing.Font("Segoe UI Black", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_judul_page.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_judul_page.Location = New System.Drawing.Point(148, 4)
        Me.lbl_judul_page.Name = "lbl_judul_page"
        Me.lbl_judul_page.Size = New System.Drawing.Size(252, 25)
        Me.lbl_judul_page.TabIndex = 3
        Me.lbl_judul_page.Text = "FILTER DATA MONTORING"
        '
        'file_direktori
        '
        Me.file_direktori.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.file_direktori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.file_direktori.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.file_direktori.Location = New System.Drawing.Point(27, 414)
        Me.file_direktori.Name = "file_direktori"
        Me.file_direktori.Size = New System.Drawing.Size(191, 24)
        Me.file_direktori.TabIndex = 103
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(24, 392)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 15)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "FILE SAVE LOCATION"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Image = Global.Test_UI.My.Resources.Resources.excel_2_24
        Me.Button3.Location = New System.Drawing.Point(425, 401)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 37)
        Me.Button3.TabIndex = 106
        Me.Button3.Text = "CREATE REPORT"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Test_UI.My.Resources.Resources.search_3_16
        Me.Button1.Location = New System.Drawing.Point(218, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 24)
        Me.Button1.TabIndex = 104
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Image = Global.Test_UI.My.Resources.Resources.plus_5_16
        Me.Button2.Location = New System.Drawing.Point(465, 338)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 19)
        Me.Button2.TabIndex = 153
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'teks_item_cd
        '
        Me.teks_item_cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teks_item_cd.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teks_item_cd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.teks_item_cd.Location = New System.Drawing.Point(360, 338)
        Me.teks_item_cd.Name = "teks_item_cd"
        Me.teks_item_cd.Size = New System.Drawing.Size(105, 19)
        Me.teks_item_cd.TabIndex = 194
        '
        'combo_item_cd
        '
        Me.combo_item_cd.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_item_cd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.combo_item_cd.FormattingEnabled = True
        Me.combo_item_cd.Location = New System.Drawing.Point(246, 338)
        Me.combo_item_cd.Name = "combo_item_cd"
        Me.combo_item_cd.Size = New System.Drawing.Size(98, 20)
        Me.combo_item_cd.TabIndex = 193
        '
        'item_cd
        '
        Me.item_cd.AutoSize = True
        Me.item_cd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.item_cd.Location = New System.Drawing.Point(203, 341)
        Me.item_cd.Name = "item_cd"
        Me.item_cd.Size = New System.Drawing.Size(15, 14)
        Me.item_cd.TabIndex = 192
        Me.item_cd.UseVisualStyleBackColor = True
        '
        'combo_status
        '
        Me.combo_status.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.combo_status.FormattingEnabled = True
        Me.combo_status.Items.AddRange(New Object() {"BELUM TERPENUHI", "TERPENUHI", "OVER"})
        Me.combo_status.Location = New System.Drawing.Point(246, 310)
        Me.combo_status.Name = "combo_status"
        Me.combo_status.Size = New System.Drawing.Size(98, 20)
        Me.combo_status.TabIndex = 191
        '
        'check_status
        '
        Me.check_status.AutoSize = True
        Me.check_status.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.check_status.Location = New System.Drawing.Point(203, 313)
        Me.check_status.Name = "check_status"
        Me.check_status.Size = New System.Drawing.Size(15, 14)
        Me.check_status.TabIndex = 190
        Me.check_status.UseVisualStyleBackColor = True
        '
        'teks_est
        '
        Me.teks_est.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teks_est.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teks_est.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.teks_est.Location = New System.Drawing.Point(360, 283)
        Me.teks_est.Name = "teks_est"
        Me.teks_est.Size = New System.Drawing.Size(105, 19)
        Me.teks_est.TabIndex = 189
        Me.teks_est.Text = "0"
        '
        'combo_est
        '
        Me.combo_est.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_est.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.combo_est.FormattingEnabled = True
        Me.combo_est.Items.AddRange(New Object() {"EQUAL", "MORE THAN", "LESS THAN"})
        Me.combo_est.Location = New System.Drawing.Point(246, 283)
        Me.combo_est.Name = "combo_est"
        Me.combo_est.Size = New System.Drawing.Size(98, 20)
        Me.combo_est.TabIndex = 188
        '
        'check_est
        '
        Me.check_est.AutoSize = True
        Me.check_est.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.check_est.Location = New System.Drawing.Point(203, 285)
        Me.check_est.Name = "check_est"
        Me.check_est.Size = New System.Drawing.Size(15, 14)
        Me.check_est.TabIndex = 187
        Me.check_est.UseVisualStyleBackColor = True
        '
        'teks_stock_out
        '
        Me.teks_stock_out.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teks_stock_out.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teks_stock_out.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.teks_stock_out.Location = New System.Drawing.Point(360, 254)
        Me.teks_stock_out.Name = "teks_stock_out"
        Me.teks_stock_out.Size = New System.Drawing.Size(105, 19)
        Me.teks_stock_out.TabIndex = 186
        Me.teks_stock_out.Text = "0"
        '
        'combo_stock_out
        '
        Me.combo_stock_out.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_stock_out.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.combo_stock_out.FormattingEnabled = True
        Me.combo_stock_out.Items.AddRange(New Object() {"EQUAL", "MORE THAN", "LESS THAN"})
        Me.combo_stock_out.Location = New System.Drawing.Point(246, 254)
        Me.combo_stock_out.Name = "combo_stock_out"
        Me.combo_stock_out.Size = New System.Drawing.Size(98, 20)
        Me.combo_stock_out.TabIndex = 185
        '
        'check_stock_out
        '
        Me.check_stock_out.AutoSize = True
        Me.check_stock_out.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.check_stock_out.Location = New System.Drawing.Point(203, 257)
        Me.check_stock_out.Name = "check_stock_out"
        Me.check_stock_out.Size = New System.Drawing.Size(15, 14)
        Me.check_stock_out.TabIndex = 184
        Me.check_stock_out.UseVisualStyleBackColor = True
        '
        'teks_stock
        '
        Me.teks_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teks_stock.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teks_stock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.teks_stock.Location = New System.Drawing.Point(360, 226)
        Me.teks_stock.Name = "teks_stock"
        Me.teks_stock.Size = New System.Drawing.Size(105, 19)
        Me.teks_stock.TabIndex = 183
        Me.teks_stock.Text = "0"
        '
        'combo_stock
        '
        Me.combo_stock.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_stock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.combo_stock.FormattingEnabled = True
        Me.combo_stock.Items.AddRange(New Object() {"EQUAL", "MORE THAN", "LESS THAN"})
        Me.combo_stock.Location = New System.Drawing.Point(246, 226)
        Me.combo_stock.Name = "combo_stock"
        Me.combo_stock.Size = New System.Drawing.Size(98, 20)
        Me.combo_stock.TabIndex = 182
        '
        'check_stock
        '
        Me.check_stock.AutoSize = True
        Me.check_stock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.check_stock.Location = New System.Drawing.Point(203, 229)
        Me.check_stock.Name = "check_stock"
        Me.check_stock.Size = New System.Drawing.Size(15, 14)
        Me.check_stock.TabIndex = 181
        Me.check_stock.UseVisualStyleBackColor = True
        '
        'teks_sticker
        '
        Me.teks_sticker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teks_sticker.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teks_sticker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.teks_sticker.Location = New System.Drawing.Point(360, 198)
        Me.teks_sticker.Name = "teks_sticker"
        Me.teks_sticker.Size = New System.Drawing.Size(105, 19)
        Me.teks_sticker.TabIndex = 180
        Me.teks_sticker.Text = "0"
        '
        'combo_sticker
        '
        Me.combo_sticker.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_sticker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.combo_sticker.FormattingEnabled = True
        Me.combo_sticker.Items.AddRange(New Object() {"EQUAL", "MORE THAN", "LESS THAN"})
        Me.combo_sticker.Location = New System.Drawing.Point(246, 198)
        Me.combo_sticker.Name = "combo_sticker"
        Me.combo_sticker.Size = New System.Drawing.Size(98, 20)
        Me.combo_sticker.TabIndex = 179
        '
        'check_sticker
        '
        Me.check_sticker.AutoSize = True
        Me.check_sticker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.check_sticker.Location = New System.Drawing.Point(203, 201)
        Me.check_sticker.Name = "check_sticker"
        Me.check_sticker.Size = New System.Drawing.Size(15, 14)
        Me.check_sticker.TabIndex = 178
        Me.check_sticker.UseVisualStyleBackColor = True
        '
        'teks_polos
        '
        Me.teks_polos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teks_polos.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teks_polos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.teks_polos.Location = New System.Drawing.Point(360, 170)
        Me.teks_polos.Name = "teks_polos"
        Me.teks_polos.Size = New System.Drawing.Size(105, 19)
        Me.teks_polos.TabIndex = 177
        Me.teks_polos.Text = "0"
        '
        'combo_polos
        '
        Me.combo_polos.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_polos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.combo_polos.FormattingEnabled = True
        Me.combo_polos.Items.AddRange(New Object() {"EQUAL", "MORE THAN", "LESS THAN"})
        Me.combo_polos.Location = New System.Drawing.Point(246, 170)
        Me.combo_polos.Name = "combo_polos"
        Me.combo_polos.Size = New System.Drawing.Size(98, 20)
        Me.combo_polos.TabIndex = 176
        '
        'check_polos
        '
        Me.check_polos.AutoSize = True
        Me.check_polos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.check_polos.Location = New System.Drawing.Point(203, 173)
        Me.check_polos.Name = "check_polos"
        Me.check_polos.Size = New System.Drawing.Size(15, 14)
        Me.check_polos.TabIndex = 175
        Me.check_polos.UseVisualStyleBackColor = True
        '
        'teks_in_wh
        '
        Me.teks_in_wh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teks_in_wh.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teks_in_wh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.teks_in_wh.Location = New System.Drawing.Point(360, 142)
        Me.teks_in_wh.Name = "teks_in_wh"
        Me.teks_in_wh.Size = New System.Drawing.Size(105, 19)
        Me.teks_in_wh.TabIndex = 174
        Me.teks_in_wh.Text = "0"
        '
        'combo_in_wh
        '
        Me.combo_in_wh.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_in_wh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.combo_in_wh.FormattingEnabled = True
        Me.combo_in_wh.Items.AddRange(New Object() {"EQUAL", "MORE THAN", "LESS THAN"})
        Me.combo_in_wh.Location = New System.Drawing.Point(246, 142)
        Me.combo_in_wh.Name = "combo_in_wh"
        Me.combo_in_wh.Size = New System.Drawing.Size(98, 20)
        Me.combo_in_wh.TabIndex = 173
        '
        'check_in_wh
        '
        Me.check_in_wh.AutoSize = True
        Me.check_in_wh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.check_in_wh.Location = New System.Drawing.Point(203, 145)
        Me.check_in_wh.Name = "check_in_wh"
        Me.check_in_wh.Size = New System.Drawing.Size(15, 14)
        Me.check_in_wh.TabIndex = 172
        Me.check_in_wh.UseVisualStyleBackColor = True
        '
        'teks_pcs
        '
        Me.teks_pcs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teks_pcs.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teks_pcs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.teks_pcs.Location = New System.Drawing.Point(360, 114)
        Me.teks_pcs.Name = "teks_pcs"
        Me.teks_pcs.Size = New System.Drawing.Size(105, 19)
        Me.teks_pcs.TabIndex = 171
        Me.teks_pcs.Text = "0"
        '
        'combo_pcs
        '
        Me.combo_pcs.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_pcs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.combo_pcs.FormattingEnabled = True
        Me.combo_pcs.Items.AddRange(New Object() {"EQUAL", "MORE THAN", "LESS THAN"})
        Me.combo_pcs.Location = New System.Drawing.Point(246, 114)
        Me.combo_pcs.Name = "combo_pcs"
        Me.combo_pcs.Size = New System.Drawing.Size(98, 20)
        Me.combo_pcs.TabIndex = 170
        '
        'check_pcs
        '
        Me.check_pcs.AutoSize = True
        Me.check_pcs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.check_pcs.Location = New System.Drawing.Point(203, 117)
        Me.check_pcs.Name = "check_pcs"
        Me.check_pcs.Size = New System.Drawing.Size(15, 14)
        Me.check_pcs.TabIndex = 169
        Me.check_pcs.UseVisualStyleBackColor = True
        '
        'teks_pp
        '
        Me.teks_pp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teks_pp.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teks_pp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.teks_pp.Location = New System.Drawing.Point(360, 86)
        Me.teks_pp.Name = "teks_pp"
        Me.teks_pp.Size = New System.Drawing.Size(105, 19)
        Me.teks_pp.TabIndex = 168
        Me.teks_pp.Text = "0"
        '
        'combo_pp
        '
        Me.combo_pp.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_pp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.combo_pp.FormattingEnabled = True
        Me.combo_pp.Items.AddRange(New Object() {"EQUAL", "MORE THAN", "LESS THAN"})
        Me.combo_pp.Location = New System.Drawing.Point(246, 86)
        Me.combo_pp.Name = "combo_pp"
        Me.combo_pp.Size = New System.Drawing.Size(98, 20)
        Me.combo_pp.TabIndex = 167
        '
        'check_prodplan
        '
        Me.check_prodplan.AutoSize = True
        Me.check_prodplan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.check_prodplan.Location = New System.Drawing.Point(203, 89)
        Me.check_prodplan.Name = "check_prodplan"
        Me.check_prodplan.Size = New System.Drawing.Size(15, 14)
        Me.check_prodplan.TabIndex = 166
        Me.check_prodplan.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(24, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 15)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "ESTIMASI HABIS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(24, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 15)
        Me.Label9.TabIndex = 164
        Me.Label9.Text = "STATUS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(24, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 15)
        Me.Label8.TabIndex = 163
        Me.Label8.Text = "ITEM CODE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(24, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 162
        Me.Label7.Text = "PCS/DAY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(24, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 15)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "IN WAREHOUSE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(24, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 15)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "STOCK TIRE POLOS GD.BAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(24, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 15)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "STOCK STICKER GD.BAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(24, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 15)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "STOCK ON HAND GD.BAHAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(24, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 15)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "STOCK OUT GD.BAHAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "PRODPLAN"
        '
        'check_all
        '
        Me.check_all.AutoSize = True
        Me.check_all.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.check_all.Location = New System.Drawing.Point(203, 61)
        Me.check_all.Name = "check_all"
        Me.check_all.Size = New System.Drawing.Size(15, 14)
        Me.check_all.TabIndex = 155
        Me.check_all.UseVisualStyleBackColor = True
        '
        'lbl_kategori
        '
        Me.lbl_kategori.AutoSize = True
        Me.lbl_kategori.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kategori.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lbl_kategori.Location = New System.Drawing.Point(24, 60)
        Me.lbl_kategori.Name = "lbl_kategori"
        Me.lbl_kategori.Size = New System.Drawing.Size(27, 15)
        Me.lbl_kategori.TabIndex = 154
        Me.lbl_kategori.Text = "ALL"
        '
        'filter_data_monitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(539, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.teks_item_cd)
        Me.Controls.Add(Me.combo_item_cd)
        Me.Controls.Add(Me.item_cd)
        Me.Controls.Add(Me.combo_status)
        Me.Controls.Add(Me.check_status)
        Me.Controls.Add(Me.teks_est)
        Me.Controls.Add(Me.combo_est)
        Me.Controls.Add(Me.check_est)
        Me.Controls.Add(Me.teks_stock_out)
        Me.Controls.Add(Me.combo_stock_out)
        Me.Controls.Add(Me.check_stock_out)
        Me.Controls.Add(Me.teks_stock)
        Me.Controls.Add(Me.combo_stock)
        Me.Controls.Add(Me.check_stock)
        Me.Controls.Add(Me.teks_sticker)
        Me.Controls.Add(Me.combo_sticker)
        Me.Controls.Add(Me.check_sticker)
        Me.Controls.Add(Me.teks_polos)
        Me.Controls.Add(Me.combo_polos)
        Me.Controls.Add(Me.check_polos)
        Me.Controls.Add(Me.teks_in_wh)
        Me.Controls.Add(Me.combo_in_wh)
        Me.Controls.Add(Me.check_in_wh)
        Me.Controls.Add(Me.teks_pcs)
        Me.Controls.Add(Me.combo_pcs)
        Me.Controls.Add(Me.check_pcs)
        Me.Controls.Add(Me.teks_pp)
        Me.Controls.Add(Me.combo_pp)
        Me.Controls.Add(Me.check_prodplan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.check_all)
        Me.Controls.Add(Me.lbl_kategori)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.file_direktori)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "filter_data_monitoring"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "filter_data_monitoring"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_judul_page As Label
    Friend WithEvents file_direktori As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents teks_item_cd As TextBox
    Friend WithEvents combo_item_cd As ComboBox
    Friend WithEvents item_cd As CheckBox
    Friend WithEvents combo_status As ComboBox
    Friend WithEvents check_status As CheckBox
    Friend WithEvents teks_est As TextBox
    Friend WithEvents combo_est As ComboBox
    Friend WithEvents check_est As CheckBox
    Friend WithEvents teks_stock_out As TextBox
    Friend WithEvents combo_stock_out As ComboBox
    Friend WithEvents check_stock_out As CheckBox
    Friend WithEvents teks_stock As TextBox
    Friend WithEvents combo_stock As ComboBox
    Friend WithEvents check_stock As CheckBox
    Friend WithEvents teks_sticker As TextBox
    Friend WithEvents combo_sticker As ComboBox
    Friend WithEvents check_sticker As CheckBox
    Friend WithEvents teks_polos As TextBox
    Friend WithEvents combo_polos As ComboBox
    Friend WithEvents check_polos As CheckBox
    Friend WithEvents teks_in_wh As TextBox
    Friend WithEvents combo_in_wh As ComboBox
    Friend WithEvents check_in_wh As CheckBox
    Friend WithEvents teks_pcs As TextBox
    Friend WithEvents combo_pcs As ComboBox
    Friend WithEvents check_pcs As CheckBox
    Friend WithEvents teks_pp As TextBox
    Friend WithEvents combo_pp As ComboBox
    Friend WithEvents check_prodplan As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents check_all As CheckBox
    Friend WithEvents lbl_kategori As Label
End Class
