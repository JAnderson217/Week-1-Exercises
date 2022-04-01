using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {3, 1, 5, 7, 5, 9};
            int total = 10;
            Tuple<int, int> indices = FindTwoSum(numbers, total);
            Console.WriteLine($"Indices that add to {total} are {indices}");
            Console.ReadLine();
        }

        public static Tuple<int, int> FindTwoSum(List<int> list, int sum)
        { 
            //loop through all values, add together, if 10 then return indicies
            for (int i=0; i<list.Count; i++)
            {
                for (int j=i+1; j<list.Count; j++)
                {
                  if ((list[i]+list[j])==10)
                    {
                        Tuple<int, int> indices = new Tuple<int, int>(i, j);
                        return indices;
                    }
                }
            }
            return null;
        }

    }


}
