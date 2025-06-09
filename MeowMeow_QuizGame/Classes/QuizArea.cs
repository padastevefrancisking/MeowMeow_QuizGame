using MeowMeow_QuizGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowMeow_QuizGame.Classes
{
    public class QuizArea
    {
        public string QuizAreaName;
        public string QuizAreaDescription;
        public PathDifficulty PathDifficulty;

        public List<QuizQuestion> QuizQuestions;

        public QuizArea(string name, string description, PathDifficulty difficulty)
        {
            QuizAreaName = name;
            QuizAreaDescription = description;
            PathDifficulty = difficulty;
            QuizQuestions = new List<QuizQuestion>();
        }

        public void AddQuizQuestion(QuizQuestion question)
        {
            QuizQuestions.Add(question);
        }

        public void PlayQuizArea(Player player)
        {
            foreach (var question in QuizQuestions)
            {
                Console.Clear();
                PrintBox($"Welcome to the {QuizAreaName} area!\n{QuizAreaDescription}");
                Console.WriteLine($"Path Difficulty: {PathDifficulty}\n");

                question.DisplayQuestion();
                Console.Write("Your answer: ");
                string userAnswer = Console.ReadLine();

                if (question.CheckAnswer(userAnswer))
                {
                    question.AddScore(player, question.Score);
                }

                question.DisplayAnswer(userAnswer);

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }

            Console.Clear();
            PrintBox($"{QuizAreaName} Area Cleared!");
            Console.WriteLine($"\nYour final score is: {player.Score}");
        }

        public void PrintBox(string message)
        {
            string[] lines = message.Split('\n');
            int maxLength = lines.Max(line => line.Length);
            int padding = 2;
            int boxWidth = maxLength + padding * 2;

            string border = "+" + new string('-', boxWidth) + "+";

            Console.WriteLine(border);
            foreach (var line in lines)
            {
                string paddedLine = line.PadLeft(line.Length + padding).PadRight(boxWidth);
                Console.WriteLine($"|{paddedLine}|");
            }
            Console.WriteLine(border);
        }
    }
}
