using System;

namespace Hotel2A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilu osobowy ma być stolik Hotelowej restauracji:");
            int liczba_osob = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wybierz interesujące Cię miejsca:");
            Console.WriteLine("-> Zwykłe");
            Console.WriteLine("-> VIP");
            String stolik = Console.ReadLine();
            if (stolik == "Zwykłe")
            {
                Console.WriteLine("Wybrano zwykły stolik.");
                Console.ReadKey();
            }
            else if (stolik == "VIP")
            {
                Console.WriteLine("Wybrano stolik VIP.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nie ma takiego stoliku w ofercie Hotelu.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            Console.WriteLine(target.GetRequest(stolik, liczba_osob));
            Console.ReadKey();
        }
    }
}
