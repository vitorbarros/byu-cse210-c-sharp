using System;
using System.Collections;
using System.Collections.Generic;

namespace Unit03.Game.Model
{
    public class Puzzle
    {
        private string Word;
        private int MaxGuesses { get; }
        private List<string> CorrectGuesses = new List<string>();
        public List<string> IncorrectGuesses = new List<string>();
        public int GuessesLeft { get; set; }

        public string CorrectGuessedWord = "";

        public Puzzle(string word, int maxGuessesLength)
        {
            Word = word;
            GuessesLeft = 5;
            MaxGuesses = maxGuessesLength;
        }
        
        public void Guess(string letter)
        {
            if (Word.Contains(letter))
            {
                CorrectGuesses.Add(letter);
                Console.WriteLine("Puzzle word " + RevelWord());
                Console.WriteLine("Correct letters " + string.Join(", ", CorrectGuesses));
                
            }
            else
            {
                IncorrectGuesses.Add(letter);
                Console.WriteLine("Incorrect letters " + string.Join(", ", IncorrectGuesses));
                GuessesLeft--;
            }
        }
        
        private string RevelWord()
        {
            string revealedWord = "";
            foreach (char letter in Word)
            {
                if (CorrectGuesses.Contains(letter.ToString()))
                {
                    revealedWord += letter;
                }
                else
                {
                    revealedWord += "_";
                }
            }
            
            CorrectGuessedWord = revealedWord;
            return revealedWord;
        }
    }
}