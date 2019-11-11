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
            um.SortStudentsByAge();
            um.AllStudentsFromBeijingTech();
            //um.AllStudentsFromInput();
            um.StudentAndUniversityNameCollection();

            /*
            int[] someInts = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            foreach(int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;

            foreach(int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }




            // this try catch is part of his solution
            string input = Console.ReadLine();
            try
            {
                int inputAsInt = Convert.ToInt32(input);
                um.AllStudentsFromThatUni(inputAsInt);
            }
            catch (Exception)
            {

                Console.WriteLine("Wrong Value");
            }
            */

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
            students.Add(new Student { Id = 3, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 6, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });

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

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Students sorted by Age:");
            foreach(Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromBeijingTech()
        {
            IEnumerable<Student> bjtStudents = from student in students
                                               join university in universities
                                               on student.UniversityId equals university.Id
                                               where university.Name == "Beijing Tech"
                                               select student;

            Console.WriteLine("Students from Beijing Tech");
            foreach(Student student in bjtStudents)
            {
                student.Print();
            }

        }

        public void AllStudentsFromInput()
        {
            int universityId = 0;
            IEnumerable<Student> universityStudents;
            IEnumerable<University> universityName;
            Console.Write("Enter the id for university > ");
            if(Int32.TryParse(Console.ReadLine(), out universityId))
            {
                universityStudents = from student in students 
                                     join university in universities 
                                     on student.UniversityId equals university.Id 
                                     where university.Id == universityId 
                                     select student;
                universityName = from university in universities
                                 where university.Id == universityId
                                 select university;
            } else
            {
                Console.WriteLine("Please use a numeric format.");
                AllStudentsFromInput();
                return;
            }
            if(universityStudents.Count() > 0)
            {
                Console.WriteLine("\nStudents from {0}\n", universityName.ElementAt(0).Name);
                foreach (Student student in universityStudents)
                {
                    student.Print();
                }
                return;
            }
            Console.WriteLine("Please enter a valid id number");
            AllStudentsFromInput();

        }

        // His method below
        public void AllStudentsFromThatUni(int Id)
        {


            IEnumerable<Student> bjtStudents = from student in students
                                               join university in universities
                                               on student.UniversityId equals university.Id
                                               where university.Id == Id
                                               select student;

            Console.WriteLine("Students from that uni {0}", Id);
            foreach (Student student in bjtStudents)
            {
                student.Print();
            }

        }

        public void StudentAndUniversityNameCollection()
        {

            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collection: ");

            foreach(var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", col.StudentName, col.UniversityName);
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
