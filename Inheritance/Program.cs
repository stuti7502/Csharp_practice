//we can't inherit multiple class
//Suppose let's say there is a base class A, and two Classes i.e. B and C inherits from class A, and now class D inherits from both class B and class c
//So, we are not sure from where it will inherit, this ambiguity is called diamond problem
public class Employee
{
    public string firstname;
    public string lastname;

}

public class FullTimeEmployee : Employee //a child class, inherited properties of parent class
{
    public float yearlySalary;
    public void printName()
    {
        Console.WriteLine(firstname + " " + lastname + " " + yearlySalary);
    }
}

public class PartTimeEmployee : Employee
{
    public float HourlyRate;
}

//when there is method overloading, two methods having same name
public class parentClass
{
    public parentClass()
    {
        Console.WriteLine("Parent class called");
    }
    public parentClass(string msg)
    {
        Console.WriteLine(msg);
    }
}

public class childClass : parentClass
{
    public childClass() : base("derived class") //if we don't use base then the constructor without parameter will be called
    {
        Console.WriteLine("Child class called");
    }
}

public class Program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.firstname = "Stuti";
        FTE.lastname = "Vithlani";
        FTE.yearlySalary = 50000;
        FTE.printName();

        //same for parttime employee

        childClass cc = new childClass();
    }
}