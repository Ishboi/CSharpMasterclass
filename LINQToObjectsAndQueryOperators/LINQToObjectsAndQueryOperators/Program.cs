using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectsAndQueryOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            UniversityManager um = new UniversityManager();

            um.GenderStudents("male");
            um.GenderStudents("female");

            Console.ReadKey();

        }
    }

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        // constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            // Let's add some Universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            //Let's add some Students
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });

        }

        public void GenderStudents(string gender)
        {
            IEnumerable<Student> genderStudents;
            if (gender.ToUpper().Equals("MALE"))
            {
                 genderStudents = from student in students where student.Gender == "male" select student;
            } else if(gender.ToUpper().Equals("FEMALE"))
            {
                genderStudents = from student in students where student.Gender == "female" select student;
            } else
            {
                genderStudents = from student in students where student.Gender == "trans-gender" select student;
            }
            Console.WriteLine("Male - Student: ");

            foreach(Student student in genderStudents)
            {
                student.Print();
            }
        }

    }


    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public void Print()
        {
            Console.WriteLine("University {0} with id {1}", Name, Id);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // Foreign Key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1}, Gender {2} and Age {3} from University with the Id {4}", Name, Id, Gender, Age, UniversityId);

        }
    }


}
