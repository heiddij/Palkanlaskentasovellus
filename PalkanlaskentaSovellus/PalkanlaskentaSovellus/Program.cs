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
        var TESTAUSMUUTAMINUT = new LueTyöntekijät();

        Console.WriteLine("Tervetuloa Palkanlasku-sovellukseen. Valitse rooli:");
        Console.WriteLine("[1] Henkilöstöpäällikkö");
        Console.WriteLine("[2] Palkanlaskija");
        int rooli = int.Parse(Console.ReadLine());

        if (rooli != 1 || rooli != 2)
        {
            Console.WriteLine("Väärä syöte! Valitse joko 1 tai 2");
            rooli = int.Parse(Console.ReadLine());
        }

        if (rooli == 1)
        {
            Console.WriteLine("Henkilöstöpäällikkö, valitse toiminto:");
            Console.WriteLine("[1] Lista työntekijöistä");
            Console.WriteLine("[2] Lisää työntekijä");
            Console.WriteLine("[3] Poista työntekijä");
            int toiminto1 = int.Parse(Console.ReadLine());
            if (toiminto1 == 1)
            {
                TESTAUSMUUTAMINUT.LuetteleKaikki();
            }
        }

        if (rooli == 2)
        {
            Console.WriteLine("Palkanlaskija, valitse toiminto:");
            Console.WriteLine("[1] Lista työntekijöistä");
            int toiminto2 = int.Parse(Console.ReadLine());
            if (toiminto2 == 1)
            {
                TESTAUSMUUTAMINUT.LuetteleKaikki();
            }
        }
    }

}