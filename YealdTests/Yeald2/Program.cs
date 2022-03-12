using System;
using System.Collections.Generic;

namespace Yeald2
{
    class Program
    {
        static List<int> MyList = new List<int>();
        static void Main(string[] args)
        {
            FillMyList();
            foreach (var item in RunningTotal())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static IEnumerable<int> RunningTotal()
        {
            int runningTotal = 0;
            foreach (var item in MyList)
            {
                runningTotal += item;
                yield return runningTotal;
            }
        }
        static void FillMyList()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
        }
    }
}
