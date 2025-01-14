/*
    24. Write a C# Sharp program to find the sum of the left diagonals of a matrix.

    Test Data:
    Input the size of the square matrix : 2
    Input elements in the first matrix :
    element - [0],[0] : 1
    element - [0],[1] : 2
    element - [1],[0] : 3
    element - [1],[1] : 4

    Expected Output :
    The matrix is :
    1 2
    3 4
    Addition of the left Diagonal elements is :5
*/

namespace ArrayAlgorithms;

public class SumOfDiagonals
{
    public static void Sum()
    {
        int numberOfElements;

        Console.WriteLine("Input the size of the square matrix:");
        numberOfElements = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input elements in the first matrix:");

        int [,] array = new int[numberOfElements, numberOfElements];

        for (int i = 0; i < numberOfElements; i++)
        {
            for (int j = 0; j < numberOfElements; j++)
            {
                Console.Write($"Element: [{i}, {j}]: ");
                array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("The matrix is:");

        for (int i = 0; i < numberOfElements; i++)
        {
            for (int j = 0; j < numberOfElements; j++)
            {
                Console.Write("{0} ", array[i, j]);
            }
            Console.WriteLine();
        }

        int sum = 0;

        for (int i = 0; i < numberOfElements; i++)
        {
            for (int j = 0; j < numberOfElements; j++)
            {
                if (i == numberOfElements - j - 1)
                    sum += array[i, j];
            }
        }

        Console.WriteLine("Addition of the left diagonal elements is: {0}", sum);
    }
}