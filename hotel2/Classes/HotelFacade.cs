using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel2.Classes
{

    class HotelFacade
    {
        DostepnoscPokoju dostepnosc;
        OfertaHotelu oferta;
        OpinieGosci opinie;

        public HotelFacade()
        {

            oferta = new OfertaHotelu();
            opinie = new OpinieGosci();
            dostepnosc = new DostepnoscPokoju();
         
        }

        public void WynajmijPokoj()
        {
            oferta.SetOferta();
            opinie.SetOpinie();
            dostepnosc.SetDostepnosc();
           

         
        }
    }
}