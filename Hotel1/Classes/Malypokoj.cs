using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Classes
{
    class Malypokoj : IFactory
    {
        public void Ilelozek(int ilosc)
        {
            Console.WriteLine("Ilosc lozek w pokoju : " + ilosc.ToString());
        }
    }
}
