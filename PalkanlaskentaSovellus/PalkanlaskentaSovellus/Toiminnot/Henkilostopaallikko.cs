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
        LueTyöntekijät lueTyontekijat = new LueTyöntekijät();

        public Henkilostopaallikko(List<Työntekijä> tyontekijaLista)
        {
            this.tyontekijaLista = tyontekijaLista;
        }

        public void Suorita()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Henkilöstöpäällikkö, valitse toiminto:"); 
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
                        Console.WriteLine("Lista työntekijöistä:");
                        lueTyontekijat.LuetteleKaikki();
                        break;
                    case 2:
                        Console.WriteLine("Työntekijän lisäys");
                        // lisäys-toiminto tähän
                        break;
                    case 3:
                        Console.WriteLine("Työntekijän poisto");
                        // poisto-toiminto tähän
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
