using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Generics;

public interface IPoint<T>
{
    public T X { get; }
    public T Y { get; }
}

public class Point2D<T>: IPoint<T> where T : struct, INumber<T>
{
    public T X { get; set; }
    public T Y { get; set; }

    public static T Distance(Point2D<T> p1, Point2D<T> p2)
    {
        return p1.Y + p2.Y; // TODO relization
    }

}

public class Figure<T> where T: IPoint<int>
{
    public T Point1 { get; set; }
    public T Point2 { get; set; }
    public T Point3 { get; set; }

}


public class Square<T> where T: struct, INumber<T>
{
    public Square(T side)
    {
        Side = side;
    }

    public T Side { get; set; }
        
    public T Area => Side * Side;

    public T Perimeter => T.CreateChecked(4) * Side;
}
