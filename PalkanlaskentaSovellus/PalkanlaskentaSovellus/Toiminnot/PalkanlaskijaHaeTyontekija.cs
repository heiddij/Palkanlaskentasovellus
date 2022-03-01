using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal class PalkanlaskijaHaeTyontekija
    {
        LueTyontekijat lueTyontekijat = new LueTyontekijat();
        SyotteenTarkistus syotteenTarkistus1 = new SyotteenTarkistus();

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

                PalkkaLaskuri palkkalaskuri = new PalkkaLaskuri(tyontekija);
                int toiminto4;
                bool syotteenTarkistus;
                int toimintojenMaara = 4;
                bool poistu = false;
                syotteenTarkistus1.SyoteJaTarkistus(out syotteenTarkistus, out toiminto4, toimintojenMaara);

                switch (toiminto4)
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
                        palkkalaskuri.TyonantajaMaksut();
                        break;
                    case 3:
                        palkkalaskuri.PalkanTiedot();
                        break;
                    case 4:
                        Console.WriteLine("Lasketaan työntekijän " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " viimeisin palkka:\n");
                        palkkalaskuri.TulostaPalkka();
                        Console.WriteLine("\n");
                        break;
                }

                if (poistu)
                {
                    Environment.Exit(0);
                }
            }
        }

        private void TulostaToiminnot(Tyontekija tyontekija)
        {
            Console.WriteLine("Valittu työntekijä: " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + "\n");
            Console.WriteLine("Valitse seuraava toiminto:");
            Console.WriteLine("[0] Lopetus");
            Console.WriteLine("[1] Näytä työntekijän tiedot");
            Console.WriteLine("[2] Näytä viime kuukauden työnantajamaksut");
            Console.WriteLine("[3] Näytä viime kuukauden palkan tiedot");
            Console.WriteLine("[4] Laske palkka");
        }

    }
}
