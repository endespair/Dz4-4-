using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4_4_;
public abstract class GeographicalObject
{
    private double X;
    private double Y;
    private string Name;
    private string Description;

    public GeographicalObject(double x, double y, string name, string description)
    {
        X = x;
        Y = y;
        Name = name ?? throw new ArgumentNullException(nameof(Name));
        Description = description ?? throw new ArgumentNullException(nameof(Description));
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Name of object: {Name}");
        Console.WriteLine($"X coordinates: {X}");
        Console.WriteLine($"Y coordinates: {Y}");
        Console.WriteLine($"Description: {Description}");
    }
}
