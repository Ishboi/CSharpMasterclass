﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Configuration;

namespace LinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LinqToSqlDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.FabioCsharpDBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            //InsertUniversities();
            //InsertStudents();
            //InsertLectures();
            //InsertStudentLectureAssociations();
            //GetUniversityOfTonie();
            //GetLecturesFromTonie();
            //GetAllStudentsFromYale();
            //GetAllUniversitiesWithTransgenders();
            //GetLecturesTaughtAtIST();
            //UpdateTonie();
            DeleteJame();

        }

        public void InsertStudents()
        {
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            // the above is the same as below with the lambda(=>) expression
            //"from university in dataContext.University where university == "Yale" select university"
            University ist = dataContext.Universities.First(un => un.Name.Equals("IST"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carla", Gender = "Female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Tonie", Gender = "Male", University = yale });
            students.Add(new Student { Name = "Leyle", Gender = "Female", University = ist });
            students.Add(new Student { Name = "Jame", Gender = "trans", University = ist });

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("delete from University");
            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);
            University ist = new University();
            ist.Name = "IST";
            dataContext.Universities.InsertOnSubmit(ist);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }


        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssociations()
        {

            Student Carla = dataContext.Students.First(st => st.Name.Equals("Carla"));
            Student Tonie = dataContext.Students.First(st => st.Name.Equals("Tonie"));
            Student Leyle = dataContext.Students.First(st => st.Name.Equals("Leyle"));
            Student Jame = dataContext.Students.First(st => st.Name.Equals("Jame"));

            Lecture Math = dataContext.Lectures.First(lec => lec.Name.Equals("Math"));
            Lecture History  = dataContext.Lectures.First(lec => lec.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Tonie, Lecture = Math });

            // below is another way of inserting data on a associative table
            StudentLecture slTonie = new StudentLecture();
            slTonie.Student = Tonie;
            slTonie.LectureId = History.Id;
            dataContext.StudentLectures.InsertOnSubmit(slTonie);

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Leyle, Lecture = History });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;

        }

        public void GetUniversityOfTonie()
        {
            Student Tonie = dataContext.Students.First(st => st.Name.Equals("Tonie"));

            University ToniesUniversity = Tonie.University;

            List<University> universities = new List<University>();
            universities.Add(ToniesUniversity);

            MainDataGrid.ItemsSource = universities;
        }

        public void GetLecturesFromTonie()
        {
            Student Tonie = dataContext.Students.First(st => st.Name.Equals("Tonie"));

            var ToniesLectures = from sl in Tonie.StudentLectures select sl.Lecture;
            //"from university in dataContext.University where university == "Yale" select university"

            MainDataGrid.ItemsSource = ToniesLectures;

        }

        public void GetAllStudentsFromYale()
        {
            var studentsFromYale = from student in dataContext.Students
                                   where student.University.Name == "Yale"
                                   select student;

            MainDataGrid.ItemsSource = studentsFromYale;
        }

        public void GetAllUniversitiesWithTransgenders()
        {
            var transgenderUniversities = from student in dataContext.Students
                                          join university in dataContext.Universities
                                          on student.University equals university
                                          where student.Gender == "trans"
                                          select university;
            MainDataGrid.ItemsSource = transgenderUniversities;
        }

        public void GetLecturesTaughtAtIST()
        {
            var lecturesFromIST = from studentLecture in dataContext.StudentLectures
                                  join student in dataContext.Students
                                  on studentLecture.StudentId equals student.Id
                                  where student.University.Name == "IST"
                                  select studentLecture.Lecture;
            MainDataGrid.ItemsSource = lecturesFromIST;
        }

        public void UpdateTonie()
        {
            Student Tonie = dataContext.Students.FirstOrDefault(st => st.Name == "Tonie");

            Tonie.Name = "Antonio";

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void DeleteJame()
        {
            Student Jame = dataContext.Students.FirstOrDefault(st => st.Name == "Jame");
            dataContext.Students.DeleteOnSubmit(Jame);
            dataContext.SubmitChanges();

            //MainDataGrid.ItemsSource = dataContext.Students;
            // bellow is in case you run into an error
            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.FabioCsharpDBConnectionString"].ConnectionString;

            LinqToSqlDataClassesDataContext db = new LinqToSqlDataClassesDataContext(connectionString);

            MainDataGrid.ItemsSource = db.Students;


        }



    }
}
