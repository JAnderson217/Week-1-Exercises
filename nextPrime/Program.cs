using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nextPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to get the next prime:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Next prime after {input} is {nextPrime(input)}");
            Console.ReadLine();
        }

        public static int nextPrime(int x)
        {
            int prime = 0;
            while (prime == 0)
            {
                x++;
                if (isPrime(x))
                {
                    prime = x;
                }
            }
            return prime;
        }

        public static bool isPrime(int y)
        {
            if (y == 1)
            {
                return false;
            }
            for (int i = 2; i < y; i++)
            {
                if ((y % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
