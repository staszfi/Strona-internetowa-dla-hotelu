using Hotel.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Wyborpokoju();

            IFactory Malypokoj = factory.GetPokoje("Malypokoj");
            Malypokoj.Ilelozek(2);

            IFactory Duzypokoj = factory.GetPokoje("Duzypokoj");
            Duzypokoj.Ilelozek(5);
            Console.ReadKey();

        }
    }
}
