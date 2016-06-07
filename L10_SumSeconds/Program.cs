using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var athlete1 = int.Parse(Console.ReadLine());
            var athlete2 = int.Parse(Console.ReadLine());
            var athlete3 = int.Parse(Console.ReadLine());

            var sum = athlete1 + athlete2 + athlete3;
            var minutes = sum / 60;
            var seconds = sum % 60;
            var zero = seconds < 10 ? "0" : "";
            Console.WriteLine("{0}:{1}{2}", minutes, zero, seconds);
        }
    }
}
