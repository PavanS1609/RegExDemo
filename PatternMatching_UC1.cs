using System;
using System.Text.RegularExpressions;
internal  class PatternMatching_UC1
{
    public static void ValidLastName()
    {
        Console.WriteLine("Enter the LastName");
        string LastName = Console.ReadLine();
    String NamePattern = "^[A-Z]{1}[a-zA-z]{3,}$";
    Regex reg = new Regex(NamePattern);
        if (reg.IsMatch(LastName))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Name is Valid");
            Console.ResetColor();
        }
        else
        {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("InValid First Name");
    Console.ResetColor();
        }
    }
    // UseCase 3&10
    public static void ValidEmail()
    {
        Console.WriteLine("Enter the Mail ID");
        string Email = Console.ReadLine();
        String NamePattern = "^[a-z]{1,}([-.+]{1}){0,1}([0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.][a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}";
        Regex reg = new Regex(NamePattern);
        if (reg.IsMatch(Email))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Email is Valid");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("InValid Email");
            Console.ResetColor();
        }

    }
        public static void ValidMobileNumber()
        {
        Console.WriteLine("Enter MobileNumber");
        string MobileNumber = Console.ReadLine();
        string NumberPattern = "^([0-9]{2}[ ]{1})+[0-9]{10}$";
        Regex reg = new Regex(NumberPattern);
        if (reg.IsMatch(MobileNumber))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("MobileNumber  is Valid");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("InValid MobileNumber");
            Console.ResetColor();
        }


        }

    //UseCase5

    public static void Pre_definedPswd()
    {
        Console.WriteLine("Enter the Password");
        string Pswd = Console.ReadLine();
        string pswd_pattern = "^[a-zA-z]{8,}$";
        Regex regex = new Regex(pswd_pattern);
        if (regex.IsMatch(Pswd))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Password  is Valid");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("InValid Password");
            Console.ResetColor();
        }
    }

        public static void PredefinedPswd_rl2()
        {
            Console.WriteLine("Enter the Password");
            string Pswd = Console.ReadLine();
            string pswd_pattern = "^[a-zA-Z]{1}[A-Z]{1}[a-zA-Z]{6}$";
            Regex regex = new Regex(pswd_pattern);
            if (regex.IsMatch(Pswd))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password  is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("InValid Password");
                Console.ResetColor();
            }

        }

    public static void PredefinedPswd_rl3()
    {
        Console.WriteLine("Enter the Password");
        string Pswd = Console.ReadLine();
        string pswd_pattern = "^[a-zA-Z]{1,}[0-9]{1,}[a-zA-Z]{6,}$";
        Regex regex = new Regex(pswd_pattern);
        if (regex.IsMatch(Pswd))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Password  is Valid");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("InValid Password");
            Console.ResetColor();
        }

    }


    public static void PredefinedPswd_rl4()
    {
        Console.WriteLine("Enter the Password");
        string Pswd = Console.ReadLine();
        string pswd_pattern = "[a-zA-Z]{1,}[A-Z]{1,}[0-9]{1,}[!,@,#,$,%,^,&,*,?]{1,}[a-zA-Z]{4,}$";
        Regex regex = new Regex(pswd_pattern);
        if (regex.IsMatch(Pswd))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Password  is Valid");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("InValid Password");
            Console.ResetColor();
        }

    }



}
