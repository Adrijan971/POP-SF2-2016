﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2_2016.Model
{
    public class DodatneUsluge
    {
        public int Id { get; set; }
        public  string Naziv { get; set; }
        public double Cena { get; set; }
        public bool Obrisan { get; set; }

    }
}