using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sql sql = new Sql();
            sql.Add();
            sql.Deleted();
            MySql mySql = new MySql();
            mySql.Add();
            mySql.Deleted();

            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add() // Virtual ekleyerek kodu Aşağıda ezmemiz sağlandı.
        {
            Console.WriteLine("Added by Default");
        }
        public virtual void Deleted()
        {
            Console.WriteLine("Deleted by Default");
        }
    }
    class Sql : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add(); Base yani Database Deki Add metodunu çağırır.
        }
    }
    class MySql : Database
    {
        public override void Deleted()
        {
            Console.WriteLine("Deleted by MySql Code");
        }
    }
}
