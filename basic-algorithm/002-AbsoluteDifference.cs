/*
    2. Absolute Difference with Triple for Greater
    Write a C# Sharp program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference.

    Sample Input:
    53
    30
    51

    Expected Output:
    6
    21
    0
*/

namespace BasicAlgorithm;

public class AbsoluteDifference
{
    public static void FindAbsoluteDifference()
    {
        const int constantNumber = 51;
        int number = 0;
        int difference = 0;

        Console.WriteLine("Enter the number:");
        number = Convert.ToInt32(Console.ReadLine());

        difference = constantNumber - number;

        if (difference < 0)
            difference = difference * -1;
        
        if (number > constantNumber)
            difference *= 3;

        Console.Write("The absolute difference is: ");
        Console.WriteLine("{0}", difference);
    }
}