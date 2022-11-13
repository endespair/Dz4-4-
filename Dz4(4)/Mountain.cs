using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4_4_;
public class Mountain : GeographicalObject
{
    private double HighestPoint;

    public Mountain(double highestPoint, double x, double y, string name, string description)
        : base(x, y, name, description)
    {
        HighestPoint = highestPoint;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Highest point: {HighestPoint}");
    }
}