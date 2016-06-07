﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            var score = double.Parse(Console.ReadLine());
            var bonus = 0.0;
            if (score <= 100)
            {
                bonus += 5;
            }
            else if (score > 1000)
            {
                bonus += score * 0.1;
            }
            else
            {
                bonus += score * 0.2;
            }                       

            if (score % 2 == 0)
            {
                bonus += 1;
            } else if (score % 5 == 0 && score % 10 != 0)
            {
                bonus += 2;
            }

            Console.WriteLine("Bonus score: {0}", bonus);
            Console.WriteLine("Total score: {0}", score + bonus);
        }
    }
}
