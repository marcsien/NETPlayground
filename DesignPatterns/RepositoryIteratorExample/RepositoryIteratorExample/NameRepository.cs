using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryIteratorExample
{
    public class NameRepository : IContainer
    {
        public static string[] names = { "Marcin", "Kasia", "Daniel", "Łukasz" };
        public IIterator getIterator()
        {
            return new NameIterator();
        }

        private class NameIterator : IIterator
        {
            int index;
            public bool hasNext()
            {
                if (index < names.Length)
                {
                    return true;
                }
                return false;
            }

            public object next()
            {
                if (this.hasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }
    }
}
