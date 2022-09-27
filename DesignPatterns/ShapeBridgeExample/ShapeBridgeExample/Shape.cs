using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeBridgeExample
{
    public abstract class Shape
    {
        protected DrawAPI drawAPI;

        protected Shape(DrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }
        public abstract void draw();
    }
}
