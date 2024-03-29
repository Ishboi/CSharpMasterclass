﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExampleC
{
    class Program
    {
        public delegate double PerformCalculation(double x, double y);

        public static double Addition(double a, double b)
        {
            Console.WriteLine("a + b is : " + (a + b));
            return a + b;
        }
        public static double Division(double a, double b)
        {
            Console.WriteLine("a / b is : " + (a / b));
            return a / b;
        }
        public static double Subtraction(double a, double b)
        {
            Console.WriteLine("a - b is : " + (a - b));
            return a - b;
        }

        static void Main(string[] args)
        {
            PerformCalculation getSum = Addition;
            //getSum(5.0, 5.0);
            PerformCalculation getQuotient = Division;
            //getQuotient(5.0, 5.0);

            PerformCalculation multiCalc = getSum + getQuotient;
            multiCalc += Subtraction; // adds subtraction method reference 
            multiCalc -= getSum; // removes getSum reference
            multiCalc(3.2, 3.2);

            Console.ReadKey();
        }
    }
}
