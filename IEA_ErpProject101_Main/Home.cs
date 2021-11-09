using IEA_ErpProject101_Main.BilgiGirisIslemleri;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Hastaneler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject101_Main
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MenuOlustur();
        }

        private void MenuOlustur()
        {
            #region Bilgi Giriş Menüsü
            tvBilgiGirisİslemleri.Nodes.Add("Hastaneler"); // Düğüm oluşturduk bunun altında child ları oluşturacağız.
            tvBilgiGirisİslemleri.Nodes[0].Nodes.Add("Hastane Bilgi Giriş"); // Burada bir child oluşturduk.
            tvBilgiGirisİslemleri.Nodes[0].Nodes.Add("Hastaneler Listesi");


            tvBilgiGirisİslemleri.Nodes.Add("Doktorlar");
            tvBilgiGirisİslemleri.Nodes[1].Nodes.Add("Doktor Bilgi Giriş");
            tvBilgiGirisİslemleri.Nodes[1].Nodes.Add("Doktorlar Listesi");



            tvBilgiGirisİslemleri.Nodes.Add("Cariler");
            tvBilgiGirisİslemleri.Nodes[2].Nodes.Add("Cari Bilgi Giriş");
            tvBilgiGirisİslemleri.Nodes[2].Nodes.Add("Cariler Listesi");
            #endregion

            #region Depo İşlemleri Menüsü
            tvDepoIslemleri.Nodes.Add("Depo İşlemleri");  // Yeni bir buton için yeni bir düğüm oluşturuyoruz.Sonrasında child larını oluşturuyoruz.
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Stok Durum");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Sevkiyat Listesi"); 
            #endregion
        }

        private void TvGorunum()
        {
            tvBilgiGirisİslemleri.Visible = false;
            tvDepoIslemleri.Visible = false;
            tv3.Visible = false;
            tv4.Visible = false;
            tv5.Visible = false;
            tv6.Visible = false;
            tv7.Visible = false;
            tv8.Visible = false;
            tv9.Visible = false;
            tv10.Visible = false;
            tv11.Visible = false;
            tv12.Visible = false;
        }
        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            lblBilgiEkrani.Text = btnBilgiGiris.Text;
            TvGorunum();
            tvBilgiGirisİslemleri.Visible = true;

         }

        private void btnDepoIslemleri_Click(object sender, EventArgs e)
        {
            lblBilgiEkrani.Text = btnDepoIslemleri.Text;
            TvGorunum();
            tvDepoIslemleri.Visible = true;
        }

        private void tvBilgiGirisİslemleri_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
        public static  bool kontrol = false; // static sayesinde kontrolü diğer frmHastanelerListesinden çağırabiliyoruz.
        private void tvBilgiGirisİslemleri_DoubleClick(object sender, EventArgs e)
        {
            
            string isim = tvBilgiGirisİslemleri.SelectedNode.Text;
           // MessageBox.Show("isim");

            if (isim=="Hastaneler Listesi" && kontrol == false)
            {
                frmHastanelerListesi frm = new frmHastanelerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
                kontrol = true;
            }
            else if (isim == "Hastane Bilgi Giriş" && kontrol == false)
            {
                frmHastaneGiris frm = new frmHastaneGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
                kontrol = true;
            }
        }
    }
}
