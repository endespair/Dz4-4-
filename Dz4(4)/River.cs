using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4_4_;
public class River : GeographicalObject
{
    private double Speed;
    private double Length;

    public River(double speed, double length, double x, double y, string name, string description)
        : base(x, y, name, description)
    {
        Speed = speed;
        Length = length;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Length of river: {Length}");
        Console.WriteLine($"Speed of river: {Speed}");
    }
}
