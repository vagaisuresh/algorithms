/*
    1. Triple Sum for Equal Integers
    Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.

    Sample Input:
    1, 2
    3, 2
    2, 2

    Expected Output:
    3
    5
    12
*/

namespace BasicAlgorithm;

public class TripleSum
{
    public static void Sum()
    {
        decimal firstValue = 0;
        decimal secondValue = 0;
        decimal sum = 0;

        Console.WriteLine("Enter the first value:");
        firstValue = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter the second value:");
        secondValue = Convert.ToDecimal(Console.ReadLine());

        sum = firstValue + secondValue;

        if (firstValue == secondValue)
            sum = sum * 3;
        
        Console.Write("Expected Output: ");
        Console.WriteLine("{0}", sum);
    }
}