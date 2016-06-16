using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_SameWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            if (input1.ToLower() == input2.ToLower())
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
