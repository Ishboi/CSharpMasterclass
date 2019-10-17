using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {

        public const int highscore = 0;
        public const string highscorePlayer = "Fabio";
        static void Main(string[] args)
        {

            int age = 25;

            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
                
            }

            if(age == 15)
            {
                Console.WriteLine("Too young to party in the club!");
            } else if(age == 25)
            {
                Console.WriteLine("Good to go!");
            } else
            {
                Console.WriteLine("How old are you then?");
            }

            string username = "Fabio";
            switch(username)
            {
                case "Fabio":
                    Console.WriteLine("username is Fabio");
                    break;
                case "root":
                    Console.WriteLine("username is root");
                    break;
                default:
                    Console.WriteLine("username is unknown");
                    break;
            }
            Console.Write("Name for concurrent: ");
            string holderInput = Console.ReadLine();
            Console.WriteLine("Score of concurrent: ");
            int holderScore = Int32.Parse(Console.ReadLine());
            whichHigher(holderScore, holderInput);

            Console.Read();

        }


        public static void whichHigher(int score, string playerName)
        {
            if(score > highscore)
            {
                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("New highscore holder is " + playerName);
                return;
            }
            Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
        }


    }
}
