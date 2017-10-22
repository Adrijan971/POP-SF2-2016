using SF2_2016.Model;
using SF2_2016.TEST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Salon();
            s1.Naziv = "Salon1";

            Console.WriteLine("Dobrodosli u salon "+ s1.Naziv);
            Console.WriteLine("1. Izlistaj sav namesaj");
            Console.WriteLine("2. Unos novog namestaja");
            Console.WriteLine("3. Izlistaj sav namesaj");
            Console.WriteLine("4. Brisanje namestaja");
        }
    }
}
