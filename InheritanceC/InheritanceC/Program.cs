using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class Program
    {
        static void Main(string[] args)
        {

            Post post1 = new Post("Thanks for the birthday wishes", true, "Fabio C");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Fabio C", 
                "https://images.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());
            Console.ReadKey();


        }
    }
}
