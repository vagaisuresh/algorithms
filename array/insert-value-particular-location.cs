/*
    14. Write a C# Sharp program to insert another value in the array (unsorted list).

    Test Data :
    Input the size of array : 4
    Input 4 elements in the array in ascending order:
    element - 0 : 1
    element - 1 : 8
    element - 2 : 7
    element - 3 : 10
    Input the value to be inserted : 5
    Input the Position, where the value to be inserted :2

    Expected Output :
    The current list of the array :
    1 8 7 10
    After Insert the element the new list is :
    1 5 8 7 10
*/

namespace ArrayAlgorithms
{
    public class InsertValue
    {
        public static void InsertValueIntoParticularLocation()
        {
            int numberOfElements = 0;
            int newValue = 0;
            int position = 0;
            
            Console.WriteLine("Input the size of array:");
            numberOfElements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input {0} elements in the array in ascending order:", numberOfElements);

            int[] array = new int[numberOfElements + 1];

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write("Element {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Input the value to be inserted:");
            newValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the position (not index), where the value to be inserted:");
            position = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The current list of the array:");

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            for (int i = numberOfElements; i >= position - 1; i--)
            {
                if (i == position - 1)
                {
                    array[i] = newValue;
                }
                else
                {
                    array[i] = array[i - 1];
                }
            }

            Console.WriteLine();
            Console.WriteLine("After insert the element the new list is:");

            for (int i = 0; i < numberOfElements + 1; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}