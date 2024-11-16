/*
    18. Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix.

    Test Data :
    Input elements in the matrix :
    element - [0],[0] : 1
    element - [0],[1] : 2
    element - [0],[2] : 3
    element - [1],[0] : 4
    element - [1],[1] : 5
    element - [1],[2] : 6
    element - [2],[0] : 7
    element - [2],[1] : 8
    element - [2],[2] : 9

    Expected Output :
    The matrix is :
    1 2 3
    4 5 6
    7 8 9
*/

namespace ArrayAlgorithms
{
    public class PrintMatrix
    {
        public static void PrintMatrix2D()
        {
            int[,] matrix = new int[3,3];

            Console.WriteLine("Input elements in the matrix:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Element - [{0},{1}]: ", i, j);
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("The matrix is:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", matrix[i,j]);
                }

                Console.WriteLine();
            }
        }
    }
}