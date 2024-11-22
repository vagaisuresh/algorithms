/*
    21. Write a C# Sharp program for multiplication of two square matrices.

    Test Data :
    Input the rows and columns of first matrix : 2 2
    Input the rows and columns of second matrix : 2 2
    Input elements in the first matrix :
    element - [0],[0] : 1
    element - [0],[1] : 2
    element - [1],[0] : 3
    element - [1],[1] : 4
    Input elements in the second matrix :
    element - [0],[0] : 5
    element - [0],[1] : 6
    element - [1],[0] : 7
    element - [1],[1] : 8

    Expected Output :
    The First matrix is :
    1 2
    3 4
    The Second matrix is :
    5 6
    7 8
    The multiplication of two matrix is :
    19 22
    43 50
*/

namespace ArrayAlgorithms;

public class MultiplicationTwoArray
{
    public static void MultiplicationTwoMatrices()
    {
        int rows = 0;
        int columns = 0;
        
        Console.WriteLine("Input the rows and columns of first matrix:");
        Console.Write("Rows: ");
        rows = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("");
        Console.Write("Columns: ");
        columns = Convert.ToInt32(Console.ReadLine());

        int[,] firstArray = new int[rows, columns];
        int[,] secondArray = new int[rows, columns];

        Console.WriteLine("Input elements in the first matrix:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Element [{0},{1}]: ", i, j);
                firstArray[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Input elements in the second matrix:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Element [{0},{1}]: ", i, j);
                secondArray[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // PRINT

        Console.WriteLine("The first matrix is:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("{0} ", firstArray[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("The second matrix is:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("{0} ", secondArray[i, j]);
            }
            Console.WriteLine();
        }

        // MULTIPLICATION

        int[,] multiplyArray = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                multiplyArray[i, j] = firstArray[i, j] * secondArray[i, j];
            }
        }

        Console.WriteLine("The multiplication of two matrix is:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("{0} ", multiplyArray[i, j]);
            }
            Console.WriteLine();
        }
    }
}