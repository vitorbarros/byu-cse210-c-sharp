using System;
using Unit03.Game.Model;
using Unit03.Game.Utils;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class Jumper
    {
        List<string> puzzleList = new List<string>();
        
        int maxGuess;
        
        string word;
        
        public Jumper()
        {
            puzzleList.Add("airplane");
            puzzleList.Add("car");
            puzzleList.Add("skate");
            puzzleList.Add("bicycle");
            puzzleList.Add("train");
            puzzleList.Add("boat");
            puzzleList.Add("rocket");
            puzzleList.Add("bus");
            puzzleList.Add("motorcycle");
            puzzleList.Add("submarine");
            
            Random random = new Random();
            int index = random.Next(0, puzzleList.Capacity);
            word = puzzleList[index];

            maxGuess = 5;
        }
        public void Init()
        {
            var puzzle = new Puzzle(word, maxGuess);

            while (puzzle.GuessesLeft > 0)
            {
                Console.Write("Guess a letter [a-z]: ");
                var guess = Console.ReadLine();

                puzzle.Guess(guess);

                if (puzzle.CorrectGuessedWord.Equals(word))
                {
                    Console.Write("Congrats you won!");
                    puzzle.GuessesLeft = 0;
                }
                else
                {
                    Parachute.Print(puzzle.IncorrectGuesses.Count);   
                }
            }
        }
    }
}