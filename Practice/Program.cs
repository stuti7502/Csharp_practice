class Program
{
    static void Main()
    {
        //instance method (invoke using instance of class)
        Program p = new Program();
        p.even();

        //static method (invoke using class name)
        Program.even1(); //or only even1();
    }

    public void even()
    {
        Console.WriteLine("Enter number ");
        var a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }

    public static void even1()
    {
        Console.WriteLine("Enter number ");
        var a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}