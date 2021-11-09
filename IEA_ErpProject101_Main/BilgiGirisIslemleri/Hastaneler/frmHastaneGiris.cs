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

namespace IEA_ErpProject101_Main.BilgiGirisIslemleri.Hastaneler
{
    public partial class frmHastaneGiris : Form
    {
        private readonly ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        public frmHastaneGiris()
        {
            InitializeComponent();
        }

        private void frmHastaneGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }

        private void ComboDoldur()
        {
            var lst = erp.tblDepartmanlar.Where(x => x.GrupId == 1).ToList();
            var lst1 = erp.tblDepartmanlar.Where(x => x.GrupId == 1).ToList();
            var lst2 = erp.tblDepartmanlar.Where(x => x.GrupId == 1).ToList();


            txtDepartman1.DataSource = lst;
            txtDepartman1.ValueMember = "Id";
            txtDepartman1.DisplayMember = "DepartmanAdi";
            txtDepartman1.SelectedIndex = -1;//Default değer olarak boş getiriyor
           
            txtDepartman2.DataSource = lst1;
            txtDepartman2.ValueMember = "Id";
            txtDepartman2.DisplayMember = "DepartmanAdi";
            txtDepartman2.SelectedIndex = -1;

            txtDepartman3.DataSource = lst2;
            txtDepartman3.ValueMember = "Id";
            txtDepartman3.DisplayMember = "DepartmanAdi";
            txtDepartman3.SelectedIndex = -1;
        }

        private void frmHastaneGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home.kontrol = false;
        }

        private void btnFormCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
