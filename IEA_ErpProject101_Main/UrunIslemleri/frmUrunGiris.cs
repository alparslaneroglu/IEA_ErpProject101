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
    public partial class frmUrunGiris : Form
    {
        ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        private int secimId = -1;
        
        public frmUrunGiris()
        {
            InitializeComponent();
        }

        private void frmUrunGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0, sira = 1;
            var lst=(from s in erp.tblUrunler
                    where s.TedarikciFirmaId==1
                    select s).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = sira;
                Liste.Rows[i].Cells[2].Value = k.UrunKodu;
                Liste.Rows[i].Cells[3].Value = k.UrunAdi;
                i++;
                sira++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ComboDoldur()
        {
            txtUrunTedarikciId.DataSource = Enum.GetValues(typeof(enumFirmaTipi));
        }
    }
}
