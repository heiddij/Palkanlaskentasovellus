using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal class HenkpaallikkoPoistaTyontekija
    {
        LueTyontekijat lueTyontekijat = new LueTyontekijat();
        public void PoistaTyontekija(List<Tyontekija> tyontekijatLista)
        {
            Console.Clear();
            Console.WriteLine("Työntekijän haku");
            Console.WriteLine("Syötä työntekijän tunnistenumero:");
            int tunniste = int.Parse(Console.ReadLine());
            int indeksi = tunniste - 1;

            Tyontekija tyontekija = lueTyontekijat.HaeTyontekija(indeksi, tyontekijatLista);

            if (tyontekija == null)

            {
                Console.WriteLine("Työntekijää ei löydy. Tarkista tunnistenumero työntekija-luettelosta.\n");
                return;
            }
            while (true)
            {
                Console.WriteLine("Löydetty työntekijä " + tyontekija.Etunimi + " " + tyontekija.Sukunimi);
                Console.WriteLine("Haluatko varmasti poistaa työntekijän tiedot?");
                Console.WriteLine("[0] Peruuta");
                Console.WriteLine("[1] Poista tiedot");
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
                        PoistaTyontekija poistatyontekija = new PoistaTyontekija();
                        poistatyontekija.Poista(indeksi, tyontekijatLista);
                        poistu = true;
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
