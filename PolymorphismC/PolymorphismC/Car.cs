using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class Car
    {

        protected int HP { get; set; }
        protected string Color { get; set; }

        public Car()
        {
            this.HP = 0;
            this.Color = "default";
        }

        public Car(int horsePower, string color)
        {
            this.HP = horsePower;
            this.Color = color;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("This car is {0} and has {1} horsepower", Color, HP);
        }

        public virtual void RepairCar()
        {
            Console.WriteLine("Car was repaired!");
        }
        

    }
}
