using System;
using System.Text.RegularExpressions;

internal class PatternMatching
{
    public static void ValidFirstName()
    {
        Console.WriteLine("Enter the FirstName");
        string FirstName = Console.ReadLine();
        String NamePattern = "^[A-Z]{1}[a-zA-z]{3,}$";
        Regex reg =new Regex(NamePattern);
        if (reg.IsMatch(FirstName))
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
}
