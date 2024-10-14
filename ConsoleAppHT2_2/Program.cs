using System;

namespace ConsoleAppHT2_2; // Note: actual namespace depends on the project name.

internal class Program
{
    static void Main(string[] args)
    {
        // Create two diagonal matrices
        DiagonalMatrix matrix1 = new DiagonalMatrix(1, 2, 3);
        DiagonalMatrix matrix2 = new DiagonalMatrix(4, 5);
        
        Console.WriteLine("Matrix 1:");
        Console.WriteLine(matrix1.ToString());

        Console.WriteLine("Matrix 2:");
        Console.WriteLine(matrix2.ToString());
        
        Console.WriteLine($"Track of Matrix 1: {matrix1.Track()}");
        Console.WriteLine($"Track of Matrix 2: {matrix2.Track()}");

        DiagonalMatrix resultMatrix = matrix1.Add(matrix2);

        Console.WriteLine("Resulting Matrix after addition:");
        Console.WriteLine(resultMatrix.ToString());
        
        Console.WriteLine($"Matrix 1 equals Matrix 2: {matrix1.Equals(matrix2)}");
        Console.WriteLine($"Matrix 1 equals Result Matrix: {matrix1.Equals(resultMatrix)}");
    }
}