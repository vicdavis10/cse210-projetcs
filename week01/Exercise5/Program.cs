using System;
using System.Reflection.Metadata;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
    
    //Remember you need to declare the function before you can call it
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int result = SquareNumber(userNumber);

        DisplayResult(userName , result);
    }

    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the program!");
    }    

    static string PromptUserName ()
    {   
      Console.Write("Please enter your name:");
      return Console.ReadLine(); 
    }
    //  Call the function and store the result in a variable

    static int PromptUserNumber ()
    {
        Console.Write("Please enter your favorite number:");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    { 
        int result = userNumber * userNumber;
        return result;
    }

    static void DisplayResult (string userName, int result)
    {
        Console.WriteLine($"{userName}, the square of your number is {result}");
    }
    
}