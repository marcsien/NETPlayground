using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ShapePrototypeExample
{
    public class ShapeCache
    {
        private static Dictionary<string, Shape> shapeMap = new Dictionary<string, Shape>();

        public Shape GetShape(string shapeId)
        {
            Shape cachedShape = shapeMap[shapeId];
            return (Shape)cachedShape.Clone();
        }

        public void LoadCache()
        {
            Square square = new Square();
            square.SetId("1");
            shapeMap.Add(square.GetId(), square);

            Rectangle rectangle = new Rectangle();
            rectangle.SetId("2");
            shapeMap.Add(rectangle.GetId(), rectangle);
        }
    }
}
