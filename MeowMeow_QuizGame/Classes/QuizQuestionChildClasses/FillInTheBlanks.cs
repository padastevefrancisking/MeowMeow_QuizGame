using MeowMeow_QuizGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeowMeow_QuizGame.Classes.QuizQuestionChildClasses
{
    public class FillInTheBlanks : QuizQuestion
    {
        public string QuestionAnswer;

        public FillInTheBlanks(string id, string text, string answer, QuestionDifficulty difficulty)
            : base(id, text, difficulty)
        {
            QuestionAnswer = answer;
        }

        public override bool CheckAnswer(string userAnswer)
        {
            if (!string.IsNullOrWhiteSpace(userAnswer))
            {
                return userAnswer.Equals(QuestionAnswer.Trim());
            }
            return false;
        }

        public override void DisplayAnswer(string userAnswer)
        {
            if(CheckAnswer(userAnswer))
            {
                Console.WriteLine("Correct! The answer is: " + QuestionAnswer);
            }
            else
            {
                Console.WriteLine("Incorrect. The correct answer is: " + QuestionAnswer);
            }
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{QuizQuestionID} (Fill in the Blanks)\n{QuizQuestionText}");
            Console.WriteLine("Please fill in the blanks with the correct answer.");
        }
    }
}
