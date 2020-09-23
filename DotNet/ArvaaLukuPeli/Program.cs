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
            Console.WriteLine(oikeaLuku);





            Console.WriteLine("Kiitos ajastasi, peli on päättynyt.");
        }
    }
}
