/*
    13. Write a C# Sharp program to insert an additional value into an array (sorted list).

    Test Data :
    Input the size of array : 3
    Input 3 elements in the array in ascending order:
    element - 0 : 5
    element - 1 : 7
    element - 2 : 9
    Input the value to be inserted : 8

    Expected Output :
    The exist array list is :
    5 7 9
    After Insert the list is :
    5 7 8 9
*/

using Microsoft.VisualBasic;

namespace ArrayAlgorithms;

public class Insert
{
    public static void InsertAdditionalElement()
    {
        int numberOfElements = 0;
        
        Console.Write("Input the size of array: ");
        numberOfElements = Convert.ToInt32(Console.ReadLine());
        numberOfElements += 1;

        Console.WriteLine("Input {0} elements in the array in ascending order:", numberOfElements);

        int[] array = new int[numberOfElements];

        for (int i = 0; i < numberOfElements - 1; i++)
        {
            Console.Write("Element {0}: ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("The exist array list is:");

        for (int i = 0; i < numberOfElements - 1; i++)
        {
            Console.Write("{0} ", array[i]);
        }

        int valueToInsert = 0;
        int position = 0;

        Console.WriteLine();
        Console.WriteLine("Input the value to be inserted: ");
        valueToInsert = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numberOfElements; i++)
        {
            if (valueToInsert < array[i])
            {
                position = i;
                break;
            }
        }
        
        // Move elements up to required position (from end to start)

        for (int i = numberOfElements - 1; i >= position; i--)
        {
            array[i] = array[i - 1];
        }

        array[position] = valueToInsert;
        Console.WriteLine("After Insert the list is:");

        foreach(int element in array)
        {
            Console.Write("{0} ", element);
        }
    }
}