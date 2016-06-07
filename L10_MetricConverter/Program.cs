using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var entry = double.Parse(Console.ReadLine());
            var inputMetric = Console.ReadLine();
            var outputMetric = Console.ReadLine();

            string[] metrics = {"m", "mm", "cm", "mi", "in", "km", "ft", "yd"};
            double[] conversions = { 1.0, 1000.00, 100.00, 0.000621371192, 39.3700787, 0.001, 3.2808399, 1.0936133 };

            var meters = entry / conversions[Array.IndexOf(metrics, inputMetric.ToLower())];
            var output = meters * conversions[Array.IndexOf(metrics, outputMetric.ToLower())];
            Console.WriteLine(output + " " + outputMetric);
        }
    }
}
