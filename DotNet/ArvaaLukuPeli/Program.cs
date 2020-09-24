using System;

namespace ArvaaLukuPeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa Arvaa luku -peliin!");
            
            // arvotaan satunnainen luku, josta tulee pelin oikea vastaus
            Random satunnainen = new Random();
            int oikeaLuku = satunnainen.Next(1, 21);
            // Console.WriteLine(oikeaLuku);
            
            // annetaan pelaajalle kolme arvauskertaa
            int arvauskertoja = 0;
            const int ArvauskertojaEnintään = 3;
            while (arvauskertoja < ArvauskertojaEnintään) {

               // kysytään pelaajalta arvaus, ja muunnetaan se numeroksi
               Console.WriteLine("Anna arvauksesi välillä 1-20:");
               int arvaus = int.Parse(Console.ReadLine());

               // tarkistetaan, onko arvaus oikein
               if (arvaus < oikeaLuku) {
                   Console.WriteLine("Oikea luku on suurempi!");
               }
               else if (arvaus > oikeaLuku) {
                   Console.WriteLine("Oikea luku on pienempi!");
               }
               else {
                   Console.WriteLine("Oikein! Voitit pelin!");

                   // päätetään silmukka
                   break;
               }

               // kasvatetaan arvauskertojen määrää yhdellä
               arvauskertoja++;
            }

            Console.WriteLine("Kiitos ajastasi, peli on päättynyt.");
        }
    }
}
