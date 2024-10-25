namespace Array;

public class StoresElements
{
    /* 
        1. Write a C# Sharp program that stores elements in an array and prints them.

        Test Data:
        Input 10 elements in the array:
        element - 0 : 1
        element - 1 : 1
        element - 2 : 2 
        ......

        Expected Output :
        Elements in array are: 1 1 2 3 4 5 6 7 8 9
    */

    public static void StoresElementsInArrayAndPrints()
    {
        int[] array = new int[10];

        Console.WriteLine("Read and Print elements of an array.");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Input 10 elements in the array.");

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Element - {0} : ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nElements in array are: ");
        
        foreach( int i in array)
        {
            Console.Write($"{i} ");
        }
    }
}