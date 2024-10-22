namespace ConsoleAppHT2_2;

public class DiagonalMatrix
{
    private readonly int[] _elements;

    public int Size { get; }
    
    public DiagonalMatrix(params int[]? elements)
    {
        if (elements == null)
        {
            _elements = [];
            Size = 0;
        }
        else
        {
            _elements = new int[elements.Length];
            Array.Copy(elements, _elements, elements.Length);
            Size = elements.Length;    
        }
    }

    public int this[int i, int j]
    {
        get => i == j && i < elements.Length && j < elements.Length ? _elements[i] : 0;
        set
        {
            if (i != j && i >= elements.Length && j >= elements.Length)
            {
                return;
            }
            _elements[i] = value;
        }
    }

    public int Track()
    {
        return _elements.Sum();
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is DiagonalMatrix m) || Size != m.Size)
        {
            return false;
        }
        return _elements.SequenceEqual(m._elements);
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(_elements, Size);
    }

    public override string ToString()
    {
        return string.Join(" ", _elements);
    }
}

public static class DiagonalMatrixExtensions
{
    public static DiagonalMatrix Add(this DiagonalMatrix matrix1, DiagonalMatrix matrix2)
    {
        int newSize = Math.Max(matrix1.Size, matrix2.Size);
        int[] newDiagonal = new int[newSize];

        for (int i = 0; i < newSize; i++)
        {
            int elem1 = i < matrix1.Size ? matrix1[i, i] : 0;
            int elem2 = i < matrix2.Size ? matrix2[i, i] : 0;
            newDiagonal[i] = elem1 + elem2;
        }

        return new DiagonalMatrix(newDiagonal);
    }
}
