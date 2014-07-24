using System;
using System.Collections.Generic;
using System.Linq;
using Functify;

namespace FunctionalDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Currying example:
            Func<int, int, int> multiply = (a, b) => a*b;

            // This is equivalent to calling multiply(int a) with b = 2
            var timesTwo = multiply.Bind(2);

            // This will print "4"
            Console.WriteLine(timesTwo(2));

            // Method chaining example:
            Action<string> writeLine = Console.WriteLine;

            // Combine the writeLine call from two separate calls
            // into a single Action delegate
            var helloWorld = writeLine.Bind("Hello, ")
                .Then(writeLine.Bind("World!"));

            helloWorld();

            // Convert multiple functions with same input to a single function with multiple outputs
            Func<int, int> incr = x => x + 1;
            var fns = new[] {incr, timesTwo}.Sequence();
            Show(fns(10)); // writes "11,20"

            // Compose with LINQ
            var f =
                from next in incr
                from dbl in timesTwo
                select Tuple.Create(next, dbl);
            var showF = f.Select(x => x.ToString());
            writeLine(showF(10)); // writes "(11, 20)"

            Console.ReadKey();
        }

        private static void Show<T>(IEnumerable<T> values)
        {
            Console.WriteLine(String.Join(", ", values.Select(x => x.ToString())));
        }
    }
}
