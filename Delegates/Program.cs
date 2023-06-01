////Delegates
////safe function pointer
////ref type

//public delegate void HelloDelegate(string msg);
//public delegate void multidelegate();

//class Program
//{
//    public static void Main()
//    {
//        HelloDelegate hd = new HelloDelegate(Hello);
//        hd("Hey there!");

//        //multicast delegate
//        multidelegate del1, del2, del3, del4;
//        del1 = new multidelegate(Multidelegate1);
//        del2 = new multidelegate(Multidelegate2);
//        del3 = new multidelegate(Multidelegate3);

//        del4 = del1 + del2 + del3;
//        del4();

//        //OR
//        multidelegate del = new multidelegate(Multidelegate1);
//        del += Multidelegate2;
//        del += Multidelegate3;
//        del();

//    }

//    public static void Hello(string message)
//    {
//        Console.WriteLine(message);
//    }

//    //multicast delegates
//    public static void Multidelegate1()
//    {
//        Console.WriteLine("first delegate");
//    }
//    public static void Multidelegate2()
//    {
//        Console.WriteLine("second delegate");
//    }
//    public static void Multidelegate3()
//    {
//        Console.WriteLine("third delegate");
//    }
//}

public delegate void HelloDelgate(string y);
class Program
{
    static void Main()
    {
        
        Console.WriteLine("Enter your name");
        string a = Console.ReadLine();

        HelloDelgate hd; //create an instance
        hd = welcome; //points to function
        hd.Invoke(a); //invoking delegate or hd(a);

        Notify obj = new Notify();
        obj.delegateEvent += subscriber1.sub1;
        obj.delegateEvent += subscriber2.sub2;

        obj.NotifyUser(a); //this method calls delegate
    }
    static void welcome(string x)
    {
        Console.WriteLine("Hello " + x);
    }
    
    
}
//define an event which notifies user
class Notify
{
    public HelloDelgate delegateEvent; //delegate of type HelloDelegate

    //method which will call this event
    public void NotifyUser(string x)
    {
        if (delegateEvent != null)
        {
            delegateEvent(x);
        }
    }
}

class subscriber1
{
    public static void sub1(string x)
    {
        Console.WriteLine("Recieved event by 1");
    }
}

class subscriber2
{
    public static void sub2(string x)
    {
        Console.WriteLine("Recieved event by 2");
    }
}