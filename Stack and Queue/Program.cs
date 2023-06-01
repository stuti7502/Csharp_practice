using System.Collections;
class collection
{
    public static void Main(string[] args)
    {
        Console.WriteLine("---------Stack-------");
        Stack stack1 = new Stack();
        stack1.Push("Stuti");
        stack1.Push("Vithlani");
        stack1.Push(75);
        stack1.Push("07/05");
        stack1.Push(true);

        foreach (object item in stack1)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine("Popped element: " + stack1.Pop());
        Console.WriteLine();
        Console.WriteLine("Top most element: " + stack1.Peek());

        Console.WriteLine("------Cloned Stack--------");
        Stack cloneStack = (Stack)stack1.Clone(); 
        foreach (object item in cloneStack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-----------Queue----------");
        Queue queue1 = new Queue();
        queue1.Enqueue("Hello");
        queue1.Enqueue("Ni Hao!");
        queue1.Enqueue("Annyeong");
        queue1.Enqueue(1);
        queue1.Enqueue(false);
        foreach (var item in queue1)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Deletd Element: " + queue1.Dequeue());
        Console.WriteLine();
        Console.WriteLine("After deleting element from queue");
        foreach (var item in queue1)
        {
            Console.WriteLine(item);
        }
    }
}