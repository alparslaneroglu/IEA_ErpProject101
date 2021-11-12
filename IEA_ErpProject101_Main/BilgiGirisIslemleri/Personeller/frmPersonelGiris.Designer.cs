
namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Personeller
{
    partial class frmPersonelGiris
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
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnFormCikis = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblPersonelKodu = new System.Windows.Forms.Label();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.txtCariTipi = new System.Windows.Forms.ComboBox();
            this.txtPUnvan = new System.Windows.Forms.ComboBox();
            this.txtPAdi = new System.Windows.Forms.TextBox();
            this.txtPDepartman = new System.Windows.Forms.ComboBox();
            this.txtPAdres2 = new System.Windows.Forms.TextBox();
            this.txtPAdres1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPMail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblhastanetel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPcep1 = new System.Windows.Forms.MaskedTextBox();
            this.lbladres = new System.Windows.Forms.Label();
            this.txtPTel = new System.Windows.Forms.MaskedTextBox();
            this.txtVerTcNo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblhastanemail = new System.Windows.Forms.Label();
            this.lbladres2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKayitBul = new System.Windows.Forms.TextBox();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBitis = new System.Windows.Forms.DateTimePicker();
            this.txtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Baslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bitis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDurum = new System.Windows.Forms.CheckBox();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlOrta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Sil64;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(271, 6);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(69, 48);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Save_icon64x64;
            this.btnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayit.Location = new System.Drawing.Point(14, 6);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(69, 48);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnFormCikis
            // 
            this.btnFormCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormCikis.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.exit_48;
            this.btnFormCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormCikis.Location = new System.Drawing.Point(1373, 12);
            this.btnFormCikis.Name = "btnFormCikis";
            this.btnFormCikis.Size = new System.Drawing.Size(52, 42);
            this.btnFormCikis.TabIndex = 4;
            this.btnFormCikis.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(101, 6);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(69, 48);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.Sil24x24;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(184, 6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(69, 48);
            this.btnSil.TabIndex = 2;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblPersonelKodu
            // 
            this.lblPersonelKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPersonelKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelKodu.Location = new System.Drawing.Point(660, 19);
            this.lblPersonelKodu.Name = "lblPersonelKodu";
            this.lblPersonelKodu.Size = new System.Drawing.Size(192, 23);
            this.lblPersonelKodu.TabIndex = 1;
            this.lblPersonelKodu.Text = "***";
            this.lblPersonelKodu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 505);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1437, 69);
            this.pnlAlt.TabIndex = 24;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Red;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 574);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1437, 11);
            this.splitter1.TabIndex = 26;
            this.splitter1.TabStop = false;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.lblPersonelKodu);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Controls.Add(this.btnFormCikis);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1437, 69);
            this.pnlUst.TabIndex = 23;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sira,
            this.CariKodu,
            this.CariAdi,
            this.CariTel,
            this.CariMail,
            this.Cep,
            this.Baslangic,
            this.Bitis});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 585);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(1437, 150);
            this.Liste.TabIndex = 25;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // txtSehir
            // 
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(190, 250);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(197, 24);
            this.txtSehir.TabIndex = 6;
            // 
            // txtCariTipi
            // 
            this.txtCariTipi.FormattingEnabled = true;
            this.txtCariTipi.Location = new System.Drawing.Point(190, 328);
            this.txtCariTipi.Name = "txtCariTipi";
            this.txtCariTipi.Size = new System.Drawing.Size(197, 24);
            this.txtCariTipi.TabIndex = 7;
            // 
            // txtPUnvan
            // 
            this.txtPUnvan.FormattingEnabled = true;
            this.txtPUnvan.Location = new System.Drawing.Point(188, 44);
            this.txtPUnvan.Name = "txtPUnvan";
            this.txtPUnvan.Size = new System.Drawing.Size(197, 24);
            this.txtPUnvan.TabIndex = 7;
            // 
            // txtPAdi
            // 
            this.txtPAdi.Location = new System.Drawing.Point(188, 71);
            this.txtPAdi.Name = "txtPAdi";
            this.txtPAdi.Size = new System.Drawing.Size(276, 22);
            this.txtPAdi.TabIndex = 0;
            // 
            // txtPDepartman
            // 
            this.txtPDepartman.FormattingEnabled = true;
            this.txtPDepartman.Location = new System.Drawing.Point(190, 203);
            this.txtPDepartman.Name = "txtPDepartman";
            this.txtPDepartman.Size = new System.Drawing.Size(276, 24);
            this.txtPDepartman.TabIndex = 11;
            // 
            // txtPAdres2
            // 
            this.txtPAdres2.Location = new System.Drawing.Point(717, 93);
            this.txtPAdres2.Multiline = true;
            this.txtPAdres2.Name = "txtPAdres2";
            this.txtPAdres2.Size = new System.Drawing.Size(647, 63);
            this.txtPAdres2.TabIndex = 4;
            // 
            // txtPAdres1
            // 
            this.txtPAdres1.Location = new System.Drawing.Point(717, 17);
            this.txtPAdres1.Multiline = true;
            this.txtPAdres1.Name = "txtPAdres1";
            this.txtPAdres1.Size = new System.Drawing.Size(647, 63);
            this.txtPAdres1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(69, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Personel Cep:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPMail
            // 
            this.txtPMail.Location = new System.Drawing.Point(190, 165);
            this.txtPMail.Name = "txtPMail";
            this.txtPMail.Size = new System.Drawing.Size(276, 22);
            this.txtPMail.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(64, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 28);
            this.label13.TabIndex = 14;
            this.label13.Text = "Tc No:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(67, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 28);
            this.label16.TabIndex = 14;
            this.label16.Text = "Şehir:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblhastanetel
            // 
            this.lblhastanetel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblhastanetel.Location = new System.Drawing.Point(67, 100);
            this.lblhastanetel.Name = "lblhastanetel";
            this.lblhastanetel.Size = new System.Drawing.Size(103, 23);
            this.lblhastanetel.TabIndex = 4;
            this.lblhastanetel.Text = "Personel Tel:";
            this.lblhastanetel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(69, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Departman:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPcep1
            // 
            this.txtPcep1.Location = new System.Drawing.Point(190, 133);
            this.txtPcep1.Mask = "(999) 000-0000";
            this.txtPcep1.Name = "txtPcep1";
            this.txtPcep1.Size = new System.Drawing.Size(118, 22);
            this.txtPcep1.TabIndex = 13;
            // 
            // lbladres
            // 
            this.lbladres.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbladres.Location = new System.Drawing.Point(583, 103);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(121, 35);
            this.lbladres.TabIndex = 4;
            this.lbladres.Text = "Personel Adres2:";
            this.lbladres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPTel
            // 
            this.txtPTel.Location = new System.Drawing.Point(188, 103);
            this.txtPTel.Mask = "(999) 000-0000";
            this.txtPTel.Name = "txtPTel";
            this.txtPTel.Size = new System.Drawing.Size(120, 22);
            this.txtPTel.TabIndex = 2;
            // 
            // txtVerTcNo
            // 
            this.txtVerTcNo.Location = new System.Drawing.Point(190, 369);
            this.txtVerTcNo.Mask = "00000000000";
            this.txtVerTcNo.Name = "txtVerTcNo";
            this.txtVerTcNo.Size = new System.Drawing.Size(138, 22);
            this.txtVerTcNo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(64, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Personel Tipi:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(37, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personel Unvan:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblhastanemail
            // 
            this.lblhastanemail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblhastanemail.Location = new System.Drawing.Point(67, 165);
            this.lblhastanemail.Name = "lblhastanemail";
            this.lblhastanemail.Size = new System.Drawing.Size(103, 23);
            this.lblhastanemail.TabIndex = 4;
            this.lblhastanemail.Text = "Personel Mail:";
            this.lblhastanemail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbladres2
            // 
            this.lbladres2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbladres2.Location = new System.Drawing.Point(586, 17);
            this.lbladres2.Name = "lbladres2";
            this.lbladres2.Size = new System.Drawing.Size(118, 42);
            this.lbladres2.TabIndex = 4;
            this.lbladres2.Text = "Personel Adres1:";
            this.lbladres2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(34, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personel Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKayitBul
            // 
            this.txtKayitBul.Location = new System.Drawing.Point(70, 17);
            this.txtKayitBul.Name = "txtKayitBul";
            this.txtKayitBul.Size = new System.Drawing.Size(394, 22);
            this.txtKayitBul.TabIndex = 25;
            // 
            // pnlOrta
            // 
            this.pnlOrta.AutoScroll = true;
            this.pnlOrta.Controls.Add(this.txtDurum);
            this.pnlOrta.Controls.Add(this.label4);
            this.pnlOrta.Controls.Add(this.label3);
            this.pnlOrta.Controls.Add(this.txtBitis);
            this.pnlOrta.Controls.Add(this.txtBaslangic);
            this.pnlOrta.Controls.Add(this.txtKayitBul);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.lbladres2);
            this.pnlOrta.Controls.Add(this.lblhastanemail);
            this.pnlOrta.Controls.Add(this.label2);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtVerTcNo);
            this.pnlOrta.Controls.Add(this.txtPTel);
            this.pnlOrta.Controls.Add(this.lbladres);
            this.pnlOrta.Controls.Add(this.txtPcep1);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.lblhastanetel);
            this.pnlOrta.Controls.Add(this.label16);
            this.pnlOrta.Controls.Add(this.label13);
            this.pnlOrta.Controls.Add(this.txtPMail);
            this.pnlOrta.Controls.Add(this.label11);
            this.pnlOrta.Controls.Add(this.txtPAdres1);
            this.pnlOrta.Controls.Add(this.txtPAdres2);
            this.pnlOrta.Controls.Add(this.txtPDepartman);
            this.pnlOrta.Controls.Add(this.txtPAdi);
            this.pnlOrta.Controls.Add(this.txtPUnvan);
            this.pnlOrta.Controls.Add(this.txtCariTipi);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 69);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1437, 436);
            this.pnlOrta.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(601, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "İs Baslangic T:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(881, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "İs Bitis T:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Visible = false;
            // 
            // txtBitis
            // 
            this.txtBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBitis.Location = new System.Drawing.Point(990, 248);
            this.txtBitis.Name = "txtBitis";
            this.txtBitis.Size = new System.Drawing.Size(195, 22);
            this.txtBitis.TabIndex = 27;
            this.txtBitis.Visible = false;
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtBaslangic.Location = new System.Drawing.Point(719, 176);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(195, 22);
            this.txtBaslangic.TabIndex = 26;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sıra";
            this.Sira.MinimumWidth = 6;
            this.Sira.Name = "Sira";
            this.Sira.Width = 62;
            // 
            // CariKodu
            // 
            this.CariKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariKodu.HeaderText = "Personel Kodu";
            this.CariKodu.MinimumWidth = 6;
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.Width = 130;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Personel Adı";
            this.CariAdi.MinimumWidth = 6;
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTel.HeaderText = "Personel Telefon";
            this.CariTel.MinimumWidth = 6;
            this.CariTel.Name = "CariTel";
            this.CariTel.Width = 133;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Personel Mail";
            this.CariMail.MinimumWidth = 6;
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 112;
            // 
            // Cep
            // 
            this.Cep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cep.HeaderText = "Personel Gsm";
            this.Cep.MinimumWidth = 6;
            this.Cep.Name = "Cep";
            this.Cep.Width = 116;
            // 
            // Baslangic
            // 
            this.Baslangic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = "-";
            this.Baslangic.DefaultCellStyle = dataGridViewCellStyle13;
            this.Baslangic.HeaderText = "Bas Tarih";
            this.Baslangic.MinimumWidth = 6;
            this.Baslangic.Name = "Baslangic";
            this.Baslangic.Width = 91;
            // 
            // Bitis
            // 
            this.Bitis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle14.Format = "d";
            dataGridViewCellStyle14.NullValue = "-";
            this.Bitis.DefaultCellStyle = dataGridViewCellStyle14;
            this.Bitis.HeaderText = "Bit Tarih";
            this.Bitis.MinimumWidth = 6;
            this.Bitis.Name = "Bitis";
            this.Bitis.Width = 83;
            // 
            // txtDurum
            // 
            this.txtDurum.AutoSize = true;
            this.txtDurum.Location = new System.Drawing.Point(539, 221);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(165, 21);
            this.txtDurum.TabIndex = 30;
            this.txtDurum.Text = "İs Bitis Tarihi Girilsin :";
            this.txtDurum.UseVisualStyleBackColor = true;
            this.txtDurum.Visible = false;
            this.txtDurum.CheckedChanged += new System.EventHandler(this.txtDurum_CheckedChanged);
           
            // 
            // frmPersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 735);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.Liste);
            this.Name = "frmPersonelGiris";
            this.Text = "frmPersonelGiris";
            this.Load += new System.EventHandler(this.frmPersonelGiris_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnFormCikis;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblPersonelKodu;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.ComboBox txtCariTipi;
        private System.Windows.Forms.ComboBox txtPUnvan;
        private System.Windows.Forms.TextBox txtPAdi;
        private System.Windows.Forms.ComboBox txtPDepartman;
        private System.Windows.Forms.TextBox txtPAdres2;
        private System.Windows.Forms.TextBox txtPAdres1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPMail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblhastanetel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtPcep1;
        private System.Windows.Forms.Label lbladres;
        private System.Windows.Forms.MaskedTextBox txtPTel;
        private System.Windows.Forms.MaskedTextBox txtVerTcNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblhastanemail;
        private System.Windows.Forms.Label lbladres2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKayitBul;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.DateTimePicker txtBitis;
        private System.Windows.Forms.DateTimePicker txtBaslangic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Baslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bitis;
        private System.Windows.Forms.CheckBox txtDurum;
    }
}