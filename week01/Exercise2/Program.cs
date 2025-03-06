using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Write the number of your grade ");
        string grade = Console.ReadLine();

        int x = int.Parse(grade);
        string letter = "";

        if (x >= 90)
        {
            if (x <= 93)
            letter = "A-";
            else
            letter = "A";
        }
        
        else if (x >= 80)
        {
            if (x >= 87) 
            letter = "B+";
            else if (x <= 83)
            letter = "B-";
            else
            letter = "B";
        }

        else if (x >= 70)
        {
            if (x >= 77) 
            letter = "C+";
            else if (x <= 73)
            letter = "C-";
            else
            letter = "C";
            
        }

        else if (x >= 60)
        {
            if (x >= 67) 
            letter = "D+";
            else if (x <= 63)
            letter = "D-";
            else
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!!!");
        }
        else 
        {
            Console.WriteLine("Sorry, wish you luck next time!");
        }


    }


}