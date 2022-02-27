using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal class PalkanlaskijaHaeTyontekija
    {
        public void HaeTyontekija(List<Tyontekija> tyontekijatLista)
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
                        Console.WriteLine("\nValittu työntekijä: " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + "\n");
                        Console.WriteLine("Valitse seuraava toiminto:");
                        Console.WriteLine("[0] Lopetus");
                        Console.WriteLine("[1] Näytä tiedot");
                        Console.WriteLine("[2] Näytä viime kuukauden tunnit");
                        Console.WriteLine("[3] Näytä viime kuukauden palkan tiedot");
                        Console.WriteLine("[4] Laske palkka");
                        int toiminto4;
                        bool syotteenTarkistus;
                        int toimintojenMaara = 4;
                        bool poistu = false;
                        SyotteenTarkistus syotteenTarkistus1 = new SyotteenTarkistus();
                        syotteenTarkistus1.SyoteJaTarkistus(out syotteenTarkistus, out toiminto4, toimintojenMaara);

                        switch (toiminto4)
                        {
                            case 0:
                                poistu = true;
                                break;
                            case 1:
                                Console.WriteLine("Työntekijän " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " tiedot:\n");
                                Console.WriteLine(tyontekija.ToString()); // tulostus työntekijä-olion tiedoista
                                break;

                            case 2:
                                Console.WriteLine("Työntekijän " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " edellisen kuukauden tunnit:");
                                // tulostus työntekijä-olion tehdyistä tunneista (tiedostosta)
                                break;
                            case 3:
                                Console.WriteLine("Työntekijän " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " viimeisimmän palkan tiedot:");
                                // tulostus mistä työntekijän palkka koostuu (tiedostosta)
                                break;
                            case 4:
                                Console.WriteLine("Lasketaan työntekijän " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " viimeisin palkka:\n");
                                PalkkaLaskuri palkkalaskuri = new PalkkaLaskuri(tyontekija);
                                palkkalaskuri.LaskePalkka();
                                Console.WriteLine("\n");
                                break;
                        }

                        if (poistu)
                        {
                            Environment.Exit(0);
                        }

                    }
                }
            }
        }
    }
}
