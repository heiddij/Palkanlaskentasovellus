using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal class Palkanlaskija
    {

        public void Suorita()
        {
            Console.Clear();
            var lueTyontekijat = new LueTyöntekijät();
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
                Console.WriteLine("Palkanlaskija, valitse toiminto:");
                Console.WriteLine("[0] Lopetus");
                Console.WriteLine("[1] Lista työntekijöistä");
                Console.WriteLine("[2] Hae työntekijä");

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
                        lueTyontekijat.LuetteleKaikki();
                        break;
                    case 2:
                        PalkanlaskijaHaeTyontekija palkanlaskijaHae = new PalkanlaskijaHaeTyontekija();
                        palkanlaskijaHae.HaeTyontekija(tyontekijatLista);
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
