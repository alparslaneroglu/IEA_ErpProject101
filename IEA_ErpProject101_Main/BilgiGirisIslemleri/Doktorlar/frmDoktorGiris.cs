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

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Doktorlar
{
    public partial class frmDoktorGiris : Form
    {
        private readonly ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        Numaralar n = new Numaralar();
        public int secimId = -1;
        private tblCariler idyeGoreBul;
        public frmDoktorGiris()
        {
            InitializeComponent();
        }

        private void frmDoktorGiris_Load(object sender, EventArgs e)
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
                           where s.CariGroupId==2
                           select new
                           {
                               id = s.Id,
                               hcode = s.CariNo,
                               hadi = s.CariAdi,
                               htel = s.CariTel,
                               hmail = s.CariMail,
                               hgsm = s.YetkiliCep1
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
                Liste.Rows[i].Cells[6].Value = k.hgsm;
                i++;
                sira++;
            }
            lblDoktorKodu.Text = n.CariKoduDoktor();
            Liste.AllowUserToAddRows = false;
        }
        private void ComboDoldur()
        {
            txtDUnvan.DataSource = Enum.GetValues(typeof(DoktorUnvan));//Doktor unvanın içindeki tipi enum olan değerleri getir.
            var lst1 = erp.tblSehirler.ToList();

            var lst = erp.tblDepartmanlar.Where(x => x.GrupId == 1).ToList();
            
            txtDepartman1.DataSource = lst;
            txtDepartman1.ValueMember = "Id";
            txtDepartman1.DisplayMember = "DepartmanAdi";
            txtDepartman1.SelectedIndex = -1;


            txtSehir.DataSource = lst1;
            txtSehir.ValueMember = "id";
            txtSehir.DisplayMember = "Sehir";
            txtSehir.SelectedIndex = -1;
        }

        private void btnFormCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
            
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
                    hst.CariAdi = txtDAdi.Text;
                    hst.CariMail = txtDoktorMail.Text;
                    hst.CariTel = txtDoktorTel.Text;
                    hst.YetkiliCep1 = txtDcep1.Text;
                    hst.CariUnvan = txtDUnvan.Text;
                    hst.YetkiliDepartmani1 = txtDepartman1.Text;
                    hst.CariMail = txtDoktorMail.Text;
                    hst.SaveUserId = 1;
                    hst.SaveDate = DateTime.Now;

                    hst.Adres1 = txtAdres1.Text;
                    hst.Adres2 = txtAdres2.Text;
                    hst.CariGroupId = 2;
                    hst.CariTipId = 1;

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
            secimId = -1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                tblCariler hst = idyeGoreBul;
                hst.isActive = false;
                erp.SaveChanges();
                MessageBox.Show("Silme Başarılı");
                Temizle();
                Listele();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (secimId!=-1)
            {
                Guncelle(); 
            }
        }

        private void Guncelle()
        {
            if (secimId>0)
            {
                return;
            }

            tblCariler hst = idyeGoreBul;


            hst.isActive = true;
            hst.CariAdi = txtDAdi.Text;
            hst.CariMail = txtDoktorMail.Text;
            hst.CariTel = txtDoktorTel.Text;
            hst.YetkiliCep1 = txtDcep1.Text;
            hst.YetkiliDepartmani1 = txtDepartman1.Text;
            hst.CariUnvan = txtDUnvan.Text;
            hst.CariMail = txtDoktorMail.Text;
            hst.UpdateUserId = 1;
            hst.SaveDate = DateTime.Now;

            hst.Adres1 = txtAdres1.Text;
            hst.Adres2 = txtAdres2.Text;

            hst.CariTipId = 1;

            hst.VDairesi = txtVeriDairesi.Text;
            hst.Tc_Vn = txtVerTcNo.Text;
            hst.SehirId = (int?)txtSehir.SelectedValue ?? -1;


            erp.SaveChanges();
            MessageBox.Show("Guncelleme başarılı..");
            Temizle();
            Listele();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            Ac(secimId);
        }

        public void Ac(int id)
        {
            secimId = id;
                idyeGoreBul= erp.tblCariler.Find(id);
            try
                
            {
                tblCariler hst = idyeGoreBul;
                

                txtDAdi.Text = hst.CariAdi;
                txtDoktorMail.Text = hst.CariMail;
                txtDoktorTel.Text = hst.CariTel;
                txtDcep1.Text = hst.YetkiliCep1;
                txtDepartman1.Text = hst.YetkiliDepartmani1;
                txtDUnvan.Text = hst.CariUnvan;
                txtDoktorMail.Text = hst.CariMail;

                txtAdres1.Text = hst.Adres1;
                txtAdres2.Text = hst.Adres2;

                txtVeriDairesi.Text = hst.VDairesi;
                txtVerTcNo.Text = hst.Tc_Vn;
                txtSehir.Text = hst.tblSehirler.sehir==null ? "" : hst.tblSehirler.sehir;

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            
        }
    }
}
