// See https://aka.ms/new-console-template for more informationg 

using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Regex demo");
        Console.WriteLine("Please select an Option : \n" +
            "1.Tocheck Valid FirstName\n" +
            "2.Tocheck Valid LastName\n"+
            "3.Tocheck Valid EmailId\n"+
            "4.Tocheck valid MobileNumber\n"+
            "5.Tocheck valid Password\n"+
            "6.Tocheck valid Password\n"+
            "7.Tocheck valid Password\n"+
            "8.Tocheck valid Password\n");
        int option =Convert.ToInt32(Console.ReadLine());
        switch(option) 
        {
                case 1:
                PatternMatching.ValidFirstName();
                break;
                case 2:
                PatternMatching_UC1.ValidLastName();
                break;
                case 3:
                PatternMatching_UC1.ValidEmail();
                break;
                case 4:
                PatternMatching_UC1.ValidMobileNumber();    
                break;
                case 5: 
                PatternMatching_UC1.Pre_definedPswd();
                break;
                case 6:
                PatternMatching_UC1.PredefinedPswd_rl2();
                break;
                case 7:
                PatternMatching_UC1.PredefinedPswd_rl3();
                break;
                case 8:
                PatternMatching_UC1.PredefinedPswd_rl4();   
                break;
        }
    }
}

