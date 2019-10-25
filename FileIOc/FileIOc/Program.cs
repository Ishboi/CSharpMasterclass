using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 1
            string[] lines = { "first line", "second line", "Third line" };
            string[] highScore = { "250", "350", "1000" };

            File.WriteAllLines(@"..\..\..\..\highscore.txt", highScore);
            File.WriteAllLines(@"..\..\..\..\ficheiroDeTexto2.txt", lines);
            /*
            // Method 2
            Console.WriteLine("Please give the file a name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file");
            string input = Console.ReadLine();
            File.WriteAllText(@"..\..\..\..\" + fileName + ".txt", input);
            */

            // Method 3
            using(StreamWriter file = new StreamWriter(@"..\..\..\..\streamWriterText.txt"))
            {
                foreach(string line in highScore)
                {
                    if(line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"..\..\..\..\streamWriterText.txt", true))
            {
                file.WriteLine("Additional line appended");
            }



            /*
            // Example 1 - reading text
            string text = System.IO.File.ReadAllText(@"..\..\..\..\ficheiroDeTexto");

            Console.WriteLine("Textfile contains following text: {0}", text);

            string[] lines = System.IO.File.ReadAllLines(@"..\..\..\..\ficheiroDeTexto");

            Console.WriteLine("Contents of textfile = ");
            foreach(string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            */



            Console.ReadKey();

        }
    }
}
