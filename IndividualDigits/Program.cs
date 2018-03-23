using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualDigits
{
    class Program
    {
        private static void PrintDigit(int number, int numberOfDigits)
        {
            int digit = number / numberOfDigits;
            int modulo = number % numberOfDigits;
            Console.Write(String.Format("{0} ", digit));
            if (numberOfDigits == 1)
            {
                return;
            }
            numberOfDigits /= 10;
            PrintDigit(modulo, numberOfDigits);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input any number");
                string input = Console.ReadLine();
                int numberOfDigits = input.Trim().Length;
                int number = Convert.ToInt32(input);
                PrintDigit(number, Convert.ToInt32(Math.Pow(10, numberOfDigits-1)));
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
