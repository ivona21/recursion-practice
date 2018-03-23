using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEven
{
    class Program
    {
        private static void Classify(int from, int to, int current, List<int> odd, List<int> even)
        {
            if (current > to)
            {
                Console.WriteLine(String.Format("All even numbers from {0} to {1} are: \n {2}", from, to, String.Join(" ", even)));
                Console.WriteLine(String.Format("All odd numbers from {0} to {1} are: \n {2}", from, to, String.Join(" ", odd)));
                return;
            }

            if (current % 2 == 0)
            {
                even.Add(current);
            }
            else
            {
                odd.Add(current);
            }

            Classify(from, to, ++current, odd, even);
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input the range to print starting from");
                int from = Convert.ToInt32(Console.ReadLine());
                int to = Convert.ToInt32(Console.ReadLine());
                Classify(from, to, from, new List<int>(), new List<int>());
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
