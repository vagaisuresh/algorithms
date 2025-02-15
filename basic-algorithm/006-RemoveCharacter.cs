/*
    6. Remove Character at Position
    Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive.

    Sample Input:
    "Python", 1
    "Python", o
    "Python", 4

    Expected Output:
    Pthon
    ython
    Pythn
*/

namespace BasicAlgorithm;

public class RemoveCharacter
{
    public static string RemoveCharacterAtPosition(string word, int position)
    {
        // Method 1

        // string removedWord = "";

        // char[] array = word.ToCharArray();
        
        // for (int i = 0; i < array.Length; i++)
        // {
        //     if (i != position)
        //         removedWord += array[i];
        // }

        // return removedWord;

        // Solution
        
        return word.Remove(position, 1);
    }
}