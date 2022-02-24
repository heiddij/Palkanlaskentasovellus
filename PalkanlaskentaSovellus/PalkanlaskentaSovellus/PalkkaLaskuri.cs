using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus
{
    internal class PalkkaLaskuri
    {
        private Työntekijä tyontekija;

        public PalkkaLaskuri(Työntekijä tyontekija)
        {
            this.tyontekija = tyontekija;
        }

        public void LaskePalkka()
        {
            double palkkaLisineen = (1 + tyontekija.Ikälisä/100) * tyontekija.Kuukausipalkka;
            double palkkaVeroineen = (1 - tyontekija.Veroprosentti / 100) * palkkaLisineen;

            Console.WriteLine("Viime kuun palkka työntekijälle " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + ":\n");
            Console.WriteLine(string.Format("{0:0.00}", palkkaVeroineen) + " euroa");
        }
    }
}
