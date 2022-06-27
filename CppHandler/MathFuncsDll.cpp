// MathFuncsDll.cpp

#include "MathFuncsDll.h"

#include <iostream>
#include <stdexcept>

using namespace std;

namespace MathFuncs
{
    double MyMathFuncs::Add(double a, double b)
    {
        std::cout << "MathFuncs::MyMathFuncs::Add(a, b);" << std::endl;
        double sum = a + b;
        std::cout << "!!! STD::OUT C++: " << "SUM: " << sum << std::endl;
        return sum;
    }

    double MyMathFuncs::Subtract(double a, double b)
    {
        return a - b;
    }

    double MyMathFuncs::Multiply(double a, double b)
    {
        return a * b;
    }

    double MyMathFuncs::Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new invalid_argument("b cannot be zero!");
        }

        return a / b;
    }
}