using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Tyontekija
{
        public string Sukunimi { get; set; } = "";
        public string Etunimi { get; set; } = "";
        public string Tehtava { get; set; } = "";
        public double Kuukausipalkka { get; set; }
        public double Ikalisa { get; set; }
        public double Veroprosentti { get; set; }

        public Tyontekija(string Sukunimi, string Etunimi, string Tehtava, double Kuukausipalkka, double Ikalisa, double Veroprosentti)
        {
            this.Sukunimi = Sukunimi;
            this.Etunimi = Etunimi;
            this.Tehtava = Tehtava;
            this.Kuukausipalkka = Kuukausipalkka;
            this.Ikalisa = Ikalisa;
            this.Veroprosentti = Veroprosentti;
        }

        public Tyontekija()
        {
        }

        public override string ToString()
        {
            return "Tehtävä: " + Tehtava + "; Kuukausipalkka: " + Kuukausipalkka + "; Ikälisä: " + Ikalisa + "; Veroprosentti: " + Veroprosentti;
        }
}
