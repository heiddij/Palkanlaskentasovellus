using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal class HenkpaallikkoHaeTyontekija 
    {
        LueTyontekijat lueTyontekijat = new LueTyontekijat();
        public void HaeTyontekija(List<Tyontekija> tyontekijatLista)
        {
            Console.Clear();
            Console.WriteLine("Työntekijän haku");
            Console.WriteLine("Syötä työntekijän tunnistenumero:");
            int tunniste = int.Parse(Console.ReadLine());
            int indeksi = tunniste - 1;

            while (true)
            {
                Tyontekija tyontekija = lueTyontekijat.HaeTyontekija(indeksi, tyontekijatLista);

                if (tyontekija == null)
                {
                    Console.WriteLine("Työntekijää ei löydy. Tarkista tunnistenumero työntekija-luettelosta.\n");
                    return;
                }

                TulostaToiminnot(tyontekija);

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
                        TietojenMuokkaus tietojenMuokkaus = new TietojenMuokkaus(tyontekijatLista);
                        tietojenMuokkaus.MuokkaaTietoja(tyontekija);
                        break;
                }
                if (poistu)
                {
                    Environment.Exit(0); // Lopettaa koko ohjelman
                }


            }
        }

        private static void TulostaToiminnot(Tyontekija tyontekija)
        {
            Console.WriteLine("Valittu työntekijä: " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + "\n");
            Console.WriteLine("Valitse seuraava toiminto:");
            Console.WriteLine("[0] Lopetus");
            Console.WriteLine("[1] Näytä tiedot");
            Console.WriteLine("[2] Muokkaa tietoja");
        }
    }
}
