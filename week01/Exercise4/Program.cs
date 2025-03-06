using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>(); 
        int userNumber = -1;

        do 
        { 
            Console.Write("Enter a list of numbers, type 0 when finished.");
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);

            if (userNumber != 0) 
            {
                numbers.Add(userNumber);
            }  
            
        } while (userNumber != 0);

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum} ");

/* Since we are making a division we will be working with decimals, so we will use float to declare the variable.
Also know that the computer will do integer division, By making one of the variables a float first, the computer 
knows that it has to do the floating point division, and we get the decimal value that we expect.
 */
        float average = ((float)sum) / numbers.Count; 
        Console.WriteLine($"The average is: {average} ");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        
        }

        Console.WriteLine($"The largest number is: {max} ");

        int smallestPositive = numbers[0];
        foreach (int number in numbers)
        {
        if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The smallest positive number is {smallestPositive} ");

        numbers.Sort();

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
    }
}