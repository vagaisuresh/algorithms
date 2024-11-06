/*
    12. Write a C# Sharp program to sort array elements in descending order.

    Test Data :
    Input the size of array : 3
    Input 3 elements in the array :
    element - 0 : 5
    element - 1 : 9
    element - 2 : 1

    Expected Output :
    Elements of the array in sorted descending order:
    9 5 1
*/

namespace ArrayAlgorithms;

public class Sort
{
    public static void SortDescendingOrder()
    {
        int numberOfElements = 0;

        Console.WriteLine("Input the size of array:");
        numberOfElements = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input {0} elements in the array:", numberOfElements);

        int[] array = new int[numberOfElements];

        for (int i = 0; i < numberOfElements; i++)
        {
            Console.Write("Element {0}: ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        SortDescend(array);
        Console.WriteLine("Elements of the array in sorted descending order:");
        
        foreach (int element in array)
        {
            Console.Write("{0} ", element);
        }
    }

    static void SortDescend(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (array[j] < array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}