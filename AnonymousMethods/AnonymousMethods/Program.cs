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



        static void Main(string[] args)
        {
            GetTextDelegate getTextDelegate = delegate (string name)
            {
                return "Hello, " + name;
            };
            Console.WriteLine(getTextDelegate("Denis"));
            Display(getTextDelegate);
            SayHello();
            Console.ReadKey();
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
