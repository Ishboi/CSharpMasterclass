using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqWithXML
{
    class Program
    {
        static void Main(string[] args)
        {

            //We simply apply our Student Structure to XML.
            string studentsXML =
                @"<Students>
                    <Student>
                        <Name>Toni</Name>
                        <Surname>Das Couves</Surname>
                        <Age>21</Age>
                        <University>Yale</University>
                    </Student>
                    <Student>
                        <Name>Carla</Name>
                        <Surname>Santos</Surname>
                        <Age>17</Age>
                        <University>Yale</University>
                    </Student>
                    <Student>
                        <Name>Leyla</Name>
                        <Surname>Futurama</Surname>
                        <Age>19</Age>
                        <University>Beijing Tech</University>
                    </Student>
                    <Student>
                        <Name>New</Name>
                        <Surname>Student</Surname>
                        <Age>0</Age>
                        <University>New University</University>
                    </Student>
                </Students>";

            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Surname = student.Element("Surname").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value
                           };
            var studentsSortedByAge = from student in students 
                              orderby student.Age 
                              select student;

            foreach (var student in studentsSortedByAge)
            {
                Console.WriteLine("Student {0} {3} with age {1} from University {2}", student.Name, student.Age, student.University, student.Surname);
            }



            Console.ReadLine();

        }
    }
}
