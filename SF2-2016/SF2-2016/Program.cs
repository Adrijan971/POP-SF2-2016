using SF2_2016.Model;
using System;
using SF2_2016.Funkcije;
using static System.Net.Mime.MediaTypeNames;

namespace SF2_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Salon();
            s1.Naziv = "Salon1";
            s1.Adresa = "Trg Dositeja Obradovica 33";
            s1.Id = 1;
            s1.BrojZiroRacuna = "840-000234234-83";
            s1.MaticniBroj = 23423423;
            s1.AdresaSajta = "http://wwww.sajt.com";
            s1.PIB = 234234234;
            s1.Telefon = "021/324-344";
            s1.Email = "email@gmail.com";

            Console.WriteLine("Dobrodosli u salon " + s1.Naziv);
            NesvrstaneFunkcije.PrikazMenija();

            var odgovor = Console.ReadLine();

            if (odgovor == "1")
            {
                Console.WriteLine("Prvi izbor");
                //PrikazNamestaja();
            }
            else if (odgovor == "2")
            {
                //UnosNamestaja();
            }
            else if (odgovor == "3")
            {
                //IzmenaNamestaja();
            }
            else if (odgovor == "4")
            {
                //BrisanjeNamestaja();
            }
            else if (odgovor == "5")
            {
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Greska , odaberite jednu od ponudjenih opcija");
                NesvrstaneFunkcije.PrikazMenija();
                Console.ReadLine();
            }
        }
    }
}
