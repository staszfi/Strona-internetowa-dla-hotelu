using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Classes
{
    class Duzypokoj : IFactory
    {
        public void Ilelozek(int ilosc)
        {
            Console.WriteLine("Ilosc lozek w pokoju : " + ilosc.ToString());
        }
    }
}
