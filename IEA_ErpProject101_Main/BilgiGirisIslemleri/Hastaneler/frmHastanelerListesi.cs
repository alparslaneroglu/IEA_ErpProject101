using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri
{
    public partial class frmHastanelerListesi : Form
    {
        public frmHastanelerListesi()
        {
            InitializeComponent();
        }

        private void frmHastanelerListesi_Load(object sender, EventArgs e)
        {

        }

        private void frmHastanelerListesi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home.kontrol = false;
            this.Dispose();// Kapatma butonuna bastığımızda arka planda ramdeki ilgili işlemler sıfırlanıyor.Garbage Collage gönderiliyor.
        }
    }
}
