using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal class TietojenMuokkaus
    {
        private List<Tyontekija> tyontekijaLista;
        TiedostonKasittelija tiedostonKasittelija = new TiedostonKasittelija();

        public TietojenMuokkaus(List<Tyontekija> tyontekijaLista)
        {
            this.tyontekijaLista = tyontekijaLista;
        }

        public void MuokkaaTietoja(Tyontekija tyontekija)
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Työntekijän " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " tietojen muokkaus:");
                Console.WriteLine("Valitse, mitä tietoja haluat muokata. Lopettaessasi ohjelman tiedot tallentuvat automaattisesti:\n");
                Console.WriteLine("[0] Takaisin");
                Console.WriteLine("[1] Muuta työnimike");
                Console.WriteLine("[2] Muuta peruspalkkan määrä");
                Console.WriteLine("[3] Muuta ikälisäprosenttia");
                Console.WriteLine("[4] Muuta veroprosenttia");
                int toiminto5;
                bool syotteenTarkistus;
                int toimintojenMaara = 4;
                bool poistu = false;
                SyotteenTarkistus syotteenTarkistus1 = new SyotteenTarkistus();
                syotteenTarkistus1.SyoteJaTarkistus(out syotteenTarkistus, out toiminto5, toimintojenMaara);

                switch (toiminto5)
                {
                    case 0:
                        poistu = true;
                        break;
                    case 1:
                        Console.WriteLine("Syötä uusi työnimike:");
                        var tyonimike = Console.ReadLine();
                        tyontekija.Tehtava = tyonimike;
                        Console.WriteLine("Henkilön " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " uusi työnimike on: " + tyontekija.Tehtava + "\n");
                        break;
                    case 2:
                        Console.WriteLine("Syötä uusi peruspalkka:");
                        var peruspalkka = double.Parse(Console.ReadLine());
                        tyontekija.Kuukausipalkka = peruspalkka;
                        Console.WriteLine("Henkilön " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " uusi kuukausipalkka on: " + tyontekija.Kuukausipalkka + "\n");
                        break;
                    case 3:
                        Console.WriteLine("Syötä uusi ikälisäprosentti:");
                        var ikalisa = double.Parse(Console.ReadLine());
                        tyontekija.Ikalisa = ikalisa;
                        Console.WriteLine("Henkilön " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " uusi ikälisäprosentti on: " + tyontekija.Ikalisa + "\n");
                        break;
                    case 4:
                        Console.WriteLine("Syötä uusi veroprosentti:");
                        var veroprosentti = double.Parse(Console.ReadLine());
                        tyontekija.Veroprosentti = veroprosentti;
                        Console.WriteLine("Henkilön " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " uusi veroprosentti on: " + tyontekija.Veroprosentti + "\n");
                        break;
                }
                if (poistu)
                {
                    tiedostonKasittelija.Talleta(tyontekijaLista);
                    break;
                }
            }
        }
    }
}
