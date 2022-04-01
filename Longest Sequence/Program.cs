using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sales = { 1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0, 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0 };
            int count = 0;
            int dryStreak = 0;
            foreach (int i in sales)
            {
                if (i == 0)
                {
                    count++;
                    if (count > dryStreak)
                    {
                        dryStreak = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            Console.WriteLine($"Longest sequence without a sale was {dryStreak} days");
            Console.ReadLine();
        }
    }
}
