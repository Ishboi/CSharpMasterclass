using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string birthday = "19-02-1992";

        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.BackgroundColor = ConsoleColor.DarkMagenta;
            //Console.Clear();
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hello Fabio");
            //Console.Read();

            //int num1 = 13;
            //int num2 = 14;
            //int num3, num4, num5;
            //int sum = num1 + num2;

            //double d1 = 3.5;
            //double d2 = 1.337;
            //double sumD = d1 / d2;

            //float f1 = 3.5F;

            //int divDandI = (int)d1 / num2;

            //Console.WriteLine(num1 + "+" + num2 + " = " + sum);
            //Console.WriteLine(d1 + "/" + num2 + " = " + sumD);

            //string myName = "Fabio";
            //string message = "My name is " + myName;

            //string capsMessage = message.ToUpper();
            //Console.WriteLine(capsMessage.ToLower());

            // implicit conversion
            //int num = 12390532;
            //long bigNum = num;

            //float myFloat = 13.37F;
            //double myNewDouble = myFloat;

            //double myDouble = 13.37;
            //int myInt;
            //// explicit conversion
            //// cast double into int;
            //myInt = (int)myDouble;

            //// typeConversion
            //string myString = myDouble.ToString(); // "13.37"
            //string myFloatString = myFloat.ToString();
            //bool sunIsShining = false;

            //string myBoolString = sunIsShining.ToString();

            //Console.WriteLine(myBoolString);
            //Console.Read();

            //string myString = "15";
            //string mySecondString = "13";
            //int num1 = Int32.Parse(myString);
            //int num2 = Int32.Parse(mySecondString);
            //int resultInt = num1 + num2;
            //string result = myString + mySecondString;
            //byte bitByte = 255;
            //sbyte sbitByte = -108;
            //int intIntit = Int32.MaxValue;
            //uint uintInit = UInt32.MaxValue;
            //short shortNumber = short.MinValue;
            //ushort ushortNumber = ushort.MaxValue;
            //long longNumber = long.MinValue;
            //ulong ulongNumber = ulong.MinValue;
            //float floatNumber = float.MaxValue;
            //double doubleNumber = double.MinValue;
            //char charType = 'F';
            //bool boolType = false;
            //string stringType = "sup";
            //decimal decimalNumber = decimal.MinValue;

            //string value1 = "I control text";
            //int value2 = Int32.Parse("123454433");

            //Console.WriteLine(bitByte);
            //Console.WriteLine(sbitByte);
            //Console.WriteLine(intIntit);
            //Console.WriteLine(uintInit);
            //Console.WriteLine(shortNumber);
            //Console.WriteLine(ushortNumber);
            //Console.WriteLine(longNumber);
            //Console.WriteLine(ulongNumber);
            //Console.WriteLine(floatNumber);
            //Console.WriteLine(doubleNumber);
            //Console.WriteLine(charType);
            //Console.WriteLine(boolType);
            //Console.WriteLine(stringType);
            //Console.WriteLine(decimalNumber);
            //Console.WriteLine("this is the string - " + value2);

            //Console.WriteLine("Birthday is - {0}", birthday);
            //Console.ReadKey();

            //WriteSomething();
            //WriteSomethingSpecific("I am an argument and am called from method");

            //Console.WriteLine(Add(Add(1, 2), Add(3, 4)));
            //Console.WriteLine(Mult(150,12));
            //Console.WriteLine(Divide(25,13));

            //string friend1 = "Danny";
            //string friend2 = "Vitorino";
            //string friend3 = "Bruno";

            //GreetFriend(friend1);
            //GreetFriend(friend2);
            //GreetFriend(friend3);

            //int firstInput = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(" + ");
            //int secondInput = Int32.Parse(Console.ReadLine());
            //Console.Write(" = " + (firstInput + secondInput));
            Calculate();
            
            Console.Read();

        }

        public static void Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string number1Input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2Input = Console.ReadLine();

            int num1 = int.Parse(number1Input);
            int num2 = int.Parse(number2Input);


            int result = num1 + num2;
            Console.WriteLine(result);

        }

        //public static void GreetFriend(string friend)
        //{
        //    Console.WriteLine("Hi " + friend + ", my friend!");
        //}

        //public static int Add(int parameter1, int parameter2)
        //{

        //    return parameter1 + parameter2;
        //}
        //public static int Mult(int num1, int num2)
        //{
        //    return num1 * num2;
        //}
        //public static double Divide(double num1, double num2)
        //{
        //    return num1 / num2;
        //}

        //public static void WriteSomething()
        //{

        //    Console.WriteLine("I am called from a method");
        //}

        //public static void WriteSomethingSpecific(string myText)
        //{
        //    Console.WriteLine(myText);
        //}
    }
}
