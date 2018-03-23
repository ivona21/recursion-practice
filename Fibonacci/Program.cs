using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        private static void CalculateFibonacci(int[] fibonacci, int index)
        {
            if (index >= fibonacci.Length)
            {
                Console.WriteLine(String.Format("The Fibonacci series of {0} terms is: {1}", fibonacci.Length, String.Join(" ", fibonacci)));
                return;
            }

            if (index == 0)
            {
                fibonacci[index] = 0;
            }
            else if (index == 1)
            {
                fibonacci[index] = 1;
            }          
            else
            {
                fibonacci[index] = fibonacci[index - 1] + fibonacci[index - 2];               
            }
            CalculateFibonacci(fibonacci, ++index);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input number of terms for the Fibonacci series");
                int number = Convert.ToInt32(Console.ReadLine());
                CalculateFibonacci(new int[number], 0);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
