using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d{5}";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 12314";

            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine("{0} hits found:\n {1}", matchCollection.Count, text);

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }
            

        }
    }
}
