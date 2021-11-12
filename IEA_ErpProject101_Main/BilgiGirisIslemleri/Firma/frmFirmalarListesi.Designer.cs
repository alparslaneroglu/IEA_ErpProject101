
namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Firma
{
    partial class frmFirmalarListesi
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblHastaneKodu = new System.Windows.Forms.Label();
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
            this.FirmaYetkili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FyCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
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
            this.pnlUst.Size = new System.Drawing.Size(1269, 69);
            this.pnlUst.TabIndex = 2;
            // 
            // lblHastaneKodu
            // 
            this.lblHastaneKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHastaneKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaneKodu.Location = new System.Drawing.Point(576, 19);
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
            // 
            // btnFormCikis
            // 
            this.btnFormCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormCikis.BackgroundImage = global::IEA_ErpProject101_Main.Properties.Resources.exit_48;
            this.btnFormCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFormCikis.Location = new System.Drawing.Point(1205, 12);
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
            this.FirmaYetkili,
            this.FyCep});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 69);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(1269, 645);
            this.Liste.TabIndex = 31;
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
            this.CariKodu.HeaderText = "FirmaKodu";
            this.CariKodu.MinimumWidth = 6;
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.Width = 105;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Firma Adı";
            this.CariAdi.MinimumWidth = 6;
            this.CariAdi.Name = "CariAdi";
            // 
            // CariTel
            // 
            this.CariTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTel.HeaderText = "Firma Telefon";
            this.CariTel.MinimumWidth = 6;
            this.CariTel.Name = "CariTel";
            this.CariTel.Width = 124;
            // 
            // CariMail
            // 
            this.CariMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariMail.HeaderText = "Firma Mail";
            this.CariMail.MinimumWidth = 6;
            this.CariMail.Name = "CariMail";
            this.CariMail.Width = 101;
            // 
            // FirmaYetkili
            // 
            this.FirmaYetkili.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirmaYetkili.HeaderText = "Firma Yetkili";
            this.FirmaYetkili.MinimumWidth = 6;
            this.FirmaYetkili.Name = "FirmaYetkili";
            // 
            // FyCep
            // 
            this.FyCep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FyCep.HeaderText = "Yetkili Cep no";
            this.FyCep.MinimumWidth = 6;
            this.FyCep.Name = "FyCep";
            this.FyCep.Width = 123;
            // 
            // frmFirmalarListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 714);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmFirmalarListesi";
            this.Text = "frmFirmalarListesi";
            this.Load += new System.EventHandler(this.frmFirmalarListesi_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblHastaneKodu;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnFormCikis;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaYetkili;
        private System.Windows.Forms.DataGridViewTextBoxColumn FyCep;
    }
}