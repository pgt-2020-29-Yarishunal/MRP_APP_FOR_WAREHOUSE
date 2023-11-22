<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class upload_customer
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
        Me.tmbl_insert = New System.Windows.Forms.Button()
        Me.rd_button_upload = New System.Windows.Forms.RadioButton()
        Me.rd_button_manual = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label_item_code = New System.Windows.Forms.Label()
        Me.tmbl_search = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.teksfile = New System.Windows.Forms.TextBox()
        Me.lbl_input = New System.Windows.Forms.Label()
        CType(Me.dataa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmbl_insert
        '
        Me.tmbl_insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.tmbl_insert.FlatAppearance.BorderSize = 0
        Me.tmbl_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tmbl_insert.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmbl_insert.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.tmbl_insert.Image = Global.Test_UI.My.Resources.Resources.plus_5_16
        Me.tmbl_insert.Location = New System.Drawing.Point(341, 161)
        Me.tmbl_insert.Name = "tmbl_insert"
        Me.tmbl_insert.Size = New System.Drawing.Size(83, 30)
        Me.tmbl_insert.TabIndex = 90
        Me.tmbl_insert.Text = "INSERT"
        Me.tmbl_insert.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.tmbl_insert.UseVisualStyleBackColor = False
        '
        'rd_button_upload
        '
        Me.rd_button_upload.AutoSize = True
        Me.rd_button_upload.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rd_button_upload.Location = New System.Drawing.Point(719, 329)
        Me.rd_button_upload.Name = "rd_button_upload"
        Me.rd_button_upload.Size = New System.Drawing.Size(94, 17)
        Me.rd_button_upload.TabIndex = 89
        Me.rd_button_upload.TabStop = True
        Me.rd_button_upload.Text = "UPLOAD FILE"
        Me.rd_button_upload.UseVisualStyleBackColor = True
        '
        'rd_button_manual
        '
        Me.rd_button_manual.AutoSize = True
        Me.rd_button_manual.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rd_button_manual.Location = New System.Drawing.Point(719, 299)
        Me.rd_button_manual.Name = "rd_button_manual"
        Me.rd_button_manual.Size = New System.Drawing.Size(75, 17)
        Me.rd_button_manual.TabIndex = 88
        Me.rd_button_manual.TabStop = True
        Me.rd_button_manual.Text = "MANUAL"
        Me.rd_button_manual.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Me.Button3.Location = New System.Drawing.Point(719, 482)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 37)
        Me.Button3.TabIndex = 70
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
        Me.Button2.Location = New System.Drawing.Point(719, 540)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 37)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "UPLOAD"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'combo_kategori
        '
        Me.combo_kategori.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_kategori.FormattingEnabled = True
        Me.combo_kategori.Items.AddRange(New Object() {"Sticker Reguler", "Sticker Eropa", "Sticker SASO", "Sticker GSO", "Sticker Inmetro", "Sticker Sendas", "Sticker Iraq", "Sticker RFID", "Sticker Alves", "Sticker Viramsum", "Sticker TIS", "Sticker USA", "NO STICKER"})
        Me.combo_kategori.Location = New System.Drawing.Point(24, 161)
        Me.combo_kategori.Name = "combo_kategori"
        Me.combo_kategori.Size = New System.Drawing.Size(259, 21)
        Me.combo_kategori.TabIndex = 68
        '
        'lbl_kategori
        '
        Me.lbl_kategori.AutoSize = True
        Me.lbl_kategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_kategori.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lbl_kategori.Location = New System.Drawing.Point(21, 132)
        Me.lbl_kategori.Name = "lbl_kategori"
        Me.lbl_kategori.Size = New System.Drawing.Size(100, 20)
        Me.lbl_kategori.TabIndex = 67
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
        Me.dataa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
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
        Me.dataa.Location = New System.Drawing.Point(16, 221)
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
        Me.dataa.Size = New System.Drawing.Size(677, 374)
        Me.dataa.TabIndex = 66
        '
        'Column1
        '
        Me.Column1.HeaderText = "Customer"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Sticker Reguler"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Sticker Eropa"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Sticker SASO"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sticker GSO"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Sticker Inmetro"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Sticker Sendas"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Sticker Iraq"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Sticker RFID"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Sticker Alves"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Sticker Viramsum"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Sticker TIS"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "Sticker USA"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.HeaderText = "NO STICKER"
        Me.Column14.Name = "Column14"
        '
        'label_item_code
        '
        Me.label_item_code.AutoSize = True
        Me.label_item_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_item_code.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.label_item_code.Location = New System.Drawing.Point(21, 32)
        Me.label_item_code.Name = "label_item_code"
        Me.label_item_code.Size = New System.Drawing.Size(108, 20)
        Me.label_item_code.TabIndex = 65
        Me.label_item_code.Text = "CUSTOMER"
        '
        'tmbl_search
        '
        Me.tmbl_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.tmbl_search.FlatAppearance.BorderSize = 0
        Me.tmbl_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tmbl_search.Image = Global.Test_UI.My.Resources.Resources.search_3_16
        Me.tmbl_search.Location = New System.Drawing.Point(242, 55)
        Me.tmbl_search.Name = "tmbl_search"
        Me.tmbl_search.Size = New System.Drawing.Size(42, 27)
        Me.tmbl_search.TabIndex = 62
        Me.tmbl_search.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(291, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "progress..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(25, 102)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(259, 13)
        Me.ProgressBar1.TabIndex = 63
        '
        'teksfile
        '
        Me.teksfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.teksfile.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teksfile.Location = New System.Drawing.Point(25, 55)
        Me.teksfile.Name = "teksfile"
        Me.teksfile.Size = New System.Drawing.Size(218, 27)
        Me.teksfile.TabIndex = 61
        '
        'lbl_input
        '
        Me.lbl_input.AutoSize = True
        Me.lbl_input.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_input.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lbl_input.Location = New System.Drawing.Point(21, 27)
        Me.lbl_input.Name = "lbl_input"
        Me.lbl_input.Size = New System.Drawing.Size(127, 25)
        Me.lbl_input.TabIndex = 60
        Me.lbl_input.Text = "INPUT FILE"
        '
        'upload_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 607)
        Me.Controls.Add(Me.tmbl_insert)
        Me.Controls.Add(Me.rd_button_upload)
        Me.Controls.Add(Me.rd_button_manual)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.combo_kategori)
        Me.Controls.Add(Me.lbl_kategori)
        Me.Controls.Add(Me.dataa)
        Me.Controls.Add(Me.label_item_code)
        Me.Controls.Add(Me.tmbl_search)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.teksfile)
        Me.Controls.Add(Me.lbl_input)
        Me.Name = "upload_customer"
        Me.Text = "FORM UPLOAD CUSTOMER"
        CType(Me.dataa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmbl_insert As Button
    Friend WithEvents rd_button_upload As RadioButton
    Friend WithEvents rd_button_manual As RadioButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents combo_kategori As ComboBox
    Friend WithEvents lbl_kategori As Label
    Friend WithEvents dataa As DataGridView
    Friend WithEvents label_item_code As Label
    Friend WithEvents tmbl_search As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents teksfile As TextBox
    Friend WithEvents lbl_input As Label
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
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
End Class
