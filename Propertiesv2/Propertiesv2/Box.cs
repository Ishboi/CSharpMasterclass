using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertiesv2
{
    class Box
    {
        // member variable
        private int length = 3;
        private int height;
        //public int width;
        private int volume;

        public int Width { get; set; }

        //public int Width // same as above
        //{
        //    get
        //    {
        //        return this.width;
        //    }
        //    set
        //    {
        //        this.width = value;
        //    }
        //}

        //public int Length { get; set; }
        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if(value < 0)
                {
                    height = -value;
                } else
                {
                    height = value;
                }
            }
        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.Width = width;
        }


        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }
        public int GetLength()
        {
            return this.length;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}",
                length, height, Width, volume = length*height*Width);
        }



    }
}
