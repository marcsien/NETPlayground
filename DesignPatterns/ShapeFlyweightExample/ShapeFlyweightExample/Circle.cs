using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFlyweightExample
{
    internal class Circle : IShape
    {
        private string color;
        private int x;
        private int y;
        private int radius;

        public Circle(string color)
        {
            this.color = color;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public void setRadius(int radius)
        {
            this.radius = radius;
        }
        public void Draw()
        {
            Console.WriteLine("Circle: Draw() [Color : " + color + ", x : " + x + ", y :" + y + ", radius :" + radius);
        }
    }
}
