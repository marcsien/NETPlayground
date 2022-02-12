using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableTest
{
    public class CustomCollection
    {
        List<Document> lista = new List<Document>();

        public CustomCollection()
        {

        }

        public void Add(Document d)
        {
            lista.Add(d);
        }

        public void OutAll()
        {
            foreach(var l in lista)
            {
                Console.WriteLine(l.Name + " " + l.Number.ToString() + " " + l.AddedTime.ToString());
            }
        }

    }
}
