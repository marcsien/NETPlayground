using System;

namespace IEnumerableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomCollection<Document> collection = new CustomCollection<Document>();
            for (int i = 0; i<5; i++)
            {
                collection.Add(new Document(false));
            }


            foreach(var d in collection)
            {
                Console.WriteLine(d.Name +" "+ d.Number + " " +d.AddedTime);
            }
        }
    }
}
