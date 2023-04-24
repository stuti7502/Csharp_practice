using System.IO;

public class Exceptionhandling
{
    public static void Main()
    {
        //StreamReader streamreader = null;
        //try
        //{
        //    streamreader = new StreamReader(@"C:\Users\stuti\Documents\weeklreport.txt");
        //    Console.WriteLine(streamreader.ReadToEnd());
        //}
        //catch(Exception ex)
        //{
        //    Console.WriteLine(ex.Message); //gets a message that describes the current exception
        //    Console.WriteLine();
        //    Console.WriteLine(ex.StackTrace); //provides the call stack to the line number in the method were exception occured
        //}
        //finally
        //{
        //    streamreader.Close();
        //    Console.WriteLine("Finally block");
        //}

        //custom Exceptions
        throw new UserAlreadyLoggedInException("User is already logged in");
    }
}

//custom exceptions
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() : base(){
    }

    public UserAlreadyLoggedInException(string message) : base(message) { }
}