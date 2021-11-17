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
    public partial class frmDoktorlarListesi : Ortaklar
    {
        //private ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        private int secimId = -1;
        public bool Secim1 = false;
        public frmDoktorlarListesi()
        {
            InitializeComponent();
        }

        private void frmDoktorlarListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in db.tblCariler
                       where s.isActive == true
                       select s).ToList();
            foreach (tblCariler k in lst)  
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.CariNo;
                Liste.Rows[i].Cells[3].Value = k.CariAdi;
                Liste.Rows[i].Cells[4].Value = k.CariTel;
                Liste.Rows[i].Cells[5].Value = k.CariMail;
                Liste.Rows[i].Cells[6].Value = k.YetkiliCep1;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1; //gelen değer null ise -1 al.                 

            if (secimId > 0 && Secim1 && Application.OpenForms["frmHastaneGiris"] == null)
            {
                //frmDoktorGiris frm = new frmDoktorGiris();
                //frm.MdiParent = Home.ActiveForm;//Form.Activeform yerine formun adını yazdık çünkü sonradan bu formunda bir parenti olabilir bu yüzden ileride çakışma ihtimali yüksektir.

                //frm.Show();
                //frm.Ac(secimId); // frm.Ac showun üstünde olduğu zaman showdan sonra tekrar loada dönüyor ve şehir ve Departman bilgileri sıfırlanıyor.
                Home.Aktarma = secimId;
                Close();
            }
            else if (Application.OpenForms["frmHastaneGiris"] != null)
            {
                frmDoktorGiris frm1 = Application.OpenForms["frmDoktorGiris"] as frmDoktorGiris;
                frm1.Ac(secimId);
                Close();




            }
        }
    }
}
