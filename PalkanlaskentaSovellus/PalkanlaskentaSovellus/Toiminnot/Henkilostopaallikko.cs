using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal class Henkilostopaallikko
    {
        private List<Työntekijä> tyontekijaLista;
        LueTyöntekijät lueTyontekijat = new LueTyontekijat();

        public Henkilostopaallikko(List<Tyontekija> tyontekijaLista)
        {
            this.tyontekijaLista = tyontekijaLista;
        }

        public void Suorita()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Henkilöstöpäällikkö, valitse toiminto:\n"); 
                Console.WriteLine("[0] Lopetus");
                Console.WriteLine("[1] Lista työntekijöistä");
                Console.WriteLine("[2] Lisää työntekijä");
                Console.WriteLine("[3] Poista työntekijä");
                Console.WriteLine("[4] Hae työntekijä");
                int toiminto1;
                bool syotteenTarkistus;
                int toimintojenMaara = 5;
                bool poistu = false;
                SyotteenTarkistus syotteenTarkistus1 = new SyotteenTarkistus();
                syotteenTarkistus1.SyoteJaTarkistus(out syotteenTarkistus, out toiminto1, toimintojenMaara);

                switch (toiminto1)
                {
                    case 0:
                        poistu = true;
                        break;
                    case 1:
                        Console.WriteLine("Lista työntekijöistä:\n");
                        lueTyontekijat.LuetteleKaikki();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        // lisäys-toiminto
                        HenkpaallikkoLisaaTyontekija paallikkoLisaa = new HenkpaallikkoLisaaTyontekija();
                        paallikkoLisaa.LisaaTyontekija(tyontekijaLista);
                        break;
                    case 3:
                        // poisto-toiminto
                        HenkpaallikkoPoistaTyontekija paallikkoPoista = new HenkpaallikkoPoistaTyontekija();
                        paallikkoPoista.PoistaTyontekija(tyontekijaLista);
                        break;
                    case 4:
                        HenkpaallikkoHaeTyontekija paallikkoHae = new HenkpaallikkoHaeTyontekija();
                        paallikkoHae.HaeTyontekija(tyontekijaLista);
                        break;
                }
                if (poistu)
                {
                    break; // Menee takaisin alkuun
                }
            }
        }
    }
}
