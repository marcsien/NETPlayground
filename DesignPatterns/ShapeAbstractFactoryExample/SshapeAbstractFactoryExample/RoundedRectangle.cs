using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAbstractFactoryExample
{
    internal class RoundedRectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing RoundedRectangle");
        }
    }
}
