using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel1S
{
        class Singleton
        {
            private static Singleton instancja = new Singleton();

            private int czas_wynajmu;
            private string wielkosc_pokoju, nazwisko_rezerwujacego;

            private Singleton() { }

            internal static Singleton Instancja
            {
                get => instancja;
                set => instancja = value;
            }

            public int Czas_wynajmu { get => czas_wynajmu; set => czas_wynajmu = value; }
            public string Wielkosc_pokoju { get => wielkosc_pokoju; set => wielkosc_pokoju = value; }
            public string Nazwisko_rezerwujacego { get => nazwisko_rezerwujacego; set => nazwisko_rezerwujacego = value; }
        }
    
}
