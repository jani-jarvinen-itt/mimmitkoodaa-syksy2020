using System;

namespace OlioOhjelmointi
{
    class Auto
    {
        public int Huippunopeus { get; set; }
        public string Väri { get; set; }
    }

    class Henkilöauto : Auto
    {        
        public int OvienMäärä { get; set; }
        public bool MoottoriKäynnissä { get; set; }

        public void Käynnistä()
        {
            MoottoriKäynnissä = true;
        }
    }

    class KuormaAuto : Auto
    {
        public int LavanKantavuusTonneina { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Henkilöauto oma = new Henkilöauto();
            Henkilöauto naapurin = new Henkilöauto();

            oma.Väri = "keltainen";
            oma.Huippunopeus = 200;

            naapurin.Väri = "harmaa";
            naapurin.Huippunopeus = 180;

            oma.Käynnistä();
        }
    }
}
