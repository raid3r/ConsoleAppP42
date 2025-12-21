using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Inherit;

public class Circle: Figure, IColorable
{
    public ConsoleColor Color { get; set; } = ConsoleColor.White;

    public double Radius { get; set; }

    public Circle(double radius) : base("Circle")
    {
        Radius = radius;
    }
    public override string GetName()
    {
        return "Circle" + " color: " + Enum.GetName<ConsoleColor>(Color);
    }
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}
