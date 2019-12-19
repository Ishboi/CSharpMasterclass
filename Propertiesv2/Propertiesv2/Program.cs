using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertiesv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,4,5);
            Console.WriteLine("Box's width is  " + box.Width);
            box.Width = 10;
            Console.WriteLine("Box's width is  " + box.Width);
            Console.WriteLine("Box's volume is  " + box.Volume);
            box.DisplayInfo();
            Console.ReadKey();

        }
    }
}
