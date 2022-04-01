using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type an integer:");
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            //use while loop and mod % 10 to move between each digit
            while (input != 0)
            {
                sum += input % 10;
                input /= 10;
            }
            Console.WriteLine($"Sum of digits is {sum}");
            Console.ReadLine();
        }
    }
}
