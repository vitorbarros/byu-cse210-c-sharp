using System;

namespace Unit03.Game.Utils
{
    public class Parachute
    {
        public static void Print(int incorrectGuesses)
        {
            int maxGuesses = 5;

            switch (maxGuesses - incorrectGuesses)
            {
                case 5:
                    Console.WriteLine(" ________");
                    Console.WriteLine("/        \\ ");
                    Console.WriteLine(" -------- ");
                    Console.WriteLine("\\        /");
                    Console.WriteLine(" \\      /");
                    Console.WriteLine("  \\    /");
                    Console.WriteLine("   \\  /");
                    Console.WriteLine("    O");
                    Console.WriteLine("   /\\ ");
                    Console.WriteLine("  /||\\ ");
                    Console.WriteLine("   /\\ ");
                    Console.WriteLine("  /  \\ ");
                    break;
                case 4:
                    Console.WriteLine(" -------- ");
                    Console.WriteLine("\\        /");
                    Console.WriteLine(" \\      /");
                    Console.WriteLine("  \\    /");
                    Console.WriteLine("   \\  /");
                    Console.WriteLine("    O");
                    Console.WriteLine("   /\\ ");
                    Console.WriteLine("  /||\\ ");
                    Console.WriteLine("   /\\ ");
                    Console.WriteLine("  /  \\ ");
                    break;
                case 3:
                    Console.WriteLine(" \\      /");
                    Console.WriteLine("  \\    /");
                    Console.WriteLine("   \\  /");
                    Console.WriteLine("    O");
                    Console.WriteLine("   /\\ ");
                    Console.WriteLine("  /||\\ ");
                    Console.WriteLine("   /\\ ");
                    Console.WriteLine("  /  \\ ");
                    break;
                case 2:
                    Console.WriteLine("  \\    /");
                    Console.WriteLine("   \\  /");
                    Console.WriteLine("    O");
                    Console.WriteLine("   /\\ ");
                    Console.WriteLine("  /||\\ ");
                    Console.WriteLine("   /\\ ");
                    Console.WriteLine("  /  \\ ");
                    break;               
                case 1:
                    Console.WriteLine("   \\  /");
                    Console.WriteLine("    O");
                    Console.WriteLine("   /\\ ");
                    Console.WriteLine("  /||\\ ");
                    Console.WriteLine("   /\\ ");
                    Console.WriteLine("  /  \\ ");
                    break;
                default:
                    Console.WriteLine("    X");
                    Console.WriteLine("   /\\ ");
                    Console.WriteLine("  /||\\ ");
                    Console.WriteLine("   /\\ ");
                    Console.WriteLine("  /  \\ ");
                    break;
            }
        }
    }
}