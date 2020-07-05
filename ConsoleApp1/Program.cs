using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var random = new Random();
            //int aantalOgen = random.Next(1, 7);
            //int i = 0;

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
                Gooi();
            }
            while (keyinfo.Key != ConsoleKey.Escape);

        }

        public static void Gooi()
        {
            var random = new Random();
            int aantalOgen = random.Next(1, 7);
            Console.WriteLine(aantalOgen);
        }

    }
}
