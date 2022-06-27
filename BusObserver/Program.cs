using System;

namespace BusObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1.0;
            var b = 3.0;

            var result = CppHandlerWrapper.Add(a, b);
            Console.WriteLine($"a + b = {result}");

            result = CppHandlerWrapper.Subtract(a, b);
            Console.WriteLine($"a - b = {result}");

            result = CppHandlerWrapper.Multiply(a, b);
            Console.WriteLine($"a * b = {result}");

            result = CppHandlerWrapper.Divide(a, b);
            Console.WriteLine($"a / b = {result}");
        }
    }
}
