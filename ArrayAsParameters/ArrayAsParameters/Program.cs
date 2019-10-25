using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAsParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentsGrades);

            foreach(int grade in studentsGrades)
            {
                Console.WriteLine(" {0} ", grade);
            }

            Console.WriteLine("The average is: {0}", averageResult);

            int[] happiness = { 10, 5, 13, 19 };
            SunIsShining(happiness);
            
            foreach(int value in happiness)
            {
                Console.WriteLine("Increased argument is {0}", value);
            }
            Console.ReadKey();
            
        }

        static int[] SunIsShining(int[] value)
        {
            for(int i = 0; i<value.Length; i++)
            {
                value[i] += 2;
            }
            return value;
        }


        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for(int i = 0; i< size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size;
            return average;
        }
    }
}
