using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciTester
{
    public class FibonacciGenerator : IFibonacciGenerator
    {
        public int Nth { get; set; }

        private int nthvalue = default;
        public int NthValue => nthvalue;

        public string Name { get; set; }

        public Func<int, int> fib;

        public FibonacciGenerator(string name, Func<int, int> fib)
        {
            Name = name;
            this.fib = fib;
        }

        public void Calculate()
        {
            nthvalue = fib(Nth);
        }
    }
}
