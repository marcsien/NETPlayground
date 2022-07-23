using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAbstractFactoryExample
{
    internal class ShapeFactory : AbstractShapeFactory
    {
        public override IShape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }

            if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
            {
                return new Square();
            }
            else if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
            {
                return new Rectangle();
            }

            return null;
        }
    }
}
