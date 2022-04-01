using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diamond = 5;
            string[] diamondArray = new string[diamond*2-1];
            //populate array with num of spaces and stars
            for (int i = 1; i <= diamond; i++)
            {
                diamondArray[i - 1] = string.Concat(Enumerable.Repeat(" ", diamond - i));
                for (int j = 0; j < ((i * 2) - 1); j++)
                {
                    diamondArray[i - 1] += "*";
                }
            }
            //populate array in reverse
            for (int i = 0; i < diamond-1; i++)
            {
                diamondArray[diamond +i] = string.Concat(Enumerable.Repeat(" ", i+1));
                diamondArray[diamond +i] += string.Concat(Enumerable.Repeat("*", (diamond - i - 1) * 2 - 1));
                //for (int j = 0; j < ((i * 2) - 1); j++)
                //{
                //    diamondArray[i - 1] += "*";
                //}
            }
            foreach (string x in diamondArray)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
