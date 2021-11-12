using System;

namespace PinInfinitline
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopActive = true;
            int i = 0;
            while (loopActive)
            {
                Console.WriteLine("Palun, sisesta oma PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());
                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN {i} korda kasutanud!");
                }
            }
            Console.WriteLine("Head aega!");
        }
    }
}
