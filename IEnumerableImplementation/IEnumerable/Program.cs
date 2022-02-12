using System;

namespace IEnumerableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomCollection collection = new CustomCollection();
            for (int i = 0; i<100; i++)
            {
                collection.Add(new Document(false));
            }
            collection.OutAll();


            foreach(var d in collection)
            {

            }
        }
    }
}
