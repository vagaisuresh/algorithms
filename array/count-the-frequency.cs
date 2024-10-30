/*
    8. Write a C# Sharp program to count the frequency of each element in an array.

    Test Data :
    Input the number of elements to be stored in the array :3
    Input 3 elements in the array :
    element - 0 : 25
    element - 1 : 12
    element - 2 : 43

    Expected Output :
    Frequency of all elements of array :
    25 occurs 1 times
    12 occurs 1 times
    43 occurs 1 times
*/

namespace ArrayAlgorithms;

public class CountFrequency
{
    public static void FrequencyOfEachElements()
    {
        int elements;

        Console.WriteLine("Input the number of elements to be stored in the array:");
        elements = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input 3 elements in the array:");
        int[] array = new int[elements];

        for (int i = 0; i < elements; i++)
        {
            Console.Write("Element - {0}: ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Frequency of all elements of array:");

        // ARRAY WITH UNIQUE ELEMENTS
        // Define the size of unique array

        int[] arrayUniqueElements = new int[elements];
        int index = -1;                                 // Elements count of the unique array; Looping up to this count only

        for (int i = 0; i < elements; i++)
        {
            bool found = false;
            index++;

            for (int j = 0; j < index; j++)
            {
                if (array[i] == arrayUniqueElements[j])
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                arrayUniqueElements[index] = array[i];
            }
            else
            {
                index--;  // If already found, reduce one count
            }
        }

        // ARRAY FOR FREQUENCY
        // Count the frequency of elements

        int uniqueCount = index + 1;                        // Taken the last index + 1 as unique count
        int[] arrayFrequency = new int[uniqueCount];

        for (int i = 0; i < uniqueCount; i++)
        {
            int frequency = 0;

            foreach (int element in array)
            {
                if (element == arrayUniqueElements[i])
                {
                    frequency += 1;
                }
            }

            Console.WriteLine("{0} occurs {1} times.", arrayUniqueElements[i], frequency);
        }
    }
}