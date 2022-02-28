// See https://aka.ms/new-console-template for more information

internal class LueTyontekijat
{
    public LueTyontekijat()
    {
    }

    // Luetaan työntekijälistasta sukunimet.
    public void LuetteleKaikki(List<Tyontekija> tyontekijatLista)
    {
        for (int i = 0; i < tyontekijatLista.Count; i++)
        {
            int tunniste = i + 1;
            Console.WriteLine(tunniste + " " + tyontekijatLista[i].Sukunimi + " " + tyontekijatLista[i].Etunimi);
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