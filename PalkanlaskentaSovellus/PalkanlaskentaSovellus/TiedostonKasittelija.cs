using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus
{
    internal class TiedostonKasittelija
    {
        string tiedostopolku = "../../../../../tyontekijat.txt";

        // Lisätään kaikki työntekijät listaan.
        public void LueTyontekijatTiedostosta(List<Tyontekija> tyontekijatLista)
        {
            StreamReader reader = File.OpenText(tiedostopolku);
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

                tyontekijatLista.Add(new Tyontekija(Sukunimi, Etunimi, Tehtävä, Kuukausipalkka, Ikälisä, Veroprosentti));
                line = reader.ReadLine();
            }
            reader.Close();
        }

        public void Talleta(List<Tyontekija> tyontekijatLista)
        {
            StreamWriter writer = File.CreateText(tiedostopolku);

            for (int i = 0; i < tyontekijatLista.Count; i++)
            {
                string rivi = $"{tyontekijatLista[i].Sukunimi};{tyontekijatLista[i].Etunimi};{tyontekijatLista[i].Tehtava};{tyontekijatLista[i].Kuukausipalkka};{tyontekijatLista[i].Ikalisa};{tyontekijatLista[i].Veroprosentti};";
                writer.WriteLine(rivi);
            }

            writer.Close();
        }
    }
}
