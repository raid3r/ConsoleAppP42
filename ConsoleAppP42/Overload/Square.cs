using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Overload;

public class Square
{

    public float Side { get; set; }

    // Перевантаження оператора ++ (інкремент)
    public static Square operator ++(Square sq)
    {
        sq.Side++;
        return sq;
    }

    // Перевантаження оператора -- (декремент)
    public static Square operator --(Square sq)
    {
        sq.Side--;
        return sq;
    }

    // Перевантаження унарного оператора -
    public static Square operator -(Square sq)
    {
        sq.Side = -sq.Side;
        return sq;
    }

    // Перевантаження оператора +=
    public static Square operator +(Square sq1, Square sq2)
    {
        return new Square { Side = sq1.Side + sq2.Side };
    }

    public static Square operator -(Square sq1, Square sq2)
    {
        return new Square { Side = sq1.Side - sq2.Side };
    }

    public static Square operator *(Square sq1, float value)
    {
        return new Square { Side = sq1.Side * value };
    }

    public static Square operator /(Square sq1, float value)
    {
        return new Square { Side = sq1.Side / value };
    }

    public static bool operator >(Square left, Square right)
    {
        return left.Side > right.Side;
    }

    public static bool operator <(Square left, Square right)
    {
        return !(left > right);
    }

    public static bool operator >=(Square left, Square right)
    {
        return left.Side >= right.Side;
    }

    public static bool operator <=(Square left, Square right)
    {
        return !(left >= right);
    }

    public override string ToString()
    {
        return $"Square with side: {Side}";
    }

    public static bool operator ==(Square left, Square right)
    {
        if (ReferenceEquals(left, right))
            return true;

        return left?.Equals(right) ?? false;
    }

    public static bool operator !=(Square left, Square right)
    {
        return !(left == right);
    }

    public override bool Equals(object? obj)
    {
        if (obj is Square other)
        {
            return this.Side == other.Side;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Side.GetHashCode();
    }

    // Повертаэть true, якщо сторона квадрата більша за нуль
    public static bool operator true(Square sq)
    {
        return sq.Side > 0;
    }

    // Повертаэть true, якщо сторона квадрата менша або дорівнює нулю
    public static bool operator false(Square sq)
    {
        return sq.Side <= 0;
    }

    public static Square operator &(Square left, Square right)
    {
        if (left)
        {
            if (right)
                return right;
        }
        return new Square { Side = 0 };
    }

    public static Square operator |(Square left, Square right)
    {
        if (left)
            return left;

        if (right)
            return right;

        return new Square { Side = 0 };
    }

    public static explicit operator float(Square sq)
    {
        return sq.Side;
    }

    public Square this[int index]
    {
        get
        {
            return new Square() { Side = Side * index };
        }
    }

    public float this[string index]
    {
        get
        {
            switch (index)
            {
                case "side":
                    return Side;
                case "area":
                    return Side * Side;
                case "perimeter":
                    return 4 * Side;
                default:
                    throw new ArgumentException("Invalid index");
            }
        }
        set
        {
            switch (index)
            {
                case "side":
                    Side = value;
                    break;
                case "area":
                    Side = (float)Math.Sqrt(value);
                    break;
                case "perimeter":
                    Side = value / 4;
                    break;
                default:
                    throw new ArgumentException("Invalid index");
            }
        }
    }

    public Square this[int size, float factor]
    {
        get
        {
            return new Square() { Side = size * factor };
        }
    }


    //public static explicit operator float(Square sq)
    //{
    //    return sq.Side;
    //}




}
