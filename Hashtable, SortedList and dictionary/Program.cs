using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Hashtable hashtable1 = new Hashtable()
        {
            { "Name", "Stuti" },
            { "Enroll", "7075" },
            { "Degree", "BE" },
            { "Gender", "female" }
        };
        foreach (DictionaryEntry info in hashtable1)
        {
            Console.WriteLine($"{info.Key}: {info.Value}");
        }
        //Contains(object key), ContaninsKey(object key), ContainsValue(object value)
        Console.WriteLine("Key Departmenet exists: " + hashtable1.Contains("Department"));
        Console.WriteLine("Key Degree exists: " + hashtable1.ContainsKey("Degree"));
        Console.WriteLine("Value Vithlani exists: " + hashtable1.ContainsValue("Vithlani"));
        Console.WriteLine("Key Computer exists: " + hashtable1.ContainsValue("Computer"));
        Console.WriteLine();

        hashtable1.Remove("Gender");
        Console.WriteLine("After Removing gender key");
        foreach (DictionaryEntry info in hashtable1)
        {
            Console.WriteLine($"{info.Key}: {info.Value}");
        }

        Console.WriteLine();
        hashtable1["Name"] = "Stuti Vithlani";
        Console.WriteLine("After Updating the value");
        foreach (DictionaryEntry info in hashtable1)
        {
            Console.WriteLine($"{info.Key}: {info.Value}");
        }

        Console.WriteLine();
        Console.WriteLine("----------SortedList----------");
        Console.WriteLine("collection of key/value pairs that are sorted by the keys and are accessible by key and by index");
        SortedList sortedList1 = new SortedList()
        {
            {1, "One" },
            {2, "Two" },
            {3, "Three" }
        };
        foreach (DictionaryEntry item in sortedList1)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
        //other functions: remove, removeat, clone, copeto

        Console.WriteLine();
        Console.WriteLine("---------Generic Collections----------");
        Console.WriteLine("List,  Queue,  HashSet,  SortedSet,  Stack, Dictionary,  SortedDictionary,  SortedList,  LinkedList");
        Console.WriteLine("Implementation of Dictionary");

        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "One");
        dictionary.Add(2, "Two");
        dictionary.Add(3, "Three");
        dictionary.Add(4, "Four");
        dictionary.Add(5, "Five");
        Console.WriteLine("Dictionary Elements: ");
        foreach (KeyValuePair<int, string> kvp in dictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
        Console.WriteLine(dictionary.Values);
    }
}