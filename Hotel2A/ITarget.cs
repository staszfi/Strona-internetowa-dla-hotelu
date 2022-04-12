using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel2A
{

    public interface ITarget
    {
        string GetRequest(string stolik, int liczba_osob);
    }
}
