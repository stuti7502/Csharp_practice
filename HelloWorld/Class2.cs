
using System.Xml.Linq;

class Program
{
    string stu_loginid { get; set; }
    string stu_pass { get; set; }
    int stu_fees { get; set; }
    string[][] data =
        {
            new string[]{"Stuti", "Stuti", "30000"},
            new string[]{"Krina", "Krina", "0"},
            new string[]{"", "", ""}
        };
    
    public void datas()
    {
        
        
        data[2][0] = stu_loginid;
        data[2][1] = stu_pass;
        data[2][2] = "30000";

        if (data[0][0] == null)
        {
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine($"1. Name : {data[0][0]}, Password : {data[0][1]}, Fees amount pending: {data[0][2]}");
        }
        if (data[1][0] == null)
        {
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine($"2. Name : {data[1][0]}, Password : {data[1][1]}, Fees amount : {data[1][2]}");
        }

        if (data[2][0] == "" || data[2][0] == null || data[2][0] == " ")
        {
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine($"3. Name : {data[2][0]}, Password : {data[2][1]}, Fees amount : {data[2][2]}");
        }

    }
    public void adm_choice()
    {
        choice_admin:
        Console.WriteLine("1. View Student");
        Console.WriteLine("2. Remove Student");
        Console.WriteLine("3. Home Page");

        Console.WriteLine("Enter your choice");
        int adm_choice = Convert.ToInt32(Console.ReadLine());

        switch(adm_choice)
        {
            case 1:
                datas();
                goto choice_admin;
            case 2:
                stu_remove();
                datas();
                goto choice_admin;
            case 3:
                home();
                break;
            default:
                Console.WriteLine();
                break;
        }
        
    }
    public void stu_remove()
    {
        datas();
        Console.WriteLine("Write the number of a student you want to remove");
        int stu = Convert.ToInt32(Console.ReadLine());
        switch (stu)
        {
            case 1:
                data[0][0] = data[0][1] = data[0][2] = null;
                break;
            case 2:
                data[1][0] = data[1][1] = data[1][2] = null;
                break;
            case 3:
                data[2][0] = data[2][1] = data[2][2] = null;
                break;
            default:
                Console.WriteLine("Wrong");
                break;
        }
    }
    public void stu_choice()
    {
        Console.WriteLine("1. Login");
        Console.WriteLine("2. Register");
        Console.WriteLine("3. Home Page");

        Console.WriteLine("Enter your choice");
        int stu_choice = Convert.ToInt32(Console.ReadLine());

        switch (stu_choice)
        {
            case 1:
                stu_login();
                break;
            case 2:
                stu_register();
                break;
            case 3:
                home();
                break;
            default:
                Console.WriteLine();
                break;
        }

    }
    public void stu_choice2()
    {
        Console.WriteLine("1. View Details");
        Console.WriteLine("2. Pay Fees");
        Console.WriteLine("3. LogOut");

        Console.WriteLine("Enter your choice");
        int stu_choice = Convert.ToInt32(Console.ReadLine());

        switch (stu_choice)
        {
            case 1:
                stu_login();
                break;
            case 2:
                stu_register();
                break;
            case 3:
                home();
                break;
            default:
                Console.WriteLine();
                break;
        }

    }
    public void adm_login()
    {
        Console.WriteLine("Login: ");
        string? loginid = Console.ReadLine();
        Console.WriteLine("Password: ");
        string? pass = Console.ReadLine();
        if(loginid == "admin" && pass == "admin")
        {
            Console.WriteLine("Success");
            adm_choice();
        }
        else
        {
            Console.WriteLine("Fail");
        }

    }
  
    public void stu_register()
    {
        Console.WriteLine("Register: ");
        stu_loginid = Console.ReadLine();
        Console.WriteLine("Password: ");
        stu_pass = Console.ReadLine();
        Console.WriteLine("Account registered successfully");
        Console.WriteLine("Press any key to continue");
        stu_choice2();


    }
    public void stu_login()
    {
        if (data[2][0] == "")
        {
            Console.WriteLine("Please register first");
            stu_register();
        }
        else
        {
            login:
            Console.WriteLine("Login: ");
            string? loginid = Console.ReadLine().ToUpper();
            Console.WriteLine("Password: ");
            string? pass = Console.ReadLine().ToUpper();

            if (loginid == stu_loginid.ToUpper() && pass == stu_pass.ToUpper())
            {
                Console.WriteLine("Success");
                stu_choice();
            }
            else
            {
                Console.WriteLine("Wrong login id or password");
                goto login;
            }
        }

    }
    public void pay_fees()
    {
        stu_fees = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Press 1: if you want to pay in installments");
        Console.WriteLine("Press 2: all together");
    }
    public void home()
    {
        Console.WriteLine("1. Admin");
        Console.WriteLine("2. Student");
        Console.WriteLine("3. Exit");
        bool ischoice = true;
        while (ischoice)
        {
            int choice;
            Console.WriteLine("Enter your choice");
            choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    adm_login();
                    break;
                case 2:
                    stu_choice();
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
            if (choice == 1 || choice == 2 || choice == 3)
            {
                ischoice = false;
            }
        }

    }
    public static void Main(string[] args)
    {
        Program p = new Program();
        p.home();
    }
}
