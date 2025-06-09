using System;

namespace MeowMeow_QuizGame
{
    class Ship
    {
        public int RunQuiz()
        {
            string[] questions = new string[]
            {
                "1. A system that all natural resources and means of production are privately owned. When one owns a business, he needs to outperform other competitors.",
                "2. Who was the origin of the phrase \"Let them eat cake\"?",
                "3. Why would 17th century Venetians gather every month to see sailors and fishermen meet on a bridge?",
                "4. The SDG's are a series of 17 goals fixed by the U.N. and adopted by 193 countries in 2015. What is the goal number that make cities and human settlements inclusive safe, resilient and sustainable?",
                "5. The SDG number , Quality Education, ensures inclusive and equitable quality education for all. By 2030, ensures equal access for all women and men to affordable and quality technical, vocational and tertiary education, including university. What target number is this?"
            };

            string[][] options = new string[][]
            {
                new string[] { "a. Capitalism", "b. Trade liberation", "c. Socialism", "d. Market Integration" },
                new string[] { "a. Maximilien Robespierre", "b. Jean-Jacques Rousseau", "c. Marie Antoinette", "d. King Louis XVI" },
                new string[] { "a. To sing", "b. To trade", "c. To dance", "d. To fight" },
                new string[] { "a. 11", "b. 9", "c. 10", "d. 13" },
                new string[] { "a. 4.1", "b. 4.2", "c. 4.3", "d. 4.4" }
            };

            string[] answers = { "a", "c", "d", "a", "c" };

            int score = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                string userAnswer = "";
                bool validInput = false;

                while (!validInput)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("|========================================================|");
                    Console.WriteLine("|                     Quiz Question                      |");
                    Console.WriteLine("|========================================================|");
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
            Console.WriteLine("Quiz Finished");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your score is {score}/{questions.Length}.");
            return score;
        }
    }
}