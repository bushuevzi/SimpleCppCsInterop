// CppHandler.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "CppHandler.h"
#include "MathFuncsDll.h"

double Add(double a, double b)
{
    return MathFuncs::MyMathFuncs::Add(a, b);
}

double Subtract(double a, double b)
{
    return MathFuncs::MyMathFuncs::Subtract(a, b);
}

double Multiply(double a, double b)
{
    return MathFuncs::MyMathFuncs::Multiply(a, b);
}

double Divide(double a, double b)
{
    return MathFuncs::MyMathFuncs::Divide(a, b);
}