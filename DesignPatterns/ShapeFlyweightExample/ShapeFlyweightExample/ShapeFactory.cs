using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFlyweightExample
{
    public class ShapeFactory
    {
        private static Dictionary<string,Circle> circleDictionary = new Dictionary<string, Circle>();

        public static IShape GetCircle(string color)
        {
            if (circleDictionary.ContainsKey(color))
            {
                Circle foundcircle = circleDictionary[color];
                return foundcircle;
            }

            Circle circle = new Circle(color);
            circleDictionary.Add(color, circle);
            Console.WriteLine("Creating circle of color : " + color);

            return circle;
        }
    }
}
