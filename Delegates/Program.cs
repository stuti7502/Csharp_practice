//Delegates
//safe function pointer
//ref type

public delegate void HelloDelegate(string msg);
public delegate void multidelegate();

class Program
{
    public static void Main()
    {
        HelloDelegate hd = new HelloDelegate(Hello);
        hd("Hey there!");

        //multicast delegate
        multidelegate del1, del2, del3, del4;
        del1 = new multidelegate(Multidelegate1);
        del2 = new multidelegate(Multidelegate2);
        del3 = new multidelegate(Multidelegate3);

        del4 = del1 + del2 + del3;
        del4();

        //OR
        multidelegate del = new multidelegate(Multidelegate1);
        del += Multidelegate2;
        del += Multidelegate3;
        del();

    }

    public static void Hello(string message)
    {
        Console.WriteLine(message);
    }

    //multicast delegates
    public static void Multidelegate1()
    {
        Console.WriteLine("first delegate");
    }
    public static void Multidelegate2()
    {
        Console.WriteLine("second delegate");
    }
    public static void Multidelegate3()
    {
        Console.WriteLine("third delegate");
    }
}