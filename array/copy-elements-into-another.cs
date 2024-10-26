/*
    4. Write a C# Sharp program to copy the elements of one array into another array.

    Test Data :
    Input the number of elements to be stored in the array : 3
    Input 3 elements in the array :
    element - 0 : 15
    element - 1 : 10
    element - 2 : 12

    Expected Output:
    The elements stored in the first array are :
    15 10 12
    The elements copied into the second array are :
    15 10 12
*/

namespace ArrayAlgorithms;

public class CopyElements
{
    public static void CopyElementsIntoAnotherArray()
    {
        int numberOfElements = 0;

        Console.WriteLine("Input the number of elements to be stored in the array:");
        numberOfElements = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input {0} elements in the array:", numberOfElements);

        int[] array = new int[numberOfElements];
        int[] copyOfArray = new int[numberOfElements];

        for (int i = 0; i < numberOfElements; i++)
        {
            Console.Write("Element - {0}: ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("The elements stored in the first array are:");
        int j = 0;

        foreach (int element in array)
        {
            Console.Write("{0} ", element);
            copyOfArray[j] = element;
            j++;
        }

        Console.WriteLine();
        Console.WriteLine("The elements copied into the second array are:");

        foreach (int element in copyOfArray)
        {
            Console.Write("{0} ", element);
        }
    }
}