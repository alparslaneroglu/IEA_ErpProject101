
namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Hastaneler
{
    partial class frmHastaneGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaneGiris));
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblHastaneKodu = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnFormCikis = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YetkiliAdi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHastaneCari = new System.Windows.Forms.Label();
            this.lbladres = new System.Windows.Forms.Label();
            this.lbladres2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtYet1 = new System.Windows.Forms.TextBox();
            this.txtYet2 = new System.Windows.Forms.TextBox();
            this.txtYet3 = new System.Windows.Forms.TextBox();
            this.txtDepartman1 = new System.Windows.Forms.ComboBox();
            this.txtDepartman2 = new System.Windows.Forms.ComboBox();
            this.txtDepartman3 = new System.Windows.Forms.ComboBox();
            this.txtEmail3 = new System.Windows.Forms.TextBox();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.txtHastaneAdi = new System.Windows.Forms.TextBox();
            this.txtHastaneCari = new System.Windows.Forms.TextBox();
            this.txtAdres1 = new System.Windows.Forms.TextBox();
            this.txtAdres2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVeriDairesi = new System.Windows.Forms.TextBox();
            this.lblhastanemail = new System.Windows.Forms.Label();
            this.lblhastanetel = new System.Windows.Forms.Label();
            this.txtHastaneMail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.txtYcep1 = new System.Windows.Forms.MaskedTextBox();
            this.txtYcep2 = new System.Windows.Forms.MaskedTextBox();
            this.txtYcep3 = new System.Windows.Forms.MaskedTextBox();
            this.txtYtel1 = new System.Windows.Forms.MaskedTextBox();
            this.txtYtel2 = new System.Windows.Forms.MaskedTextBox();
            this.txtYtel3 = new System.Windows.Forms.MaskedTextBox();
            this.txtVerTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtHastaneTel = new System.Windows.Forms.MaskedTextBox();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.txtKayitBul = new System.Windows.Forms.TextBox();
            this.txtCariTipi = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlOrta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.lblHastaneKodu);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Controls.Add(this.btnFormCikis);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1437, 69);
            this.pnlUst.TabIndex = 0;
            // 
            // lblHastaneKodu
            // 
            this.lblHastaneKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHastaneKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaneKodu.Location = new System.Drawing.Point(660, 19);
            this.lblHastaneKodu.Name = "lblHastaneKodu";
            this.lblHastaneKodu.Size = new System.Drawing.Size(192, 23);
            this.lblHastaneKodu.TabIndex = 1;
            this.lblHastaneKodu.Text = "***";
            this.lblHastaneKodu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnFormCikis.Click += new System.EventHandler(this.btnFormCikis_Click);
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
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 666);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1437, 69);
            this.pnlAlt.TabIndex = 1;
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
            this.YetkiliAdi1});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 516);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(1437, 150);
            this.Liste.TabIndex = 2;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
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
            this.CariKodu.HeaderText = "Hastane Kodu";
            this.CariKodu.MinimumWidth = 6;
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.Width = 117;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Hastane Adı";
            this.CariAdi.MinimumWidth = 6;
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTel.HeaderText = "Hastane Telefon";
            this.CariTel.MinimumWidth = 6;
            this.CariTel.Name = "CariTel";
            this.CariTel.Width = 130;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Hastane Mail";
            this.CariMail.MinimumWidth = 6;
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 109;
            // 
            // YetkiliAdi1
            // 
            this.YetkiliAdi1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.YetkiliAdi1.HeaderText = "Yetkili Kişi";
            this.YetkiliAdi1.MinimumWidth = 6;
            this.YetkiliAdi1.Name = "YetkiliAdi1";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Red;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 505);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1437, 11);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hastane Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHastaneCari
            // 
            this.lblHastaneCari.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblHastaneCari.Location = new System.Drawing.Point(37, 74);
            this.lblHastaneCari.Name = "lblHastaneCari";
            this.lblHastaneCari.Size = new System.Drawing.Size(133, 23);
            this.lblHastaneCari.TabIndex = 4;
            this.lblHastaneCari.Text = "Hastane Cari Adı :";
            this.lblHastaneCari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbladres
            // 
            this.lbladres.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbladres.Location = new System.Drawing.Point(67, 175);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(103, 23);
            this.lbladres.TabIndex = 4;
            this.lbladres.Text = "Adres1:";
            this.lbladres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbladres2
            // 
            this.lbladres2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbladres2.Location = new System.Drawing.Point(678, 135);
            this.lbladres2.Name = "lbladres2";
            this.lbladres2.Size = new System.Drawing.Size(103, 23);
            this.lbladres2.TabIndex = 4;
            this.lbladres2.Text = "Adres2:";
            this.lbladres2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(423, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cari Tipi:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(613, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Yetkili ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(824, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Departman:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(1218, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "E-Mail:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(966, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Telefon:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(1083, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Cep:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(81, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 27);
            this.label12.TabIndex = 4;
            this.label12.Text = "Vergi Dairesi:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtYet1
            // 
            this.txtYet1.Location = new System.Drawing.Point(518, 45);
            this.txtYet1.Name = "txtYet1";
            this.txtYet1.Size = new System.Drawing.Size(214, 22);
            this.txtYet1.TabIndex = 10;
            // 
            // txtYet2
            // 
            this.txtYet2.Location = new System.Drawing.Point(518, 73);
            this.txtYet2.Name = "txtYet2";
            this.txtYet2.Size = new System.Drawing.Size(214, 22);
            this.txtYet2.TabIndex = 15;
            // 
            // txtYet3
            // 
            this.txtYet3.Location = new System.Drawing.Point(518, 101);
            this.txtYet3.Name = "txtYet3";
            this.txtYet3.Size = new System.Drawing.Size(214, 22);
            this.txtYet3.TabIndex = 20;
            // 
            // txtDepartman1
            // 
            this.txtDepartman1.FormattingEnabled = true;
            this.txtDepartman1.Location = new System.Drawing.Point(738, 43);
            this.txtDepartman1.Name = "txtDepartman1";
            this.txtDepartman1.Size = new System.Drawing.Size(207, 24);
            this.txtDepartman1.TabIndex = 11;
            // 
            // txtDepartman2
            // 
            this.txtDepartman2.FormattingEnabled = true;
            this.txtDepartman2.Location = new System.Drawing.Point(738, 69);
            this.txtDepartman2.Name = "txtDepartman2";
            this.txtDepartman2.Size = new System.Drawing.Size(207, 24);
            this.txtDepartman2.TabIndex = 16;
            // 
            // txtDepartman3
            // 
            this.txtDepartman3.FormattingEnabled = true;
            this.txtDepartman3.Location = new System.Drawing.Point(738, 97);
            this.txtDepartman3.Name = "txtDepartman3";
            this.txtDepartman3.Size = new System.Drawing.Size(207, 24);
            this.txtDepartman3.TabIndex = 21;
            // 
            // txtEmail3
            // 
            this.txtEmail3.Location = new System.Drawing.Point(1221, 98);
            this.txtEmail3.Name = "txtEmail3";
            this.txtEmail3.Size = new System.Drawing.Size(214, 22);
            this.txtEmail3.TabIndex = 24;
            // 
            // txtEmail2
            // 
            this.txtEmail2.Location = new System.Drawing.Point(1221, 70);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(214, 22);
            this.txtEmail2.TabIndex = 19;
            // 
            // txtEmail1
            // 
            this.txtEmail1.Location = new System.Drawing.Point(1221, 42);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(214, 22);
            this.txtEmail1.TabIndex = 14;
            // 
            // txtHastaneAdi
            // 
            this.txtHastaneAdi.Location = new System.Drawing.Point(188, 46);
            this.txtHastaneAdi.Name = "txtHastaneAdi";
            this.txtHastaneAdi.Size = new System.Drawing.Size(276, 22);
            this.txtHastaneAdi.TabIndex = 0;
            // 
            // txtHastaneCari
            // 
            this.txtHastaneCari.Location = new System.Drawing.Point(188, 75);
            this.txtHastaneCari.Name = "txtHastaneCari";
            this.txtHastaneCari.Size = new System.Drawing.Size(276, 22);
            this.txtHastaneCari.TabIndex = 1;
            // 
            // txtAdres1
            // 
            this.txtAdres1.Location = new System.Drawing.Point(188, 165);
            this.txtAdres1.Multiline = true;
            this.txtAdres1.Name = "txtAdres1";
            this.txtAdres1.Size = new System.Drawing.Size(482, 63);
            this.txtAdres1.TabIndex = 4;
            // 
            // txtAdres2
            // 
            this.txtAdres2.Location = new System.Drawing.Point(787, 135);
            this.txtAdres2.Multiline = true;
            this.txtAdres2.Name = "txtAdres2";
            this.txtAdres2.Size = new System.Drawing.Size(647, 63);
            this.txtAdres2.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(423, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 28);
            this.label13.TabIndex = 14;
            this.label13.Text = "Vergi No:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVeriDairesi
            // 
            this.txtVeriDairesi.Location = new System.Drawing.Point(201, 294);
            this.txtVeriDairesi.Name = "txtVeriDairesi";
            this.txtVeriDairesi.Size = new System.Drawing.Size(197, 22);
            this.txtVeriDairesi.TabIndex = 8;
            // 
            // lblhastanemail
            // 
            this.lblhastanemail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblhastanemail.Location = new System.Drawing.Point(65, 137);
            this.lblhastanemail.Name = "lblhastanemail";
            this.lblhastanemail.Size = new System.Drawing.Size(103, 23);
            this.lblhastanemail.TabIndex = 4;
            this.lblhastanemail.Text = "Hastane Mail:";
            this.lblhastanemail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblhastanetel
            // 
            this.lblhastanetel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblhastanetel.Location = new System.Drawing.Point(65, 103);
            this.lblhastanetel.Name = "lblhastanetel";
            this.lblhastanetel.Size = new System.Drawing.Size(103, 23);
            this.lblhastanetel.TabIndex = 4;
            this.lblhastanetel.Text = "Hastane Tel:";
            this.lblhastanetel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHastaneMail
            // 
            this.txtHastaneMail.Location = new System.Drawing.Point(188, 137);
            this.txtHastaneMail.Name = "txtHastaneMail";
            this.txtHastaneMail.Size = new System.Drawing.Size(276, 22);
            this.txtHastaneMail.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label16.Location = new System.Drawing.Point(81, 247);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 28);
            this.label16.TabIndex = 14;
            this.label16.Text = "Şehir:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSehir
            // 
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(201, 250);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(197, 24);
            this.txtSehir.TabIndex = 6;
            // 
            // txtYcep1
            // 
            this.txtYcep1.Location = new System.Drawing.Point(1081, 41);
            this.txtYcep1.Mask = "(999) 000-0000";
            this.txtYcep1.Name = "txtYcep1";
            this.txtYcep1.Size = new System.Drawing.Size(118, 22);
            this.txtYcep1.TabIndex = 13;
            // 
            // txtYcep2
            // 
            this.txtYcep2.Location = new System.Drawing.Point(1081, 69);
            this.txtYcep2.Mask = "(999) 000-0000";
            this.txtYcep2.Name = "txtYcep2";
            this.txtYcep2.Size = new System.Drawing.Size(118, 22);
            this.txtYcep2.TabIndex = 18;
            // 
            // txtYcep3
            // 
            this.txtYcep3.Location = new System.Drawing.Point(1081, 95);
            this.txtYcep3.Mask = "(999) 000-0000";
            this.txtYcep3.Name = "txtYcep3";
            this.txtYcep3.Size = new System.Drawing.Size(118, 22);
            this.txtYcep3.TabIndex = 23;
            // 
            // txtYtel1
            // 
            this.txtYtel1.Location = new System.Drawing.Point(951, 43);
            this.txtYtel1.Mask = "(999) 000-0000";
            this.txtYtel1.Name = "txtYtel1";
            this.txtYtel1.Size = new System.Drawing.Size(118, 22);
            this.txtYtel1.TabIndex = 12;
            // 
            // txtYtel2
            // 
            this.txtYtel2.Location = new System.Drawing.Point(951, 71);
            this.txtYtel2.Mask = "(999) 000-0000";
            this.txtYtel2.Name = "txtYtel2";
            this.txtYtel2.Size = new System.Drawing.Size(118, 22);
            this.txtYtel2.TabIndex = 17;
            // 
            // txtYtel3
            // 
            this.txtYtel3.Location = new System.Drawing.Point(951, 97);
            this.txtYtel3.Mask = "(999) 000-0000";
            this.txtYtel3.Name = "txtYtel3";
            this.txtYtel3.Size = new System.Drawing.Size(118, 22);
            this.txtYtel3.TabIndex = 22;
            // 
            // txtVerTcNo
            // 
            this.txtVerTcNo.Location = new System.Drawing.Point(532, 294);
            this.txtVerTcNo.Mask = "00000000000";
            this.txtVerTcNo.Name = "txtVerTcNo";
            this.txtVerTcNo.Size = new System.Drawing.Size(138, 22);
            this.txtVerTcNo.TabIndex = 9;
            // 
            // txtHastaneTel
            // 
            this.txtHastaneTel.Location = new System.Drawing.Point(188, 103);
            this.txtHastaneTel.Mask = "(999) 000-0000";
            this.txtHastaneTel.Name = "txtHastaneTel";
            this.txtHastaneTel.Size = new System.Drawing.Size(197, 22);
            this.txtHastaneTel.TabIndex = 2;
            // 
            // pnlOrta
            // 
            this.pnlOrta.AutoScroll = true;
            this.pnlOrta.Controls.Add(this.txtKayitBul);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.txtYtel3);
            this.pnlOrta.Controls.Add(this.lbladres2);
            this.pnlOrta.Controls.Add(this.txtYcep3);
            this.pnlOrta.Controls.Add(this.txtYtel2);
            this.pnlOrta.Controls.Add(this.lblhastanemail);
            this.pnlOrta.Controls.Add(this.txtYcep2);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtVerTcNo);
            this.pnlOrta.Controls.Add(this.lblHastaneCari);
            this.pnlOrta.Controls.Add(this.txtHastaneTel);
            this.pnlOrta.Controls.Add(this.label7);
            this.pnlOrta.Controls.Add(this.txtYtel1);
            this.pnlOrta.Controls.Add(this.lbladres);
            this.pnlOrta.Controls.Add(this.txtYcep1);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtVeriDairesi);
            this.pnlOrta.Controls.Add(this.lblhastanetel);
            this.pnlOrta.Controls.Add(this.label16);
            this.pnlOrta.Controls.Add(this.label9);
            this.pnlOrta.Controls.Add(this.label13);
            this.pnlOrta.Controls.Add(this.label10);
            this.pnlOrta.Controls.Add(this.txtHastaneMail);
            this.pnlOrta.Controls.Add(this.label11);
            this.pnlOrta.Controls.Add(this.txtAdres2);
            this.pnlOrta.Controls.Add(this.label12);
            this.pnlOrta.Controls.Add(this.txtAdres1);
            this.pnlOrta.Controls.Add(this.txtYet1);
            this.pnlOrta.Controls.Add(this.txtHastaneCari);
            this.pnlOrta.Controls.Add(this.txtYet2);
            this.pnlOrta.Controls.Add(this.txtYet3);
            this.pnlOrta.Controls.Add(this.txtDepartman1);
            this.pnlOrta.Controls.Add(this.txtHastaneAdi);
            this.pnlOrta.Controls.Add(this.txtCariTipi);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Controls.Add(this.txtEmail3);
            this.pnlOrta.Controls.Add(this.txtDepartman2);
            this.pnlOrta.Controls.Add(this.txtEmail2);
            this.pnlOrta.Controls.Add(this.txtDepartman3);
            this.pnlOrta.Controls.Add(this.txtEmail1);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 69);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1437, 436);
            this.pnlOrta.TabIndex = 17;
            // 
            // txtKayitBul
            // 
            this.txtKayitBul.Location = new System.Drawing.Point(184, 18);
            this.txtKayitBul.Name = "txtKayitBul";
            this.txtKayitBul.Size = new System.Drawing.Size(280, 22);
            this.txtKayitBul.TabIndex = 25;
            // 
            // txtCariTipi
            // 
            this.txtCariTipi.FormattingEnabled = true;
            this.txtCariTipi.Location = new System.Drawing.Point(532, 247);
            this.txtCariTipi.Name = "txtCariTipi";
            this.txtCariTipi.Size = new System.Drawing.Size(197, 24);
            this.txtCariTipi.TabIndex = 7;
            // 
            // frmHastaneGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 735);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.pnlUst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHastaneGiris";
            this.Text = "frmHastaneGiris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHastaneGiris_FormClosing);
            this.Load += new System.EventHandler(this.frmHastaneGiris_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnFormCikis;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHastaneCari;
        private System.Windows.Forms.Label lbladres;
        private System.Windows.Forms.Label lbladres2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtYet1;
        private System.Windows.Forms.TextBox txtYet2;
        private System.Windows.Forms.TextBox txtYet3;
        private System.Windows.Forms.ComboBox txtDepartman1;
        private System.Windows.Forms.ComboBox txtDepartman2;
        private System.Windows.Forms.ComboBox txtDepartman3;
        private System.Windows.Forms.TextBox txtEmail3;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.TextBox txtHastaneAdi;
        private System.Windows.Forms.TextBox txtHastaneCari;
        private System.Windows.Forms.TextBox txtAdres1;
        private System.Windows.Forms.TextBox txtAdres2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVeriDairesi;
        private System.Windows.Forms.Label lblhastanemail;
        private System.Windows.Forms.Label lblhastanetel;
        private System.Windows.Forms.TextBox txtHastaneMail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.MaskedTextBox txtYcep1;
        private System.Windows.Forms.MaskedTextBox txtYcep2;
        private System.Windows.Forms.MaskedTextBox txtYcep3;
        private System.Windows.Forms.MaskedTextBox txtYtel1;
        private System.Windows.Forms.MaskedTextBox txtYtel2;
        private System.Windows.Forms.MaskedTextBox txtYtel3;
        private System.Windows.Forms.MaskedTextBox txtVerTcNo;
        private System.Windows.Forms.MaskedTextBox txtHastaneTel;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn YetkiliAdi1;
        private System.Windows.Forms.Label lblHastaneKodu;
        private System.Windows.Forms.ComboBox txtCariTipi;
        private System.Windows.Forms.TextBox txtKayitBul;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}