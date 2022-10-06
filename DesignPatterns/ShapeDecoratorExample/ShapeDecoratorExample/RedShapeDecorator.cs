using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDecoratorExample
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        {
        }
        public override void Draw()
        {
            base.Draw();
            setRedBorder(decoratedShape);
        }

        private void setRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
