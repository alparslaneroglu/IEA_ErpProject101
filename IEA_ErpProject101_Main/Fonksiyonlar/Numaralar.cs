using IEA_ErpProject101_Main.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject101_Main.Fonksiyonlar
{
    class Numaralar
    {
        private readonly ErpProjectWMPEntities erp = new ErpProjectWMPEntities();
        
        public string CariKoduHastane()
        {
            
            try
            {
                var numara = (from s in erp.tblCariler orderby s.Id descending select s).First().Id;
                numara++;
                string num ="H"+ numara.ToString().PadLeft(8, '0'); // 8 haneli olanakadar başına 0 ekliyor.
                return num;
            }
            catch (Exception )
            {
                return "00000001";
                
            }
        }
        public string CariKoduDoktor()
        {
            try
            {
                var numara = (from s in erp.tblCariler orderby s.Id descending select s).First().Id;
                numara++;
                string num = "D" + numara.ToString().PadLeft(8, '0'); // 8 haneli olanakadar başına 0 ekliyor.
                return num;
            }
            catch (Exception)
            {

                return "00000001";
            }
        }
        public string CariKoduPersonel()
        {
            try
            {
                var numara = (from s in erp.tblPersonelDetay orderby s.Id descending select s).First().Id;
                numara++;
                string num = "P" + numara.ToString().PadLeft(8, '0'); // 8 haneli olanakadar başına 0 ekliyor.
                return num;
            }
            catch (Exception)
            {

                return "P00000001";
            }
        }

        internal string CariKoduFirma()
        {
            try
            {
                var numara = (from s in erp.tblPersonelDetay orderby s.Id descending select s).First().Id;
                numara++;
                string num = "P" + numara.ToString().PadLeft(8, '0'); // 8 haneli olanakadar başına 0 ekliyor.
                return num;
            }
            catch (Exception)
            {

                return "F00000001";
            }
        }
        public string urunGenelKodu()
        {
            try
            {
                var numara = (from s in erp.tblUrunler orderby s.Id descending select s).First().Id;
                numara++;
                string num = "U" + numara.ToString().PadLeft(8, '0'); // 8 haneli olanakadar başına 0 ekliyor.
                return num;
            }
            catch (Exception)
            {

                return "U00000001";
            }
        }
        public string StokGirisGenelKodu()
        {
            try
            {
                var numara = (from s in erp.tblStokGirisUst orderby s.Id descending select s).First().Id;
                numara++;
                string num =numara.ToString().PadLeft(8, '0'); 
                return num;
            }
            catch (Exception)
            {

                return "00000001";
            }
        }
    }
}
