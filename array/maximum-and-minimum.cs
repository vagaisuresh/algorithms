/*
    9. Write a C# Sharp program to find the maximum and minimum elements in an array.

    Test Data :
    Input the number of elements to be stored in the array :3
    Input 3 elements in the array :
    element - 0 : 45
    element - 1 : 25
    element - 2 : 21

    Expected Output :
    Maximum element is : 45
    Minimum element is : 21
*/

namespace ArrayAlgorithms;

public class MinMax
{
    public static void FindMinimumAndMaximum()
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

        int minimum = 2147483647;
        int maximum = -2147483648;

        foreach (int element in array)
        {
            if (element <= minimum)
                minimum = element;

            if (element >= maximum)
                maximum = element;
        }

        Console.WriteLine("Maximum element is: {0}", maximum);
        Console.WriteLine("Minimum element is: {0}", minimum);
    }
}