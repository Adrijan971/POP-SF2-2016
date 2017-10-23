using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2_2016.Model
{

    [Serializable]

    public class ProdajaNamestaja
    {
        public int Id { get; set; }
        List<Namestaj> NamestajZaProdaju { get; set; }
        public DateTime DatumProdaje { get; set; }
        public string Kupac { get; set; }
        List<DodatneUsluge> DodatneUsluge { get; set; }
        public const decimal PDV = 20; 
        public double UkupnaCena { get; set; }
        public string BrojRacuna { get; set; }

    }
}
