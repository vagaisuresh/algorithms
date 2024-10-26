/*
    5. Write a C# Sharp program in to count duplicate elements in an array.

    Test Data :
    Input the number of elements to be stored in the array :3
    Input 3 elements in the array :
    element - 0 : 5
    element - 1 : 1
    element - 2 : 1

    Expected Output :
    Total number of duplicate elements found in the array is : 1
*/

namespace ArrayAlgorithms;

public class CountElements
{
    public static void CountDuplicateElements()
    {
        int numberOfElements = 0;
        int duplicateElements = 0;

        Console.WriteLine("Input the number of elements to be stored in the array:");
        numberOfElements = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input {0} elements in the array:", numberOfElements);
        int[] array = new int[numberOfElements];

        for (int i = 0; i < numberOfElements; i++)
        {
            Console.Write("Element - {0}: ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        // (1) Get duplicates using for-loop
        duplicateElements = DuplicateCountingUsingForLoop(array, numberOfElements);

        // (2) Get duplicates using Dictionary
        //duplicateElements = DuplicateCountingUsingDictionary(array);

        // (3) Get Duplicates using LINQ
        //duplicateElements = DuplicateCountingUsingLinq(array);

        Console.WriteLine("Total number of duplicate elements found in the array is: {0}", duplicateElements);
    }

    private static int DuplicateCountingUsingForLoop(int[] array, int numberOfElements)
    {
        int[] copyOfArray = new int[numberOfElements];
        Array.Copy(array, copyOfArray, numberOfElements);

        int[] duplicateArray = new int[numberOfElements];

        // Add the below value into duplicateArray if found
        int value = 1;

        for (int i = 0; i < numberOfElements; i++)
        {
            for (int j = 0; j < numberOfElements; j++)
            {
                if (array[i] == array[j])
                {
                    duplicateArray[j] = value;
                    value++;
                }
            }

            // Reset to initial value
            value = 1;
        }

        // Read the values from duplicateArray
        // Get the count if value is equal to 2

        int duplicateCount = 0;

        foreach (int duplicate in duplicateArray)
        {
            if (duplicate == 2)
                duplicateCount += 1;
        }

        return duplicateCount;
    }

    private static int DuplicateCountingUsingDictionary(int[] array)
    {
        Dictionary<int, int> occarances = new Dictionary<int, int>();

        foreach (int element in array)
        {
            if (occarances.ContainsKey(element))
            {
                occarances[element]++;
            }
            else
            {
                occarances[element] = 1;
            }
        }

        int duplicateCount = 0;

        foreach (var pair in occarances)
        {
            if (pair.Value > 1)
            {
                duplicateCount += 1;
            }
        }

        return duplicateCount;

        // Explanation
        // Dictionary: We use a Dictionary<int, int> where the key is the element and the value is its count.
        // Key-Value Pairs: Each entry in a Dictionary consists of a key and a corresponding value. The key is unique within the Dictionary, while multiple keys can map to different values.
        // Loop: We iterate through the array and update the count of each element.
        // Display Duplicates: Finally, we return the elements that have a count greater than one.
    }

    private static int DuplicateCountingUsingLinq(int[] array)
    {
        var duplicates = array.GroupBy(x => x).Where(g => g.Count() > 1).Select(a => a.Key);
        return duplicates.Count();
    }

    // Actual Solution

    public static void Main()  // Main method, entry point of the program
    {
        int[] arr1 = new int[100];  // Declaration of an integer array 'arr1' with size 100
        int[] arr2 = new int[100];  // Declaration of another integer array 'arr2' with size 100
        int[] arr3 = new int[100];  // Declaration of another integer array 'arr3' with size 100
        int s1, mm = 1, ctr = 0;  // Declaration of variables 's1', 'mm', and 'ctr'
        int i, j;  // Declaration of loop control variables 'i' and 'j'

        // Display a message to count the total number of duplicate elements in an array
        Console.Write("\n\nCount total number of duplicate elements in an array:\n");
        Console.Write("---------------------------------------------------------\n");

        Console.Write("Input the number of elements to be stored in the array :");
        s1 = Convert.ToInt32(Console.ReadLine());  // Read the number of elements from the user and store it in 's1'

        Console.Write("Input {0} elements in the array:\n", s1);  // Prompt the user to input 's1' elements
        for (i = 0; i < s1; i++)
        {
            Console.Write("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());  // Read user input and store it in the array 'arr1'
        }

        // Copy elements from 'arr1' to 'arr2' and initialize 'arr3' with 0
        for (i = 0; i < s1; i++)
        {
            arr2[i] = arr1[i];  // Copy each element from 'arr1' to 'arr2'
            arr3[i] = 0;  // Initialize 'arr3' with 0
        }

        // Mark the elements that are duplicate in 'arr3'
        for (i = 0; i < s1; i++)
        {
            for (j = 0; j < s1; j++)
            {
                if (arr1[i] == arr2[j])
                {
                    arr3[j] = mm;  // Mark duplicate elements in 'arr3' with 'mm'
                    mm++;  // Increment 'mm'
                }
            }
            mm = 1;  // Reset 'mm' to 1
        }

        // Count the number of duplicate elements in 'arr3'
        for (i = 0; i < s1; i++)
        {
            if (arr3[i] == 2)
            {
                ctr++;  // Increment 'ctr' for each duplicate element found in 'arr3'
            }
        }

        Console.Write("The number of duplicate elements is: {0} \n", ctr);  // Output the count of duplicate elements
        Console.Write("\n\n");  // Extra newline for formatting
    }
}