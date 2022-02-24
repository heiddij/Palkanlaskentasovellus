using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal class Henkilostopaallikko
    {

        public void Suorita()
        {
            Console.Clear();
            LueTyöntekijät lueTyontekijat = new LueTyöntekijät();
            List<Työntekijä> tyontekijatLista = new List<Työntekijä>(); // Käytetään alla.

            // Alla oleva voisi olla omassa metodissaan. En saanut sitä toimimaan, joten se on nyt tässä. Saa korjata!
            StreamReader reader = File.OpenText("../../../../../työntekijät.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] jaaOsiin = line.Split(";");
                string Sukunimi = jaaOsiin[0];
                string Etunimi = jaaOsiin[1];
                string Tehtävä = jaaOsiin[2];
                double Kuukausipalkka = Convert.ToDouble(jaaOsiin[3]);
                double Ikälisä = Convert.ToDouble(jaaOsiin[4]);
                double Veroprosentti = Convert.ToDouble(jaaOsiin[5]);
                // Console.WriteLine(Sukunimi + Etunimi + Tehtävä + Kuukausipalkka + Ikälisä + Veroprosentti); // Testaus

                tyontekijatLista.Add(new Työntekijä(Sukunimi, Etunimi, Tehtävä, Kuukausipalkka, Ikälisä, Veroprosentti));
                line = reader.ReadLine();
            }
            reader.Close();

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
                        paallikkoHae.HaeTyontekija(tyontekijatLista);
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
