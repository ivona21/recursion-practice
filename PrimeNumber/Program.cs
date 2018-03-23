using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        private static void IsPrime(int number, int divisor)
        {
            if (number % divisor == 0)
            {
                Console.WriteLine(String.Format("The number {0} is not a prime number", number));
                return;
            }

            if (divisor > number / 2)
            {
                Console.WriteLine(String.Format("The number {0} is a prime number", number));
                return;
            }

            IsPrime(number, ++divisor);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input any positive number");
                int number = Convert.ToInt32(Console.ReadLine());
                IsPrime(number, 2);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
