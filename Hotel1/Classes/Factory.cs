using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Classes
{
    abstract class Factory
    {
        public abstract IFactory GetPokoje(string Pokoje);
    }
}
