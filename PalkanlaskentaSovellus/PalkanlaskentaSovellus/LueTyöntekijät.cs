// See https://aka.ms/new-console-template for more information

internal class LueTyöntekijät
{
    public LueTyöntekijät()
    {
    }

    // Luetaan tiedostosta yksi rivi kerrallaan.
    public void LuetteleKaikki()
    {
        // Luettava tiedosto on 5 kansiota taaksepäin .exe -tiedoston kansiosta.
        StreamReader reader = File.OpenText("../../../../../työntekijät.txt");
        string line = reader.ReadLine();
        while (line != null)
        {
            // Muodostetaan nimi luomalla lista ja jakamalla luettu rivi kolmeen osaan listassa ; -merkin avulla.
            // Indeksi 0=sukunimi, 1=etunimi, 2=muu tieto mistä ei tässä välitetä.
            string[] jaaOsiin = line.Split(";", 3);
            Console.WriteLine(jaaOsiin[0] + " " + jaaOsiin[1]);

            line = reader.ReadLine();
        }
        reader.Close();
    }

    // Haetaan työntekijälistasta sukunimi.
    // Jos löytyy, niin palauttaa rivin mistä työntekijä löytyy int arvolla. Muuten palautus 0.
    public int HaeTyontekija(string hakusana)
    {
        int palautus = 0;
        int rivinLaskija = 1;
        if (hakusana.All(Char.IsLetter) == true) // Tarkistetaan että haetaan vain kirjaimilla.
        {
            StreamReader reader = File.OpenText("../../../../työntekijät.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                if (line.Contains(hakusana))
                {
                    palautus = rivinLaskija;
                    break;
                }
                line = reader.ReadLine();
                rivinLaskija++;
            }
            reader.Close();
        }
        return palautus;
    }
}