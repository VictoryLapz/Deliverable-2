using System;

namespace CoinFlipChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playagain = true;

            while (playagain)
            {
                {
                    Console.WriteLine("Welcome to the Coin Flip Challenge!");
                    Console.Write("Enter your name: ");
                    string playerName = Console.ReadLine();

                    Console.Write($"Hi, {playerName}! Do you want to play the Coin Flip Challenge? (yes/no): ");
                    string playChoice = Console.ReadLine().ToLower();

                    if (playChoice == "yes")
                    {
                        int totalCorrectGuesses = 0;

                        for (int round = 1; round <= 10; round++)
                        {
                            Console.WriteLine($"\nRound {round}:");
                            Console.Write("Heads or Tails?");
                            string userGuess = Console.ReadLine().ToLower();

                            //try again generator//

                            while (userGuess != "heads" && userGuess != "tails")
                            {
                                Console.Write("Invalid input. Please enter heads and tails");
                                userGuess = Console.ReadLine().ToLower();
                            }

                            // Generate a random coin flip (0 for heads, 1 for tails)
                            Random random = new Random();
                            int coinFlip = random.Next(2);

                            string result = (coinFlip == 0) ? "heads" : "tails";

                            if (userGuess == result)
                            {
                                Console.WriteLine("Correct!");
                                totalCorrectGuesses++;
                            }
                            else
                            {
                                Console.WriteLine($"Wrong! It was {result}.");
                            }
                        }

                        Console.WriteLine($"\nGame over, {playerName}! You got {totalCorrectGuesses} correct guesses.");

                        Console.Write("Do you want to play again? (yes/no): ");
                        string playagainchoice = Console.ReadLine().ToLower();

                        if (playagainchoice != "yes")
                        {
                            playagain = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Maybe next time! Goodbye.");
                        playagain = false;
                    }
                }
            }
        }
    }
}