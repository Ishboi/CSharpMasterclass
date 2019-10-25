using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC2
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee("Danny", "Jesus", 1750);
            Boss boss1 = new Boss("Pedro", "Satanas", 1200, "Rolls Royce");
            Trainees trainee1 = new Trainees("Fabio", "Poor", 500);

            trainee1.Work();
            Console.WriteLine("Press any key so trainee can stop working.");
            Console.ReadKey();
            trainee1.Pause();
            Console.WriteLine("Trainee worked for {0} hours", trainee1.Workinghours);

            Console.ReadKey();

        }
    }
}
