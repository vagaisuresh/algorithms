/*
    19. Write a C# Sharp program for adding two matrices of the same size.

    Test Data :
    Input the size of the square matrix (less than 5): 2
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

    Expected Output:
    The First matrix is:
    1 2
    3 4
    The Second matrix is :
    5 6
    7 8
    The Addition of two matrix is :
    6 8
    10 12
*/

namespace ArrayAlgorithms;

public class AddMatrix
{
    public static void AddTwoMatrix()
    {
        int sizeOfSquareMatrix = 0;

        Console.WriteLine("Input the size of the square matrix (less than 5):");
        sizeOfSquareMatrix = Convert.ToInt32(Console.ReadLine());

        int[,] firstMatrix = new int[sizeOfSquareMatrix, sizeOfSquareMatrix];
        int[,] secondMatrix = new int[sizeOfSquareMatrix, sizeOfSquareMatrix];
        int[,] sumMatrix = new int[sizeOfSquareMatrix, sizeOfSquareMatrix];

        Console.WriteLine("Input elements in the first matrix:");

        for (int i = 0; i < sizeOfSquareMatrix; i++)
        {
            for (int j = 0; j < sizeOfSquareMatrix; j++)
            {
                Console.Write("Element [{0},{1}]: ", i, j);
                firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Input elements in the second matrix:");

        for (int i = 0; i < sizeOfSquareMatrix; i++)
        {
            for (int j = 0; j < sizeOfSquareMatrix; j++)
            {
                Console.Write("Element [{0},{1}]: ", i, j);
                secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine();
        Console.WriteLine("The first matrix is:");

        for (int i = 0; i < sizeOfSquareMatrix; i++)
        {
            for (int j = 0; j < sizeOfSquareMatrix; j++)
            {
                Console.Write("{0} ", firstMatrix[i, j]);
            }

            Console.WriteLine();
        }
        
        Console.WriteLine("The second matrix is:");

        for (int i = 0; i < sizeOfSquareMatrix; i++)
        {
            for (int j = 0; j < sizeOfSquareMatrix; j++)
            {
                Console.Write("{0} ", secondMatrix[i, j]);
            }
            
            Console.WriteLine();
        }

        // SUM

        for (int i = 0; i < sizeOfSquareMatrix; i++)
        {
            for (int j = 0; j < sizeOfSquareMatrix; j++)
            {
                sumMatrix[i ,j] = firstMatrix[i, j] + secondMatrix[i, j];
            }
        }

        Console.WriteLine("The Addition of two matrix is:");

        for (int i = 0; i < sizeOfSquareMatrix; i++)
        {
            for (int j = 0; j < sizeOfSquareMatrix; j++)
            {
                Console.Write("{0} ", sumMatrix[i, j]);
            }
            
            Console.WriteLine();
        }
    }
}