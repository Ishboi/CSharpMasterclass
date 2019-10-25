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

            VideoPost video1 = new VideoPost("Art of programming", true, "Master programmer",
                "https://youtube.com/watch?v=gfd3443gY", 30);
            
            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(video1.ToString());

            video1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            video1.Stop();

            Console.ReadKey();


        }
    }
}
