// See https://aka.ms/new-console-template for more information

// Ohjelman pääluokka, ns. pääohjelma, josta kaikki toiminnallisuus alkaa

using PalkanlaskentaSovellus.Toiminnot;

class MainClass
{
    // Main metodia kutsutaan kun ohjelma käynnistyy. Tämä on ensimmäinen metodi mitä ohjelma kutsuu ja mistä
    // kaikki alkaa. 
    //
    // "string[] args" tarkoittaa parametreja, jos niitä on annettu ohjelman alkaessa esim. komentokehotteesta
    public static void Main(string[] args)
    {
        var lueTyontekijat = new LueTyöntekijät();
        bool syotteenTarkistus; // onko syöte int vai joku muu
        int rooli;
        int toimintojenMaara = 2;
        List<string> tyontekijat = new List<string>(); // TESTAUKSEEN -- tähän lista työntekijä-olioista
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

        Console.WriteLine("Tervetuloa Palkanlasku-sovellukseen. Valitse rooli:");
        Console.WriteLine("[1] Henkilöstöpäällikkö");
        Console.WriteLine("[2] Palkanlaskija");

        // TESTAUKSEEN:
        tyontekijat.Add("Minna Jokinen");
        tyontekijat.Add("Matti Mäkinen");

        // Metodi sisältää syötteen ja sen tarkistuksen
        SyoteJaTarkistus(out syotteenTarkistus, out rooli, toimintojenMaara);

        if (rooli == 1)
        {
            MenuToiminto toiminto01 = new EnsimmainenToiminto();
            toiminto01.Suorita();
            HenkilostopaallikonToiminnot(lueTyontekijat, tyontekijatLista);
        }

        if (rooli == 2)
        {
            PalkanLaskijanToiminnot(lueTyontekijat, tyontekijatLista);
        }
    }

    private static void PalkanLaskijanToiminnot(LueTyöntekijät lueTyontekijat, List<Työntekijä> tyontekijatLista)
    {
        Console.WriteLine("Palkanlaskija, valitse toiminto:");
        Console.WriteLine("[1] Lista työntekijöistä");
        Console.WriteLine("[2] Hae työntekijä");

        int toiminto2;
        bool syotteenTarkistus;
        int toimintojenMaara = 2;
        SyoteJaTarkistus(out syotteenTarkistus, out toiminto2, toimintojenMaara);

        switch (toiminto2)
        {
            case 1:
                lueTyontekijat.LuetteleKaikki();
                break;
            case 2:
                HaeTyontekijaPalkanlaskuaVarten(tyontekijatLista);
                break;
        }
    }

    private static void HaeTyontekijaPalkanlaskuaVarten(List<Työntekijä> tyontekijatLista)
    {
        Console.WriteLine("Työntekijän haku");
        Console.WriteLine("Syötä työntekijän sukunimi:");
        var sukunimi = Console.ReadLine();
        
        for (int i = 0; i < tyontekijatLista.Count; i++)
        {
            //if (!tyontekijatLista[i].Sukunimi.Contains(sukunimi))
            //{
            //    Console.WriteLine("Työntekijää ei löydy. Syötä sukunimi uudestaan:");
            //    sukunimi = Console.ReadLine();
            //}
            if (sukunimi == tyontekijatLista[i].Sukunimi)
            {
                Työntekijä tyontekija = tyontekijatLista[i];
                Console.WriteLine("Löydetty työntekijä: " + tyontekija.Etunimi + " " + tyontekija.Sukunimi);
                Console.WriteLine("Valitse seuraava toiminto:");
                Console.WriteLine("[1] Näytä tiedot");
                Console.WriteLine("[2] Näytä viime kuukauden tunnit");
                Console.WriteLine("[3] Näytä viime kuukauden palkan tiedot");
                Console.WriteLine("[4] Laske palkka");
                int toiminto4;
                bool syotteenTarkistus;
                int toimintojenMaara = 4;
                SyoteJaTarkistus(out syotteenTarkistus, out toiminto4, toimintojenMaara);

                switch (toiminto4)
                {
                    case 1:
                        Console.WriteLine("Työntekijän " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " tiedot:");
                        Console.WriteLine(tyontekija.ToString()); // tulostus työntekijä-olion tiedoista
                        break;

                    case 2:
                        Console.WriteLine("Työntekijän " + tyontekija + " edellisen kuukauden tunnit:");
                        // tulostus työntekijä-olion tehdyistä tunneista (tiedostosta)
                        break;
                    case 3:
                        Console.WriteLine("Työntekijän " + tyontekija + " viimeisimmän palkan tiedot:");
                        // tulostus mistä työntekijän palkka koostuu (tiedostosta)
                        break;
                    case 4:
                        Console.WriteLine("Lasketaan työntekijän " + tyontekija + " viimeisin palkka:");
                        // Kutsutaan laske palkka -metodia palkanlasku-luokasta?
                        break;
                }
            }
        }
    }

    private static void HenkilostopaallikonToiminnot(LueTyöntekijät lueTyontekijat, List<Työntekijä> tyontekijatLista)
    {
        Console.WriteLine("Henkilöstöpäällikkö, valitse toiminto:");
        Console.WriteLine("[1] Lista työntekijöistä");
        Console.WriteLine("[2] Lisää työntekijä");
        Console.WriteLine("[3] Poista työntekijä");
        Console.WriteLine("[4] Hae työntekijä");
        int toiminto1;
        bool syotteenTarkistus;
        int toimintojenMaara = 4;
        SyoteJaTarkistus(out syotteenTarkistus, out toiminto1, toimintojenMaara);

        switch (toiminto1)
        {
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
                HaeTyontekija(tyontekijatLista);
                break;

        }
    }

    private static void HaeTyontekija(List<Työntekijä> tyontekijatLista)
    {
        Console.WriteLine("Työntekijän haku");
        Console.WriteLine("Syötä työntekijän sukunimi:");
        var sukunimi = Console.ReadLine();

        for (int i = 0; i < tyontekijatLista.Count; i++)
        {
            //if (!tyontekijatLista[i].Sukunimi.Contains(sukunimi))
            //{
            //    Console.WriteLine("Työntekijää ei löydy. Syötä sukunimi uudestaan:");
            //    sukunimi = Console.ReadLine();
            //}
            if (sukunimi == tyontekijatLista[i].Sukunimi)
            {
                Työntekijä tyontekija = tyontekijatLista[i];
                Console.WriteLine("Löydetty työntekijä: " + tyontekija.Etunimi + " " + tyontekija.Sukunimi);
                Console.WriteLine("Valitse seuraava toiminto:");
                Console.WriteLine("[1] Näytä tiedot");
                Console.WriteLine("[2] Muokkaa tietoja");
                int toiminto3;
                bool syotteenTarkistus;
                int toimintojenMaara = 2;
                SyoteJaTarkistus(out syotteenTarkistus, out toiminto3, toimintojenMaara);

                switch (toiminto3)
                {
                    case 1:
                        Console.WriteLine("Työntekijän " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " tiedot:");
                        Console.WriteLine(tyontekija.ToString()); // tulostus työntekijä-olion tiedoista
                        break;

                    case 2:
                        TietojenMuokkaus(tyontekija);
                        break;
                }
            }
        }
    }

    private static void TietojenMuokkaus(Työntekijä tyontekija)
    {
        Console.WriteLine("Työntekijän " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " tietojen muokkaus:");
        Console.WriteLine("Valitse, mitä tietoja haluat muokata:");
        Console.WriteLine("[1] Muuta työnimike");
        Console.WriteLine("[2] Muuta peruspalkkan määrä");
        Console.WriteLine("[3] Muuta ikälisäprosenttia");
        Console.WriteLine("[4] Muuta veroprosenttia");
        int toiminto5;
        bool syotteenTarkistus;
        int toimintojenMaara = 4;
        SyoteJaTarkistus(out syotteenTarkistus, out toiminto5, toimintojenMaara);

        switch (toiminto5)
        {
            case 1:
                Console.WriteLine("Syötä uusi työnimike:");
                var tyonimike = Console.ReadLine();
                tyontekija.Tehtävä = tyonimike;
                Console.WriteLine("Henkilön " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " uusi työnimike on: " + tyontekija.Tehtävä);
                break;
            case 2:
                Console.WriteLine("Syötä uusi peruspalkka:");
                var peruspalkka = double.Parse(Console.ReadLine());
                tyontekija.Kuukausipalkka = peruspalkka;
                Console.WriteLine("Henkilön " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " uusi kuukausipalkka on: " + tyontekija.Kuukausipalkka);
                break;
            case 3:
                Console.WriteLine("Syötä uusi ikälisäprosentti:");
                var ikalisa = double.Parse(Console.ReadLine());
                tyontekija.Ikälisä = ikalisa;
                Console.WriteLine("Henkilön " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " uusi ikälisäprosentti on: " + tyontekija.Ikälisä);
                break;
            case 4:
                Console.WriteLine("Syötä uusi veroprosentti:");
                var veroprosentti = double.Parse(Console.ReadLine());
                tyontekija.Veroprosentti = veroprosentti;
                Console.WriteLine("Henkilön " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " uusi veroprosentti on: " + tyontekija.Veroprosentti);
                break;
        }
    }

    private static void SyoteJaTarkistus(out bool syotteenTarkistus, out int oikeaSyote, int toimintojenMaara)
    {
        do
        {
            var syote = Console.ReadLine();
            syotteenTarkistus = int.TryParse(syote, out oikeaSyote);

            if (!syotteenTarkistus || oikeaSyote > toimintojenMaara)
            {
                Console.WriteLine("Väärä syöte! Valitse numero annetuista vaihtoehdoista");
            }
        }
        while (!syotteenTarkistus || oikeaSyote > toimintojenMaara);
    }
}
