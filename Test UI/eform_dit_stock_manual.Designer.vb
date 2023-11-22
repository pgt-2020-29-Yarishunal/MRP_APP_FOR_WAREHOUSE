<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eform_dit_stock_manual
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_judul_page = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teks_item = New System.Windows.Forms.TextBox()
        Me.teks_stock_out = New System.Windows.Forms.TextBox()
        Me.label_item_code_2 = New System.Windows.Forms.Label()
        Me.teks_stock_in = New System.Windows.Forms.TextBox()
        Me.label_item_desk = New System.Windows.Forms.Label()
        Me.teks_on_hand = New System.Windows.Forms.TextBox()
        Me.label_item_code = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tmbl_insert = New System.Windows.Forms.Button()
        Me.bulan = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.periode_stock = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.jenis_stock = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tahun_text = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cut_off_text = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.lbl_judul_page)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(832, 43)
        Me.Panel1.TabIndex = 105
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Test_UI.My.Resources.Resources.x_mark_16
        Me.Button2.Location = New System.Drawing.Point(801, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 21)
        Me.Button2.TabIndex = 81
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lbl_judul_page
        '
        Me.lbl_judul_page.AutoSize = True
        Me.lbl_judul_page.Font = New System.Drawing.Font("Segoe UI Black", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_judul_page.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_judul_page.Location = New System.Drawing.Point(266, 9)
        Me.lbl_judul_page.Name = "lbl_judul_page"
        Me.lbl_judul_page.Size = New System.Drawing.Size(174, 25)
        Me.lbl_judul_page.TabIndex = 4
        Me.lbl_judul_page.Text = "EDIT DATA STOCK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(39, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "ITEM CODE"
        '
        'teks_item
        '
        Me.teks_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teks_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teks_item.Location = New System.Drawing.Point(42, 103)
        Me.teks_item.Name = "teks_item"
        Me.teks_item.Size = New System.Drawing.Size(144, 21)
        Me.teks_item.TabIndex = 102
        '
        'teks_stock_out
        '
        Me.teks_stock_out.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.teks_stock_out.Location = New System.Drawing.Point(241, 245)
        Me.teks_stock_out.Name = "teks_stock_out"
        Me.teks_stock_out.Size = New System.Drawing.Size(159, 22)
        Me.teks_stock_out.TabIndex = 88
        '
        'label_item_code_2
        '
        Me.label_item_code_2.AutoSize = True
        Me.label_item_code_2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_item_code_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.label_item_code_2.Location = New System.Drawing.Point(237, 220)
        Me.label_item_code_2.Name = "label_item_code_2"
        Me.label_item_code_2.Size = New System.Drawing.Size(96, 21)
        Me.label_item_code_2.TabIndex = 87
        Me.label_item_code_2.Text = "STOCK OUT"
        '
        'teks_stock_in
        '
        Me.teks_stock_in.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.teks_stock_in.Location = New System.Drawing.Point(420, 245)
        Me.teks_stock_in.Name = "teks_stock_in"
        Me.teks_stock_in.Size = New System.Drawing.Size(159, 22)
        Me.teks_stock_in.TabIndex = 86
        '
        'label_item_desk
        '
        Me.label_item_desk.AutoSize = True
        Me.label_item_desk.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_item_desk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.label_item_desk.Location = New System.Drawing.Point(416, 220)
        Me.label_item_desk.Name = "label_item_desk"
        Me.label_item_desk.Size = New System.Drawing.Size(81, 21)
        Me.label_item_desk.TabIndex = 85
        Me.label_item_desk.Text = "STOCK IN"
        '
        'teks_on_hand
        '
        Me.teks_on_hand.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.teks_on_hand.Location = New System.Drawing.Point(44, 245)
        Me.teks_on_hand.Name = "teks_on_hand"
        Me.teks_on_hand.Size = New System.Drawing.Size(159, 22)
        Me.teks_on_hand.TabIndex = 84
        '
        'label_item_code
        '
        Me.label_item_code.AutoSize = True
        Me.label_item_code.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_item_code.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.label_item_code.Location = New System.Drawing.Point(40, 220)
        Me.label_item_code.Name = "label_item_code"
        Me.label_item_code.Size = New System.Drawing.Size(172, 21)
        Me.label_item_code.TabIndex = 81
        Me.label_item_code.Text = "QUANTITY ON HAND"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Image = Global.Test_UI.My.Resources.Resources.search_3_16
        Me.Button1.Location = New System.Drawing.Point(207, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 31)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "SEARCH"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tmbl_insert
        '
        Me.tmbl_insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.tmbl_insert.FlatAppearance.BorderSize = 0
        Me.tmbl_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tmbl_insert.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmbl_insert.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.tmbl_insert.Image = Global.Test_UI.My.Resources.Resources.edit_2_16
        Me.tmbl_insert.Location = New System.Drawing.Point(44, 298)
        Me.tmbl_insert.Name = "tmbl_insert"
        Me.tmbl_insert.Size = New System.Drawing.Size(75, 29)
        Me.tmbl_insert.TabIndex = 101
        Me.tmbl_insert.Text = "EDIT"
        Me.tmbl_insert.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.tmbl_insert.UseVisualStyleBackColor = False
        '
        'bulan
        '
        Me.bulan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bulan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bulan.FormattingEnabled = True
        Me.bulan.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.bulan.Location = New System.Drawing.Point(533, 101)
        Me.bulan.Name = "bulan"
        Me.bulan.Size = New System.Drawing.Size(123, 23)
        Me.bulan.TabIndex = 111
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(530, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "BULAN"
        '
        'periode_stock
        '
        Me.periode_stock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.periode_stock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.periode_stock.FormattingEnabled = True
        Me.periode_stock.Items.AddRange(New Object() {"Stock Awal Bulan (This Month)", "Stock Akhir bulan (Last Month)"})
        Me.periode_stock.Location = New System.Drawing.Point(369, 101)
        Me.periode_stock.Name = "periode_stock"
        Me.periode_stock.Size = New System.Drawing.Size(139, 23)
        Me.periode_stock.TabIndex = 109
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(366, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "PERIODE STOCK"
        '
        'jenis_stock
        '
        Me.jenis_stock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jenis_stock.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jenis_stock.FormattingEnabled = True
        Me.jenis_stock.Items.AddRange(New Object() {"Stock Daily", "Stock MRP"})
        Me.jenis_stock.Location = New System.Drawing.Point(207, 101)
        Me.jenis_stock.Name = "jenis_stock"
        Me.jenis_stock.Size = New System.Drawing.Size(138, 23)
        Me.jenis_stock.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(204, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "JENIS STOCK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(41, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "CATEGORY :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(670, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "TAHUN"
        '
        'tahun_text
        '
        Me.tahun_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tahun_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tahun_text.Location = New System.Drawing.Point(673, 102)
        Me.tahun_text.Name = "tahun_text"
        Me.tahun_text.Size = New System.Drawing.Size(144, 21)
        Me.tahun_text.TabIndex = 113
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(39, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "CUT OFF"
        '
        'cut_off_text
        '
        Me.cut_off_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cut_off_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cut_off_text.Location = New System.Drawing.Point(42, 160)
        Me.cut_off_text.Name = "cut_off_text"
        Me.cut_off_text.Size = New System.Drawing.Size(144, 21)
        Me.cut_off_text.TabIndex = 115
        '
        'eform_dit_stock_manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(832, 357)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cut_off_text)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tahun_text)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bulan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.periode_stock)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.jenis_stock)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.teks_item)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tmbl_insert)
        Me.Controls.Add(Me.teks_stock_out)
        Me.Controls.Add(Me.label_item_code_2)
        Me.Controls.Add(Me.teks_stock_in)
        Me.Controls.Add(Me.label_item_desk)
        Me.Controls.Add(Me.teks_on_hand)
        Me.Controls.Add(Me.label_item_code)
        Me.Name = "eform_dit_stock_manual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDIT DATA STOCK"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents lbl_judul_page As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents teks_item As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tmbl_insert As Button
    Friend WithEvents teks_stock_out As TextBox
    Friend WithEvents label_item_code_2 As Label
    Friend WithEvents teks_stock_in As TextBox
    Friend WithEvents label_item_desk As Label
    Friend WithEvents teks_on_hand As TextBox
    Friend WithEvents label_item_code As Label
    Friend WithEvents bulan As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents periode_stock As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents jenis_stock As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tahun_text As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cut_off_text As TextBox
End Class
