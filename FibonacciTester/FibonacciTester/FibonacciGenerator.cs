using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciTester
{
    public class FibonacciGeneratorEventArg : EventArgs
    {
        public FibonacciGenerator fibonacciGenerator { get; set; }
    }
    public class FibonacciGenerator : IFibonacciGenerator
    {
        public event EventHandler<FibonacciGeneratorEventArg> FibonacciCalculated;

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
            onFibonacciCalculated();
        }
        
        protected virtual void onFibonacciCalculated()
        {
            if (FibonacciCalculated != null)
            {
                FibonacciCalculated(this, new FibonacciGeneratorEventArg() { fibonacciGenerator = this });
            }
        }
    }
}
