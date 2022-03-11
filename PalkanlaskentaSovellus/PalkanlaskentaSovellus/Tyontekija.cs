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

        public Tyontekija(string sukunimi, string etunimi, string tehtava, double kuukausipalkka, double ikalisa, double veroprosentti)
        {
            this.Sukunimi = sukunimi;
            this.Etunimi = etunimi;
            this.Tehtava = tehtava;
            this.Kuukausipalkka = kuukausipalkka;
            this.Ikalisa = ikalisa;
            this.Veroprosentti = veroprosentti;
        }

        public Tyontekija()
        {
        }

        public override string ToString()
        {
            return "Tehtävä:\t\t\t" + Tehtava + "\nKuukausipalkka:\t\t\t" + Kuukausipalkka + " euroa\nIkälisä:\t\t\t" + Ikalisa + "%\nVeroprosentti:\t\t\t" + Veroprosentti + "%";
        }
}
