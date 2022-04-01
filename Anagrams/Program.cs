using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "parts","traps","arts","rats","starts","tarts","rat","art","tar","tars","stars","stray"};
            string anagram = "star";
            //sort each word and compare, if equal then anagram - alternative way would be to check length, convert to char array and compare each char
            foreach (string word in words)
            {
                if (String.Concat(word.OrderBy(c => c)) == String.Concat(anagram.OrderBy(c => c)))
                {
                    Console.WriteLine($"{word} is an anagram of {anagram}");
                }
                else
                {
                    Console.WriteLine($"{word} is not an anagram of {anagram}");
                }
            }
            Console.ReadLine();
        }
    }
}
