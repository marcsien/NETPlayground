using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapePrototypeExample
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            type = "Rectangle";
        }

        public override object Clone()
        {
            Object clone = null;

            try
            {
                clone = this.MemberwiseClone();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return clone;
        }

        public override void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }

    }
}
