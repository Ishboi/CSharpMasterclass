using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    // a BMW is a Car

    class BMW:Car
    {
        string brand = "BMW";

        public string Model { get; set; }

        public BMW(int hp, string color, string model)
            : base(hp, color)
        {
            this.Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine("This {0} {1} is {2} and has {3} horsepower", this.brand, this.Model, Color, HP);
        }
        public sealed override void RepairCar()
        {
            Console.WriteLine("{0} {1} was repaired!", this.brand, this.Model);
        }

    }
}
