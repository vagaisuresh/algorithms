/*
    6. Write a program in C# Sharp to print all unique elements in an array.

    Test Data :
    Input the number of elements to be stored in the array :3
    Input 3 elements in the array :
    element - 0 : 1
    element - 1 : 5
    element - 2 : 1

    Expected Output :
    The unique elements found in the array are :
*/

// Solved using LINQ
// Can solve using Dictionary & For loop (refer count-duplicate-elements.cs)

namespace ArrayAlgorithms;

public class UniqueElements
{
    public static void FindDuplicateElements()
    {
        int numberOfElements = 0;

        Console.WriteLine("Input the number of elements to be stored in the array:");
        numberOfElements = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input {0} elements in the array:", numberOfElements);

        int[] array = new int[numberOfElements];

        for (int i = 0; i < numberOfElements; i++)
        {
            Console.Write("Element - {0}: ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        var uniqueElements = array.GroupBy(x => x).Where(g => g.Count() > 0).Select(a => a.Key);

        Console.WriteLine("The unique elements found in the array are: {0}", uniqueElements.Count());
    }
}