interface IStudent
{
    public void Login();
    public void Register();
    
}

interface Imail
{
    public void mailConfirmation();
}

//DIP
public class Student1
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DoB { get; set; }

    private IStudentRepository _stdRepo;

    public Student1(IStudentRepository stdRepo)
    {
        _stdRepo = stdRepo;
    }

    public void Save()
    {
        _stdRepo.AddStudent(this);
    }
}

public interface IStudentRepository
{
    void AddStudent(Student1 std);
    void EditStudent(Student1 std);

    IList<Student1> GetAllStudents();
}

public class StudentRepository : IStudentRepository
{
    public void AddStudent(Student1 std)
    {
        
    }

    public void EditStudent(Student1 std)
    {
        
    }


    public IList<Student1> GetAllStudents()
    {
        
       
    }
}
//srp
public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
   
}

public class EmailManager
{
    public static void SendEmail(string recEmailed, string senderEmailId, string subject, string message)
    {
        // smtp code here
    }
}

public class PaymentManger
{
    public static void ProcessPayment()
    {
        //payment processing code here
    }
}

//ocp
public abstract class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }

    public abstract void Subscribe(Student std);
}

public class OnlineCourse : Course
{
    public override void Subscribe(Student std)
    {
        //write code to subscribe to an online course
    }
}

public class OfflineCourse : Course
{
    public override void Subscribe(Student std)
    {
        //write code to subscribe to a offline course
    }
}

//lsp
public abstract class Calculator
{
    protected readonly int[] _numbers;

    public Calculator(int[] numbers)
    {
        _numbers = numbers;
    }

    public abstract int Calculate();
}
public class TotalMarks : Calculator
{
    public TotalMarks(int[] numbers)
        : base(numbers)
    {
    }

    public override int Calculate() => _numbers.Sum();
}

public class AverageMarks : Calculator
{
    public AverageMarks(int[] numbers)
       : base(numbers)
    {
    }

    public override int Calculate() => (int)_numbers.Average();
}

class Program
{
    static void Main(string[] args)
    {
        var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

        Calculator sum = new TotalMarks(numbers);

        Calculator evenSum = new AverageMarks(numbers);
    }
}

