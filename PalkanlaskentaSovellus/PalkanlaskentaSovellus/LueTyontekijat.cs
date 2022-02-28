// See https://aka.ms/new-console-template for more information

internal class LueTyontekijat
{
    public LueTyontekijat()
    {
    }

    // Lisätään kaikki työntekijät listaan.
    public void LueTyontekijatTiedostosta(List<Tyontekija> tyontekijatLista)
    {
        StreamReader reader = File.OpenText("../../../../../tyontekijat.txt");
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
            int Numero = Convert.ToInt32(jaaOsiin[6]);
            // Console.WriteLine(Sukunimi + Etunimi + Tehtävä + Kuukausipalkka + Ikälisä + Veroprosentti); // Testaus

            tyontekijatLista.Add(new Tyontekija(Sukunimi, Etunimi, Tehtävä, Kuukausipalkka, Ikälisä, Veroprosentti, Numero));
            line = reader.ReadLine();
        }
        reader.Close();
    }

    // Luetaan työntekijälistasta sukunimet.
    public void LuetteleKaikki(List<Tyontekija> tyontekijatLista)
    {
        for (int i = 0; i < tyontekijatLista.Count; i++)
        {
            Console.WriteLine(tyontekijatLista[i].Sukunimi + " " + tyontekijatLista[i].Etunimi);
        }
    }

    // Haetaan työntekijälistasta sukunimi.
    // Jos löytyy, niin palauttaa rivin mistä työntekijä löytyy (tekstitiedostosta) int arvolla, muuten palautus 0.
    public int HaeTyontekija(string hakusana, List<Tyontekija> tyontekijatLista)
    {
        int palautus = 0;
        for (int i = 0; i < tyontekijatLista.Count; i++)
        {
            if (tyontekijatLista[i].Sukunimi.Contains(hakusana))
            {
                palautus = i;
                break;
            }
        }
        return palautus;
    }
}