//public class extension1
//{
//    public void one()
//    {
//        Console.WriteLine("One");
//    }
//    public void two() { Console.WriteLine("two"); }
//}

//public static class extension2
//{
//    public static void three(this extension1 ex1)
//    {
//        Console.WriteLine("three");
//    }
//    public static void four(this extension1 ex1) { Console.WriteLine("four"); }
//}

//class Class1
//{
//    public static void Main()
//    {

//        extension1 ext1 = new extension1();
//        ext1.one();
//        ext1.two();
//        ext1.three();
//        ext1.four();
//    }
//}
//class Rectangle
//{
//    public int Length;
//    public int Breadth;
//    public int Area()
//    {
//        return Length * Breadth;
//    }
//    public int Perimeter()
//    {
//        return 2 * (Length + Breadth);
//    }
//}
//class Cuboid : Rectangle
//{
//    public int Height;
//    public Cuboid(int l, int b, int h)
//    {
//        Length = l;
//        Breadth = b;
//        Height = h;
//    }
//    public int Volume()
//    {
//        return Length * Breadth * Height;
//    }
//}


//namespace SealedDemo
//{
//    public class Class1
//    {
//        public virtual void Method1()
//        {
//            Console.WriteLine("Class1 Method1");
//        }
//    }

//    public class Class2 : Class1
//    {
//        //Private Method
//        private void Method2()
//        {
//            Console.WriteLine("Class2 Private Method2");
//        }

//        //Sealed Method
//        public sealed override void Method1()
//        {
//            Console.WriteLine("Class2 Sealed Method1");
//        }
//    }

//    public class Class3 : Class2
//    {
//        //We cannot override Method1 because it is sealed in Class2
//        //But this method is inherited and hence we can access this method
//        //using Class3 instance
//        public override void Method1()
//        {
//            Console.WriteLine("InkJet Printer Printing...");
//        }

//        //Class2 Private Method Method2 is not inherited to child class and hence
//        //you can define the same method here
//        public void Method2()
//        {
//            Console.WriteLine("Class3 public Method2");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Class2 obj1 = new Class2();
//            obj1.Method1();

//            Class3 obj3 = new Class3();
//            obj3.Method1();
//            obj3.Method2();

//            Console.ReadKey();
//        }
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Dictionary<string, string> My_dict1 =
//                      new Dictionary<string, string>();
//        string status = "yes";
//        while (status == "yes")
//        {
//            var name = Console.ReadLine();
//            var name1 = Console.ReadLine();
//            My_dict1.Add(name, name1);
//            Console.WriteLine("Continue?");
//            status = Console.ReadLine();
//        }
//        foreach (KeyValuePair<string, string> kvp in My_dict1)
//        {
//            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
//        }
        
//    }

//}
