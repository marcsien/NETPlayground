using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProxyExample
{
    public class RealImage : IImage
    {
        private String fileName;
        public RealImage(string fileName)
        {
            this.fileName = fileName;
            loadFromDisk(fileName);
        }
        public void Display()
        {
            Console.WriteLine("Displaying " + fileName);
        }

        private void loadFromDisk(String fileName)
        {
            Console.WriteLine("Loading " + fileName);
        }
    }
}