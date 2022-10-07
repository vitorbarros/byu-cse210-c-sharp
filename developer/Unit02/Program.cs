using System;

namespace Unit02
{
    class HiloGame
    {
        int currentCard;
        int nextCard;
        int score;
        string guess;
        string playAgain;
        Random random;

        public HiloGame()
        {
            random = new Random();
            score = 300;
            currentCard = random.Next(1, 14);
            nextCard = random.Next(1, 14);
        }

        public void Play()
        {
            while (score > 0)
            {
                Console.WriteLine("The current card is: " + currentCard);
                Console.Write("Will the next card be higher or lower? [h/l] ");

                guess = Console.ReadLine();

                Console.WriteLine("The next card was: " + nextCard);

                if ((guess == "higher" || guess == "h" || guess == "H" || guess == "HIGHER") && nextCard > currentCard)
                {
                    Console.WriteLine("You guessed correctly!");
                    score += 100;
                }
                else if ((guess == "lower" || guess == "l" || guess == "L" || guess == "LOWER") && nextCard < currentCard)
                {
                    Console.WriteLine("You guessed correctly!");
                    score += 100;
                }
                else
                {
                    Console.WriteLine("You guessed incorrectly!");
                    score -= 75;
                }

                Console.WriteLine("Your score is: " + score);

                if (score > 0)
                {
                    Console.Write("Do you want to keep playing? [y/n] ");
                    playAgain = Console.ReadLine();

                    if (playAgain == "n")
                    {
                        break;
                    }
                }

                currentCard = nextCard;
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
