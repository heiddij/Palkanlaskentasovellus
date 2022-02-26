using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus
{
    internal class PalkkaLaskuri
    {
        private Tyontekija tyontekija;

        public PalkkaLaskuri(Tyontekija tyontekija)
        {
            this.tyontekija = tyontekija;
        }

        public void LaskePalkka()
        {
            double palkkaLisineen = (1 + tyontekija.Ikalisa/100) * tyontekija.Kuukausipalkka;
            double palkkaVeroineen = (1 - tyontekija.Veroprosentti / 100) * palkkaLisineen;

            Console.WriteLine("Viime kuun palkka työntekijälle " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + ":\n");
            Console.WriteLine(string.Format("{0:0.00}", palkkaVeroineen) + " euroa");
        }
    }
}
