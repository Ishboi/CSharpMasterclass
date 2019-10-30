using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeT
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime dateTime = new DateTime(1992, 5, 31);

            Console.WriteLine("My birthday is {0}", dateTime);

            // Write today on screen
            Console.WriteLine(DateTime.Today);
            // Write current time on screen
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow ill be the {0}", tomorrow);
            Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);
            Console.WriteLine(GetFirstDayOfYear(1999));

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in Feb 2000: {0}", days);
            days = DateTime.DaysInMonth(2001, 2);
            Console.WriteLine("Days in Feb 2001: {0}", days);
            days = DateTime.DaysInMonth(2004, 2);
            Console.WriteLine("Days in Feb 2004: {0}", days);

            DateTime now = DateTime.Now;
            Console.WriteLine("{0} o'clock {1} minutes and {2} seconds.", now.Hour, now.Minute, now.Second);

            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            daysPassed(input, dateTime);


        }


        static void daysPassed(string input, DateTime dateTime)
        {
            DateTime now = DateTime.Now;
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("You are {0} days old", daysPassed.Days);
            } else
            {
                Console.WriteLine("Wrong input format");
            }

        }


        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }

    }
}
