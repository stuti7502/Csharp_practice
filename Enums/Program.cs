//strongly typed constants(hence, ecxplicit conversion is required, as enum of one type cannot be implicity assigned to another although their underlying values are same)
//default type is int
//value types

class Program
{
    public static void Main()
    {
        short[] values = (short[])Enum.GetValues(typeof(Season));
        foreach (short value in values)
        {
            Console.WriteLine(value);
        }
        string[] names = (string[])Enum.GetNames(typeof(Season));
        foreach (string Name in names)
        {
            Console.WriteLine(Name);
        }
    }

}

public enum Season: short
{
    Spring,
    Winter,
    Monsoon
}