using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDigits
{
    class Program
    {
        private static void CountDigits(int initialNumber, int currentNumber, int numberOfDigits)
        {
            if (currentNumber / 10 < 1)
            {
                Console.WriteLine(String.Format("The number {0} cointains number of digits : {1}", initialNumber, numberOfDigits));
                return;
            }

            CountDigits(initialNumber, currentNumber / 10, ++numberOfDigits);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input any number");
                int number = Convert.ToInt32(Console.ReadLine());
                CountDigits(number, number, 1);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
