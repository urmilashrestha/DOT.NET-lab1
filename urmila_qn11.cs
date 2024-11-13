using System;

class Program
{
    static void Main()
    {
        int[,] mat1 = new int[2, 2];
        int[,] mat2 = new int[2, 2];
        int[,] result = new int[2, 2];
        
        Console.WriteLine("Enter the elements of the first matrix (2x2):");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("Element [{i + 1},{j + 1}]: ");
                mat1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter the elements of the second matrix (2x2):");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("Element [{i + 1},{j + 1}]: ");
                mat2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Matrix multiplication
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < 2; k++)
                {
                    result[i, j] += mat1[i, k] * mat2[k, j];
                }
            }
        }

        Console.WriteLine("The resulting matrix is:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("{result[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}
