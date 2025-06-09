using System;
using System.Threading;

namespace MeowMeow_QuizGame
{
    class Books
    {
        public int RunQuiz()
        {
            Console.Clear();
            TypeLine("OH NO... YOU CHOSE THE BOOKS...", 60);
            TypeLine("Ancient texts surround you... whispers echo in the shadows...", 40);
            TypeLine("You have ONLY 1 LIFE. Just one mistake... and it's over.", 40);
            Console.WriteLine();
            Console.WriteLine("\nThis category holds questions from ETHICS, LAWS, and LITERATURE.");
            Console.WriteLine("Can you handle the pressure?\n");

            if (!AskQuestion(
                "1. In Charles Dickens’ *Oliver Twist*, what food does Oliver famously ask for more of?",
                new string[] { "a. soup", "b. water", "c. porridge", "d. alcohol" },
                "c"))
                return 0;

            if (!AskQuestion(
                "2. In Shakespeare’s *Romeo and Juliet*, what is the last name of Romeo?",
                new string[] { "a. Oberon", "b. Montague", "c. Juliet", "d. Capulet" },
                "b"))
                return 0;

            Console.WriteLine("\nThis is hard... Are you sure you want to continue?");

            if (!AskQuestion(
                "3. What is the longest word in English WITHOUT a vowel?",
                new string[] { "(Type your answer directly):" },
                "Twyndyllyngs", true))
                return 0;

            if (!AskQuestion(
                "4. It is defined as \"an act which proceeds from the deliberate free will of man\". What is it?",
                new string[] { "a. Human Act", "b. Act of Man", "c. Nature of Man", "d. Morality" },
                "a"))
                return 0;

            Console.WriteLine("\nWHOAAA... FINAL QUESTION APPROACHING.");
            Console.WriteLine("Take a deep breath. Your brain's sweating, isn't it?");

            if (!AskQuestion(
                "5. The Data Privacy Act of 2012 aims to protect personal information in the Philippines.\nWhat Republic Act number is this?",
                new string[] { "(Type your answer directly):" },
                "Republic Act No. 10173", true))
                return 0;

            Console.WriteLine("\nYepeyyy! You survived the Books quiz!");
            Console.WriteLine("Perfect score. You're sharp. Brilliant. Fearless.");
            Console.WriteLine("🎉 Congratsss you have 5 points!");
            return 5;
        }

        private bool AskQuestion(string question, string[] options, string correctAnswer, bool exactMatch = false)
        {
            Console.WriteLine("\n" + question);
            foreach (var option in options)
            {
                Console.WriteLine(option);
            }

            string userAnswer;
            while (true)
            {
                Console.Write("\nYour answer: ");
                userAnswer = Console.ReadLine().Trim().ToLower();

                if (exactMatch)
                    break;

                if (userAnswer == "a" || userAnswer == "b" || userAnswer == "c" || userAnswer == "d")
                    break;

                Console.WriteLine("Please enter a valid choice: a, b, c, or d.");
            }

            if (exactMatch)
            {
                if (userAnswer == correctAnswer.ToLower())
                {
                    Console.WriteLine("\nCorrect. You live... for now.");
                    return true;
                }
            }
            else
            {
                if (userAnswer == correctAnswer.ToLower())
                {
                    Console.WriteLine("\nCorrect. Moving on...");
                    return true;
                }
            }

            Console.WriteLine("\nWrong.");
            Console.WriteLine("Awww... ggs :< GAME OVER.");
            Console.WriteLine("😢 Oh no, you have 0 points.");
            return false;
        }

        private void TypeLine(string text, int delay)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
    }
}
