/*
    20. Write a C# Sharp program for the subtraction of two matrixes.

    Test Data :
    Input the size of the square matrix (less than 5): 2
    Input elements in the first matrix :
    element - [0],[0] : 5
    element - [0],[1] : 6
    element - [1],[0] : 7
    element - [1],[1] : 8
    Input elements in the second matrix :
    element - [0],[0] : 1
    element - [0],[1] : 2
    element - [1],[0] : 3
    element - [1],[1] : 4

    Expected Output :
    The First matrix is :
    5 6
    7 8
    The Second matrix is :
    1 2
    3 4
    The Subtraction of two matrix is :
    4 4
    4 4
*/

namespace ArrayAlgorithms;

public class TwoDimArray
{
    public static void SubtractionTwoMatrixes()
    {
        int numberOfElements = 0;
        Console.WriteLine("Input the size of the square matrix (less than 5):");
        numberOfElements = Convert.ToInt32(Console.ReadLine());

        int[,] firstMatrix = new int[numberOfElements, numberOfElements];
        int[,] secondMatrix = new int[numberOfElements, numberOfElements];

        Console.WriteLine("Input elements in the first matrix:");

        for (int i = 0; i < numberOfElements; i++)
        {
            for (int j = 0; j < numberOfElements; j++)
            {
                Console.Write("Element [{0},{1}]: ", i, j);
                firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Input elements in the second matrix:");

        for (int i = 0; i < numberOfElements; i++)
        {
            for (int j = 0; j < numberOfElements; j++)
            {
                Console.Write("Element [{0}, {1}]: ", i, j);
                secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine();
        Console.WriteLine("The first matrix is:");

        for (int i = 0; i < numberOfElements; i++)
        {
            for (int j = 0; j < numberOfElements; j++)
            {
                Console.Write("{0} ", firstMatrix[i, j]);
            }

            Console.WriteLine();
        }
        
        Console.WriteLine("The second matrix is:");

        for (int i = 0; i < numberOfElements; i++)
        {
            for (int j = 0; j < numberOfElements; j++)
            {
                Console.Write("{0} ", secondMatrix[i, j]);
            }
            
            Console.WriteLine();
        }

        // SUBTRACTION

        int[,] matrix = new int[numberOfElements, numberOfElements];

        for (int i = 0; i < numberOfElements; i++)
        {
            for (int j = 0; j < numberOfElements; j++)
            {
                matrix[i, j] = firstMatrix[i, j] - secondMatrix[i, j];
            }
        }

        Console.WriteLine("The subtraction of two matrix is:");

        for (int i = 0; i < numberOfElements; i++)
        {
            for (int j = 0; j < numberOfElements; j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            
            Console.WriteLine();
        }
    }
}