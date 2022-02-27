﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal class HenkpaallikkoPoistaTyontekija
    {
        public void PoistaTyontekija(List<Tyontekija> tyontekijatLista)
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
                        Tyontekija tyontekija = tyontekijatLista[i];
                        Console.WriteLine("Valittu työntekijä: " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + "\n");
                        Console.WriteLine("Valitse seuraava toiminto:");
                        Console.WriteLine("[0] Lopetus");
                        Console.WriteLine("[1] Näytä tiedot");
                        Console.WriteLine("[2] Poista tiedot");
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
                                Console.WriteLine("Työntekijän " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " tiedot:\n");
                                Console.WriteLine(tyontekija.ToString()); // tulostus työntekijä-olion tiedoista
                                Console.WriteLine("\n");
                                break;

                            case 2:
                                PoistaTyontekija poistaTyontekija = new PoistaTyontekija();
                                poistaTyontekija.PoistaTietoja(tyontekija);
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