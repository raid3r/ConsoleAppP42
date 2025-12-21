using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Inherit;

internal interface IFigure: IArea, IPerimeter
{
  public string GetName();
}
