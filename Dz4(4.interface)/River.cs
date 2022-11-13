using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz4_4.interface_;
internal class River : IGeogObject
{
    private double X;
    private double Y;
    private string Name;
    private string Description;
    private double Length;
    private double Speed;

    public River(double x, double y, string name, string description, int length, int speed)
    {
        X = x;
        Y = y;
        Name = name ?? throw new ArgumentNullException(nameof(Name));
        Description = description ?? throw new ArgumentNullException(nameof(Description));
        Length = length;
        Speed = speed;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Name of object: {Name}");
        Console.WriteLine($"X coordinates: {X}");
        Console.WriteLine($"Y coordinates: {Y}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Length of river: {Length}");
        Console.WriteLine($"Speed of river: {Speed}");
    }
}
