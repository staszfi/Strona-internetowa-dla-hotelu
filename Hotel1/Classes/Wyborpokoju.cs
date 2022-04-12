using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Classes
{
    class Wyborpokoju : Factory
    {
        public override IFactory GetPokoje(string Pokoje)
        {
            switch (Pokoje)
            {
                case "Malypokoj":
                    return new Malypokoj();
                case "Duzypokoj":
                    return new Duzypokoj();
                default:
                    throw new ApplicationException(string.Format("Pokoj nie moze zostac stworzony", Pokoje));
            }
        }
    }
}
