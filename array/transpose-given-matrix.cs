/*
    22. Write a C# Sharp program to find the transpose of a given matrix.

    Test Data :
    Input the rows and columns of the matrix : 2 2
    Input elements in the first matrix :
    element - [0],[0] : 1
    element - [0],[1] : 2
    element - [1],[0] : 3
    element - [1],[1] : 4

    Expected Output :
    The matrix is :
    1 2
    3 4
    The Transpose of a matrix is :
    1 3
    2 4
*/

namespace ArrayAlgorithms;

public class Transpose
{
    public static void TransposeMatrix()
    {
        int rows = 0;
        int columns = 0;

        Console.WriteLine("Input the rows and columns of the matrix:");
        rows = Convert.ToInt32(Console.ReadLine());
        columns = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Element: [{0},{1}]: ", i, j);
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("The matrix is:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }

        int[,] transposeMatrix = new int[columns, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                transposeMatrix[j, i] = matrix[i, j];
            }
        }

        Console.WriteLine("The matrix is:");

        for (int j = 0; j < columns; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} ", transposeMatrix[j, i]);
            }
            Console.WriteLine();
        }
    }
}