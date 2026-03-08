using System;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Ingrese el orden de la matriz: ");
        int n = int.Parse(Console.ReadLine());

        // create matrix
        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = i + j;

                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // Lower triangular matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}