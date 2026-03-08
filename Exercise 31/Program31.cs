using System;
internal class Program31
{
    private static void Main()
    {
        Console.WriteLine("Ingrese el orden de la matriz: ");
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número.");
            return;
        }
        int n = int.Parse(input);

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