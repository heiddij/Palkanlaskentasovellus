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

    // Haetaan työntekijä listalta, jos ei löydy niin palautetaan null

    public Tyontekija? HaeTyontekija(int tunniste, List<Tyontekija> tyontekijatLista)
    {
        for (int i = 0; i < tyontekijatLista.Count; i++)
        {
            if (i == tunniste)
            {
                Tyontekija tyontekija = tyontekijatLista[i];
                return tyontekija;
            }

        } 
        return null;
    }
}