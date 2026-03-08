using System;

internal class Program34
{
    private static void Main()
    {
        Console.Write("Ingrese el orden de la matriz: ");
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número.");
            return;
        }
        int n = int.Parse(input);

        // create matrix
        int[,] m = new int[n, n];
        Console.WriteLine("Matriz original:");

        // fill and display original matrix

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                m[i, j] = (i * 2) + j;
                Console.Write(m[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Auxiliary matrix for transposition

        string[,] a = new string[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                a[i, j] = "";
            }
        }

        // Hourglass

        int x = (n / 2) + 1;

        for (int i = 0; i < x; i++)
        {
            for (int j = i; j < n - i; j++)
            {
                a[i, j] = m[i, j].ToString();

                a[n - i - 1, j] = m[n - i - 1, j].ToString();
            }
        }

        // Display hourglass

        Console.WriteLine("\nReloj de arena:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{a[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}