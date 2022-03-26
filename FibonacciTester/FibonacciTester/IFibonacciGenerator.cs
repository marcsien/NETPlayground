using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciTester
{
    public interface IFibonacciGenerator
    {   
        public void Calculate();
        int Nth
        {
            get;
            set;
        }
        int NthValue
        {
            get;
        }
        string Name { get; set; }

    }
}
