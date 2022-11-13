using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4_4.interface_;
internal class Mountain : IGeogObject
{
    private double X;
    private double Y;
    private string Name;
    private string Description;
    private int HighestPoint;

    public Mountain(double x, double y, string name, string description, int highestPoint)
    {
        X = x;
        Y = y;
        Name = name ?? throw new ArgumentNullException(nameof(Name));
        Description = description ?? throw new ArgumentNullException(nameof(Name));
        HighestPoint = highestPoint;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Name of object: {Name}");
        Console.WriteLine($"X coordinates: {X}");
        Console.WriteLine($"Y coordinates: {Y}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Highest point of mountain: {HighestPoint}");
    }
}
