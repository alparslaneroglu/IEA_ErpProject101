using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances // Miras
{
    class Program
    {
        static void Main(string[] args)
        {
            Players ply = new Players();
            Coach coach = new Coach();
            Person person = new Person();
            
            //Her bir class ayrı ayrı implemante edilebilir.
            //Her bir class sadece bir kere miras alabilir.
            //Interfaceler 1 den fazla olabilir ancak miras işlemi bir kere tanımlanır.
        }

    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }



    }

    class Players:Person  
    {
        public string Position { get; set; }

    }
    class Coach:Person
    {
        public string CoachPosition { get; set; }

    }

}
