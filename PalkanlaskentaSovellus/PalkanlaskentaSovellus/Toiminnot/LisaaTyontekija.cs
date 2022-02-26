using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal class LisaaTyontekija
    {
        public void LisaaTyontekija(Tyontekija tyontekija)
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Työntekijän " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " tietojen lisäys:");
                Console.WriteLine("[0] Takaisin");
                Console.WriteLine("[1] Lisää työntekijä");
                int toiminto2;
                bool syotteenTarkistus;
                int toimintojenMaara = 1;
                bool poistu = false;
                SyotteenTarkistus syotteenTarkistus1 = new SyotteenTarkistus();
                syotteenTarkistus1.SyoteJaTarkistus(out syotteenTarkistus, out toiminto5, toimintojenMaara);

                switch (toiminto2)
                {
                    case 0:
                        poistu = true;
                        break;
                    case 1:
                        Console.WriteLine("Työntekijä" + tyontekija.Sukunimi + "poistettu!");
                        //tähän itse lisäys koodi!!
                        //var tyonimike = Console.ReadLine();
                        //tyontekija.Tehtävä = tyonimike;

                        break;
                }
                if (poistu)
                {
                    break;
                }
            }
        }
    }
}