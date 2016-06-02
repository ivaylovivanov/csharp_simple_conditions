using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_TypeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            string[] words = new string[10] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            
            if (Enumerable.Range(0,10).Contains(number))
            {
                Console.WriteLine(words[number]);     
            }
            else
            {
                Console.WriteLine("number too big");
            }

        }
    }
}
