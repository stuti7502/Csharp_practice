using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        //multidimensional arrays
        int[,] array1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(array1[i, j] + " ");
            }
            Console.WriteLine();
        }
        int[][] array = new int[2][]; //definition of array
        array[0] = new int[6] { 42, 61, 37, 41, 59, 63 };
        array[1] = new int[4] { 11, 21, 56, 78 };
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("--------------Array List--------------");
        //ARRAYLIST
        ArrayList arrayList1 = new ArrayList()
        {
            "Black",
            "Pink",
            "Red",
            "White",
            "Violet"
        };
        //arrayList1.Add("India");
        //arrayList1.Add("Korea");
        foreach (string s in arrayList1)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine();
        Console.WriteLine("Access element from ArrayList " + arrayList1[0]);
        Console.WriteLine();

        //insert to specific number
        arrayList1.Insert(2, "Cyan");
        arrayList1.Insert(3, 5);
        foreach (string s1 in arrayList1)
        {
            Console.WriteLine(s1);
        }
        Console.WriteLine();
        Console.WriteLine("Inserting range of elements");
        //insert range
        ArrayList arrayList2 = new ArrayList()
        {
            "Blue",
            "Yellow"
        };

        arrayList1.InsertRange(2, arrayList2);
        foreach (string s1 in arrayList1)
        {
            Console.WriteLine(s1);
        }

        //removing elements
        //remove, removeat, removerange, removeall

        arrayList1.Remove("Yellow");
        Console.WriteLine();
        Console.WriteLine("After using Remove() func");
        foreach (string s1 in arrayList1)
        {
            Console.WriteLine(s1);
        }

        //check if that element is in arraylist
        Console.WriteLine("Contains Blue or not" + arrayList1.Contains("Blue"));
        Console.WriteLine("Contains Yellow or not" + arrayList1.Contains("Yellow"));

        //clone, copy, sort
        Console.WriteLine();
        arrayList1.Sort();
        foreach (string s1 in arrayList1)
        {
            Console.WriteLine(s1);
        }

        Console.WriteLine("--------------Sortlist--------------");
        DictionaryEntry[] evenarray = new DictionaryEntry[3];
        DictionaryEntry[] oddarray = new DictionaryEntry[3];
        SortedList sortedList1 = new SortedList()
        {
            {1, "One" },
            {2, "Two" },
            {3, "Three" }
        };
        sortedList1.CopyTo(evenarray, 0);
        sortedList1.CopyTo(oddarray, 0);
        for (int i = 0; i < evenarray.Length; i++)
        {
            if (Convert.ToInt32(evenarray[i].Key) % 2 == 0)
            {
                Console.WriteLine(evenarray[i].Value);
            }

        }
        for (int i = 0; i < oddarray.Length; i++)
        {
            if (Convert.ToInt32(oddarray[i].Key) % 2 != 0)
            {
                Console.WriteLine(oddarray[i].Value);
            }
        }


    }

}