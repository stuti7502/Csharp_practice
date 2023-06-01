//types:
//Value parameters - points to different memory location
//reference parameters - points to same memory location
//out parameters
//parameters array

class Program
{
    public static void Main()
    {
        //value parameters
        int i = 0;
        SimpleMethod(i);
        Console.WriteLine(i);

        //reference parameters
        int k = 0;
        SimpleMethod1(ref k);
        Console.WriteLine(k);

        //out parameters
        int Total = 0;
        int Product = 0;
        Calculate(out Total, out Product);
        Console.WriteLine("Sum = {0} & Product = {0}", Total, Product);

        //Parameter Arrays
        //int[] numbers = { 5, 6, 7 };
        //ArrayParam(numbers);
        //OR
        ArrayParam(1, 2, 3);
    }

    //value parameters
    public static void SimpleMethod(int j)
    {
        j = 1001;
    }

    //refernce parameter
    public static void SimpleMethod1(ref int j)
    {
        j = 1001;
    }

    //out paramentes
    public static void Calculate(out int Sum, out int Product)
    {
        Sum = 10 + 20;
        Product = 10 * 20;

    }

    //Parameter Arrays
    public static void ArrayParam(params int[] num)
    {
        foreach(int i in num)
        {
            Console.Write(i + " ");
        }
    }
}