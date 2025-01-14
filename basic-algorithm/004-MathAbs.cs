/*
    4. Within 10 of 100 or 200
    Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.

    Sample Input:
    103
    90
    89

    Expected Output:
    True
    True
    False
*/

namespace BasicAlgorithm;

public class MathAbs
{
    public static bool CheckIntegerWithinAbs(int number)
    {
        return Math.Abs(number - 100) <= 10 || Math.Abs(number - 200) <= 10 ? true : false;
    }
}