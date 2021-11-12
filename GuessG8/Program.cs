using System;

namespace GuessG8
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            string welcome = "Arvuta numbrit välja 1 kuni 10";
            int num = rnd.Next(1, 10);
            Console.WriteLine(welcome);
            int count = 1;
            int p;
            while (count > 0)
                {
                Console.WriteLine("Katse number {0}:", count);
                p = Convert.ToInt32(Console.ReadLine());
                if (p == num)
                {
                    Console.WriteLine("Teie saite õiget numbrit kätte!");
                    break;
                }
                count++;

            }
            Console.ReadKey();
        }
    }
}