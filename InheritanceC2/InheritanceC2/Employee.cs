using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC2
{
    class Employee
    {
        //bool isWorking = false;
        private static int currentId;

        protected int ID { get; set; }
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }
        protected bool Working { get; set; }
        protected int TimeWorking { get; set; }

        public Employee()
        {
            GetNextID();
        }
        
        public Employee(string firstName, string lastName, int salary)
        {
            this.ID = GetNextID();
            this.FirstName = firstName;
            this.Name = FirstName + lastName;
            this.Salary = salary;
        }

        protected int GetNextID()
        {
            return ++currentId;
        }


        public void Work()
        {
            Working = true;
        }

        public void Pause()
        {
            Working = false;
        }

        public override string ToString()
        {
            return String.Format("This person works here");
        }


    }
}
