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

namespace IEA_ErpProject101_Main.UrunIslemleri
{
    
    public partial class frmUrunlerListesi : Form
    {
        Numaralar n = new Numaralar();
        ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        private int secimId = -1;
        public frmUrunlerListesi()
        {
            InitializeComponent();
        }

        private void frmUrunlerListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst = (from s in erp.tblUrunler
                       where s.isActive == true
                       select s).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.UrunGenelNo;
                Liste.Rows[i].Cells[3].Value = k.UrunKodu;
                Liste.Rows[i].Cells[4].Value = k.UrunAdi;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;

            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblFirmaKodu.Text = n.urunGenelKodu();
           // txtKayitBul.Text = n.urunGenelKodu();


        }

       

        

        private void Liste_DoubleClick_1(object sender, EventArgs e)
        {
            secimId = (int?)Liste.CurrentRow.Cells[0].Value ?? -1;
            if (secimId > 0 && Application.OpenForms["frmUrunGiris"] != null)
            {
                frmUrunGiris frm = Application.OpenForms["frmUrunGiris"] as frmUrunGiris;
                frm.Ac(secimId);
                Close();
            }
            else
            {
                frmUrunGiris frm = new frmUrunGiris();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
                frm.Ac(secimId);
            }
        }
    }
}
