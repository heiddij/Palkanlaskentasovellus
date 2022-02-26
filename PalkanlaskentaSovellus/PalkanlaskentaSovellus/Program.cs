using PalkanlaskentaSovellus;
using PalkanlaskentaSovellus.Toiminnot;

class MainClass
{
    public static void Main(string[] args)
    {
        LueTyontekijat lueTyontekijat = new LueTyontekijat();
        bool syotteenTarkistus; // onko syöte int vai joku muu
        int rooli;
        int toimintojenMaara = 2;
        List<Tyontekija> tyontekijatLista = new List<Tyontekija>(); // Käytetään alla.

        // Alla oleva voisi olla omassa metodissaan. En saanut sitä toimimaan, joten se on nyt tässä. Saa korjata!
        StreamReader reader = File.OpenText("../../../../../tyontekijat.txt");
        string line = reader.ReadLine();
        while (line != null)
        {
            string[] jaaOsiin = line.Split(";");
            string Sukunimi = jaaOsiin[0];
            string Etunimi = jaaOsiin[1];
            string Tehtava = jaaOsiin[2];
            double Kuukausipalkka = Convert.ToDouble(jaaOsiin[3]);
            double Ikalisa = Convert.ToDouble(jaaOsiin[4]);
            double Veroprosentti = Convert.ToDouble(jaaOsiin[5]);
            // Console.WriteLine(Sukunimi + Etunimi + Tehtava + Kuukausipalkka + Ikalisa + Veroprosentti); // Testaus

            tyontekijatLista.Add(new Tyontekija(Sukunimi, Etunimi, Tehtava, Kuukausipalkka, Ikalisa, Veroprosentti));
            line = reader.ReadLine();
        }
        reader.Close();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Tervetuloa Palkanlasku-sovellukseen. Valitse rooli (0 lopettaa):\n");
            Console.WriteLine("[0] Lopetus");
            Console.WriteLine("[1] Henkilöstöpäällikkö");
            Console.WriteLine("[2] Palkanlaskija");

            bool poistu = false;

            SyotteenTarkistus syotteenTarkistus1 = new SyotteenTarkistus();
            syotteenTarkistus1.SyoteJaTarkistus(out syotteenTarkistus, out rooli, toimintojenMaara);

            switch (rooli)
            {
                case 0:
                    poistu = true;
                    break;
                case 1:
                    Henkilostopaallikko henkilostopaallikko = new Henkilostopaallikko(tyontekijatLista);
                    henkilostopaallikko.Suorita();
                    break;
                case 2:
                    Palkanlaskija palkanlaskija = new Palkanlaskija(tyontekijatLista);
                    palkanlaskija.Suorita();
                    break;
            }
            if (poistu)
            {
                Environment.Exit(0);
            }
        }

        
    }
}
