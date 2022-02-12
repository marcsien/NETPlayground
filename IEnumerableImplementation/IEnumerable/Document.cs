using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableTest
{
    public class Document
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public DateTime AddedTime { get; set; }

        public Document()
        {
        }

        public Document(int i,string n)
        {
            this.Number = i;
            this.Name = n;
            this.AddedTime = DateTime.Now;
        }

        public Document(bool b)
        {
            if(b == false)
            {
                Random r = new Random();
                this.Number = r.Next(0, 1000);
                this.Name = RandomString(5);
                this.AddedTime = DateTime.Now;
            }
        }

        private string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
