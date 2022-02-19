using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus
{
    public class Työntekijä
    {
        public string Sukunimi { get; set; } = "";
        public string Etunimi { get; set; } = "";
        public string Tehtävä { get; set; } = "";
        public double Kuukausipalkka { get; set; }
        public double Ikälisä { get; set; }
        public double Veroprosentti { get; set; }

        public Työntekijä()
        {
        }
    }
}
