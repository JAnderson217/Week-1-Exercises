using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Guess number, 6 tries
            int tries = 0;
            bool correct = false;
            int guess = 0;
            Random rnd = new Random();
            int randNum = rnd.Next(1, 101);
            while (tries < 6 && !correct)
            {
                Console.WriteLine("Enter your guess:");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == randNum)
                {
                    Console.WriteLine($"Correct the number was {randNum}");
                    correct = true;
                    break;
                }
                tries++;
                //Console.WriteLine($"Incorrect! {guess} is not the number, you have {6 - tries} tries remaining");
                if (guess < randNum)
                {
                    Console.WriteLine($"Too low! {guess} is not the number, you have {6 - tries} tries remaining");
                }
                else
                {
                    Console.WriteLine($"Too high! {guess} is not the number, you have {6 - tries} tries remaining");
                }
            }
            if (!correct)
            {
                Console.WriteLine($"Unlucky! The number was {randNum}");
            }
            Console.ReadLine();
        }
    }
}
