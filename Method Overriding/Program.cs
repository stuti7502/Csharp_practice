
public class Employee
{
    public string firstname = "S";
    public string lastname ="V";

    public virtual void printName() //if we write virtual, it means we are giving permission to child class to replace this, if child class does not have same method then it can use parent class's method
    {
        Console.WriteLine(firstname + " abc " + lastname);
    }

}

public class FullTimeEmployee : Employee //a child class, inherited properties of parent class
{
    public override void printName() //override is to replace parent class's method
    {
        Console.WriteLine(firstname + " " + lastname);
    }
}

public class PartTimeEmployee : Employee
{
    public override void printName()
    {
        Console.WriteLine(firstname + " " + lastname);
    }
}

public class Program
{
    public static void Main()
    {
        //Employee[] employees = new Employee[3];
        
        //employees[0] = new Employee();
        //employees[1] = new FullTimeEmployee();
        //employees[2] = new PartTimeEmployee();

        //foreach(Employee e in employees)
        //{
        //    e.printName();
        //}
        
        Employee e = new PartTimeEmployee();
        e.printName();
    }
}

