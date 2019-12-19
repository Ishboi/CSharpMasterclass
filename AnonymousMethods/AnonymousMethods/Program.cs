using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    class Program
    {
        public delegate string GetTextDelegate(string name);

        public delegate double GetResultDelegate(double a, double b);

        static void Main(string[] args)
        {

            // Creating an anonymous method
            GetTextDelegate getTextDelegate = delegate (string name)
            {
                return "Hello, " + name;
            };

            // Lambda expression
            GetTextDelegate getHelloText = (string name) => { return "Hello, " + name; };

            // Statement lambda
            GetTextDelegate getGoodbyeText = (string name) =>
            {
                Console.WriteLine("I'm inside of a lambda statement");
                return "Goodbye, " + name;
            };

            // even nicer lambda expression, also it only works because it's just one variable the "name" variable
            GetTextDelegate getWelcomeText = name => "Welcome, " + name;

            // lambda expression with various variables
            GetResultDelegate getSum = (a, b) => a + b;
            GetResultDelegate getProduct = (a, b) => a * b;

            DisplayNum(getSum);
            DisplayNum(getProduct);


            Console.WriteLine(getWelcomeText("Denis"));
            //Display(getTextDelegate);
            SayHello();
            Console.ReadKey();
        }

        static void DisplayNum(GetResultDelegate getResultDelegate)
        {
            Console.WriteLine(getResultDelegate(3.5, 2.5));
        }

        static void Display(GetTextDelegate getTextDelegate)
        {
            Console.WriteLine(getTextDelegate("World"));
        }


        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
