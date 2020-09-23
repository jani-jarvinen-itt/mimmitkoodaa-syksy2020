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
            while (arvauskertoja < 3) {

               Console.WriteLine("Anna arvauksesi välillä 1-20:");
               int arvaus = int.Parse(Console.ReadLine());

               if (arvaus < oikeaLuku) {
                   Console.WriteLine("Oikea luku on suurempi!");
               }
               else if (arvaus > oikeaLuku) {
                   Console.WriteLine("Oikea luku on pienempi!");
               }
               else {
                   Console.WriteLine("Oikein! Voitit pelin!");
               }

               arvauskertoja++;
            }

            Console.WriteLine("Kiitos ajastasi, peli on päättynyt.");
        }
    }
}
