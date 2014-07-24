Functify
========

A C# extension library that allows users to compose and curry Func&lt;> and Action&lt;> delegate instances at runtime.

You can grab the NuGet package here: https://www.nuget.org/packages/Functify/

Here's an example of how you can use it: 

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
        }
    }
