using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Delegates;

public delegate double MathOperation(double a, double b);



public static class Operations
{
    public static double Add(double a, double b) => a + b;
    public static double Subtract(double a, double b) => a - b;
    public static double Multiply(double a, double b) => a * b;
    public static double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Denominator cannot be zero.");
        return a / b;
    }
}

public class PowerOperations
{
    private int baseValue = 0;
    public PowerOperations(int baseValue) {
    this.baseValue = baseValue;
    }

    public double Power(double a, double b) => baseValue + Math.Pow(a, b);

    public double Sqrt(double a) => Math.Sqrt(a) + baseValue;


}

public delegate void MathOperationAndShowResult(double a, double b);

class Calculator
{
    public double A { get; set; }
    public double B { get; set; }

    public event MathOperationAndShowResult Calculate;

    public void CalculateAndShow()
    {
        //if (Calculate != null)
        //{
        //    foreach (MathOperationAndShowResult del in Calculate.GetInvocationList())
        //    {
        //        del(A, B);
        //    }
        //}

        Calculate?.Invoke(A, B);
    }

}


