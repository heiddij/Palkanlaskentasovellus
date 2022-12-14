using PalkanlaskentaSovellus;
using PalkanlaskentaSovellus.Toiminnot;

class MainClass
{
    public static void Main(string[] args)
    {
        bool syotteenTarkistus; // onko syöte int vai joku muu
        int rooli;
        int toimintojenMaara = 2;

        // Tehdään lista työntekijöistä.
        List<Tyontekija> tyontekijatLista = new List<Tyontekija>(); // Käytetään alla.
        TiedostonKasittelija tiedostonKasittelija = new TiedostonKasittelija();
        tiedostonKasittelija.LueTyontekijatTiedostosta(tyontekijatLista);

        while (true)
        {
            TulostaToiminnot();

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

    private static void TulostaToiminnot()
    {
        Console.Clear();
        Console.WriteLine("Tervetuloa Palkanlasku-sovellukseen. Valitse rooli (0 lopettaa):\n");
        Console.WriteLine("[0] Lopetus");
        Console.WriteLine("[1] Henkilöstöpäällikkö");
        Console.WriteLine("[2] Palkanlaskija");
    }
}
