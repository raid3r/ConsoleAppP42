using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Inherit;

public class Square : Figure
{
    public double SideA { get; set; }

    public Square(double sideA): base("Square")
    {
        SideA = sideA;
    }

    public override double GetArea()
    {
        return SideA * SideA;
    }

    public override double GetPerimeter()
    {
        return 4 * SideA;
    }
}
