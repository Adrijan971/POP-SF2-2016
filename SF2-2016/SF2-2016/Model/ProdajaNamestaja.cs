using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2_2016.Model
{
    public class ProdajaNamestaja
    {
        public int Id { get; set; }
        List<Namestaj> NamestajZaProdaju { get; set; }
        public DateTime DatumProdaje { get; set; }
        public string sifra { get; set; }
        List<DodatneUsluge> DodatneUsluge { get; set; }
        public double PDV{ get; set; }
        public double UkupnaCena { get; set; }


    }
}
