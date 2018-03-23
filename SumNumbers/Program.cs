using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class Program
    {
        private static void CalculateSum(int maxNumber, int currentNumber, int currentSum)
        {
            if (currentNumber < 1)
            {
                Console.WriteLine(String.Format("The sum of first {0} numbers is : {1}", maxNumber, currentSum));
                return;
            }
            currentSum += currentNumber;
            CalculateSum(maxNumber, --currentNumber, currentSum);


        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("How many numbers to sum?");
                int numbersToSum = Convert.ToInt32(Console.ReadLine());
                CalculateSum(numbersToSum, numbersToSum, 0);
                Console.WriteLine();
                Console.WriteLine();
            }
          
        }
    }
}
