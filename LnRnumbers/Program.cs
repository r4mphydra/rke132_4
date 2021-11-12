using System;

namespace LnRnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Palun, sisesta oma PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());
                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud");
                }
             
       
            }
            
            }
        }
    }

