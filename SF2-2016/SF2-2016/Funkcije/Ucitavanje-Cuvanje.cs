using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SF2_2016.Funkcije
{
    class Ucitavanje_Cuvanje
    {
        public void UcitavanjeIzFajla(tip,lista) {

            XmlSerializer serializer = new XmlSerializer(typeof());
            TextWriter writer = new StreamWriter(lokacija);
            serializer.Serialize(writer, ime_liste);
            writer.Close();
        }

    }
}
