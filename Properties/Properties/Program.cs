﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(5, 4, 10);
            Console.WriteLine("volume is{0}", box.Volume);
            Console.WriteLine("Front surface of the box is {0}", box.Frontsurface);
            

            box.DisplayInfo();
            Console.ReadKey();
        }
    }
}
