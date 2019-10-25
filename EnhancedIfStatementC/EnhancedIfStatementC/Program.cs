using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancedIfStatementC
{
    class Program
    {
        static void Main(string[] args)
        {

            int temperature = -5;
            string stateOfMatter;
            /*
            if(temperature < 0)
            {
                stateOfMatter = "solid";
            }
            else
            {
                stateOfMatter = "liquid";
            } */


            // in short:

            temperature += 20;
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.ReadKey();


        }
    }
}
