using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        private static void CalculateFactorial(int initialNumber, int currentNumber, long result)
        {
            if (currentNumber < 1)
            {
                Console.WriteLine(String.Format("The factorial of {0} is {1}", initialNumber, result));
                return;
            }

            result = result * currentNumber;
            CalculateFactorial(initialNumber, --currentNumber, result);

        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input any positive number");
                int number = Convert.ToInt32(Console.ReadLine());
                CalculateFactorial(number, number, 1);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
