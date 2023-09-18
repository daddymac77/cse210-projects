using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);

        int guessedNumber = -1;
        while (magicNumber != guessedNumber)
        {
       Console.Write("What is your guess? ");
        guessedNumber = int.Parse(Console.ReadLine());

        if (magicNumber > guessedNumber)
        {
            Console.Write("Higher!");
        }
        
        else if (magicNumber < guessedNumber)
        {
            Console.Write("Lower!");
        }
        else
        {
            Console.Write("You guessed it!");
        }

        
            
        
        
            
        }
        }
        }

        

        
    
    

