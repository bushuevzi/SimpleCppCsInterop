using System;
using System.Runtime.InteropServices;

namespace BusObserver
{
    class Program
    {
        [DllImport("..\\..\\..\\..\\x64\\Debug\\CppHandler.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Add(double a, double b);

        static void Main(string[] args)
        {
            double result = Add(1.0, 3.0);
            Console.WriteLine(result);
        }
    }
}
