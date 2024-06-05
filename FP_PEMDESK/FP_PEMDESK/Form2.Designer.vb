<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txttanggal = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txttotal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtharga = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtfaktur = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtnamapembeli = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtjumlah = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbomakanan = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnstruk = New Guna.UI2.WinForms.Guna2Button()
        Me.btnlaporan = New Guna.UI2.WinForms.Guna2Button()
        Me.btnhapus = New Guna.UI2.WinForms.Guna2Button()
        Me.btnsimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.btnkeluar = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvdata = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackgroundImage = CType(resources.GetObject("Guna2Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.Controls.Add(Me.txttanggal)
        Me.Guna2Panel1.Controls.Add(Me.txttotal)
        Me.Guna2Panel1.Controls.Add(Me.txtharga)
        Me.Guna2Panel1.Controls.Add(Me.txtfaktur)
        Me.Guna2Panel1.Controls.Add(Me.txtnamapembeli)
        Me.Guna2Panel1.Controls.Add(Me.txtjumlah)
        Me.Guna2Panel1.Controls.Add(Me.cbomakanan)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.btnstruk)
        Me.Guna2Panel1.Controls.Add(Me.btnlaporan)
        Me.Guna2Panel1.Controls.Add(Me.btnhapus)
        Me.Guna2Panel1.Controls.Add(Me.btnsimpan)
        Me.Guna2Panel1.Controls.Add(Me.btnkeluar)
        Me.Guna2Panel1.Controls.Add(Me.dgvdata)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(967, 562)
        Me.Guna2Panel1.TabIndex = 0
        '
        'txttanggal
        '
        Me.txttanggal.Checked = True
        Me.txttanggal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txttanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.txttanggal.Location = New System.Drawing.Point(753, 3)
        Me.txttanggal.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.txttanggal.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(200, 36)
        Me.txttanggal.TabIndex = 6
        Me.txttanggal.Value = New Date(2023, 12, 23, 0, 53, 5, 409)
        '
        'txttotal
        '
        Me.txttotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttotal.DefaultText = ""
        Me.txttotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txttotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txttotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txttotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txttotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttotal.Location = New System.Drawing.Point(757, 98)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttotal.PlaceholderText = ""
        Me.txttotal.SelectedText = ""
        Me.txttotal.Size = New System.Drawing.Size(183, 23)
        Me.txttotal.TabIndex = 5
        '
        'txtharga
        '
        Me.txtharga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtharga.DefaultText = ""
        Me.txtharga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtharga.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtharga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtharga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtharga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtharga.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtharga.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtharga.Location = New System.Drawing.Point(439, 196)
        Me.txtharga.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtharga.PlaceholderText = ""
        Me.txtharga.SelectedText = ""
        Me.txtharga.Size = New System.Drawing.Size(183, 24)
        Me.txtharga.TabIndex = 4
        '
        'txtfaktur
        '
        Me.txtfaktur.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfaktur.DefaultText = ""
        Me.txtfaktur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfaktur.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfaktur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfaktur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfaktur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfaktur.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtfaktur.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfaktur.Location = New System.Drawing.Point(439, 62)
        Me.txtfaktur.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtfaktur.Name = "txtfaktur"
        Me.txtfaktur.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfaktur.PlaceholderText = ""
        Me.txtfaktur.SelectedText = ""
        Me.txtfaktur.Size = New System.Drawing.Size(183, 24)
        Me.txtfaktur.TabIndex = 4
        '
        'txtnamapembeli
        '
        Me.txtnamapembeli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtnamapembeli.DefaultText = ""
        Me.txtnamapembeli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtnamapembeli.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtnamapembeli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnamapembeli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtnamapembeli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnamapembeli.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtnamapembeli.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnamapembeli.Location = New System.Drawing.Point(439, 15)
        Me.txtnamapembeli.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnamapembeli.Name = "txtnamapembeli"
        Me.txtnamapembeli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnamapembeli.PlaceholderText = ""
        Me.txtnamapembeli.SelectedText = ""
        Me.txtnamapembeli.Size = New System.Drawing.Size(183, 24)
        Me.txtnamapembeli.TabIndex = 4
        '
        'txtjumlah
        '
        Me.txtjumlah.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtjumlah.DefaultText = ""
        Me.txtjumlah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtjumlah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtjumlah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtjumlah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtjumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtjumlah.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtjumlah.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtjumlah.Location = New System.Drawing.Point(439, 156)
        Me.txtjumlah.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjumlah.PlaceholderText = ""
        Me.txtjumlah.SelectedText = ""
        Me.txtjumlah.Size = New System.Drawing.Size(183, 24)
        Me.txtjumlah.TabIndex = 4
        '
        'cbomakanan
        '
        Me.cbomakanan.BackColor = System.Drawing.Color.Transparent
        Me.cbomakanan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbomakanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomakanan.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbomakanan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbomakanan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbomakanan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbomakanan.ItemHeight = 30
        Me.cbomakanan.Location = New System.Drawing.Point(439, 98)
        Me.cbomakanan.Name = "cbomakanan"
        Me.cbomakanan.Size = New System.Drawing.Size(289, 36)
        Me.cbomakanan.TabIndex = 3
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(286, 191)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(56, 26)
        Me.Guna2HtmlLabel5.TabIndex = 2
        Me.Guna2HtmlLabel5.Text = "Harga"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(753, 62)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(105, 26)
        Me.Guna2HtmlLabel3.TabIndex = 2
        Me.Guna2HtmlLabel3.Text = "Total Harga"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(286, 151)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(69, 26)
        Me.Guna2HtmlLabel2.TabIndex = 2
        Me.Guna2HtmlLabel2.Text = "Jumlah"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(286, 10)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(77, 26)
        Me.Guna2HtmlLabel4.TabIndex = 2
        Me.Guna2HtmlLabel4.Text = "Pembeli"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(286, 62)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(61, 26)
        Me.Guna2HtmlLabel6.TabIndex = 2
        Me.Guna2HtmlLabel6.Text = "Faktur"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(286, 98)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(54, 26)
        Me.Guna2HtmlLabel1.TabIndex = 2
        Me.Guna2HtmlLabel1.Text = "Menu"
        '
        'btnstruk
        '
        Me.btnstruk.BackColor = System.Drawing.Color.Transparent
        Me.btnstruk.BorderRadius = 15
        Me.btnstruk.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnstruk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnstruk.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnstruk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnstruk.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnstruk.ForeColor = System.Drawing.Color.White
        Me.btnstruk.Location = New System.Drawing.Point(734, 179)
        Me.btnstruk.Name = "btnstruk"
        Me.btnstruk.Size = New System.Drawing.Size(206, 55)
        Me.btnstruk.TabIndex = 1
        Me.btnstruk.Text = "STRUK"
        '
        'btnlaporan
        '
        Me.btnlaporan.BackColor = System.Drawing.Color.Transparent
        Me.btnlaporan.BorderRadius = 15
        Me.btnlaporan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnlaporan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnlaporan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnlaporan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnlaporan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnlaporan.ForeColor = System.Drawing.Color.White
        Me.btnlaporan.Location = New System.Drawing.Point(734, 487)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Size = New System.Drawing.Size(206, 55)
        Me.btnlaporan.TabIndex = 1
        Me.btnlaporan.Text = "Lihat Laporan"
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.Transparent
        Me.btnhapus.BorderRadius = 15
        Me.btnhapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnhapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnhapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnhapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnhapus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnhapus.ForeColor = System.Drawing.Color.White
        Me.btnhapus.Location = New System.Drawing.Point(296, 498)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(167, 34)
        Me.btnhapus.TabIndex = 1
        Me.btnhapus.Text = "Hapus"
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.Transparent
        Me.btnsimpan.BorderRadius = 15
        Me.btnsimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnsimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnsimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnsimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnsimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnsimpan.ForeColor = System.Drawing.Color.White
        Me.btnsimpan.Location = New System.Drawing.Point(478, 498)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(167, 34)
        Me.btnsimpan.TabIndex = 1
        Me.btnsimpan.Text = "Simpan"
        '
        'btnkeluar
        '
        Me.btnkeluar.BackColor = System.Drawing.Color.Transparent
        Me.btnkeluar.BorderRadius = 15
        Me.btnkeluar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnkeluar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnkeluar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnkeluar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnkeluar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnkeluar.ForeColor = System.Drawing.Color.White
        Me.btnkeluar.Location = New System.Drawing.Point(49, 498)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(167, 34)
        Me.btnkeluar.TabIndex = 1
        Me.btnkeluar.Text = "Keluar"
        '
        'dgvdata
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvdata.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvdata.ColumnHeadersHeight = 4
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvdata.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvdata.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvdata.Location = New System.Drawing.Point(296, 240)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.RowHeadersVisible = False
        Me.dgvdata.RowHeadersWidth = 51
        Me.dgvdata.RowTemplate.Height = 24
        Me.dgvdata.Size = New System.Drawing.Size(644, 241)
        Me.dgvdata.TabIndex = 0
        Me.dgvdata.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvdata.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvdata.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvdata.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvdata.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvdata.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvdata.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvdata.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvdata.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvdata.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvdata.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvdata.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvdata.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvdata.ThemeStyle.ReadOnly = False
        Me.dgvdata.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvdata.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvdata.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvdata.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvdata.ThemeStyle.RowsStyle.Height = 24
        Me.dgvdata.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvdata.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 563)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnkeluar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvdata As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txttotal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtjumlah As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbomakanan As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnhapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnlaporan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txttanggal As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtharga As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnstruk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtnamapembeli As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtfaktur As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
