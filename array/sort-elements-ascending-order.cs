/*
    11. Write a C# Sharp program to sort elements of an array in ascending order.

    Test Data :
    Input the size of array : 5
    Input 5 elements in the array :
    element - 0 : 2
    element - 1 : 7
    element - 2 : 4
    element - 3 : 5
    element - 4 : 9

    Expected Output :
    Elements of array in sorted ascending order:
    2 4 5 7 9
*/

namespace ArrayAlgorithms;

public class SortElements
{
    public static void SortElementsAscendingOrder()
    {
        int numberOfElements = 0;

        Console.WriteLine("Input the size of array:");
        numberOfElements = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input {0} elements in the array:", numberOfElements);

        int[] array = new int[numberOfElements];

        for (int i =0; i < numberOfElements; i++)
        {
            Console.Write("Element - {0}: ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Elements of array before sort:");

        int k = 0;
        int[] sortedArray = new int[numberOfElements];

        foreach (var element in array)
        {
            Console.Write("{0} ", element.ToString());
            sortedArray[k] = element;
            k++;
        }

        BubbleSort(sortedArray);

        Console.WriteLine("");
        Console.WriteLine("Elements of array in sorted ascending order:");

        foreach (var element in sortedArray)
        {
            Console.Write("{0} ", element);
        }
    }

    static void BubbleSort(int[] sortedArray)
    {
        int n = sortedArray.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (sortedArray[j] > sortedArray[j + 1])
                {
                    int temp = sortedArray[j];
                    sortedArray[j] = sortedArray[j + 1];
                    sortedArray[j + 1] = temp;
                }
            }
        }
    }
}