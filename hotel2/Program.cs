using hotel2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hotel2
{

    class Program
    {
        static void Main(string[] args)
        {
            HotelFacade facade = new HotelFacade();

            facade.WynajmijPokoj();
            Console.ReadKey();


        }
    }
}

 