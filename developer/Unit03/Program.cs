using System;
using System.Collections;
using System.Collections.Generic;

namespace Unit03
{
    class Jumper {
            List<string> puzzleList = new List<string>();
            string puzzle;
            string guess;
            string revealed;
            int parachute;
            bool solved;
            bool gameOver;
            
            public Jumper() {
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
                puzzle = puzzleList[index];
            }

            public void Play() {
                while (!gameOver) {
                    Console.WriteLine("The puzzle is: " + puzzle);
                    Console.Write("Guess a letter: ");
                    guess = Console.ReadLine();
    
                    if (puzzle.Contains(guess)) {
                        Console.WriteLine("You guessed correctly!");
                        revealed += guess;
                    }
                    else {
                        Console.WriteLine("You guessed incorrectly!");
                        parachute--;
                    }
    
                    if (revealed == puzzle) {
                        solved = true;
                        gameOver = true;
                    }
    
                    if (parachute == 0) {
                        gameOver = true;
                    }
                }
            }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Jumper jumper = new Jumper();
            jumper.Play();
        }
    }
}
