using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Extensions;

public sealed class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    protected string _color = "Red";

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
}
