using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNatural
{
    class Program
    {
        public static void Print(int currentNumber, int maxNumber)
        {
            if (currentNumber > maxNumber)
            {
                return;
            }

            Console.Write(currentNumber + " ");
            Print(++currentNumber, maxNumber);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("How many numbers to print?");
                int maxNumber = Convert.ToInt32(Console.ReadLine());
                int startNumber = 1;
                Print(startNumber, maxNumber);
                Console.WriteLine();
            }
           
        }
    }
}
