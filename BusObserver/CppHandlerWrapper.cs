using System.Runtime.InteropServices;

namespace BusObserver
{
    public static class CppHandlerWrapper
    {
        [DllImport("..\\..\\..\\..\\x64\\Debug\\CppHandler.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Add(double a, double b);

        [DllImport("..\\..\\..\\..\\x64\\Debug\\CppHandler.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Subtract(double a, double b);

        [DllImport("..\\..\\..\\..\\x64\\Debug\\CppHandler.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Multiply(double a, double b);

        [DllImport("..\\..\\..\\..\\x64\\Debug\\CppHandler.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Divide(double a, double b);
    }
}