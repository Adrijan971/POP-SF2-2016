using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2_2016.Model
{
    public class Namestaj
    {
        public int Id { get; set; }
        public int Naziv { get; set; }
        public string Sifra { get; set; }
        public double cena { get; set; }
        public int KolicinaUmagacinu { get; set; }
        public bool Obrisan { get; set; }
        public TipNamestaja TipNamestaja { get; set; }


    }
}
