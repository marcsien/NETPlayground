using System;

namespace ShapePrototypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype pattern demo");

            ShapeCache cache = new ShapeCache();
            cache.LoadCache();

            Shape clonedShape1 = (Shape)cache.GetShape("1");
            Console.WriteLine("Cloned Shape : " + clonedShape1.GetType());

            Shape clonedShape2 = (Shape)cache.GetShape("2");
            Console.WriteLine("Cloned Shape : " + clonedShape2.GetType());
        }
    }
}
