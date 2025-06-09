using System;

namespace MewMeow_QuizGame.Classes.Underground
{
    class Underground
    {
        public int RunQuiz()
        {
            string[] questions = new string[]
            {
                "1. Which city is the first to use landscape architecture as a design concept?",
                "2. It is the building frame construction system that uses one-piece structural stud from the foundation to the roof:",
                "3. A Benguet pine wood is used as post to support an average load of 29,400 pounds, 5 feet high. If the timber has a compressive stress of 700 psi, what would be the typical size of the timber support most economical to be used for the purpose?",
                "4. It is the manner of arranging and coordinating the parts of a composition so as to produce a coherent image. This determines the overall shape, size, and arrangement of the elements.",
                "5. The foundation in which a cantilever beam is provided to join two footings is known as:"
            };

            string[][] options = new string[][]
            {
                new string[] { "a. Versailles", "b. London", "c. Dorset", "d. Warsaw" },
                new string[] { "a. Lath framing", "b. Wall framing", "c. Balloon framing", "d. Upright framing" },
                new string[] { "a. 4x5 inches", "b. 6x7 inches", "c. 5x6 inches", "d. 7x4 inches" },
                new string[] { "a. Structure", "b. Form", "c. Organization", "d. Composition" },
                new string[] { "a. Strap footing", "b. Raft footing", "c. Combined footing", "d. Strip footing" }
            };

            string[] answers = { "a", "c", "b", "b", "a" };

            int score = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                string userAnswer = "";
                bool validInput = false;

                while (!validInput)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║                     Quiz Question                      ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(questions[i]);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (var option in options[i])
                    {
                        Console.WriteLine(option);
                    }
                    Console.ResetColor();

                    Console.Write("Enter your answer (a/b/c/d): ");
                    userAnswer = Console.ReadLine().Trim().ToLower();

                    if (userAnswer == "a" || userAnswer == "b" || userAnswer == "c" || userAnswer == "d")
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input. Please enter only a, b, c, or d.");
                        Console.ResetColor();
                        Console.WriteLine("\nPress Enter to try again...");
                        Console.ReadLine();
                    }
                }

                if (userAnswer == answers[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong. The correct answer is {answers[i]}.");
                }
                Console.ResetColor();

                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   Quiz Completed!                      ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your score is {score}/{questions.Length}.");
            return score;
        }
    }
}
