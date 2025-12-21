using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppP42.Inherit;

public class Apartment: IArea
{
    private double _area;
    public Apartment(double area)
    {
        _area = area;
    }
    public double GetArea()
    {
        return _area;
    }

    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }

    public override string ToString()
    {
        return $"Apartment: Area={GetArea()}, Address={Address}, City={City}, Region={Region}, PostalCode={PostalCode}";
    }    
}
