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

        // Työnantajan kulut palkasta
        public double TyonantajaTyEL { get; set; }
        public double TyonantajaTyotVakMaksu { get; set; }

        // Työntekijän kulut palkasta
        public double TyontekijaTyEL { get; set; }
        public double TyontekijaTyotVakMaksu { get; set; }


        public PalkkaLaskuri(Tyontekija tyontekija)
        {
            this.tyontekija = tyontekija;
            TyonantajaTyEL = 0.2585;
            TyonantajaTyotVakMaksu = 0.005;
            TyontekijaTyEL = 0.0715;
            TyontekijaTyotVakMaksu = 0.015;
        }

        public void LaskePalkka()
        {
            double lisat = tyontekija.Ikalisa/100 * tyontekija.Kuukausipalkka;
            double verot = tyontekija.Veroprosentti/100 * tyontekija.Kuukausipalkka;
            double kulut = (TyontekijaTyEL + TyontekijaTyotVakMaksu) * tyontekija.Kuukausipalkka;
            double nettopalkka = tyontekija.Kuukausipalkka + lisat - verot -kulut;

            Console.Clear();
            Console.WriteLine("Viime kuun maksettava palkka työntekijälle " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + ":\n");
            Console.WriteLine(string.Format("{0:0.00}", nettopalkka) + " euroa\n");
        }
    }
}
