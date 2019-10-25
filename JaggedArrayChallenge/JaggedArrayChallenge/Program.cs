using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] joesFamily = new string[] { "Martha", "Robert" };

            string[][] friends = new string[][] {
                new string[] {"sandra", "pai", "tobias"},
                new string[] {"daniel", "teresa", "Sao"},
                new string[] {"raquel", "andre", "sandra2"},
                joesFamily
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you", friends[0][0], friends[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you", friends[0][1], friends[2][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you", friends[0][1], friends[2][1]);
            Console.ReadKey();

            // his solution
        }


        //    while(true)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Type exit to quit.");
        //        Console.Write("Introduce who > ");
        //        string friend1 = Console.ReadLine();
        //        Console.Write(" to whom > ");
        //        string friend2 = Console.ReadLine();
        //        if (friend1.ToUpper().Equals("EXIT") || friend2.ToUpper().Equals("EXIT"))
        //        {
        //            return;
        //        }
        //        if (!findFriend(friends, friend1) || !findFriend(friends,friend2))
        //        {
        //            Console.WriteLine("Friend doesn't exist. Please try again.");
        //            Console.ReadKey();
        //            Console.Clear();
        //            continue;
        //        }
        //        Console.WriteLine("{0} this is {1}", friend1, friend2);
        //        Console.ReadKey();
        //    }
        //}
        //public static bool findFriend(string[][] friends, string friend)
        //{

        //    for (int i = 0; i < friends.Length; i++)
        //    {
        //        foreach(string value in friends[i])
        //        {
        //            if(friend.ToUpper().Equals(value.ToUpper()))
        //            {
        //                return true;
        //            }
        //        }
        //    }

        //    return false;
        //} 
    }



}
