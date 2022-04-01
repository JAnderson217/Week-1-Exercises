using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_at_Nth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //populate list of primes until X number
            //Console.WriteLine("Populate list of primes until:");
            //int totalPrimes = Convert.ToInt32(Console.ReadLine()); 
            int totalPrimes = 100;
            //create list of primes
            List<int> primeNumbers = populatePrime(100);
            Console.Write("Prime numbers: ");
            foreach (int primeNumber in primeNumbers)
            {
                Console.Write($"{primeNumber} ");
            }
            Console.WriteLine();
            Console.WriteLine("Please enter N for prime number at Nth position:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Prime number at N = {n} is {primeNumbers[n-1]}");
            Console.ReadLine(); 
        }

        public static List<int> populatePrime(int a)
        {
            List<int> primeNumbers = new List<int>();
            for (int i = 2; i<a; i++)
            {
                if (isPrime(i))
                {
                    primeNumbers.Add(i);
                }   
            }
            return primeNumbers;
        }

        public static bool isPrime(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if ((a % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
