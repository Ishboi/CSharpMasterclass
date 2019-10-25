using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC2
{
    class Boss : Employee
    {

        public string CompanyCar { get; set; }
        public bool Leading { get; set; }
        public Boss() { }
        
        public Boss(string firstName, string lastName, int salary, string companycar)
        {
            this.FirstName = firstName;
            this.Name = FirstName + lastName;
            this.Salary = salary;
            this.CompanyCar = companycar;
        }

        public override string ToString()
        {
            return String.Format("This is the boss of this company he leads and works here.");
        }

    }
}
