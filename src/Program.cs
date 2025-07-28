using System;

namespace QuizGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                Console.Clear();
                PrintTitle();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Choose game mode:");
                Console.WriteLine("1) Fixed difficulty");
                Console.WriteLine("2) Progressive difficulty");
                Console.ResetColor();
                Console.Write("Select: ");
                var modeChoice = Console.ReadLine();

                GameMode mode;
                int fixedDifficulty = 1;

                if (modeChoice == "1")
                {
                    mode = GameMode.FixedDifficulty;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Choose difficulty: 1) Easy 2) Medium 3) Hard");
                    Console.ResetColor();
                    Console.Write("Select: ");
                    if (!int.TryParse(Console.ReadLine(), out fixedDifficulty) || fixedDifficulty < 1 || fixedDifficulty > 3)
                        fixedDifficulty = 1;
                }
                else
                {
                    mode = GameMode.ProgressiveDifficulty;
                }

                var engine = new GameEngine(mode, fixedDifficulty);

                while (!engine.IsGameOver())
                {
                    var question = engine.GetNextQuestion();
                    if (question == null) break;

                    Console.WriteLine($"\n{question.Text}");
                    if (question.Choices != null)
                    {
                        char option = 'A';
                        foreach (var choice in question.Choices)
                        {
                            Console.WriteLine($"{option}) {choice}");
                            option++;
                        }
                    }

                    Console.Write("Your answer: ");
                    string answer = Console.ReadLine() ?? "";

                    engine.CheckAnswer(question, answer);
                    Console.WriteLine($"Score: {engine.Score} | Lives: {engine.Lives}");
                }

                Console.ForegroundColor = ConsoleColor.Red;
                if (engine.Lives <= 0)
                    Console.WriteLine("\nGame over! You ran out of lives.");
                else
                    Console.WriteLine("\nGame over! No more questions left.");
                Console.ResetColor();

                Console.Write("\nPlay again? (y/n): ");
                var restartChoice = Console.ReadLine()?.ToLower();
                playAgain = restartChoice == "y";
            }
        }

        static void PrintTitle()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
   ____  _                       __  __ _           _ 
  / ___|| |__   __ _ _ __ _ __  |  \/  (_)_ __   __| |
  \___ \| '_ \ / _` | '__| '_ \ | |\/| | | '_ \ / _` |
   ___) | | | | (_| | |  | |_) || |  | | | | | | (_| |
  |____/|_| |_|\__,_|_|  | .__/ |_|  |_|_|_| |_|\__,_|
                         |_|                                                         
");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("SharpMind");
            Console.WriteLine("Author: NikCraftsApps");
            Console.ResetColor();
        }
    }
}
