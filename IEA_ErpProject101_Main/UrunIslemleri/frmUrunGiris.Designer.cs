
namespace IEA_ErpProject101_Main.UrunIslemleri
{
    partial class frmUrunGiris
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
            this.lblFirmaKodu = new System.Windows.Forms.Label();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnFormCikis = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbladres2 = new System.Windows.Forms.Label();
            this.lblhastanemail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbladres = new System.Windows.Forms.Label();
            this.lblhastanetel = new System.Windows.Forms.Label();
            this.txtFMail = new System.Windows.Forms.TextBox();
            this.txtFAdres1 = new System.Windows.Forms.TextBox();
            this.txtFAdres2 = new System.Windows.Forms.TextBox();
            this.txtFAdi = new System.Windows.Forms.TextBox();
            this.txtUrunTedarikciId = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.pnlOrta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirmaKodu
            // 
            this.lblFirmaKodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFirmaKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaKodu.Location = new System.Drawing.Point(660, 19);
            this.lblFirmaKodu.Name = "lblFirmaKodu";
            this.lblFirmaKodu.Size = new System.Drawing.Size(192, 23);
            this.lblFirmaKodu.TabIndex = 1;
            this.lblFirmaKodu.Text = "***";
            this.lblFirmaKodu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(0, 499);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1437, 59);
            this.pnlAlt.TabIndex = 34;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Red;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 558);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1437, 37);
            this.splitter1.TabIndex = 36;
            this.splitter1.TabStop = false;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sira,
            this.GenelNo,
            this.UrunKodu,
            this.UrunAdi});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 595);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.RowTemplate.Height = 24;
            this.Liste.Size = new System.Drawing.Size(1437, 140);
            this.Liste.TabIndex = 35;
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
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUst.Controls.Add(this.lblFirmaKodu);
            this.pnlUst.Controls.Add(this.btnKayit);
            this.pnlUst.Controls.Add(this.btnFormCikis);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1437, 69);
            this.pnlUst.TabIndex = 33;
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
            // pnlOrta
            // 
            this.pnlOrta.AutoScroll = true;
            this.pnlOrta.Controls.Add(this.textBox3);
            this.pnlOrta.Controls.Add(this.label6);
            this.pnlOrta.Controls.Add(this.textBox2);
            this.pnlOrta.Controls.Add(this.label5);
            this.pnlOrta.Controls.Add(this.textBox1);
            this.pnlOrta.Controls.Add(this.label1);
            this.pnlOrta.Controls.Add(this.lbladres2);
            this.pnlOrta.Controls.Add(this.lblhastanemail);
            this.pnlOrta.Controls.Add(this.label2);
            this.pnlOrta.Controls.Add(this.lbladres);
            this.pnlOrta.Controls.Add(this.lblhastanetel);
            this.pnlOrta.Controls.Add(this.txtFMail);
            this.pnlOrta.Controls.Add(this.txtFAdres1);
            this.pnlOrta.Controls.Add(this.txtFAdres2);
            this.pnlOrta.Controls.Add(this.txtFAdi);
            this.pnlOrta.Controls.Add(this.txtUrunTedarikciId);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(0, 69);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(1437, 430);
            this.pnlOrta.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Genel No:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbladres2
            // 
            this.lbladres2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbladres2.Location = new System.Drawing.Point(582, 16);
            this.lbladres2.Name = "lbladres2";
            this.lbladres2.Size = new System.Drawing.Size(118, 30);
            this.lbladres2.TabIndex = 4;
            this.lbladres2.Text = "Urun Aciklama :";
            this.lbladres2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblhastanemail
            // 
            this.lblhastanemail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblhastanemail.Location = new System.Drawing.Point(65, 131);
            this.lblhastanemail.Name = "lblhastanemail";
            this.lblhastanemail.Size = new System.Drawing.Size(103, 23);
            this.lblhastanemail.TabIndex = 4;
            this.lblhastanemail.Text = "Urun Adi:";
            this.lblhastanemail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(37, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tedarikci";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbladres
            // 
            this.lbladres.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbladres.Location = new System.Drawing.Point(577, 80);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(124, 28);
            this.lbladres.TabIndex = 4;
            this.lbladres.Text = "Kutu İcerik :";
            this.lbladres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblhastanetel
            // 
            this.lblhastanetel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblhastanetel.Location = new System.Drawing.Point(67, 104);
            this.lblhastanetel.Name = "lblhastanetel";
            this.lblhastanetel.Size = new System.Drawing.Size(103, 23);
            this.lblhastanetel.TabIndex = 4;
            this.lblhastanetel.Text = "Urun Kodu:";
            this.lblhastanetel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFMail
            // 
            this.txtFMail.Location = new System.Drawing.Point(184, 132);
            this.txtFMail.Name = "txtFMail";
            this.txtFMail.Size = new System.Drawing.Size(276, 22);
            this.txtFMail.TabIndex = 3;
            // 
            // txtFAdres1
            // 
            this.txtFAdres1.Location = new System.Drawing.Point(706, 6);
            this.txtFAdres1.Multiline = true;
            this.txtFAdres1.Name = "txtFAdres1";
            this.txtFAdres1.Size = new System.Drawing.Size(415, 53);
            this.txtFAdres1.TabIndex = 5;
            // 
            // txtFAdres2
            // 
            this.txtFAdres2.Location = new System.Drawing.Point(706, 65);
            this.txtFAdres2.Multiline = true;
            this.txtFAdres2.Name = "txtFAdres2";
            this.txtFAdres2.Size = new System.Drawing.Size(415, 56);
            this.txtFAdres2.TabIndex = 4;
            // 
            // txtFAdi
            // 
            this.txtFAdi.Location = new System.Drawing.Point(184, 47);
            this.txtFAdi.Name = "txtFAdi";
            this.txtFAdi.Size = new System.Drawing.Size(276, 22);
            this.txtFAdi.TabIndex = 0;
            // 
            // txtUrunTedarikciId
            // 
            this.txtUrunTedarikciId.FormattingEnabled = true;
            this.txtUrunTedarikciId.Location = new System.Drawing.Point(184, 75);
            this.txtUrunTedarikciId.Name = "txtUrunTedarikciId";
            this.txtUrunTedarikciId.Size = new System.Drawing.Size(276, 24);
            this.txtUrunTedarikciId.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 22);
            this.textBox1.TabIndex = 50;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 22);
            this.textBox2.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(69, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 27);
            this.label5.TabIndex = 51;
            this.label5.Text = "Alis Fiyat :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(67, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 27);
            this.label6.TabIndex = 51;
            this.label6.Text = "Satis Fiyat :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(184, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 22);
            this.textBox3.TabIndex = 52;
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
            // GenelNo
            // 
            this.GenelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GenelNo.HeaderText = "Genel No";
            this.GenelNo.MinimumWidth = 6;
            this.GenelNo.Name = "GenelNo";
            this.GenelNo.Width = 97;
            // 
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunKodu.HeaderText = "Ürün Kodu";
            this.UrunKodu.MinimumWidth = 6;
            this.UrunKodu.Name = "UrunKodu";
            // 
            // UrunAdi
            // 
            this.UrunAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.MinimumWidth = 6;
            this.UrunAdi.Name = "UrunAdi";
            // 
            // frmUrunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 735);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlUst);
            this.Name = "frmUrunGiris";
            this.Text = "frmUrunGiris";
            this.Load += new System.EventHandler(this.frmUrunGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlOrta.ResumeLayout(false);
            this.pnlOrta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFirmaKodu;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnFormCikis;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbladres2;
        private System.Windows.Forms.Label lblhastanemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbladres;
        private System.Windows.Forms.Label lblhastanetel;
        private System.Windows.Forms.TextBox txtFMail;
        private System.Windows.Forms.TextBox txtFAdres1;
        private System.Windows.Forms.TextBox txtFAdres2;
        private System.Windows.Forms.TextBox txtFAdi;
        private System.Windows.Forms.ComboBox txtUrunTedarikciId;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
    }
}