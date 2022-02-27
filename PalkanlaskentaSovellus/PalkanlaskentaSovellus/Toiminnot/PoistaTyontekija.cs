using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal class PoistaTyontekija
    {
        public void Poista(Tyontekija tyontekija)
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Työntekijän " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " tietojen poisto:");
                Console.WriteLine("Muista, tiedot poistuvat pysyvästi!\n");
                Console.WriteLine("[0] Takaisin");
                Console.WriteLine("[1] Poista työntekijä");
                int toiminto2;
                bool syotteenTarkistus;
                int toimintojenMaara = 1;
                bool poistu = false;
                SyotteenTarkistus syotteenTarkistus1 = new SyotteenTarkistus();
                syotteenTarkistus1.SyoteJaTarkistus(out syotteenTarkistus, out toiminto2, toimintojenMaara);

                switch (toiminto2)
                {
                    case 0:
                        poistu = true;
                        break;
                    case 1:
                        Console.WriteLine("Työntekijä" + tyontekija.Sukunimi + "poistettu!");
                        //tähän itse poisto koodi, jos saisi poistettua koko rivin!!
                                                
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