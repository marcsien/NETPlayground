using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFacadeExample
{
    public class ShapeMakerFacade
    {
        private IShape circle;
        private IShape rectangle;
        private IShape square;

        public ShapeMakerFacade()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void drawCircle()
        {
            circle.Draw();
        }
        public void drawRectangle()
        {
            rectangle.Draw();
        }
        public void drawSquare()
        {
            square.Draw();
        }
    }
}