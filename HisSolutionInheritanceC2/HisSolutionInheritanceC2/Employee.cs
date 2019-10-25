using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisSolutionInheritanceC2
{
    class Employee
    {

        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string firstsName, int salary)
        {
            this.Name = name;
            this.FirstName = firstsName;
            this.Salary = salary;
        }

        public Employee()
        {
            Name = "C";
            FirstName = "Fabio";
            Salary = 50000;
        }
        
        public void Work()
        {
            Console.WriteLine("I'm working");
        }

        public void Pause()
        {
            Console.WriteLine("I'm having a break");
        }




    }
}
