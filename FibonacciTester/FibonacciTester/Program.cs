using System;
using System.Threading;

namespace FibonacciTester
{
    public class FibonacciCalculatedNotifier
    {
        public void onFibonacciCalculated(object source, FibonacciGeneratorEventArg arg)
        {
            Console.WriteLine($"Calculating with {arg.fibonacciGenerator.Name} algorithm completed.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciTimer<FibonacciGenerator> timer = new FibonacciTimer<FibonacciGenerator>(30);
            FibonacciCalculatedNotifier notifier = new FibonacciCalculatedNotifier();

            FibonacciGenerator f1 = new FibonacciGenerator("IterationAsLambda", (n) => {
                int a = 0, b = 1, t = 1;
                for (int i = 0; i < n; i++)
                {
                    t = a;
                    a = a + b;
                    b = t;
                }
                return a;
            });
            timer.AddNew(f1);

            FibonacciGenerator f2 = new FibonacciGenerator("RecursiveAsProgramClassMethod", n => Program.FibRecursive(n));
            timer.AddNew(f2);

            FibonacciGenerator f3 = new FibonacciGenerator("RecursiveOneLineAsProgramClassMethod", n => Program.FibRecursiveOneLine(n));
            timer.AddNew(f3);

            FibonacciGenerator f4 = new FibonacciGenerator("IterationAsProgramClassMethod", n => Program.FibIteration(n));
            timer.AddNew(f4);

            FibonacciGenerator f5 = new FibonacciGenerator("Recursive AsLambda", (n) => {
                Func<int, int> fact = null;
                fact = x => (x <= 1) ? x : fact(x - 2) + fact(x - 1);
                return fact(n);
            });
            timer.AddNew(f5);


            f1.FibonacciCalculated += notifier.onFibonacciCalculated;
            f2.FibonacciCalculated += notifier.onFibonacciCalculated;
            f3.FibonacciCalculated += notifier.onFibonacciCalculated;
            f4.FibonacciCalculated += notifier.onFibonacciCalculated;
            f5.FibonacciCalculated += notifier.onFibonacciCalculated;

            timer.Run();
            timer.DisplayResults();
        }

        public static int FibRecursive(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return FibRecursive(n - 2) + FibRecursive(n - 1);
            }
        }

        public static int FibRecursiveOneLine(int n)
        {
            return (n <= 2) ? 1 : FibRecursiveOneLine(n - 1) + FibRecursiveOneLine(n - 2);
        }

        public static int FibIteration(int n)
        {
            int a = 0, b = 1, t = 1;
            for (int i = 0; i < n; i++)
            {
                t = a;
                a = a + b;
                b = t;
            }
            return a;
        }
    }
}
