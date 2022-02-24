using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus
{
    internal class SyotteenTarkistus
    {
        public void SyoteJaTarkistus(out bool syotteenTarkistus, out int oikeaSyote, int toimintojenMaara)
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
}
