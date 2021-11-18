﻿using IEA_ErpProject101_Main.BilgiGirisIslemleri;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Doktorlar;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Firma;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Hastaneler;
using IEA_ErpProject101_Main.BilgiGirisIslemleri.Personeller;
using IEA_ErpProject101_Main.DepoIslemleri.StokIslemleri;
using IEA_ErpProject101_Main.Fonksiyonlar;
using IEA_ErpProject101_Main.UrunIslemleri;
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
        formlar f = new formlar();
        internal static int Aktarma = -1;
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



            tvBilgiGirisİslemleri.Nodes.Add("Firmalar");
            tvBilgiGirisİslemleri.Nodes[2].Nodes.Add("Firma Bilgi Giriş");
            tvBilgiGirisİslemleri.Nodes[2].Nodes.Add("Firmalar Listesi");


            tvBilgiGirisİslemleri.Nodes.Add("Personeller");
            tvBilgiGirisİslemleri.Nodes[3].Nodes.Add("Personel Bilgi Giriş");
            tvBilgiGirisİslemleri.Nodes[3].Nodes.Add("Personeller Listesi");
            #endregion

            #region Depo İşlemleri Menüsü
            tvDepoIslemleri.Nodes.Add("Depo İşlemleri");  // Yeni bir buton için yeni bir düğüm oluşturuyoruz.Sonrasında child larını oluşturuyoruz.
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Stok Durum");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Stok Giriş");
            tvDepoIslemleri.Nodes[0].Nodes[1].Nodes.Add("Stok Giriş");
            tvDepoIslemleri.Nodes[0].Nodes[1].Nodes.Add("Stok Listesi");
            tvDepoIslemleri.Nodes[0].Nodes.Add("Depo Sevkiyat Listesi");
            #endregion

            #region Urun Islemleri
            tvUrunİslemleri.Nodes.Add("Urunler");
            tvUrunİslemleri.Nodes[0].Nodes.Add("Urun Giriş");
            tvUrunİslemleri.Nodes[0].Nodes.Add("Urunler Listesi");

            #endregion
        }

        private void TvGorunum()
        {
            tvBilgiGirisİslemleri.Visible = false;
            tvDepoIslemleri.Visible = false;
            tvUrunİslemleri.Visible = false;
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
        public static bool kontrol = false; // static sayesinde kontrolü diğer frmHastanelerListesinden çağırabiliyoruz.
        private void tvBilgiGirisİslemleri_DoubleClick(object sender, EventArgs e)
        {
            //string isim = "";
            // if (tvBilgiGirisİslemleri.SelectedNode!=null)
            // {

            //      isim = tvBilgiGirisİslemleri.SelectedNode.Text;
            //     // MessageBox.Show("isim");
            // }
            string isim = tvBilgiGirisİslemleri.SelectedNode != null ? tvBilgiGirisİslemleri.SelectedNode.Text : ""; // Turnery if ile yukarıdaki işlemi tek satırda halletik.Burada Form ekranında sol taraftaki ağaçlar kısmında bir listeyi açtıktan sonra boş biyere tıklarken aldığımız hatayı engelledik.

            if (isim == "Hastaneler Listesi" && Application.OpenForms["frmHastanelerListesi"] as frmHastanelerListesi is null)
            {
                //frmHastanelerListesi frm = new frmHastanelerListesi();
                //frm.MdiParent = Home.ActiveForm;
                //frm.Show();

                // kontrol = true;
                f.HastaneListesi();
            }
            else if (isim == "Hastane Bilgi Giriş" && Application.OpenForms["frmHastaneGiris"] as frmHastaneGiris is null)
            {
                frmHastaneGiris frm = new frmHastaneGiris();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();

                //kontrol = true;
            }
            else if (isim == "Doktor Bilgi Giriş" && Application.OpenForms["frmDoktorGiris"] is null)
            {
                frmDoktorGiris frm = new frmDoktorGiris();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            else if (isim == "Doktorlar Listesi" && Application.OpenForms["frmDoktorlarListesi"] is null)
            {
                //frmDoktorlarListesi frm = new frmDoktorlarListesi();
                //frm.MdiParent = Home.ActiveForm;
                //frm.Show();
                f.DoktorListesi();
            }
            else if (isim == "Personel Bilgi Giriş" && Application.OpenForms["frmPersonelGiris"] is null)
            {
                frmPersonelGiris frm = new frmPersonelGiris();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            else if (isim == "Personeller Listesi" && Application.OpenForms["frmPersonellerListesi"] is null)
            {
                //frmPersonellerListesi frm = new frmPersonellerListesi();
                //frm.MdiParent = Home.ActiveForm;
                //frm.Show();
                f.PersonelListesi();
            }
            else if (isim == "Firma Bilgi Giriş" && Application.OpenForms["frmFirmaGiris"] is null)
            {
                frmFirmaGiris frm = new frmFirmaGiris();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
            }
            else if (isim == "Firmalar Listesi" && Application.OpenForms["frmFirmalarListesi"] is null)
            {
            //    frmFirmalarListesi frm = new frmFirmalarListesi();
            //    frm.MdiParent = Home.ActiveForm;
            //    frm.Show();
            f.FirmaListesi();
            }
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            lblBilgiEkrani.Text = btnUrunIslemleri.Text;
            TvGorunum();
            tvUrunİslemleri.Visible = true;
        }

        private void tvUrunİslemleri_DoubleClick(object sender, EventArgs e)
        {
            string isim = tvUrunİslemleri.SelectedNode != null ? tvUrunİslemleri.SelectedNode.Text : "";
            if (isim == "Urunler Listesi" && Application.OpenForms["frmUrunlerListesi"] is null)
            {
                frmUrunlerListesi frm = new frmUrunlerListesi();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
                frm.Activate();
                // kontrol = true;
            }
            else if (isim == "Urun Giriş" && Application.OpenForms["frmUrunGiris"] is null)
            {


                frmUrunGiris frm = new frmUrunGiris();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
                frm.Activate();
                // kontrol = true;
                
            }
        }

        private void tvDepoIslemleri_DoubleClick(object sender, EventArgs e)
        {
            string isim = tvDepoIslemleri.SelectedNode != null ? tvDepoIslemleri.SelectedNode.Text : "";
            if (isim == "Stok Giriş" && Application.OpenForms["frmStokGiris"] is null)
            {
                frmStokGiris frm = new frmStokGiris();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
                frm.Activate();
               
            }
            else if (isim == "Stok Listesi" && Application.OpenForms["frmStokGirisListe"] is null)
            {

                frmStokGirisListe frm = new frmStokGirisListe();
                frm.MdiParent = Home.ActiveForm;
                frm.Show();
                frm.Activate();
                // kontrol = true;
            }
        }
    }
}
