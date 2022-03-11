using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal class Palkanlaskija
    {
        private List<Tyontekija> tyontekijaLista;
        LueTyontekijat lueTyontekijat = new LueTyontekijat();

        public Palkanlaskija(List<Tyontekija> tyontekijaLista)
        {
            this.tyontekijaLista = tyontekijaLista;
        }

        public void Suorita()
        {
            Console.Clear();
            var lueTyontekijat = new LueTyontekijat();

            while (true)
            {
                TulostaToiminnot();

                int toiminto2;
                bool syotteenTarkistus;
                int toimintojenMaara = 3;
                SyotteenTarkistus syotteenTarkistus1 = new SyotteenTarkistus();
                syotteenTarkistus1.SyoteJaTarkistus(out syotteenTarkistus, out toiminto2, toimintojenMaara);
                bool poistu = false;
                switch (toiminto2)
                {
                    case 0:
                        poistu = true;
                        break;
                    case 1:
                        Console.WriteLine("Lista työntekijöistä:\n");
                        lueTyontekijat.LuetteleKaikki(tyontekijaLista);
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        PalkanlaskijaHaeTyontekija palkanlaskijaHae = new PalkanlaskijaHaeTyontekija();
                        palkanlaskijaHae.HaeTyontekija(tyontekijaLista);
                        break;
                }

                if (poistu)
                {
                    break;
                }
            }
        }

        private static void TulostaToiminnot()
        {
            Console.WriteLine("Palkanlaskija, valitse toiminto:");
            Console.WriteLine("[0] Lopetus");
            Console.WriteLine("[1] Lista työntekijöistä");
            Console.WriteLine("[2] Hae työntekijä");
        }
    }
}
