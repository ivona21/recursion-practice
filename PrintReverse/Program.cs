using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintReverse
{
    class Program
    {
        private static void PrintNumber(int number)
        {
            if (number < 1)
            {
                return;
            }
            Console.Write(String.Format("{0} ", number));
            PrintNumber(--number);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("How many numbers to print?");
                int maxNumber = Convert.ToInt32(Console.ReadLine());
                PrintNumber(maxNumber);
                Console.WriteLine();
                Console.WriteLine();

            }
        }
    }
}
