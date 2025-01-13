/*
    3. Check 30 or Sum Equals 30
    Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.

    Sample Input:
    30, 0
    25, 5
    20, 30
    20, 25

    Expected Output:
    True
    True
    True
    False
*/

namespace BasicAlgorithm;

public class CheckIntegerOrSumEquals
{
    public static bool SumEqueals()
    {
        const int n = 30;

        int firstNumber = 0;
        int secondNumber = 0;

        Console.WriteLine("Enter the first number:");
        firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        secondNumber = Convert.ToInt32(Console.ReadLine());

        return firstNumber == n || secondNumber == n || (firstNumber + secondNumber == n) ? true : false;
    }
}