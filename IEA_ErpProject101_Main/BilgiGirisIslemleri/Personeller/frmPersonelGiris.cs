using IEA_ErpProject101_Main.Entity;
using IEA_ErpProject101_Main.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Personeller
{
    public partial class frmPersonelGiris : Form
    {
        private readonly ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        Numaralar n = new Numaralar();
        public int secimId = -1;
        public frmPersonelGiris()
        {
            InitializeComponent();
        }

        private void frmPersonelGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }
        private void Listele()
        {


            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblPersonelDetay
                       where s.tblCariler.isActive == true
                       where s.tblCariler.CariGroupId == 6
                       select s).ToList();


            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.tblCariler.CariNo;
                Liste.Rows[i].Cells[3].Value = k.tblCariler.CariAdi;
                Liste.Rows[i].Cells[4].Value = k.tblCariler.CariTel;
                Liste.Rows[i].Cells[5].Value = k.tblCariler.CariMail;
                Liste.Rows[i].Cells[6].Value = k.tblCariler.YetkiliCep1;
                Liste.Rows[i].Cells[7].Value = k.isBasiTarih;
                Liste.Rows[i].Cells[8].Value = k.isSonuTarih;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            lblPersonelKodu.Text = n.CariKoduPersonel();

        }
        private void ComboDoldur()
        {
            txtPUnvan.DataSource = Enum.GetValues(typeof(enumPersonelUnvan));//Doktor unvanın içindeki tipi enum olan değerleri getir.
            var lst1 = erp.tblSehirler.ToList();

            var lst = erp.tblDepartmanlar.Where(x => x.GrupId == 1).ToList();

            txtPDepartman.DataSource = lst;
            txtPDepartman.ValueMember = "Id";
            txtPDepartman.DisplayMember = "DepartmanAdi";
            txtPDepartman.SelectedIndex = -1;


            txtSehir.DataSource = lst1;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "Sehir";
            txtSehir.SelectedIndex = -1;
        }


        private void YeniKayit()
        {
            string hkodu = n.CariKoduHastane();
            try
            {
                if (secimId == -1)
                {
                    tblCariler hst = new tblCariler();
                    hst.isActive = true;
                    hst.CariAdi = txtPAdi.Text;
                    hst.CariMail = txtPMail.Text;
                    hst.CariTel = txtPTel.Text;
                    hst.YetkiliCep1 = txtPcep1.Text;
                    hst.CariUnvan = txtPUnvan.Text;
                    hst.YetkiliDepartmani1 = txtPDepartman.Text;
                    hst.CariMail = txtPMail.Text;
                    hst.SaveUserId = 1;
                    hst.SaveDate = DateTime.Now;

                    hst.Adres1 = txtPAdres1.Text;
                    hst.Adres2 = txtPAdres2.Text;
                    hst.CariGroupId = 6;
                    hst.CariTipId = 1;
                    
                    hst.Tc_Vn = txtVerTcNo.Text;
                    if (txtSehir.Text!="")
                    {
                        hst.SehirId = (int?)txtSehir.SelectedValue ?? -1; // txtSehir.SelectedValue !=null ? (int)txtSehir.SelectedValue : -1; //erp.tblSehirler.First(x => x.sehir == txtSehir.Text).id;   farklı çözümleri mevcuttur.
                    }
                    
                    hst.CariNo = hkodu;
                    erp.tblCariler.Add(hst);
                    erp.SaveChanges();
                    //Önce bir kayıt yaptık cünkü cariıd ihtiyacımız var ve bunu bir kere kayıt etmeden bulamayız. Ondan dolayı ilk başta carileri kayıt ettik.
                    tblPersonelDetay pdet = new tblPersonelDetay();
                    pdet.CariId = erp.tblCariler.First(x => x.CariAdi == txtPAdi.Text).Id;
                    pdet.isBasiTarih = txtBaslangic.Value;
                    //pdet.isSonuTarih = txtBitis.Value;
                    erp.tblPersonelDetay.Add(pdet);
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


        private void Guncelle()
        {
            if (secimId<0)
            {
                return;
            }
            tblPersonelDetay hst = erp.tblPersonelDetay.First(x=>x.Id==secimId);
            hst.tblCariler.CariAdi = txtPAdi.Text;

            hst.tblCariler.CariMail = txtPMail.Text;
            hst.tblCariler.CariTel = txtPTel.Text;
            hst.tblCariler.YetkiliCep1 = txtPcep1.Text;
            hst.tblCariler.YetkiliDepartmani1 = txtPDepartman.Text;
            hst.tblCariler.CariUnvan = txtPUnvan.Text;
            hst.tblCariler.CariMail = txtPMail.Text;
            hst.tblCariler.UpdateUserId = 1;
            hst.tblCariler.SaveDate = DateTime.Now;

            hst.tblCariler.Adres1 = txtPAdres1.Text;
            hst.tblCariler.Adres2 = txtPAdres2.Text;

            hst.tblCariler.CariTipId = 1;

            hst.tblCariler.Tc_Vn = txtVerTcNo.Text;
            hst.tblCariler.SehirId = (int?)txtSehir.SelectedValue ?? -1;
            hst.isBasiTarih = txtBaslangic.Value;
            if (txtDurum.Checked)
            {
                hst.isSonuTarih = txtBitis.Value;
            }


            erp.SaveChanges();
            MessageBox.Show("Guncelleme başarılı..");
            Temizle();
            Listele();
        }
        public void Ac(int id)
        {
            secimId = id;
            try
            {
                txtDurum.Visible = true;
                tblPersonelDetay hst = erp.tblPersonelDetay.First(x => x.Id== id);


                txtPAdi.Text = hst.tblCariler.CariAdi;
                txtPMail.Text = hst.tblCariler.CariMail;
                txtPTel.Text = hst.tblCariler.CariTel;
                txtPcep1.Text = hst.tblCariler.YetkiliCep1;
                txtPDepartman.Text = hst.tblCariler.YetkiliDepartmani1;
                txtPUnvan.Text = hst.tblCariler.CariUnvan;
                txtPMail.Text = hst.tblCariler.CariMail;

                txtPAdres1.Text = hst.tblCariler.Adres1;
                txtPAdres2.Text = hst.tblCariler.Adres2;

                txtVerTcNo.Text = hst.tblCariler.Tc_Vn;
                txtSehir.Text = hst.tblCariler.tblSehirler.sehir == null ? "" :hst.tblCariler.tblSehirler.sehir;
                txtBaslangic.Text = hst.isBasiTarih.ToString();
                txtBitis.Text = hst.isSonuTarih.ToString();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }


        }
        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void txtDurum_CheckedChanged(object sender, EventArgs e)
        {
            if (txtDurum.Checked)
            {
                label3.Visible = true;
                txtBitis.Visible = true;
            }
            else
            {
                label3.Visible = false;
                txtBitis.Visible = false;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
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

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
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
            label6.Visible = false;
            txtBitis.Visible = false;
            txtBitis.Text = "";
            secimId = -1;
            txtDurum.Visible = false;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        
    }
}
