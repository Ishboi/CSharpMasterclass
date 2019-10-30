using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomT
{
    class Program
    {
        static void Main(string[] args)
        {

            Random dice = new Random();
            int numEyes;

            for(int i = 0; i<10; i++)
            {
                numEyes = dice.Next(1,7);
                Console.WriteLine(numEyes);
            }
            Console.WriteLine("Please enter your question.");
            Console.ReadLine();
            numEyes = dice.Next(1, 4); //between the range where you want to start and +1 where you want to end, so it's 3 but insert 4 instead
            switch(numEyes)
            {
                case 1:
                    Console.WriteLine("Yes");
                    break;
                case 2:
                    Console.WriteLine("Maybe");
                    break;
                case 3:
                    Console.WriteLine("No");
                    break;
            }

            Console.ReadKey();


        }
    }
}
