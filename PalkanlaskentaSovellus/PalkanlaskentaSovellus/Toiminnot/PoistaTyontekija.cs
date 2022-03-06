using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal class PoistaTyontekija
    {
        public void Poista(int tunniste, List<Tyontekija> tyontekijatlista)
        {
            for (int i = 0; i < tyontekijatlista.Count; i++)
            {
                if(i == tunniste)
                {
                    Console.WriteLine("Työntekijä " + tyontekijatlista[i].Etunimi + " " + tyontekijatlista[i].Sukunimi + " poistettu!");
                    tyontekijatlista.RemoveAt(i);
                    break;
                }
            }
            if (tunniste > tyontekijatlista.Count)
            { 
                Console.WriteLine("Työntekijää ei löydy!"); 
            }
              
        }
    }
}