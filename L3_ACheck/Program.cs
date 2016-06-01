using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_ACheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var evaluation = double.Parse(Console.ReadLine());
            if (evaluation >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
