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

            Console.WriteLine("Birthday is - {0}", birthday);
            Console.ReadKey();



        }
    }
}
