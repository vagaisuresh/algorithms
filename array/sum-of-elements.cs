/*
    3. Write a program in C# Sharp to find the sum of all array elements.

    Test Data :
    Input the number of elements to be stored in the array :3
    Input 3 elements in the array :
    element - 0 : 2
    element - 1 : 5
    element - 2 : 8

    Expected Output :
    Sum of all elements stored in the array is : 15
*/

namespace ArrayAlgorithms;

public class SumOfArrayElements
{
    public static void Sum()
    {
        int numberOfElements = 0;

        Console.WriteLine("Input the number of elements to be stored in the array:");
        numberOfElements=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input {0} elements in the array:", numberOfElements);

        int[] array = new int[numberOfElements];

        for (int i = 0; i < numberOfElements; i++)
        {
            Console.Write("Element - {0}: ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        var sum = 0;

        foreach (int element in array)
        {
            sum += element;
        }

        Console.WriteLine("Sum of all elements stored in the array is: {0}", sum);
    }
}