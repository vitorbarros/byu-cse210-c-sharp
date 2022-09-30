using System;
using System.Collections.Generic;

namespace Unit01
{
    class TicTacToeGame
    {

        public List<string> GenerateBoard()
        {
            List<string> board = new List<string>();

            for (int i = 1; i <= 9; i++)
            {
                board.Add(i.ToString());
            }

            return board;
        }

        public void RenderBoard(List<string> boardList)
        {
            Console.WriteLine($"{boardList[0]}|{boardList[1]}|{boardList[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{boardList[3]}|{boardList[4]}|{boardList[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{boardList[6]}|{boardList[7]}|{boardList[8]}");
        }

        public void MakeMove(List<string> board, int choice, string currentPlayer)
        {
            int index = choice - 1;
            board[index] = currentPlayer;
        }

        public int GetMoveChoice(string currentPlayer)
        {
            Console.Write($"{currentPlayer}'s turn to choose a square (1-9): ");
            string move_string = Console.ReadLine();
            int choice = int.Parse(move_string);
            return choice;
        }

        public string GetNextPlayer(string currentPlayer)
        {
            string nextPlayer = "x";

            if (currentPlayer == "x")
            {
                nextPlayer = "o";
            }

            return nextPlayer;
        }

        public bool IsTie(List<string> board)
        {
            bool foundDigit = false;

            foreach (string value in board)
            {
                if (char.IsDigit(value[0]))
                {
                    foundDigit = true;
                    break;
                }
            }

            return !foundDigit;
        }

        public bool IsWinner(List<string> board, string player)
        {
            bool isWinner = false;

            if ((board[0] == player && board[1] == player && board[2] == player)
                || (board[3] == player && board[4] == player && board[5] == player)
                || (board[6] == player && board[7] == player && board[8] == player)
                || (board[0] == player && board[3] == player && board[6] == player)
                || (board[1] == player && board[4] == player && board[7] == player)
                || (board[2] == player && board[5] == player && board[8] == player)
                || (board[0] == player && board[4] == player && board[8] == player)
                || (board[2] == player && board[4] == player && board[6] == player)
                )
            {
                isWinner = true;
            }

            return isWinner; 
        }

        public bool IsGameOver(List<string> board)
        {
            bool isGameOver = false;

            if (IsWinner(board, "x") || IsWinner(board, "o") || IsTie(board))
            {
                isGameOver = true;
            }

            return isGameOver;
        }
    }

    class Program
    {
        public static TicTacToeGame Game = new TicTacToeGame();

        static void Main(string[] args)
        {
            List<string> board = Game.GenerateBoard();
            string currentPlayer = "x";

            while (!Game.IsGameOver(board))
            {
                Game.RenderBoard(board);

                int choice = Game.GetMoveChoice(currentPlayer);
                Game.MakeMove(board, choice, currentPlayer);

                currentPlayer = Game.GetNextPlayer(currentPlayer);
            }

            Game.RenderBoard(board);
            Console.WriteLine("Good game. Thanks for playing!");
        }
    }
}
