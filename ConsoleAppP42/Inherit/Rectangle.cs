using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Inherit;

public sealed class Rectangle: Square
{
    public double SideB { get; set; }

    public Rectangle(double sideA, double sideB) : base(sideA)
    {
        SideB = sideB;
    }

    public override string GetName()
    {
        return "Rectangle";
    }

    public override double GetArea()
    {
        return SideA * SideB;
    }
    public override double GetPerimeter()
    {
        return 2 * (SideA + SideB);
    }
}
