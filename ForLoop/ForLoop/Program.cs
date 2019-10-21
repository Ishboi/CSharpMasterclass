using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {


            for(int counter = 1; counter < 50; counter++)
            {
                if(counter % 2 > 0)
                {
                    Console.WriteLine(counter + " is odd");
                }
            }
            for (int counter = 1; counter < 20; counter+=2)
            {
                if(counter % 2 > 0)
                {
                    Console.WriteLine(counter + " is odd");
                }
            }
            Console.WriteLine("For loop is done");
            Console.Read();
        }
    }
}
