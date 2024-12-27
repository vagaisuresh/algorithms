/*
    23. Write a C# Sharp program to find the sum of the right diagonals of a matrix.

    Test Data :
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
    Addition of the right Diagonal elements is : 5
*/

namespace ArrayAlgorithms
{
    public class SumTheRightDiagonals
    {
        public static void SumRightDiagonalsValue()
        {
            int sizeOfArray = 0;
            int sum = 0;

            Console.WriteLine("Input the size of the square matrix: ");
            sizeOfArray = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input elements in the first matrix: ");

            int[,] array = new int[sizeOfArray, sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                for (int j = 0; j < sizeOfArray; j++)
                {
                    Console.Write("Element - [{0}, {1}]: ", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The matrix is: ");

            for (int i = 0; i < sizeOfArray; i++)
            {
                for (int k = 0; k < sizeOfArray; k++)
                {
                    Console.Write("{0} ", array[i, k]);
                    
                    if (i == k)
                        sum += array[i, k];
                }
                Console.WriteLine();
            }

            Console.WriteLine("Addition of the right Diagonal elements is: ");
            Console.WriteLine(sum);
        }
    }
}