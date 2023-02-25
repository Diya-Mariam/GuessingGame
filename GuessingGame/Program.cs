// See https://aka.ms/new-console-template for more information


using System;

class Game
{
    static void Main(String[] args)
    {
        string secretWord = "Diya M";
        string guess = "";
        int guessCount = 0;
        bool outOfGuesses = false;

        while(secretWord != guess && outOfGuesses== false)
        {
            if(guessCount < 3)
            {
                Console.WriteLine("Enter guess: ");
                guess = Console.ReadLine();
                guessCount++;
            }
            else
            {
                outOfGuesses = true;

            }
            
        }

        if( outOfGuesses)
        {
            Console.WriteLine("You Lost");
        }
        else
        {
            Console.WriteLine("You Won!");
        }
    }
}