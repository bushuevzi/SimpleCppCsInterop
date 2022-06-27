#pragma once
// CppHandler.h

// Returns a + b
extern "C" __declspec(dllexport) double Add(double a, double b);

// Returns a - b
extern "C" __declspec(dllexport) double Subtract(double a, double b);

// Returns a * b
extern "C" __declspec(dllexport) double Multiply(double a, double b);

// Returns a / b
// Throws DivideByZeroException if b is 0
extern "C" __declspec(dllexport) double Divide(double a, double b);