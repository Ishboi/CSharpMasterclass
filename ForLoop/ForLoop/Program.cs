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
            //for (int counter = 1; counter < 20; counter+=2)
            //{
            //    if(counter % 2 > 0)
            //    {
            //        Console.WriteLine(counter + " is odd");
            //    }
            //}
            //doWhileLoop();
            //whileLoop();
            //breakContinue();
            average();

            Console.WriteLine("Loops are done");
            Console.Read();
        }

        public static void doWhileLoop()
        {
            int counter = 0;
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                //Console.WriteLine(counter);
                //counter++;
            } while (lengthOfText < 20);
            Console.WriteLine("Thanks, that was enought!");

        }

        public static void whileLoop()
        {
            int counter = 0;
            int test = 23323232;
            while(Console.ReadLine().Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount of people, +" +
                    "anything else ends the counting.");
                counter++;
                Console.WriteLine("Currently there is {0} people in this bus.", counter);
            }
            Console.WriteLine("Currently there is {0} people in the bus we're good to go ant this is just a test {1}", counter, test);
        }

        public static void breakContinue()
        {

            for (int counter = 0; counter < 10; counter++)
            {
                if(counter % 2 == 0)
                {
                    Console.WriteLine("Now comes an odd number!");
                    continue;
                }
                Console.WriteLine(counter);
            }

        }

        public static void average()
        {

            int count = 0;
            double grade = 0.0;
            double input = 0.0;

            while(true)
            {
                count++;
                Console.WriteLine("Please insert grade for student number {0}", count);
                Double.TryParse(Console.ReadLine(), out input);
                if((input == -1) || (input < 0) || (input > 20))
                {
                    Console.WriteLine("Stopped execution either by will or invalid value");
                    break;
                }
                grade += input;
            }
            Console.WriteLine("Grade total: {2}\n Average for class with {0} students, is {1:0.00}", count, (grade / count), grade);

        }


    }
}
