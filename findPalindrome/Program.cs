using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a string you would like to be reversed:");
            String input = Console.ReadLine();
            if (checkPalindrome(input))
            {
                Console.WriteLine($"{input} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome");
            }
            Console.ReadLine();
        }

        public static bool checkPalindrome(String a)
        {
            char[] inputToChar = a.ToCharArray();
            String palindrome = "";
            for (int i = inputToChar.Length - 1; i >= 0; i--)
            {
                palindrome += inputToChar[i];
            }
            if (a == palindrome)
            {
                return true;
            }
            return false;
        }
    }
}
