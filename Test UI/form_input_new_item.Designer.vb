<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_input_new_item
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.combo_kategori = New System.Windows.Forms.ComboBox()
        Me.lbl_kategori = New System.Windows.Forms.Label()
        Me.dataa = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label_item_code = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.teksfile = New System.Windows.Forms.TextBox()
        Me.lbl_input = New System.Windows.Forms.Label()
        Me.teks_item_code = New System.Windows.Forms.TextBox()
        Me.teks_item_desk = New System.Windows.Forms.TextBox()
        Me.label_item_desk = New System.Windows.Forms.Label()
        Me.teks_item_code2 = New System.Windows.Forms.TextBox()
        Me.label_item_code_2 = New System.Windows.Forms.Label()
        Me.teks_item_safety = New System.Windows.Forms.TextBox()
        Me.label_item_safety = New System.Windows.Forms.Label()
        Me.teks_item_tire2 = New System.Windows.Forms.TextBox()
        Me.label_item_tire_2 = New System.Windows.Forms.Label()
        Me.teks_item_tire1 = New System.Windows.Forms.TextBox()
        Me.label_item_tire_1 = New System.Windows.Forms.Label()
        Me.teks_item_tire4 = New System.Windows.Forms.TextBox()
        Me.label_item_tire_4 = New System.Windows.Forms.Label()
        Me.teks_item_tire5 = New System.Windows.Forms.TextBox()
        Me.label_item_tire_5 = New System.Windows.Forms.Label()
        Me.teks_item_tire3 = New System.Windows.Forms.TextBox()
        Me.label_item_tire_3 = New System.Windows.Forms.Label()
        Me.rd_button_manual = New System.Windows.Forms.RadioButton()
        Me.rd_button_upload = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tmbl_insert = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tmbl_search = New System.Windows.Forms.Button()
        Me.teks_sub_kategori = New System.Windows.Forms.TextBox()
        Me.lbl_sub = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.dataa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'combo_kategori
        '
        Me.combo_kategori.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_kategori.FormattingEnabled = True
        Me.combo_kategori.Location = New System.Drawing.Point(31, 264)
        Me.combo_kategori.Name = "combo_kategori"
        Me.combo_kategori.Size = New System.Drawing.Size(259, 21)
        Me.combo_kategori.TabIndex = 31
        '
        'lbl_kategori
        '
        Me.lbl_kategori.AutoSize = True
        Me.lbl_kategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kategori.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lbl_kategori.Location = New System.Drawing.Point(28, 235)
        Me.lbl_kategori.Name = "lbl_kategori"
        Me.lbl_kategori.Size = New System.Drawing.Size(100, 20)
        Me.lbl_kategori.TabIndex = 30
        Me.lbl_kategori.Text = "KATEGORI"
        '
        'dataa
        '
        Me.dataa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dataa.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dataa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(100, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataa.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataa.EnableHeadersVisualStyles = False
        Me.dataa.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dataa.Location = New System.Drawing.Point(22, 301)
        Me.dataa.Name = "dataa"
        Me.dataa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataa.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.dataa.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dataa.Size = New System.Drawing.Size(642, 294)
        Me.dataa.TabIndex = 29
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item Code"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Item Code 1"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Deskripsi"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Kategori"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Item Tire 1"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Item Tire 2"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Item Tire 3"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Item Tire 4"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Item Tire 5"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Safety Stock"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Sub Kategori"
        Me.Column11.Name = "Column11"
        '
        'label_item_code
        '
        Me.label_item_code.AutoSize = True
        Me.label_item_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_item_code.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.label_item_code.Location = New System.Drawing.Point(27, 32)
        Me.label_item_code.Name = "label_item_code"
        Me.label_item_code.Size = New System.Drawing.Size(106, 20)
        Me.label_item_code.TabIndex = 27
        Me.label_item_code.Text = "ITEM CODE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(297, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "progress..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(31, 102)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(259, 13)
        Me.ProgressBar1.TabIndex = 25
        '
        'teksfile
        '
        Me.teksfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teksfile.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teksfile.Location = New System.Drawing.Point(31, 55)
        Me.teksfile.Name = "teksfile"
        Me.teksfile.Size = New System.Drawing.Size(218, 27)
        Me.teksfile.TabIndex = 23
        '
        'lbl_input
        '
        Me.lbl_input.AutoSize = True
        Me.lbl_input.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lbl_input.Location = New System.Drawing.Point(27, 27)
        Me.lbl_input.Name = "lbl_input"
        Me.lbl_input.Size = New System.Drawing.Size(127, 25)
        Me.lbl_input.TabIndex = 22
        Me.lbl_input.Text = "INPUT FILE"
        '
        'teks_item_code
        '
        Me.teks_item_code.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.teks_item_code.Location = New System.Drawing.Point(31, 57)
        Me.teks_item_code.Name = "teks_item_code"
        Me.teks_item_code.Size = New System.Drawing.Size(159, 22)
        Me.teks_item_code.TabIndex = 36
        '
        'teks_item_desk
        '
        Me.teks_item_desk.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.teks_item_desk.Location = New System.Drawing.Point(386, 57)
        Me.teks_item_desk.Name = "teks_item_desk"
        Me.teks_item_desk.Size = New System.Drawing.Size(196, 22)
        Me.teks_item_desk.TabIndex = 38
        '
        'label_item_desk
        '
        Me.label_item_desk.AutoSize = True
        Me.label_item_desk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_item_desk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.label_item_desk.Location = New System.Drawing.Point(382, 33)
        Me.label_item_desk.Name = "label_item_desk"
        Me.label_item_desk.Size = New System.Drawing.Size(105, 20)
        Me.label_item_desk.TabIndex = 37
        Me.label_item_desk.Text = "DESKRIPSI"
        '
        'teks_item_code2
        '
        Me.teks_item_code2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.teks_item_code2.Location = New System.Drawing.Point(209, 57)
        Me.teks_item_code2.Name = "teks_item_code2"
        Me.teks_item_code2.Size = New System.Drawing.Size(159, 22)
        Me.teks_item_code2.TabIndex = 40
        '
        'label_item_code_2
        '
        Me.label_item_code_2.AutoSize = True
        Me.label_item_code_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_item_code_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.label_item_code_2.Location = New System.Drawing.Point(205, 32)
        Me.label_item_code_2.Name = "label_item_code_2"
        Me.label_item_code_2.Size = New System.Drawing.Size(121, 20)
        Me.label_item_code_2.TabIndex = 39
        Me.label_item_code_2.Text = "ITEM CODE 2"
        '
        'teks_item_safety
        '
        Me.teks_item_safety.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.teks_item_safety.Location = New System.Drawing.Point(209, 193)
        Me.teks_item_safety.Name = "teks_item_safety"
        Me.teks_item_safety.Size = New System.Drawing.Size(159, 22)
        Me.teks_item_safety.TabIndex = 42
        '
        'label_item_safety
        '
        Me.label_item_safety.AutoSize = True
        Me.label_item_safety.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_item_safety.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.label_item_safety.Location = New System.Drawing.Point(205, 168)
        Me.label_item_safety.Name = "label_item_safety"
        Me.label_item_safety.Size = New System.Drawing.Size(141, 20)
        Me.label_item_safety.TabIndex = 41
        Me.label_item_safety.Text = "SAFETY STOCK"
        '
        'teks_item_tire2
        '
        Me.teks_item_tire2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.teks_item_tire2.Location = New System.Drawing.Point(208, 127)
        Me.teks_item_tire2.Name = "teks_item_tire2"
        Me.teks_item_tire2.Size = New System.Drawing.Size(159, 22)
        Me.teks_item_tire2.TabIndex = 44
        '
        'label_item_tire_2
        '
        Me.label_item_tire_2.AutoSize = True
        Me.label_item_tire_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_item_tire_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.label_item_tire_2.Location = New System.Drawing.Point(204, 102)
        Me.label_item_tire_2.Name = "label_item_tire_2"
        Me.label_item_tire_2.Size = New System.Drawing.Size(112, 20)
        Me.label_item_tire_2.TabIndex = 43
        Me.label_item_tire_2.Text = "ITEM TIRE 2"
        '
        'teks_item_tire1
        '
        Me.teks_item_tire1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.teks_item_tire1.Location = New System.Drawing.Point(31, 127)
        Me.teks_item_tire1.Name = "teks_item_tire1"
        Me.teks_item_tire1.Size = New System.Drawing.Size(159, 22)
        Me.teks_item_tire1.TabIndex = 46
        '
        'label_item_tire_1
        '
        Me.label_item_tire_1.AutoSize = True
        Me.label_item_tire_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_item_tire_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.label_item_tire_1.Location = New System.Drawing.Point(27, 102)
        Me.label_item_tire_1.Name = "label_item_tire_1"
        Me.label_item_tire_1.Size = New System.Drawing.Size(112, 20)
        Me.label_item_tire_1.TabIndex = 45
        Me.label_item_tire_1.Text = "ITEM TIRE 1"
        '
        'teks_item_tire4
        '
        Me.teks_item_tire4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.teks_item_tire4.Location = New System.Drawing.Point(563, 127)
        Me.teks_item_tire4.Name = "teks_item_tire4"
        Me.teks_item_tire4.Size = New System.Drawing.Size(159, 22)
        Me.teks_item_tire4.TabIndex = 48
        '
        'label_item_tire_4
        '
        Me.label_item_tire_4.AutoSize = True
        Me.label_item_tire_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_item_tire_4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.label_item_tire_4.Location = New System.Drawing.Point(559, 102)
        Me.label_item_tire_4.Name = "label_item_tire_4"
        Me.label_item_tire_4.Size = New System.Drawing.Size(112, 20)
        Me.label_item_tire_4.TabIndex = 47
        Me.label_item_tire_4.Text = "ITEM TIRE 4"
        '
        'teks_item_tire5
        '
        Me.teks_item_tire5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.teks_item_tire5.Location = New System.Drawing.Point(32, 193)
        Me.teks_item_tire5.Name = "teks_item_tire5"
        Me.teks_item_tire5.Size = New System.Drawing.Size(159, 22)
        Me.teks_item_tire5.TabIndex = 50
        '
        'label_item_tire_5
        '
        Me.label_item_tire_5.AutoSize = True
        Me.label_item_tire_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_item_tire_5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.label_item_tire_5.Location = New System.Drawing.Point(28, 168)
        Me.label_item_tire_5.Name = "label_item_tire_5"
        Me.label_item_tire_5.Size = New System.Drawing.Size(112, 20)
        Me.label_item_tire_5.TabIndex = 49
        Me.label_item_tire_5.Text = "ITEM TIRE 5"
        '
        'teks_item_tire3
        '
        Me.teks_item_tire3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.teks_item_tire3.Location = New System.Drawing.Point(386, 127)
        Me.teks_item_tire3.Name = "teks_item_tire3"
        Me.teks_item_tire3.Size = New System.Drawing.Size(159, 22)
        Me.teks_item_tire3.TabIndex = 52
        '
        'label_item_tire_3
        '
        Me.label_item_tire_3.AutoSize = True
        Me.label_item_tire_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_item_tire_3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.label_item_tire_3.Location = New System.Drawing.Point(382, 102)
        Me.label_item_tire_3.Name = "label_item_tire_3"
        Me.label_item_tire_3.Size = New System.Drawing.Size(112, 20)
        Me.label_item_tire_3.TabIndex = 51
        Me.label_item_tire_3.Text = "ITEM TIRE 3"
        '
        'rd_button_manual
        '
        Me.rd_button_manual.AutoSize = True
        Me.rd_button_manual.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rd_button_manual.Location = New System.Drawing.Point(687, 306)
        Me.rd_button_manual.Name = "rd_button_manual"
        Me.rd_button_manual.Size = New System.Drawing.Size(75, 17)
        Me.rd_button_manual.TabIndex = 53
        Me.rd_button_manual.TabStop = True
        Me.rd_button_manual.Text = "MANUAL"
        Me.rd_button_manual.UseVisualStyleBackColor = True
        '
        'rd_button_upload
        '
        Me.rd_button_upload.AutoSize = True
        Me.rd_button_upload.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rd_button_upload.Location = New System.Drawing.Point(687, 336)
        Me.rd_button_upload.Name = "rd_button_upload"
        Me.rd_button_upload.Size = New System.Drawing.Size(94, 17)
        Me.rd_button_upload.TabIndex = 54
        Me.rd_button_upload.TabStop = True
        Me.rd_button_upload.Text = "UPLOAD FILE"
        Me.rd_button_upload.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Image = Global.Test_UI.My.Resources.Resources.edit_2_24
        Me.Button1.Location = New System.Drawing.Point(712, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 41)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "EDIT ITEM INFORMATION"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tmbl_insert
        '
        Me.tmbl_insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.tmbl_insert.FlatAppearance.BorderSize = 0
        Me.tmbl_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tmbl_insert.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmbl_insert.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.tmbl_insert.Image = Global.Test_UI.My.Resources.Resources.plus_5_16
        Me.tmbl_insert.Location = New System.Drawing.Point(563, 187)
        Me.tmbl_insert.Name = "tmbl_insert"
        Me.tmbl_insert.Size = New System.Drawing.Size(83, 30)
        Me.tmbl_insert.TabIndex = 55
        Me.tmbl_insert.Text = "INSERT"
        Me.tmbl_insert.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.tmbl_insert.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.DimGray
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Image = Global.Test_UI.My.Resources.Resources.trash_6_16
        Me.Button3.Location = New System.Drawing.Point(687, 489)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 37)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "CLEAR TABLE"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Image = Global.Test_UI.My.Resources.Resources.arrow_180_16
        Me.Button2.Location = New System.Drawing.Point(687, 547)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 37)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "UPLOAD"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'tmbl_search
        '
        Me.tmbl_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.tmbl_search.FlatAppearance.BorderSize = 0
        Me.tmbl_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tmbl_search.Image = Global.Test_UI.My.Resources.Resources.search_3_16
        Me.tmbl_search.Location = New System.Drawing.Point(248, 55)
        Me.tmbl_search.Name = "tmbl_search"
        Me.tmbl_search.Size = New System.Drawing.Size(42, 27)
        Me.tmbl_search.TabIndex = 24
        Me.tmbl_search.UseVisualStyleBackColor = False
        '
        'teks_sub_kategori
        '
        Me.teks_sub_kategori.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.teks_sub_kategori.Location = New System.Drawing.Point(386, 193)
        Me.teks_sub_kategori.Name = "teks_sub_kategori"
        Me.teks_sub_kategori.Size = New System.Drawing.Size(159, 22)
        Me.teks_sub_kategori.TabIndex = 58
        '
        'lbl_sub
        '
        Me.lbl_sub.AutoSize = True
        Me.lbl_sub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lbl_sub.Location = New System.Drawing.Point(382, 168)
        Me.lbl_sub.Name = "lbl_sub"
        Me.lbl_sub.Size = New System.Drawing.Size(142, 20)
        Me.lbl_sub.TabIndex = 57
        Me.lbl_sub.Text = "SUB KATEGORI"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Image = Global.Test_UI.My.Resources.Resources.edit_2_24
        Me.Button4.Location = New System.Drawing.Point(712, 59)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 41)
        Me.Button4.TabIndex = 59
        Me.Button4.Text = "TAMBAH KATEGORI"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button4.UseVisualStyleBackColor = False
        '
        'form_input_new_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(844, 607)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.teks_sub_kategori)
        Me.Controls.Add(Me.lbl_sub)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tmbl_insert)
        Me.Controls.Add(Me.rd_button_upload)
        Me.Controls.Add(Me.rd_button_manual)
        Me.Controls.Add(Me.teks_item_tire3)
        Me.Controls.Add(Me.label_item_tire_3)
        Me.Controls.Add(Me.teks_item_tire5)
        Me.Controls.Add(Me.label_item_tire_5)
        Me.Controls.Add(Me.teks_item_tire4)
        Me.Controls.Add(Me.label_item_tire_4)
        Me.Controls.Add(Me.teks_item_tire1)
        Me.Controls.Add(Me.label_item_tire_1)
        Me.Controls.Add(Me.teks_item_tire2)
        Me.Controls.Add(Me.label_item_tire_2)
        Me.Controls.Add(Me.teks_item_safety)
        Me.Controls.Add(Me.label_item_safety)
        Me.Controls.Add(Me.teks_item_code2)
        Me.Controls.Add(Me.label_item_code_2)
        Me.Controls.Add(Me.teks_item_desk)
        Me.Controls.Add(Me.label_item_desk)
        Me.Controls.Add(Me.teks_item_code)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.combo_kategori)
        Me.Controls.Add(Me.lbl_kategori)
        Me.Controls.Add(Me.dataa)
        Me.Controls.Add(Me.label_item_code)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.tmbl_search)
        Me.Controls.Add(Me.teksfile)
        Me.Controls.Add(Me.lbl_input)
        Me.Name = "form_input_new_item"
        Me.Text = "FORM INPUT NEW ITEM"
        CType(Me.dataa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents combo_kategori As ComboBox
    Friend WithEvents lbl_kategori As Label
    Friend WithEvents dataa As DataGridView
    Friend WithEvents label_item_code As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents tmbl_search As Button
    Friend WithEvents teksfile As TextBox
    Friend WithEvents lbl_input As Label
    Friend WithEvents teks_item_code As TextBox
    Friend WithEvents teks_item_desk As TextBox
    Friend WithEvents label_item_desk As Label
    Friend WithEvents teks_item_code2 As TextBox
    Friend WithEvents label_item_code_2 As Label
    Friend WithEvents teks_item_safety As TextBox
    Friend WithEvents label_item_safety As Label
    Friend WithEvents teks_item_tire2 As TextBox
    Friend WithEvents label_item_tire_2 As Label
    Friend WithEvents teks_item_tire1 As TextBox
    Friend WithEvents label_item_tire_1 As Label
    Friend WithEvents teks_item_tire4 As TextBox
    Friend WithEvents label_item_tire_4 As Label
    Friend WithEvents teks_item_tire5 As TextBox
    Friend WithEvents label_item_tire_5 As Label
    Friend WithEvents teks_item_tire3 As TextBox
    Friend WithEvents label_item_tire_3 As Label
    Friend WithEvents rd_button_manual As RadioButton
    Friend WithEvents rd_button_upload As RadioButton
    Friend WithEvents tmbl_insert As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents teks_sub_kategori As TextBox
    Friend WithEvents lbl_sub As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
End Class
