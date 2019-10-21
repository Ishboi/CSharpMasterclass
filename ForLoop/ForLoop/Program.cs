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


            //for(int counter = 1; counter < 50; counter++)
            //{
            //    if(counter % 2 > 0)
            //    {
            //        Console.WriteLine(counter + " is odd");
            //    }
            //}

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
            average(); // my solution

            /**
             * His weird solution

            //string input = "0";
            //int count = 0;
            //int total = 0;
            //int currentNumber = 0;
            //while(input != "-1")
            //{
            //    Console.WriteLine("Last number was {0}", currentNumber);
            //    Console.WriteLine("Please enter the next score");
            //    Console.WriteLine("Current amount of entries {0}", count);
            //    Console.WriteLine("Please enter -1 once you are ready to calculate the average");

            //    input = Console.ReadLine();
            //    if(input.Equals("-1"))
            //    {
            //        Console.WriteLine("--------------------------------------------------");
            //        double average = (double)total / (double)count;
            //        Console.WriteLine("The average score of your students is {0}", average);
            //    }

            //    if(int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber <21)
            //    {
            //        total += currentNumber;
            //    }
            //    else
            //    {
            //        if(!input.Equals("-1"))
            //        {
            //            Console.WriteLine("Please enter a value between 1 and 20!");
            //        }
            //        continue;
            //    }

            //    count++;

            //}
    */

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
                Console.WriteLine("Please insert grade for student number {0}", (count+1));
                bool success = Double.TryParse(Console.ReadLine(), out input);
                if(success)
                {
                    count++;
                    if((input == -1) || (input < 0) || (input > 20))
                    {
                        Console.WriteLine("Stopped execution either by will or invalid value");
                        break;
                    }
                    grade += input;
                    continue;
                }
                Console.WriteLine("Please insert a valid value that goes from 0 to 20");
            }
            Console.WriteLine("Grade total: {2}\n Average for class with {0} students, is {1:0.00}", count, (grade / count), grade);

        }


    }
}
