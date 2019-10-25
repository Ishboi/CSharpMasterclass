using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InheritanceC2
{
    class Trainees : Employee
    {
        public int Workinghours { get; set; }
        public int SchoolHours { get; set; }
        public bool Learning { get; set; }

        Timer timer;

        public Trainees(string firstName, string lastName, int salary)
        {
            this.ID = GetNextID();
            this.FirstName = firstName;
            this.Name = FirstName + lastName;
            this.Salary = salary;

        }

        public void Learn()
        {
            if(Working)
            {
                Working = false;
            }
            Learning = true;
        }

        new public void Work()
        {
            if(!Working)
            {
                Working = true;
                Console.WriteLine("{0} stared his work", this.Name);
                timer = new Timer(TraineeWorking, null, 0, 1000);
            } else
            {
                Console.WriteLine("Already working here");
            }
        }

        public void TraineeWorking(Object o)
        {
            Workinghours++;
            Console.WriteLine("Currently trainee is working for {0} hours", Workinghours);
            GC.Collect();
        }

        new public void Pause()
        {
            timer.Dispose();
        }


        public override string ToString()
        {
            return String.Format("This person works here and is having a traineeship here");
        }

    }
}
