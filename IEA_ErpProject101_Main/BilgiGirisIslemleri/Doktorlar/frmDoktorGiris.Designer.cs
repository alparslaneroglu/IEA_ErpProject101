
namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Doktorlar
{
    partial class frmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorGiris));
            this.txtKayitBul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbladres2 = new System.Windows.Forms.Label();
            this.lblhastanemail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVerTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtDoktorTel = new System.Windows.Forms.MaskedTextBox();
            this.lbladres = new System.Windows.Forms.Label();
            this.txtDcep1 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVeriDairesi = new System.Windows.Forms.TextBox();
            this.lblhastanetel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDoktorMail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdres2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAdres1 = new System.Windows.Forms.TextBox();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepartman1 = new System.Windows.Forms.ComboBox();
            this.txtDAdi = new System.Windows.Forms.TextBox();
            this.txtDUnvan = new System.Windows.Forms.ComboBox();
            this.txtCariTipi = new System.Windows.Forms.ComboBox();
            this.txtSehir = new System.Windows.Forms.ComboBox();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblDoktorKodu = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnFormCikis = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlOrta.SuspendLayout();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKayitBul
            // 
            this.txtKayitBul.Location = new System.Drawing.Point(70, 17);
            this.txtKayitBul.Name = "txtKayitBul";
            this.txtKayitBul.Size = new System.Drawing.Size(394, 22);
            this.txtKayitBul.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(34, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doktor Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbladres2
            // 
            this.lbladres2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbladres2.Location = new System.Drawing.Point(593, 17);
            this.lbladres2.Name = "lbladres2";
            this.lbladres2.Size = new System.Drawing.Size(111, 42);
            this.lbladres2.TabIndex = 4;
            this.lbladres2.Text = "Doktor Muayene Adres:";
            this.lbladres2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblhastanemail
            // 
            this.lblhastanemail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblhastanemail.Location = new System.Drawing.Point(67, 165);
            this.lblhastanemail.Name = "lblhastanemail";
            this.lblhastanemail.Size = new System.Drawing.Size(103, 23);
            this.lblhastanemail.TabIndex = 4;
            this.lblhastanemail.Text = "Doktor Mail";
            this.lblhastanemail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(64, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cari Tipi:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVerTcNo
            // 
            this.txtVerTcNo.Location = new System.Drawing.Point(190, 369);
            this.txtVerTcNo.Mask = "00000000000";
            this.txtVerTcNo.Name = "txtVerTcNo";
            this.txtVerTcNo.Size = new System.Drawing.Size(138, 22);
            this.txtVerTcNo.TabIndex = 9;
            // 
            // txtDoktorTel
            // 
            this.txtDoktorTel.Location = new System.Drawing.Point(188, 103);
            this.txtDoktorTel.Mask = "(999) 000-0000";
            this.txtDoktorTel.Name = "txtDoktorTel";
            this.txtDoktorTel.Size = new System.Drawing.Size(120, 22);
            this.txtDoktorTel.TabIndex = 2;
            // 
            // lbladres
            // 
            this.lbladres.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbladres.Location = new System.Drawing.Point(583, 103);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(121, 35);
            this.lbladres.TabIndex = 4;
            this.lbladres.Text = "Doktor Hast Adres:";
            this.lbladres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDcep1
            // 
            this.txtDcep1.Location = new System.Drawing.Point(190, 133);
            this.txtDcep1.Mask = "(999) 000-0000";
            this.txtDcep1.Name = "txtDcep1";
            this.txtDcep1.Size = new System.Drawing.Size(118, 22);
            this.txtDcep1.TabIndex = 13;
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
            // txtVeriDairesi
            // 
            this.txtVeriDairesi.Location = new System.Drawing.Point(190, 292);
            this.txtVeriDairesi.Name = "txtVeriDairesi";
            this.txtVeriDairesi.Size = new System.Drawing.Size(197, 22);
            this.txtVeriDairesi.TabIndex = 8;
            // 
            // lblhastanetel
            // 
            this.lblhastanetel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblhastanetel.Location = new System.Drawing.Point(67, 100);
            this.lblhastanetel.Name = "lblhastanetel";
            this.lblhastanetel.Size = new System.Drawing.Size(103, 23);
            this.lblhastanetel.TabIndex = 4;
            this.lblhastanetel.Text = "Doktor Tel:";
            this.lblhastanetel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(64, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 28);
            this.label13.TabIndex = 14;
            this.label13.Text = "Vergi No:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDoktorMail
            // 
            this.txtDoktorMail.Location = new System.Drawing.Point(190, 165);
            this.txtDoktorMail.Name = "txtDoktorMail";
            this.txtDoktorMail.Size = new System.Drawing.Size(276, 22);
            this.txtDoktorMail.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(69, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Cep:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdres2
            // 
            this.txtAdres2.Location = new System.Drawing.Point(717, 17);
            this.txtAdres2.Multiline = true;
            this.txtAdres2.Name = "txtAdres2";
            this.txtAdres2.Size = new System.Drawing.Size(647, 63);
            this.txtAdres2.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(67, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 27);
            this.label12.TabIndex = 4;
            this.label12.Text = "Vergi Dairesi:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdres1
            // 
            this.txtAdres1.Location = new System.Drawing.Point(717, 93);
            this.txtAdres1.Multiline = true;
            this.txtAdres1.Name = "txtAdres1";
            this.txtAdres1.Size = new System.Drawing.Size(647, 63);
            this.txtAdres1.TabIndex = 4;
            // 
            // pnlOrta
            // 
            this.pnlOrta.AutoScroll = true;
            this.pnlOrta.Controls.Add(this.txtKayitBul);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.lbladres2);
            this.pnlOrta.Controls.Add(this.lblhastanemail);
            this.pnlOrta.Controls.Add(this.label2);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.txtVerTcNo);
            this.pnlOrta.Controls.Add(this.txtDoktorTel);
            this.pnlOrta.Controls.Add(this.lbladres);
            this.pnlOrta.Controls.Add(this.txtDcep1);
            this.pnlOrta.Controls.Add(this.label8);
            this.pnlOrta.Controls.Add(this.txtVeriDairesi);
            this.pnlOrta.Controls.Add(this.lblhastanetel);
            this.pnlOrta.Controls.Add(this.label16);
            this.pnlOrta.Controls.Add(this.label13);
            this.pnlOrta.Controls.Add(this.txtDoktorMail);
            this.pnlOrta.Controls.Add(this.label11);
            this.pnlOrta.Controls.Add(this.txtAdres2);
            this.pnlOrta.Controls.Add(this.label12);
            this.pnlOrta.Controls.Add(this.txtAdres1);
            this.pnlOrta.Controls.Add(this.txtDepartman1);
            this.pnlOrta.Controls.Add(this.txtDAdi);
            this.pnlOrta.Controls.Add(this.txtDUnvan);
            this.pnlOrta.Controls.Add(this.txtCariTipi);
            this.pnlOrta.Controls.Add(this.txtSehir);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 69);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1437, 436);
            this.pnlOrta.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(67, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor Unvan:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDepartman1
            // 
            this.txtDepartman1.FormattingEnabled = true;
            this.txtDepartman1.Location = new System.Drawing.Point(190, 203);
            this.txtDepartman1.Name = "txtDepartman1";
            this.txtDepartman1.Size = new System.Drawing.Size(276, 24);
            this.txtDepartman1.TabIndex = 11;
            // 
            // txtDAdi
            // 
            this.txtDAdi.Location = new System.Drawing.Point(188, 71);
            this.txtDAdi.Name = "txtDAdi";
            this.txtDAdi.Size = new System.Drawing.Size(276, 22);
            this.txtDAdi.TabIndex = 0;
            // 
            // txtDUnvan
            // 
            this.txtDUnvan.FormattingEnabled = true;
            this.txtDUnvan.Location = new System.Drawing.Point(188, 44);
            this.txtDUnvan.Name = "txtDUnvan";
            this.txtDUnvan.Size = new System.Drawing.Size(197, 24);
            this.txtDUnvan.TabIndex = 7;
            // 
            // txtCariTipi
            // 
            this.txtCariTipi.FormattingEnabled = true;
            this.txtCariTipi.Location = new System.Drawing.Point(190, 328);
            this.txtCariTipi.Name = "txtCariTipi";
            this.txtCariTipi.Size = new System.Drawing.Size(197, 24);
            this.txtCariTipi.TabIndex = 7;
            // 
            // txtSehir
            // 
            this.txtSehir.FormattingEnabled = true;
            this.txtSehir.Location = new System.Drawing.Point(190, 250);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(197, 24);
            this.txtSehir.TabIndex = 6;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.lblDoktorKodu);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Controls.Add(this.btnFormCikis);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1437, 69);
            this.pnlUst.TabIndex = 18;
            // 
            // lblDoktorKodu
            // 
            this.lblDoktorKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDoktorKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorKodu.Location = new System.Drawing.Point(660, 19);
            this.lblDoktorKodu.Name = "lblDoktorKodu";
            this.lblDoktorKodu.Size = new System.Drawing.Size(192, 23);
            this.lblDoktorKodu.TabIndex = 1;
            this.lblDoktorKodu.Text = "***";
            this.lblDoktorKodu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.Cep});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 505);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(1437, 150);
            this.Liste.TabIndex = 20;
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
            this.CariKodu.HeaderText = "Doktor Kodu";
            this.CariKodu.MinimumWidth = 6;
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.Width = 107;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Doktor Adı";
            this.CariAdi.MinimumWidth = 6;
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTel.HeaderText = "Doktor Telefon";
            this.CariTel.MinimumWidth = 6;
            this.CariTel.Name = "CariTel";
            this.CariTel.Width = 120;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Doktor Mail";
            this.CariMail.MinimumWidth = 6;
            this.CariMail.Name = "CariMail";
            // 
            // Cep
            // 
            this.Cep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cep.HeaderText = "Doktor Gsm";
            this.Cep.MinimumWidth = 6;
            this.Cep.Name = "Cep";
            this.Cep.Width = 103;
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 655);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1437, 69);
            this.pnlAlt.TabIndex = 19;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Red;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 724);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1437, 11);
            this.splitter1.TabIndex = 21;
            this.splitter1.TabStop = false;
            // 
            // frmDoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 735);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.pnlUst);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoktorGiris";
            this.Text = "frmDoktorGiris";
            this.Load += new System.EventHandler(this.frmDoktorGiris_Load);
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKayitBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbladres2;
        private System.Windows.Forms.Label lblhastanemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtVerTcNo;
        private System.Windows.Forms.MaskedTextBox txtDoktorTel;
        private System.Windows.Forms.Label lbladres;
        private System.Windows.Forms.MaskedTextBox txtDcep1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVeriDairesi;
        private System.Windows.Forms.Label lblhastanetel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDoktorMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAdres2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAdres1;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.ComboBox txtDepartman1;
        private System.Windows.Forms.TextBox txtDAdi;
        private System.Windows.Forms.ComboBox txtCariTipi;
        private System.Windows.Forms.ComboBox txtSehir;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblDoktorKodu;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnFormCikis;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtDUnvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
    }
}