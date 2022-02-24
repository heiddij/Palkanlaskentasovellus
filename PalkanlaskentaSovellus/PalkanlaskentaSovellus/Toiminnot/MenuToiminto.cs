using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus.Toiminnot
{
    internal abstract class MenuToiminto
    {

        public string Komento { get; set; }
        public abstract void Suorita(); // abstract pakottaa aliluokan suorittamaan 


    }
}
