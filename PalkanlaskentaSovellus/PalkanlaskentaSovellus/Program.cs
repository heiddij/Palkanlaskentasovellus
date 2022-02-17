// See https://aka.ms/new-console-template for more information

// Ohjelman pääluokka, ns. pääohjelma, josta kaikki toiminnallisuus alkaa

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
            HenkilostopaallikonToiminnot(lueTyontekijat, tyontekijat);
        }

        if (rooli == 2)
        {
            PalkanLaskijanToiminnot(lueTyontekijat, tyontekijat);
        }
    }

    private static void PalkanLaskijanToiminnot(LueTyöntekijät lueTyontekijat, List<string> tyontekijat)
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
                HaeTyontekijaPalkanlaskuaVarten(tyontekijat);
                break;
        }
    }

    private static void HaeTyontekijaPalkanlaskuaVarten(List<string> tyontekijat)
    {
        Console.WriteLine("Työntekijän haku");
        Console.WriteLine("Syötä työntekijän sukunimi:");
        var sukunimi = Console.ReadLine();

        for (int i = 0; i < tyontekijat.Count; i++)
        {
            if (!tyontekijat.Contains(sukunimi))
            {
                Console.WriteLine("Työntekijää ei löydy. Syötä sukunimi uudestaan:");
                sukunimi = Console.ReadLine();
            }
            if (sukunimi == tyontekijat[i])
            {
                var tyontekija = tyontekijat[i];
                Console.WriteLine("Löydetty työntekijä: " + tyontekija);
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
                        Console.WriteLine("Työntekijän " + tyontekija + " tiedot:");
                        // tulostus työntekijä-olion tiedoista
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

    private static void HenkilostopaallikonToiminnot(LueTyöntekijät lueTyontekijat, List<string> tyontekijat)
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
                HaeTyontekija(tyontekijat);
                break;

        }
    }

    private static void HaeTyontekija(List<string> tyontekijat)
    {
        Console.WriteLine("Työntekijän haku");
        Console.WriteLine("Syötä työntekijän sukunimi:");
        var sukunimi = Console.ReadLine();

        for (int i = 0; i < tyontekijat.Count; i++)
        {
            if (!tyontekijat.Contains(sukunimi))
            {
                Console.WriteLine("Työntekijää ei löydy. Syötä sukunimi uudestaan:");
                sukunimi = Console.ReadLine();
            }
            if (sukunimi == tyontekijat[i])
            {
                var tyontekija = tyontekijat[i];
                Console.WriteLine("Löydetty työntekijä: " + tyontekija);
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
                        Console.WriteLine("Työntekijän " + tyontekija + " tiedot:");
                        // tulostus työntekijä-olion tiedoista
                        break;

                    case 2:
                        TietojenMuokkaus(tyontekija);
                        break;
                }
            }
        }
    }

    private static void TietojenMuokkaus(string tyontekija)
    {
        Console.WriteLine("Työntekijän " + tyontekija + " tietojen muokkaus:");
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
                break;
            case 2:
                Console.WriteLine("Syötä uusi peruspalkka:");
                var peruspalkka = int.Parse(Console.ReadLine());
                break;
            case 3:
                Console.WriteLine("Syötä uusi ikälisäprosentti:");
                var ikalisa = int.Parse(Console.ReadLine());
                break;
            case 4:
                Console.WriteLine("Syötä uusi veroprosentti:");
                var veroprosentti = int.Parse(Console.ReadLine());
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