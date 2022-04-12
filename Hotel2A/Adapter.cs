using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2A
{

    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest(String stolik, int liczba_osob)
        {
            return $"{this._adaptee.GetRequest()} Zarezerwowano stolik dla ilości osób: " + liczba_osob + ". Miejsca: " + stolik;
        }
    }
}
