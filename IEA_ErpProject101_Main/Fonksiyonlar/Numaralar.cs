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

                throw;
            }
        }
    }
}
