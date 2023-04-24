//id should not be negative, name cannot be set to null, if student name is missing "No Name" should be printed and marks should be read-only
public class Student
{
    public int _ID;
    public string? _Name;
    public int _marks = 70;

    public int Id
    {
        set
        {
            if(value <= 0)
            {
                throw new Exception("Id cannot be negative");
            }
            this._ID = value;
        }
        get
        {
            return _ID;
        }
    }

    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._Name = value;
        }
        get
        {
            return string.IsNullOrEmpty(this._Name) ? "No name" : this._Name;
        }
    }

    public int Marks
    {
        get 
        { 
            return this._marks;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Student s = new Student();
        s.Id= 1;
        s.Name = "Stuti";
        
        Console.WriteLine(s.Id + s.Name + s.Marks);
    }
}