/*
    2. Write a C# Sharp program to read n values in an array and display them in reverse order.

    Test Data :
    Input the number of elements to store in the array :3
    Input 3 number of elements in the array :
    element - 0 : 2
    element - 1 : 5
    element - 2 : 7

    Expected Output:
    The values store into the array are:
    2 5 7
    The values store into the array in reverse are :
    7 5 2
*/

namespace ArrayAlgorithms;

public class ReadValuesAndReverse
{
    public static void ReadElementsAndReverse()
    {
        int numberOfElements = 0;

        Console.WriteLine("Input the number of elements to store in the array:");
        numberOfElements = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input {0} number of elements in the array:", numberOfElements);

        int[] array = new int[numberOfElements];

        for (int i = 0; i < numberOfElements; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("The values stored into the array are:");
        
        foreach (int element in array)
        {
            Console.WriteLine($"{element} ");
        }

        Console.WriteLine("The values store into the array in reverse are:");
        Array.Reverse(array);

        foreach (int element in array)
        {
            Console.WriteLine($"{element} ");
        }
    }
}