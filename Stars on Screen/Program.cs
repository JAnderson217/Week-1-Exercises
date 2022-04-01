using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars_on_Screen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stars = 5;
            string[] starsArray = new string[stars];
            //populate array with num of spaces and stars
            for (int i = 1; i <= stars; i++)
            {
                starsArray[i - 1] = string.Concat(Enumerable.Repeat(" ", (stars - i)));
                for (int j = 0; j < ((i * 2) - 1); j++)
                {
                    starsArray[i - 1] += "*";
                }
            }
            foreach (string x in starsArray)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
