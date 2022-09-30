using System;

namespace Unit03
{
    // Overview #
    // Hilo is a game in which the player guesses if the next card drawn by the dealer will be higher or lower than the previous one. Points are won or lost based on whether or not the player guessed correctly.

    // Rules #
    // Hilo is played according to the following rules.

    // The player starts the game with 300 points.
    // Individual cards are represented as a number from 1 to 13.
    // The current card is displayed.
    // The player guesses if the next one will be higher or lower.
    // The the next card is displayed.
    // The player earns 100 points if they guessed correctly.
    // The player loses 75 points if they guessed incorrectly.
    // If a player reaches 0 points the game is over.
    // If a player has more than 0 points they decide if they want to keep playing.
    // If a player decides not to play again the game is over.
    class HiloGame
    {
        // The current card
        int currentCard;

        // The next card
        int nextCard;

        // The player's score
        int score;

        // The player's guess
        string guess;

        // The player's choice to keep playing
        string playAgain;

        // The random number generator
        Random random;

        // The constructor
        public HiloGame()
        {
            // Initialize the random number generator
            random = new Random();

            // Initialize the score
            score = 300;

            // Initialize the current card
            currentCard = random.Next(1, 14);

            // Initialize the next card
            nextCard = random.Next(1, 14);
        }

        // The main game loop
        public void Play()
        {
            // Loop until the player runs out of points
            while (score > 0)
            {
                // Display the current card
                Console.WriteLine("The current card is " + currentCard);

                // Get the player's guess
                Console.Write("Will the next card be higher or lower? ");
                guess = Console.ReadLine();

                // Display the next card
                Console.WriteLine("The next card is " + nextCard);

                // Check the player's guess
                if (guess == "higher" && nextCard > currentCard)
                {
                    // The player guessed correctly
                    Console.WriteLine("You guessed correctly!");
                    score += 100;
                }
                else if (guess == "lower" && nextCard < currentCard)
                {
                    // The player guessed correctly
                    Console.WriteLine("You guessed correctly!");
                    score += 100;
                }
                else
                {
                    // The player guessed incorrectly
                    Console.WriteLine("You guessed incorrectly!");
                    score -= 75;
                }

                // Display the player's score
                Console.WriteLine("Your score is " + score);

                // Check if the player wants to keep playing
                if (score > 0)
                {
                    // Get the player's choice
                    Console.Write("Do you want to keep playing? ");
                    playAgain = Console.ReadLine();

                    // Check the player's choice
                    if (playAgain == "no")
                    {
                        // The player doesn't want to keep playing
                        break;
                    }
                }

                // Set the current card to the next card
                currentCard = nextCard;

                // Get the next card
                nextCard = random.Next(1, 14);
            }
        }
    }


    class Program
    {

        public static HiloGame hiloGame = new HiloGame();
        static void Main(string[] args)
        {
            hiloGame.Play();
        }
    }
}
