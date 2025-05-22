public class StackGeneric
{
    public void GenericStackMethodUsage()
    {
        Stack<int> stack = new Stack<int>();

        Console.WriteLine("Push:");
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        foreach (int i in stack)
        {
            Console.WriteLine($"{i} ");
        }

        Console.WriteLine();
        Console.WriteLine($"Peek: {stack.Peek()}");

        Console.WriteLine();
        Console.WriteLine("Pop:");

        stack.Pop();

        foreach (int i in stack)
        {
            Console.WriteLine($"{i} ");
        }
    }
}