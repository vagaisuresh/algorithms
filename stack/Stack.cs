public class Stack
{
    private int[] items;            // Array to hold the stack elements

    private int index;              // Index represending the top element of the stack

    public Stack(int size)
    {
        items = new int[size];      // Initializing the array with the given size
        index = -1;                 // Initializing top to -1, indicating an empty stack
    }

    public bool IsEmpty()
    {
        return index == -1;
    }

    public bool IsFull()
    {
        return index == items.Length - 1;
    }

    public void Push(int item)
    {
        if (IsFull())
        {
            Console.WriteLine("Stack is full!");
            return;
        }

        index += 1;
        items[index] = item;
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty!");
            return -1;
        }

        return items[index--];
    }

    public void Display(Stack stack)
    {
        if (stack.IsEmpty())
        {
            Console.WriteLine("Stack is empty!");
            return;
        }

        Console.WriteLine("\nStack Elements:");

        foreach (int item in stack.items)
        {
            Console.Write($"{item} ");
        }
    }
}