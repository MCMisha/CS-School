using System;

namespace ConsoleAppHT2_1;

internal class Program
{
    static void Main(string[] args)
    {
        MassPoint3D point1 = new MassPoint3D();
        MassPoint3D point2 = new MassPoint3D();
        MassPoint3D point3 = new MassPoint3D();
        
        point1.X = 1;
        point1.Y = 2;
        point1.Z = 3;
        point1.Mass = 5.5;
        
        point2.X = 4;
        point2.Y = 6;
        point2.Z = 8;
        point2.Mass = 10;

        point3.X = 0;
        point3.Y = 0;
        point3.Z = 0;
        
        double distance = point1.Distance(point2);
        Console.WriteLine($"Distance between point1 and point2: {distance}");
        
        Console.WriteLine($"Is point1 at the origin? {point1.IsZero()}");
        Console.WriteLine($"Is point2 at the origin? {point2.IsZero()}");
        Console.WriteLine($"Is point3 at the origin: {point3.IsZero()}");
        point1.Mass = -3.0;
        Console.WriteLine($"Mass of point1 after setting a negative value: {point1.Mass}");
        Console.WriteLine($"Point1 - X: {point1.X}, Y: {point1.Y}, Z: {point1.Z}, Mass: {point1.Mass}");
        Console.WriteLine($"Point2 - X: {point2.X}, Y: {point2.Y}, Z: {point2.Z}, Mass: {point2.Mass}");
    }
}