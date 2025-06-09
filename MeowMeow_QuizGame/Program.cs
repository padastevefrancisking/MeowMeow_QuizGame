using MeowMeow_QuizGame.Classes;
using MeowMeow_QuizGame.Classes.QuizQuestionChildClasses;
using MewMeow_QuizGame.Classes.Underground;
using System;
using System.Collections.Generic;
using static System.Reflection.Metadata.BlobBuilder;

namespace MeowMeow_QuizGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            HashSet<int> completedQuizzes = new HashSet<int>();
            int totalScore = 0;

            QuizArea quizArea = new QuizArea(
                "Jungle",
                "It contains differential and integral calculus, and differential equations questions.", Enums.PathDifficulty.LEGENDARY
            );

            List<QuizQuestion> questions = new List<QuizQuestion>
            {
                new FillInTheBlanks(
                    "DCQ1P2",
                    "What is the derivative of x^2?",
                    "16cos(4x)+(3x^2/(x^3+2))",
                    Enums.QuestionDifficulty.LEVEL_3
                ),
                new MultipleChoice(
                    "CMQ2P1",
                    "Given that a circle has 2pi radians, how many degrees are equal to pi/12 radians?",
                    new List<string> { "6 degrees", "15 degrees", "12 degrees", "20 degrees" },
                    0,
                    Enums.QuestionDifficulty.LEVEL_1
                )
            };

            foreach (var question in questions)
            {
                quizArea.AddQuizQuestion(question);
            }

            while (!exit)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Welcome to the Mewmew Game!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your Current Score: {totalScore}");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Choose a quiz to play:");

                Console.ForegroundColor = ConsoleColor.Cyan;
                if (!completedQuizzes.Contains(1)) Console.WriteLine("1. Underground");
                if (!completedQuizzes.Contains(2)) Console.WriteLine("2. Books");
                if (!completedQuizzes.Contains(3)) Console.WriteLine("3. Ship");
                if (!completedQuizzes.Contains(4)) Console.WriteLine("4. Jungle");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("0. Exit");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (completedQuizzes.Contains(1))
                        {
                            Console.WriteLine("You have already completed this quiz. Choose another one.");
                        }
                        else
                        {
                            Underground underground = new Underground();
                            totalScore += underground.RunQuiz();
                            completedQuizzes.Add(1);
                        }
                        break;
                    case "2":
                        if (completedQuizzes.Contains(2))
                        {
                            Console.WriteLine("You have already completed this quiz. Choose another one.");
                        }
                        else
                        {
                            Books books = new Books();
                            totalScore += books.RunQuiz();
                            completedQuizzes.Add(2);
                        }
                        break;
                    case "3":
                        if (completedQuizzes.Contains(3))
                        {
                            Console.WriteLine("You have already completed this quiz. Choose another one.");
                        }
                        else
                        {
                            Ship ship = new Ship();
                            totalScore += ship.RunQuiz();
                            completedQuizzes.Add(3);
                        }
                        break;
                    case "4":
                        if (completedQuizzes.Contains(4))
                        {
                            Console.WriteLine("You have already completed this quiz. Choose another one.");
                        }
                        else
                        {
                            Player player = new Player("Player1");
                            quizArea.PlayQuizArea(player);
                            totalScore += player.Score;
                            completedQuizzes.Add(4);
                        }
                        break;
                    case "0":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYou chose to leave... For now. Goodbye.");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (!exit && completedQuizzes.Count < 4)
                {
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                }
                else if (completedQuizzes.Count >= 4)
                {
                    Console.WriteLine("\nAll quizzes have been completed! Exiting the game. Goodbye!");
                    exit = true;
                }
            }
        }
    }
}