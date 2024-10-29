/*
    7. Write a C# Sharp program to merge two arrays of the same size sorted in ascending order.

    Test Data :
    Input the number of elements to be stored in the first array :3
    Input 3 elements in the array :
    element - 0 : 1
    element - 1 : 2
    element - 2 : 3

    Input the number of elements to be stored in the second array :3
    Input 3 elements in the array:
    element - 0 : 1
    element - 1 : 2
    element - 2 : 3

    Expected Output:
    The merged array in ascending order is :
    1 1 2 2 3 3
*/

namespace ArrayAlgorithms;

public class MergeArrays
{
    public static void MergeTwoArrays()
    {
        int numberOfElements = 0;

        Console.WriteLine("Input the number of elements to be stored in the array:");
        numberOfElements = Convert.ToInt32(Console.ReadLine());

        int[] firstArray = new int[numberOfElements];
        int[] secondArray = new int[numberOfElements];

        Console.WriteLine("Input {0} elements in the first array:", numberOfElements);

        for (int i = 0; i < numberOfElements; i++)
        {
            Console.Write("Element - {0}: ", i);
            firstArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Input {0} elements in the second array:", numberOfElements);

        for (int i = 0; i < numberOfElements; i++)
        {
            Console.Write("Element - {0}: ", i);
            secondArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] mergedArray = new int[numberOfElements + numberOfElements];
        int j = 0;

        for (int i = 0; i < numberOfElements; i++)
        {
            mergedArray[j] = firstArray[i];
            j++;
            mergedArray[j] = secondArray[i];
            j++;
        }

        // Using in-build Sort method in Array class
        //Array.Sort(mergedArray);

        // Using bubble sort algorithm
        BubbleSort(mergedArray);

        Console.WriteLine("The merged array in ascending order is:");

        foreach (int element in mergedArray)
        {
            Console.Write("{0} ", element);
        }
    }

    static void BubbleSort(int[] mergedArray)
    {
        int n = mergedArray.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (mergedArray[j] >= mergedArray[j + 1])
                {
                    int temp = mergedArray[j];
                    mergedArray[j] = mergedArray[j + 1];
                    mergedArray[j + 1] = temp;
                }
            }
        }
    }
}