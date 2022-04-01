using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a string you would like to be reversed:");
            String input = Console.ReadLine();
            char[] inputToChar = input.ToCharArray();
            String palindrome = "";
            for (int i = inputToChar.Length-1; i >= 0; i--)
            {
                palindrome += inputToChar[i];
            }
            Console.WriteLine($"The palindrome of {input} is {palindrome}");
            Console.ReadLine();
        }
    }
}
