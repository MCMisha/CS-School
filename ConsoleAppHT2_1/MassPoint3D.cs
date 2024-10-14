namespace ConsoleAppHT2_1;

public class MassPoint3D
{
    private int[] _coordinates = new int[3];
    private double _mass;
    
    public int X
    {
        get => _coordinates[0];
        set => _coordinates[0] = value;
    }

    public int Y
    {
        get => _coordinates[1];
        set => _coordinates[1] = value;
    }

    public int Z
    {
        get => _coordinates[2];
        set => _coordinates[2] = value;
    }

    public double Mass
    {
        get => _mass;
        set
        {
            if (value < 0)
            {
                _mass = 0;
            }
            else
            {
                _mass = value;   
            }
        }
    }

    public bool IsZero() => X == 0 && Y == 0 && Z == 0;

    public double Distance(MassPoint3D point) =>
        Math.Sqrt(Math.Pow(X - point.X, 2) + Math.Pow(Y - point.Y, 2) + Math.Pow(Z - point.Z, 2));


}