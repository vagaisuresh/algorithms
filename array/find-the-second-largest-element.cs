/*
    16. Write a C# Sharp program to find the second largest element in an array.

    Test Data :
    Input the size of array : 5
    Input 5 elements in the array :
    element - 0 : 2
    element - 1 : 9
    element - 2 : 1
    element - 3 : 4
    element - 4 : 6

    Expected Output :
    The Second largest element in the array is: 6
*/

namespace ArrayAlgorithms
{
    public class FindLargest
    {
        public static void FindSecondLargestElement()
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

            // Get the largest

            int largestElement = 0;
            int secondLargetElement = 0;

            foreach (int element in array)
            {
                if (element > largestElement)
                {
                    largestElement = element;
                }

                foreach (int ele in array)
                {
                    if (ele < largestElement)
                    {
                        if (ele > secondLargetElement)
                        {
                            secondLargetElement = ele;
                        }
                    }
                }
            }

            Console.Write("The second largest element in the array is: {0}", secondLargetElement);
        }
    }
}