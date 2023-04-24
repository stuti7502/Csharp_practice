class program
{
    static void Main()
    {
        bool equal = calculator.AreEqual<string>("AB", "A");

        if(equal)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }

    }
}

public class calculator
{
    public static bool AreEqual<T>(T a, T b)
    {
        return a.Equals(b);
    }
}

//The below can only compare int types

//public class calculator
//{
//    public static bool AreEqual(int a, int b)
//    {
//        return a == b;
//    }
//}


//this will compare any type like string with int ..etc

//public class calculator
//{
//    public static bool AreEqual(object a, object b)
//    {
//        return a == b;
//    }
//}