using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapePrototypeExample
{
    public abstract class Shape : ICloneable
    {
        private string id;
        protected string type;

        public abstract void Draw();

        public string GetType()
        {
            return type;
        }

        public string GetId()
        {
            return id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public abstract object Clone();
    }
}
