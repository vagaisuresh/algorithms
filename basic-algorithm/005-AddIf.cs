/*
    5. Add 'if' to String if Absent
    Write a C# Sharp program to create a string where 'if' is added to the front of a given string. If the string already begins with 'if', return it unchanged.

    Sample Input:
    "if else"
    "else"

    Expected Output:
    if else
    if else
*/

namespace BasicAlgorithm;

public class StringProgram
{
    public static string AddIfToString(string input)
    {
        string twoChar = input.ToString().Substring(0, 2);

        if (twoChar.ToLower() == "if")
            return input;
        else
            return "if " + input;
    }
}