//Why we need generics
//If we specify data type and then we want another data type
//If we use object, it will lead to poor performance because of boxing and unboxing
//Method overloading, repeat again and again
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

        Console.WriteLine();
        Console.WriteLine("Another Example");
        //Instantiate GenericClass, string is the type argument
        GenericClass<string> myGenericClass = new GenericClass<string>
        {
            Message = "Hey there"
        };
        myGenericClass.GenericMethod("Stuti", "Ahmedabad");
        Console.ReadLine();

        Console.WriteLine("---Generic Constraints----");
        // Instantiate Generic Class with Constraint
        GenericClass<string> stringClass = new GenericClass<string>();
        stringClass.Message = "Generic Constraints";
        stringClass.GenericMethod("Effiel Tower", "Paris");


        //CLASS CONSTRAINT
        Console.WriteLine("---Class constraint---");
        GenericClass1<Employee1> EmployeeClass = new GenericClass1<Employee1>();
        Employee1 emp1 = new Employee1() { Name = "Effiel Tower", Location = "Paris" };
        Employee1 emp2 = new Employee1() { Name = "Taj Mahal", Location = "Agra" };
        Employee1 emp3 = new Employee1() { Name = "City Palace", Location = "Udaipur" };
        EmployeeClass.Message = emp1;
        EmployeeClass.GenericMethod1(emp2, emp3);

        //STRUCT CONSTRAINT
        Console.WriteLine("---Struct constraint---");
        GenericClass2<int> intClass = new GenericClass2<int>();
        intClass.Message = 30;
        intClass.GenericMethod2(10, 20);

        //T,U constraint
        Console.WriteLine("---T,U constraint---");
        GenericClass3<Employee3, IEmployee> employeeGenericClass = new GenericClass3<Employee3, IEmployee>();
        //Compile Time Error as string is not a value type, it is a reference type
        //GenericClass<string> stringClass = new GenericClass<string>();

        //Compile Time Error as Employee is not a value type, it is a reference type
        //GenericClass<Employee> EmployeeClass = new GenericClass<Employee>();

    }
}

public class calculator
{
    public static bool AreEqual<T>(T a, T b)
    {
        return a.Equals(b);
    }
}

//another example

public class GenericClass<T>
{
    public T Message;
    public void GenericMethod(T Name, T Location)
    {
        Console.WriteLine($"Message: {Message}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Location: {Location}");
    }
}

public class GenericClass1<T> where T : class
    {
        public T Message;
        public void GenericMethod1(T Param1, T Param2)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Place Name: {Param1}");
            Console.WriteLine($"Location: {Param2}");
        }
    }

    public class Employee1
    {
        public string Name { get; set; }
        public string Location { get; set; }
}

 
    public class GenericClass2<T> where T : struct
    {
        public T Message;
        public void GenericMethod2(T Param1, T Param2)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Param1: {Param1}");
            Console.WriteLine($"Param2: {Param2}");
        }
    }

    public class Employee2
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }


//Other constraintas: baseclass, new(), interface, T: U

//T: U constraint
//In a nullable context, if U is a non-nullable reference type, T must be a non-nullable reference type. If U is a nullable reference type, 
//    T may be either nullable or non-nullable. So, in this constraint, there are two Type Arguments i.e. 
//    T and U. U can be an interface, abstract class, or simple class. T must inherit or implements the U class.

public class GenericClass3<T, U> where T : U
{
    public T Message;
    public void GenericMethod3(T Param1, U Param2)
    {
        Console.WriteLine($"Message: {Message}");
        Console.WriteLine($"Param1: {Param1}");
        Console.WriteLine($"Param2: {Param2}");
    }
}
public interface IEmployee
{
}
public class Employee3 : IEmployee
{
    public string Name { get; set; }
}
public class Customer
{
    public string Name { get; set; }
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