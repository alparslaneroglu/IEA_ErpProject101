using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{               // Bir classta birden fazla interface kullanılıyor.Fakat miras alınamıyor.
    interface ICustomerDal
    {
        void Add(); // database yi tanımlanarken kendimiz bu şekilde tanımlayacağız.Bunların içerisini biz tanımlayacağız.
        void Update();
        void Delete();
    }
    class UseSqlDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");

        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");

        }
    }
    class UseOracle : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");

        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");

        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");

        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
