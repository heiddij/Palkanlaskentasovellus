using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Työntekijä
{
        public string Sukunimi { get; set; } = "";
        public string Etunimi { get; set; } = "";
        public string Tehtävä { get; set; } = "";
        public double Kuukausipalkka { get; set; }
        public double Ikälisä { get; set; }
        public double Veroprosentti { get; set; }

        public Työntekijä(string Sukunimi, string Etunimi, string Tehtävä, double Kuukausipalkka, double Ikälisä, double Veroprosentti)
        {
            this.Sukunimi = Sukunimi;
            this.Etunimi = Etunimi;
            this.Tehtävä = Tehtävä;
            this.Kuukausipalkka = Kuukausipalkka;
            this.Ikälisä = Ikälisä;
            this.Veroprosentti = Veroprosentti;
        }

        public Työntekijä()
        {
        }
}
