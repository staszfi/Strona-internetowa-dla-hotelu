using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel1S
{
    internal class main
    {
        static void Main(string[] args)
        {

            Singleton singleton = Singleton.Instancja;
            singleton.Wielkosc_pokoju = "Duzy";
            singleton.Nazwisko_rezerwujacego = "Nowak";
            singleton.Czas_wynajmu = 5;
            Console.WriteLine("Pokoj " + singleton.Wielkosc_pokoju + " zarezerwowal/a Pan/Pani: " + singleton.Nazwisko_rezerwujacego + " czas wynajmu: " + singleton.Czas_wynajmu);
            Console.ReadKey();
        }
    }
}
