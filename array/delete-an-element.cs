/*
    15. Write a C# Sharp program to delete an element at the desired position from an array.

    Test Data :
    Input the size of array : 5
    Input 5 elements in the array in ascending order:
    element - 0 : 1
    element - 1 : 2
    element - 2 : 3
    element - 3 : 4
    element - 4 : 5
    Input the position (index) where to delete: 3

    Expected Output :
    The new list is : 1 2 4 5
*/

namespace ArrayAlgorithms;

public class DeleteArrayElement
{
    public static void DeleteAnElement()
    {
        int numberOfElements = 0;
        int deletePosition = 0;

        Console.WriteLine("Input the size of array:");
        numberOfElements = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input {0} elements in the array in ascending order:", numberOfElements);

        int[] array = new int[numberOfElements];

        for (int i = 0; i < numberOfElements; i++)
        {
            Console.Write("Element {0}: ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Input the position where to delete:");
        deletePosition = Convert.ToInt32(Console.ReadLine());

        int[] newArray = new int[numberOfElements - 1];
        int j = 0;

        for (int i = 0; i < numberOfElements; i++)
        {
            if (i != deletePosition)
            {
                newArray[j] = array[i];
                j++;
            }
        }

        Console.WriteLine("The new list after element deleted is:");

        foreach (int element in newArray)
        {
            Console.Write("{0} ", element);
        }
    }
}