using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();

            ICustomerDal[] cd = new ICustomerDal[]
            {
                new UseOracle(),
                new UseSqlDal()
            };
            foreach (var customerDal in cd)
            {
                customerDal.Add();
            }
            
            
            //CustomerManager cm = new CustomerManager();
            //cm.Add(new UseOracle());
            //cm.Add(new UseSqlDal());

            Console.ReadLine();
            
        }

        private static void NewMethod()
        {
            //Interfaceler hiçbir zaman new keyword ile kullanılamazlar.
            //IPerson iper = new IPerson(); bu yanlış çünkü soyut bir kavram ile somut bir kavramı eşleyemeyiz.
            //Ancak IPerson interfacesinden türettiğimiz sınıflar new lenebilir.
            IPerson person = new Customer(); // Map leme olayı budur.Yani İstenilen bütün bilgileri değil sadece person içerisinde olan bilgileri getiriyoruz.Normal şartlarda customer içerisinde adres bilgiside var fakat Iperson dan türettiğimiz için sadece onun içindeki 3 bilgiye ulaşıyoruz.
            IPerson person1 = new Student();



            Customer customer = new Customer
            {
                id = 1,
                Name = "Onur",
                LastName = "Agici",
                Adress = "Esengles"
            };
            Student student = new Student
            {
                id = 2,
                Name = "Alparslan",
                LastName = "Eroglu",
                StudentNo = "445"

            };

            PersonManager pm = new PersonManager();
            pm.Add(customer);
        }
    }
    interface IPerson  // Interface olduğu anlaşılsın diye başına 'I' yerleştirilir.. Burası Soyut bir nesnedir.Olayı aşağıda somutlaştırıyoruz.
    {
        // Temel(base) nesne oluşturup diğer nesnelere ondan implemente etmektir.
        //Soyut nesneler tek başlarına anlam ifade etmezler ve somut nesenelere ihtiyaç duyarlar.

        int id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }




    }

    class Customer : IPerson // Somut nesne haline getirdik.
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }

    class Student : IPerson
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string StudentNo { get; set; }

    }
    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name);

        }
    }
}
