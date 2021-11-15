using IEA_ErpProject101_Main.Entity;
using IEA_ErpProject101_Main.Fonksiyonlar;
using IEA_ErpProject101_Main.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Firma
{
    public partial class frmFirmaGiris : Form
    {
        private readonly ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        Numaralar n = new Numaralar();
        public int secimId = -1;
        public frmFirmaGiris()
        {
            InitializeComponent();
        }

        private void frmFirmaGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler
                       where s.isActive == true
                       where s.CariGroupId == 3
                       select new
                       {
                           id = s.Id,
                           hcode = s.CariNo,
                           hadi = s.CariAdi,
                           htel = s.CariTel,
                           hmail = s.CariMail,
                           hyet = s.YetkiliAdi1,
                           hyetcep=s.YetkiliCep1
                       }).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.hcode;
                Liste.Rows[i].Cells[3].Value = k.hadi;
                Liste.Rows[i].Cells[4].Value = k.htel;
                Liste.Rows[i].Cells[5].Value = k.hmail;
                Liste.Rows[i].Cells[6].Value = k.hyet;
                Liste.Rows[i].Cells[7].Value = k.hyetcep;
                i++;
                sira++;
            }
            lblFirmaKodu.Text = n.CariKoduFirma();
            Liste.AllowUserToAddRows = false;
        }

        private void ComboDoldur()
        {
            var lst = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var lst1 = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var lst2 = erp.tblDepartmanlar.Where(x => x.GrupId == 3).ToList();
            var lst3 = erp.tblSehirler.ToList();
            txtFTipi.DataSource = Enum.GetValues(typeof(enumFirmaTipi));

            txtFDepT1.DataSource = lst;
            txtFDepT1.ValueMember = "Id";
            txtFDepT1.DisplayMember = "DepartmanAdi";
            txtFDepT1.SelectedIndex = -1;//Default değer olarak boş getiriyor

           txtFDepT2.DataSource = lst1;
           txtFDepT2.ValueMember = "Id";
           txtFDepT2.DisplayMember = "DepartmanAdi";
           txtFDepT2.SelectedIndex = -1;

            txtFDepT3.DataSource = lst2;
            txtFDepT3.ValueMember = "Id";
            txtFDepT3.DisplayMember = "DepartmanAdi";
            txtFDepT3.SelectedIndex = -1;

            txtSehir.DataSource = lst3;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "Sehir";
            txtSehir.SelectedIndex = -1;
        }
        private void YeniKayit()
        {
            string hkodu = n.CariKoduFirma();
            try
            {
                if (txtFAdi.Text=="")
                {
                    return;
                }
                if (secimId == -1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtFAdi.Text;
                    hst.CariMail = txtFMail.Text;
                    hst.CariTel = txtFTel.Text;
                    hst.YetkiliAdi1 = txtFYet1.Text;
                    hst.YetkiliAdi2 = txtFYet2.Text;
                    hst.YetkiliAdi3 = txtFYet3.Text;
                    hst.YetkiliDepartmani1 = txtFDepT1.Text;
                    hst.YetkiliDepartmani2 = txtFDepT2.Text;
                    hst.YetkiliDepartmani3 = txtFDepT3.Text;
                    hst.YetkiliTel1 = txtFYtel1.Text;
                    hst.YetkiliTel2 = txtFYtel2.Text;
                    hst.YetkiliTel3 = txtFYtel3.Text;
                    hst.YetkiliCep1 = txtFYcep1.Text;
                    hst.YetkiliCep2 = txtFYcep2.Text;
                    hst.YetkiliCep3 = txtFYcep3.Text;
                    hst.YetkiliMail1 = txtFYEmail1.Text;
                    hst.YetkiliMail2 = txtFYEmail2.Text;
                    hst.YetkiliMail3 = txtFYEmail3.Text;
                    hst.SaveUserId = 1;
                    hst.SaveDate = DateTime.Now;

                    hst.Adres1 = txtFAdres1.Text;
                    hst.Adres2 = txtFAdres2.Text;
                    hst.CariGroupId = 3;
                    hst.CariTipId = (int)txtFTipi.SelectedValue;
                    
                    hst.VDairesi = txtVeriDairesi.Text;
                    hst.Tc_Vn = txtVerTcNo.Text;
                    hst.SehirId = (int?)txtSehir.SelectedValue ?? -1; // txtSehir.SelectedValue !=null ? (int)txtSehir.SelectedValue : -1; //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;   farklı çözümleri mevcuttur.
                    hst.CariNo = hkodu;

                    erp.tblCariler.Add(hst);
                    erp.SaveChanges();
                    MessageBox.Show("Kayıt başarılı..");
                    Temizle();
                    Listele();
                }
                else
                {
                    MessageBox.Show("Bu kayıt daha önce yapılmış.Kendine başka kayıt bul");
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
        public void Ac(int id)
        {
            secimId = id; // Dış fromdan veri gelirse secimId hatası almamak için bu işlemi yaptım.
            try
            {
                tblCariler hst = erp.tblCariler.Find(id);

                txtFAdi.Text = hst.CariAdi;
                txtFMail.Text = hst.CariMail;
                txtFTel.Text = hst.CariTel;
                txtFYet1.Text = hst.YetkiliAdi1;
                txtFYet2.Text = hst.YetkiliAdi2;
                txtFYet3.Text = hst.YetkiliAdi3;
                txtFDepT1.Text = hst.YetkiliDepartmani1;
                txtFDepT2.Text = hst.YetkiliDepartmani2;
                txtFDepT3.Text = hst.YetkiliDepartmani3;
                txtFYtel1.Text = hst.YetkiliTel1;
                txtFYtel2.Text = hst.YetkiliTel2;
                txtFYtel3.Text = hst.YetkiliTel3;
                txtFYcep1.Text = hst.YetkiliCep1;
                txtFYcep2.Text = hst.YetkiliCep2;
                txtFYcep3.Text = hst.YetkiliCep3;
                txtFYEmail1.Text = hst.YetkiliMail1;
                txtFYEmail2.Text = hst.YetkiliMail2;
                txtFYEmail3.Text = hst.YetkiliMail3;
                txtFAdres1.Text = hst.Adres1;
                txtFAdres2.Text = hst.Adres2;

                
                txtVeriDairesi.Text = hst.VDairesi;
                txtVerTcNo.Text = hst.Tc_Vn;
                txtSehir.Text = hst.tblSehirler.sehir;
                lblFirmaKodu.Text = hst.CariNo;
                txtKayitBul.Text = hst.CariNo;
                txtFTipi.Text = hst.CariUnvan;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button(); // Sanal arka planda bir buton oluşturduk Fiziksel bir buton değil.
            btn.Size = new Size(25, txtKayitBul.ClientSize.Height + 0);
            btn.Location = new Point(txtKayitBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.Image = Resources.arrow_1176;
            txtKayitBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += btn_Click;  //Click eventini çalıştırma.Manuel olarak click eventi çalıştırılamaz.

        }
        [DllImport("user32.dll")] // Buna gerek yok ama bunun sayesinde daha iyi çalışıyor.
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private void btn_Click(object sender, EventArgs e) //Click eventi oluşturduk.
        {
            if (Application.OpenForms["frmFirmalarListesi"] == null)
            {
                frmFirmalarListesi frm = new frmFirmalarListesi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            SendToBack(); // Eğer frmHastaneGiris içerisinde close yazdıysan ben frmHastaneGirisi kapatıyorum. This. ifadesini başına eklemeye gerek yok.
        }
        private void Temizle()
        {
            foreach (Control k in pnlOrta.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox)
                {
                    k.Text = "";
                }
            }
            secimId = -1;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void Guncelle()
        {
            try
            {
                tblCariler hst = erp.tblCariler.Find(secimId);
                if (secimId<0)
                {
                    return;
                }
                
                hst.CariAdi = txtFAdi.Text;
                hst.CariMail = txtFMail.Text;
                hst.CariTel = txtFTel.Text;
                hst.YetkiliAdi1 = txtFYet1.Text;
                hst.YetkiliAdi2 = txtFYet2.Text;
                hst.YetkiliAdi3 = txtFYet3.Text;
                hst.YetkiliDepartmani1 = txtFDepT1.Text;
                hst.YetkiliDepartmani2 = txtFDepT2.Text;
                hst.YetkiliDepartmani3 = txtFDepT3.Text;
                hst.YetkiliTel1 = txtFYtel1.Text;
                hst.YetkiliTel2 = txtFYtel2.Text;
                hst.YetkiliTel3 = txtFYtel3.Text;
                hst.YetkiliCep1 = txtFYcep1.Text;
                hst.YetkiliCep2 = txtFYcep2.Text;
                hst.YetkiliCep3 = txtFYcep3.Text;
                hst.YetkiliMail1 = txtFYEmail1.Text;
                hst.YetkiliMail2 = txtFYEmail2.Text;
                hst.YetkiliMail3 = txtFYEmail3.Text;
                hst.UpdateUserId = 1;
                hst.UpdateDate = DateTime.Now;

                hst.Adres1 = txtFAdres1.Text;
                hst.Adres2 = txtFAdres2.Text;
                hst.CariGroupId = 3;
                if (txtFTipi.Text!="")
                {
                    hst.CariTipId = (int)txtFTipi.SelectedValue;
                }
                hst.CariTipId = (int)txtFTipi.SelectedValue;

                hst.VDairesi = txtVeriDairesi.Text;
                hst.Tc_Vn = txtVerTcNo.Text;
                hst.SehirId = (int?)txtSehir.SelectedValue ?? -1; // txtSehir.SelectedValue !=null ? (int)txtSehir.SelectedValue : -1; //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;   farklı çözümleri mevcuttur.
               

                erp.SaveChanges();
                MessageBox.Show("Kayıt başarılı..");
                Temizle();
                Listele();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblCariler hst = erp.tblCariler.Find(secimId);
                hst.isActive = false;
                erp.SaveChanges();
                MessageBox.Show("Silme Başarılı");
                Temizle();
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        private void btnFormCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
