using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal class HenkpaallikkoHaeTyontekija 
    {
        public void HaeTyontekija(List<Työntekijä> tyontekijatLista)
        {
            Console.Clear();
            Console.WriteLine("Työntekijän haku");
            Console.WriteLine("Syötä työntekijän sukunimi:");
            var sukunimi = Console.ReadLine();

            for (int i = 0; i < tyontekijatLista.Count; i++)
            {
                if (sukunimi == tyontekijatLista[i].Sukunimi)
                {
                    while (true)
                    {
                        Työntekijä tyontekija = tyontekijatLista[i];
                        Console.WriteLine("Valittu työntekijä: " + tyontekija.Etunimi + " " + tyontekija.Sukunimi);
                        Console.WriteLine("Valitse seuraava toiminto:");
                        Console.WriteLine("[0] Lopetus");
                        Console.WriteLine("[1] Näytä tiedot");
                        Console.WriteLine("[2] Muokkaa tietoja");
                        int toiminto3;
                        bool syotteenTarkistus;
                        int toimintojenMaara = 2;
                        bool poistu = false;
                        SyotteenTarkistus syotteenTarkistus1 = new SyotteenTarkistus();
                        syotteenTarkistus1.SyoteJaTarkistus(out syotteenTarkistus, out toiminto3, toimintojenMaara);

                        switch (toiminto3)
                        {
                            case 0:
                                poistu = true;
                                break;
                            case 1:
                                Console.WriteLine("Työntekijän " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " tiedot:");
                                Console.WriteLine(tyontekija.ToString()); // tulostus työntekijä-olion tiedoista
                                break;

                            case 2:
                                TietojenMuokkaus tietojenMuokkaus = new TietojenMuokkaus();
                                tietojenMuokkaus.MuokkaaTietoja(tyontekija);
                                break;
                        }
                        if (poistu)
                        {
                            Environment.Exit(0); // Lopettaa koko ohjelman
                        }
                    }
                }
            }
        }
    }
}
