/*
    10. Write a program in C# Sharp to separate odd and even integers into separate arrays.

    Test Data :
    Input the number of elements to be stored in the array :5
    Input 5 elements in the array :
    element - 0 : 25
    element - 1 : 47
    element - 2 : 42
    element - 3 : 56
    element - 4 : 32

    Expected Output:
    The Even elements are:
    42 56 32
    The Odd elements are :
    25 47
*/

namespace ArrayAlgorithms;

public class OddEvenElement
{
    public static void FindOddAndEven()
    {
        int numberOfElements = 0;

        Console.WriteLine("Input the number of elements to be stored in the array:");
        numberOfElements = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input {0} elements in the array:", numberOfElements);

        int[] array = new int[numberOfElements];

        for (int i = 0; i < numberOfElements; i++)
        {
            Console.Write("Element - {0}: ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] arrayOdd = new int[numberOfElements];
        int[] arrayEven = new int[numberOfElements];

        int oddIndex = 0;
        int evenIndex = 0;

        foreach (int element in array)
        {
            if (element % 2 != 0)
            {
                arrayOdd[oddIndex] = element;
                oddIndex++;
            }
            else
            {
                arrayEven[evenIndex] = element;
                evenIndex++;
            }
        }

        Console.WriteLine("The Odd elements are:");

        for (int m = 0; m < oddIndex; m++)
        {
            Console.Write("{0} ", arrayOdd[m]);
        }

        Console.WriteLine();
        Console.WriteLine("The Even elements are:");

        for (int n = 0; n < evenIndex; n++)
        {
            Console.Write("{0} ", arrayEven[n]);
        }
    }
}