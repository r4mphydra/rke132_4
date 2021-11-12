using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i = 0;
            while(i != 5)
            {
                int randomNum = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on {randomNum}.");
                if(randomNum == 5)
                {
                    i = randomNum;
                }
            }
            Console.WriteLine("Head aega!");
        }
    }
}
