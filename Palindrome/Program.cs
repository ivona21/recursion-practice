using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        private static void IsPalindrome(string word, int counter, int limit)
        {
            if (word.Length == 1)
            {
                Console.WriteLine("String is only one character long, so ofcourse it is Palindrome.");
                return;
            }

            if (counter > limit)
            {
                Console.WriteLine("The string is Palindrome.");
                return;
            }

            if (word[counter].Equals(word[word.Length - 1 - counter]))
            {
                IsPalindrome(word, ++counter, limit);
            }
            else
            {
                Console.WriteLine("The string is not Palindrome.");
                return;
            }

        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input a string");
                string word = Console.ReadLine();
                IsPalindrome(word, 0, word.Length / 2 + 1);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
