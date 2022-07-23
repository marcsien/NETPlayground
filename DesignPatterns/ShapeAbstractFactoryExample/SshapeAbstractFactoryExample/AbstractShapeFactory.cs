using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAbstractFactoryExample
{
    internal abstract class AbstractShapeFactory
    {
        public abstract IShape GetShape(String shapeType);
    }
}