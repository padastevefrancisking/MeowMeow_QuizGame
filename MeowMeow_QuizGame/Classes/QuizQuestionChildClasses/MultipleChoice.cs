using MeowMeow_QuizGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowMeow_QuizGame.Classes.QuizQuestionChildClasses
{
    public class MultipleChoice : QuizQuestion
    {
        public List<String> Choices;
        public int CorrectChoiceIndex;

        public MultipleChoice(string id, string text, List<string> choices, int correctChoiceIndex, QuestionDifficulty difficulty)
            : base(id, text, difficulty)
        {
            Choices = choices;
            CorrectChoiceIndex = correctChoiceIndex;
        }

        public override bool CheckAnswer(string userAnswer)
        {
            if (!string.IsNullOrWhiteSpace(userAnswer))
            {
                userAnswer = userAnswer.Trim().ToUpper();

                if (userAnswer.Length == 1 && userAnswer[0] >= 'A' && userAnswer[0] < 'A' + Choices.Count)
                {
                    int choiceIndex = userAnswer[0] - 'A';
                    return choiceIndex == CorrectChoiceIndex;
                }
            }

            return false;
        }

        public override void DisplayAnswer(string userAnswer)
        {
            if (CheckAnswer(userAnswer))
            {
                Console.WriteLine("Correct! The answer is: " + Choices[CorrectChoiceIndex]);
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is: " + Choices[CorrectChoiceIndex]);
            }
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{QuizQuestionID} (Multiple Choice)\n{QuizQuestionText}");
            for (int i = 0; i < Choices.Count; i++)
            {
                char letter = (char)('A' + i);
                Console.WriteLine($"[{letter}] {Choices[i]}");
            }
        }
    }
}
