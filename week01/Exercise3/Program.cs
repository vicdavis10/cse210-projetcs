using System;
using System.Net;

Console.WriteLine("Hello World! This is the Exercise3 Project.");

bool playAgain = true; // a boolean variable to control the game loop

while (playAgain)
{
    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 100);
    int guessNumber = 0;
    int numberOfGuesses = 0;

    do
    {
        Console.Write("What is your guess?");
        string guess = Console.ReadLine();
        guessNumber = int.Parse(guess);
        numberOfGuesses++;


        if (magicNumber < guessNumber)
        {
            Console.WriteLine("Lower");
        }

        else if (magicNumber > guessNumber)
        {
            Console.WriteLine("Higher");
        }

        else
        {
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You took {numberOfGuesses} guesses");
        }

    } while (guessNumber != magicNumber);

    Console.Write("Do you want to play again? (yes or no)");
    string playAgainAnswer = Console.ReadLine();
    if (playAgainAnswer != "yes")
    {
        playAgain = false; // set playAgain to false to exit the game loop
    }
}
