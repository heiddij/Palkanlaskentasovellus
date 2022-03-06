using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal class HenkpaallikkoLisaaTyontekija
    {
       public void LisaaTyontekija(List<Tyontekija> tyontekijatLista)
        {
            Console.WriteLine("Työntekijän lisäys");
            Console.WriteLine("Syötä työntekijän sukunimi:");
            string sukunimi = Console.ReadLine();
            Console.WriteLine("Syötä työntekijän etunimi:");
            string etunimi = Console.ReadLine();
            Console.WriteLine("Syötä työntekijän tehtava:");
            string tehtava = Console.ReadLine();
            Console.WriteLine("Syötä työntekijän kuukausipalkka:");
            double kuukausipalkka = double.Parse(Console.ReadLine());
            Console.WriteLine("Syötä työntekijän ikalisa:");
            double ikalisa = double.Parse(Console.ReadLine());
            Console.WriteLine("Syötä työntekijän veroprosentti:");
            double veroprosentti = double.Parse(Console.ReadLine());

            tyontekijatLista.Add(new Tyontekija(sukunimi, etunimi, tehtava, kuukausipalkka, ikalisa, veroprosentti));
        }
    }
}
