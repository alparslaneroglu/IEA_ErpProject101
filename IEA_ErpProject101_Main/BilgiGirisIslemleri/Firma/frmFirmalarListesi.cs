using IEA_ErpProject101_Main.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Firma
{
    public partial class frmFirmalarListesi : Form
    {
        private ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        private int secimId = -1;
        public bool Secim1 = false;
        public frmFirmalarListesi()
        {
            InitializeComponent();
        }

        private void frmFirmalarListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblCariler
                       where s.isActive == true
                       where s.CariGroupId==3
                       select s).ToList();
            foreach (tblCariler k in lst)  // tblcariler diyerek sadece oradan kayıt al dışarıdan alma diyoruz.
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.CariNo;
                Liste.Rows[i].Cells[3].Value = k.CariAdi;
                Liste.Rows[i].Cells[4].Value = k.CariTel;
                Liste.Rows[i].Cells[5].Value = k.CariMail;
                Liste.Rows[i].Cells[6].Value = k.YetkiliAdi1;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //enum classları mesela cevapları sürekli sabit olan şeylerin şablonları hazır tutuyoruz.Örneğin cinsiyet  kadın erkek belirtilmemiş .Bu seçeneklerden başka herhangi bir seçenek olmadığı için bu şekilde kullanmak istedğimiz herhangi bir yerden erişmemiz bu şekilde daha kolay oluyor.
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1; //gelen değer null ise -1 al.                 

            if (secimId > 0 && Secim1 && Application.OpenForms["frmFirmaGiris"] == null)
            {
                //frmFirmaGiris frm = new frmFirmaGiris();
                //frm.MdiParent = Home.ActiveForm;//Form.Activeform yerine formun adını yazdık çünkü sonradan bu formunda bir parenti olabilir bu yüzden ileride çakışma ihtimali yüksektir.

                //frm.Show();
                //frm.Ac(secimId); // frm.Ac showun üstünde olduğu zaman showdan sonra tekrar loada dönüyor ve şehir ve Departman bilgileri sıfırlanıyor.
                Home.Aktarma = secimId;
                Close();
            }
            else if (Application.OpenForms["frmFirmaGiris"] != null)
            {
                frmFirmaGiris frm1 = Application.OpenForms["frmFirmaGiris"] as frmFirmaGiris;
                frm1.Ac(secimId);
                Close();




            }
        }
    }
}
