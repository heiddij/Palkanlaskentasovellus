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
}