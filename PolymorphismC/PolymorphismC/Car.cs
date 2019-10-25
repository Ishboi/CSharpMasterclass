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

        // has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();
        
        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and is owned by {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }

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
