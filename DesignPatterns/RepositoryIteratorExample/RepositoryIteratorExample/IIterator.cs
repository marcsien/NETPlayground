using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryIteratorExample
{
    public interface IIterator
    {
        public bool hasNext();
        public object next();
    }
}
