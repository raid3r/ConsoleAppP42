using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Dim2;

public class Square : Rectangle
{
    public Square(int sideLength, string name) : base(sideLength, sideLength, name)
    {
    }
}
