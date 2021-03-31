namespace PersonelTakipUygulamasi.Forms
{
    partial class FrmAnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAraclar = new System.Windows.Forms.Panel();
            this.cbxUnvan = new System.Windows.Forms.ComboBox();
            this.cbxDurumu = new System.Windows.Forms.ComboBox();
            this.cbxDepartman = new System.Windows.Forms.ComboBox();
            this.lblDurumu = new System.Windows.Forms.Label();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.lblDepartman = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.dateDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.tbxPersonelNo = new System.Windows.Forms.TextBox();
            this.lblPersonelNo = new System.Windows.Forms.Label();
            this.tbxTCKimlikNo = new System.Windows.Forms.TextBox();
            this.lblTCKimlikNo = new System.Windows.Forms.Label();
            this.tbxSoyAdi = new System.Windows.Forms.TextBox();
            this.lblSoyAdi = new System.Windows.Forms.Label();
            this.tbxAdi = new System.Windows.Forms.TextBox();
            this.lblAdi = new System.Windows.Forms.Label();
            this.pnlButonlar = new System.Windows.Forms.Panel();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dgwCalisanlar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAraclar.SuspendLayout();
            this.pnlButonlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCalisanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAraclar
            // 
            this.pnlAraclar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAraclar.Controls.Add(this.cbxUnvan);
            this.pnlAraclar.Controls.Add(this.cbxDurumu);
            this.pnlAraclar.Controls.Add(this.cbxDepartman);
            this.pnlAraclar.Controls.Add(this.lblDurumu);
            this.pnlAraclar.Controls.Add(this.lblUnvan);
            this.pnlAraclar.Controls.Add(this.lblDepartman);
            this.pnlAraclar.Controls.Add(this.lblDogumTarihi);
            this.pnlAraclar.Controls.Add(this.dateDogumTarihi);
            this.pnlAraclar.Controls.Add(this.tbxPersonelNo);
            this.pnlAraclar.Controls.Add(this.lblPersonelNo);
            this.pnlAraclar.Controls.Add(this.tbxTCKimlikNo);
            this.pnlAraclar.Controls.Add(this.lblTCKimlikNo);
            this.pnlAraclar.Controls.Add(this.tbxSoyAdi);
            this.pnlAraclar.Controls.Add(this.lblSoyAdi);
            this.pnlAraclar.Controls.Add(this.tbxAdi);
            this.pnlAraclar.Controls.Add(this.lblAdi);
            this.pnlAraclar.Location = new System.Drawing.Point(12, 89);
            this.pnlAraclar.Name = "pnlAraclar";
            this.pnlAraclar.Size = new System.Drawing.Size(507, 322);
            this.pnlAraclar.TabIndex = 0;
            // 
            // cbxUnvan
            // 
            this.cbxUnvan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxUnvan.FormattingEnabled = true;
            this.cbxUnvan.Items.AddRange(new object[] {
            "Kurul Başkanı",
            "Kurul Üyesi",
            "Departman Müdürü",
            "Departman Şefi",
            "Departman Çalışanı",
            "Yardımcı Hizmetler"});
            this.cbxUnvan.Location = new System.Drawing.Point(234, 228);
            this.cbxUnvan.Name = "cbxUnvan";
            this.cbxUnvan.Size = new System.Drawing.Size(256, 27);
            this.cbxUnvan.TabIndex = 17;
            this.cbxUnvan.Tag = "Unvan";
            // 
            // cbxDurumu
            // 
            this.cbxDurumu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDurumu.FormattingEnabled = true;
            this.cbxDurumu.Items.AddRange(new object[] {
            "Aktif Çalışan",
            "Sözleşmesi Askıda",
            "Ücretsiz İzinde",
            "İşten Çıkarılma",
            "İstifa"});
            this.cbxDurumu.Location = new System.Drawing.Point(234, 263);
            this.cbxDurumu.Name = "cbxDurumu";
            this.cbxDurumu.Size = new System.Drawing.Size(256, 27);
            this.cbxDurumu.TabIndex = 16;
            this.cbxDurumu.Tag = "Durumu";
            // 
            // cbxDepartman
            // 
            this.cbxDepartman.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDepartman.FormattingEnabled = true;
            this.cbxDepartman.Items.AddRange(new object[] {
            "Yönetim",
            "İdari İşler",
            "Muhasebe",
            "Satın Alma",
            "Pazarlama",
            "Yazılım",
            "Destek Hizmetleri"});
            this.cbxDepartman.Location = new System.Drawing.Point(234, 193);
            this.cbxDepartman.Name = "cbxDepartman";
            this.cbxDepartman.Size = new System.Drawing.Size(256, 27);
            this.cbxDepartman.TabIndex = 15;
            this.cbxDepartman.Tag = "Departman";
            // 
            // lblDurumu
            // 
            this.lblDurumu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDurumu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurumu.ForeColor = System.Drawing.Color.White;
            this.lblDurumu.Location = new System.Drawing.Point(18, 262);
            this.lblDurumu.Name = "lblDurumu";
            this.lblDurumu.Size = new System.Drawing.Size(210, 26);
            this.lblDurumu.TabIndex = 14;
            this.lblDurumu.Text = "DURUMU";
            this.lblDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDurumu.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblUnvan
            // 
            this.lblUnvan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUnvan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnvan.ForeColor = System.Drawing.Color.White;
            this.lblUnvan.Location = new System.Drawing.Point(18, 227);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(210, 26);
            this.lblUnvan.TabIndex = 12;
            this.lblUnvan.Text = "UNVAN";
            this.lblUnvan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDepartman
            // 
            this.lblDepartman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDepartman.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepartman.ForeColor = System.Drawing.Color.White;
            this.lblDepartman.Location = new System.Drawing.Point(18, 192);
            this.lblDepartman.Name = "lblDepartman";
            this.lblDepartman.Size = new System.Drawing.Size(210, 26);
            this.lblDepartman.TabIndex = 10;
            this.lblDepartman.Text = "DEPARTMAN";
            this.lblDepartman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDogumTarihi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.ForeColor = System.Drawing.Color.White;
            this.lblDogumTarihi.Location = new System.Drawing.Point(18, 157);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(210, 26);
            this.lblDogumTarihi.TabIndex = 9;
            this.lblDogumTarihi.Text = "DOĞUM TARİHİ";
            this.lblDogumTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateDogumTarihi
            // 
            this.dateDogumTarihi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDogumTarihi.Location = new System.Drawing.Point(234, 157);
            this.dateDogumTarihi.Name = "dateDogumTarihi";
            this.dateDogumTarihi.Size = new System.Drawing.Size(256, 26);
            this.dateDogumTarihi.TabIndex = 8;
            this.dateDogumTarihi.Tag = "DogumTarihi";
            this.dateDogumTarihi.ValueChanged += new System.EventHandler(this.dateDogumTarihi_ValueChanged);
            // 
            // tbxPersonelNo
            // 
            this.tbxPersonelNo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPersonelNo.Location = new System.Drawing.Point(234, 123);
            this.tbxPersonelNo.Name = "tbxPersonelNo";
            this.tbxPersonelNo.Size = new System.Drawing.Size(256, 26);
            this.tbxPersonelNo.TabIndex = 7;
            this.tbxPersonelNo.Tag = "PersonelNo";
            // 
            // lblPersonelNo
            // 
            this.lblPersonelNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPersonelNo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelNo.ForeColor = System.Drawing.Color.White;
            this.lblPersonelNo.Location = new System.Drawing.Point(18, 122);
            this.lblPersonelNo.Name = "lblPersonelNo";
            this.lblPersonelNo.Size = new System.Drawing.Size(210, 26);
            this.lblPersonelNo.TabIndex = 6;
            this.lblPersonelNo.Text = "PERSONEL NO";
            this.lblPersonelNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxTCKimlikNo
            // 
            this.tbxTCKimlikNo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTCKimlikNo.Location = new System.Drawing.Point(234, 85);
            this.tbxTCKimlikNo.Name = "tbxTCKimlikNo";
            this.tbxTCKimlikNo.Size = new System.Drawing.Size(256, 26);
            this.tbxTCKimlikNo.TabIndex = 5;
            this.tbxTCKimlikNo.Tag = "TCKimlikNo";
            // 
            // lblTCKimlikNo
            // 
            this.lblTCKimlikNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTCKimlikNo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCKimlikNo.ForeColor = System.Drawing.Color.White;
            this.lblTCKimlikNo.Location = new System.Drawing.Point(18, 84);
            this.lblTCKimlikNo.Name = "lblTCKimlikNo";
            this.lblTCKimlikNo.Size = new System.Drawing.Size(210, 26);
            this.lblTCKimlikNo.TabIndex = 4;
            this.lblTCKimlikNo.Text = "TC KİMLİK NO";
            this.lblTCKimlikNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxSoyAdi
            // 
            this.tbxSoyAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSoyAdi.Location = new System.Drawing.Point(234, 50);
            this.tbxSoyAdi.Name = "tbxSoyAdi";
            this.tbxSoyAdi.Size = new System.Drawing.Size(256, 26);
            this.tbxSoyAdi.TabIndex = 3;
            this.tbxSoyAdi.Tag = "SoyAdi";
            // 
            // lblSoyAdi
            // 
            this.lblSoyAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSoyAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyAdi.ForeColor = System.Drawing.Color.White;
            this.lblSoyAdi.Location = new System.Drawing.Point(18, 49);
            this.lblSoyAdi.Name = "lblSoyAdi";
            this.lblSoyAdi.Size = new System.Drawing.Size(210, 26);
            this.lblSoyAdi.TabIndex = 2;
            this.lblSoyAdi.Text = "SOYADI";
            this.lblSoyAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxAdi
            // 
            this.tbxAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAdi.Location = new System.Drawing.Point(234, 14);
            this.tbxAdi.Name = "tbxAdi";
            this.tbxAdi.Size = new System.Drawing.Size(256, 26);
            this.tbxAdi.TabIndex = 1;
            this.tbxAdi.Tag = "Adi";
            // 
            // lblAdi
            // 
            this.lblAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAdi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.ForeColor = System.Drawing.Color.White;
            this.lblAdi.Location = new System.Drawing.Point(18, 14);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(210, 26);
            this.lblAdi.TabIndex = 0;
            this.lblAdi.Text = "ADI";
            this.lblAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButonlar
            // 
            this.pnlButonlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButonlar.Controls.Add(this.btnHepsiniSil);
            this.pnlButonlar.Controls.Add(this.btnTemizle);
            this.pnlButonlar.Controls.Add(this.btnSil);
            this.pnlButonlar.Controls.Add(this.btnBul);
            this.pnlButonlar.Controls.Add(this.btnGetir);
            this.pnlButonlar.Controls.Add(this.btnGuncelle);
            this.pnlButonlar.Controls.Add(this.btnKaydet);
            this.pnlButonlar.Location = new System.Drawing.Point(12, 432);
            this.pnlButonlar.Name = "pnlButonlar";
            this.pnlButonlar.Size = new System.Drawing.Size(507, 206);
            this.pnlButonlar.TabIndex = 1;
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.BackColor = System.Drawing.Color.Gray;
            this.btnHepsiniSil.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniSil.ForeColor = System.Drawing.Color.Aqua;
            this.btnHepsiniSil.Location = new System.Drawing.Point(339, 81);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(151, 49);
            this.btnHepsiniSil.TabIndex = 7;
            this.btnHepsiniSil.Text = "HEPSİNİ SİL";
            this.btnHepsiniSil.UseVisualStyleBackColor = false;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Gray;
            this.btnTemizle.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Aqua;
            this.btnTemizle.Location = new System.Drawing.Point(182, 81);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(151, 49);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Gray;
            this.btnSil.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Aqua;
            this.btnSil.Location = new System.Drawing.Point(22, 81);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(151, 49);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "SEÇİLİ KAYDI SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnBul
            // 
            this.btnBul.BackColor = System.Drawing.Color.Gray;
            this.btnBul.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBul.ForeColor = System.Drawing.Color.Aqua;
            this.btnBul.Location = new System.Drawing.Point(261, 143);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(229, 49);
            this.btnBul.TabIndex = 4;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.Gray;
            this.btnGetir.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.ForeColor = System.Drawing.Color.Aqua;
            this.btnGetir.Location = new System.Drawing.Point(22, 143);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(229, 49);
            this.btnGetir.TabIndex = 3;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Gray;
            this.btnGuncelle.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Aqua;
            this.btnGuncelle.Location = new System.Drawing.Point(261, 15);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(229, 49);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Gray;
            this.btnKaydet.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Aqua;
            this.btnKaydet.Location = new System.Drawing.Point(22, 15);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(229, 49);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dgwCalisanlar
            // 
            this.dgwCalisanlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwCalisanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCalisanlar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwCalisanlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgwCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwCalisanlar.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgwCalisanlar.EnableHeadersVisualStyles = false;
            this.dgwCalisanlar.Location = new System.Drawing.Point(535, 89);
            this.dgwCalisanlar.Name = "dgwCalisanlar";
            this.dgwCalisanlar.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwCalisanlar.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgwCalisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCalisanlar.Size = new System.Drawing.Size(881, 549);
            this.dgwCalisanlar.TabIndex = 2;
            this.dgwCalisanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCalisanlar_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1404, 66);
            this.label1.TabIndex = 3;
            this.label1.Text = "PERSONEL TAKİP UYGULAMASI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1428, 669);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwCalisanlar);
            this.Controls.Add(this.pnlButonlar);
            this.Controls.Add(this.pnlAraclar);
            this.Name = "FrmAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Takip Uygulaması";
            this.Load += new System.EventHandler(this.FrmAnaMenu_Load);
            this.pnlAraclar.ResumeLayout(false);
            this.pnlAraclar.PerformLayout();
            this.pnlButonlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCalisanlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAraclar;
        private System.Windows.Forms.Label lblDurumu;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.Label lblDepartman;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.DateTimePicker dateDogumTarihi;
        private System.Windows.Forms.TextBox tbxPersonelNo;
        private System.Windows.Forms.Label lblPersonelNo;
        private System.Windows.Forms.TextBox tbxTCKimlikNo;
        private System.Windows.Forms.Label lblTCKimlikNo;
        private System.Windows.Forms.TextBox tbxSoyAdi;
        private System.Windows.Forms.Label lblSoyAdi;
        private System.Windows.Forms.TextBox tbxAdi;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.ComboBox cbxUnvan;
        private System.Windows.Forms.ComboBox cbxDurumu;
        private System.Windows.Forms.ComboBox cbxDepartman;
        private System.Windows.Forms.Panel pnlButonlar;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dgwCalisanlar;
        private System.Windows.Forms.Label label1;
    }
}