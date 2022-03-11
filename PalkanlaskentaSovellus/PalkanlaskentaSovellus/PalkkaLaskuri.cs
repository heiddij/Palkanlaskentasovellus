using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkanlaskentaSovellus
{
    internal class PalkkaLaskuri
    {
        private Tyontekija tyontekija;

        // Työnantajan kulut palkasta
        public double TyonantajaTyEL { get; set; }
        public double TyonantajaTyotVakMaksu { get; set; }
        public double SairausVakMaksu { get; set; } 

        // Työntekijän kulut palkasta
        public double TyontekijaTyEL { get; set; }
        public double TyontekijaTyotVakMaksu { get; set; }


        public PalkkaLaskuri(Tyontekija tyontekija)
        {
            this.tyontekija = tyontekija;
            TyonantajaTyEL = 0.187;
            TyonantajaTyotVakMaksu = 0.005;
            SairausVakMaksu = 0.0134;
            TyontekijaTyEL = 0.0715;
            TyontekijaTyotVakMaksu = 0.015;
        }

        public void TulostaPalkka()
        {
            Console.Clear();
            Console.WriteLine("Viime kuukauden maksettava nettopalkka työntekijälle " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + ":\n");
            Console.WriteLine($"{LaskePalkka():0.00} euroa\n");
        }

        public void PalkanTiedot()
        {
            Console.Clear();
            Console.WriteLine("Työntekijän " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " viime kuukauden palkan tiedot:\n");
            Console.WriteLine("Palkka:\t\t\t\t " + tyontekija.Kuukausipalkka);
            Console.WriteLine($"Ennakonpidätys:\t\t\t {LaskeVerot():0.00}");
            Console.WriteLine($"Työeläkemaksu:\t\t\t {(TyontekijaTyEL * tyontekija.Kuukausipalkka):0.00}");
            Console.WriteLine($"Työttömyysvakuutusmaksu:\t {(TyontekijaTyotVakMaksu * tyontekija.Kuukausipalkka):0.00}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"= Nettopalkka:\t\t\t {LaskePalkka():0.00}\n");
        }

        public void TyonantajaMaksut()
        {
            double tyoelakemaksu = TyonantajaTyEL * tyontekija.Kuukausipalkka;
            double sairausvakmaksu = SairausVakMaksu * tyontekija.Kuukausipalkka;
            double tyotvakmaksu = TyonantajaTyotVakMaksu * tyontekija.Kuukausipalkka;
            double yhteensa = tyoelakemaksu + sairausvakmaksu + tyotvakmaksu;

            Console.Clear();
            Console.WriteLine("Työntekijän " + tyontekija.Etunimi + " " + tyontekija.Sukunimi + " viime kuukauden palkan työnantajamaksut:\n");
            Console.WriteLine($"Työeläkemaksu:\t\t\t {tyoelakemaksu:0.00}");
            Console.WriteLine($"Sairausvakuutusmaksu:\t\t {sairausvakmaksu:0.00}");
            Console.WriteLine($"Työttömyysvakuutusmaksu:\t {tyotvakmaksu:0.00}\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"= Yhteensä:\t\t\t {yhteensa:0.00}\n");
        }

        private double LaskeLisat()
        {
            return tyontekija.Ikalisa / 100 * tyontekija.Kuukausipalkka;
        }

        private double LaskeVerot()
        {
            return tyontekija.Veroprosentti / 100 * tyontekija.Kuukausipalkka;
        }

        private double LaskeKulut()
        {
            return (TyontekijaTyEL + TyontekijaTyotVakMaksu) * tyontekija.Kuukausipalkka;
        }

        private double LaskePalkka()
        {
            return tyontekija.Kuukausipalkka + LaskeLisat() - LaskeVerot() - LaskeKulut();
        }
    }
}
