
using System;

String name = null;
String answer = null;
String headsOrTailsGuess = null;
int correctGuesses = 0;
Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
Console.WriteLine("What is your name?");
name = Console.ReadLine();
Console.WriteLine("Welcome " + name + " ." + "Do you want to do the COIN FLIP CHALLENGE? Yes/No");
answer = Console.ReadLine();
int input = 0;
int random2;

if (answer.Equals("yes"))
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Heads or Tails?");
        headsOrTailsGuess = Console.ReadLine();
        if (headsOrTailsGuess.Equals("heads"))
        {
            input = 0;
        }
        else
        {
            input = 1;
        }
        Random random = new Random();
        random2 = random.Next(2);

        if (random2 == input)
        {
            Console.WriteLine("Correct!");
            correctGuesses++;  
        } else
        {
            Console.WriteLine("Wrong!");
        }
        
    }

    Console.WriteLine("Thank you " + name + " you got a score of " + correctGuesses);

}
else {
    Console.WriteLine("You are a coward " + name);
}
