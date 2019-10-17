using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What's the temperature like?");
            //string temperature = Console.ReadLine();
            //int numTemp;
            //bool success = int.TryParse(temperature, out numTemp) ? true : false; // jus testing for ternary not really usefull

            //int number;
            //if(int.TryParse(temperature, out number))
            //{
            //    numTemp = number;
            //} else
            //{
            //    numTemp = 0;
            //    Console.WriteLine("Value entered, was no number. 0 set as temperature");
            //}

            //if (numTemp < 20)
            //{
            //    Console.WriteLine("Take the coat");
            //} else if (numTemp == 20)
            //{
            //    Console.WriteLine("Pants and Pull Over should be fine");
            //}else if(numTemp == 30) {
            //    Console.WriteLine("It's super hot!");
            //} else
            //{
            //    Console.WriteLine("Shorts are enough today");
            //}


            string userName = Register("username");
            string password = Register("password");

            bool isAdmin = false;
            bool isRegistered = Login(userName, password);
            if(isRegistered)
            {
                Console.WriteLine("Welcome " + userName);
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Please register first");
            Console.ReadKey();




            //if (isRegistered && userName != "" && userName.Equals("admin"))
            //{
            //    Console.WriteLine("Hi there, registered user");
            //    Console.WriteLine("Hi there, " + userName);
            //    Console.WriteLine("Hi there, Admin");
            //}
            //if(isAdmin || isRegistered)
            //{
            //    Console.WriteLine("You are logged in");
            //}

            Console.ReadKey();
        }

        public static string Register(String userOrPassword)
        {
            Console.WriteLine("Please enter your " + userOrPassword);
            string userAndPassword = Console.ReadLine();
            return userAndPassword;

        }

        public static bool Login(string username, string password)
        {
            Console.WriteLine("Login\nUsername: ");
            string registeredUser = Console.ReadLine();
            Console.WriteLine("Password: ");
            string registeredUserPassword = Console.ReadLine();
            return registeredUser.Equals(username) && registeredUserPassword.Equals(password);
        }
    }
}
