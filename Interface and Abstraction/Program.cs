//Interface: 
//cannot contain field
//cannot have access modifier
//can only have declaration
//good practice to start interface name with I

interface ICustomer
{
    void print();
}

class Customer : ICustomer
{
    public void print()
    {
        Console.WriteLine("Interface print");
    }
}

//Explicit Interface
//it is used when two interfaces have same method name

interface I1
{
    void printMethod();
}

interface I2
{
    void printMethod();
}

public class ExplicitInterface: I1, I2{
    void I1.printMethod()
    {
        Console.WriteLine("I1 invoked");
    }

    void I2.printMethod()
    {
        Console.WriteLine("I2 invoked");
    }
}

//Abstraction
//cannot be instantiated
//can only be used as base class
//may contain abstract members(method, properties, events) but not mandatory

public abstract class EmployeeAbstract
{
    //public abstract void print(); // if we use abstract for method then we can't declare properties inside and have to declare in another class
    public void printAbstract()
    {
        Console.WriteLine("Thhis is an abstract method");
    }
}

//public class Employee : EmployeeAbstract
//{
//    public override void print()
//    {
//        Console.WriteLine("This is an abstract method");
//    }
//}
public class Program : EmployeeAbstract
{
    public static void Main()
    {
        //interface
        Customer c = new Customer();
        c.print();

        //explicit interface
        ExplicitInterface EI = new ExplicitInterface();
        ((I1)EI).printMethod();
        ((I2)EI).printMethod();

        //Abstraction
        Program e = new Program();
        e.printAbstract();
    }
}
