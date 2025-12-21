using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Inherit;

public abstract class Figure: IFigure
{
    public Figure(string name)
    {
        _name = name;
    }

    private readonly string _name;

    public virtual string GetName()
    {
        return _name;
    }

    public abstract double GetArea();

    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{GetName()}: Area={GetArea()}, Perimeter={GetPerimeter()}";
    }
}
