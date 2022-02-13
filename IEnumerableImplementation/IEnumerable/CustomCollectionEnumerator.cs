using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableTest
{
    public class CustomCollectionEnumerator<T> : IEnumerator<T>
    {
        private CustomCollection<T> currentData = null;
        private T currentItem = default(T);
        private Queue<T> enumData = null;

        public T Current
        {
            get
            {
                if (this.enumData == null)
                    throw new InvalidOperationException
                    ("Use MoveNext before calling Current");

                return this.currentItem;
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (this.enumData == null)
            {
                this.enumData = new Queue<T>();
                populate(this.enumData, this.currentData);
            }
            if (this.enumData.Count > 0)
            {
                this.currentItem = this.enumData.Dequeue();
                return true;
            }
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public CustomCollectionEnumerator(CustomCollection<T> data)
        {
            this.currentData = data;
        }

        private void populate(Queue<T> enumQueue, CustomCollection<T> cc)
        {
            T[] array = cc.GetAll();
            for(int i = 0; i< array.Length; i++)
            {
                enumQueue.Enqueue(array[i]);
            }
        }
    }
}
