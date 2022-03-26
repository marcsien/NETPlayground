using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciTester
{
    public class FibonacciTimer<T> where T : IFibonacciGenerator
    {
        private int nthElement;

        private List<T> list = new List<T>();
        private SortedList<long, T> results = new SortedList<long, T>();
        public FibonacciTimer(int nthelement)
        {
            this.nthElement = nthelement;
        }

        public void AddNew(T item)
        {
            this.list.Add(item);
        }

        public void Run()
        {
            foreach (var obj in list)
            {
                obj.Nth = nthElement;
                Stopwatch stopwatch = Stopwatch.StartNew();
                obj.Calculate();
                stopwatch.Stop();
                results.Add(stopwatch.ElapsedTicks, obj);
            }
        }
        public void DisplayResults()
        {
            foreach (var r in results)
            {
                Console.WriteLine($"Method : {r.Value.Name} took {r.Key} ticks to calculate {r.Value.Nth}th fibonacci sequence value with calculated value :{r.Value.NthValue}");
            }
        }
    }
}
