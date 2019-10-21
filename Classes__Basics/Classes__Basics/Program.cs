using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes__Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object of my class
            // an instance of human
            Human denis = new Human("tobias", "sissy", "brown", 8);
            Human tobias = new Human("sdafsdfs", "asdad", "dasdsa", 2131);

            // access public variable from outside, and even change it
            //denis.firstName = "Denis";
            // call methods of the class
            denis.IntroduceMyself();

            Human michael = new Human("rocky", "badbird", "gray");
            //michael.firstName = "Mikel";
            michael.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human Natalie = new Human("Natalie");
            Natalie.IntroduceMyself();

            Human michaelHere = new Human("Michal", "Here");
            michaelHere.IntroduceMyself();

            Human frank = new Human("Frank", "Walter", 25);
            frank.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
