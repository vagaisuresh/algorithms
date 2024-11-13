/*
    17. Write a C# Sharp program to find the second smallest element in an array.

    Test Data :
    Input the size of array : 5
    Input 5 elements in the array (value must be <9999) :
    element - 0 : 0
    element - 1 : 9
    element - 2 : 4
    element - 3 : 6
    element - 4 : 5

    Expected Output :
    The Second smallest element in the array is : 4
*/

namespace ArrayAlgorithms
{
    public class FindSmallest
    {
        public static void SecondSmallestElement()
        {
            int numberOfElements = 0;

            Console.WriteLine("Input the size of array:");
            numberOfElements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input {0} elements in the array:", numberOfElements);

            int[] array = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write("Element {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            BubbleSort(array);
            int secondSmallestElement = array[1];

            Console.Write("The second smallest element in the array is: {0}", secondSmallestElement);
        }

        static void BubbleSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (array[j] >= array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}