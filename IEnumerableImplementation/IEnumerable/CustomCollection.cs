using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableTest
{
    public class CustomCollection<T> : IEnumerable<T>
    {
        List<T> lista = new List<T>();

        public CustomCollection()
        {

        }

        public void Add(T d)
        {
            lista.Add(d);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CustomCollectionEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public T[] GetAll()
        {
            return lista.ToArray<T>();
        }
    }
}
