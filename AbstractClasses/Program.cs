using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
   
        {
            Database databese = new MsSql();
            databese.Add();
            databese.Deleted();
            Database database2 = new Oracle();
            database2.Add();
            database2.Deleted();

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        //Abstract classlar ile hem tamamlanmış hem de tamamlanmamış metodlar tanımlayabiliriz.
        //Abstract classlar birer inheritance'dir.Bu yüzden her class için bir kez kullanılır sonrasında interfacelerimiz varsa ekleyebiliriz.Abstract claslar new keywordu alamaz.
        public void Add() // Tamamlanmış Metod
        {
            Console.WriteLine("Added by default");

        }

        public abstract void Deleted(); // Tamamlanmamış Metod
    }
    class MsSql : Database //Abstract lar sadece birkez tanımlanır.
    {
        //Abstract dediğimiz şey içi dolu olmayan virtual metoddur.
        public override void Deleted()
        {
            Console.WriteLine("Deleted by MsSql");
        }

    }
    class Oracle : Database
    {
        public override void Deleted()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
